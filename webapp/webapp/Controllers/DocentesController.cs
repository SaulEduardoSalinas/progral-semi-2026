using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using webapp.Models;

[Route("api/[controller]")]
[ApiController]
public class DocentesController : ControllerBase
{
    private readonly MyDbContext _context;
    public DocentesController(MyDbContext context)
    {
        _context = context;
    }

    // GET: api/Docentes
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Docente>>> GetDocentes()
    {
        return await _context.Docentes.ToListAsync();
    }

    // GET: api/Docentes/buscar?buscar=juan
    [HttpGet("buscar")]
    public async Task<ActionResult<IEnumerable<Docente>>> BuscarDocente([FromQuery] string? buscar)
    {
        var consulta = _context.Docentes.AsQueryable();
        if (!string.IsNullOrEmpty(buscar))
        {
            consulta = consulta.Where(docente => docente.nombre!.Contains(buscar) || docente.codigo!.Contains(buscar));
        }
        return await consulta.ToListAsync();
    }

    // GET: api/Docentes/5
    [HttpGet("{iddocente}")]
    public async Task<ActionResult<Docente>> GetDocente(int iddocente)
    {
        var docente = await _context.Docentes.FindAsync(iddocente);
        if (docente == null)
        {
            return NotFound();
        }
        return docente;
    }

    // PUT: api/Docentes/5
    [HttpPut("{iddocente}")]
    public async Task<IActionResult> PutDocente(int iddocente, Docente docente)
    {
        if (iddocente != docente.idDocente)
        {
            return BadRequest();
        }
        _context.Entry(docente).State = EntityState.Modified;
        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!_context.Docentes.Any(e => e.idDocente == iddocente))
            {
                return NotFound();
            }
            throw;
        }
        return CreatedAtAction("GetDocente", new { iddocente = docente.idDocente }, docente);
    }

    // POST: api/Docentes
    [HttpPost]
    public async Task<ActionResult<Docente>> PostDocente(Docente docente)
    {
        _context.Docentes.Add(docente);
        await _context.SaveChangesAsync();
        return CreatedAtAction("GetDocente", new { iddocente = docente.idDocente }, docente);
    }

    // DELETE: api/Docentes/5
    [HttpDelete("{iddocente}")]
    public async Task<IActionResult> DeleteDocente(int iddocente)
    {
        var docente = await _context.Docentes.FindAsync(iddocente);
        if (docente == null)
        {
            return NotFound();
        }
        _context.Docentes.Remove(docente);
        await _context.SaveChangesAsync();
        return NoContent();
    }
}
