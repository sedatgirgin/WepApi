using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Models
{
    public class Variables
    {
        [Key]
        public int Id { get; set; }
        public string VId { get; set; }
        public int Rowid { get; set; }
        public string Avalue { get; set; }
        public int AddressOut { get; set; }
        public int AddressIn { get; set; }
        public string Bvalue { get; set; }
        public string Bit_position { get; set; }
        public string Buttonpath { get; set; }
        public string Code { get; set; }
        public bool Decimal { get; set; }
        public int Defaultvalue { get; set; }
        public double Delay { get; set; }
        public double Delta { get; set; }
        public string Description { get; set; }
        public int Dimension { get; set; }
        public int Frequency { get; set; }
        public string Functioncode { get; set; }
        public int Grpcategory { get; set; }
        public int Idgroup { get; set; }
        public int Idhsvariable { get; set; }
        public string Idvarmdl { get; set; }
        public string Idvariable { get; set; }
        public string Imageoff { get; set; }
        public string Imageon { get; set; }
        public string Inserttime { get; set; }
        public bool Isactive { get; set; }
        public bool Iscancelled { get; set; }
        public bool Ishaccp { get; set; }
        public bool Islogic { get; set; }
        public bool Isonchange { get; set; }
        public string Lastupdate { get; set; }
        public int Length { get; set; }
        public string Maximum { get; set; }
        public string Measureunit { get; set; }
        public string Minimum { get; set; }
        public int Priority { get; set; }
        public int ReadWrite { get; set; }
        public bool Signed { get; set; }
        public string ToDisplay { get; set; }
        public int Type { get; set; }
        public string Varencoding { get; set; }
        public string DetailId { get; set; }
        public string DeviceModel { get; set; }


    }
}
