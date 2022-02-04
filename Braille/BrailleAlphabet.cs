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
        public static List<alphabetBrailleStruct> ENGLISH = new List<alphabetBrailleStruct>
        {
             new alphabetBrailleStruct
             {
                symbol = 'a',
                cell = new List<int>
                {
                    1,0,0,0,0,0
                }
             },
              new alphabetBrailleStruct
              {
                symbol = 'b',
                cell = new List<int>
                {
                    1,1,0,0,0,0
                }
              },
               new alphabetBrailleStruct
              {
                symbol = 'c',
                cell = new List<int>
                {
                    1,0,0,1,0,0
                }
              },
                new alphabetBrailleStruct
              {
                symbol = 'd',
                cell = new List<int>
                {
                    1,0,0,1,1,0
                }
              },
                 new alphabetBrailleStruct
              {
                symbol = 'e',
                cell = new List<int>
                {
                    1,0,0,0,1,0
                }
              },
                  new alphabetBrailleStruct
              {
                symbol = 'f',
                cell = new List<int>
                {
                    1,1,0,1,0,0
                }
              },
                   new alphabetBrailleStruct
              {
                symbol = 'g',
                cell = new List<int>
                {
                    1,1,0,1,1,0
                }
              },
                    new alphabetBrailleStruct
              {
                symbol = 'h',
                cell = new List<int>
                {
                    1,1,0,0,1,0
                }
              },
                     new alphabetBrailleStruct
              {
                symbol = 'i',
                cell = new List<int>
                {
                    0,1,0,1,0,0
                }
              },
                      new alphabetBrailleStruct
              {
                symbol = 'j',
                cell = new List<int>
                {
                    0,1,0,1,1,0
                }
              },
                       new alphabetBrailleStruct
              {
                symbol = 'k',
                cell = new List<int>
                {
                    1,0,1,0,0,0
                }
              },
                        new alphabetBrailleStruct
              {
                symbol = 'l',
                cell = new List<int>
                {
                    1,1,1,0,0,0
                }
              },
                         new alphabetBrailleStruct
              {
                symbol = 'm',
                cell = new List<int>
                {
                    1,0,1,1,0,0
                }
              },
                          new alphabetBrailleStruct
              {
                symbol = 'n',
                cell = new List<int>
                {
                    1,0,1,1,1,0
                }
              },
                           new alphabetBrailleStruct
              {
                symbol = 'o',
                cell = new List<int>
                {
                    1,0,1,0,1,0
                }
              },
                            new alphabetBrailleStruct
              {
                symbol = 'p',
                cell = new List<int>
                {
                    1,1,1,1,0,0
                }
              },
                             new alphabetBrailleStruct
              {
                symbol = 'q',
                cell = new List<int>
                {
                    1,1,1,1,1,0
                }
              },
                              new alphabetBrailleStruct
              {
                symbol = 'r',
                cell = new List<int>
                {
                    1,1,1,0,1,0
                }
              },
                               new alphabetBrailleStruct
              {
                symbol = 's',
                cell = new List<int>
                {
                    0,1,1,1,0,0
                }
              },
                                new alphabetBrailleStruct
              {
                symbol = 't',
                cell = new List<int>
                {
                    0,1,1,1,1,0
                }
              },
                                 new alphabetBrailleStruct
              {
                symbol = 'u',
                cell = new List<int>
                {
                    1,0,1,0,0,1
                }
              },
                                  new alphabetBrailleStruct
              {
                symbol = 'v',
                cell = new List<int>
                {
                    1,1,1,0,0,1
                }
              },
                                   new alphabetBrailleStruct
              {
                symbol = 'x',
                cell = new List<int>
                {
                    1,0,1,1,0,1
                }
              },
                                    new alphabetBrailleStruct
              {
                symbol = 'y',
                cell = new List<int>
                {
                    1,0,1,1,1,1
                }
              },
                                     new alphabetBrailleStruct
              {
                symbol = 'z',
                cell = new List<int>
                {
                    1,0,1,0,1,1
                }
              },

        };

    }
    public enum Alphabet
    {
        RUSSIA,
        ENGLISH
    }
    public struct alphabetBrailleStruct
    {
        public List<int> cell;
        public char symbol;
    }
}
