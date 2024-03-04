using System.Dynamic;

class Person{

    public string? name;
    private int age;

    // public void Setvalue(string n, int a){
    //     name = n;
    //     age = a;
    // }

    public int Age{
        get{return age ;}
        set {
            if (value >= 18){
                age = value;
            } ;}
    }

    // public void SetAge(int a){
    //     age = a;
    // }

    // public int GetAge(){
    //     return age;
    // }

    public void Display(){
         Console.WriteLine($"Name : {name} and Age : {age}");
    }
}
class TestOOP {

    // public static void Main(string[] args){
    //     Console.WriteLine("Welcome to OOP");

    //     Person p1 = new Person();
    //     Person p2 = new Person();
    //     p2.name = "Abcd";
    //     // p2.age = 21;
    //     // p1.SetAge(23);
    //     // p1.Setvalue("Akib", 25);
    //     p1.Age = 23;
    //     p1.Display();
    //     Console.WriteLine($"Name : {p1.name} and Age : {p1.Age}");
    // }

}