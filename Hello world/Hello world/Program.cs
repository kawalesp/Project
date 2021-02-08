using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hello_world
{
    public class Program
    {
        public static void Main(string[] args)
        {
     
        string sentence;
        Console.Write("Enter String  : ");
        sentence = Console.ReadLine();
        string[] words = sentence.Split(' ');
        Console.WriteLine("Count of words :" + words.Length);
        Console.ReadKey();
      }

    }
  }
