using System;
class CopyFile
{
    static void Main()
    {
        string srcpathfile = "C:\\Users\\Public\\Documents\\test.txt";
        string destpathfile = "C:\\Users\\Public\\Documents\\test2.txt";
        try
        {
            string filecontent = File.ReadAllText(srcpathfile);
            File.WriteAllText(destpathfile, filecontent);
            Console.WriteLine("File Copied Successfully");
        }
        catch (Exception e)
        {
            Console.WriteLine("Error Occurred: " + e.Message);
        }
    }
}
