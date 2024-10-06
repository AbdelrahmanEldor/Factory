using Autodesk.Revit.UI;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trials_Eldor
{
    internal class GeneralMethod
    {



        #region  Testing Groub

        //show dialog box 
        public void ShowDialogBox(IEnumerable list)
        {
            dialogbox box = new dialogbox(list);
            box.ShowDialog();
        }







        //ShowTask
        public void ShowTask(string messagexx)
        {
            TaskDialog.Show("Abdelrahman_Eldor", messagexx);
        }



        #endregion


    }
}
