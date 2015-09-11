using System;

namespace BST
{
    public class Node
    {
        public int Value { get; set; }

        public Node Left { get; set; }

        public Node Right { get; set; }

        public Node(int value)
        {
            Value = value;
            Left = null;
            Right = null;
        }

        public void AddRecursive(int data)
        {
            if (data > Value)
            {
                if (Right == null)
                    Right = new Node(data);
                else
                    Right.AddRecursive(data);
            }
            else
            {
                if(Left == null)
                    Left = new Node(data);
                else
                    Left.AddRecursive(data);
            }
        }

        public Node FindAndDeleteNode(int data)
        {
            if (Value == data)
                return this;
            if (data > Value)
            {
                if (Right != null)
                {
                    var result = Right.FindAndDeleteNode(data);
                    if (Right.Value == data)
                        Right = null;
                    return result;
                }    
            }
            else
            {
                if (Left != null)
                {
                    var result = Left.FindAndDeleteNode(data);
                    if (Left.Value == data)
                        Left = null;
                    return result;
                }
            }

            return null;
        }
    }

    public class MyBst
    {
        public Node Top { get; set; }

        public MyBst(Node top)
        {
            Top = top;
        }

        public MyBst()
        {
            Top = null;
        }

        public void AddRecursive(int data)
        {
            if (Top == null) // Top is empty there is no tree
            {
                Top = new Node(data);
            }
            else
            {
                Top.AddRecursive(data);
            }
        }

        public void Add(int data)
        {
            if (Top == null)
            {
                Top = new Node(data);
            }
            else
            {
                var current = Top;
                while (true)
                {
                    if (data > current.Value)
                    {
                        var right = current.Right;
                        if (right == null)
                        {
                            right = new Node(data);
                            current.Right = right;
                            return;
                        }
                        current = right;
                    }
                    else
                    {
                        var left = current.Left;
                        if (left == null)
                        {
                            left = new Node(data);
                            current.Left = left;
                            return;
                        }
                        current = left;
                    }
                }
            }
        }

        public void PreOrderTraverse(Node node)
        {
            Console.Write("{0} ", node.Value);
            if(node.Left != null)
                PreOrderTraverse(node.Left);
            if(node.Right != null)
                PreOrderTraverse(node.Right);
        }

        public void InOrderTraverse(Node node)
        {
            if (node.Left != null)
                InOrderTraverse(node.Left);

            Console.Write("{0} ", node.Value);

            if (node.Right != null)
                InOrderTraverse(node.Right);
        }

        public void PostOrderTraverse(Node node)
        {
            if(node != null)
                PostOrderTraverse(node.Left);

            if (node != null)
                PostOrderTraverse(node.Right);

            if (node != null)
                Console.Write("{0} ", node.Value);
        }

        public void Min()
        {
            //Csinalhatunk pre/post vagy inorder bejarast
            if (Top == null)
            {
                Console.WriteLine("Top is empty");
            }
            else
            {
                var current = Top;
                while (true)
                {
                    var left = current.Left;
                    if (left == null)
                    {
                        Console.WriteLine("The minimum value in the tree is: {0}", current.Value);
                        return;
                    }
                    current = left;
                }       
            }
        }

        public void Max()
        {
            //Csinalhatunk pre/post vagy inorder bejarast
            if (Top == null)
            {
                Console.WriteLine("Top is empty");
            }
            else
            {
                var current = Top;
                while (true)
                {
                    var right = current.Right;
                    if (right == null)
                    {
                        Console.WriteLine("The maximum value in the tree is: {0}", current.Value);
                        return;
                    }
                    current = right;
                }
            }
        }

        private Node FindAndDeleteNode(int data)
        {
            if (Top == null)
            {
                Console.WriteLine("Top is empty");
            }
            else
            {
                return Top.FindAndDeleteNode(data);
            }
            return null;
        }

        private void PostOrderDelete(Node node)
        {
            if (node != null)
                PostOrderDelete(node.Left);

            if (node != null)
                PostOrderDelete(node.Right);

            if (node != null)
            {
                node.Right = null;
                node.Left = null;
            }

        }

        public void Delete(int data)
        {
            var node = FindAndDeleteNode(data);

            PostOrderDelete(node);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            if (args == null) throw new ArgumentNullException(nameof(args));
            var myBst = new MyBst();

            //myBst.AddRecursive(20);
            //myBst.AddRecursive(15);
            //myBst.AddRecursive(25);
            //myBst.AddRecursive(13);
            //myBst.AddRecursive(18);
            //myBst.AddRecursive(22);
            //myBst.AddRecursive(45);
            //myBst.AddRecursive(40);
            //myBst.AddRecursive(14);
            //myBst.AddRecursive(17);

            myBst.Add(20);
            myBst.Add(15);
            myBst.Add(25);
            myBst.Add(13);
            myBst.Add(18);
            myBst.Add(22);
            myBst.Add(45);
            myBst.Add(40);
            myBst.Add(14);
            myBst.Add(17);

            Console.Write("PreOrder Traverse of the tree: ");
            myBst.PreOrderTraverse(myBst.Top);
            Console.WriteLine();
            Console.Write("InOrder Traverse of the tree: ");
            myBst.InOrderTraverse(myBst.Top);
            Console.WriteLine();
            Console.Write("PostOrder Traverse of the tree: ");
            myBst.PostOrderTraverse(myBst.Top);
            Console.WriteLine();
            myBst.Min();
            myBst.Max();
            myBst.Delete(45);
            myBst.PreOrderTraverse(myBst.Top);

            Console.ReadLine();
        }
    }
}
