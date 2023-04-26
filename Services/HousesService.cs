namespace spring23_gregslist_cSharp.Controllers;

public class HousesService
{

    private readonly HousesRepository _housesRepo;

    public HousesService(HousesRepository housesRepo)
    {
        _housesRepo = housesRepo;
    }
}
