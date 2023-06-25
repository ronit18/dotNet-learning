namespace dotNetRpg.CharacterServices
{
	public interface ICharacterService
	{
		List<Character> GetAllCharacters();
		Character GetCharacterById(int id);
		List<Character> AddCharacter(Character newCharacter);
	}
}