using System;

namespace TreeTutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
           Node node = createTree();
           inOrder(node);
            Console.WriteLine();
            preOrder(node);
            Console.WriteLine();
            postOrder(node);
            Console.WriteLine();
            Console.WriteLine(height(node));
            Console.WriteLine(size(node));
        }

        public static Node createTree()
        {
            Console.WriteLine("Enter Data");
            int r = Convert.ToInt32(Console.ReadLine());

            if (r == -1) return null;

            Node root = new Node(r);

            Console.WriteLine("Enter data for the left node of "+ root.data);
            root.left = createTree();

            Console.WriteLine("Enter data for the right node of " + root.data);
            root.right = createTree();

            return root;
        }

        public static void inOrder(Node root)
        {
            if (root == null) return;

            inOrder(root.left);
            Console.Write(root.data + " ");
            inOrder(root.right);

        }

        public static void preOrder(Node root)
        {
            if (root == null) return;

            Console.Write(root.data + " ");
            preOrder(root.left);
            preOrder(root.right);
        }

        public static void postOrder(Node root)
        {
            if (root == null) return;  
            postOrder(root.left);
            postOrder(root.right);
            Console.Write(root.data + " ");
        }

        public static int height(Node root)
        {
            if (root == null) return 0;

            return Math.Max(height(root.left), height(root.right)) + 1;

        }
        static int count = 0;
        public static int size(Node root)
        {
            if (root == null) return 0;
            count++;
            size(root.left); 
            size(root.right);
            return count;
        }

    }

    public class Node
    {
      public  Node left, right;

      public  int data;

        public Node(int data)
        {
            this.data = data;
        }

    }
}
