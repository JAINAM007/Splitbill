using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jainam_Bill_Split_App
{
    class Split_calculate
    {
        //Author : Jainam Shah
        //Date : 02-JUN-2021
        
        public int Cam_trip_num { get; set; }
        public List<List<float>> Cam_tripwise_expenses { get; set; }

        #region Outstanding amount 
        public List<float> Outstanding_amt_list()
        {
            List<float> Outstanding_amt_list = new List<float>();
            float Difference_amt;
            float Total_trips_avg_expense = Avg_of_Expense();
            for (int i = 0; i < Cam_tripwise_expenses.Count; i++)
            {
                Difference_amt = Total_trips_avg_expense - Each_trip_host_person_amt(i);
                Outstanding_amt_list.Add(Difference_amt);
            }

            return Outstanding_amt_list;
        }
        #endregion

        #region Avg_of_Expense
        public float Avg_of_Expense()
        {
            float Tripwise_total = 0;
            foreach (var lte in Cam_tripwise_expenses)
            {
                foreach (float te in lte)
                {
                    Tripwise_total += te;
                }
            }

            return Tripwise_total / Cam_tripwise_expenses.Count;
        }
        #endregion

        #region Total of each trip host person spending
        public float Each_trip_host_person_amt(int index)
        {
            float Ethp_total = 0;
            foreach (float amt in Cam_tripwise_expenses[index])
            {
                Ethp_total += amt;
            }

            return Ethp_total;
        }
        #endregion

       

    }

   
}
