using System.Linq;

namespace Encoder
{
    public class NumberSequence
    {
        public string Sequence { get; }

        public int Length => Sequence.Length;

        private NumberSequence(string sequence)
        {
            Sequence = sequence;
        }

        public static NumberSequence FromSequenceStart(string message)
        {
            string sequence  = string.Empty;

            foreach (char character in message)
            {
                if (char.IsDigit(character))
                {
                    sequence += character;
                }
                else
                {
                    break;
                }
            }

            return new NumberSequence(sequence);
        }

        public string Reverse()
        {
            return string.Concat(Sequence.Reverse());
        }
    }
}
