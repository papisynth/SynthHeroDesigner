﻿// Decompiled with JetBrains decompiler
// Type: Hero_Designer.frmFloatingStats
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
  public class frmFloatingStats : Form
  {
    [AccessedThroughProperty("dvFloat")]
    private DataView _dvFloat;
    private IContainer components;
    protected frmMain myOwner;

    internal virtual DataView dvFloat
    {
      get
      {
        return this._dvFloat;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.dvFloat_Load);
        DataView.SizeChangeEventHandler changeEventHandler1 = new DataView.SizeChangeEventHandler(this.dvFloat_SizeChange);
        DataView.FloatChangeEventHandler changeEventHandler2 = new DataView.FloatChangeEventHandler(this.dvFloat_FloatChanged);
        DataView.Unlock_ClickEventHandler clickEventHandler = new DataView.Unlock_ClickEventHandler(this.dvFloat_Unlock);
        DataView.TabChangedEventHandler changedEventHandler = new DataView.TabChangedEventHandler(this.dvFloat_TabChanged);
        DataView.SlotUpdateEventHandler updateEventHandler = new DataView.SlotUpdateEventHandler(this.dvFloat_SlotUpdate);
        DataView.SlotFlipEventHandler flipEventHandler = new DataView.SlotFlipEventHandler(this.dvFloat_SlotFlip);
        if (this._dvFloat != null)
        {
          this._dvFloat.Load -= eventHandler;
          this._dvFloat.SizeChange -= changeEventHandler1;
          this._dvFloat.FloatChange -= changeEventHandler2;
          this._dvFloat.Unlock_Click -= clickEventHandler;
          this._dvFloat.TabChanged -= changedEventHandler;
          this._dvFloat.SlotUpdate -= updateEventHandler;
          this._dvFloat.SlotFlip -= flipEventHandler;
        }
        this._dvFloat = value;
        if (this._dvFloat == null)
          return;
        this._dvFloat.Load += eventHandler;
        this._dvFloat.SizeChange += changeEventHandler1;
        this._dvFloat.FloatChange += changeEventHandler2;
        this._dvFloat.Unlock_Click += clickEventHandler;
        this._dvFloat.TabChanged += changedEventHandler;
        this._dvFloat.SlotUpdate += updateEventHandler;
        this._dvFloat.SlotFlip += flipEventHandler;
      }
    }

    public frmFloatingStats(ref frmMain iOwner)
    {
      this.Load += new EventHandler(this.frmFloatingStats_Load);
      this.Closed += new EventHandler(this.frmFloatingStats_Closed);
      this.InitializeComponent();
      this.myOwner = iOwner;
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void dvFloat_FloatChanged()
    {
      this.Close();
    }

    private void dvFloat_Load(object sender, EventArgs e)
    {
    }

    private void dvFloat_SizeChange(Size newSize, bool Compact)
    {
      this.ClientSize = newSize;
    }

    private void dvFloat_SlotFlip(int PowerIndex)
    {
      this.myOwner.DataView_SlotFlip(PowerIndex);
    }

    private void dvFloat_SlotUpdate()
    {
      this.myOwner.DataView_SlotUpdate();
    }

    private void dvFloat_TabChanged(int Index)
    {
      this.myOwner.SetDataViewTab(Index);
    }

    private void dvFloat_Unlock()
    {
      this.myOwner.DataViewLocked = false;
      if (this.myOwner.dvLastPower <= -1)
        return;
      this.myOwner.Info_Power(this.myOwner.dvLastPower, this.myOwner.dvLastEnh, this.myOwner.dvLastNoLev, this.myOwner.DataViewLocked);
    }

    private void frmFloatingStats_Closed(object sender, EventArgs e)
    {
      this.myOwner.ShowAnchoredDataView();
      this.Hide();
    }

    private void frmFloatingStats_Load(object sender, EventArgs e)
    {
      this.dvFloat.MoveDisable = true;
      this.dvFloat.SetScreenBounds(this.dvFloat.Bounds);
      this.dvFloat.SetLocation(this.dvFloat.Location, true);
    }

    [DebuggerStepThrough]
    private void InitializeComponent()
    {
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (frmFloatingStats));
      this.dvFloat = new DataView();
      this.SuspendLayout();
      this.dvFloat.BackColor = Color.FromArgb(64, 64, 64);
      this.dvFloat.DrawVillain = false;
      this.dvFloat.Floating = true;
      this.dvFloat.Font = new Font("Arial", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.dvFloat.Location = new Point(0, 0);
      this.dvFloat.Name = "dvFloat";
      Size size = new Size(300, 348);
      this.dvFloat.Size = size;
      this.dvFloat.TabIndex = 0;
      this.dvFloat.VisibleSize = Enums.eVisibleSize.Full;
      this.AutoScaleMode = AutoScaleMode.None;
      this.BackColor = Color.FromArgb(64, 64, 64);
      size = new Size(298, 348);
      this.ClientSize = size;
      this.Controls.Add((Control) this.dvFloat);
      this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
      this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = nameof (frmFloatingStats);
      this.ShowInTaskbar = false;
      this.StartPosition = FormStartPosition.Manual;
      this.Text = "Info";
      this.TopMost = true;
      this.ResumeLayout(false);
    }
  }
}
