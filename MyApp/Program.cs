using System;
using System.Diagnostics.CodeAnalysis;

public class Person
{
   public double TotalPurschases{get;set;}
   public string Name{get;set;}
   public int CustomerId{get;set;}

   public Person(string name, int customerId, double totalPurschases)
   {
       Name = name;
       CustomerId = customerId;
       TotalPurschases = totalPurschases;
   }

   public string getContactInfo()
   {
       return $"Name: {Name}, CustomerId: {CustomerId}, TotalPurschases: {TotalPurschases}";
   }

   public string getTransactionHistory()
    {
        return $"Customer {Name} has made total purchases worth {TotalPurschases}";
    }
}

public string FirstName
    {
        get;
        set
        {
            field=(string.IsNullOrWhiteSpace(value)is false
            ? value
            : throw new ArgumentException(nameof(value),"First name cannot be null or empty"));
        }
    }="FirstName";
public class Program
{
    public static void Main(string[] args)
    {
        Person p1 = new Person("Ankit", 123, 1000.50);
        Console.WriteLine(p1.getContactInfo());
        Console.WriteLine(p1.getTransactionHistory());
    }
}