using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotorCycleStore_Fram_4_7_2.models
{
    class ComboboxItem
    {
        public string Text { get; set; }
        public string Value { get; set; }

        public ComboboxItem()
        {
            this.Text = Text;
            this.Value = Value;
        }

        public override string ToString()
        {
            return Text;
        }
    }
}
