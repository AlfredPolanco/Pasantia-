using System;
using System.Collections.Generic;
using System.IO;
using System.Net.WebSockets;
using System.Text;

namespace FilterData
{
    class Program
    {
        //BEFORE EXECUTING THE CODE THE FILE HAS TO BE DOWNLOADED FIRST!
        static void Main(string[] args)
        {
            List<string> list0 = new List<string>();
            List<string> list1 = new List<string>();
            List<string> list2 = new List<string>();
            List<string> list3 = new List<string>();
            List<string> list4 = new List<string>();
            List<string> list5 = new List<string>();
            List<string> list6 = new List<string>();
            List<string> list7 = new List<string>();
            List<string> list8 = new List<string>();
            List<string> list9 = new List<string>();
            List<string> list10 = new List<string>();
            List<string> list11 = new List<string>();
            List<string> list12 = new List<string>();

            try
            {
                //Please write the file path were the mobility data has been downloaded
                using (var reader = new StreamReader(@"F:\Pasantia\Mobility.csv"))
                {
                    while (!reader.EndOfStream)
                    {
                        var line = reader.ReadLine();
                        var values = line.Split(',');
                        if (values[0] == "DO")
                        {
                            list0.Add(values[0]);
                            list1.Add(values[1]);
                            list2.Add(values[2]);
                            list3.Add(values[3]);
                            list4.Add(values[4]);
                            list5.Add(values[5]);
                            list6.Add(values[6]);
                            list7.Add(values[7]);
                            list8.Add(values[8]);
                            list9.Add(values[9]);
                            list10.Add(values[10]);
                            list11.Add(values[11]);
                            list12.Add(values[12]);
                        }
                    }
                }
                //Transalate colummn name to spanish
                var csv = new StringBuilder();
                var newLine2 = string.Format("country_region_code,country_region,sub_region_1,sub_region_2,iso_3166_2_code,census_fips_code,date,retail_and_recreation_percent_change_from_baseline,grocery_and_pharmacy_percent_change_from_baseline,parks_percent_change_from_baseline,transit_stations_percent_change_from_baseline,workplaces_percent_change_from_baseline,residential_percent_change_from_baseline");
                csv.AppendLine(newLine2);
                for (int i = 0; i < list0.Count; i++)
                {
                    var l0 = list0[i];
                    var l1 = list1[i];
                    var l2 = list2[i];
                    var l3 = list3[i];
                    var l4 = list4[i];
                    var l5 = list5[i];
                    var l6 = list6[i];
                    var l7 = list7[i];
                    var l8 = list8[i];
                    var l9 = list9[i];
                    var l10 = list10[i];
                    var l11 = list11[i];
                    var l12 = list12[i];

                    var newLine = string.Format("{0},{1},{2},{3},{4},{5},{6},{7}," +
                        "{8},{9},{10},{11},{12}", l0, l1, l2, l3, l4, l5,
                        l6, l7, l8, l9, l10, l11, l12);
                    csv.AppendLine(newLine);
                    File.WriteAllText(@"F:\Pasantia\DO-Mobility.csv", csv.ToString());
                }
            }
            catch (Exception e )
            {
                Console.WriteLine("Please check that the file Mobility already exists");
            }
        }
    }
}
