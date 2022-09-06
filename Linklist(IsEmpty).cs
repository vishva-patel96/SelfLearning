public class Linklist
{
    public class Node
    {
        public int data;
        public Node nextelement;

        public Node()
        {
            nextelement = null;
        }
    };
    Node head;

    public Linklist()
    {
        head = null;

    }
    public bool IsEmpty()
    {
        if (head == null)
            return true;
        else
            return false;
    }
}
public class Mainclass
{
    public static void Main (string[] args)
    {
        Linklist list = new Linklist();
        Console.WriteLine(list.IsEmpty());
    }
}