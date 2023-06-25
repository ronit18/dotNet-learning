namespace dotNetRpg.CharacterServices
{
	public class CharacterServices : ICharacterService
	{
		private static List<Character> characters = new List<Character>{
			new Character(),
			new Character{Id=1,Name="Ronit"}

		};
		public async Task<List<Character>> GetAllCharacters()
		{
			return characters;
		}
		public async Task<Character> GetCharacterById(int id)
		{
			return characters.FirstOrDefault(c => c.Id == id)!;
		}

		public async Task<List<Character>> AddCharacter(Character newCharacter)
		{
			characters.Add(newCharacter);
			return characters;
		}


	}
}