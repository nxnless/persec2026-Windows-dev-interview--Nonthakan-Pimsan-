// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;
using System.Collections.Generic;
using System.Linq;
public class HelloWorld
{
    public static bool Check_Equal_point(string search , string word , int point){
        
        
        string sub_word = word.Substring(point , search.Length);
        
        // Console.WriteLine("Search " + search + " sub Word " + sub_word);
        // Console.WriteLine(String.Equals(search, sub_word, StringComparison.OrdinalIgnoreCase));
        return String.Equals(search, sub_word, StringComparison.OrdinalIgnoreCase);
    }
    

    public static void Search_Words(string search , List<string> data , int MaxResult){
        var Result = new List<string>();
        // Console.WriteLine(data.Count);
        
        // Remove Data not used
        for (int i = data.Count - 1; i >= 0; i--){
            if(!data[i].ToLower().Contains(search.ToLower())){
                data.RemoveAt(i);

                //return null if search data is invalid
                if(data.Count == 0)
                    return ;
            }
        }
        // Console.WriteLine(data.Count);
        // foreach(var a in data){
        //     Console.WriteLine(a);
        // }
       
        var maxLength = data.Max(s => s.Length); 
        
        for(int point = 0 ; point <= maxLength - search.Length ; point++){
            int i = 0;
            while(i < data.Count){
                // Console.WriteLine("Check " + search + " in "+ i);
                if(Check_Equal_point(search , data[i] , point)){
                    // Console.WriteLine("Currect"+data[i]);
                    Result.Add(data[i]);
                    data.RemoveAt(i);
                    i = 0;
                }
                i++;
            }
    
        }
        
      for(int i = 0 ; i< MaxResult ; i++){
          if(i<Result.Count){
              Console.Write("`"+Result[i]+"` ");
          }
      }
    }
    
    public static void Main(string[] args)
    {
        var data = new List<string>()
        {"cat", "bat", "rat", "mat"};
        // {"Mother", "Think", "Worthy", "Apple", "Android"};
        Console.WriteLine("Enter Your Search Word");
        string search = Console.ReadLine();
        Console.WriteLine("Enter Your Max Result");
        int MaxResult = Convert.ToInt32(Console.ReadLine());
        // Console.WriteLine(Check_Equal_point(search,data[1],0));
        Search_Words(search,data,MaxResult);
        
        object[][] testcases = new object[][]
        {
          
            new object[] {"th", new List<string>(){"Mother", "Think", "Worthy", "Apple", "Android"}, 1},
            new object[] {"ap", new List<string>(){"apple", "banana", "grape", "apricot"}, 3},
            new object[] {"ki", new List<string>(){"Kiwi", "Mango", "Pineapple"}, 5},
            new object[] {"TH", new List<string>(){"THINK", "thought", "Through"}, 3},
            new object[] {"zzz", new List<string>(){"apple", "banana"}, 0},
            new object[] {"apple", new List<string>(){"apple", "apple", "apple"}, 3},
            new object[] {" ", new List<string>(){"Hello World", "Open AI", "C#"}, 2},
            new object[] {"at", new List<string>(){"cat", "bat", "rat", "mat"}, 4}
        };

        // Loop ผ่าน test cases
        for (int t = 0; t < testcases.Length; t++)
        {
            Console.WriteLine($"\n--- Test Case {t+1} ---");
            string searchT = (string)testcases[t][0];
            List<string> dataT = (List<string>)testcases[t][1];
            int maxResultT = (int)testcases[t][2];
            Search_Words(searchT, dataT, maxResultT);
        }
        
        
    }
}