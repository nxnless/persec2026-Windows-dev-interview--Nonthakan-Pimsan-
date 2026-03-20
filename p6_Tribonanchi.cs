// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

public class HelloWorld
{
    public static int current;
    public static int loop_sum(int start , int[] arr){
        if(start == 1){
            return arr[0];
        }if(start == 2){
            return arr[0]+arr[1];
        }else{
            return arr[start]+arr[start-1]+arr[start-2]+arr[start-3];
        }
        return 1;
    }
    
    public static void PrintLoop(int[] num){
        Console.Write("[");
        for(int i = 0 ; i < num.Length ; i++){
            Console.Write(num[i]+",");
        }
        Console.WriteLine("]");
    }
    
    public static void Tribonanchi(int[] num , int goal){
        int[] result = new int[goal];
        current = num.Length;
        
         for(int i = 0 ; i < num.Length ; i++){
            result[i] = num[i];
        }
        if(goal > num.Length){
            for(int i = num.Length ; i < goal ; i++){
                result[i] = loop_sum(i , result);
            }
        }
     
        
        PrintLoop(result);
    }
    
    public static void Main(string[] args)
    {
        // Input qty
        int[][] testcase = new int[][]
        {
            new int[] {1},
            new int[] {5, 2},
            new int[] {7, 8, 9},
            new int[] {3},
            new int[] {4, 6},
            new int[] {10, 11},
            new int[] {9},
            new int[] {12, 3, 5},
            new int[] {8, 2},
            new int[] {6},
            new int[] {14, 15, 1},
            new int[] {7, 9},
            new int[] {2},
            new int[] {11, 4, 8},
            new int[] {5}
        };
        
        Console.WriteLine("Enter Quantity 0 - 3");
        int Set_num = Convert.ToInt32(Console.ReadLine());
        int[] arrInt = new int[Set_num];
        if( Set_num <= 3 && Set_num > 0){ //Check num
              for(int i = 0 ; i < Set_num ; i++){ // Loop For keep num
                  Console.WriteLine("Enter num");
                  arrInt[i] = Convert.ToInt32(Console.ReadLine());
              }
            Console.WriteLine("Enter Quantity Result");
            int qty_result = Convert.ToInt32(Console.ReadLine());
            
            Tribonanchi(arrInt , qty_result);
        }else{
            Console.WriteLine("Wrong Number");
        }
        
        Console.WriteLine("Testcase");
      for(int i = 0 ; i < 15 ; i++){
        Tribonanchi(testcase[i] , 5);
      }
        
    }
}