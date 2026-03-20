// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

public class HelloWorld
{
    public static object[][] Roman_Value = new object[][]
    {
        new object[] {1000,"M"},
        new object[] {900,"CM"},
        new object[] {500,"D"},
        new object[] {400,"CD"},
        new object[] {100,"C"},
        new object[] {90,"XC"},
        new object[] {50,"L"},
        new object[] {40,"XL"},
        new object[] {10,"X"},
        new object[] {9,"IX"},
        new object[] {5,"V"},
        new object[] {4,"IV"},
        new object[] {1,"I"},
    };
    
    public static void ConvertRoman(int Input){
        Console.WriteLine("Your Input is "+ Input);
        string result = "";
        int num = Input;
        for(int i = 0 ; i<13 ; i++ ){
            
            // int j = 0;
            int numR = (int)Roman_Value[i][0];
            string WriteR = (string)Roman_Value[i][1];
            if(num/numR > 0){
                //  Console.WriteLine(Roman_Value[i][0]);
                for(int j = 0 ; j < num/ numR ; j++){
                    result += WriteR;
                }
                // result += WriteR * (num/numR);
                num %=numR;
            }
           
        }
        Console.WriteLine("Output = " + result);
       
    }
    
    
    public static void Main(string[] args)
    {
         int[] testcase = new int[]
        {
            1023, 5876, 1205, 999, 4500,
            7832, 1500, 6700, 2345, 8901,
            3200, 4567, 2100, 7543, 8888,
            1345, 9999, 5400, 6789, 1123
        };
        int Input = Convert.ToInt32(Console.ReadLine());
        ConvertRoman(Input);
        
          for(int i = 0 ; i < testcase.Length ; i++){
            Console.WriteLine("");
            ConvertRoman(testcase[i]);
        }
    }
}