using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jainam_Bill_Split_App
{
    class File_to_list_datatransform
    {
        //global 
        List<Split_calculate> Spical = new List<Split_calculate>();
        StreamReader sr;

        public List<Split_calculate> Generate_list(string file_path)
        {
            sr = new StreamReader(file_path);
            string line;
            while ((line = sr.ReadLine()) != null && line != "0")
            {
                List_formation(line);
            }


            return Spical;

        }

        private void List_formation(string line)
        {
            int Group_people = int.Parse(line);
            float temp_line;
            Split_calculate cal = new Split_calculate();

            int Num_times_paid;
            List<List<float>> Upperlist = new List<List<float>>();

            for (int i = 1; i <= Group_people; i++)
            {
                Num_times_paid = int.Parse(sr.ReadLine()); //The total expense transaction by one person
                List<float> innerList = new List<float>();  //list to store the expense

                int j = 0;
                while (j < Num_times_paid)
                {
                    temp_line = float.Parse(sr.ReadLine()); innerList.Add(temp_line); j++;
                }
                Upperlist.Add(innerList);
            }
            
            cal.Cam_tripwise_expenses = Upperlist;
            Spical.Add(cal);
        }



    }
}
