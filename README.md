# braille-csharp
Шрифт Брайля в C#

## Использование
```
BrailleBuilder braille = new BrailleBuilder(1000, 1000, 50, true, Brushes.White);
braille.appendText("привет", Alphabet.RUSSIA);
braille.Build().Save("result.png");
```
## Как всё работает
В первую очередь картинка разбивается на группы. Одна группа - 1 буква.




