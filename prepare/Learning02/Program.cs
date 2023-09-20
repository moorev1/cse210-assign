using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "IT instructor";
        job1._company = "Presbyterian Acaemy High School";
        job1._startYear = 2017;
        job1._endYear = 2019;

        Job job2 = new Job();
        job2._jobTitle = "Warehouse Supervisor";
        job2._company = "Jomra Electricals";
        job2._startYear = 2020;
        job2._endYear = 2022;
        
         Job job3 = new Job();
        job3._jobTitle = "Technology specialist";
        job3._company = "The Church Of Jesus Christ Of Latter Day Saints ";
        job3._startYear = 2022;
        job3._endYear = 2023;

        Resume myResume = new Resume();
        myResume._name = "Vincent Moore";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);
         myResume._jobs.Add(job3); // added job 3 to the list


        myResume.Display();
    }
}
