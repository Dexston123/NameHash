using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectLibray.Data.Models
{
    public class SettingsModel
    {
        public string Username { get; set; }
        public string Theme { get; set; }
        public string Language { get; set; }
        public string Currency { get; set; }
        public string WorkType { get; set; }
        public string IsVisible { get; set; }

    }
}
