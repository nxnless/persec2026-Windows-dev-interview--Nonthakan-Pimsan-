
using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine()); 
        string[] Input = new string[n];
     
        for(int i = 0 ; i < n ; i++){
             Input[i] = Console.ReadLine();
        }
        Array.Sort(Input);
       for(int i = 0 ; i< n ;i++){
           Console.WriteLine(Input[i]);
       }
        
    }
}