using Microsoft.AspNetCore.Mvc;

namespace dotNetRpg.Controllers
{
	[ApiController]
	[Route("api/[controller]")]
	public class CharacterController : ControllerBase
	{
		private readonly ICharacterService _characterService;

		public CharacterController(ICharacterService characterService)
		{
			_characterService = characterService;

		}


		[HttpGet("get")]
		[ProducesResponseType(200)]
		[ProducesResponseType(500)]
		public async Task<ActionResult<ServiceResponse<List<Character>>>> Getall()
		{
			try
			{
				return Ok(await _characterService.GetAllCharacters());
			}
			catch (Exception)
			{
				return StatusCode(500, "Bad Request");
			}
		}

		[HttpGet("get/{id:int}")]
		[ProducesResponseType(200)]
		[ProducesResponseType(500)]
		public async Task<ActionResult<ServiceResponse<List<Character>>>> GetSingle(int id)
		{
			try
			{
				return Ok(await _characterService.GetCharacterById(id));
			}
			catch (Exception)
			{
				return StatusCode(500, "Bad Request");
			}
		}

		[HttpPost("create")]
		[ProducesResponseType(200)]
		[ProducesResponseType(500)]
		public async Task<ActionResult<ServiceResponse<List<Character>>>> AddCharacter([FromBody] Character newCharacter)
		{
			try
			{
				return Ok(await _characterService.AddCharacter(newCharacter));
			}
			catch (Exception)
			{
				return StatusCode(500, "Bad Request");
			}
		}
	}
}