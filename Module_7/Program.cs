using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Module_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }

    class BaseClass
    {
        public string Name;
        protected string Description;
        private int value;

        public BaseClass(int value)
        {
            this.value = value;
        }
    }

    class InheritedClass : BaseClass
    {
        private int newValue;
        public InheritedClass(int newValue) : base(100)
        {
            this.newValue = newValue;
        }
    }

    class Car
    {
        public double Fuel;

        public int Mileage;

        public Car()
        {
            Fuel = 50;
            Mileage = 0;
        }
        public void Move()
        {
            //Move a kilometer
            Mileage++;
            Fuel -= 0.5;
        }
        public void FillTheCar()
        {
            Fuel = 50;
        }
    }
    enum FuelType
    {
        Gas = 0,
        Electricity
    }

    class HybridCar : Car
    {
        public FuelType FuelType;

        public void ChangeFuelType(FuelType type)
        {
            FuelType = type;
        }

        Car car = new HybridCar();
        HybridCar hybrid = new HybridCar();
        car.Move()

    }

    //с этим модификатор нельзя наследовать 
    sealed class Admin
    {

    }

    class Employee
    {
        public string Name;
        public int Age;
        public int Salary;
    }

    class ProjectManaer : Employee
    {
        public string ProjectName;
    }

    class Developer : Employee
    {
        public string Programminglanguage;
    }

    class Vegetables
    {
        public string Potato;
        public string Carrot;

    }

    class Fruits : Vegetables
    {
        public string Aplle;
        public string Banana;
        public string Pear;
    }

    class Food : Fruits
    {

    }

    class Obj
    {
        private string name;
        private string description;

        public Odj()
        {
            Console.WriteLine("Вызван конструктор для параметров");
        }
        public Obj(string name, string description) : this()
        {
            this.name = name;
            this.description = description;
        }
    }

    class Objj
    {
        private string name;
        private string owner;
        private int lenght;
        private int count;

        public Objj(string name, string ownerName, int objjLenght, int count)
        {
            this.name = name;
            owner = ownerName;
            lenght = objjLenght;
            this.count = count;

        }
    }

    class SmartHelper
    {
        private string name;

        public SmartHelper(string name)
        {
            this.name = name;
        }

        public void Greetings(string name)
        {
            Console.WriteLine("Привет, {0}, я интелектуальный помощник {1}", name, this.name);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            SmartHelper helper = new SmartHelper("Олег");
            helper.Greetings("Грег");
            Console.ReadKey();
        }
    }

    class BaseClass2
    {
        protected string Name;

        public BaseClass2(string name)
        {
            Name = name;
        }
    }

    class DerivedClass2 : BaseClass2
    {
        public string Description;
        public int Counter;

        public DerivedClass2(string name, string description) : base(name)
        {

            Description = description;
        }

        public DerivedClass2(string name, string description, int counter) : base(name)
        {

            Description = description;
            Counter = counter;
        }

        //или
        public DerivedClass2(string name, string description, int counter) : this(name, description)
        {
            Counter = counter;
        }
    }

    class Creature
    {

    }
    class Animal : Creature
    {

    }
    class Human : Creature
    {

    }

    class HomoSapiens : Human
    {

    }
    class Program2
    {
        static void Main(string[] args)
        {
            //восходящее преобразование
            HomoSapiens hs = new HomoSapiens();
            Human human = hs;
            Creature creature = (Creature)human;
            Creature secondCreature = new Animal();

            // нисходящее преобразование
            Creature secondCreature2 = new Animal();
            Animal animal = (Animal)secondCreature;

            object obj = new Animal();
            Animal animal2 = (Animal)obj;

            // для проверки возможности перобразования используется is

            if (secondCreature is Animal)
            {
                Console.WriteLine("Экземпляр имеет тип Animal");
            }
        }

        bool expression;
        expression = secondCreature is Animal; //true
            expression = secondCreature is Creature; //true
            expression = secondCreature is object; //true
            expression = secondCreature is Human; //false
    }

    class Car2
    {
        public int Mileage;
        public Car2()
        {
            Mileage = 0;
        }

        public virtual void Move()
        {
            Console.WriteLine("Вызван метод Move класса Car2");
            Mileage++;
        }
    }
    enum FuelType2
    {
        Gas = 0,
        Electricity
    }
    class HybridCar2 : Car2
    {
        public FuelType2 FuelType2;
        public double Gas;
        public double Electricity;
        public HybridCar2()
        {
            Electricity = 50;
            Gas = 50;
        }

        public override void Move()
        {

            base.Move();//использование базового метода Move
            Console.WriteLine("Вызван метод Move класса HybridCar2");
            // Mileage++;

            switch (FuelType2)
            {
                case FuelType2.Gas:
                    Gas -= 0.5;
                    break;
                case FuelType2.Electricity:
                    Electricity -= 0.5;
                    break;
            }
        }

        public void ChangeFuelType(FuelType2 type)
        {
            FuelType2 = type;
        }

    }

    class Program3
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            HybridCar hybridCar = new HybridCar();

            car.Move(); //метод класса Car
            hybridCar.Move(); //метод класса HybridCar
            ((Car)hybridCar).Move();//метод класса HybridCar
            Console.ReadKey();
        }
    }

    class BaseClass4

    {
        public virtual void Display()
        {
            Console.WriteLine("Метод класса BaseClass");
        }
    }

    class DerivedClass : BaseClass4
    {
        public override void Display()
        {
            base.Display();
            Console.WriteLine("Метод класса DerivedClass");
        }
    }
    class Citizen
    {
        public virtual double Age
        {
            get;
            set;
        }

        public void SayYourAge()
        {
            Console.WriteLine("Мне {0} лет", Age);

        }
    }
    class CivilServant : Citizen
    {
        private double age;
        public override double Age
        {
            get
            {
                return age;
            }
            set
            {
                if (value < 18)
                {
                    Console.WriteLine("Для работы госслужащим гражданинам должен быть не младше 148 лет");
                }
                else
                {
                    age = value;

                }
            }
        }
    }
    class President : CivilServant
    {
        private double age;
        public override double Age
        {
            get
            {
                return age;
            }
            set
            {
                if (value < 35)
                {
                    Console.WriteLine("Для работы президентом гражданин должен быть не младше 35 лет");
                }
                else
                {
                    age = value;
                }
            }
        }
    }

    class BaseClass8
    {
        public virtual int Counter
        {
            get;
            set;
        }
    }

    class DerivedClass8 : BaseClass8
    {
        private int counter;
        public override int Counter
        {
            get
            {
                return counter;
            }
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("Значения должны быть больше 0"); ;
                }
                else
                {
                    counter = value;
                }
            }


        }
    }
    //переопределение базоввого метода
    class BaseClass10
    {
        public virtual void Method()
        {
            //базовая логика
        }
    }
    class InheritedClass10 : BaseClass10
    {
        public override void Method()
        {
            base.Method();
            //добавленная логика
        }
    }

    class A
    {
        public virtual void Display()
        {
            Console.WriteLine("Вызван метод класса А");
        }
    }
    class B : A
    {
        public new void Display()
        {
            Console.WriteLine("Вызван метод класса В");
        }
    }

    class C : A
    {

        public override void Display()
        {
            Console.WriteLine("Вызван метод класса C");
        }
    }
    class D : B
    {
        //сокрытие метода через ключевое слово new
        public new void Display()
        {
            Console.WriteLine("Вызван метод класса D");
        }
    }

    class E : C
    {
        //сокрытие метода через ключевое слово new
        public new void Display()
        {
            Console.WriteLine("Вызван метод класса E");
        }
    }

    class Program10
    {
        static void Main(string[] args)
        {
            A a = new A();
            B b = new B();
            C c = new C();

            a.Display(); //метод класса A
            b.Display(); //метод класса B
            ((A)b).Display(); //метод класса B

            c.Display(); //метод класса C
            ((A)c).Display(); //метод класса B
            ((B)c).Display(); //метод класса B

        }
    }
    internal class Program11
    {
        static void Main(string[] args)
        {
            Vector a = new Vector { X = 3, Y = 5 };
            Vector b = new Vector { X = 7, Y = 13 };

            Vector c = a.Add(b);
            Console.WriteLine($"{c.X}, {c.Y}");
        }
    }
    class Vector
    {
        public int X;
        public int Y;

        public Vector Add(Vector second)
        {
            return new Vector
            {
                X = this.X + second.X,
                Y = this.Y + second.Y
            };
        }
        //для объявления перегрузк оператора оязательно указать можификаторы public и static, а после возвращамого метода указать слово operator
        public static Vector operator +(Vector a, Vector b)
        {
            return new Vector
            {
                X = a.X + b.X,
                Y = a.Y + b.Y
            };
        }
        //после перезгрузки оператора можно булет использовать Vector c = a + b;
    }

    Vector a = new Vector { X = 3, Y = 5 };
    Vector b = new Vector { X = 7, Y = 13 };
    Vector c = new Vector { X = a.X + b.X, Y = a.Y + b.Y };

    class Obj2
    {
        public int Value;

        public static Obj2 operator +(Obj2 a, Obj2 b)
        {
            return new Obj2
            {
                Value = a.Value + b.Value
            };
        }
        public static Obj2 operator -(Obj2 a, Obj2 b)
        {
            return new Obj2
            {
                Value = a.Value - b.Value
            };
        }
    }
    //работа индексатора
    //класс для объекта Книга
    class Book
    {
        public string Name;
        public string Author;
    }
    // класс для оъекта Коллекция книг
    class BookCollection
    {
        //закрытое поле, хранящее книги в виде массива
        private Book[] collection;

        //конструктор с добавлением массива книг
        public BookCollection(Book[] collection)
        {

            this.collection = collection;
        }

        // индексатор по массиву
        public Book this[int index]
        {

            get
            {
                //проверяем чтобы индекс был в диапазоне для массива
                if (index >= 0 && index < collection.Length)
                {
                    return collection[index];
                }
                else
                {
                    return null;
                }
            }
            private set
            {
                //проверяем чтобы индекс был в диапазоне для массива
                if (index >= 0 && index < collection.Length)
                {
                    collection[index] = value;
                }
            }
        }


        public Book this[string name]
        {
            get
            {
                for (int i = 0; i < collection.Length; i++)
                {
                    if (collection[i].Name == name)
                    {
                        return collection[i];
                    }
                }
                return null;
            }
        }
    }

    //для получения книги воспользуемся следующим синтаксисом
    class Program12
    {
        static void Main(string[] args)
        {
            var array = new Book[]
            {
                new Book  { Name = "Мастер и Маргарита",Author = "Булгаков"  },
                new Book  { Name = "Отцы и дети", Author = "Тургенев" },
            };
            BookCollection collection = new BookCollection(array);
            Console.ReadKey();
            Book book = collection[1];
            book = collection[-1];
            book = collection[4];

            Console.ReadKey();

            book = collection["Мастер и Маргарита"];

            Console.ReadKey();
        }
    }

    class IndexingClass
    {
        private int[] array;

        public IndexingClass(int[] array)
        {
            this.array = array;
        }

        public int this[int index]
        {
            get
            {
                return array[index];
            }
            set
            {
                array[index] = value;
            }


        }
    }

    abstract class AbstractClass
    {

        //абстрактное свойство
        public abstract string Name
        {
            //метлды при этом не имеют тела
            get;
            set;
        }
        public abstract void Display();

    }

    abstract class DerivedAbstractClass : AbstractClass
    {
        public abstract void Display2();
    }

    abstract class FourLeggedAnimal
    {
        public abstract void Describe();
    }

    class Dog : FourLeggedAnimal
    {
        public override void Describe()
        {
            Console.WriteLine("Это животное - собака");
        }
    }

    class Cat : FourLeggedAnimal
    {
        public override void Describe()
        {
            Console.WriteLine("Это животное - cat");
        }
    }
    abstract class Person
    {
        public string Name;

        public Person(string name)
        {
            Name = name;
        }
        public void DisplayName()
        {
            Console.WriteLine(Name);
        }
    }
    class Employee2 : Person
    {
        //булевый флаг, сообщающий находится ли сотрудник на смене
        public bool IsOnShift;

        public Employee2(string name, bool isOnShift) : base(name)
        {
            IsOnShift = isOnShift;
        }
    }
    class Guest : Person
    {
        public DateTime ArrivalDate;
        public Guest(string name, DateTime arrivalDate) : base(name)
        {
            ArrivalDate = arrivalDate;
        }
    }

    abstract class ComputerPart
    {
        public abstract void Work();

    }
    class Processor : ComputerPart
    {
        public override void Work()
        {

        }
    }
    class MotherBoard : ComputerPart
    {
        public override void Work()
        {

        }
    }
    class GraficCard : ComputerPart
    {
        public override void Work()
        {

        }
    }

    abstract class Transport
    {
        public abstract void Move();
    }

    class Boat : Transport
    {
        public override void Move()
        {

        }
    }

    class Car3 : Transport
    {
        public double Fuel;
        public int Mileage;

        public Car3()
        {
            Fuel = 50;
            Mileage = 0;
        }
        public override void Move()
        {
            Mileage++;
            Fuel -= 0.5;

        }
        public void FillTheCar()
        {
            Fuel = 50;
        }
    }
    enum FuelType3
    {
        Gas = 0,
        Electricity
    }

    class HybridCar3 : Car3
    {
        public FuelType FuelType;

        public void ChangeFuelType(FuelType type)
        {
            FuelType = type;
        }
    }

    class User
    {
        public string Login;
        public string Name;
    }

    class Admin2 : User
    {
        public void ManageUser()
        {

        }
    }

    class MotherBoard2
    {

    }
    //композиция
    class SystemUnit
    {
        private MotherBoard2 motherBoard;

        public SystemUnit()
        {
            motherBoard = new MotherBoard2();
        }
    }
    //агрегацмя
    class SystemUnit
    {
        private MotherBoard motherBoard;

        public SystemUnit(MotherBoard2 motherBoard)
        {
            this.motherBoard = motherBoard;
        }
    }
    class SimpleClass
    {
        public static int MinValue = 100;

        public int Value;

        public SimpleClass(int value)
        {
            if (value < MinValue)
            {
                Value = MinValue;
            }
            else
            {
                Value = value;
            }
        }

        SimpleClass object1 = new SimpleClass(50);
        SimpleClass object2 = new SimpleClass(170);
    }
    static void Main(string[] args)
    {
        Console.WriteLine(SimpleClass.MinValue);
    }

    class Obj
    {
        public string Name;
        public string Discription;

        public static string Parent;
        public static int DaysInWeek;
        public static int MaxValue;

        static Obj()
        {
            Parent = "System.Object";
            DaysInWeek = 7;
            MaxValue = 2000;
        }
    }





    class Counter
    {
        private static int increasingCounter;
        //статическое свойство
        public static int IncreasingCounter
        {
            get
            {
                return increasingCounter;
            }
            set
            {
                if (value > increasingCounter)
                {
                    increasingCounter = value;
                }
            }
        }
        //обращение к свойству извне через класс в котром оно создано
        Counter.IncreasingCounter++;
            Console.WriteLine(Counter.IncreasingCounter);
    }
    class Helper
    {
        public static int Sum(int a, int b, int c)
        {
            return a + b + c;
        }
        //вызов метода в коде
        var sum = Helper.Sum(1, 2, 3);


        int num1 = 3;
        int num2 = 58;

        public static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;

        }
    }
    class Car12
    {
        //статические поля
        public static int MinPrice = 100_000;
        public static int MaxPrice;

        //статический конструктор
        static Car12()
        {
            Console.WriteLine("Вызвван статический коструктор Car12");
            MaxPrice = 1_000_000;
        }

        //нестатическое поле
        public int Price;
    }

    class Program13
    {
        static void Main(string[] args)
        {
            //создание экзкмляра класса
            Car car = new Car();
            //обращение к его статическим полям
            Console.WriteLine(Car12.MinPrice);
            Console.WriteLine(Car12.MaxPrice);

        }
    }
    //метод расширения (расширение обозначентся Extensions) котрой находит последний символ в строке
    static class StringExtensions
    {
        public static char GetLastChar(this string sourse)
        {
            return sourse[sourse.Length - 1];
        }
    }
    //чтобы использовать данный метод, нам нужно взять экземпляр строки и вызвать для него данный метод

    string str = "Hello";
    Console.WriteLine(str.GetLastChar());
        Console.WriteLine("Строка".GetLastChar());

    static class IntExtensions
    {
        public static int GetNegative(this int a)
        {
            if (a > 0)
            {
                return -a;
            }
            else
            {
                return a;
            }
        }

        public static int GetPositive(this int a)
        {

            if (a < 0)
            {
                return a;
            }
            else
            {
                return a;
            }
        }
    }
    //Обобщённый тип
    class Generic<T>
    {
        public int Field; // Поле типа T
        public int Field = default(T); // Поле типа T. Для получения значения для определённого типа T. вернёт null, если тип T — ссылочный, и 0 — если тип значимый
        public void Method(T param) // Параметр типа T
        {

        }
    }
    //обобщение может иметь и несколько типов сразу
    class Generic<T1, T2, T3>
    {
        public T1 Field; // Поле типа T1
        public T2 Property { get; set; } // Свойство типа T2
        public void Method(T3 param) // Параметр типа T3
        {

        }

        //Для создания типов из таких обобщений нужно также указывать конкретные типы через запятую:
        Generic<object, int, string> generic = new Generic<object, int, string>();
    }

    class Order
    {
        public object Number;
        public object Description;


        //для работы с заказом мы сможем пользоваться различными типами номера заказа
        Order order1 = new Order();
        Order order2 = new Order();

        order1.Number = 1234;
        order2.Number = "NN-1234";



//чтобы воспользоваться значениями переменных для какой-то логики обработки, их нужно будет приводить к нужному типу, например, так
        int number1 = (int)order1.Number;
        string number2 = (string)order2.Number;

//ужно проверять типы, например, с использованием функции GetType()
        if (order1.Number.GetType() == typeof(int))
            {
            int number1 = (int)order1.Number;
    }
           if (order1.Number.GetType() == typeof(string))
            {
            int number2 = (string)order2.Number;


    //Благодаря обобщениям мы можем сделать класс Order универсальным — Order<T>:
    class Order<T>
    {
        public T Number;
        public T Description;
    }
    //Теперь поле Number будет того типа, который мы подставим в качестве параметра
    //Для этого при объявлении типа и при инициализации переменной используем типы Order<int> и Order<string>:
    Order<int> order1 = new Order<int>();
    Order<string> order2 = new Order<string>();

    order1.Number = 1234;
    order2.Number = "NN-1234";

    int number1 = order1.Number;
    string number2 = order2.Number;


    class Order
    {
        public int Number;
        public int Description;
        public void DisplayAddress()
        {
            Console.WriteLine(Delivery.Address);
        }
    }
    abstract class Delivery
    {
        public string Address;

    }

    class HomeDelivery : Delivery
    {

    }

    class PickPointDelivery : Delivery
    {

    }

    class ShopDelivery : Delivery
    {

    }

    class Order <TDelivery, TStruct> where TDelivery: Delivery
    {
        public TDelivery Delivery;
        public int Number;
        public string Description;

        public void DisplayAddress()
        {
            Console.WriteLine(Delivery.Address);
        }

        // ... Другие поля
    }

}

    class PremiumService<T> where T : Order<HomeDelivery>
    {
        public T Order;
    }

    class Order<TDelivery> where TDelivery : Delivery
    {

    }


    class ElectricEngine : Engine
    {

    }

    class GasEngine : Engine
    {

    }

    abstract   class CarPart
    {

    }

   abstract class Engine
    {

    }

    class Battery : CarPart
    {

    }

    class Differential : CarPart
    {

    }

    class Wheel : CarPart
    {

    }

    class ElectricCar :Car<ElectricEngine>
    {
        public override void ChangePart<TPart>(TPart newPart)
        {

        }

    }

    class GasCar : Car<GasEngine>

    {
        public override void ChangePart<TPart>(TPart newPart)
        { 
        
        }
    }

    abstract class Car<TEngine> where TEngine : Engine
    {
        public TEngine Engine;

        public virtual void ChangePart<TPart>(TPart NewPart) where TPart : CarPart

        {

        }

    }



    class Record<T1, T2>
    {

        public T1 Id;
        public T2 Value;
        public DateTime Date;
    }

    //Обобщённые методы
    //нестатическими
    class Obj
    {
        public void Display<T>(T param)
        {
            Console.WriteLine(param.ToString();
        }
    }

    //статическими
    class Program
    {
        public static void Swap<T>(ref T x, ref T y)
        {
            T t = x;
            x = y;
            y = t;
        }

        //Для демонстрации работы методов воспользуемся следующим кодом:
        static void Main(string[] args)
        {
            Obj obj = new Obj();
            obj.Display<int>(345);

            int num1 = 4;
            int num2 = 10;
            Swap<int>(ref num1, ref num2);

            Console.WriteLine("{0} {1}", num1, num2);
            Console.ReadKey();

        }

    }

    class BaseClass<T>
    {
        public T Field;

    }
    class DerivedClass<T> : BaseClass<T> 
    { 
    public T Property
        {
            get;
            set;
        }
    }
}


