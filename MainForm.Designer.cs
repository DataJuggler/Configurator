

#region using statements


#endregion

namespace Configurator
{

    #region class MainForm
    /// <summary>
    /// This is the designer for the MainForm.
    /// </summary>
    partial class MainForm
    {
        
        #region Private Variables
        private System.ComponentModel.IContainer components = null;
        private DataJuggler.Win.Controls.LabelTextBoxBrowserControl SolutionFolderControl;
        private DataJuggler.Win.Controls.LabelTextBoxControl AppConfigFilesFoundControl;
        private DataJuggler.Win.Controls.LabelTextBoxControl WebConfigFilesFoundControl;
        private DataJuggler.Win.Controls.Button PackButton;
        private System.Windows.Forms.Label StatusLabel;
        #endregion
        
        #region Methods
            
            #region Dispose(bool disposing)
            /// <summary>
            ///  Clean up any resources being used.
            /// </summary>
            /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
            protected override void Dispose(bool disposing)
            {
                if (disposing && (components != null))
                {
                    components.Dispose();
                }
                base.Dispose(disposing);
            }
            #endregion
            
            #region InitializeComponent()
            /// <summary>
            ///  Required method for Designer support - do not modify
            ///  the contents of this method with the code editor.
            /// </summary>
            private void InitializeComponent()
            {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.SolutionFolderControl = new DataJuggler.Win.Controls.LabelTextBoxBrowserControl();
            this.AppConfigFilesFoundControl = new DataJuggler.Win.Controls.LabelTextBoxControl();
            this.WebConfigFilesFoundControl = new DataJuggler.Win.Controls.LabelTextBoxControl();
            this.PackButton = new DataJuggler.Win.Controls.Button();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.UnpackButton = new DataJuggler.Win.Controls.Button();
            this.OutputFolderControl = new DataJuggler.Win.Controls.LabelTextBoxBrowserControl();
            this.SuspendLayout();
            // 
            // SolutionFolderControl
            // 
            this.SolutionFolderControl.BackColor = System.Drawing.Color.Transparent;
            this.SolutionFolderControl.BrowseType = DataJuggler.Win.Controls.Enumerations.BrowseTypeEnum.Folder;
            this.SolutionFolderControl.ButtonImage = ((System.Drawing.Image)(resources.GetObject("SolutionFolderControl.ButtonImage")));
            this.SolutionFolderControl.ButtonWidth = 48;
            this.SolutionFolderControl.DarkMode = false;
            this.SolutionFolderControl.DisabledLabelColor = System.Drawing.Color.Empty;
            this.SolutionFolderControl.Editable = true;
            this.SolutionFolderControl.EnabledLabelColor = System.Drawing.Color.Empty;
            this.SolutionFolderControl.Filter = null;
            this.SolutionFolderControl.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SolutionFolderControl.HideBrowseButton = false;
            this.SolutionFolderControl.LabelBottomMargin = 0;
            this.SolutionFolderControl.LabelColor = System.Drawing.Color.LemonChiffon;
            this.SolutionFolderControl.LabelFont = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SolutionFolderControl.LabelText = "Solution Folder:";
            this.SolutionFolderControl.LabelTopMargin = 0;
            this.SolutionFolderControl.LabelWidth = 148;
            this.SolutionFolderControl.Location = new System.Drawing.Point(57, 39);
            this.SolutionFolderControl.Name = "SolutionFolderControl";
            this.SolutionFolderControl.OnTextChangedListener = null;
            this.SolutionFolderControl.OpenCallback = null;
            this.SolutionFolderControl.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.SolutionFolderControl.SelectedPath = null;
            this.SolutionFolderControl.Size = new System.Drawing.Size(689, 32);
            this.SolutionFolderControl.StartPath = null;
            this.SolutionFolderControl.TabIndex = 0;
            this.SolutionFolderControl.TextBoxBottomMargin = 0;
            this.SolutionFolderControl.TextBoxDisabledColor = System.Drawing.Color.Empty;
            this.SolutionFolderControl.TextBoxEditableColor = System.Drawing.Color.Empty;
            this.SolutionFolderControl.TextBoxFont = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SolutionFolderControl.TextBoxTopMargin = 0;
            this.SolutionFolderControl.Theme = DataJuggler.Win.Controls.Enumerations.ThemeEnum.Dark;
            // 
            // AppConfigFilesFoundControl
            // 
            this.AppConfigFilesFoundControl.BackColor = System.Drawing.Color.Transparent;
            this.AppConfigFilesFoundControl.BottomMargin = 0;
            this.AppConfigFilesFoundControl.Editable = true;
            this.AppConfigFilesFoundControl.Encrypted = false;
            this.AppConfigFilesFoundControl.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AppConfigFilesFoundControl.LabelBottomMargin = 0;
            this.AppConfigFilesFoundControl.LabelColor = System.Drawing.Color.LemonChiffon;
            this.AppConfigFilesFoundControl.LabelFont = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AppConfigFilesFoundControl.LabelText = "App Configs #:";
            this.AppConfigFilesFoundControl.LabelTopMargin = 0;
            this.AppConfigFilesFoundControl.LabelWidth = 148;
            this.AppConfigFilesFoundControl.Location = new System.Drawing.Point(57, 151);
            this.AppConfigFilesFoundControl.MultiLine = false;
            this.AppConfigFilesFoundControl.Name = "AppConfigFilesFoundControl";
            this.AppConfigFilesFoundControl.OnTextChangedListener = null;
            this.AppConfigFilesFoundControl.PasswordMode = false;
            this.AppConfigFilesFoundControl.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.AppConfigFilesFoundControl.Size = new System.Drawing.Size(220, 32);
            this.AppConfigFilesFoundControl.TabIndex = 1;
            this.AppConfigFilesFoundControl.TextBoxBottomMargin = 0;
            this.AppConfigFilesFoundControl.TextBoxDisabledColor = System.Drawing.Color.LightGray;
            this.AppConfigFilesFoundControl.TextBoxEditableColor = System.Drawing.Color.White;
            this.AppConfigFilesFoundControl.TextBoxFont = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AppConfigFilesFoundControl.TextBoxTopMargin = 0;
            this.AppConfigFilesFoundControl.Theme = DataJuggler.Win.Controls.Enumerations.ThemeEnum.Dark;
            // 
            // WebConfigFilesFoundControl
            // 
            this.WebConfigFilesFoundControl.BackColor = System.Drawing.Color.Transparent;
            this.WebConfigFilesFoundControl.BottomMargin = 0;
            this.WebConfigFilesFoundControl.Editable = true;
            this.WebConfigFilesFoundControl.Encrypted = false;
            this.WebConfigFilesFoundControl.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.WebConfigFilesFoundControl.LabelBottomMargin = 0;
            this.WebConfigFilesFoundControl.LabelColor = System.Drawing.Color.LemonChiffon;
            this.WebConfigFilesFoundControl.LabelFont = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.WebConfigFilesFoundControl.LabelText = "Web Configs #:";
            this.WebConfigFilesFoundControl.LabelTopMargin = 0;
            this.WebConfigFilesFoundControl.LabelWidth = 148;
            this.WebConfigFilesFoundControl.Location = new System.Drawing.Point(57, 207);
            this.WebConfigFilesFoundControl.MultiLine = false;
            this.WebConfigFilesFoundControl.Name = "WebConfigFilesFoundControl";
            this.WebConfigFilesFoundControl.OnTextChangedListener = null;
            this.WebConfigFilesFoundControl.PasswordMode = false;
            this.WebConfigFilesFoundControl.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.WebConfigFilesFoundControl.Size = new System.Drawing.Size(220, 32);
            this.WebConfigFilesFoundControl.TabIndex = 2;
            this.WebConfigFilesFoundControl.TextBoxBottomMargin = 0;
            this.WebConfigFilesFoundControl.TextBoxDisabledColor = System.Drawing.Color.LightGray;
            this.WebConfigFilesFoundControl.TextBoxEditableColor = System.Drawing.Color.White;
            this.WebConfigFilesFoundControl.TextBoxFont = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.WebConfigFilesFoundControl.TextBoxTopMargin = 0;
            this.WebConfigFilesFoundControl.Theme = DataJuggler.Win.Controls.Enumerations.ThemeEnum.Dark;
            // 
            // PackButton
            // 
            this.PackButton.BackColor = System.Drawing.Color.Transparent;
            this.PackButton.ButtonText = "Pack";
            this.PackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PackButton.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.PackButton.ForeColor = System.Drawing.Color.LemonChiffon;
            this.PackButton.Location = new System.Drawing.Point(602, 326);
            this.PackButton.Margin = new System.Windows.Forms.Padding(4);
            this.PackButton.Name = "PackButton";
            this.PackButton.Size = new System.Drawing.Size(144, 48);
            this.PackButton.TabIndex = 3;
            this.PackButton.Theme = DataJuggler.Win.Controls.Enumerations.ThemeEnum.Dark;
            this.PackButton.Click += new System.EventHandler(this.PackButton_Click);
            this.PackButton.MouseEnter += new System.EventHandler(this.Button_MouseEnter);
            this.PackButton.MouseLeave += new System.EventHandler(this.Button_MouseLeave);
            // 
            // StatusLabel
            // 
            this.StatusLabel.BackColor = System.Drawing.Color.Transparent;
            this.StatusLabel.ForeColor = System.Drawing.Color.LemonChiffon;
            this.StatusLabel.Location = new System.Drawing.Point(57, 263);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(474, 38);
            this.StatusLabel.TabIndex = 4;
            this.StatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // UnpackButton
            // 
            this.UnpackButton.BackColor = System.Drawing.Color.Transparent;
            this.UnpackButton.ButtonText = "Unpack";
            this.UnpackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UnpackButton.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.UnpackButton.ForeColor = System.Drawing.Color.LemonChiffon;
            this.UnpackButton.Location = new System.Drawing.Point(446, 326);
            this.UnpackButton.Margin = new System.Windows.Forms.Padding(4);
            this.UnpackButton.Name = "UnpackButton";
            this.UnpackButton.Size = new System.Drawing.Size(144, 48);
            this.UnpackButton.TabIndex = 5;
            this.UnpackButton.Theme = DataJuggler.Win.Controls.Enumerations.ThemeEnum.Dark;
            this.UnpackButton.Click += new System.EventHandler(this.UnpackButton_Click);
            this.UnpackButton.MouseEnter += new System.EventHandler(this.Button_MouseEnter);
            this.UnpackButton.MouseLeave += new System.EventHandler(this.Button_MouseLeave);
            // 
            // OutputFolderControl
            // 
            this.OutputFolderControl.BackColor = System.Drawing.Color.Transparent;
            this.OutputFolderControl.BrowseType = DataJuggler.Win.Controls.Enumerations.BrowseTypeEnum.Folder;
            this.OutputFolderControl.ButtonImage = ((System.Drawing.Image)(resources.GetObject("OutputFolderControl.ButtonImage")));
            this.OutputFolderControl.ButtonWidth = 48;
            this.OutputFolderControl.DarkMode = false;
            this.OutputFolderControl.DisabledLabelColor = System.Drawing.Color.Empty;
            this.OutputFolderControl.Editable = true;
            this.OutputFolderControl.EnabledLabelColor = System.Drawing.Color.Empty;
            this.OutputFolderControl.Filter = null;
            this.OutputFolderControl.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.OutputFolderControl.HideBrowseButton = false;
            this.OutputFolderControl.LabelBottomMargin = 0;
            this.OutputFolderControl.LabelColor = System.Drawing.Color.LemonChiffon;
            this.OutputFolderControl.LabelFont = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.OutputFolderControl.LabelText = "Config File:";
            this.OutputFolderControl.LabelTopMargin = 0;
            this.OutputFolderControl.LabelWidth = 148;
            this.OutputFolderControl.Location = new System.Drawing.Point(57, 95);
            this.OutputFolderControl.Name = "OutputFolderControl";
            this.OutputFolderControl.OnTextChangedListener = null;
            this.OutputFolderControl.OpenCallback = null;
            this.OutputFolderControl.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.OutputFolderControl.SelectedPath = null;
            this.OutputFolderControl.Size = new System.Drawing.Size(689, 32);
            this.OutputFolderControl.StartPath = null;
            this.OutputFolderControl.TabIndex = 6;
            this.OutputFolderControl.TextBoxBottomMargin = 0;
            this.OutputFolderControl.TextBoxDisabledColor = System.Drawing.Color.Empty;
            this.OutputFolderControl.TextBoxEditableColor = System.Drawing.Color.Empty;
            this.OutputFolderControl.TextBoxFont = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.OutputFolderControl.TextBoxTopMargin = 0;
            this.OutputFolderControl.Theme = DataJuggler.Win.Controls.Enumerations.ThemeEnum.Dark;
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = global::Configurator.Properties.Resources.BlackImage;
            this.ClientSize = new System.Drawing.Size(800, 417);
            this.Controls.Add(this.OutputFolderControl);
            this.Controls.Add(this.UnpackButton);
            this.Controls.Add(this.StatusLabel);
            this.Controls.Add(this.PackButton);
            this.Controls.Add(this.WebConfigFilesFoundControl);
            this.Controls.Add(this.AppConfigFilesFoundControl);
            this.Controls.Add(this.SolutionFolderControl);
            this.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configurator";
            this.ResumeLayout(false);

            }
        #endregion

        #endregion

        private DataJuggler.Win.Controls.Button UnpackButton;
        private DataJuggler.Win.Controls.LabelTextBoxBrowserControl OutputFolderControl;
    }
    #endregion

}
