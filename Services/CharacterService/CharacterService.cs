namespace dotNetRpg.CharacterServices
{
	public class CharacterServices : ICharacterService
	{
		private static List<Character> characters = new List<Character>{
			new Character(),
			new Character{Id=1,Name="Ronit"}

		};
		public List<Character> GetAllCharacters()
		{
			return characters;
		}
		public Character GetCharacterById(int id)
		{
			return characters.FirstOrDefault(c => c.Id == id)!;
		}

		public List<Character> AddCharacter(Character newCharacter)
		{
			characters.Add(newCharacter);
			return characters;
		}


	}
}