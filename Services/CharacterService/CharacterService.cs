namespace dotNetRpg.CharacterServices
{
	public class CharacterServices : ICharacterService
	{
		private static List<Character> characters = new List<Character>{
			new Character(),
			new Character{Id=1,Name="Ronit"}

		};
		public async Task<ServiceResponse<List<Character>>> GetAllCharacters()
		{
			var ServiceResponse = new ServiceResponse<List<Character>>();
			ServiceResponse.Data = characters;
			return ServiceResponse;
		}
		public async Task<ServiceResponse<Character>> GetCharacterById(int id)
		{
			var ServiceResponse = new ServiceResponse<Character>();
			var character = characters.FirstOrDefault(c => c.Id == id)!;
			ServiceResponse.Data = character;
			return ServiceResponse;
		}

		public async Task<ServiceResponse<List<Character>>> AddCharacter(Character newCharacter)
		{
			var ServiceResponse = new ServiceResponse<List<Character>>();
			characters.Add(newCharacter);
			ServiceResponse.Data = characters;
			return ServiceResponse;
		}


	}
}