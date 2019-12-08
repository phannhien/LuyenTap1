using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppG12019.DAL.Entity
{
    public class  Contacts
    {
        public string firstName { get; set; }
        public string name { get; set; }
        public string phone { get; set; }
        public string email { get; set; }

        public static List<Contacts> getListFromFile(string pathContacts)
        {
            var arraylist = File.ReadLines(pathContacts);
            List<Contacts> hienthi = new List<Contacts>();
            foreach(string line in arraylist)
            {
                var lsValue = line.Split(new char[] { '#' });
                var contacts = new Contacts
                {
                    firstName = line[0].ToString(),
                    name = lsValue[0],
                    phone = lsValue[1],
                    email = lsValue[2]
                };
                hienthi.Add(contacts);
            }
            return hienthi;
        }
    }
}
