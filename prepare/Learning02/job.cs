public class Job

    //STATE 
    //OBJECTS or MEMBER VARIABLE ------------------------------------------------------
{
    public string _company;
    public string _jobTitle;
    public int _startYear;
    public int _endYear;
    //OBJECTS or MEMBER VARIABLE ------------------------------------------------------


    //BEHAVIOR
    //METHOD -------------------------------------------------------
    public void DisplayJobDeets()
    {
        Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}");
    }
    //METHOD --------------------------------------------------------



}