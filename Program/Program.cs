using System;

// Exercise 1
class Car
{
    private string brand;
    private int year;
    private float price;

    public Car(string brand, int year, float price)
    {
        this.brand = brand;
        this.year = year;
        this.price = price;
    }

    public void DisplayCarInfo()
    {
        Console.WriteLine($"Car: {brand}, Year: {year}, Price: {price:C}");
    }
}

// Exercise 2
class BankAccount
{
    private string accountNumber;
    private decimal balance;

    public BankAccount(string accountNumber)
    {
        this.accountNumber = accountNumber;
        this.balance = 0;
    }

    public void Deposit(decimal amount)
    {
        balance += amount;
    }

    public void Withdraw(decimal amount)
    {
        balance -= amount;
    }

    public void DisplayBalance()
    {
        Console.WriteLine($"Final Balance: {balance:C}");
    }
}

// Exercise 3
class Rectangle
{
    private float length;
    private float width;

    public Rectangle(float length, float width)
    {
        this.length = length;
        this.width = width;
    }

    public float CalculateArea()
    {
        return length * width;
    }
}

// Exercise 4
class Shape
{
    public virtual double CalculateArea()
    {
        return 0;
    }
}

class Circle : Shape
{
    private double radius;

    public Circle(double radius)
    {
        this.radius = radius;
    }

    public override double CalculateArea()
    {
        return Math.PI * Math.Pow(radius, 2);
    }
}

// Exercise 5
class Student
{
    private string name;
    private int age;
    private string major;

    public Student(string name, int age, string major)
    {
        this.name = name;
        this.age = age;
        this.major = major;
    }

    public void Introduce()
    {
        Console.WriteLine($"Student: {name}, Age: {age}, Major: {major}");
    }
}

// Exercise 6
class Stack<T>
{
    private System.Collections.Generic.Stack<T> stack = new System.Collections.Generic.Stack<T>();

    public void Push(T item)
    {
        stack.Push(item);
    }

    public T Pop()
    {
        return stack.Pop();
    }

    public T Peek()
    {
        return stack.Peek();
    }

    public bool IsEmpty()
    {
        return stack.Count == 0;
    }
}

// Exercise 7
class Calendar
{
    public enum DaysOfWeek
    {
        Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday
    }

    public void PrintWeekdays()
    {
        Console.WriteLine("Weekdays: " + string.Join(", ", Enum.GetNames(typeof(DaysOfWeek)).Take(5)));
    }
}

// Exercise 8
struct Point2D
{
    public float X;
    public float Y;
}

class PointHelper
{
    public static double CalculateDistance(Point2D point1, Point2D point2)
    {
        return Math.Sqrt(Math.Pow(point2.X - point1.X, 2) + Math.Pow(point2.Y - point1.Y, 2));
    }
}

class Program
{
    static void Main()
    {
        // Exercise 1
        Car car = new Car("Toyota", 2023, 25000);
        car.DisplayCarInfo();

        // Exercise 2
        BankAccount account = new BankAccount("123456");
        account.Deposit(1000);
        account.Withdraw(500);
        account.DisplayBalance();

        // Exercise 3
        Rectangle rectangle = new Rectangle(4.5f, 3.2f);
        Console.WriteLine($"Rectangle Area: {rectangle.CalculateArea()}");

        // Exercise 4
        Circle circle = new Circle(5);
        Console.WriteLine($"Circle Area: {circle.CalculateArea()}");

        // Exercise 5
        Student student = new Student("John Doe", 20, "Computer Science");
        student.Introduce();

        // Exercise 6
        Stack<int> intStack = new Stack<int>();
        intStack.Push(1);
        intStack.Push(2);
        intStack.Push(3);
        Console.WriteLine($"Peek: {intStack.Peek()}");
        intStack.Pop();
        Console.WriteLine($"Peek after Pop: {intStack.Peek()}");

        // Exercise 7
        Calendar calendar = new Calendar();
        calendar.PrintWeekdays();

        // Exercise 8
        Point2D point1 = new Point2D { X = 1, Y = 2 };
        Point2D point2 = new Point2D { X = 4, Y = 6 };
        Console.WriteLine($"Distance between points: {PointHelper.CalculateDistance(point1, point2)}");
    }
}
