using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApi_KruggerChallenge.Models;

namespace WebApi_KruggerChallenge.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SectorController(KruggerDbContext context) : ControllerBase
    {
        private readonly KruggerDbContext _context = context;

        //Listar sectores
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var sectores = await _context.Sector.ToListAsync();
            if (sectores.Any())
            {
                return Ok(new Response<IEnumerable<Sector>>
                {
                    IsSuccess = true,
                    Result = sectores,
                    Message = "Listado de Sectores"
                });
            }
            return Ok(new Response<IEnumerable<Sector>>
            {
                IsSuccess = false,
                Message = "No tiene registros",
                Result = []
            });
        }

        //Registrar sectores
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] CrearActualizarSector model)
        {
            var sectorNuevo = new Sector
            {
               hora_inicio = model.hora_inicio,
               hora_fin = model.hora_fin,
               nombre_sector = model.nombre_sector,
               sec_long = model.sec_long,
               sec_lat = model.sec_lat,
            };
            await _context.Sector.AddAsync(sectorNuevo);
            await _context.SaveChangesAsync();

            return Ok(new Response<Sector>
            {
                IsSuccess = false,
                Result = sectorNuevo,
                Message = "Sector registrado correctamente"
            });
        }

    }
}
