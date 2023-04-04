/*Console.Write("Pichai");
Console.Write(" ");
Console.Write("Thongarsa");

Console.ReadKey();
*/

/*string name = Console.ReadLine();
Console.WriteLine(name);*/

/*int warternuk = 60;
double sung = 1.55;

Console.WriteLine(wartern uk / (sung * sung));*/

/*int Hrung = Int32.Parse(Console.ReadLine());
if (Hrung > 80) 
{
    Console.WriteLine("A");
}
else if (Hrung >= 70) 
{
    Console.WriteLine("B");
}
else if (Hrung >= 60) 
{
    Console.WriteLine("C");
}
else if (Hrung >= 50) 
{
    Console.WriteLine("D");
}
else if (Hrung < 50) 
{
    Console.WriteLine("F");
}*/

/*string gender = "ชา" +
    "3";
int height = 150;

if(gender=="ชาย"&&height >160)
{
    Console.Write("ผ่านเกนxx");
}
if(gender == "ชาย" || height > 160)
{
    Console.Write("ผ่านหzz");
}
if (gender!="ชาย")
{
    Console.WriteLine("บ่ผ่านdc");
}    */
/*int buy = Int32.Parse(Console.ReadLine());

if (buy >= 15000)
{
    if (buy < 20000)
    {
        Console.WriteLine("sale 10%");
        Console.WriteLine("sale  " + buy * 0.1);
        Console.WriteLine("buy  " + (buy - (buy * 0.1)));

    }
    else if (buy < 30000)
    {
        Console.WriteLine("sale 20%");
        Console.WriteLine("sale  " + buy * 0.2);
        Console.WriteLine("buy  " + (buy - (buy * 0.2)));
    }
    else
    {
        Console.WriteLine("sale 30%");
        Console.WriteLine("sale  " + buy * 0.3);
        Console.WriteLine("buy  " + (buy - (buy * 0.3)));
    }
}*/

/*void wwe()
{
    Console.WriteLine("hee");
}
wwe();
 */
/*int Sum(int x , int y)
{
    return x + y;
}
Console.WriteLine(Sum(5, 5));*/

/*class Person
{
    public string name;
    public int age;
    public string gender;

    public string Name { get; set; }
    public int Age { get; set; }
    public string Gender { get; set; }

    public Person(string name, string gender, int age )
    {
        Name = name;
        Age = age;
        Gender = gender;
       
    }
    public string getInfo()
    {
        return $"ชื่อ : {Name} เพศ : {Gender} อายุ : {Age}";
    }
    static void Main(string[] args)
    {
        Person person = new Person("Pichai", "ชาย", 19);
        Console.WriteLine(person.getInfo());
    }
}
*/

class Parent
{
    private int numberOfChildren;
    private double income;
    private string role;

    public int NumberOfChildren { get; set; }
    public double Income { get; set; }
    public string Role { get; set; }

    public Parent(int numberOfChildren, double income, string role)
    {
        NumberOfChildren = numberOfChildren;
        Income = income;
        Role = role;
         
    }
}