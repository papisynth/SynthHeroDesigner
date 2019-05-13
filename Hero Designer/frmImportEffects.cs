﻿// Decompiled with JetBrains decompiler
// Type: Hero_Designer.frmImportEffects
// Assembly: Hero Designer, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 971EB14D-7E2B-4ADC-89DF-A9C8225AA28C
// Assembly location: C:\Users\robin\Documents\Mids Hero-20190421T164236Z-001\Mids Hero\Hero Designer.exe

using Base.IO_Classes;
using Import;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace Hero_Designer
{
  [DesignerGenerated]
  public class frmImportEffects : Form
  {
    private frmBusy _bFrm;
    [AccessedThroughProperty("btnCheckAll")]
    private Button _btnCheckAll;
    [AccessedThroughProperty("btnClose")]
    private Button _btnClose;
    [AccessedThroughProperty("btnEraseAll")]
    private Button _btnEraseAll;
    [AccessedThroughProperty("btnFile")]
    private Button _btnFile;
    [AccessedThroughProperty("btnImport")]
    private Button _btnImport;
    [AccessedThroughProperty("btnUncheckAll")]
    private Button _btnUncheckAll;
    [AccessedThroughProperty("ColumnHeader1")]
    private ColumnHeader _ColumnHeader1;
    [AccessedThroughProperty("ColumnHeader2")]
    private ColumnHeader _ColumnHeader2;
    [AccessedThroughProperty("ColumnHeader3")]
    private ColumnHeader _ColumnHeader3;
    [AccessedThroughProperty("ColumnHeader4")]
    private ColumnHeader _ColumnHeader4;
    [AccessedThroughProperty("ColumnHeader5")]
    private ColumnHeader _ColumnHeader5;
    [AccessedThroughProperty("ColumnHeader6")]
    private ColumnHeader _ColumnHeader6;
    private readonly List<ListViewItem> _currentItems;
    [AccessedThroughProperty("dlgBrowse")]
    private OpenFileDialog _dlgBrowse;
    private string _fullFileName;
    [AccessedThroughProperty("HideUnchanged")]
    private Button _HideUnchanged;
    private List<EffectData> _importBuffer;
    [AccessedThroughProperty("Label6")]
    private Label _Label6;
    [AccessedThroughProperty("Label8")]
    private Label _Label8;
    [AccessedThroughProperty("lblDate")]
    private Label _lblDate;
    [AccessedThroughProperty("lblFile")]
    private Label _lblFile;
    [AccessedThroughProperty("lstImport")]
    private ListView _lstImport;
    private bool _showUnchanged;
    [AccessedThroughProperty("txtNoAU")]
    private Label _txtNoAU;
    [AccessedThroughProperty("udRevision")]
    private NumericUpDown _udRevision;
    private IContainer components;

    internal virtual Button btnCheckAll
    {
      get
      {
        return this._btnCheckAll;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.btnCheckAll_Click);
        if (this._btnCheckAll != null)
          this._btnCheckAll.Click -= eventHandler;
        this._btnCheckAll = value;
        if (this._btnCheckAll == null)
          return;
        this._btnCheckAll.Click += eventHandler;
      }
    }

    internal virtual Button btnClose
    {
      get
      {
        return this._btnClose;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.btnClose_Click);
        if (this._btnClose != null)
          this._btnClose.Click -= eventHandler;
        this._btnClose = value;
        if (this._btnClose == null)
          return;
        this._btnClose.Click += eventHandler;
      }
    }

    internal virtual Button btnEraseAll
    {
      get
      {
        return this._btnEraseAll;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.btnEraseAll_Click);
        if (this._btnEraseAll != null)
          this._btnEraseAll.Click -= eventHandler;
        this._btnEraseAll = value;
        if (this._btnEraseAll == null)
          return;
        this._btnEraseAll.Click += eventHandler;
      }
    }

    internal virtual Button btnFile
    {
      get
      {
        return this._btnFile;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.btnFile_Click);
        if (this._btnFile != null)
          this._btnFile.Click -= eventHandler;
        this._btnFile = value;
        if (this._btnFile == null)
          return;
        this._btnFile.Click += eventHandler;
      }
    }

    internal virtual Button btnImport
    {
      get
      {
        return this._btnImport;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.btnImport_Click);
        if (this._btnImport != null)
          this._btnImport.Click -= eventHandler;
        this._btnImport = value;
        if (this._btnImport == null)
          return;
        this._btnImport.Click += eventHandler;
      }
    }

    internal virtual Button btnUncheckAll
    {
      get
      {
        return this._btnUncheckAll;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.btnUncheckAll_Click);
        if (this._btnUncheckAll != null)
          this._btnUncheckAll.Click -= eventHandler;
        this._btnUncheckAll = value;
        if (this._btnUncheckAll == null)
          return;
        this._btnUncheckAll.Click += eventHandler;
      }
    }

    internal virtual ColumnHeader ColumnHeader1
    {
      get
      {
        return this._ColumnHeader1;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._ColumnHeader1 = value;
      }
    }

    internal virtual ColumnHeader ColumnHeader2
    {
      get
      {
        return this._ColumnHeader2;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._ColumnHeader2 = value;
      }
    }

    internal virtual ColumnHeader ColumnHeader3
    {
      get
      {
        return this._ColumnHeader3;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._ColumnHeader3 = value;
      }
    }

    internal virtual ColumnHeader ColumnHeader4
    {
      get
      {
        return this._ColumnHeader4;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._ColumnHeader4 = value;
      }
    }

    internal virtual ColumnHeader ColumnHeader5
    {
      get
      {
        return this._ColumnHeader5;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._ColumnHeader5 = value;
      }
    }

    internal virtual ColumnHeader ColumnHeader6
    {
      get
      {
        return this._ColumnHeader6;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._ColumnHeader6 = value;
      }
    }

    internal virtual OpenFileDialog dlgBrowse
    {
      get
      {
        return this._dlgBrowse;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._dlgBrowse = value;
      }
    }

    internal virtual Button HideUnchanged
    {
      get
      {
        return this._HideUnchanged;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.HideUnchanged_Click);
        if (this._HideUnchanged != null)
          this._HideUnchanged.Click -= eventHandler;
        this._HideUnchanged = value;
        if (this._HideUnchanged == null)
          return;
        this._HideUnchanged.Click += eventHandler;
      }
    }

    internal virtual Label Label6
    {
      get
      {
        return this._Label6;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._Label6 = value;
      }
    }

    internal virtual Label Label8
    {
      get
      {
        return this._Label8;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._Label8 = value;
      }
    }

    internal virtual Label lblDate
    {
      get
      {
        return this._lblDate;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._lblDate = value;
      }
    }

    internal virtual Label lblFile
    {
      get
      {
        return this._lblFile;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._lblFile = value;
      }
    }

    internal virtual ListView lstImport
    {
      get
      {
        return this._lstImport;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._lstImport = value;
      }
    }

    internal virtual Label txtNoAU
    {
      get
      {
        return this._txtNoAU;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._txtNoAU = value;
      }
    }

    internal virtual NumericUpDown udRevision
    {
      get
      {
        return this._udRevision;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._udRevision = value;
      }
    }

    public frmImportEffects()
    {
      this.Load += new EventHandler(this.frmImportEffects_Load);
      this._fullFileName = "";
      this._showUnchanged = true;
      this.InitializeComponent();
      this._importBuffer = new List<EffectData>();
      this._currentItems = new List<ListViewItem>();
    }

    private void btnCheckAll_Click(object sender, EventArgs e)
    {
      this.lstImport.BeginUpdate();
      int num = this.lstImport.Items.Count - 1;
      for (int index = 0; index <= num; ++index)
        this.lstImport.Items[index].Checked = true;
      this.lstImport.EndUpdate();
    }

    private void btnClose_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    private void btnEraseAll_Click(object sender, EventArgs e)
    {
      int num1 = DatabaseAPI.Database.Power.Length - 1;
      for (int index = 0; index <= num1; ++index)
        DatabaseAPI.Database.Power[index].Effects = new IEffect[0];
      int num2 = this._importBuffer.Count - 1;
      for (int index = 0; index <= num2; ++index)
      {
        if (this._importBuffer[index].IsValid)
          this._importBuffer[index].IsNew = true;
      }
      int num3 = (int) Interaction.MsgBox((object) "All power effects removed!", MsgBoxStyle.OkOnly, (object) null);
    }

    private void btnFile_Click(object sender, EventArgs e)
    {
      this.dlgBrowse.FileName = this._fullFileName;
      if (this.dlgBrowse.ShowDialog((IWin32Window) this) == DialogResult.OK)
      {
        this._fullFileName = this.dlgBrowse.FileName;
        this.Enabled = false;
        if (this.ParseClasses(this._fullFileName))
          this.FillListView();
        this.Enabled = true;
      }
      this.BusyHide();
      this.DisplayInfo();
    }

    private void btnImport_Click(object sender, EventArgs e)
    {
      this.ProcessImport();
    }

    private void btnUncheckAll_Click(object sender, EventArgs e)
    {
      this.lstImport.BeginUpdate();
      int num = this.lstImport.Items.Count - 1;
      for (int index = 0; index <= num; ++index)
        this.lstImport.Items[index].Checked = false;
      this.lstImport.EndUpdate();
    }

    private void BusyHide()
    {
      if (this._bFrm == null)
        return;
      this._bFrm.Close();
      this._bFrm = (frmBusy) null;
    }

    private void BusyMsg(string sMessage)
    {
      if (this._bFrm == null)
      {
        this._bFrm = new frmBusy();
        this._bFrm.Show((IWin32Window) this);
      }
      this._bFrm.SetMessage(sMessage);
    }

    private void DisplayInfo()
    {
      this.lblFile.Text = FileIO.StripPath(this._fullFileName);
      this.lblDate.Text = "Date: " + Strings.Format((object) DatabaseAPI.Database.PowerEffectVersion.RevisionDate, "dd/MMM/yy HH:mm:ss");
      this.udRevision.Value = new Decimal(DatabaseAPI.Database.PowerEffectVersion.Revision);
      int num1 = 0;
      int num2 = DatabaseAPI.Database.Power.Length - 1;
      for (int index = 0; index <= num2; ++index)
      {
        if (DatabaseAPI.Database.Power[index].NeverAutoUpdate)
          ++num1;
      }
      this.txtNoAU.Text = Conversions.ToString(num1) + " powers locked.";
    }

    [DebuggerNonUserCode]
    protected override void Dispose(bool disposing)
    {
      try
      {
        if (!disposing || this.components == null)
          return;
        this.components.Dispose();
      }
      finally
      {
        base.Dispose(disposing);
      }
    }

    private void FillListView()
    {
      string[] items = new string[6];
      this.lstImport.BeginUpdate();
      this.lstImport.Items.Clear();
      int num1 = 0;
      int num2 = 0;
      int num3 = 0;
      int num4 = 0;
      int num5 = this._importBuffer.Count - 1;
      for (int index = 0; index <= num5; ++index)
      {
        ++num1;
        if (num1 >= 100)
        {
          this.BusyMsg(Strings.Format((object) index, "###,##0") + " records checked.");
          Application.DoEvents();
          num1 = 0;
        }
        if (this._importBuffer[index].IsValid)
        {
          items[0] = this._importBuffer[index].Data.PowerFullName;
          items[1] = Enum.GetName(this._importBuffer[index].Data.EffectType.GetType(), (object) this._importBuffer[index].Data.EffectType);
          bool flag = false;
          if (this._importBuffer[index].IsNew)
          {
            items[2] = "Yes";
            if (this._importBuffer[index].IsLocked)
              items[2] = "Lock";
            ++num2;
          }
          else
          {
            items[2] = "No";
            flag = this._importBuffer[index].CheckDifference(ref DatabaseAPI.Database.Power[this._importBuffer[index].Index].Effects[this._importBuffer[index].Nid], out items[5]);
          }
          if (flag)
          {
            items[3] = "Yes";
            if (this._importBuffer[index].IsLocked)
              items[3] = "Lock";
            ++num3;
          }
          else
            items[3] = "No";
          if (this._importBuffer[index].IndexChanged)
          {
            items[4] = "Yes (" + Conversions.ToString(this._importBuffer[index].Nid) + ")";
            if (this._importBuffer[index].IsLocked)
              items[2] = "Lock (" + Conversions.ToString(this._importBuffer[index].Nid) + ")";
            ++num4;
          }
          else
            items[4] = "No";
          ListViewItem listViewItem = new ListViewItem(items)
          {
            Checked = flag | this._importBuffer[index].IsNew,
            Tag = (object) index
          };
          this._currentItems.Add(listViewItem);
          this.lstImport.Items.Add(listViewItem);
        }
      }
      if (this.lstImport.Items.Count > 0)
        this.lstImport.Items[0].EnsureVisible();
      this.lstImport.EndUpdate();
      this.HideUnchanged.Text = "Hide Unchanged";
      int num6 = (int) Interaction.MsgBox((object) ("New: " + Conversions.ToString(num2) + "\r\nModified: " + Conversions.ToString(num3) + "\r\nRe-Indexed: " + Conversions.ToString(num4)), MsgBoxStyle.OkOnly, (object) null);
    }

    private void frmImportEffects_Load(object sender, EventArgs e)
    {
      this._fullFileName = DatabaseAPI.Database.PowerEffectVersion.SourceFile;
      this.DisplayInfo();
    }

    private void HideUnchanged_Click(object sender, EventArgs e)
    {
      this._showUnchanged = !this._showUnchanged;
      this.lstImport.BeginUpdate();
      this.lstImport.Items.Clear();
      int num = this._currentItems.Count - 1;
      for (int index = 0; index <= num; ++index)
      {
        if (this._showUnchanged | this._currentItems[index].SubItems[2].Text == "Yes" | this._currentItems[index].SubItems[3].Text == "Yes")
          this.lstImport.Items.Add(this._currentItems[index]);
      }
      this.lstImport.EndUpdate();
    }

    [DebuggerStepThrough]
    private void InitializeComponent()
    {
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (frmImportEffects));
      this.btnCheckAll = new Button();
      this.btnClose = new Button();
      this.dlgBrowse = new OpenFileDialog();
      this.btnUncheckAll = new Button();
      this.btnImport = new Button();
      this.lstImport = new ListView();
      this.ColumnHeader1 = new ColumnHeader();
      this.ColumnHeader2 = new ColumnHeader();
      this.ColumnHeader4 = new ColumnHeader();
      this.ColumnHeader5 = new ColumnHeader();
      this.ColumnHeader3 = new ColumnHeader();
      this.ColumnHeader6 = new ColumnHeader();
      this.Label8 = new Label();
      this.lblDate = new Label();
      this.udRevision = new NumericUpDown();
      this.Label6 = new Label();
      this.lblFile = new Label();
      this.btnFile = new Button();
      this.btnEraseAll = new Button();
      this.txtNoAU = new Label();
      this.HideUnchanged = new Button();
      this.udRevision.BeginInit();
      this.SuspendLayout();
      Point point = new Point(12, 545);
      this.btnCheckAll.Location = point;
      this.btnCheckAll.Name = "btnCheckAll";
      Size size = new Size(75, 23);
      this.btnCheckAll.Size = size;
      this.btnCheckAll.TabIndex = 60;
      this.btnCheckAll.Text = "Check All";
      this.btnCheckAll.UseVisualStyleBackColor = true;
      point = new Point(904, 516);
      this.btnClose.Location = point;
      this.btnClose.Name = "btnClose";
      size = new Size(86, 23);
      this.btnClose.Size = size;
      this.btnClose.TabIndex = 59;
      this.btnClose.Text = "Close";
      this.btnClose.UseVisualStyleBackColor = true;
      this.dlgBrowse.DefaultExt = "csv";
      this.dlgBrowse.Filter = "CSV Spreadsheets (*.csv)|*.csv";
      point = new Point(93, 545);
      this.btnUncheckAll.Location = point;
      this.btnUncheckAll.Name = "btnUncheckAll";
      size = new Size(75, 23);
      this.btnUncheckAll.Size = size;
      this.btnUncheckAll.TabIndex = 61;
      this.btnUncheckAll.Text = "Uncheck All";
      this.btnUncheckAll.UseVisualStyleBackColor = true;
      point = new Point(904, 77);
      this.btnImport.Location = point;
      this.btnImport.Name = "btnImport";
      size = new Size(86, 22);
      this.btnImport.Size = size;
      this.btnImport.TabIndex = 58;
      this.btnImport.Text = "Import";
      this.btnImport.UseVisualStyleBackColor = true;
      this.lstImport.CheckBoxes = true;
      this.lstImport.Columns.AddRange(new ColumnHeader[6]
      {
        this.ColumnHeader1,
        this.ColumnHeader2,
        this.ColumnHeader4,
        this.ColumnHeader5,
        this.ColumnHeader3,
        this.ColumnHeader6
      });
      this.lstImport.HeaderStyle = ColumnHeaderStyle.Nonclickable;
      point = new Point(12, 77);
      this.lstImport.Location = point;
      this.lstImport.Name = "lstImport";
      size = new Size(886, 462);
      this.lstImport.Size = size;
      this.lstImport.TabIndex = 57;
      this.lstImport.UseCompatibleStateImageBehavior = false;
      this.lstImport.View = View.Details;
      this.ColumnHeader1.Text = "Power";
      this.ColumnHeader1.Width = 293;
      this.ColumnHeader2.Text = "Effect";
      this.ColumnHeader2.Width = 87;
      this.ColumnHeader4.Text = "New";
      this.ColumnHeader4.Width = 53;
      this.ColumnHeader5.Text = "Modified";
      this.ColumnHeader3.Text = "PowerIndex Change";
      this.ColumnHeader3.Width = 93;
      this.ColumnHeader6.Text = "Change";
      this.ColumnHeader6.Width = 310;
      point = new Point(632, 53);
      this.Label8.Location = point;
      this.Label8.Name = "Label8";
      size = new Size(65, 18);
      this.Label8.Size = size;
      this.Label8.TabIndex = 56;
      this.Label8.Text = "Revision:";
      this.Label8.TextAlign = ContentAlignment.TopRight;
      point = new Point(9, 53);
      this.lblDate.Location = point;
      this.lblDate.Name = "lblDate";
      size = new Size(175, 18);
      this.lblDate.Size = size;
      this.lblDate.TabIndex = 54;
      this.lblDate.Text = "Date:";
      point = new Point(703, 51);
      this.udRevision.Location = point;
      this.udRevision.Maximum = new Decimal(new int[4]
      {
        (int) ushort.MaxValue,
        0,
        0,
        0
      });
      this.udRevision.Name = "udRevision";
      size = new Size(116, 20);
      this.udRevision.Size = size;
      this.udRevision.TabIndex = 53;
      point = new Point(12, 9);
      this.Label6.Location = point;
      this.Label6.Name = "Label6";
      size = new Size(150, 14);
      this.Label6.Size = size;
      this.Label6.TabIndex = 52;
      this.Label6.Text = "Effect Definition File:";
      this.lblFile.BorderStyle = BorderStyle.Fixed3D;
      point = new Point(12, 25);
      this.lblFile.Location = point;
      this.lblFile.Name = "lblFile";
      size = new Size(807, 23);
      this.lblFile.Size = size;
      this.lblFile.TabIndex = 51;
      this.lblFile.TextAlign = ContentAlignment.MiddleLeft;
      point = new Point(825, 25);
      this.btnFile.Location = point;
      this.btnFile.Name = "btnFile";
      size = new Size(165, 23);
      this.btnFile.Size = size;
      this.btnFile.TabIndex = 50;
      this.btnFile.Text = "Load / Re-Load";
      this.btnFile.UseVisualStyleBackColor = true;
      point = new Point(904, 120);
      this.btnEraseAll.Location = point;
      this.btnEraseAll.Name = "btnEraseAll";
      size = new Size(86, 69);
      this.btnEraseAll.Size = size;
      this.btnEraseAll.TabIndex = 62;
      this.btnEraseAll.Text = "Erase All Effects";
      this.btnEraseAll.UseVisualStyleBackColor = true;
      point = new Point(904, 192);
      this.txtNoAU.Location = point;
      this.txtNoAU.Name = "txtNoAU";
      size = new Size(86, 55);
      this.txtNoAU.Size = size;
      this.txtNoAU.TabIndex = 63;
      this.txtNoAU.Text = "0 Powers Locked";
      this.txtNoAU.TextAlign = ContentAlignment.MiddleCenter;
      point = new Point(174, 545);
      this.HideUnchanged.Location = point;
      this.HideUnchanged.Name = "HideUnchanged";
      size = new Size(99, 23);
      this.HideUnchanged.Size = size;
      this.HideUnchanged.TabIndex = 64;
      this.HideUnchanged.Text = "Hide Unchanged";
      this.HideUnchanged.UseVisualStyleBackColor = true;
      this.AutoScaleMode = AutoScaleMode.None;
      size = new Size(1002, 573);
      this.ClientSize = size;
      this.Controls.Add((Control) this.HideUnchanged);
      this.Controls.Add((Control) this.txtNoAU);
      this.Controls.Add((Control) this.btnEraseAll);
      this.Controls.Add((Control) this.btnCheckAll);
      this.Controls.Add((Control) this.btnClose);
      this.Controls.Add((Control) this.btnUncheckAll);
      this.Controls.Add((Control) this.btnImport);
      this.Controls.Add((Control) this.lstImport);
      this.Controls.Add((Control) this.Label8);
      this.Controls.Add((Control) this.lblDate);
      this.Controls.Add((Control) this.udRevision);
      this.Controls.Add((Control) this.Label6);
      this.Controls.Add((Control) this.lblFile);
      this.Controls.Add((Control) this.btnFile);
      this.Font = new Font("Arial", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.FormBorderStyle = FormBorderStyle.FixedDialog;
      this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = nameof (frmImportEffects);
      this.ShowInTaskbar = false;
      this.Text = "Import Power Effects";
      this.udRevision.EndInit();
      this.ResumeLayout(false);
    }

    private bool ParseClasses(string iFileName)
    {
      int num1 = 0;
      StreamReader iStream;
      try
      {
        iStream = new StreamReader(iFileName);
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        int num2 = (int) Interaction.MsgBox((object) ex.Message, MsgBoxStyle.Critical, (object) "Power CSV Not Opened");
        ProjectData.ClearProjectError();
        return false;
      }
      int num3 = 0;
      int num4 = 0;
      int num5 = 0;
      this._importBuffer = new List<EffectData>();
      int num6 = 0;
      int num7 = -1;
      int num8 = 0;
      int index1 = -1;
      string iString;
      do
      {
        iString = FileIO.ReadLineUnlimited(iStream, char.MinValue);
        if (iString != null && !iString.StartsWith("#"))
        {
          ++num6;
          if (num6 >= 99)
          {
            this.BusyMsg(Strings.Format((object) num3, "###,##0") + " records parsed.");
            Application.DoEvents();
            num6 = 0;
          }
          ++index1;
          this._importBuffer.Add(new EffectData(iString));
          ++num3;
          if (!this._importBuffer[index1].IsValid)
          {
            ++num4;
          }
          else
          {
            ++num1;
            EffectData effectData = this._importBuffer[index1];
            if (num7 != effectData.Index)
            {
              num7 = effectData.Index;
              num8 = 0;
              num5 = 0;
            }
            else
              ++num8;
            effectData.Data.nID = num8;
            effectData.Nid = num8;
            if (effectData.Data.nID > DatabaseAPI.Database.Power[effectData.Index].Effects.Length - 1)
            {
              effectData.IsNew = true;
            }
            else
            {
              int index2 = effectData.Nid - num5;
              if (effectData.CheckSimilar(ref DatabaseAPI.Database.Power[effectData.Index].Effects[index2]))
              {
                effectData.Nid = index2;
                effectData.Data.nID = index2;
                effectData.IsNew = false;
                if (num5 > 0)
                  effectData.IndexChanged = true;
              }
              else
              {
                effectData.IsNew = true;
                int num2 = DatabaseAPI.Database.Power[effectData.Index].Effects.Length - 1;
                for (int index3 = 0; index3 <= num2; ++index3)
                {
                  bool flag = false;
                  if (index3 <= effectData.Nid && this._importBuffer[index1 - effectData.Nid + index3].Nid == index3)
                    flag = true;
                  if (!flag)
                  {
                    int nid = effectData.Nid;
                    for (int index4 = 0; index4 <= nid; ++index4)
                    {
                      if (this._importBuffer[index1 - effectData.Nid + index4].Nid == index3)
                      {
                        flag = true;
                        break;
                      }
                    }
                  }
                  if (!flag && effectData.CheckSimilar(ref DatabaseAPI.Database.Power[effectData.Index].Effects[index3]))
                  {
                    effectData.Nid = index3;
                    effectData.Data.nID = index3;
                    effectData.IndexChanged = true;
                    effectData.IsNew = false;
                    break;
                  }
                }
              }
            }
            if (effectData.IsNew)
              ++num5;
          }
        }
      }
      while (iString != null);
      iStream.Close();
      int num9 = (int) Interaction.MsgBox((object) ("Parse Completed!\r\nTotal Records: " + Conversions.ToString(num3) + "\r\nGood: " + Conversions.ToString(num1) + "\r\nRejected: " + Conversions.ToString(num4)), MsgBoxStyle.Information, (object) "File Parsed");
      return true;
    }

    private bool ProcessImport()
    {
      bool flag = false;
      int num1 = 0;
      int num2 = 0;
      this.BusyMsg("Applying...");
      this.Enabled = false;
      int num3 = 0;
      int num4 = this.lstImport.Items.Count - 1;
      for (int index = 0; index <= num4; ++index)
      {
        if (this.lstImport.Items[index].Checked)
        {
          if (!this._importBuffer[Conversions.ToInteger(this.lstImport.Items[index].Tag)].Apply())
            ++num3;
          ++num1;
          ++num2;
          if (num2 >= 9)
          {
            this.BusyMsg("Applying: " + Conversions.ToString(index) + " records done.");
            Application.DoEvents();
            num2 = 0;
          }
        }
      }
      this.Enabled = true;
      this.BusyMsg("Saving...");
      DatabaseAPI.Database.PowerEffectVersion.SourceFile = this.dlgBrowse.FileName;
      DatabaseAPI.Database.PowerEffectVersion.RevisionDate = DateTime.Now;
      DatabaseAPI.Database.PowerEffectVersion.Revision = Convert.ToInt32(this.udRevision.Value);
      DatabaseAPI.MatchAllIDs((IMessager) null);
      DatabaseAPI.SaveMainDatabase();
      this.BusyHide();
      int num5 = (int) Interaction.MsgBox((object) ("Import of " + Conversions.ToString(num1) + " records completed!\r\nOf these, " + Conversions.ToString(num3) + " records were found read-only."), MsgBoxStyle.Information, (object) "Done");
      this.DisplayInfo();
      return flag;
    }
  }
}
