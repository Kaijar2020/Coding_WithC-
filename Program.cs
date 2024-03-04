
using System;

class Test{
    // public static void Main(string[] args){
    //     // SwitchTemp();
    //     // FindPositiveNumber();
    //     // EvenOrOdd();
    //     // LargestAmongThree();
    //     // LeapYear.FindLeapYear();
    //     // LeapYear.VowelConsonent();
    //     // SwitchPractice();
    //     // Loop.forLoop();
    //     // Loop.whileLoop();
    //     Loop.NestedLoop();
   
    // }

    public static void SwitchTemp(){
         double temp = 105;
        // Console.WriteLine("Enter Temparature in Farenhite : ");
        // temp = Convert.ToDouble(Console.ReadLine());

        double lob = (temp-32)*5;
        double result = lob/9;

        Console.WriteLine("The Celcius Scale Temprature is : "+result.ToString("F2")+" Degree Celcius");
    }

    static void FindPositiveNumber(){
        int num;
        Console.WriteLine("Enter the number: ");
        num = Convert.ToInt32(Console.ReadLine());
        if(num<0){
            Console.WriteLine(num+" is a Negative number");
        }
        else if (num>0){
            Console.WriteLine(num+" is a Positive number");
        }
        else{
            Console.WriteLine(num+" is equal to zero");
        }
    }

    static void EvenOrOdd(){
        int num;
        Console.WriteLine("Enter the number: ");
        num = Convert.ToInt32(Console.ReadLine());

        if(num%2==0){
            Console.WriteLine(num+" is a Even number");
        }
        else{
            Console.WriteLine(num+" is a Odd number");
        }
    }

    static void LargestAmongThree(){
        int number1;
        Console.WriteLine("Enter the number1: ");
        number1 = Convert.ToInt32(Console.ReadLine());

        int number2;
        Console.WriteLine("Enter the number2: ");
        number2 = Convert.ToInt32(Console.ReadLine());

        int number3;
        Console.WriteLine("Enter the number3: ");
        number3 = Convert.ToInt32(Console.ReadLine());

        if(number1 > number2 && number1>number3){
            Console.WriteLine(number1+" is the Largest");
        }
        else if(number2 > number3 && number2 > number1){
            Console.WriteLine(number2+" is the Largest");
        }
        else if (number3 > number1 && number3 > number2){
            Console.WriteLine(number3+" is the Largest");
        }
        else{
            Console.WriteLine("Hmmm!..All three number are equals.");
        }
    }

    static void SwitchPractice(){
        string day;
        Console.WriteLine("Enter the day: ");
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
        day = Console.ReadLine();
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.

#pragma warning disable CS8602 // Dereference of a possibly null reference.
        switch (day.ToLower()){
            case "monday": Console.WriteLine("This is your work day");
                            break;

            case "tuesday":Console.WriteLine("This is your work day");
                            break;

            case "wednessday": Console.WriteLine("This is your work day");
                                break;

            case "thuesday": Console.WriteLine("This is your work day");
                            break;

            case "friday": Console.WriteLine("This is your short work day");
                            break;

            case "satarday": Console.WriteLine("Hmmmm!!!..This is your first vacation");
                             break;

            case "sunday": Console.WriteLine("Hmmmm.!!!..This is your first vacation");
                             break;

            default: Console.WriteLine("Invalid Input");  
                        break;
       }
#pragma warning restore CS8602 // Dereference of a possibly null reference.
    }

 
    
}