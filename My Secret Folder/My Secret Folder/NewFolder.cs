using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace My_Secret_Folder
{
    public partial class NewFolder : Form
    {
        private readonly string filePath;
        public NewFolder()
        {
            InitializeComponent();
            this.filePath = filePath;
        }

        public string FolderName { get; private set; }
        private void ButtonEnterClick(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                this.FolderName = this.textBoxFolderName.Text.Trim();
                this.DialogResult = DialogResult.OK;
            }
        }

        private void ValidateTextBoxFolderName(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(this.textBoxFolderName.Text)) 
            {
                e.Cancel = true;
                this.textBoxFolderName.Focus();
                //SetErrorMessage("Can not create a folder with empty name!");
            }
            else if ( /* the text from the insructions is unreadable - slide 10) */ )
            {
                e.Cancel = true;
                this.textBoxFolderName.Focus();
                //SetErrorMessage("A folder with the same name already exists. ")
            }
            else
            {
                e.Cancel = true;
                //SetErrorMessage(String.Empty);
            }
        }
    }
}
