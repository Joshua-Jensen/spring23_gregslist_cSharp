using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace spring23_gregslist_cSharp.Controllers;

[ApiController]
[Route("api/[controller]")]
public class HouseController : ControllerBase
{
    private readonly HousesService _housesService;

    public HouseController(HousesService housesService)
    {
        _housesService = housesService;
    }




}
