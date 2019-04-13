// D3894
// Program 3
// Due 11/12/18
// CIS 200-01

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prog2
{
    public partial class EditAddress : Form
    {

       

        public EditAddress(List<Address>Addresses)
        {
            InitializeComponent();
            addressList = Addresses;
        }

        List<Address> addressList;

        private void EditAddress_Load(object sender, EventArgs e)
        {
            foreach (Address a in addressList)
            {
                addressCombo.Items.Add(a.Name); //Displays names on combo box
            }
        }

        //Pre: User clicks ok button
        //Post: the form runs or closes depending on errors
        private void okButton_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
                this.DialogResult = DialogResult.OK;
        }

        //Pre: User clicks cancel button
        //Post: Form closes
        private void cancelButton_Click(object sender, EventArgs e)
        {
             
                this.DialogResult = DialogResult.Cancel;
        }
    }
}
