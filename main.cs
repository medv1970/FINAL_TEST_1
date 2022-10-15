using System;
          
public class Program
{
  private static String[] Filter(String[] arr) {
    String[] result = new String[arr.Length];
    int counter = 0;
    foreach (string i in arr)
    {
     if (i.Length <= 3) {
       result[counter] = i;
       counter++;
     }
    }
    return result;
  }
  
  
  public static void Main()
  {
    string[] a = new string[]{"hello", "2", "world", ":-)"};
    string[] b = new string[]{"1234", "1567", "-2", "computerscience"};
    string[] c = new string[]{"Russia", "Denmark", "KAZAN"};

  
    Array.ForEach(Program.Filter(a), Console.WriteLine);
    Array.ForEach(Program.Filter(b), Console.WriteLine);
    Array.ForEach(Program.Filter(c), Console.WriteLine);
    
  }
}