using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DB_CRUD_Example
{
    class FileTextBox :TextBox
    {
        protected override void OnTextChanged(EventArgs e)
        {
            // Let the base class process changed text first 
            base.OnTextChanged(e);
            // If the file does not exist, color the text red 
            if (!File.Exists(this.Text))
            {
                this.ForeColor = Color.Red;
            }
            else
            { // Make it black
                this.ForeColor = Color.Black;
            }
        }
    }
}
