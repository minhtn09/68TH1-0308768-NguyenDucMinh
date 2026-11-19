using System.Windows.Forms;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
namespace Revit_API
{
    [Autodesk.Revit.Attributes.Transaction(Autodesk.Revit.Attributes.TransactionMode.Manual)]
    public class Class1 : IExternalCommand
    {
        public Result Execute(ExternalCommandData commandData, ref string message, ElementSet elements)
        {

            return Result.Succeeded;
        }
    }
}
