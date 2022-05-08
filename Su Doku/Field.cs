using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Su_Doku
{
    internal class Field : Button
    {
        public int Value { get; set; }
        public int PositionX { get; set; }
        public int PositionY { get; set; }
        public bool IsLocked { get; set; }

        public void Clear()
        {
            this.Text = string.Empty; 
            this.IsLocked = false;
        }
    }
}
