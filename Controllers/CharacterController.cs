using Microsoft.AspNetCore.Mvc;

namespace dotNetRpg.Controllers
{
	[ApiController]
	[Route("api/[controller]")]
	public class CharacterController : ControllerBase
	{
		private static List<Character> characters = new List<Character>{
			new Character(),
			new Character{Id=1,Name="Ronit"}

		};

		[HttpGet("get")]
		public ActionResult<List<Character>> Getall()
		{
			try
			{
				return Ok(characters);
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
				return Ok(characters.FirstOrDefault(c => c.Id == id));
			}
			catch (System.Exception)
			{
				return BadRequest("Bad Request");
			}
		}
	}
}