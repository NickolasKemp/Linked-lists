namespace LinkedList;    
public class List
    {
        private Node head;
        private Node tail;
        private long count; 
        public void Add(long data)
        {
            Node newNode = new Node(data);
            if (head == null)
            {
                head = newNode;
                tail = newNode;
            }
            else
            {
                tail.Next = newNode;
                newNode.Prev = tail;
                tail = newNode;
            }

            count++;
        }
        
        public void Remove(long data)
        {
            Node current = head;
            while (current != null)
            {
                if (current.Data == data)
                {
                    if (current.Prev == null)
                    {
                        head = current.Next;
                        if (head != null)
                        {
                            head.Prev = null;
                        }
                    }
                    else if (current.Next == null)
                    {
                        tail = current.Prev;
                        tail.Next = null;
                    }
                    else
                    {
                        current.Prev.Next = current.Next;
                        current.Next.Prev = current.Prev;
                    }
                    count--; 
                    return; 
                }
                current = current.Next;
            }
        }

        public void Display()
        {
            Node current = head;
            while (current != null)
            {
                Console.Write(current.Data + " ");
                current = current.Next;
            }
            Console.WriteLine();
        }
        
                
        private double CalculateAverage()
        {
            if (head == null)
            {
                return 0; 
            }

            Node current = head;
            long sum = 0;
            while (current != null)
            {
                sum += current.Data;
                current = current.Next;
            }

            return (double)sum / count; 
        }

        public long? FindFirstMultipeOf5()
        {
            Node current = head;
            while (current != null)
            {
                if (current.Data % 5 == 0)
                {
                    return current.Data;
                }

                current = current.Next;
            }

            return null;
        }
        
        public long SumOfElementsAtEvenPositions()
        {
            long sum = 0;
            Node current = head;
            long index = 0;
            while (current != null)
            {
                if (index % 2 == 0) 
                {
                    sum += current.Data;
                }
                current = current.Next;
                index++;
            }
            return sum;
        }
        
        public List GetElementsGreaterThanValue(long value)
        {
            List newList = new List();
            Node current = head;
            while (current != null)
            {
                if (current.Data > value)
                {
                    newList.Add(current.Data);
                }
                current = current.Next;
            }
            return newList;
        }
        
        public void RemoveElementsGreaterThanAverage()
        {
            double average = CalculateAverage();
            Node current = head;
            while (current != null)
            {
                if (current.Data > average)
                {
                    Remove(current.Data);
                }
                current = current.Next;
            }
        }
        
    }