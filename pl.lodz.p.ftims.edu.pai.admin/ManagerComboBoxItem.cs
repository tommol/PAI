using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pl.lodz.p.ftims.edu.pai.admin
{
    public class ManagerComboBoxItem
    {
        public string Text { get; set; }
        public object Value { get; set; }

        public ManagerComboBoxItem(string text , int id)
        {
            Text = text;
            Value = id;
        }
        public override string ToString()
        {
            return Text;
        }
    }
}
