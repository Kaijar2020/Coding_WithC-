public class LeapYear{
       public static void FindLeapYear(){
        int year;
        Console.WriteLine("Enter Year : ");
        year = Convert.ToInt32(Console.ReadLine());

        if(year%400 == 0 || ((year%4 == 0) && (year%100 !=0))){
            Console.WriteLine($"This {year} is a Leap Year");
        }
        else{
            Console.WriteLine($"This {year} is a not a Leap Year");
        }
    }

    public static void VowelConsonent(){
        char letter;
        Console.WriteLine("Enter Letter : ");
#pragma warning disable CS8604 // Possible null reference argument.
        letter = Convert.ToChar(Console.ReadLine());
#pragma warning restore CS8604 // Possible null reference argument.

        letter = char.ToUpper(letter);

        if(letter =='A' || letter == 'E' || letter == 'I' || letter == 'O' || letter == 'U'){
            Console.WriteLine($"{letter} is a Vowel");
        }
        else {
            Console.WriteLine($"{letter} is a Consonenet");
        }
    }
}