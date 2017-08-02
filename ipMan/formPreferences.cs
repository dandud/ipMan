using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ipMan
{
    public partial class formPreferences : Form
    {
        public formPreferences()
        {
            InitializeComponent();
            MessageBox.Show("Here!");
            populate_chkbox();
        }
        public void populate_chkbox()
        {
            EnumToListBox(typeof(NetworkInterfaceType), chklistbox_adaptselect);
        }
        static public void EnumToListBox(Type EnumType, ListControl TheListBox)
        {
            Array Values = System.Enum.GetValues(EnumType);

            foreach (int Value in Values)
            {
                string Display = Enum.GetName(EnumType, Value);
                CheckedListBox Item = new CheckedListBox();
                Item.Items.Add(Display);
            }
        }

    }


}
