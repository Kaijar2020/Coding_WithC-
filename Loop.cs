public class Loop{

    public static void forLoop(){
        int range;
        Console.WriteLine("Ente rthe range : ");
        range = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("The Even Number is : ");


        for(int i = 1 ; i<=range; i++){ 
            if(i%2==0){
                Console.Write($"{i}\t");
            }
        }
    }

    public static void whileLoop(){
        int range;
        Console.WriteLine("Ente rthe range : ");
        range = Convert.ToInt32(Console.ReadLine());

        int i = 1;
        int fact = 1;
        while(i<=range){
            fact *= i;
            i++;
        }
        
       Console.WriteLine($"The Factorial number of {range} is {fact}"); 
    }

    public static void NestedLoop(){

        int start_number ,end_number;

        Console.WriteLine("Ente start number : ");
        start_number = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Ente end number : ");
        end_number = Convert.ToInt32(Console.ReadLine());

        for(int i = start_number; i<=end_number; i++){
            for(int j = 1 ; j<11; j++){
                Console.WriteLine($"{i} * {j} = {i*j}");
            }
            Console.WriteLine("================");
        }
    }
    
}