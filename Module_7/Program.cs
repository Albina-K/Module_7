using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
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

    class  Car
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
    class  CivilServant: Citizen
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
    class President: CivilServant
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
    class InheritedClass10:BaseClass10
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
    }

        Vector a = new Vector { X = 3, Y = 5};
        Vector b = new Vector { X = 7, Y = 13 };
        Vector c = new Vector { X = a.X + b.X, Y = a.Y + b.Y };
}
