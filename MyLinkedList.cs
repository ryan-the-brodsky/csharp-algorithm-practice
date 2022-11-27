namespace algos.MyLinkedList;

public class MyLinkedList
{
    public Node? head {get; set;} = null;
    public MyLinkedList()
    {

    }

    public MyLinkedList insertNode(object value)
    {
        Node newNode = new Node(value);
        if(head is null){
            head = newNode;
            return this;
        }
        Node walker = head;
        while(walker.next is not null)
        {
            walker = walker.next;
        }
        walker.next = newNode;
        return this;
    }

    public MyLinkedList print()
    {
        if(head is null)
            return this;

        Node? walker = head;
        while(walker is not null)
        {
            Console.WriteLine((string)walker.value);
            walker = walker.next;
        }
        
        return this;
    }

    
}

public class Node
{
    public Node? next {get; set;}
    public object value {get; set;}
    public Node(object _value)
    {
        value = _value;
    }
}