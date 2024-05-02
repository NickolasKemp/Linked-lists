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
            
            list.Display();
            list.RemoveElementsGreaterThanAverage();
            list.Display();
            var newList = list.GetElementsGreaterThanValue(1);
            newList.Display();
        }
    }
}
