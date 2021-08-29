using System;
using Onyx.Characters;

namespace Test
{
    class Program
    {
        public static void Main(string[] args)
        {
            //int number = 12;
            //Console.Write(number);
            //Console.Write(number.GetType().FullName);

            //Player Bob = new Player();
            //Console.Write(Bob.GetType());

            //string hello = "Hello";
            //Console.WriteLine(hello);
            //string world = " World";
            //Console.WriteLine(hello + world);

            //string helloWorld = hello + world;
            //Console.WriteLine(helloWorld);

            NodeList<int> primes = new NodeList<int>();
            primes.Add(7);
            primes.Add(13);
            primes.Add(17);
            primes.RemoveLast();
            primes.RemoveLast();
            primes.RemoveLast();
            primes.RemoveLast();
            NodeList<string> text = new NodeList<string>();
            text.Add("poggers");
            text.RemoveLast();

        }
    }
}


public class Node<T>
{
    public T Value;
    public Node<T> NextRef;
    public Node(){
        
}
    public Node(T value)
    {
        this.Value = value;
    }
    public Node(T value, Node<T> nextRef)
    {
        this.Value = value;
        this.NextRef = nextRef;
    }
}


public class NodeList<T>
{
    public int Count;
    public Node<T> Head;

    public void Add(T newval)
        {
        if (Head == null)
        {
            //Head = new Node<T>();
            //Head.Value = newval;
            Head = new Node<T>(newval);
            Count = 1;
            
       
        }
        else
        {
Node<T> node = new Node<T>();
        node.Value = newval;

            Node<T> p = Head;
            while(p.NextRef != null)
            {
                p = p.NextRef;
            }
        p.NextRef = node;
        Count++;
      
        }
        
        }

    public void RemoveLast()
    {
        if (Head == null)
        {
            return;
        }
     
        Node <T> p = Head;
        Node<T> secondtolast = p;
        
        while (p != null && p.NextRef != null)
        {
            secondtolast = p;
            p = p.NextRef;

        }
        secondtolast.NextRef = null;
        Count--;

        if (Count == 0)
        {
            Head = null;
        }
        
    }

    //bool contains(value to find)
    //{
    //    if value exists{

    //        return tru
    //    }
    //    else
    //    {
    //        return false
    //    }
    //}
    //int find(value to find)
    //{
    //    if contains(value to find) == true{
    //        return value
    //    }
    //    else
    //    {
    //        return false
    //    }
    //}
}
