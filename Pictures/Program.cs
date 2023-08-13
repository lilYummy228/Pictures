using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pictures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int availablePicturesPlaces = 3;
            int picturesCount = 52;
            int fullRowCount = picturesCount/ availablePicturesPlaces;
            int picturesBeyond = picturesCount % availablePicturesPlaces;
            Console.WriteLine($"Помещающихся в ряд картинок: {availablePicturesPlaces}\n" +
                $"Всего картинок: {picturesCount}\nПолностью заполненных картинками рядов: {fullRowCount}" +
                $"\nКартинок сверх меры: {picturesBeyond}.");
        }
    }
}
