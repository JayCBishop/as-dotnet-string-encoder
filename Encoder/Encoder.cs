using System;
using System.Linq;
using System.Text;

namespace Encoder
{
    public class EncoderProcessor
    {
        public string Encode(string message)
        {
            var lowerCaseMessage = message.ToLower();

            var encodedMessageBuilder = new StringBuilder();
            for (int index = 0; index < lowerCaseMessage.Length; index++)
            {
                var character = lowerCaseMessage.ElementAt(index);
                
                if (char.IsDigit(character))
                {
                    var numberSequence = NumberSequence.FromSequenceStart(lowerCaseMessage.Substring(index));
                    encodedMessageBuilder.Append(numberSequence.Reverse());
                    index += (numberSequence.Length - 1);
                    continue;
                } 
                
                encodedMessageBuilder.Append(EncodeCharacter(character));
            }

            return encodedMessageBuilder.ToString();
        }

        public char EncodeCharacter(char character)
        {

            if (character.IsVowel())
            {
                return (char)Enum.Parse<Vowel>(character.ToString());
            }

            if (character == 'y')
            {
                return ' ';
            }

            if (character == ' ')
            {
                return 'y';
            }

            if (char.IsLetter(character))
            {
                return character.DecrementCharacter();
            }

            return character;
        }
    }
}
