using System;
using System.Collections.Generic;
using Separator;

namespace LinkedListGeneric
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleSeparator consoleSeparator = new ConsoleSeparator('-', 50);
            SeparateEvent separateEvent = new SeparateEvent();
            separateEvent.OnSeparate += consoleSeparator.Separator;

            LinkedList<int> numbers = new LinkedList<int>();
            numbers.AddLast(1);
            numbers.AddFirst(2);
            numbers.AddAfter(numbers.Last, 3);
            foreach(int x in numbers)
            {
                Console.WriteLine(x);
            }
            separateEvent.Display();

            LinkedList<Person> people = new LinkedList<Person>();
            LinkedListNode<Person> linkedListNode = people.AddLast(new Person() { Name = "Tom" });
            people.AddLast(new Person() { Name = "John" });
            people.AddFirst(new Person() { Name = "Bill" });
            foreach(Person person in people)
            {
                Console.WriteLine(person.Name);
            }
            separateEvent.Display();
            Console.WriteLine(linkedListNode.Previous.Value.Name);
            Console.WriteLine(linkedListNode.Next.Value.Name);
            Console.ReadKey();
        }
    }
}
