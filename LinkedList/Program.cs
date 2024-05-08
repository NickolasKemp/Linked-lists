using System;

namespace LinkedList {

    class Program {
        static void Main(string[] args)
        {
            List list = new List();

            list.Add(1);
            list.Add(10);
            list.Add(-5);
            list.Add(7);
            list.Add(3);
            list.Add(4);
            
            list.Display();
            
            //1. Перше входження елементу кратного 5
            long? firstElementMultiplyOf5 = list.FindFirstMultipeOf5();
            
            //2. Суму елементів на парних позиціях
            long? sumOfElementsOnEvenPositions = list.SumOfElementsAtEvenPositions();
            
            //3. Новий списко зі значень більших за задане
            var listWithElementsGraterThatValue = list.GetElementsGreaterThanValue(1);
            Console.WriteLine(listWithElementsGraterThatValue);
            
            //4. Видалення елементів більшеих за середнє значення (=3.3)
            list.RemoveElementsGreaterThanAverage();
        }
    }
}
