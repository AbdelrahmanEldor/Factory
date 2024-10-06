using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




using Autodesk.Revit.DB;
using Autodesk.Revit.DB.Structure;
using Autodesk.Revit.DB.Architecture;
using Autodesk.Revit.DB.Mechanical;
using Autodesk.Revit.DB.Plumbing;
using Autodesk.Revit.UI;
using Autodesk.Revit.UI.Selection;
using Autodesk.Revit.Attributes;
using Autodesk.Revit.ApplicationServices;
using System.Runtime.ExceptionServices;
using System.Xml.Linq;
using Autodesk.Revit.DB.Visual;
//using System.Windows.Shapes;
using System.Windows;
using System.Security.Policy;
using System.ComponentModel.Design;
//using System.Windows.Media;




namespace Trials_Eldor
{

    [Transaction(TransactionMode.Manual)]
    public class Trials : IExternalCommand
    {
        public Result Execute(ExternalCommandData commandData, ref string message, ElementSet elements)
        {

            #region Application , Documents
            UIApplication uiapp = commandData.Application;
            Autodesk.Revit.ApplicationServices.Application app = commandData.Application.Application;
            UIDocument uidoc = commandData.Application.ActiveUIDocument;
            Document doc = commandData.Application.ActiveUIDocument.Document;
            #endregion

            #region General Method
            GeneralMethod gm = new GeneralMethod();
            #endregion



            // Transaction Groub   
            TransactionGroup tg = new TransactionGroup(doc, "Final Action");
            tg.Start();







            ////================================================= collect all levels in the project and get tha main levels

            IList<Element> AllLevels = new FilteredElementCollector(doc).OfClass(typeof(Level)).ToElements();
            AllLevels = AllLevels.OrderBy(c => (c as Level).Elevation).ToList();
            //gm.ShowDialogBox(AllLevels.Select(qq => qq.Name));




            List<Level> MainLevels = new List<Level>();

            foreach (Level x in AllLevels)
            {
                if (x.ParametersMap.get_Item("Name").AsString().Equals("LEVEL -1 - BASEMENT") ||
                    x.ParametersMap.get_Item("Name").AsString().Equals("LEVEL 0 - FIRST FLOOR") ||
                    x.ParametersMap.get_Item("Name").AsString().Equals("LEVEL 1 - SECOND FLOOR") ||
                    x.ParametersMap.get_Item("Name").AsString().Equals("ROOF - Estimate") ||
                    x.ParametersMap.get_Item("Name").AsString().Equals("T.O. LEVEL -1 WALLS") ||
                    x.ParametersMap.get_Item("Name").AsString().Equals("T.O. LEVEL 0 PLATE") ||
                    x.ParametersMap.get_Item("Name").AsString().Equals("T.O. LEVEL 1 PLATE"))
                {
                    MainLevels.Add(x);

                }
            }








            //dfdfdfdofnsdpflf
            //nsdogsgkm;,


            // khfokjdfpgfjol


            // khfokjdfpgfjol

            //fgfkdfnbkdmbdf
            //gdfgdfgdfg
            //dfdfgdfgdfgdfdfgfgf
            //gergerergerer


            gm.ShowDialogBox(MainLevels.Select(qq => (qq.Name + " >>>>>>> " + "Elevataion = " + qq.Elevation)));





                










            tg.Assimilate();
            return Result.Succeeded;
        }
    }
}
