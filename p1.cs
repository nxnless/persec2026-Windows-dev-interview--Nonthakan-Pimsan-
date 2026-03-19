// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;
using System.Collections.Generic;
public class HelloWorld
{
    public static bool is_Pair(char sub_string , Stack<int> Wongleb){
        int toInt = sub_string;
        //  Console.WriteLine(toInt);
        if(toInt == 41 && Wongleb.Peek() == 40){
            return true;
        }else if(toInt == 93 && Wongleb.Peek() == 91){
            return true;
        }else if(toInt == 125 && Wongleb.Peek() == 123){
            return true;
        }
        return false;
    }
    
    public static bool is_Open(char sub_string){
        if(sub_string == '(' || sub_string == '[' || sub_string == '{' )
        {
            return true;
        }
        return false;
    }
    
    public static bool is_Wongleb(char i){
        int a = i;
        if(a == 40 || a == 41 ||a == 91 ||a == 93 ||a == 123 || a== 125){
            return true;
        }
        return false;
    }
    
    
    public static bool Check_Wongleb(string Input){
        Stack<int> Wongleb = new Stack<int>();
        
        for(int i = 0 ; i < Input.Length ; i++){
            if(is_Wongleb(Input[i])){
                if(is_Open(Input[i])){
                    Wongleb.Push(Input[i]);
                }else{
                    if(Wongleb.Count > 0){
                        if(is_Pair(Input[i] , Wongleb)){
                            Wongleb.Pop();
                        }else{
                            // Console.WriteLine("MaiJing");
                            return false;
                        }
                    }
                }
            }
            // else{ 
            //     return false;
            // }
         
        }
          if (Wongleb.Count > 0){
            //   Console.WriteLine("MaiJing");
              return false;
          }else{
            //   Console.WriteLine("JingKub");
              return true;
          }
    }
    public static void Main(string[] args)
    {
        string[] testcase = {
    "()",
    "()[]{}",
    "{[()]}",
    "((()))",
    "{[()()]()}",
    "",              
    "([]{})",
    
    "(",
    ")",
    "(()",
    "())",
    "([)]",           
    "{[(])}",
    "((()",
    "())(()",
    "(((((((((())))))))))",
    "[]{}()[]{}()",
    "{",
    "}",
    "][",
    "}{",
    "([{}])(){}[]",
    "(a+b)*(c-d)",
    "(a+b]*(c-d)",   
    "if(x[0] == '{') { return; }",
    "for(int i=0; i<n; i++) { arr[i] = (i+1); }"
    };
        string Input = Console.ReadLine();
        Console.WriteLine("Input is" + Input);
        Console.WriteLine(Check_Wongleb(Input));  
        // Console.WriteLine(is_Open('('));
        for(int i = 0 ; i < testcase.Length ; i++){
            Console.WriteLine("Input testcase "+i+" is"+testcase[i]);
            Console.WriteLine(Check_Wongleb(testcase[i]));  
            
        }
    }
}