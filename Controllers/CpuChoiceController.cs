using LazarB_Challenge_RockPaperScissorLizardSpock_Endpoint.Services;
using Microsoft.AspNetCore.Mvc;

namespace LazarB_Challenge_RockPaperScissorLizardSpock_Endpoint.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CpuChoiceController : ControllerBase
    {
        private readonly CpuChoiceServices _cpuChoiceServices;

        public CpuChoiceController(CpuChoiceServices cpuChoiceServices){
            _cpuChoiceServices = cpuChoiceServices;
        }

        [HttpPost]
        [Route("CpuDecision")]

        public string CpuDesicion(){
            return _cpuChoiceServices.CpuGo();
        }
    }
}