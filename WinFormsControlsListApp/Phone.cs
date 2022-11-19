using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsControlsListApp
{
    internal class Phone
    {
        public string? Model { set; get; }
        public string? Company { set; get; }
        public decimal Price { set; get; }

        public override string ToString()
        {
            return Company + " " + Model + " " + Price.ToString();
        }
    }

    
}
