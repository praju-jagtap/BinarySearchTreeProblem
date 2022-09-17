namespace BinarySearchTreeProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BinarySearchTree<int> binarySearchTree = new BinarySearchTree<int>();
            binarySearchTree.InsertData(56);
            binarySearchTree.InsertData(30);
            binarySearchTree.InsertData(70);
            binarySearchTree.Display(binarySearchTree.GetRoot());
            Console.WriteLine("\n");
            Console.WriteLine("Count Of Element in Binary Search Tree is : " + binarySearchTree.GetSize());
            Console.WriteLine("\n");
            bool result = binarySearchTree.SearchTree(30, binarySearchTree.GetRoot());
            Console.WriteLine(result);
        }
    }
}