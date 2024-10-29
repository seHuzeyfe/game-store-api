using System.ComponentModel.DataAnnotations;

namespace GAME_STORE_API.Dtos;

public record class CreateGameDto
(   
    //Data notations
    [Required][StringLength(50)]string Name,
    [Required][StringLength(20)]string Genre,
    [Range(1,100)]decimal Price,
    DateOnly ReleaseDate
);
