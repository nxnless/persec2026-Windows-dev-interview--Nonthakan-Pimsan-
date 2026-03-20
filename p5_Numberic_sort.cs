// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

public class HelloWorld
{
    public static void SortNum(int Input){
        Console.WriteLine("Your Input is "+ Input);
        string a = Input.ToString();
        char[] charInput = a.ToCharArray();
        Array.Sort(charInput);
        Array.Reverse(charInput);
        int final_number = int.Parse(charInput);
        Console.WriteLine("Your Output is "+final_number);
    }
    
    public static void Main(string[] args)
    {
      int[] testcase = new int[]
        {
            1023, 5876, 12045, 9999, 45000,
            78321, 1500, 67000, 23456, 8901,
            32000, 45678, 2100, 76543, 88888,
            13450, 99999, 5400, 67890, 11234
        };
        
        int Input = Convert.ToInt32(Console.ReadLine());
        SortNum(Input);
       
        for(int i = 0 ; i < testcase.Length ; i++){
            Console.WriteLine("");
            SortNum(testcase[i]);
        }
        
    }
}