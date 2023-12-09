﻿using rpgAPI.Dtos.Character;
using rpgAPI.Models;

namespace rpgAPI.Services.CharacterService
{
    public interface ICharacterService
    {
       Task<ServiceResponse<List<GetCharacterDto>>> GetAllCharacters();
        Task<ServiceResponse<GetCharacterDto>> GetCharacterById(int id);
        Task<ServiceResponse<List<GetCharacterDto>>> AddCharacter(AddCharacterDto newCharacter);
     
    }
}
