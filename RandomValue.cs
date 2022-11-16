using System;
using System.Text;

namespace RandomValueGenerator
{
    public class RandomValue
    {

        public string Randomize(int length = 0)
        {

            Random random = new Random();
            var builder = new StringBuilder(length != 0 ? length : 100);


            // char is a single Unicode character  
            char offset = 'a';
            const int lettersOffset = 26; // A...Z or a..z: length=26  

            for (var i = 0; i < length; i++)
            {
                var @char = (char)random.Next(offset, offset + lettersOffset);
                builder.Append(@char);
            }

            return builder.ToString().ToLower();

        }
    }
}