//<summary>
//  Title   : Server Form
//  System  : Microsoft Visual C# .NET 2008
//  $LastChangedDate: 2009-10-30 14:43:28 +0100 (Pt, 30 paŸ 2009) $
//  $Rev: 4199 $
//  $LastChangedBy: mzbrzezny $
//  $URL: svn://svnserver.hq.cas.com.pl/VS/trunk/PR33-CommServerUA/UAServer/UserInterface/ServerForm.cs $
//  $Id: ServerForm.cs 4199 2009-10-30 13:43:28Z mzbrzezny $
//
//  Copyright (C)2009, CAS LODZ POLAND.
//  TEL: +48 (42) 686 25 47
//  mailto://techsupp@cas.eu
//  http://www.cas.eu
//</summary>

namespace CAS.CommServer.UA.Server.Service.UserInterface
{
    partial class ServerForm 
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
          this.components = new System.ComponentModel.Container();
          System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager( typeof( ServerForm ) );
          this.TrayIcon = new System.Windows.Forms.NotifyIcon( this.components );
          this.serverMenuStrip = new System.Windows.Forms.MenuStrip();
          this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
          this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
          this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
          this.minimizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
          this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
          this.oPCUAViewerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
          this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
          this.onlineHelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
          this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
          this.supportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
          this.rSSFeedsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
          this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
          this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
          this.ServerDiagnosticsCTRL = new ServerDiagnosticsCtrl();
          this.licenseInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
          this.openLogContainingFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
          this.enterUnlockCodeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
          this.serverMenuStrip.SuspendLayout();
          this.SuspendLayout();
          // 
          // TrayIcon
          // 
          this.TrayIcon.Icon = ( (System.Drawing.Icon)( resources.GetObject( "TrayIcon.Icon" ) ) );
          this.TrayIcon.Text = "CAS CommServer  UA";
          this.TrayIcon.Visible = true;
          this.TrayIcon.MouseMove += new System.Windows.Forms.MouseEventHandler( this.TrayIcon_MouseMove );
          this.TrayIcon.Click += new System.EventHandler( this.TrayIcon_Click );
          this.TrayIcon.DoubleClick += new System.EventHandler( this.TrayIcon_Click );
          // 
          // serverMenuStrip
          // 
          this.serverMenuStrip.Items.AddRange( new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.helpToolStripMenuItem} );
          this.serverMenuStrip.Location = new System.Drawing.Point( 0, 0 );
          this.serverMenuStrip.Name = "serverMenuStrip";
          this.serverMenuStrip.Size = new System.Drawing.Size( 703, 24 );
          this.serverMenuStrip.TabIndex = 1;
          this.serverMenuStrip.Text = "menuStrip1";
          // 
          // fileToolStripMenuItem
          // 
          this.fileToolStripMenuItem.DropDownItems.AddRange( new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem} );
          this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
          this.fileToolStripMenuItem.Size = new System.Drawing.Size( 37, 20 );
          this.fileToolStripMenuItem.Text = "File";
          // 
          // exitToolStripMenuItem
          // 
          this.exitToolStripMenuItem.Image = ( (System.Drawing.Image)( resources.GetObject( "exitToolStripMenuItem.Image" ) ) );
          this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
          this.exitToolStripMenuItem.Size = new System.Drawing.Size( 92, 22 );
          this.exitToolStripMenuItem.Text = "Exit";
          this.exitToolStripMenuItem.Click += new System.EventHandler( this.exitToolStripMenuItem_Click );
          // 
          // viewToolStripMenuItem
          // 
          this.viewToolStripMenuItem.DropDownItems.AddRange( new System.Windows.Forms.ToolStripItem[] {
            this.minimizeToolStripMenuItem} );
          this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
          this.viewToolStripMenuItem.Size = new System.Drawing.Size( 44, 20 );
          this.viewToolStripMenuItem.Text = "View";
          // 
          // minimizeToolStripMenuItem
          // 
          this.minimizeToolStripMenuItem.Image = ( (System.Drawing.Image)( resources.GetObject( "minimizeToolStripMenuItem.Image" ) ) );
          this.minimizeToolStripMenuItem.Name = "minimizeToolStripMenuItem";
          this.minimizeToolStripMenuItem.Size = new System.Drawing.Size( 160, 22 );
          this.minimizeToolStripMenuItem.Text = "Minimize to tray";
          this.minimizeToolStripMenuItem.Click += new System.EventHandler( this.minimizeToolStripMenuItem_Click );
          // 
          // toolsToolStripMenuItem
          // 
          this.toolsToolStripMenuItem.DropDownItems.AddRange( new System.Windows.Forms.ToolStripItem[] {
            this.oPCUAViewerToolStripMenuItem} );
          this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
          this.toolsToolStripMenuItem.Size = new System.Drawing.Size( 48, 20 );
          this.toolsToolStripMenuItem.Text = "Tools";
          // 
          // oPCUAViewerToolStripMenuItem
          // 
          this.oPCUAViewerToolStripMenuItem.Image = ( (System.Drawing.Image)( resources.GetObject( "oPCUAViewerToolStripMenuItem.Image" ) ) );
          this.oPCUAViewerToolStripMenuItem.Name = "oPCUAViewerToolStripMenuItem";
          this.oPCUAViewerToolStripMenuItem.Size = new System.Drawing.Size( 155, 22 );
          this.oPCUAViewerToolStripMenuItem.Text = "OPC UA Viewer";
          this.oPCUAViewerToolStripMenuItem.Click += new System.EventHandler( this.oPCUAViewerToolStripMenuItem_Click );
          // 
          // helpToolStripMenuItem
          // 
          this.helpToolStripMenuItem.DropDownItems.AddRange( new System.Windows.Forms.ToolStripItem[] {
            this.onlineHelpToolStripMenuItem,
            this.homeToolStripMenuItem,
            this.supportToolStripMenuItem,
            this.rSSFeedsToolStripMenuItem,
            this.toolStripSeparator1,
            this.aboutToolStripMenuItem,
            this.licenseInformationToolStripMenuItem,
            this.openLogContainingFolderToolStripMenuItem,
            this.enterUnlockCodeToolStripMenuItem} );
          this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
          this.helpToolStripMenuItem.Size = new System.Drawing.Size( 44, 20 );
          this.helpToolStripMenuItem.Text = "Help";
          // 
          // onlineHelpToolStripMenuItem
          // 
          this.onlineHelpToolStripMenuItem.Image = ( (System.Drawing.Image)( resources.GetObject( "onlineHelpToolStripMenuItem.Image" ) ) );
          this.onlineHelpToolStripMenuItem.Name = "onlineHelpToolStripMenuItem";
          this.onlineHelpToolStripMenuItem.Size = new System.Drawing.Size( 226, 22 );
          this.onlineHelpToolStripMenuItem.Text = "Online help";
          this.onlineHelpToolStripMenuItem.Click += new System.EventHandler( this.onlineHelpToolStripMenuItem_Click );
          // 
          // homeToolStripMenuItem
          // 
          this.homeToolStripMenuItem.Image = ( (System.Drawing.Image)( resources.GetObject( "homeToolStripMenuItem.Image" ) ) );
          this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
          this.homeToolStripMenuItem.Size = new System.Drawing.Size( 226, 22 );
          this.homeToolStripMenuItem.Text = "Home";
          this.homeToolStripMenuItem.Click += new System.EventHandler( this.homeToolStripMenuItem_Click );
          // 
          // supportToolStripMenuItem
          // 
          this.supportToolStripMenuItem.Image = ( (System.Drawing.Image)( resources.GetObject( "supportToolStripMenuItem.Image" ) ) );
          this.supportToolStripMenuItem.Name = "supportToolStripMenuItem";
          this.supportToolStripMenuItem.Size = new System.Drawing.Size( 226, 22 );
          this.supportToolStripMenuItem.Text = "Support";
          this.supportToolStripMenuItem.Click += new System.EventHandler( this.supportToolStripMenuItem_Click );
          // 
          // rSSFeedsToolStripMenuItem
          // 
          this.rSSFeedsToolStripMenuItem.Image = ( (System.Drawing.Image)( resources.GetObject( "rSSFeedsToolStripMenuItem.Image" ) ) );
          this.rSSFeedsToolStripMenuItem.Name = "rSSFeedsToolStripMenuItem";
          this.rSSFeedsToolStripMenuItem.Size = new System.Drawing.Size( 226, 22 );
          this.rSSFeedsToolStripMenuItem.Text = "RSS Feeds";
          this.rSSFeedsToolStripMenuItem.Click += new System.EventHandler( this.rSSFeedsToolStripMenuItem_Click );
          // 
          // toolStripSeparator1
          // 
          this.toolStripSeparator1.Name = "toolStripSeparator1";
          this.toolStripSeparator1.Size = new System.Drawing.Size( 223, 6 );
          // 
          // aboutToolStripMenuItem
          // 
          this.aboutToolStripMenuItem.Image = ( (System.Drawing.Image)( resources.GetObject( "aboutToolStripMenuItem.Image" ) ) );
          this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
          this.aboutToolStripMenuItem.Size = new System.Drawing.Size( 226, 22 );
          this.aboutToolStripMenuItem.Text = "About CommServer UA";
          this.aboutToolStripMenuItem.Click += new System.EventHandler( this.aboutToolStripMenuItem_Click );
          // 
          // ServerDiagnosticsCTRL
          // 
          this.ServerDiagnosticsCTRL.Anchor = ( (System.Windows.Forms.AnchorStyles)( ( ( ( System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom )
                      | System.Windows.Forms.AnchorStyles.Left )
                      | System.Windows.Forms.AnchorStyles.Right ) ) );
          this.ServerDiagnosticsCTRL.Location = new System.Drawing.Point( -1, 27 );
          this.ServerDiagnosticsCTRL.Name = "ServerDiagnosticsCTRL";
          this.ServerDiagnosticsCTRL.Size = new System.Drawing.Size( 703, 447 );
          this.ServerDiagnosticsCTRL.TabIndex = 0;
          // 
          // 
          // licenseInformationToolStripMenuItem
          // 
          this.licenseInformationToolStripMenuItem.Image = ( (System.Drawing.Image)( resources.GetObject( "licenseInformationToolStripMenuItem.Image" ) ) );
          this.licenseInformationToolStripMenuItem.Name = "licenseInformationToolStripMenuItem";
          this.licenseInformationToolStripMenuItem.Size = new System.Drawing.Size( 226, 22 );
          this.licenseInformationToolStripMenuItem.Text = "License information";
          this.licenseInformationToolStripMenuItem.Click += new System.EventHandler( this.licenseInformationToolStripMenuItem_Click );
          // 
          // openLogContainingFolderToolStripMenuItem
          // 
          this.openLogContainingFolderToolStripMenuItem.Image = ( (System.Drawing.Image)( resources.GetObject( "openLogContainingFolderToolStripMenuItem.Image" ) ) );
          this.openLogContainingFolderToolStripMenuItem.Name = "openLogContainingFolderToolStripMenuItem";
          this.openLogContainingFolderToolStripMenuItem.Size = new System.Drawing.Size( 226, 22 );
          this.openLogContainingFolderToolStripMenuItem.Text = "Open log containing folder";
          this.openLogContainingFolderToolStripMenuItem.Click += new System.EventHandler( this.openLogContainingFolderToolStripMenuItem_Click );
          // 
          // enterUnlockCodeToolStripMenuItem
          // 
          this.enterUnlockCodeToolStripMenuItem.Image = ( (System.Drawing.Image)( resources.GetObject( "enterUnlockCodeToolStripMenuItem.Image" ) ) );
          this.enterUnlockCodeToolStripMenuItem.Name = "enterUnlockCodeToolStripMenuItem";
          this.enterUnlockCodeToolStripMenuItem.ShortcutKeys = ( (System.Windows.Forms.Keys)( ( System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.K ) ) );
          this.enterUnlockCodeToolStripMenuItem.Size = new System.Drawing.Size( 226, 22 );
          this.enterUnlockCodeToolStripMenuItem.Text = "Enter the unlock code";
          this.enterUnlockCodeToolStripMenuItem.Click += new System.EventHandler( this.enterUnlockCodeToolStripMenuItem_Click );
          // 
          // ServerForm
          // 
          this.AutoScaleDimensions = new System.Drawing.SizeF( 6F, 13F );
          this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
          this.ClientSize = new System.Drawing.Size( 703, 479 );
          this.Controls.Add( this.ServerDiagnosticsCTRL );
          this.Controls.Add( this.serverMenuStrip );
          this.Icon = ( (System.Drawing.Icon)( resources.GetObject( "$this.Icon" ) ) );
          this.MainMenuStrip = this.serverMenuStrip;
          this.Name = "ServerForm";
          this.Text = "CommServer UA Monitor";
          this.FormClosing += new System.Windows.Forms.FormClosingEventHandler( this.ServerForm_FormClosing );
          this.Resize += new System.EventHandler( this.ServerForm_Resize );
          this.serverMenuStrip.ResumeLayout( false );
          this.serverMenuStrip.PerformLayout();
          this.ResumeLayout( false );
          this.PerformLayout();

        }
        #endregion

        private ServerDiagnosticsCtrl ServerDiagnosticsCTRL;
        private System.Windows.Forms.NotifyIcon TrayIcon;
        private System.Windows.Forms.MenuStrip serverMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem minimizeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oPCUAViewerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem onlineHelpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem supportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rSSFeedsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem licenseInformationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openLogContainingFolderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enterUnlockCodeToolStripMenuItem;

    }
}
