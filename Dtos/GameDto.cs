namespace GAME_STORE_API.Dtos;

public record class GameDto(
    int Id,
    string name,
    string genre,
    decimal Price,
    DateOnly ReleaseDate
);
