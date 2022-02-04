using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Braille
{
    class Program
    {
        static void Main(string[] args)
        {
            BrailleBuilder braille = new BrailleBuilder(1000, 1000, 50, true, Color.White);
            braille.appendText("готово", Alphabet.RUSSIA);
            braille.Build().Save("result.png");

            braille.Clear(Color.White);
            braille.appendText("hello", Alphabet.ENGLISH);
            braille.Build().Save("result2.png");
        }

    }
}
