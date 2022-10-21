using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    [DataContract]
    public class Student
    {
        long jmbg;
        string name;
        string surname;
        string index;

        public Student(long jmbg, string name, string surname, string index)
        {
            this.Jmbg = jmbg;
            this.Name = name;
            this.Surname = surname;
            this.Index = index;
        }

        [DataMember]
        public long Jmbg { get => jmbg; set => jmbg = value; }
        [DataMember]
        public string Name { get => name; set => name = value; }
        [DataMember]
        public string Surname { get => surname; set => surname = value; }
        [DataMember]
        public string Index { get => index; set => index = value; }
    }
}
