using System;

namespace LinkedList
{
    public class Node
    {
        public int Value { get; set; }

        public Node Next { get; set; }

        public Node(int data)
        {
            Value = data;
            Next = null;
        }

        public void AddToEnd(int data)
        {
            if (Next == null)
            {
                Next = new Node(data);
            }
            else
            {
                Next.AddToEnd(data);
            }
        }

        public void Print()
        {
            Console.Write(Value + " => ");
            if (Next != null)
            {
                Next.Print();
            }
        }

        public void AddSorted(int data)
        {
            if (Next == null)
            {
                Next = new Node(data);
            }
            else if (data < Next.Value)
            {
                var temp = new Node(data);
                temp.Next = Next;
                this.Next = temp;
            }
            else
                Next.AddSorted(data);
        }

        public void Find(int data, int index)
        {
            if (Value == data)
            {
                Console.WriteLine("It is at the: {0}", index);
                return;
            }
            if (Next == null)
            {
                Console.WriteLine("Could not find");
            }
            else
            {
                if (Value != data)
                {
                    index++;
                    Next.Find(data, index);
                }
            }
        }

        public void Min(int min)
        {
            if (min > Value)
            {
                min = Value;
            }
            if (Next == null)
            {
                Console.WriteLine("Min is: {0}", min);
            }
            else
            {
                Next.Min(min);
            }
        }

        public void Max(int max)
        {
            if (max < Value)
            {
                max = Value;
            }
            if (Next == null)
            {
                Console.WriteLine("Max is: {0}", max);
            }
            else
            {
                Next.Max(max);
            }
        }
    }


    public class MyList
    {
        public Node Head { get; set; }

        public MyList()
        {
            Head = null;
        }

        public void AddToEnd(int data)
        {
            if (Head == null)
            {
                Head = new Node(data);
            }
            else
            {
                Head.AddToEnd(data);
            }
        }

        public void AddSorted(int data)
        {
            if (Head == null)
            {
                Head = new Node(data);
            }
            else if (data < Head.Value)
            {
                AddToBeginning(data);
            }
            else
            {
                Head.AddSorted(data);
            }
        }

        public void AddToBeginning(int data)
        {
            if (Head == null)
            {
                Head = new Node(data);
            }
            else
            {
                var temp = new Node(data);
                temp.Next = Head;
                Head = temp;
            }
        }

        public void Find(int data)
        {
            if (Head == null)
            {
                Console.WriteLine("Head is null");
            }
            else
            {
                Head.Find(data, 0);
            }
        }

        public void Min()
        {
            if (Head == null)
            {
                Console.WriteLine("Head is null");
            }
            else
            {
                Head.Min(Head.Value);
            }
        }

        public void Max()
        {
            if (Head == null)
            {
                Console.WriteLine("Head is null");
            }
            else
            {
                Head.Max(Head.Value);
            }
        }

        public void Print()
        {
            Head.Print();
            Console.WriteLine();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var myList = new MyList();

            //myList.AddToEnd(5);
            //myList.AddToEnd(2);
            //myList.AddToEnd(8);
            //myList.AddToEnd(7);
            //myList.AddToEnd(11);

            //myList.AddToBeginning(5);
            //myList.AddToBeginning(2);
            //myList.AddToBeginning(8);
            //myList.AddToBeginning(7);
            //myList.AddToBeginning(11);

            myList.AddSorted(5);
            myList.AddSorted(2);
            myList.AddSorted(8);
            myList.AddSorted(7);
            myList.AddSorted(11);

            myList.Print();

            myList.Find(7);
            myList.Min();
            myList.Max();

            Console.ReadLine();
        }
    }
}
