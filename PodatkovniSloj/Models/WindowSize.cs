using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace PodatkovniSloj.Models
{
    [DataContract]
    public class WindowSize
    {
        [DataMember(Name = "windowSize")]
        public string SizeOfWindow { get; set; }
    }
}
