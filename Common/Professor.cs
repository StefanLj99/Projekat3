using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using System.Runtime.Serialization;

namespace Common
{
    [DataContract]
    public class Professor
    {
        long jmbg;
        string name;
        string surname;

        public Professor(long jmbg, string name, string surname)
        {
            this.Jmbg = jmbg;
            this.Name = name;
            this.Surname = surname;
        }

        [DataMember]
        public long Jmbg { get => jmbg; set => jmbg = value; }
        [DataMember]
        public string Name { get => name; set => name = value; }
        [DataMember]
        public string Surname { get => surname; set => surname = value; }
    }
}
