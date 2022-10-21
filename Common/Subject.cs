using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    [DataContract]
    public class Subject
    {
        long id;
        string name;
        int espb;

        public Subject(long id, string name, int espb)
        {
            this.Id = id;
            this.Name = name;
            this.Espb = espb;
        }

        [DataMember]
        public long Id { get => id; set => id = value; }
        [DataMember]
        public string Name { get => name; set => name = value; }
        [DataMember]
        public int Espb { get => espb; set => espb = value; }
    }
}
