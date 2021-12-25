using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Braille
{
    class BrailleAlphabet
    {
        public static List<alphabetBrailleStruct> RUSSIA = new List<alphabetBrailleStruct>
        {
            new alphabetBrailleStruct
            {
                symbol = 'а',
                cell = new List<int>
                {
                    1,0,0,0,0,0
                }
            },
            new alphabetBrailleStruct
            {
                symbol = 'б',
                cell = new List<int>
                {
                    1,1,0,0,0,0
                }
            },
            new alphabetBrailleStruct
            {
                symbol = 'в',
                cell = new List<int>
                {
                    0,1,0,1,1,1
                }
            },
            new alphabetBrailleStruct
            {
                symbol = 'г',
                cell = new List<int>
                {
                    1,1,0,1,1,0
                }
            },
            new alphabetBrailleStruct
            {
                symbol = 'д',
                cell = new List<int>
                {
                    1,0,0,1,1,0
                }
            },
            new alphabetBrailleStruct
            {
                symbol = 'е',
                cell = new List<int>
                {
                    1,0,0,0,1,0
                }
            },
            new alphabetBrailleStruct
            {
                symbol = 'ё',
                cell = new List<int>
                {
                    1,0,0,0,0,1
                }
            },
            new alphabetBrailleStruct
            {
                symbol = 'ж',
                cell = new List<int>
                {
                    0,1,0,1,1,0
                }
            },
            new alphabetBrailleStruct
            {
                symbol = 'з',
                cell = new List<int>
                {
                    1,0,1,0,1,1
                }
            },
            new alphabetBrailleStruct
            {
                symbol = 'и',
                cell = new List<int>
                {
                    0,1,0,1,0,0
                }
            },
            new alphabetBrailleStruct
            {
                symbol = 'й',
                cell = new List<int>
                {
                    1,1,1,1,0,1
                }
            },
            new alphabetBrailleStruct
            {
                symbol = 'к',
                cell = new List<int>
                {
                    1,0,1,0,0,0
                }
            },
            new alphabetBrailleStruct
            {
                symbol = 'л',
                cell = new List<int>
                {
                    1,1,1,0,0,0
                }
            },
            new alphabetBrailleStruct
            {
                symbol = 'м',
                cell = new List<int>
                {
                    1,0,1,1,0,0
                }
            },
            new alphabetBrailleStruct
            {
                symbol = 'н',
                cell = new List<int>
                {
                    1,0,1,1,1,0
                }
            },
            new alphabetBrailleStruct
            {
                symbol = 'о',
                cell = new List<int>
                {
                    1,0,1,0,1,0
                }
            },
            new alphabetBrailleStruct
            {
                symbol = 'п',
                cell = new List<int>
                {
                    1,1,1,1,0,0
                }
            },
            new alphabetBrailleStruct
            {
                symbol = 'р',
                cell = new List<int>
                {
                    1,1,1,0,1,0
                }
            },
            new alphabetBrailleStruct
            {
                symbol = 'с',
                cell = new List<int>
                {
                    0,1,1,1,0,0
                }
            },
            new alphabetBrailleStruct
            {
                symbol = 'т',
                cell = new List<int>
                {
                    0,1,1,1,1,0
                }
            },
            new alphabetBrailleStruct
            {
                symbol = 'у',
                cell = new List<int>
                {
                    1,0,1,0,0,1
                }
            },
            new alphabetBrailleStruct
            {
                symbol = 'ф',
                cell = new List<int>
                {
                    1,1,0,1,0,0
                }
            },
            new alphabetBrailleStruct
            {
                symbol = 'х',
                cell = new List<int>
                {
                    1,1,0,0,1,0
                }
            },
            new alphabetBrailleStruct
            {
                symbol = 'ц',
                cell = new List<int>
                {
                    1,0,0,1,0,0
                }
            },
            new alphabetBrailleStruct
            {
                symbol = 'ч',
                cell = new List<int>
                {
                    1,1,1,1,1,0
                }
            },
            new alphabetBrailleStruct
            {
                symbol = 'ш',
                cell = new List<int>
                {
                    1,0,0,0,1,1
                }
            },
            new alphabetBrailleStruct
            {
                symbol = 'щ',
                cell = new List<int>
                {
                    1,0,1,1,0,1
                }
            },
            new alphabetBrailleStruct
            {
                symbol = 'ъ',
                cell = new List<int>
                {
                    1,1,1,0,1,1
                }
            },
            new alphabetBrailleStruct
            {
                symbol = 'ы',
                cell = new List<int>
                {
                    0,1,1,1,0,1
                }
            },
            new alphabetBrailleStruct
            {
                symbol = 'ь',
                cell = new List<int>
                {
                    0,1,1,1,1,1
                }
            },
            new alphabetBrailleStruct
            {
                symbol = 'э',
                cell = new List<int>
                {
                    0,1,0,1,0,1
                }
            },
            new alphabetBrailleStruct
            {
                symbol = 'ю',
                cell = new List<int>
                {
                    1,1,0,0,1,1
                }
            },
            new alphabetBrailleStruct
            {
                symbol = 'я',
                cell = new List<int>
                {
                    1,1,0,1,0,1
                }
            }


        };
    }

    public struct alphabetBrailleStruct
    {
        public List<int> cell;
        public char symbol;
    }
}
