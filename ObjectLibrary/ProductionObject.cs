using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectLibrary
{
    public class ProductionObject
    {
        public int Production_Id { get; set; }
        public int Pond_Id {get; set;}
        public long Production_Number { get; set; }
        public string Pond_Preparation_Date { get; set; }
        public long Harvest_Quantity { get; set; }
        public DateTime Date_Of_Harvest { get; set; }
        public int Crop_Number { get; set; }
        public double Survival_Rate { get; set; }
        public string Harvest_Status { get; set; }
        public long Total_Fry_Stocked { get; set; }
        public DateTime Date_Stocked { get; set; }
        public double Actual_Body_Weight { get; set; }
        public int Supplier_Id { get; set; }
        public string Entry_Status { get; set; }
        public string Farm_Name { get; set; }
        public DateTime Sampling_Date { get; set; }
        public double Weekly_Cummulative{ get; set; }
        public int Week_Number { get; set; }
        public string Lab_Technician { get; set; }

    }
}
