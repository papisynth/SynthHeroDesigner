// Decompiled with JetBrains decompiler
// Type: Hero_Designer.frmAbout
// Assembly: Hero Designer, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 971EB14D-7E2B-4ADC-89DF-A9C8225AA28C
// Assembly location: C:\Users\robin\Documents\Mids Hero-20190421T164236Z-001\Mids Hero\Hero Designer.exe

using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using midsControls;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace Hero_Designer
{
  public class frmAbout : Form
  {
    [AccessedThroughProperty("ibClose")]
    private ImageButton _ibClose;
    [AccessedThroughProperty("Label1")]
    private Label _Label1;
    [AccessedThroughProperty("Label3")]
    private Label _Label3;
    [AccessedThroughProperty("Label4")]
    private Label _Label4;
    [AccessedThroughProperty("Label5")]
    private Label _Label5;
    [AccessedThroughProperty("lblDBDate")]
    private Label _lblDBDate;
    [AccessedThroughProperty("lblDBIssue")]
    private Label _lblDBIssue;
    [AccessedThroughProperty("lblDonate")]
    private Label _lblDonate;
    [AccessedThroughProperty("lblEmail")]
    private Label _lblEmail;
    [AccessedThroughProperty("lblLegal")]
    private Label _lblLegal;
    [AccessedThroughProperty("lblVersion")]
    private Label _lblVersion;
    [AccessedThroughProperty("lblWebPage")]
    private Label _lblWebPage;
    [AccessedThroughProperty("pbBackground")]
    private PictureBox _pbBackground;
    [AccessedThroughProperty("tTip")]
    private ToolTip _tTip;
    private IContainer components;
    private Point mouse_offset;

    internal virtual ImageButton ibClose
    {
      get
      {
        return this._ibClose;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        ImageButton.ButtonClickedEventHandler clickedEventHandler = new ImageButton.ButtonClickedEventHandler(this.ibClose_ButtonClicked);
        if (this._ibClose != null)
          this._ibClose.ButtonClicked -= clickedEventHandler;
        this._ibClose = value;
        if (this._ibClose == null)
          return;
        this._ibClose.ButtonClicked += clickedEventHandler;
      }
    }

    internal virtual Label Label1
    {
      get
      {
        return this._Label1;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._Label1 = value;
      }
    }

    internal virtual Label Label3
    {
      get
      {
        return this._Label3;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._Label3 = value;
      }
    }

    internal virtual Label Label4
    {
      get
      {
        return this._Label4;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._Label4 = value;
      }
    }

    internal virtual Label Label5
    {
      get
      {
        return this._Label5;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._Label5 = value;
      }
    }

    internal virtual Label lblDBDate
    {
      get
      {
        return this._lblDBDate;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._lblDBDate = value;
      }
    }

    internal virtual Label lblDBIssue
    {
      get
      {
        return this._lblDBIssue;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._lblDBIssue = value;
      }
    }

    internal virtual Label lblDonate
    {
      get
      {
        return this._lblDonate;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.lblDonate_Click);
        if (this._lblDonate != null)
          this._lblDonate.Click -= eventHandler;
        this._lblDonate = value;
        if (this._lblDonate == null)
          return;
        this._lblDonate.Click += eventHandler;
      }
    }

    internal virtual Label lblEmail
    {
      get
      {
        return this._lblEmail;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.lblEmail_Click);
        if (this._lblEmail != null)
          this._lblEmail.Click -= eventHandler;
        this._lblEmail = value;
        if (this._lblEmail == null)
          return;
        this._lblEmail.Click += eventHandler;
      }
    }

    internal virtual Label lblLegal
    {
      get
      {
        return this._lblLegal;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._lblLegal = value;
      }
    }

    internal virtual Label lblVersion
    {
      get
      {
        return this._lblVersion;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._lblVersion = value;
      }
    }

    internal virtual Label lblWebPage
    {
      get
      {
        return this._lblWebPage;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.lblWebPage_Click);
        if (this._lblWebPage != null)
          this._lblWebPage.Click -= eventHandler;
        this._lblWebPage = value;
        if (this._lblWebPage == null)
          return;
        this._lblWebPage.Click += eventHandler;
      }
    }

    internal virtual PictureBox pbBackground
    {
      get
      {
        return this._pbBackground;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        MouseEventHandler mouseEventHandler1 = new MouseEventHandler(this.PictureBox1_MouseMove);
        MouseEventHandler mouseEventHandler2 = new MouseEventHandler(this.PictureBox1_MouseDown);
        if (this._pbBackground != null)
        {
          this._pbBackground.MouseMove -= mouseEventHandler1;
          this._pbBackground.MouseDown -= mouseEventHandler2;
        }
        this._pbBackground = value;
        if (this._pbBackground == null)
          return;
        this._pbBackground.MouseMove += mouseEventHandler1;
        this._pbBackground.MouseDown += mouseEventHandler2;
      }
    }

    internal virtual ToolTip tTip
    {
      get
      {
        return this._tTip;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._tTip = value;
      }
    }

    public frmAbout()
    {
      this.Load += new EventHandler(this.frmAbout_Load);
      this.InitializeComponent();
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void frmAbout_Load(object sender, EventArgs e)
    {
      string str = "http://www.cohplanner.com/".Replace("http://", "");
      if (str.EndsWith("/") & str.IndexOf("/") == str.Length - 1)
        str = str.Substring(0, str.Length - 1);
      this.lblWebPage.Text = str;
      this.lblVersion.Text = Strings.Format((object) MainModule.MidsController.HeroDesignerVersion, "#0.0####");
      this.lblDBIssue.Text = Conversions.ToString(DatabaseAPI.Database.Issue);
      this.lblDBDate.Text = Strings.Format((object) DatabaseAPI.Database.Version, "#0.0####") + " (" + Strings.Format((object) DatabaseAPI.Database.Date, "dd/MMM/yyyy") + ")";
    }

    private void ibClose_ButtonClicked()
    {
      this.Close();
    }

    [DebuggerStepThrough]
    private void InitializeComponent()
    {
      this.components = (IContainer) new Container();
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (frmAbout));
      this.lblLegal = new Label();
      this.Label1 = new Label();
      this.Label4 = new Label();
      this.Label5 = new Label();
      this.lblDBDate = new Label();
      this.lblDBIssue = new Label();
      this.lblVersion = new Label();
      this.lblEmail = new Label();
      this.lblWebPage = new Label();
      this.tTip = new ToolTip(this.components);
      this.pbBackground = new PictureBox();
      this.Label3 = new Label();
      this.ibClose = new ImageButton();
      ((ISupportInitialize) this.pbBackground).BeginInit();
      this.SuspendLayout();
      this.lblLegal.BackColor = Color.Transparent;
      this.lblLegal.Font = new Font("Arial", 7f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.lblLegal.ForeColor = Color.FromArgb(192, 192, (int) byte.MaxValue);
      Point point = new Point(28, 320);
      this.lblLegal.Location = point;
      this.lblLegal.Name = "lblLegal";
      Size size = new Size(325, 160);
      this.lblLegal.Size = size;
      this.lblLegal.TabIndex = 7;
      this.lblLegal.Text = componentResourceManager.GetString("lblLegal.Text");
      this.lblLegal.TextAlign = ContentAlignment.BottomCenter;
      this.lblLegal.UseMnemonic = false;
      this.Label1.BackColor = Color.Black;
      this.Label1.Font = new Font("Arial", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Label1.ForeColor = Color.FromArgb(192, 192, (int) byte.MaxValue);
      point = new Point(35, 93);
      this.Label1.Location = point;
      this.Label1.Name = "Label1";
      size = new Size(123, 20);
      this.Label1.Size = size;
      this.Label1.TabIndex = 8;
      this.Label1.Text = "Program Version:";
      this.Label1.TextAlign = ContentAlignment.MiddleRight;
      this.Label4.BackColor = Color.Black;
      this.Label4.Font = new Font("Arial", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Label4.ForeColor = Color.FromArgb(192, 192, (int) byte.MaxValue);
      point = new Point(35, 117);
      this.Label4.Location = point;
      this.Label4.Name = "Label4";
      size = new Size(123, 20);
      this.Label4.Size = size;
      this.Label4.TabIndex = 9;
      this.Label4.Text = "Game Issue:";
      this.Label4.TextAlign = ContentAlignment.MiddleRight;
      this.Label5.BackColor = Color.Black;
      this.Label5.Font = new Font("Arial", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Label5.ForeColor = Color.FromArgb(192, 192, (int) byte.MaxValue);
      point = new Point(32, 141);
      this.Label5.Location = point;
      this.Label5.Name = "Label5";
      size = new Size(126, 20);
      this.Label5.Size = size;
      this.Label5.TabIndex = 10;
      this.Label5.Text = "Database Version:";
      this.Label5.TextAlign = ContentAlignment.MiddleRight;
      this.lblDBDate.BackColor = Color.Black;
      this.lblDBDate.Font = new Font("Arial", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.lblDBDate.ForeColor = Color.White;
      point = new Point(164, 141);
      this.lblDBDate.Location = point;
      this.lblDBDate.Name = "lblDBDate";
      size = new Size(184, 20);
      this.lblDBDate.Size = size;
      this.lblDBDate.TabIndex = 11;
      this.lblDBDate.Text = "0/0/0";
      this.lblDBDate.TextAlign = ContentAlignment.MiddleLeft;
      this.lblDBIssue.BackColor = Color.Black;
      this.lblDBIssue.Font = new Font("Arial", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.lblDBIssue.ForeColor = Color.White;
      point = new Point(164, 117);
      this.lblDBIssue.Location = point;
      this.lblDBIssue.Name = "lblDBIssue";
      size = new Size(160, 20);
      this.lblDBIssue.Size = size;
      this.lblDBIssue.TabIndex = 12;
      this.lblDBIssue.Text = "12";
      this.lblDBIssue.TextAlign = ContentAlignment.MiddleLeft;
      this.lblVersion.BackColor = Color.Black;
      this.lblVersion.Font = new Font("Arial", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.lblVersion.ForeColor = Color.White;
      point = new Point(164, 93);
      this.lblVersion.Location = point;
      this.lblVersion.Name = "lblVersion";
      size = new Size(160, 20);
      this.lblVersion.Size = size;
      this.lblVersion.TabIndex = 13;
      this.lblVersion.Text = "1.4";
      this.lblVersion.TextAlign = ContentAlignment.MiddleLeft;
      this.lblEmail.AutoSize = true;
      this.lblEmail.BackColor = Color.Black;
      this.lblEmail.Cursor = Cursors.Hand;
      this.lblEmail.Font = new Font("Arial", 10f, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, (byte) 0);
      this.lblEmail.ForeColor = Color.FromArgb(192, 192, (int) byte.MaxValue);
      point = new Point((int) sbyte.MaxValue, 184);
      this.lblEmail.Location = point;
      this.lblEmail.Name = "lblEmail";
      size = new Size(126, 16);
      this.lblEmail.Size = size;
      this.lblEmail.TabIndex = 14;
      this.lblEmail.Text = "Email Mids' Team";
      this.lblEmail.TextAlign = ContentAlignment.MiddleCenter;
      this.tTip.SetToolTip((Control) this.lblEmail, "Email the author");
      this.lblWebPage.AutoSize = true;
      this.lblWebPage.BackColor = Color.Black;
      this.lblWebPage.Cursor = Cursors.Hand;
      this.lblWebPage.Font = new Font("Arial", 10f, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, (byte) 0);
      this.lblWebPage.ForeColor = Color.FromArgb(192, 192, (int) byte.MaxValue);
      point = new Point(112, 204);
      this.lblWebPage.Location = point;
      this.lblWebPage.Name = "lblWebPage";
      size = new Size(156, 16);
      this.lblWebPage.Size = size;
      this.lblWebPage.TabIndex = 15;
      this.lblWebPage.Text = "www.cohplanner.com";
      this.lblWebPage.TextAlign = ContentAlignment.MiddleCenter;
      this.tTip.SetToolTip((Control) this.lblWebPage, "Mids Hero/Villain Designer homepage");
      point = new Point(159, 257);
      size = new Size(62, 31);
      this.pbBackground.Image = (Image) componentResourceManager.GetObject("pbBackground.Image");
      point = new Point(1, 1);
      this.pbBackground.Location = point;
      this.pbBackground.Name = "pbBackground";
      size = new Size(378, 500);
      this.pbBackground.Size = size;
      this.pbBackground.TabIndex = 19;
      this.pbBackground.TabStop = false;
      this.Label3.BackColor = Color.Black;
      this.Label3.BorderStyle = BorderStyle.Fixed3D;
      point = new Point(24, 75);
      this.Label3.Location = point;
      this.Label3.Name = "Label3";
      size = new Size(332, 413);
      this.Label3.Size = size;
      this.Label3.TabIndex = 20;
      this.ibClose.BackColor = Color.Black;
      this.ibClose.Checked = false;
      this.ibClose.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      point = new Point(0, 0);
      this.ibClose.KnockoutLocationPoint = point;
      point = new Point(138, 304);
      this.ibClose.Location = point;
      this.ibClose.Name = "ibClose";
      size = new Size(105, 22);
      this.ibClose.Size = size;
      this.ibClose.TabIndex = 17;
      this.ibClose.TextOff = "Close";
      this.ibClose.TextOn = "Close";
      this.ibClose.Toggle = false;
      this.AutoScaleMode = AutoScaleMode.None;
      this.BackColor = Color.Black;
      size = new Size(380, 502);
      this.ClientSize = size;
      this.Controls.Add((Control) this.ibClose);
      this.Controls.Add((Control) this.lblDonate);
      this.Controls.Add((Control) this.lblWebPage);
      this.Controls.Add((Control) this.lblEmail);
      this.Controls.Add((Control) this.lblVersion);
      this.Controls.Add((Control) this.lblDBIssue);
      this.Controls.Add((Control) this.lblDBDate);
      this.Controls.Add((Control) this.Label5);
      this.Controls.Add((Control) this.Label4);
      this.Controls.Add((Control) this.Label1);
      this.Controls.Add((Control) this.lblLegal);
      this.Controls.Add((Control) this.Label3);
      this.Controls.Add((Control) this.pbBackground);
      this.Font = new Font("Arial", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.ForeColor = Color.White;
      this.FormBorderStyle = FormBorderStyle.None;
      this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = nameof (frmAbout);
      this.ShowInTaskbar = false;
      this.StartPosition = FormStartPosition.CenterParent;
      this.Text = "About";
      ((ISupportInitialize) this.pbBackground).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();
    }

    private void lblDonate_Click(object sender, EventArgs e)
    {
      clsXMLUpdate.Donate();
    }

    private void lblEmail_Click(object sender, EventArgs e)
    {
      clsXMLUpdate.MailMe();
    }

    private void lblWebPage_Click(object sender, EventArgs e)
    {
      clsXMLUpdate.GoToCoHPlanner();
    }

    private void pbPayPal_Click(object sender, EventArgs e)
    {
      clsXMLUpdate.Donate();
    }

    private void PictureBox1_MouseDown(object sender, MouseEventArgs e)
    {
      this.mouse_offset = new Point(-e.X, -e.Y);
    }

    private void PictureBox1_MouseMove(object sender, MouseEventArgs e)
    {
      if (e.Button != MouseButtons.Left)
        return;
      Point mousePosition = Control.MousePosition;
      mousePosition.Offset(this.mouse_offset.X, this.mouse_offset.Y);
      this.Location = mousePosition;
    }
  }
}
