using System.IO;

namespace FileIOLab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filePath = "../../../data.txt";

            //1.    Read from file
            ReadFile(filePath);

            //2.    Write to file

            //3.   Confirm the file was created using the ReadFile method.

            //4.   Use String Builder
        }
        /*
           ReadFile method: 
           Inputs: 
               - string: file name, indicates the location of the file to read.
           Output: None. 
           Functionality:
               Method uses StreamReader to read from the file one line at a time, displays the line 
               on the console and at the end display the count of the lines.
        */

        static void ReadFile(string fileName)
        {
            /*
             *  Robust Programming
                - The following conditions may cause an exception:
                - The file may not exist (IOException).
                - No authorization. 
             */

            //Step 1: Check File Exists
            if (true)
            {
                //Step 2: Declare required variables (StreamReader, string line, int count,...)


                //Step 3: IO is prone to exceptions. Add a try catch block.

                try
                {
                    //Step 4: Open file for reading ..initialize StreamReader


                    //Step 5: read from file using ReadLine (exactly like the console) 
                    //Q: When do we stop reading? What is the sentinel value? 	A: null


                }
                catch (Exception e)
                {
                    Console.WriteLine("Error reading file: " + e.Message);
                }
                finally
                {
                    //Step 6: close the file in the finally block.
                }
            }
            else
            {
                Console.WriteLine("Error: File does not exist.");
            }
        }

        /*
           WriteToFile method: 
           Inputs: 
               - string: file name, indicates the location of the file to read.
           Output: None. 
           Functionality:
               Ask the user for input and save it into a file using StreamWriter.
               The method stops when the user enter “q”. 
        */

        static void WriteFile(string fileName)
        {
            /*
             *  Robust Programming
                The following conditions may cause an exception:
                - Access to the path is denied. (WinIOError)
                - The file exists and is read-only (IOException).
                - The path name may be too long (PathTooLongException).
                - The disk may be full (IOException).
             */

            //Step 1: Declare required variables (StreamWriter, string output, ...)

            //Step 2: IO is prone to exceptions. Best practice: add a try-catch block.

            //Step 3: Open file for writing. Initialize StreamWriter

            //Step 4: Add any text content to the file using Write and WriteLine (exactly like the console)

            //Step 5: Close the file in the finally block.

        }

        static void WriteFileBuilder(string fileName)
        {
            /*
             *  Robust Programming
                The following conditions may cause an exception:
                - Access to the path is denied. (WinIOError)
                - The file exists and is read-only (IOException).
                - The path name may be too long (PathTooLongException).
                - The disk may be full (IOException).
             */

            //Step 1: Declare required variables (StreamWriter, string output, ...)

            //Step 2: IO is prone to exceptions. Best practice: add a try-catch block.

            //Step 3: Add any text content to the String Builder


            //Step 3: Open file for writing. Initialize StreamWriter
            //Write everything to the file.

            //Step 5: Close the file in the finally block.

        }
    }
}