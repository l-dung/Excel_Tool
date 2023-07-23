using System;
using System.Runtime.InteropServices;
using Excel = Microsoft.Office.Interop.Excel;
using Microsoft.Office.Interop.Excel;
using System.Windows.Forms;
using System.Collections.Generic;

namespace ExcelApp
{
    public partial class frmMain : Form
    {
        Excel.Application xlApp;
        Workbook xlWorkBook;
        Worksheet xlWorkSheet;
        Worksheet xlWorkSheet2;
        Object misValue = Type.Missing;
        List<ShapeObject> shapeObjects = new List<ShapeObject>();
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            xlApp = new Excel.Application();
            if (xlApp == null)
            {
                MessageBox.Show("Excel is not properly installed!!");
                return;
            }
            xlWorkBook = xlApp.Workbooks.Open(txtPath.Text);
            xlWorkSheet = xlWorkBook.Sheets["sheet1"];
            xlWorkSheet2 = xlWorkBook.Sheets["sheet2"];

            foreach (Shape shape in xlWorkSheet.Shapes)
            {
                xlWorkSheet2.Shapes.AddShape(shape.AutoShapeType, shape.Left, shape.Top, shape.Width, shape.Height);
            }

            CloseExcel(true);
        }
        private void releaseObject(object obj)
        {
            try
            {
                Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception)
            {
                obj = null;
            }
            finally
            {
                GC.Collect();
            }
        }

        private void OpenExcel(string path)
        {
            xlApp = new Excel.Application();
            if (xlApp == null)
            {
                MessageBox.Show("Excel is not properly installed!!");
                return;
            }
            xlWorkBook = xlApp.Workbooks.Open(path);
        }
        private void CloseExcel(bool saveflag = false)
        {
            if (saveflag) xlWorkBook.Save();

            xlWorkBook.Close(true, misValue, misValue);
            xlApp.Quit();

            if (xlApp!=null) releaseObject(xlApp);
            if (xlWorkBook != null) releaseObject(xlWorkBook);
            if (xlWorkSheet != null) releaseObject(xlWorkSheet);
            if (xlWorkSheet2 != null) releaseObject(xlWorkSheet2);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            //get sheet name
            cbbSheetName.Items.Clear();
            OpenExcel(txtPath.Text);
            foreach (Worksheet sheet in xlWorkBook.Sheets)
            {
                cbbSheetName.Items.Add(sheet.Name.ToString());
            }
            CloseExcel(false);
        }

        private void btnGetShape_Click(object sender, EventArgs e)
        {   string sheetName= cbbSheetName.SelectedText;
            if (sheetName.Trim() == "")
            {
                MessageBox.Show("Vui lòng chọn tên sheet!");
                return;
            }
            shapeObjects.Clear();
            OpenExcel(txtPath.Text);
            xlWorkSheet = xlWorkBook.Sheets[sheetName];
            foreach (Shape shape in xlWorkSheet.Shapes)
            {
                shapeObjects.Add(new ShapeObject(shape.AutoShapeType, shape.Top, shape.Left, shape.Height, shape.Width));
            }
            CloseExcel(false);
            lbGetShape.Text = String.Format("Có tổng cộng {0} Shape",shapeObjects.Count.ToString());
        }
    }
}
