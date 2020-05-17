using ApiWallet.Data;
using ApiWallet.Models;

namespace ApiWallet.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FundosController : ControllerBase
    {
        private readonly DataContext _context;

        public FundosController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Fundo>>> GetFundoss()
        {
            return await _context.Fundos.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Fundo>> GetFundo(int id)
        {
            var fundo = await _context.Fundos.FindAsync(id);

            if (fundo == null)
            {
                return NotFound();
            }

            return fundo;
        }

        [HttpPost]
        public async Task<ActionResult<Fundo>> PostFund(Fundo fundo)
        {
            _context.Fundos.Add(fundo);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetFundo", new { id = fundo.FundoId }, fundo);
        }

    }
}
