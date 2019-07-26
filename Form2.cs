﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


using Word = Microsoft.Office.Interop.Word;
using Microsoft.Office.Interop.Word;
using Microsoft.Office.Core;
using System.Reflection;
using System.IO;
using System.Diagnostics;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using Microsoft.Office.Interop.Excel;
using Excel = Microsoft.Office.Interop.Excel;

namespace Rapor
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        // Find and Replace:
        private void FindAndReplace(Microsoft.Office.Interop.Word.Application wordApp, object findText, object replaceWithText)
        {
            
            object matchCase = true;
            object matchWholeWord = true;
            object matchWildCards = false;
            object matchSoundLike = false;
            object nmatchAllForms = false;
            object forward = true;
            object format = false;
            object matchKashida = false;
            object matchDiactitics = false;
            object matchAlefHamza = false;
            object matchControl = false;
            object read_only = false;
            object visible = true;
            object replace = 2;
            object wrap = 1;
            
            wordApp.Selection.Find.Execute(ref findText,
                        ref matchCase, ref matchWholeWord,
                        ref matchWildCards, ref matchSoundLike,
                        ref nmatchAllForms, ref forward,
                        ref wrap, ref format, ref replaceWithText,
                        ref replace, ref matchKashida,
                        ref matchDiactitics, ref matchAlefHamza,
                        ref matchControl);

        }

        string pathResim = null;

        

        // Create The Document:
        private void CreateWordDocument(object filename, object saveAs, object image)
        {
            List<int> processesbeforegen = getRunningProcesses();
            object missing = Missing.Value;
            Word.Application wordApp = new Word.Application();
            Document aDoc = null;

            

            if (File.Exists((string)filename))
            {
                object readOnly = false;
                wordApp.Visible = false;
                aDoc = wordApp.Documents.Open(ref filename, ref missing, ref readOnly,
                ref missing, ref missing, ref missing,
                ref missing, ref missing, ref missing,
                ref missing, ref missing, ref missing,
                ref missing, ref missing, ref missing, ref missing);

                object replaceAll = WdReplace.wdReplaceAll;

                foreach (Section section in aDoc.Sections)
                {
                    Word.Range headerRange = section.Headers[WdHeaderFooterIndex.wdHeaderFooterPrimary].Range;
                    headerRange.Find.Text = "proje_dokuman_no";
                    headerRange.Find.Replacement.Text = proje_dokuman_no.Text;
                    headerRange.Find.Execute(ref missing, ref missing, ref missing,
                                             ref missing, ref missing, ref missing,
                                             ref missing, ref missing, ref missing,
                                             ref missing, ref replaceAll, ref missing,
                                             ref missing, ref missing, ref missing);
                    headerRange.Find.Text = "firma_dokuman_no";
                    headerRange.Find.Replacement.Text = firma_dokuman_no.Text;
                    headerRange.Find.Execute(ref missing, ref missing, ref missing,
                                             ref missing, ref missing, ref missing,
                                             ref missing, ref missing, ref missing,
                                             ref missing, ref replaceAll, ref missing,
                                             ref missing, ref missing, ref missing);
                    headerRange.Find.Text = "ekipman_adi";
                    headerRange.Find.Replacement.Text = ekipman_adi.Text;
                    headerRange.Find.Execute(ref missing, ref missing, ref missing,
                                             ref missing, ref missing, ref missing,
                                             ref missing, ref missing, ref missing,
                                             ref missing, ref replaceAll, ref missing,
                                             ref missing, ref missing, ref missing);
                }

                aDoc.Activate();

                // find and replace commands:
                this.FindAndReplace(wordApp, "siparis_no", siparis_no.Text);
                this.FindAndReplace(wordApp, "mm-yy", tarih.Text);
                this.FindAndReplace(wordApp, "ekipman_adi", ekipman_adi.Text);
                this.FindAndReplace(wordApp, "gign_no", gign_no.Text);
                this.FindAndReplace(wordApp, "uretici_firma", uretici_firma.Text);
                this.FindAndReplace(wordApp, "test_tarihi", test_tarihi.Text);
                this.FindAndReplace(wordApp, "rapor_tarihi", rapor_tarihi.Text);
                this.FindAndReplace(wordApp, "olcumu_gerceklestiren", olcumu_gerceklestiren.SelectedItem);
                this.FindAndReplace(wordApp, "telefon_no", telefon_no.Text);
                this.FindAndReplace(wordApp, "e_posta", e_posta.Text);
                this.FindAndReplace(wordApp, "gemi_adi", gemi_adi.Text);
                this.FindAndReplace(wordApp, "olcum_yeri", olcum_yeri.SelectedItem);
                this.FindAndReplace(wordApp, "mahal", mahal.Text);
                this.FindAndReplace(wordApp, "ekipman_model", ekipman_model.Text);
                this.FindAndReplace(wordApp, "ekipman_guc", ekipman_guc.Text);
                this.FindAndReplace(wordApp, "ekipman_devir", ekipman_devir.Text);
                this.FindAndReplace(wordApp, "proje_dokuman_no", proje_dokuman_no.Text);

            }

            else
            {
                MessageBox.Show("file dose not exist.");
                return;
            }

            int i = 1;
            while (aDoc.Content.Bookmarks.Exists("a_" + i))
            {
                object oMissed = aDoc.Bookmarks["a_" + i].Range;
                object oLinktoFile = false;
                object oSaveWithDocument = true;
                aDoc.InlineShapes.AddPicture(pathResim + @"\" + "Ortam " + i + ".png", ref oLinktoFile, ref oSaveWithDocument, ref oMissed);
                i++;
            }
            // Save as the document:
            aDoc.SaveAs2(ref saveAs, ref missing, ref missing, ref missing,
                        ref missing, ref missing, ref missing,
                        ref missing, ref missing, ref missing,
                        ref missing, ref missing, ref missing,
                        ref missing, ref missing, ref missing);

            MessageBox.Show("The report created successfully.");
            List<int> processesaftergen = getRunningProcesses();
            killProcesses(processesbeforegen, processesaftergen);
        }

        public List<int> getRunningProcesses()
        {
            List<int> ProcessIDs = new List<int>();
            foreach (Process clsProcess in Process.GetProcesses())
            {
                if (Process.GetCurrentProcess().Id == clsProcess.Id)
                    continue;
                if (clsProcess.ProcessName.Contains("WINWORD") || clsProcess.ProcessName.Contains("EXCEL"))
                {
                    ProcessIDs.Add(clsProcess.Id);
                }
            }
            return ProcessIDs;
        }

        public void killProcesses(List<int> processesbeforegen, List<int> processesaftergen)
        {
            foreach (int pidafter in processesaftergen)
            {
                bool processfound = false;
                foreach (int pidbefore in processesbeforegen)
                {
                    if (pidafter == pidbefore)
                    {
                        processfound = true;
                    }
                }
                if (processfound == false)
                {
                    Process clsProcess = Process.GetProcessById(pidafter);
                    clsProcess.Kill();
                }
            }
        }
        private void Import_Image_Click_1(object sender, EventArgs e)
        {
            if (graphs.ShowDialog() == DialogResult.OK)
            {
                pathResim = graphs.SelectedPath;
                textBox2.Text = graphs.SelectedPath;
                button1.Enabled = true;
            }
        }
        // Load The Current Document:
        private void Button2_Click_1(object sender, EventArgs e)
        {
            if (LoadDoc.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = LoadDoc.FileName;
               

            }
        }
        // Create The New Document:
        private void Button1_Click_1(object sender, EventArgs e)
        {
            if (SaveDoc.ShowDialog() == DialogResult.OK)
            {
                CreateWordDocument(textBox1.Text, SaveDoc.FileName, pathResim);
               
            }
        }
                           
        private void Export_Click_1(object sender, EventArgs e)
        {
            if (exportpath.ShowDialog() == DialogResult.OK)
            {
                textBox4.Text = exportpath.SelectedPath;
            }
        }

        private void Openexcel_Click_1(object sender, EventArgs e)
        {
            List<int> processesbeforegen = getRunningProcesses();

            if (excelac.ShowDialog() == DialogResult.OK)
            {
                textBox3.Text = excelac.FileName;
                Excel.Application exc = new Excel.Application();
                exc.Visible = false;
                exc.Workbooks.Open(textBox3.Text);
                Worksheet sheet = exc.Worksheets[1];
                sheet.Activate();

                foreach (Worksheet ws in exc.Worksheets)
                {
                    ChartObjects chartobjects = ws.ChartObjects();

                    foreach (ChartObject co in chartobjects)
                    {
                        co.Select();
                        Excel.Chart chart = co.Chart;
                        chart.Export(exportpath.SelectedPath + @"\" + chart.Name + ".png", "PNG", false);

                    }
                }
                progressBar1.Minimum = 0;
                progressBar1.Maximum = 100;
                progressBar1.Step = 10;
                MessageBox.Show("The graphs are imported successfully.");
                List<int> processesaftergen = getRunningProcesses();
                killProcesses(processesbeforegen, processesaftergen);
            }
        }

        
    }

}