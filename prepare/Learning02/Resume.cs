using System.Security.Cryptography.X509Certificates;

public class Resume

{
    //MEMBER VAR -----------------------------------------------------
    public string _name;
    //MEMBER VAR -----------------------------------------------------

    public List<Job> _jobs = new List<Job>();


    public void MyResume()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Jobs:");

        foreach(Job job in _jobs)
        {
            job.DisplayJobDeets();
        }
    }



}