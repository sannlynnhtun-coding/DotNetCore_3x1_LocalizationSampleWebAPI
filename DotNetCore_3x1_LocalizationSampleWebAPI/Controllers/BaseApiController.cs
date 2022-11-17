using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetCore_3x1_LocalizationSampleWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BaseApiController : ControllerBase
    {
        private readonly IStringLocalizer<BaseApiController> localizer;
        public BaseApiController(IStringLocalizer<BaseApiController> localizer)
        {
            this.localizer = localizer;
        }
    }
}
