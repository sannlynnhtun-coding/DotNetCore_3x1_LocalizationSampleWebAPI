using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;

namespace DotNetCore_3x1_LocalizationSampleWebAPI.Controllers
{
    [Route("{culture:culture}/[controller]")]
    [ApiController]
    public class HomeController : BaseApiController
    {
        private readonly IStringLocalizer<BaseApiController> _localizer;

        public HomeController(IStringLocalizer<BaseApiController> localizer) : base(localizer)
        {
            _localizer = localizer;
        }

        public string Get()
        {           
            return _localizer["Home"];
        }
    }
}