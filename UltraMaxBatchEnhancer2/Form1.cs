using Flir.Atlas.Image;
using System;
using System.IO;
using System.Windows.Forms;

using System.Drawing;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Diagnostics;
using Bunifu.UI.WinForms;
using System.Threading;

namespace UltraMaxBatchEnhancer2
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        public Form1()
        {       
            InitializeComponent();   
            ResetEverything();
        }

        public string filePath = "";
        public double num_images;

        //create method "metroButton4_Click()" for Upload button (to upload the image)
        //create FolderBrowserDialog object "folderBrowserDialog1"
        //update Description for folderBrowserDialog1 
        //if the OK button in folderBrowserDialog1 is clicked
            //set filePath variable to the SelectedPath of folderBrowserDialog1
            //set the Text of textBox_SelectedFolderPath to filePath
            //clear the items in listBox_imageFiles
            //create a list of string items "files"; get the files from filePath and set them to "files"
            //for each file item in files
                //try doing the following
                    //create string variable "name"; for the current file, replace the string "filePath+\\" with "", and set that to "name"
                        //if the current file's path ends with .jpg
                        //and the current file is a Thermal Image file
                                //create a Thermal Image file "ti", from the current file
                                //if the Thermal Image file "ti" contains UltraMax data (i.e. it needs to be UltraMax'ed)                                
                                    //add the name of the file "ti" to listBox_imageFiles
                //catch exception
                    //continue to the next item
        private void metroButton4_Click(object sender, EventArgs e)
        {
            {
                FolderBrowserDialog folderBrowserDialog1 = new FolderBrowserDialog();
                folderBrowserDialog1.Description = "Please upload a folder with Thermal Image needing batch enhancement.";

                if (folderBrowserDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    filePath = folderBrowserDialog1.SelectedPath;
                    textBox_SelectedFolderPath.Text = filePath;
                    listBox_imageFiles.Items.Clear();
                    string[] files = Directory.GetFiles(filePath);

                    foreach (string file in files)
                    {
                        try
                        {
                            string name = file.Replace((filePath + "\\"), "");

                            if (file.EndsWith(".jpg") && ThermalImageFile.IsThermalImage(file))
                            {
                                ThermalImageFile ti = new ThermalImageFile(file);
                               
                                if ( ti.ContainsUltraMaxData)
                                {     
                                    listBox_imageFiles.Items.Add(name);
                                }
                            }
                        }
                        catch (Exception)
                        {
                            continue;
                        }
                    }
                }
            }
        }

        //create method "Enhance()"
        //call ThermalImageFile variable "ti"
        //try doing the following
            //create DirectoryInfo object "d", from the filePath
            //create FileInfo list "Files"; get the list of files from d, and set it to Files"
            //create string variable "filePath_original"; add filePath + \\ + backup_um, and set it to "filePath"
            //create directory based on filePath_original
            //create string variable "fileName"
            //create string variable "fileName_original" 
            //for each FileInfo object "file" in FileInfo list list "Files"
                //set variable "fileName" to filePath + \\ + name of the file object
                //set variable "fileName_original" to filePath_original + \\ + name of the file object
                //create ThermalImageFile file object "ti" from the fileName
                //try doing the following
                    //convert the ThermalImageFile file to UltraMax resulution
                    //load the progress bar
                //catch exception
                    //continue to the next item
                //save the ThermalImageFile file 
                //dispose the ThermalImageFile file from memory
                //if the file object does not exist in fileName_original
                    //copy the file object's fileName in to fileName_original (creates a backup/original of the UltraMax image)
            //show MessageBox with title, message, Information icon, OK button, and Help button
        //catch exception
            //show MessageBox with title, message, Question Mark icon, OK button, and Help button

        public void Enhance()
        {
            ThermalImageFile ti;
            
            try
            {
                DirectoryInfo d = new DirectoryInfo(filePath);
                FileInfo[] Files = d.GetFiles();
                string filePath_original = filePath + "\\" + "backup_um";
                Directory.CreateDirectory(filePath_original);
                string fileName;
                string fileName_original;

                foreach (FileInfo file in Files)
                {
                    fileName = filePath + "\\" + file.Name;
                    fileName_original = filePath_original + "\\" + file.Name;
                    ti = new ThermalImageFile(fileName);

                    if (!File.Exists(fileName_original))
                    {
                        File.Copy(fileName, fileName_original);
                    }

                    try
                    {
                        ti.ConvertToUltraMax();
                        LoadProgressBar();
                    }
                    catch (Exception)
                    {
                        continue;
                    }

                    ti.Save();
                    ti.Dispose();
                }   
                MessageBox.Show(this, "UltraMax batch enhancement is now complete.", "Enhancement Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (System.ArgumentException)
            {   
                MessageBox.Show(this, "Please upload a Thermal Image needing batch enhancement.", "Error: No Thermal Image uploaded", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
        }

        //create method ResetEverything()
        //set the Text in textBox_SelectedFolderPath to ""
        //clear the items in listBox_imageFiles
        //set the value of metroProgressBar1 to 0
        //set variable "filePath" to ""
        private void ResetEverything()
        {
            textBox_SelectedFolderPath.Text = "";
            listBox_imageFiles.Items.Clear();
            metroProgressBar1.Value = 0;
            filePath = "";
        }

        //create method LoadProgressBar()
        //create DirectoryInfo object "d", from the filePath
        //create FileInfo list "Files"; get the list of files from d, and set it to "Files"
        //add by 1 to variable "num_images"
        //create double variable "size"; get the length of FileInfo list "Files", and set it to "size"
        //create double variable "progressBar_value"; compute num_images divided by size multiplied by 100, and set it to "progressBar_value"
        //set the value of metroProgressBar1 to progressBar_value (converted to string)

        public void LoadProgressBar()
        {
            try
            {
                DirectoryInfo d = new DirectoryInfo(filePath);
                FileInfo[] Files = d.GetFiles();
                num_images++;
                double size = Files.Length;
                double progressBar_value = num_images / size * 100;
                metroProgressBar1.Value = Convert.ToInt32(progressBar_value);
            }
            catch (Exception)
            {
            }
        }

        //create method "metroButton1_Click()" for Enhance button (to enhance the image)
        //create Thread "t"; set method Enhance() to start "t"
        //start "t"
        //set the CheckForIllegalCrossThreadCalls() method on Form 1 to "false"
        //create Thread "t2"; set method LoadProgressBar() to start "t2"
        //start "t2"
        //set the CheckForIllegalCrossThreadCalls() method on Form 1 to "false"
        //apply the Collect() method on the Garbage Collector
        private void metroButton1_Click(object sender, EventArgs e)
        {
            Thread t = new Thread(new ThreadStart(Enhance));
            t.Start();
            Form1.CheckForIllegalCrossThreadCalls = false;
            
            Thread t2 = new Thread(new ThreadStart(LoadProgressBar));
            t2.Start();            
            Form1.CheckForIllegalCrossThreadCalls = false;
            
            GC.Collect();
        }

        //create method "metroButton2_Click()" for Reset button (to reset the form)
        //apply the ResetEverything() method
        private void metroButton2_Click(object sender, EventArgs e)
        {
            ResetEverything();
        }

        //create method "metroButton3_Click()" for View button (to view the folder)
        //if the length of filePath is not 0
            //open the folder with the images using filePath
        //else
            //show MessageBox with title, message, Question Mark icon, OK button, and Help button
        private void metroButton3_Click(object sender, EventArgs e)
        {
            if (filePath.Length != 0)
            {   
                System.Diagnostics.Process.Start("explorer.exe", filePath);
            }
            else
            {       
                MessageBox.Show(this, "Please upload a Thermal Image needing batch enhancement in order to load a file path.", "Error: No File Path loaded", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
        }

        //create method "Form1_FormClosing()"
        //apply the Collect() method on the Garbage Collector
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {   
            GC.Collect();
        }

        //create method metroLink1_Click()
        //open webpage "wwww.qeatech.com"
        private void metroLink1_Click(object sender, EventArgs e)
        {   
            System.Diagnostics.Process.Start("https://qeatech.com/");
        }

        //create method metroLink2_Click()
        //open webpage "wwww.qeatech.com" [should open User Manual]
        private void metroLink2_Click(object sender, EventArgs e)
        {   
            System.Diagnostics.Process.Start("https://qeatech.com/");
        }

        //extra method; cannot remove
        public void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {

        }
    }
}
