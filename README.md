# File-Manager-in-C-simple-GER


Einfacher File Manager in C# einfach und schlicht gehalten. :)


# Einbinden 

using System.Diagnostics;
using System.IO; 
soll beide eingebunden werden einmal zum öffnen und schließen des Dateipfads und zum Starten einer Datei die wir ausgewählt haben.

# Datei-Explorer-Anwendung
Dieses Repository enthält eine einfache Datei-Explorer-Anwendung in C#, die es Benutzern ermöglicht, durch Verzeichnisse zu navigieren und Dateien anzuzeigen. Im Folgenden erkläre ich die wichtigsten Teile des Codes:

# Variablen und Initialisierung


private string filePath = ""; // Ihr Dateipfad
private bool isFile = false;
private string currentlySelectediteme = "";
filePath: Dies ist der Standardpfad, der beim Start der Anwendung verwendet wird.
isFile: Eine boolesche Variable, die angibt, ob das ausgewählte Element eine Datei ist.
currentlySelectediteme: Hier wird der Text des ausgewählten Elements gespeichert.

# Form1_Load-Methode


private void Form1_Load(object sender, EventArgs e)
{
    filepathbox.Text = filePath; // Beschreiben des Dateipfads beim Starten der Applikation
    loadFilesAndDirectories(); // Methode öffnen
}

Der Dateipfad wird im Textfeld filepathbox angezeigt.
Die Methode loadFilesAndDirectories wird aufgerufen, um Dateien und Verzeichnisse zu laden.

# removeBack-Methode


public void removeBack()
{
    string path = filepathbox.Text; // Löschen des letzten Beitrags
    if (path.LastIndexOf("\\") == path.Length - 1)
    {
        filepathbox.Text = path.Substring(0, path.Length - 1);
    }
}
Diese Methode entfernt den letzten Backslash aus dem Pfad im Textfeld filepathbox.

# goback-Methode


public void goback()
{
    try
    {
        removeBack(); // Löschen des letzten Beitrags
        string path = filepathbox.Text; // Index bis zum nächsten \\ löschen
        path = path.Substring(0, path.LastIndexOf("\\"));
        this.isFile = false;
        filepathbox.Text = path;
        removeBack();
    }
    catch
    {
        // Fehlerbehandlung
    }
}
