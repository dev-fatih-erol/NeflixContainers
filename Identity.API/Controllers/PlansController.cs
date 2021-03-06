﻿using System.Collections.Generic;
using System.Threading.Tasks;
using Identity.API.Application;
using Identity.Domain.Model;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Subscription.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlansController
    {
        private readonly IPlanQueries _planQueries;

        public PlansController(IPlanQueries planQueries)
        {
            _planQueries = planQueries;
        }

        [HttpGet]
        [ProducesResponseType(typeof(IEnumerable<SubscriptionPlan>), 200)]
        [AllowAnonymous]
        public async Task<IEnumerable<SubscriptionPlan>> GetPlans()
        {
            return await _planQueries.GetAllPlans();
        }
    }
}
