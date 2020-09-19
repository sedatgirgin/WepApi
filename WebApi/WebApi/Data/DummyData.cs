using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using WebApi.Models;

namespace WebApi.Data
{
    public class DummyData
    {
        public static void Initialize(IApplicationBuilder app)
        {
            try
            {
                using (var serviceScope = app.ApplicationServices.GetService<IServiceScopeFactory>().CreateScope())
                {

                    var context = serviceScope.ServiceProvider.GetService<Context>();
                    context.Database.EnsureCreated();

                    // Look for any variables
                    //saving data repeatedly in the table WebDB
                    if (context.Variables != null && context.Variables.Any())
                        return;   // DB has already been seeded

                    //record to Database's WebDB 
                   var variables = GetVariables().ToArray();

                    context.Variables.AddRange(variables);
                    context.SaveChanges();
                }
            }
            catch (Exception e)
            {
                Console.Write(e.ToString());
            }
            
        }

        public static List<Variables> GetVariables()
        {
            List<Variables> values = File.ReadAllLines("Data\\variable.csv")
                                           .Skip(1)
                                           .Select(v => FromCsv(v))
                                           .ToList();
            return values;
        }
        static Variables variableList;
        public static Variables FromCsv(string csvLine)
        {
            string[] values = csvLine.Split(',');
           variableList = new Variables();
           
           variableList.VId = values[0];
           variableList.Rowid = Convert.ToInt32(values[1]);
           variableList.Avalue = values[2];
           variableList.AddressOut = Convert.ToInt32(values[3]);
           variableList.AddressIn = Convert.ToInt32(values[4]);
           variableList.Bvalue = values[5];
           variableList.Bit_position = values[6];
           variableList.Buttonpath = values[7];
           variableList.Code = values[8];
           variableList.Decimal = values[9].Equals("false") ? false : true;
           variableList.Defaultvalue = Convert.ToInt32(values[10]);
           variableList.Delay = Convert.ToDouble(values[11]);
           variableList.Delta = Convert.ToDouble(values[12]);
           variableList.Description = values[13];
           variableList.Dimension = Convert.ToInt32(values[14]);
           variableList.Frequency = Convert.ToInt32(values[15]);
           variableList.Functioncode = values[16];
           variableList.Grpcategory = Convert.ToInt32(values[17]);
           variableList.Idgroup = Convert.ToInt32(values[18]);
           variableList.Idhsvariable = Convert.ToInt32(values[19]);
           variableList.Idvarmdl = values[20];
           variableList.Idvariable = values[21];
           variableList.Imageoff = values[22];
           variableList.Imageon = values[23];
           variableList.Inserttime = values[24];
           variableList.Isactive = values[25].Equals("false") ? false : true;
           variableList.Iscancelled = values[26].Equals("false") ? false : true;
           variableList.Ishaccp = values[27].Equals("false") ? false : true;
           variableList.Islogic = values[28].Equals("false") ? false : true;
           variableList.Isonchange = values[29].Equals("false") ? false : true;
           variableList.Lastupdate = values[30];
           variableList.Length = Convert.ToInt32(values[31]);
           variableList.Maximum = values[32];
           variableList.Measureunit = values[33];
           variableList.Minimum = values[34];
           variableList.Priority = Convert.ToInt32(values[35]);
           variableList.ReadWrite = Convert.ToInt32(values[36]);
           variableList.Signed = values[37].Equals("false") ? false : true;
           variableList.ToDisplay = values[38];
           variableList.Type = Convert.ToInt32(values[39]);
           variableList.Varencoding = values[40];
           variableList.DetailId = values[41];
           variableList.DeviceModel = values[42];
            
            return variableList;
        }


    }
}
