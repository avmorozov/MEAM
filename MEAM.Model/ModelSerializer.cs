﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace MEAM.Model
{
    public class ModelSerializer
    {
        public static List<MaintenanceObject> LoadObjects(string file)
        {
            using (var objfile = new StreamReader(file))
            {
                return JsonConvert.DeserializeObject<List<MaintenanceObject>>(objfile.ReadToEnd());
            }
        }

        public static void SaveObjects(IEnumerable<MaintenanceObject> data, string file)
        {
            using (var objfile = new StreamWriter(file))
            {
                objfile.WriteLine(JsonConvert.SerializeObject(data));
            }
        }

        public static void SaveMaintenancePlan(MaintenancePlan plan, string file)
        {
            throw new NotImplementedException();
        }

    }
}
