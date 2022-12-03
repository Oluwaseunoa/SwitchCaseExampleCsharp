class Program
{
    static void Main() 
    
    {
       //variable to store grade letter of student
       char gradeLetter = 'A';

        // find out the description based on the grade letter
        string gradeDescription;

        switch (gradeLetter)
        {
            case 'A': gradeDescription = "Outstanding"; break;
            case 'B': gradeDescription = "Excelent"; break;
            case 'C': gradeDescription = "Good"; break;
            case 'D': gradeDescription = "Average"; break;
            case 'F': gradeDescription = "Fail"; break;
            default: gradeDescription = "None"; break;
        }
        System.Console.WriteLine(gradeDescription);
        System.Console.ReadKey();   
    }
}