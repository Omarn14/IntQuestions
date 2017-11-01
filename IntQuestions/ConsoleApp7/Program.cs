using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            string[] Question = { "What are your strengths? ","What are your weaknesses?" , "Who's your mentor?",
            "Who's your mentor?" , "Who is someone you look up to? Why?" , "Name someone in your career who really made a difference.",
            "Are you willing to travel?" , "How much are you willing to travel?" , "What's your availability? When can you start work?",
            "How long do you expect to work for this company?" , "Why do you want to leave your current company?" ,
            "Why are you looking for a new job?", "Why are you leaving the military?", "Tell me about a time when you disagreed with your boss. How did you handle it?",
            "How would you handle a disagreement if your boss was wrong?" , " What do you expect from a supervisor?" ,
            "If I called your boss right now and asked him what is an area that you could improve on, what would he say?",
            "What are three positive things your last boss would say about you?", "What negative thing would your last boss say about you",
            "Tell me about yourself." , "What was the last book you read for fun?" , "Tell me about an accomplishment you are most proud of." ,
            "What's the most difficult decision you've made in the last two years and how did you come to that decision?" };

            start: 

            int InterviewQ = rnd.Next(0, Question.Length);

            Console.WriteLine("{0}", Question[InterviewQ]);
            Console.ReadLine();

            goto start;
        }
    }
}
