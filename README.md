# braille-csharp
Шрифт Брайля в C#

## Использование
```
BrailleBuilder braille = new BrailleBuilder(1000, 1000, 50, true, Brushes.White);
braille.appendText("привет", Alphabet.RUSSIA);
braille.Build().Save("result.png");
```
## Как всё работает
В первую очередь картинка разбивается на группы. Одна группа - 1 буква. Ячейки нумируются сверху вниз:

![image](https://user-images.githubusercontent.com/74132592/147390584-9dcab117-8935-4a76-99f6-c126ef8b2d20.png)

Вот так выглядит буква Г:
```
new alphabetBrailleStruct
{
  symbol = 'г',
  cell = new List<int>
  {
    1,1,0,1,1,0
  }
}
```





