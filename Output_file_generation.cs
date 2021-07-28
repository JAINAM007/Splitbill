using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jainam_Bill_Split_App
{
    class Output_file_generation
    {
        public void Out_file_gen(List<Split_calculate> spical, string file_path)
        {
            using (StreamWriter outfile = new StreamWriter(file_path + ".out"))
            {
                foreach (Split_calculate sc in spical)
                {                              
                    List<float> amt = sc.Outstanding_amt_list();
                    foreach (float am in amt)
                    {
                        if (am > 0) outfile.WriteLine(am.ToString("$#,##0.00"));
                        else outfile.WriteLine((Math.Round(am,3)).ToString("$#,##0.00;($#,##0.00)"));
                    }
                    outfile.WriteLine(string.Empty);
                }
            }
        }
    }
}
