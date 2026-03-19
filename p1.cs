// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;
using System.Collections.Generic;
public class HelloWorld
{
    public static bool is_Open(char sub_string){
        if(sub_string == '(' || sub_string == '[' || sub_string == '{' )
        {
            return true;
        }
        return false;
    }
    
    // public static bool Check_Wongleb(string Input){
    //     Stack<int> Wongleb = new Stack<int>();
    // }
   
    public static void Main(string[] args)
    {
    //   string Input = Console.ReadLine();
       Console.WriteLine(is_Open('('));
    }
}