using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media.Imaging;
using System.Windows.Threading;
//using System.Windows.Forms;

namespace ClassLibrary
{
    public static class ShowImages
    {
        //Диалоговое окно выхода
        public static void ExitForm(System.ComponentModel.CancelEventArgs e)
        {
            System.Windows.Forms.DialogResult noExit;
            noExit = System.Windows.Forms.MessageBox.Show("Вы действительно хотите выйти?", "", System.Windows.Forms.MessageBoxButtons.YesNo, System.Windows.Forms.MessageBoxIcon.Information);
            if (noExit == System.Windows.Forms.DialogResult.No)
                e.Cancel = true;
        }
    }
}
