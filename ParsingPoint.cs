using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.AxHost;

namespace Parsing_for_xtUML_model
{
    public static class ParsingPoint
    {
        public static bool Point25(JArray jsonArray)
        {
            try
            {
                HashSet<string> stateNames = new HashSet<string>();
                foreach (var model in jsonArray)
                {
                    if (model["type"]?.ToString() == "class")
                    {
                        var stateCheck = model["state_name"];
                        if (stateCheck != null)
                        {
                            string stateName = stateCheck.ToString();
                            if (stateNames.Contains(stateName))
                            {
                                MessageBox.Show($"Ada subsistem dengan nama yang sama: {stateName}. Pastikan semua subsistem memiliki nama yang unik.");
                                return false;
                            }
                            stateNames.Add(stateName);
                        }
                        else
                        {
                            MessageBox.Show("Error: Properti 'state_name' tidak ditemukan atau kosong.");
                            return false;
                        }
                    }
                }
                MessageBox.Show("Semua nama state/state_name unik.");
                return true;
            } 
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return false;
            }
        }   
    }
}
