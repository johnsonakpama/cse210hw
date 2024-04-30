using System;

public class Resume
{
   public string _name;

   public List<Job> _jobs = ne List<Job>(); 

   public void Display()
   {
     Console.WriteLine($"Name: {_name}");
     Console.WriteLine($"Job: {_jobs}");

     foreach (Job job in _jobs item in collection)
     {
        job.Display();
     }
   }
}