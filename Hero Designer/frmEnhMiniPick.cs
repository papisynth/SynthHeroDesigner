﻿// Decompiled with JetBrains decompiler
// Type: Hero_Designer.frmEnhMiniPick
// Assembly: Hero Designer, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 971EB14D-7E2B-4ADC-89DF-A9C8225AA28C
// Assembly location: C:\Users\robin\Documents\Mids Hero-20190421T164236Z-001\Mids Hero\Hero Designer.exe

using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace Hero_Designer
{
  public class frmEnhMiniPick : Form
  {
    [AccessedThroughProperty("btnOK")]
    private Button _btnOK;
    [AccessedThroughProperty("lbList")]
    private ListBox _lbList;
    [AccessedThroughProperty("lblMessage")]
    private Label _lblMessage;
    private IContainer components;

    internal virtual Button btnOK
    {
      get
      {
        return this._btnOK;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.btnOK_Click);
        if (this._btnOK != null)
          this._btnOK.Click -= eventHandler;
        this._btnOK = value;
        if (this._btnOK == null)
          return;
        this._btnOK.Click += eventHandler;
      }
    }

    internal virtual ListBox lbList
    {
      get
      {
        return this._lbList;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler1 = new EventHandler(this.lbList_DoubleClick);
        EventHandler eventHandler2 = new EventHandler(this.lbList_SelectedIndexChanged);
        if (this._lbList != null)
        {
          this._lbList.DoubleClick -= eventHandler1;
          this._lbList.SelectedIndexChanged -= eventHandler2;
        }
        this._lbList = value;
        if (this._lbList == null)
          return;
        this._lbList.DoubleClick += eventHandler1;
        this._lbList.SelectedIndexChanged += eventHandler2;
      }
    }

    internal virtual Label lblMessage
    {
      get
      {
        return this._lblMessage;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._lblMessage = value;
      }
    }

    public frmEnhMiniPick()
    {
      this.Load += new EventHandler(this.frmEnhMez_Load);
      this.InitializeComponent();
    }

    private void btnOK_Click(object sender, EventArgs e)
    {
      this.DialogResult = DialogResult.OK;
      this.Hide();
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void frmEnhMez_Load(object sender, EventArgs e)
    {
    }

    [DebuggerStepThrough]
    private void InitializeComponent()
    {
      this.lbList = new ListBox();
      this.btnOK = new Button();
      this.lblMessage = new Label();
      this.SuspendLayout();
      Point point = new Point(4, 44);
      this.lbList.Location = point;
      this.lbList.Name = "lbList";
      Size size = new Size(172, 160);
      this.lbList.Size = size;
      this.lbList.TabIndex = 0;
      this.btnOK.DialogResult = DialogResult.OK;
      point = new Point(8, 212);
      this.btnOK.Location = point;
      this.btnOK.Name = "btnOK";
      size = new Size(168, 24);
      this.btnOK.Size = size;
      this.btnOK.TabIndex = 1;
      this.btnOK.Text = "OK";
      point = new Point(4, 0);
      this.lblMessage.Location = point;
      this.lblMessage.Name = "lblMessage";
      size = new Size(176, 40);
      this.lblMessage.Size = size;
      this.lblMessage.TabIndex = 2;
      this.lblMessage.Text = "Please select an item from the list below and click OK";
      this.lblMessage.TextAlign = ContentAlignment.MiddleCenter;
      this.AcceptButton = (IButtonControl) this.btnOK;
      size = new Size(5, 13);
      this.AutoScaleBaseSize = size;
      this.CancelButton = (IButtonControl) this.btnOK;
      size = new Size(182, 244);
      this.ClientSize = size;
      this.ControlBox = false;
      this.Controls.Add((Control) this.lblMessage);
      this.Controls.Add((Control) this.btnOK);
      this.Controls.Add((Control) this.lbList);
      this.FormBorderStyle = FormBorderStyle.FixedSingle;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = nameof (frmEnhMiniPick);
      this.ShowInTaskbar = false;
      this.StartPosition = FormStartPosition.CenterParent;
      this.Text = "Details";
      this.ResumeLayout(false);
    }

    private void lbList_DoubleClick(object sender, EventArgs e)
    {
      this.btnOK_Click(RuntimeHelpers.GetObjectValue(sender), e);
    }

    private void lbList_SelectedIndexChanged(object sender, EventArgs e)
    {
    }
  }
}
