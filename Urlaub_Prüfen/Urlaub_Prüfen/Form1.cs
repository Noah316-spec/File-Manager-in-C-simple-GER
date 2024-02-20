using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;
using System.Xml.Serialization;

namespace Urlaub_Prüfen
{
  
    public partial class Form1 : Form
    {
        private string filePath = "ihrPfad"; // ihr dateipfad 
        private bool isFile = false;
        private string currentlySelectediteme = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            filepathbox.Text = filePath; // beschreiben des Dateipfads beim starten der Applikation 
            loadFilesAndDirectories(); //methode lffnen
        }

        public void removeBack()
        {
            string path = filepathbox.Text;  // löschen des letzten beitrages 
            if(path.LastIndexOf("\\") == path.Length -1)
            {
                filepathbox.Text = path.Substring(0, path.Length - 1);

            }
        }
        public void  goback()
        {
            try
            {
                removeBack(); // löschen des letzten beitrages 
                string path = filepathbox.Text; // index bis zum nächsten \\ löschen 
                path = path.Substring(0, path.LastIndexOf("\\"));
                this.isFile = false;
                filepathbox.Text = path;
                removeBack();
            }
            catch
            {

            }

        }

        public void loadFilesAndDirectories()
        {
            DirectoryInfo fileList;
            string tempFilePath = "";
            FileAttributes fileAttributes;
            try
            {
                if (isFile)
                {
                    tempFilePath = filePath + "\\" + currentlySelectediteme; // temp wird der dateipfad übergeben
                    FileInfo fileInfo = new FileInfo(tempFilePath);
                    label2.Text = fileInfo.Name; // FileName wird in Label2 geschrieben
                    label4.Text = fileInfo.Extension; // Filetyp wird in label4 geschrieben
                    DateTime creationTimeUtc1 = fileInfo.CreationTimeUtc;
                    label3.Text = creationTimeUtc1.ToString(); // FileCreationtime wird in label3 geschrieben.
                    DateTime lastacces = fileInfo.LastAccessTimeUtc;
                    label6.Text = lastacces.ToString();
                    fileAttributes = System.IO.File.GetAttributes(tempFilePath);
                    Process.Start(tempFilePath); // öffnen der Datei 
                }
                else
                {
                    fileAttributes = System.IO.File.GetAttributes(filePath);

                }
                if((fileAttributes & FileAttributes.Directory) == FileAttributes.Directory)
                {
                    fileList = new DirectoryInfo(filePath); 
                    FileInfo[] files = fileList.GetFiles(); // Get all the files
                    DirectoryInfo[] dirs = fileList.GetDirectories(); // get als directorys
                    string fileExtension = "";
                    listView1.Items.Clear();

                    for (int i = 0; i < files.Length; i++)
                    {
                        fileExtension = files[i].Extension.ToUpper();
                        switch(fileExtension) // auswahl der Dateitypen abfrage
                        {
                            case ".MP3":
                            case ":MP2":

                                listView1.Items.Add(files[i].Name, 5);
                                break;
                            case ".EXE":
                            case ".COM":
                                listView1.Items.Add(files[i].Name, 7);
                                break;
                            case ".MP4":
                            case ".AVI":
                            case ".MKV":

                                listView1.Items.Add(files[i].Name, 6);
                                break;
                            case ".PDF":

                                listView1.Items.Add(files[i].Name, 4);
                                break;
                            case ".DOC":
                            case ".DOCX":
                            case ".TXT":
                                listView1.Items.Add(files[i].Name, 3);
                                break;
                            case ".PNG":
                            case ".JPG":
                            case ".JPEG":

                                listView1.Items.Add(files[i].Name, 9);
                                break;
                            case ".AACDB":

                                listView1.Items.Add(files[i].Name, 13);
                                break;
                            case ".XLSX":
                            case ".XLSM":
                            case ".CSV":
                                listView1.Items.Add(files[i].Name, 12);
                                break;
                            case ".PPTX":
                                listView1.Items.Add(files[i].Name, 11);
                                break;
                            case ".URL":
                                listView1.Items.Add(files[i].Name, 14);
                                break;
                            case ".ZIP":
                                listView1.Items.Add(files[i].Name, 15);
                                break;
                            case ".LNK":
                                listView1.Items.Add(files[i].Name, 16);
                                break;
                            case ".INI":
                                listView1.Items.Add(files[i].Name, 17);
                                break;

                            default:

                                listView1.Items.Add(files[i].Name, 8); //dafult falls es diese Art nicht gibt
                                break;

                        }
                    }
                    for (int i = 0; i < dirs.Length; i++)
                    {
                        listView1.Items.Add(dirs[i].Name, 10); // bild für dirs 
                    }
                }
                else
                {
                    label2.Text =this.currentlySelectediteme;// file Name 
                }
            }
            catch (Exception e)
            {


            }
        }


        


        public void loadbuttonAction()
        {
            //Methode load button action 
            removeBack(); 
            filePath = filepathbox.Text; // aktueller Filepath wird in filepath geschrieben 
            loadFilesAndDirectories();
            isFile = false;



        }
        private void button2_Click(object sender, EventArgs e)
        {
            //Methode loadbutton action wird áusgeführt
            loadbuttonAction(); 
        }

        private void listView1_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            // Die Methode listView1_ItemSelectionChanged wird aufgerufen, wenn sich die Auswahl eines Elements in der ListView ändert.

            // Die folgende Zeile speichert den Text des ausgewählten Elements in der Variable currentlySelectediteme.
            currentlySelectediteme = e.Item.Text;

            // Hier wird der Dateipfad des ausgewählten Elements erstellt.
            string fullPath = Path.Combine(filePath, currentlySelectediteme);

            // Überprüfen, ob das ausgewählte Element ein Verzeichnis ist.
            FileAttributes fileAttributes = System.IO.File.GetAttributes(fullPath);
            if ((fileAttributes & FileAttributes.Directory) == FileAttributes.Directory)
            {
                // Wenn es sich um ein Verzeichnis handelt, setzen wir isFile auf false und aktualisieren den Dateipfad im Textfeld.
                isFile = false;
                filepathbox.Text = fullPath;
            }
            else
            {
                // Andernfalls handelt es sich um eine Datei, und wir setzen isFile auf true.
                isFile = true;
            }
        }


        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //Methode wird geöffnet wenn doppel click auf ein icon gedrückt wird.
            loadbuttonAction();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Dateipfad kann dadurch zurück gestellt werden. Goback und loadbuttonaction werden geöffnet
            goback();
            loadbuttonAction();
        }
    }
}
