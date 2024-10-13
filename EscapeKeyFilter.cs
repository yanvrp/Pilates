using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pilates
{
    public class EscapeKeyFilter : IMessageFilter
    {
        public bool PreFilterMessage(ref Message m)
        {
            const int WM_KEYUP = 0x0101;
            if (m.Msg == WM_KEYUP)
            {
                Keys key = (Keys)m.WParam.ToInt32();
                if (key == Keys.Escape)
                {
                    Form activeForm = Form.ActiveForm;
                    if (activeForm != null)
                    {
                        activeForm.Close();
                    }
                    return true;
                }
            }
            return false;
        }
    }

}
