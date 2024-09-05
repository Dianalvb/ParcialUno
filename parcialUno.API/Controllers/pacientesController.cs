using Microsoft.AspNetCore.Mvc;
using parcialUno.API.Data;

namespace parcialUno.API.Controllers
{
    [ApiController]
    [Route("/api/pacientes")]
    public class pacientesController : ControllerBase
    {
        private readonly DataContext dataContext;

        public pacientesController(DataContext dataContext)
        {
            this.dataContext = dataContext;
        }
    }
}
