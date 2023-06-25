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
		public ActionResult<List<Character>> Getall()
		{
			try
			{
				return Ok(_characterService.GetAllCharacters());
			}
			catch (System.Exception)
			{
				return BadRequest("Bad Request");
			}
		}

		[HttpGet("get/{id:int}")]
		public ActionResult<List<Character>> GetSingle(int id)
		{
			try
			{
				return Ok(_characterService.GetCharacterById(id));
			}
			catch (System.Exception)
			{
				return BadRequest("Bad Request");
			}
		}

		[HttpPost("create")]
		public ActionResult<List<Character>> AddCharacter([FromBody] Character newCharacter)
		{
			try
			{
				return Ok(_characterService.AddCharacter(newCharacter));
			}
			catch (System.Exception)
			{
				return BadRequest("Bad Request");
			}
		}
	}
}