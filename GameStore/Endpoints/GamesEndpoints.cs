using System;
using GameStore.Dtos;

namespace GameStore.Endpoints;

public static class GamesEndpoints
{
    const string GetGameEndpointName = "GetGame";
    private static readonly List<GameDto> games = [
    new (
        1,
        "Street Figther II",
        "Fighting",
        19.99M,
        new DateOnly(1992, 7, 15)),
    new (
        2,
        "Final Fantasy XIV",
        "Roleplating",
        59.99M,
        new DateOnly(2010, 9, 30)),
    new (
        3,
        "FIFA 2023",
        "Sports",
        69.99M,
        new DateOnly(2022, 9, 27))
];

public static WebApplication MapGamesEndpoints(this WebApplication app)
{

}


}
