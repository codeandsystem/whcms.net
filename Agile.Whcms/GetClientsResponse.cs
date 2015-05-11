using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Xml.Serialization;

namespace Agile.Whcms
{
   
    public class GetClientsResponse : WhcmsResponse
    {
            [XmlElement("clients")]
            public List<Client> Clients { get; set; }

            [XmlElement("totalresults")]
            public int TotalResults { get; set; }

            [XmlElement("startnumber")]
            public int StartNumber { get; set; }

            [XmlElement("numreturned")]
            public int NumReturned { get; set; }
    }
}
