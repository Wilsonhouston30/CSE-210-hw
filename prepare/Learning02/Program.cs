using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello this is practive");
         Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Microsoft";
        job1._startYear = 2019;
        job1._endYear = 2022;

        Console.WriteLine($"{job1._jobTitle} ({job1._company}) {job1._startYear}--{job1._endYear}");

        Job job2 = new Job();
        job2._jobTitle = "Janiitor";
        job2._company = "Nike";
        job2._startYear = 1999;
        job2._endYear = 2023;
        Console.WriteLine();
        job2.Display();

        Resume resume1 = new Resume();
        resume1._name = "Wilson Houston";

        resume1._job.Add(job1);
        resume1._job.Add(job2);

        resume1.Display();
        



    }
}