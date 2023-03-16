using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.WPF.Models
{
    internal class Message
    {
        public int Id { get; init; }
        public string Text { get; set; } = "";
        public string Avtor { get; set; } = "NoAvtor";
    }
}
