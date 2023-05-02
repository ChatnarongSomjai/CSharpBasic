
//Console.WriteLine("Hello, World!");

/*
int num1 = 0;
long num2 = 10;

Console.WriteLine("Number : {0}", num1, num2);
Console.WriteLine("Number : {0}", num2);
Console.WriteLine("$Number : {0}", num1);

 */

/*
long num1 = 3000000000;

string text = "asdwda";

char text2 = "a";

*/

/*
double d1 = 700;
int d2 = Convert.ToInt32(d1);

string num1 = "1000";
string num2 = "500";

int num3 = int.Parse(num1);
int num4 = int.Parse(num2);

Console.WriteLine(num3+num4);
*/

/*
//Console.Write("Enter Your Name : ");
//string name = Console.ReadLine();

Console.Write("No : ");
string num2 = Console.ReadLine();

Console.WriteLine($"My name: {name} ");
Console.WriteLine($"{num1}+{num2}= {num1 + num2}");
*/

/*
int num1 = 5;
int num2 = 10;
double num3 = 9.3;

Console.WriteLine(Math.Ceiling(num3));
*/

/*
using System;
class Program
{
    static void Main()
    {
        // รับข้อมูลคนที่ 1
        Console.WriteLine("No.1");
        Console.Write("name: ");
        string name1 = Console.ReadLine();
        Console.Write("weight (kg): ");
        double weight1 = double.Parse(Console.ReadLine());
        Console.Write("height (cm): ");
        double height1 = double.Parse(Console.ReadLine());

        // รับข้อมูลคนที่ 2
        Console.WriteLine("\nNo 2");
        Console.Write("name: ");
        string name2 = Console.ReadLine();
        Console.Write("weight (kg): ");
        double weight2 = double.Parse(Console.ReadLine());
        Console.Write("height (cm): ");
        double height2 = double.Parse(Console.ReadLine());

        // คำนวณค่า BMI สำหรับคนที่ 1
        double heightInMeter1 = height1 / 100; // แปลงเป็นเมตร
        double bmi1 = weight1 / (heightInMeter1 * heightInMeter1);

        // คำนวณค่า BMI สำหรับคนที่ 2
        double heightInMeter2 = height2 / 100; // แปลงเป็นเมตร
        double bmi2 = weight2 / (heightInMeter2 * heightInMeter2);

        // แสดงผลลัพธ์
        Console.WriteLine("\n Result");
        Console.WriteLine("name: " + name1.ToUpper());
        Console.WriteLine("BMI: " + Math.Round(bmi1, 2));

        Console.WriteLine("\nname: " + name2.ToUpper());
        Console.WriteLine("BMI: " + Math.Round(bmi2, 2));

        // ค้นหาค่า BMI ที่มากที่สุด
        double maxBmi = Math.Max(bmi1, bmi2);
        Console.WriteLine("\n Most BMI : " + Math.Round(maxBmi, 2));
    }
}

*/
/*
double x = 7;
double y = 3;
Console.WriteLine(x+3);
x = 7;
Console.WriteLine(x + 3);
Console.WriteLine(x++);
Console.WriteLine(++y);

Console.WriteLine(x);
Console.WriteLine(y);

double x1 = x++;
double x2 = ++x;
 Console.WriteLine(x1);
Console.WriteLine(x2);
*/

/*
string role = "admin";
if (role == "admin") {
    Console.WriteLine("user is admin");
} else if (role =="admin1")
{
    Console.WriteLine("user is admin1");
}
else
{
    Console.WriteLine("User is Worng");
}
*/
/*
using System;

class Program
{
    static void Main()
    {
        // รับข้อมูลตำแหน่งงานและเงินเดือน
        Console.Write("Position: ");
        string position = Console.ReadLine();
        Console.Write("Salary: ");
        float salary = float.Parse(Console.ReadLine());

        // ตรวจสอบตำแหน่งงานและเพิ่มเงินเดือนตามเงื่อนไข
        float increasedSalary = 0;
        switch (position)
        {
            case "Assistant Developer":
                increasedSalary = salary * 0.0f;
                break;
            case "IT Support":
                increasedSalary = salary * 0.07f;
                break;
            case "Senior Developer":
                increasedSalary = salary * 0.1f;
                break;
            case "Administrator":
                increasedSalary = salary * 0.08f;
                break;
            default:
                increasedSalary = salary * 0.03f;
                break;
        }

        // แสดงผลลัพธ์
        Console.WriteLine("Increased Salary: " + increasedSalary);
    }
}
*/

/*
using System;

class Program
{
    static void Main()
    {
        // รับข้อมูลตำแหน่งงานและเงินเดือน
        Console.Write("Position: ");
        string position = Console.ReadLine();
        Console.Write("Salary: ");
        float salary = float.Parse(Console.ReadLine());

        // ตรวจสอบตำแหน่งงานและเพิ่มเงินเดือนตามเงื่อนไข
        float increasedSalary = 0;
        if (position == "Assistant Developer")
        {
            increasedSalary = salary * 0.05f;
        }
        else if (position == "IT Support")
        {
            increasedSalary = salary * 0.07f;
        }
        else if (position == "Senior Developer")
        {
            increasedSalary = salary * 0.1f;
        }
        else if (position == "Administrator")
        {
            increasedSalary = salary * 0.08f;
        }
        else
        {
            increasedSalary = salary * 0.03f;
        }

        // คำนวณเงินเดือนที่เพิ่มขึ้น
        float totalSalary = salary + increasedSalary;

        // แสดงผลลัพธ์
        Console.WriteLine("Increased Salary: " + increasedSalary);
        Console.WriteLine("Total Salary: " + totalSalary);
    }
}

*/

//int num = 0;
/*while (num <=5)
{
    ++num;
    Console.WriteLine(num);
}
Console.WriteLine("Exit Loop");*/
/*
do
{
    ++num;
    Console.WriteLine(num);
} while (num<=5);

Console.WriteLine("Exit Loop");*/
/*
for(int i = 0;i <= 5; i++)
{
    Console.WriteLine(i);
}
*/
/*
string name = "Jet";
foreach(char character in name)
{
    Console.WriteLine(character);
}
*/
/*
string[] cars = new string[] { "Ford","Toyota","Honda","BMW","Benz","MG"};
Array.Resize(ref cars, 7);
cars[6] = "Jaguar";

Array.Sort(cars);

foreach (string car in cars) { 
        Console.WriteLine(car);
 }
Console.WriteLine("-------------");
Array.Reverse(cars);

foreach(string car in cars)
{ 
       Console.WriteLine(car); 
}

string[] cars2 = new string[4];
Console.WriteLine("-----------------------");
Array.Copy(cars, cars2, 3);
foreach(string car in cars2)
    {
    Console.WriteLine(car);
}

Console.WriteLine("---------------");
Console.WriteLine(Array.IndexOf(cars2,"Ford"));

Console.WriteLine("----------------");
Console.WriteLine(cars2.Length);
foreach (string car in cars)
{
    Console.WriteLine(car);
}
*/
/*
List<int> Listnumber = new List<int>();

foreach(int n in Listnumber)
{
    Console.WriteLine(n);
};
Console.WriteLine("----------------");
Listnumber.Add(0);
Listnumber.Add(1);

foreach (int n in Listnumber)
{
    Console.WriteLine(n);
};
Console.WriteLine("----------------");
Listnumber.Remove(0);

foreach(int n in Listnumber)
{
    Console.WriteLine(n);
};

if (Listnumber.Contains(1))
{
    Console.WriteLine("True");
}
else {
    Console.WriteLine("Flase");
}

*/
/*
HashSet<int> SetOfNumber1 = new HashSet<int>();
SetOfNumber1.Add(50);
SetOfNumber1.Add(100);
SetOfNumber1.Add(150);

HashSet<int> SetOfNumber2 = new HashSet<int>();
SetOfNumber2.Add(90);
SetOfNumber2.Add(150);
SetOfNumber2.Add(170);

foreach (int i in SetOfNumber1)
{
    Console.WriteLine(i);
}
Console.WriteLine("----------------");
foreach (int i in SetOfNumber2)
{
    Console.WriteLine(i);
}
Console.WriteLine(SetOfNumber1.Count);
Console.WriteLine(SetOfNumber2.Count);

Console.WriteLine("----------------");

SetOfNumber1.IntersectWith(SetOfNumber2);
foreach (int i in SetOfNumber1)
{
    Console.WriteLine(i);
}
Console.WriteLine("----------------");
SetOfNumber1.UnionWith(SetOfNumber2);
foreach (int i in SetOfNumber1)
{
    Console.WriteLine(i);
}
Console.WriteLine("----------------");
SetOfNumber1.ExceptWith(SetOfNumber2);
foreach (int i in SetOfNumber1)
{
    Console.WriteLine(i);
}
*/
/*
Dictionary<string,int>citiesRepulation = new Dictionary<string,int>();

citiesRepulation.Add("Bangkok", 1000000);
citiesRepulation.Add("Pataya", 800000);
int num = 0;
//Console.WriteLine(citiesRepulation("Bangkok"));
if(citiesRepulation.TryGetValue("Bangkok",out num))
{
    Console.WriteLine(num);
}else
{
    Console.WriteLine(num);
}

foreach (KeyValuePair<string, int> number in citiesRepulation)
{ 
    Console.WriteLine(number.Key);
}
*/
/*
using System;

class Program
{
    static void Main()
    {
        bool exit = false;
        while (!exit)
        {
            Console.Write("Enter the number of students: ");
            int numberOfStudents = int.Parse(Console.ReadLine());

            double maxScore = double.MinValue;  // คะแนนสูงสุด
            double minScore = double.MaxValue;  // คะแนนต่ำสุด

            for (int i = 0; i < numberOfStudents; i++)
            {
                Console.WriteLine("----------------");
                Console.Write("\nEnter student ID: ");
                string studentID = Console.ReadLine();

                Console.Write("Enter student score: ");
                double studentScore = double.Parse(Console.ReadLine());

                Console.WriteLine("Student ID: " + studentID);
                Console.WriteLine("Student Score: " + studentScore);


                // หาคะแนนสูงสุดและต่ำสุด
                maxScore = Math.Max(maxScore, studentScore);
                minScore = Math.Min(minScore, studentScore);
            }
            

            string exitChoice = "";
            while (exitChoice != "Y" && exitChoice != "N")
            {
                Console.WriteLine("----------------");
                Console.Write("Exit? (Y/N): ");
                exitChoice = Console.ReadLine().ToUpper();
            }
            if (exitChoice == "N")
            {
                continue;  // วนกลับไปทำขั้นตอนใหม่
            }
            else if (exitChoice == "Y")
            {
                exit = true;  // ออกจากลูป
            }
            Console.WriteLine("Number of Students: " + numberOfStudents);
            Console.WriteLine("Max Score: " + maxScore);
            Console.WriteLine("Min Score: " + minScore);
        }
            Console.WriteLine("----------------");
           
    }
}

*//*
class person
{ 
    private string name;
    private int age;

    public string Name
    {
        get { return name; }
        set { name = value; }

    }

    public int Age
    {
        get { return age; }
        set { age = value; }
    }
}

class Program
{
    public static void Main()
    {
        person P1= new person();
        P1.Name = "Jet";
        P1.Age = 22;

        Console.WriteLine(P1.Name);
        Console.WriteLine(P1.Age);  

        Console.WriteLine("------------------");

        person P2= new person();
        P2.Name = "Jojo";
        P2.Age = 22;

        Console.WriteLine(P2.Name);
        Console.WriteLine(P2.Age);
    }
}

class Employee:person
{
    public static void Salary()
    {
        Console.WriteLine("[0] salary = 50000", Name);

    }
}
*/











/*
using System;

// Parent Class
class Parent
{
    // Attribute
    public string ParentAttribute { get; set; }

    // Method
    public void ParentMethod()
    {
        Console.WriteLine(" method from the Parent Class");
    }
}

// Child Class
class Child : Parent
{
    // Additional Attribute
    public string ChildAttribute { get; set; }

    // Additional Method
    public void ChildMethod()
    {
        Console.WriteLine(" method from the Child Class");
    }

    // Constructor Method
    public Child(string parentAttribute, string childAttribute)
    {
        ParentAttribute = parentAttribute;
        ChildAttribute = childAttribute;
    }
}

class Program
{
    static void Main()
    {
        // Create an object from the Child Class
        Child childObject = new Child("Parent Attribute Value", "Child Attribute Value");

        // Access and use the inherited attribute and method from the Parent Class
        Console.WriteLine("Parent Attribute: " + childObject.ParentAttribute);
        childObject.ParentMethod();

        // Access and use the attribute and method of the Child Class
        Console.WriteLine("Child Attribute: " + childObject.ChildAttribute);
        childObject.ChildMethod();
    }
}
*/
/*
using System;

// Parent Class - Vehicle
class Vehicle
{
    // Attribute
    public string Brand { get; set; }

    // Method
    public void Drive()
    {
        Console.WriteLine("Driving the vehicle");
    }
}

// Child Class - Car (Inherits from Vehicle)
class Car : Vehicle
{
    // Additional Attribute
    public string Model { get; set; }

    // Additional Method
    public void Honk()
    {
        Console.WriteLine("Honking the car horn");
    }

    // Constructor Method
    public Car(string brand, string model)
    {
        Brand = brand;
        Model = model;
    }
}

class Program
{
    static void Main()
    {
        // Create an object from the Child Class (Car)
        Car myCar = new Car("Toyota", "Camry");

        // Access and use the inherited attribute and method from the Parent Class (Vehicle)
        Console.WriteLine("Brand: " + myCar.Brand);
        myCar.Drive();

        // Access and use the attribute and method of the Child Class (Car)
        Console.WriteLine("Model: " + myCar.Model);
        myCar.Honk();
    }
}
*/
/*
using System;

// Parent Class - Food
class Food
{
    // Attribute
    public string Name { get; set; }

    // Method
    public void Eat()
    {
        Console.WriteLine("Eating " + Name);
    }
}

// Child Class - DailyFood (Inherits from Food)
class DailyFood : Food
{
    // Additional Attribute
    public string TimeOfDay { get; set; }

    // Additional Method
    public void Digest()
    {
        Console.WriteLine("Digesting " + Name);
    }

    // Constructor Method
    public DailyFood(string name, string timeOfDay)
    {
        Name = name;
        TimeOfDay = timeOfDay;
    }

    // Additional Method
    public void Describe()
    {
        Console.WriteLine("Name: " + Name);
        Console.WriteLine("Time of Day: " + TimeOfDay);
    }
}

class Program
{
    static void Main()
    {
        // Create an object from the Child Class (DailyFood)
        DailyFood myFood = new DailyFood("Rice", "Lunch");

        // Access and use the inherited attribute and method from the Parent Class (Food)
        Console.WriteLine("Food Name: " + myFood.Name);
        myFood.Eat();

        // Access and use the attribute and method of the Child Class (DailyFood)
        Console.WriteLine("Time of Day: " + myFood.TimeOfDay);
        myFood.Describe();
        myFood.Digest();
    }
}
*/


/*
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp1
{
    internal class Animalcs
    {
        private string sex;
        private double normalSpeed;
        public string Sex { get { return sex; } set { sex = value; } }
        public double NormalSpeed { get { return normalSpeed; } set { normalSpeed = value; } }

        public virtual double Run()
        {
            return normalSpeed * 2.5;
        }
    }

    internal class Cheetah : Animalcs
    {
        public Cheetah(string sex, double normalSpeed)
        {
            Sex = sex;
            NormalSpeed = normalSpeed;
        }
        public override double Run()
        {
            return NormalSpeed * 4.5;
        }
    }

    internal class Tortoise : Animalcs
    {
        public Tortoise(string sex, double normalSpeed)
        {
            Sex = sex;
            NormalSpeed = normalSpeed;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Cheetah cheetah = new Cheetah("M", 79.5);
            Tortoise tortoise = new Tortoise("F", 7.2);

            double cheetahrun = cheetah.Run();
            double tortoiseRun = tortoise.Run();

            Console.WriteLine($"Cheetah run speed = {cheetahrun}");
            Console.WriteLine($"Tortoise run speed = {tortoiseRun}");
        }
    }
}

*/
using System;

namespace Test01
{
    internal class SportsCar
    {
        private string brand;
        private double actualSpeed;
        public string Brand { get { return brand; } set { brand = value; } }
        public double ActualSpeed { get { return actualSpeed; } set { actualSpeed = value; } }

        public virtual double GetSpeed()
        {
            return actualSpeed;
        }
    }

    internal class Lamborghini : SportsCar
    {
        public Lamborghini(string brand, double actualSpeed)
        {
            Brand = brand;
            ActualSpeed = actualSpeed;
        }

        public override double GetSpeed()
        {
            return ActualSpeed;
        }
    }

    internal class Ferrari : SportsCar
    {
        public Ferrari(string brand, double actualSpeed)
        {
            Brand = brand;
            ActualSpeed = actualSpeed;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Lamborghini lamborghini = new Lamborghini("Lamborghini Aventador", 349.5);
            Ferrari ferrari = new Ferrari("Ferrari 488 GTB", 340.2);

            double lamborghiniSpeed = lamborghini.GetSpeed();
            double ferrariSpeed = ferrari.GetSpeed();

            Console.WriteLine($"Lamborghini speed = {lamborghiniSpeed} km/h");
            Console.WriteLine($"Ferrari speed = {ferrariSpeed} km/h");
        }
    }
}
