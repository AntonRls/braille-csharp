using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Braille
{
    class BrailleBuilder
    {
        private Bitmap picture;
        private Graphics pictureGr;
        private int scalePixel;
        private int padding;
        private int margin;
        private List<Zone> zones = new List<Zone>();
        private int currentZone = 0;
        /// <summary>
        /// Создать билдер
        /// </summary>
        /// <param name="width">ширина картинки</param>
        /// <param name="height">высота</param>
        /// <param name="scale">размер одной точки</param>
        public BrailleBuilder(int width, int height, int scale)
        {

            picture = new Bitmap(width, height);
            scalePixel = scale;
            pictureGr = Graphics.FromImage(picture);
            padding = scalePixel / 2;
            margin = scalePixel;

            init();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="width">ширина картинки</param>
        /// <param name="height">высота</param>
        /// <param name="scale">размер одной точки</param>
        /// <param name="fillBaground">Залить задний фон цветом</param>
        /// <param name="color">Цвет для заливки</param>
        public BrailleBuilder(int width, int height, int scale, bool fillBaground, Color color)
        {

            picture = new Bitmap(width, height);
            scalePixel = scale;
            pictureGr = Graphics.FromImage(picture);
            padding = scalePixel / 2;
            margin = scalePixel;
            if (fillBaground)
            {
                pictureGr.Clear(color);
            }
            init();

        }

        /// <summary>
        /// Добавить текст
        /// </summary>
        /// <param name="text">Текст</param>
        /// <param name="alphabet">Нужный язык</param>
        public void appendText(string text, Alphabet alphabet)
        {
   
            var currentAlphabet = new List<alphabetBrailleStruct>();
            if (alphabet == Alphabet.RUSSIA)
            {
                currentAlphabet = BrailleAlphabet.RUSSIA;
            }
            else if(alphabet == Alphabet.ENGLISH)
            {
                currentAlphabet = BrailleAlphabet.ENGLISH;
            }
            foreach (char c in text.Trim())
            {
                foreach(alphabetBrailleStruct b in currentAlphabet)
                {
                    if(b.symbol == c)
                    {
                        for(int i = 0; i < 6; i++)
                        {
                            if(b.cell[i] == 1)
                            {
                                SetPixel(pictureGr, zones[currentZone].posCells[i]);
                            }
                        }
                        currentZone++;
                        break;
                    }
                }
            }
        }

        /// <summary>
        /// Возвращает Bitmap с результатом 
        /// </summary>
        /// <returns></returns>
        public Bitmap Build()
        {
            return picture; 
        }
        /// <summary>
        /// Очищает картинку
        /// </summary>
        /// <param name="color">Цвет заливки</param>
        public void Clear(Color color)
        {
            pictureGr.Clear(color);
            currentZone = 0;
        }
        private void init()
        {
            {
                zones = new List<Zone>(0);
                int xGroupCount = int.Parse((picture.Width / ((scalePixel) * 2 + padding + margin)).ToString().Split('.')[0]);
                int yGroupCount = int.Parse((picture.Height / ((scalePixel) * 3 + padding * 2 + margin)).ToString().Split('.')[0]);

                int lastXcord = 0;
                int lastYcord = 0;

                for (int i = 0; i <= yGroupCount; i++)
                {
                    for (int i2 = 0; i2 < xGroupCount; i2++)
                    {
                        if (lastXcord <= picture.Width - ((scalePixel) * 2 + padding + margin) && lastYcord <= picture.Height - ((scalePixel) * 3 + padding * 2 + margin))
                        {
                            Zone zone = new Zone();
                            zone.pos = new Point(lastXcord, lastYcord);
                            zone.size = new Size((scalePixel) * 2 + padding, (scalePixel) * 3 + padding * 2);
                            List<Point> cellPoints = new List<Point>();
                            int cellP = 0;
                            int yTemp = lastYcord;
                            int xTemp = lastXcord;
                            while (cellPoints.Count < 6)
                            {
                                cellP++;

                                if (cellP == 4)
                                {
                                    xTemp += padding + scalePixel;
                                    yTemp = lastYcord;
                                    cellP = 0;
                                }
                                else if (cellP == 1)
                                {
                                    if (yTemp == lastYcord && xTemp != lastXcord)
                                    {
                                        yTemp += padding + scalePixel;
                                    }
                                }
                                else
                                {
                                    yTemp += padding + scalePixel;
                                }

                                cellPoints.Add(new Point(xTemp, yTemp));

                            }

                            zone.posCells = cellPoints;
                            zones.Add(zone);

                            lastXcord = i2 * ((scalePixel) * 2 + padding + margin);
                            lastYcord = i * ((scalePixel) * 3 + padding * 2 + margin);

                        }
                    }
                }

                zones.RemoveAt(0); 
            }
        }
        private void SetPixel(Graphics gr, Point pos)
        {
            gr.FillEllipse(Brushes.Black, new Rectangle(pos, new Size(scalePixel, scalePixel)));
        }
        private void SetPixelNotFill(Graphics gr, Point pos)
        {
            gr.DrawEllipse(new Pen(Brushes.Black), new Rectangle(pos, new Size(scalePixel, scalePixel)));
        }
        struct Zone
        {
            public Point pos;
            public Size size;
            public List<Point> posCells;

        }
        
    }

  

}
