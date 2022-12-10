using System;

namespace pz_18
{
    class Program
    {
        enum Marks
        {
            very_bad = 1,
            unsatisfactory,
            satisfactory,
            good,
            great
        }
        enum Seasons
        {
            winter,
            spring, 
            summer,
            autumn
        }

    
        static void Main(string[] args)
        {

            
           
            
        }

        static void Holidays (Seasons seasons)
        {
            switch (seasons)
            {
                case Seasons.winter:
                    Console.Write("12.12 - День Конституции\n01.01 - Новый Год\n07.01 - Рождество\n14.02 - День Святого Валентина");
                    break;
                case Seasons.spring:
                    Console.Write("08.03 - Международный женский день\n01.04 - День смеха\n12.04 - День космонавтики\n01.05 - Праздник весны и труда\n09.05 - День Победы");
                    break;
                case Seasons.summer:
                    Console.Write("01.06 - Международный день защиты детей\n12.06 - День России\n22.08 - День Государственного флага");
                    break;
                case Seasons.autumn:
                    Console.Write("01.09 - День знаний\n05.10 - День учителя\n04.11 - День народного единства");
                    break;
            }
        }

        static void PrintMessage(Marks marks)
        {
            switch (marks)
            {
                case Marks.very_bad:
                    Console.WriteLine("Очень плохо");
                    break;
                case Marks.unsatisfactory:
                    Console.WriteLine("Неудовлетворительно");
                    break;
                case Marks.satisfactory:
                    Console.WriteLine("Удовлетворительно");
                    break;
                case Marks.good:
                    Console.WriteLine("Хорошо");
                    break;
                case Marks.great:
                    Console.WriteLine("Отлично");
                    break;
            }
        }
    }
}
