using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jainam_Bill_Split_App
{
    class Program
    {
        //Author : Jainam Shah
        //Date : 02-JUN-2021
        static void Main(string[] args)
        {

            try
            {
                Console.WriteLine("Enter the file path");
                //store the file path in one variable
                var file_path = Console.ReadLine();

                #region File fetch and write
                if (!string.IsNullOrEmpty(file_path))
                {
                    if (File.Exists(file_path))
                    {
                        Console.WriteLine("Loading the txt file");
                        File_to_list_datatransform Fr = new File_to_list_datatransform();                        
                        List<Split_calculate> Cal_obj = Fr.Generate_list(file_path);

                        Output_file_generation out_gen = new Output_file_generation();
                        out_gen.Out_file_gen(Cal_obj, file_path);


                    }
                    else
                    {
                        Console.WriteLine("The text file is not available at the given path");

                    }
                }

                else
                {
                    Console.WriteLine("File path not entered");
                }

                #endregion
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
        }
    }
}
