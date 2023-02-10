namespace AdventOfCode2022.Day03;

public static class CharacterToIntegerConverter
{
    private const int UpperCaseAsciiOffset = 38;
    private const int LowerCaseAsciiOffset = 96;
    public static int Convert(char character) => char.IsUpper(character) ? character - UpperCaseAsciiOffset : character - LowerCaseAsciiOffset;
}