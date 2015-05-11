using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Xml.Serialization;

namespace Agile.Whcms
{
    public class Client
    {
        [XmlElement("id")]
        public int Id { get; set; }

        [XmlElement("firstname")]
        public string FirstName { get; set; }

        [XmlElement("lastname")]
        public string LastName { get; set; }

        [XmlElement("companyname")]
        public string CompanyName { get; set; }

        [XmlElement("email")]
        public string Email { get; set; }

        [XmlElement("datecreated")]
        public string DateCreated { get; set; }

        [XmlElement("groupid")]
        public int GroupId { get; set; }

        [XmlElement("status")]
        public string Status { get; set; }


    }
}
