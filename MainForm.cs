

#region using statements

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataJuggler.Win.Controls;
using DataJuggler.UltimateHelper;
using Configurator.Objects;
using System.IO;
using Configurator.Enumerations;
using DataJuggler.UltimateHelper.Objects;

#endregion

namespace Configurator
{

    #region class MainForm
    /// <summary>
    /// Main Form for this app.
    /// </summary>
    public partial class MainForm : Form
    {
        
        #region Private Variables
        private string outputFolder;
        private string solutionFolder;
        private const string ConfigFileName = "ConfigOutput.txt";
        #endregion
        
        #region Constructor
        /// <summary>
        /// Create a new instance of a 'MainForm' object.
        /// </summary>
        public MainForm()
        {
            // Create Controls
            InitializeComponent();

            // Perform initializations for this object
            Init();
        }
        #endregion
        
        #region Events
            
            #region PackButton_Click(object sender, EventArgs e)
            /// <summary>
            /// event is fired when the 'PackButton' is clicked.
            /// </summary>
            private void PackButton_Click(object sender, EventArgs e)
            {
                // Set the input properties
                OutputFolder = OutputFolderControl.Text;
                SolutionFolder = SolutionFolderControl.Text;

                // If the strings OutputFolder and SolutionFolder both exist
                if (Valid())
                {
                    // Show a message
                    StatusLabel.Text = "Analyzing";
                    StatusLabel.ForeColor = Color.LemonChiffon;

                    // Perform the pack
                    PackConfigFiles();
                }
                else
                {
                    // Show a message
                    StatusLabel.Text = "Solution Folder and Output Folder are both required to continue.";
                    StatusLabel.ForeColor = Color.Coral;
                }
            }
            #endregion
            
            #region Button_MouseEnter(object sender, EventArgs e)
            /// <summary>
            /// event is fired when a Button _ Mouse Enter
            /// </summary>
            private void Button_MouseEnter(object sender, EventArgs e)
            {
                // Change the cursor to a hand
                Cursor = Cursors.Hand;
            }
            #endregion
            
            #region Button_MouseLeave(object sender, EventArgs e)
            /// <summary>
            /// event is fired when a Button _ Mouse Leave
            /// </summary>
            private void Button_MouseLeave(object sender, EventArgs e)
            {
                // Change the cursor back to the default pointer
                Cursor = Cursors.Default;
            }
            #endregion

            #region UnpackButton_Click(object sender, EventArgs e)
            /// <summary>
            /// event is fired when the 'UnpackButton' is clicked.
            /// </summary>
            private void UnpackButton_Click(object sender, EventArgs e)
            {
                // Set the input properties
                OutputFolder = OutputFolderControl.Text;
                SolutionFolder = SolutionFolderControl.Text;

                // If the strings OutputFolder and SolutionFolder both exist
                if (Valid())
                {
                    // Show a message
                    StatusLabel.Text = "Analyzing";
                    StatusLabel.ForeColor = Color.LemonChiffon;

                    // Now do the unpacking
                    UnpackConfigFiles();
                }
                else
                {
                    // Show a message
                    StatusLabel.Text = "Solution Folder and Output Folder are both required to continue.";
                    StatusLabel.ForeColor = Color.Coral;
                }
            }
            #endregion
            
        #endregion

        #region Methods

            #region CopyFile(DeploymentFile file)
            /// <summary>
            /// This method copies the DeploymentFile passed in
            /// </summary>
            public bool CopyFile(DeploymentFile file)
            {
                // initial value
                bool copied = false;

                try
                {
                    // Copy the source to the target
                    File.Copy(file.Source, file.Target);
                    
                    // set the return value
                    copied = true;
                }
                catch (Exception error)
                {
                    // for debugging only
                    DebugHelper.WriteDebugError("CopyFile", "MainForm.cs", error);
                }
                
                // return value
                return copied;
            }
            #endregion
            
            #region Init()
            /// <summary>
            /// This method performs initializations for this object.
            /// </summary>
            public void Init()
            {
                // read the app settings
                string solutionFolder = ConfigurationHelper.ReadAppSetting("SolutionFolder");
                string outputFolder = ConfigurationHelper.ReadAppSetting("OutputFolder");

                // Display the values
                SolutionFolderControl.Text = solutionFolder;
                OutputFolderControl.Text = outputFolder;
            }
            #endregion
            
            #region PackConfigFiles()
            /// <summary>
            /// This method Pack Config Files
            /// </summary>
            public void PackConfigFiles()
            {
                // local
                List<ConfigLocation> configLocations = new List<ConfigLocation>();

                 // initial value
                string status = "Done.";

                // Create a new collection of 'string' objects.
                List<string> extensions = new List<string>();

                // we only want app.config and web.config files
                extensions.Add(".config");

                // Create a new collection of 'ConfigLocation' objects.
                List<string> files = new List<string>();

                // Get all the config files recursively
                files = FileHelper.GetFilesRecursively(SolutionFolder, ref files, extensions);

                // If the files collection exists and has one or more items
                if (ListHelper.HasOneOrMoreItems(files))
                {
                    // Iterate the collection of string objects
                    foreach (string filePath in files)
                    {
                        // if not a dll not an exe and not nuget
                        bool ignoreFile = ShouldFileBeIgnored(filePath);

                        // Should hte file be ignoored
                        if (!ignoreFile)
                        {
                            // Create a new instance of a 'ConfigLocation' object.
                            ConfigLocation config = new ConfigLocation();

                            // Set the path
                            config.FilePath = filePath;

                            // set the fileInfo
                            FileInfo fileInfo = new FileInfo(filePath);
                        
                            // Set ConfigType
                            if (fileInfo.Name.ToLower().StartsWith("app"))
                            {
                                // set to app.config
                                config.ConfigType = ConfigTypeEnum.AppConfig;
                            }
                            else if (fileInfo.Name.ToLower().StartsWith("web"))
                            {
                                // set to web.config
                                config.ConfigType = ConfigTypeEnum.WebConfig;
                            }

                            // Set the value
                            config.ProjectName = fileInfo.DirectoryName;

                            // Add this item
                            configLocations.Add(config);
                        }
                    }

                    // locals
                    int appConfigCount = 0;
                    int webConfigCount = 0;
                    string outputFilePath = "";
                    FileInfo file = null;
                    StringBuilder sb = null;

                    // If the configLocations collection exists and has one or more items
                    if (ListHelper.HasOneOrMoreItems(configLocations))
                    {
                        // Create a new instance of a 'StringBuilder' object.
                        sb = new StringBuilder();

                        // set the value
                        appConfigCount = configLocations.Where(x => x.ConfigType == ConfigTypeEnum.AppConfig).Count();

                        // set the value
                        webConfigCount = configLocations.Where(x => x.ConfigType == ConfigTypeEnum.WebConfig).Count();

                        // Copy the files to the output folder
                        foreach (ConfigLocation configLocation in configLocations)
                        {
                            // set the file
                            file = new FileInfo(configLocation.FilePath);

                            // Set the outFolderPath
                            DirectoryInfo directory = new DirectoryInfo(configLocation.ProjectName);
                            string outputFolderPath = Path.Combine(OutputFolder, directory.Name);

                            if (directory.Name == "Views")
                            {
                                // there are two for views
                                if (directory.FullName.ToLower().Contains("areas"))
                                {
                                    // Admin and Client both have there own
                                    if (directory.FullName.ToLower().Contains("admin"))
                                    {
                                        // Set the projectName
                                        configLocation.ProjectName = @"AreasAdminViews";
                                    }
                                    else
                                    {
                                        // Set the projectName
                                        configLocation.ProjectName = @"AreasClientViews";
                                    }

                                    // Set the ProjectName
                                    outputFolderPath = Path.Combine(OutputFolder, configLocation.ProjectName);
                                }
                                
                                // if the directory doesn't exist
                                if (!Directory.Exists(outputFolderPath))
                                {
                                    // Create the directory
                                    Directory.CreateDirectory(outputFolderPath);
                                }
                            }
                            else
                            {
                                // if the directory doesn't exist
                                if (!Directory.Exists(outputFolderPath))
                                {
                                    // Create the directory
                                    Directory.CreateDirectory(outputFolderPath);
                                }
                            }

                            // set the outputFolderPath
                            outputFilePath = Path.Combine(outputFolderPath, file.Name);

                            // Copy
                            File.Copy(configLocation.FilePath, outputFilePath);

                            // Add this entry and a newLine
                            sb.Append(configLocation.FilePath);
                            sb.Append(Environment.NewLine);
                            sb.Append(outputFilePath);
                            sb.Append(Environment.NewLine);
                            
                            // Seperator between values
                            sb.Append(Environment.NewLine);
                        }

                        // Get the list
                        string results = sb.ToString();

                        // Write out the contents
                        string configContentSummary = "ConfigOutput.txt";
                        string configContentPath = Path.Combine(OutputFolder, configContentSummary);

                        // Delete this file if it already exists, as there can be only 1 in the output folder.
                        if (File.Exists(configContentPath))
                        {
                            // Delete this file
                            File.Delete(configContentPath);
                        }

                        // Write out our results
                        File.AppendAllText(configContentPath, results);

                        // Set status
                        if (ListHelper.HasXOrMoreItems(configLocations, 2))
                        {
                            status = "Copied " + configLocations.Count + " files.";
                        }
                        else
                        {
                            status = "Copied " + configLocations.Count + " file.";
                        }
                    }

                    // Display results
                    AppConfigFilesFoundControl.Text = appConfigCount.ToString();
                    WebConfigFilesFoundControl.Text = webConfigCount.ToString();

                    // Set the text
                    StatusLabel.Text = status;
                }
            }
            #endregion
            
            #region ShouldFileBeIgnored(string filePath)
            /// <summary>
            /// This method returns the File Be Ignored
            /// </summary>
            public bool ShouldFileBeIgnored(string filePath)
            {
                // initial value
                bool ignoreFile = false;

                if (filePath.ToLower().Contains("bin"))
                {
                    // set to true
                    ignoreFile = true;    
                }

                if (filePath.ToLower().Contains("obj"))
                {
                    // set to true
                    ignoreFile = true;    
                }

                if (filePath.ToLower().Contains("nuget"))
                {
                    // set to true
                    ignoreFile = true;    
                }

                if (filePath.ToLower().Contains("exe"))
                {
                    // set to true
                    ignoreFile = true;    
                }

                if (filePath.ToLower().Contains("dll"))
                {
                    // set to true
                    ignoreFile = true;    
                }

                if (filePath.ToLower().Contains(".vs"))
                {
                    // set to true
                    ignoreFile = true;    
                }

                if (filePath.ToLower().Contains("tools"))
                {
                    // set to true
                    ignoreFile = true;    
                }

                if (filePath.ToLower().Contains("sample"))
                {
                    // set to true
                    ignoreFile = true;    
                }

                if (filePath.ToLower().Contains("testopapi"))
                {
                    // set to true
                    ignoreFile = true;    
                }

                if (filePath.ToLower().Contains("packages"))
                {
                    // set to true
                    ignoreFile = true;    
                }
                
                // return value
                return ignoreFile;
            }
        #endregion

            #region UnpackConfigFiles()
            /// <summary>
            /// This method Unpacks the Config Files
            /// </summary>
            public void UnpackConfigFiles()
            {
                // Get the path
                string configFilePath = Path.Combine(OutputFolder, ConfigFileName);

                // locals
                int filesCopied = 0;
                bool fileCopied = false;

                // get all the text from the file
                string configFileContent = File.ReadAllText(configFilePath);

                // Get all the lines
                List<TextLine> lines = TextHelper.GetTextLines(configFileContent);

                // If the lines collection exists and has one or more items
                if (ListHelper.HasOneOrMoreItems(lines))
                {
                    // Create a new collection of 'DeploymentFile' objects.
                    List<DeploymentFile> deploymentFiles = new List<DeploymentFile>();

                    // locals
                    DeploymentFile deploymentFile = null;
                    int row = -1;

                    // Iterate the collection of TextLine objects
                    foreach (TextLine line in lines)
                    {
                        // Increment the value for row
                        row++;

                        if (row % 3 == 0)
                        {   
                            // Create a new instance of a 'DeploymentFile' object.
                            deploymentFile = new DeploymentFile();

                            // Set the source
                            deploymentFile.Target = line.Text;
                        }
                        else if (row % 3 == 1)
                        {
                            // Set the source
                            deploymentFile.Source = line.Text;

                            // Add this deploymentFile
                            deploymentFiles.Add(deploymentFile);
                        }
                    }

                    // If the deploymentFiles collection exists and has one or more items
                    if (ListHelper.HasOneOrMoreItems(deploymentFiles))
                    {
                        // Iterate the collection of DeploymentFile objects
                        foreach (DeploymentFile file in deploymentFiles)
                        {
                            // Copy this file
                            fileCopied = CopyFile(file);

                            // if the value for fileCopied is true
                            if (fileCopied)
                            {
                                // Increment the value for filesCopied
                                filesCopied++;
                            }
                        }

                        // Display the text
                        StatusLabel.Text = "Finished copying " + filesCopied + " config files.";

                        // if singular
                        if (filesCopied == 1)
                        {
                            // Change to a singular message
                            StatusLabel.Text = "Finished copying 1 file.";
                        }
                    }
                }
            }
            #endregion
            
            #region Valid()
            /// <summary>
            /// This method returns the
            /// </summary>
            public bool Valid()
            {
                // initial value
                bool valid = TextHelper.Exists(SolutionFolder, OutputFolder);
                
                // return value
                return valid;
            }
            #endregion
            
        #endregion

        #region Properties

            #region OutputFolder
            /// <summary>
            /// This property gets or sets the value for 'OutputFolder'.
            /// </summary>
            public string OutputFolder
            {
                get { return outputFolder; }
                set { outputFolder = value; }
            }
            #endregion
            
            #region SolutionFolder
            /// <summary>
            /// This property gets or sets the value for 'SolutionFolder'.
            /// </summary>
            public string SolutionFolder
            {
                get { return solutionFolder; }
                set { solutionFolder = value; }
            }
            #endregion
            
        #endregion

    }
    #endregion

}
