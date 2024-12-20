using System;
using System.Collections.Generic;

public class Employee
{
    private string name;
    private int id;

    public Employee(string s, int i)
    {
        name = s;
        id = i;
    }

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public int ID
    {
        get { return id; }
        set { id = value; }
    }
}

public class GenericList<T> where T : Employee
{
    private List<T> items = new List<T>();

    public void Add(T item)
    {
        items.Add(item);
    }

    public T FindByName(string name)
    {
        foreach (var item in items)
        {
            if (item.Name == name)
                return item;
        }
        return null;
    }

    public void Display()
    {
        foreach (var item in items)
        {
            Console.WriteLine($"ID: {item.ID}, Name: {item.Name}");
        }
    }
}

class Program
{
    static void Main()
    {
        var list = new GenericList<Employee>();
        list.Add(new Employee("Alice", 1));
        list.Add(new Employee("Bob", 2));

        list.Display();

        var foundEmployee = list.FindByName("Alice");
        Console.WriteLine($"Found employee: ID = {foundEmployee.ID}, Name = {foundEmployee.Name}");

        Console.ReadKey();
    }
}
