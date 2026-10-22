using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace Parcial2_2
{
    public class Conexion_base_datos
    {
        public static string CadenaConexion =
               @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True";

        public const char AGREGAR = 'A';
        public const char MODIFICAR = 'M';
        public const char ELIMINAR = 'E';

        public DataSet crearDs()
        {
            DataSet ds = new DataSet("dsSistema");
            var consultas = new Dictionary<string, string>
            {
                { "usuarios", "SELECT idUsuario, usuario, clave, nombre, direccion, telefono FROM usuarios_USSS139126 ORDER BY usuario" },
                { "alumnos",  "SELECT idAlumno, codigo, nombre, direccion, telefono FROM alumnos ORDER BY nombre" },
                { "materias", "SELECT idMateria, codigo, nombre, uv FROM materias ORDER BY codigo" },
                { "periodos", "SELECT idPeriodo, periodo, fecha FROM periodos ORDER BY fecha" }
            };

            using (SqlConnection cn = new SqlConnection(CadenaConexion))
            {
                foreach (KeyValuePair<string, string> consulta in consultas)
                {
                    using (SqlDataAdapter da = new SqlDataAdapter(consulta.Value, cn))
                    {
                        da.MissingSchemaAction = MissingSchemaAction.AddWithKey;
                        da.Fill(ds, consulta.Key);
                    }
                }
            }
            return ds;
        }

        public int mantenimiento_usuarios_USSS139126(char operacion, Dictionary<string, object> campos)
        {
            return mantenimiento("usuarios_USSS139126", "idUsuario", operacion, campos);
        }

        public int mantenimientoAlumnos(char operacion, Dictionary<string, object> campos)
        {
            return mantenimiento("alumnos", "idAlumno", operacion, campos);
        }

        public int mantenimientoMaterias(char operacion, Dictionary<string, object> campos)
        {
            return mantenimiento("materias", "idMateria", operacion, campos);
        }

        private int mantenimiento(string tabla, string llave, char operacion, Dictionary<string, object> campos)
        {
            List<string> columnas = campos.Keys.Where(k => k != llave).ToList();
            string sql;

            switch (operacion)
            {
                case AGREGAR:
                    sql = "INSERT INTO " + tabla + " (" + string.Join(", ", columnas) + ") VALUES (" +
                          string.Join(", ", columnas.Select(c => "@" + c)) + ")";
                    break;
                case MODIFICAR:
                    sql = "UPDATE " + tabla + " SET " + string.Join(", ", columnas.Select(c => c + " = @" + c)) +
                          " WHERE " + llave + " = @" + llave;
                    break;
                case ELIMINAR:
                    sql = "DELETE FROM " + tabla + " WHERE " + llave + " = @" + llave;
                    break;
                default:
                    throw new ArgumentException("Operación no válida: " + operacion);
            }
            return procesar(sql, campos);
        }

        public int procesar(string sql, Dictionary<string, object> parametros)
        {
            using (SqlConnection cn = new SqlConnection(CadenaConexion))
            using (SqlCommand cmd = new SqlCommand(sql, cn))
            {
                foreach (KeyValuePair<string, object> p in parametros)
                {
                    cmd.Parameters.AddWithValue("@" + p.Key, p.Value ?? DBNull.Value);
                }
                cn.Open();
                return cmd.ExecuteNonQuery();
            }
        }

        public int guardarPeriodos(DataTable periodos)
        {
            using (SqlConnection cn = new SqlConnection(CadenaConexion))
            using (SqlDataAdapter da = new SqlDataAdapter("SELECT idPeriodo, periodo, fecha FROM periodos", cn))
            using (SqlCommandBuilder constructor = new SqlCommandBuilder(da))
            {
                constructor.ConflictOption = ConflictOption.OverwriteChanges;
                return da.Update(periodos);
            }
        }

        public DataTable notasDe(int idMateria, int idPeriodo)
        {
            const string sql =
                "SELECT d.idDetalle, a.nombre, d.lab1, d.lab2, d.parcial " +
                "FROM dnotas d " +
                "JOIN notas n ON n.idNota = d.idNota " +
                "JOIN alumnos a ON a.idAlumno = n.idAlumno " +
                "WHERE n.idPeriodo = @idPeriodo AND d.idMateria = @idMateria " +
                "ORDER BY a.nombre";

            DataTable tabla = new DataTable("notas");
            using (SqlConnection cn = new SqlConnection(CadenaConexion))
            using (SqlDataAdapter da = new SqlDataAdapter(sql, cn))
            {
                da.SelectCommand.Parameters.AddWithValue("@idPeriodo", idPeriodo);
                da.SelectCommand.Parameters.AddWithValue("@idMateria", idMateria);
                da.Fill(tabla);
            }
            return tabla;
        }

        public int guardarNotas(DataTable notas)
        {
            int guardadas = 0;
            foreach (DataRow fila in notas.Rows)
            {
                if (fila.RowState != DataRowState.Modified) continue;

                guardadas += procesar(
                    "UPDATE dnotas SET lab1 = @lab1, lab2 = @lab2, parcial = @parcial WHERE idDetalle = @idDetalle",
                    new Dictionary<string, object>
                    {
                        { "lab1", fila["lab1"] },
                        { "lab2", fila["lab2"] },
                        { "parcial", fila["parcial"] },
                        { "idDetalle", fila["idDetalle"] }
                    });
            }
            notas.AcceptChanges();
            return guardadas;
        }

        public string iniciarSesion(string usuario, string clave)
        {
            const string sql =
                "SELECT nombre FROM usuarios_USSS139126 " +
                "WHERE usuario = @usuario AND clave = @clave COLLATE Latin1_General_CS_AS";

            using (SqlConnection cn = new SqlConnection(CadenaConexion))
            using (SqlCommand cmd = new SqlCommand(sql, cn))
            {
                cmd.Parameters.Add("@usuario", SqlDbType.VarChar, 35).Value = usuario;
                cmd.Parameters.Add("@clave", SqlDbType.VarChar, 35).Value = clave;
                cn.Open();

                using (SqlDataReader lector = cmd.ExecuteReader())
                {
                    if (lector.Read())
                    {
                        return lector.GetString(0);
                    }
                }
            }
            return null;
        }
    }
}
