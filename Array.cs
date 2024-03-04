using System.Diagnostics.CodeAnalysis;

class Array{

    public static void Main(string[] args){
        // ArrayExample();
        TwoDArray();
    }

    static void ArrayExample(){
        int[] numbers = {-10, 20, -30, 40, 50,0};
        int sum =0;
        foreach(int number in numbers){
            if(number>0){
                 sum += number;
            }
        }
        Console.WriteLine(sum);
    }

    static void TwoDArray(){
        int[,] matrix = {{1,2,3},{4,5,6}};

        for(int row =0; row<2; row++){
            for(int col =0; col<3; col++){
                Console.Write(matrix[row,col]+" ");
            }
            Console.WriteLine();
        }
    }
}