using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Xml.Serialization;

namespace Agile.Whcms
{

    public class WhcmsResponse
    {
        [XmlElement("action")]
        public string Action { get; set; }

        [XmlElement("result")]
        public string Result { get; set; }


    }
}
