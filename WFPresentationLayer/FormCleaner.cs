using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFPresentationLayer
{
    class FormCleaner
    {
        public static void Clear(Control control)
        {
            foreach (Control item in control.Controls)
            {
                if (item.HasChildren)
                {
                    Clear(item);
                }

                if (item is TextBoxBase)
                {
                    TextBoxBase txt = (TextBoxBase)item;
                    txt.Clear();
                }
                else if (item is ComboBox)
                {
                    ComboBox cmb = (ComboBox)item;
                    cmb.SelectedItem = -1;
                }
            }
        }
    }
}
