#region Namespaces
using Autodesk.Revit.ApplicationServices;
using Autodesk.Revit.Attributes;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using Autodesk.Revit.UI.Selection;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.IO;

#endregion

namespace FrmProjectSetup
{
    [Transaction(TransactionMode.Manual)]
    public class FrmProjectSetup : IExternalCommand
    {
        public Result Execute(
          ExternalCommandData commandData,
          ref string message,
          ElementSet elements)
        {
            UIApplication uiapp = commandData.Application;
            UIDocument uidoc = uiapp.ActiveUIDocument;
            Application app = uiapp.Application;
            Document doc = uidoc.Document;

            //declear and initialize variable for line counter
            int LineNumber = 1;
            //TaskDialog.Show("Test", "Form Project Setup!");

            Form1 SetupForm = new Form1();
            SetupForm.Height = 500;
            SetupForm.Width = 800;
            SetupForm.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;


            //if ok button is selected, do the folowing
            if (SetupForm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                //do something here
                string fPath = SetupForm.tbLevelTemplate.Text;
                string fPath2 = SetupForm.tbSheetTemplatePath.Text;


                //check to see if the data file exists
                if (File.Exists(fPath))
                {
                    Debug.Print("File Exist!" + fPath);

                    //create array from data file
                    Transaction t = new Transaction(doc);
                    t.Start("Create levels");

                    //using predefine method to create level with file path and document variable
                    mkLevelsWithFile(fPath, doc);

                    t.Commit();
                    t.Dispose();


                }// end of if 
                else
                {
                    Debug.Print("File Does Not Exist!");
                }// end of else


                if (File.Exists(fPath2))
                {
                    //TaskDialog.Show("Test", "Create sheets from data file!");
                    string filepath2 = @"m:\onedrive - mon & associates inc\library\reivt\revit addin bootcamp\download\rab_session_02_challenge_sheets.csv";
                    string[] fileArray2 = System.IO.File.ReadAllLines(filepath2);
                    LineNumber = 1;

                    FilteredElementCollector collector = new FilteredElementCollector(doc);
                    collector.OfCategory(BuiltInCategory.OST_TitleBlocks);
                    ElementId tblockId = collector.FirstElementId();

                    //--------------Start Transtraction----------------------------------------------//


                    Transaction t2 = new Transaction(doc);
                    t2.Start("Create Sheets");

                    foreach (string rowString2 in fileArray2)
                    {
                        string[] cellString2 = rowString2.Split(',');
                        string sheetNo = cellString2[0];
                        string SheetName = cellString2[1];

                        // create sheet
                        if (LineNumber != 1)
                        {
                            ViewSheet mySheet = ViewSheet.Create(doc, tblockId);
                            mySheet.Name = SheetName;
                            mySheet.SheetNumber = sheetNo;
                        }

                        string LineNumberString = LineNumber.ToString();
                        Debug.Print(LineNumberString);

                        LineNumber++;


                    }

                    t2.Commit();
                    t2.Dispose();
                    //------------------------------end transaction------------------------------------//
                }

            }


            return Result.Succeeded;


        }

        //************************************************************//
        //*** Method for creating levels base on csv file ************//
        //*** column one to contain level name and  ******************//
        //*** columne 2 to contain floor elevation in decimal feet ***//
        //*** last modified on 2022-11-17 6:47 pm ********************//
        //************************************************************//

        private void mkLevelsWithFile(string filePath, Document doc)
        {


            int LineNumber = 1;
            string[] fileArray = System.IO.File.ReadAllLines(filePath);


            foreach (string rowString in fileArray)
            {
                string[] cellString = rowString.Split(',');

                string levelName = cellString[0];
                string levelHeightString = cellString[1];
                double levelHeightNumber = 0.00;
                string LineNumberString = LineNumber.ToString();

                try
                {
                    // create level
                    levelHeightNumber = Convert.ToDouble(levelHeightString);
                    Level myLevel = Level.Create(doc, levelHeightNumber);
                    myLevel.Name = levelName;

                }
                catch
                {
                    TaskDialog.Show("Exception", "Error on data file line number "
                                                 + LineNumberString + " !\n" + "Cannot convert string"
                                                 + "\n\n" + "\""
                                                 + levelHeightString
                                                 + "\"" + "\n\n"
                                                 + "level height to double!");
                }

                LineNumber++;
            }


        }//end of method mkLevelsWithFile(

        private void mkSheetWithFiles (string filePath, Document doc)
        {

        }
    }
}
