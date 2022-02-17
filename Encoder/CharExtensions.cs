using System;

namespace Encoder
{
    public static class CharExtensions
    {
        public static bool IsVowel(this char character)
        {
            return Enum.IsDefined(typeof(Vowel), character.ToString());
        }

        public static char DecrementCharacter(this char character)
        {
            return (char)(Convert.ToInt32(character) - 1);
        }
    }
}
