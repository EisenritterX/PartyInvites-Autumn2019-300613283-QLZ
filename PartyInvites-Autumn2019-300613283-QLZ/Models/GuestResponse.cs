using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PartyInvites_Autumn2019_300613283_QLZ.Models
{
    public class GuestResponse
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone{ get; set; }
        public bool? WillAttend { get; set; }
    }
}
