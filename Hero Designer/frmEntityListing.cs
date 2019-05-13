﻿// Decompiled with JetBrains decompiler
// Type: Hero_Designer.frmEntityListing
// Assembly: Hero Designer, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 971EB14D-7E2B-4ADC-89DF-A9C8225AA28C
// Assembly location: C:\Users\robin\Documents\Mids Hero-20190421T164236Z-001\Mids Hero\Hero Designer.exe

using Base.IO_Classes;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace Hero_Designer
{
  [DesignerGenerated]
  public class frmEntityListing : Form
  {
    [AccessedThroughProperty("btnAdd")]
    private Button _btnAdd;
    [AccessedThroughProperty("btnCancel")]
    private Button _btnCancel;
    [AccessedThroughProperty("btnClone")]
    private Button _btnClone;
    [AccessedThroughProperty("btnDelete")]
    private Button _btnDelete;
    [AccessedThroughProperty("btnDown")]
    private Button _btnDown;
    [AccessedThroughProperty("btnedit")]
    private Button _btnedit;
    [AccessedThroughProperty("btnOK")]
    private Button _btnOK;
    [AccessedThroughProperty("btnUp")]
    private Button _btnUp;
    [AccessedThroughProperty("ColumnHeader1")]
    private ColumnHeader _ColumnHeader1;
    [AccessedThroughProperty("ColumnHeader2")]
    private ColumnHeader _ColumnHeader2;
    [AccessedThroughProperty("ColumnHeader3")]
    private ColumnHeader _ColumnHeader3;
    [AccessedThroughProperty("lvEntity")]
    private ListView _lvEntity;
    private frmBusy bFrm;
    private IContainer components;

    internal virtual Button btnAdd
    {
      get
      {
        return this._btnAdd;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.btnAdd_Click);
        if (this._btnAdd != null)
          this._btnAdd.Click -= eventHandler;
        this._btnAdd = value;
        if (this._btnAdd == null)
          return;
        this._btnAdd.Click += eventHandler;
      }
    }

    internal virtual Button btnCancel
    {
      get
      {
        return this._btnCancel;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.btnCancel_Click);
        if (this._btnCancel != null)
          this._btnCancel.Click -= eventHandler;
        this._btnCancel = value;
        if (this._btnCancel == null)
          return;
        this._btnCancel.Click += eventHandler;
      }
    }

    internal virtual Button btnClone
    {
      get
      {
        return this._btnClone;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.btnClone_Click);
        if (this._btnClone != null)
          this._btnClone.Click -= eventHandler;
        this._btnClone = value;
        if (this._btnClone == null)
          return;
        this._btnClone.Click += eventHandler;
      }
    }

    internal virtual Button btnDelete
    {
      get
      {
        return this._btnDelete;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.btnDelete_Click);
        if (this._btnDelete != null)
          this._btnDelete.Click -= eventHandler;
        this._btnDelete = value;
        if (this._btnDelete == null)
          return;
        this._btnDelete.Click += eventHandler;
      }
    }

    internal virtual Button btnDown
    {
      get
      {
        return this._btnDown;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.btnDown_Click);
        if (this._btnDown != null)
          this._btnDown.Click -= eventHandler;
        this._btnDown = value;
        if (this._btnDown == null)
          return;
        this._btnDown.Click += eventHandler;
      }
    }

    internal virtual Button btnedit
    {
      get
      {
        return this._btnedit;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.btnEdit_Click);
        if (this._btnedit != null)
          this._btnedit.Click -= eventHandler;
        this._btnedit = value;
        if (this._btnedit == null)
          return;
        this._btnedit.Click += eventHandler;
      }
    }

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

    internal virtual Button btnUp
    {
      get
      {
        return this._btnUp;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.btnUp_Click);
        if (this._btnUp != null)
          this._btnUp.Click -= eventHandler;
        this._btnUp = value;
        if (this._btnUp == null)
          return;
        this._btnUp.Click += eventHandler;
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

    internal virtual ListView lvEntity
    {
      get
      {
        return this._lvEntity;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.lvEntity_DoubleClick);
        if (this._lvEntity != null)
          this._lvEntity.DoubleClick -= eventHandler;
        this._lvEntity = value;
        if (this._lvEntity == null)
          return;
        this._lvEntity.DoubleClick += eventHandler;
      }
    }

    public frmEntityListing()
    {
      this.Load += new EventHandler(this.frmEntityListing_Load);
      this.InitializeComponent();
    }

    private void btnAdd_Click(object sender, EventArgs e)
    {
      SummonedEntity iEntity = new SummonedEntity();
      int num1 = 0;
      bool flag;
      do
      {
        iEntity.UID = "NewEntity_" + Conversions.ToString(num1);
        flag = true;
        int num2 = DatabaseAPI.Database.Entities.Length - 1;
        for (int index = 0; index <= num2; ++index)
        {
          if (DatabaseAPI.Database.Entities[index].UID.ToLower() == iEntity.UID.ToLower())
            flag = false;
        }
        ++num1;
      }
      while (!flag);
      frmEntityEdit frmEntityEdit = new frmEntityEdit(iEntity);
      int num3 = (int) frmEntityEdit.ShowDialog();
      if (frmEntityEdit.DialogResult != DialogResult.OK)
        return;
      IDatabase database = DatabaseAPI.Database;
      SummonedEntity[] summonedEntityArray = (SummonedEntity[]) Utils.CopyArray((Array) database.Entities, (Array) new SummonedEntity[DatabaseAPI.Database.Entities.Length + 1]);
      database.Entities = summonedEntityArray;
      DatabaseAPI.Database.Entities[DatabaseAPI.Database.Entities.Length - 1] = new SummonedEntity(frmEntityEdit.myEntity);
      DatabaseAPI.Database.Entities[DatabaseAPI.Database.Entities.Length - 1].nID = DatabaseAPI.Database.Entities.Length - 1;
      this.ListAddItem(DatabaseAPI.Database.Entities.Length - 1);
    }

    private void btnCancel_Click(object sender, EventArgs e)
    {
      this.BusyMsg("Re-Indexing...");
      DatabaseAPI.LoadMainDatabase();
      DatabaseAPI.MatchAllIDs((IMessager) null);
      this.BusyHide();
      this.Hide();
    }

    private void btnClone_Click(object sender, EventArgs e)
    {
      if (this.lvEntity.SelectedIndices.Count <= 0)
        return;
      frmEntityEdit frmEntityEdit = new frmEntityEdit(new SummonedEntity(DatabaseAPI.Database.Entities[this.lvEntity.SelectedIndices[0]])
      {
        nID = DatabaseAPI.Database.Entities.Length
      });
      int num = (int) frmEntityEdit.ShowDialog();
      if (frmEntityEdit.DialogResult == DialogResult.OK)
      {
        IDatabase database = DatabaseAPI.Database;
        SummonedEntity[] summonedEntityArray = (SummonedEntity[]) Utils.CopyArray((Array) database.Entities, (Array) new SummonedEntity[DatabaseAPI.Database.Entities.Length + 1]);
        database.Entities = summonedEntityArray;
        DatabaseAPI.Database.Entities[DatabaseAPI.Database.Entities.Length - 1] = new SummonedEntity(frmEntityEdit.myEntity);
        this.ListAddItem(DatabaseAPI.Database.Entities.Length - 1);
      }
    }

    private void btnDelete_Click(object sender, EventArgs e)
    {
      if (this.lvEntity.SelectedIndices.Count <= 0 || Interaction.MsgBox((object) ("Really delete entity: " + DatabaseAPI.Database.Entities[this.lvEntity.SelectedIndices[0]].DisplayName + "?"), MsgBoxStyle.YesNo | MsgBoxStyle.Question, (object) "Are you sure?") != MsgBoxResult.Yes)
        return;
      SummonedEntity[] summonedEntityArray = new SummonedEntity[DatabaseAPI.Database.Entities.Length - 1 + 1];
      int selectedIndex = this.lvEntity.SelectedIndices[0];
      int index1 = 0;
      int num1 = DatabaseAPI.Database.Entities.Length - 1;
      for (int index2 = 0; index2 <= num1; ++index2)
      {
        if (index2 != selectedIndex)
        {
          summonedEntityArray[index1] = new SummonedEntity(DatabaseAPI.Database.Entities[index2]);
          ++index1;
        }
      }
      DatabaseAPI.Database.Entities = new SummonedEntity[DatabaseAPI.Database.Entities.Length - 2 + 1];
      int num2 = DatabaseAPI.Database.Entities.Length - 1;
      for (int index2 = 0; index2 <= num2; ++index2)
        DatabaseAPI.Database.Entities[index2] = new SummonedEntity(summonedEntityArray[index2]);
      this.DisplayList();
      if (this.lvEntity.Items.Count > 0)
      {
        if (this.lvEntity.Items.Count > selectedIndex)
          this.lvEntity.Items[selectedIndex].Selected = true;
        else if (this.lvEntity.Items.Count == selectedIndex)
          this.lvEntity.Items[selectedIndex - 1].Selected = true;
      }
    }

    private void btnDown_Click(object sender, EventArgs e)
    {
      if (this.lvEntity.SelectedIndices.Count <= 0)
        return;
      int selectedIndex = this.lvEntity.SelectedIndices[0];
      if (selectedIndex < this.lvEntity.Items.Count - 1)
      {
        SummonedEntity[] summonedEntityArray = new SummonedEntity[2]
        {
          new SummonedEntity(DatabaseAPI.Database.Entities[selectedIndex]),
          new SummonedEntity(DatabaseAPI.Database.Entities[selectedIndex + 1])
        };
        DatabaseAPI.Database.Entities[selectedIndex + 1] = new SummonedEntity(summonedEntityArray[0]);
        DatabaseAPI.Database.Entities[selectedIndex] = new SummonedEntity(summonedEntityArray[1]);
        this.DisplayList();
        this.lvEntity.Items[selectedIndex + 1].Selected = true;
        this.lvEntity.Items[selectedIndex + 1].EnsureVisible();
      }
    }

    private void btnEdit_Click(object sender, EventArgs e)
    {
      if (this.lvEntity.SelectedIndices.Count <= 0)
        return;
      int selectedIndex = this.lvEntity.SelectedIndices[0];
      frmEntityEdit frmEntityEdit = new frmEntityEdit(DatabaseAPI.Database.Entities[this.lvEntity.SelectedIndices[0]]);
      if (frmEntityEdit.ShowDialog() == DialogResult.OK)
      {
        DatabaseAPI.Database.Entities[selectedIndex] = new SummonedEntity(frmEntityEdit.myEntity);
        this.ListUpdateItem(selectedIndex);
      }
    }

    private void btnOK_Click(object sender, EventArgs e)
    {
      DatabaseAPI.MatchSummonIDs();
      DatabaseAPI.SaveMainDatabase();
      this.Hide();
    }

    private void btnUp_Click(object sender, EventArgs e)
    {
      if (this.lvEntity.SelectedIndices.Count <= 0)
        return;
      int selectedIndex = this.lvEntity.SelectedIndices[0];
      if (selectedIndex >= 1)
      {
        SummonedEntity[] summonedEntityArray = new SummonedEntity[2]
        {
          new SummonedEntity(DatabaseAPI.Database.Entities[selectedIndex]),
          new SummonedEntity(DatabaseAPI.Database.Entities[selectedIndex - 1])
        };
        DatabaseAPI.Database.Entities[selectedIndex - 1] = new SummonedEntity(summonedEntityArray[0]);
        DatabaseAPI.Database.Entities[selectedIndex] = new SummonedEntity(summonedEntityArray[1]);
        this.DisplayList();
        this.lvEntity.Items[selectedIndex - 1].Selected = true;
        this.lvEntity.Items[selectedIndex - 1].EnsureVisible();
      }
    }

    private void BusyHide()
    {
      if (this.bFrm == null)
        return;
      this.bFrm.Close();
      this.bFrm = (frmBusy) null;
    }

    private void BusyMsg(string sMessage)
    {
      if (this.bFrm == null)
      {
        this.bFrm = new frmBusy();
        this.bFrm.Show((IWin32Window) this);
      }
      this.bFrm.SetMessage(sMessage);
    }

    public void DisplayList()
    {
      this.lvEntity.BeginUpdate();
      this.lvEntity.Items.Clear();
      int num = DatabaseAPI.Database.Entities.Length - 1;
      for (int Index = 0; Index <= num; ++Index)
        this.ListAddItem(Index);
      if (this.lvEntity.Items.Count > 0)
      {
        this.lvEntity.Items[0].Selected = true;
        this.lvEntity.Items[0].EnsureVisible();
      }
      this.lvEntity.EndUpdate();
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

    private void frmEntityListing_Load(object sender, EventArgs e)
    {
      this.DisplayList();
    }

    [DebuggerStepThrough]
    private void InitializeComponent()
    {
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (frmEntityListing));
      this.lvEntity = new ListView();
      this.ColumnHeader1 = new ColumnHeader();
      this.ColumnHeader2 = new ColumnHeader();
      this.ColumnHeader3 = new ColumnHeader();
      this.btnUp = new Button();
      this.btnDown = new Button();
      this.btnAdd = new Button();
      this.btnDelete = new Button();
      this.btnedit = new Button();
      this.btnOK = new Button();
      this.btnCancel = new Button();
      this.btnClone = new Button();
      this.SuspendLayout();
      this.lvEntity.Columns.AddRange(new ColumnHeader[3]
      {
        this.ColumnHeader1,
        this.ColumnHeader2,
        this.ColumnHeader3
      });
      this.lvEntity.FullRowSelect = true;
      this.lvEntity.HeaderStyle = ColumnHeaderStyle.Nonclickable;
      this.lvEntity.HideSelection = false;
      Point point = new Point(12, 12);
      this.lvEntity.Location = point;
      this.lvEntity.MultiSelect = false;
      this.lvEntity.Name = "lvEntity";
      Size size = new Size(398, 431);
      this.lvEntity.Size = size;
      this.lvEntity.TabIndex = 0;
      this.lvEntity.UseCompatibleStateImageBehavior = false;
      this.lvEntity.View = View.Details;
      this.ColumnHeader1.Text = "Entity";
      this.ColumnHeader1.Width = 153;
      this.ColumnHeader2.Text = "Name";
      this.ColumnHeader2.Width = 120;
      this.ColumnHeader3.Text = "Type";
      this.ColumnHeader3.Width = 96;
      point = new Point(416, 12);
      this.btnUp.Location = point;
      this.btnUp.Name = "btnUp";
      size = new Size(75, 23);
      this.btnUp.Size = size;
      this.btnUp.TabIndex = 1;
      this.btnUp.Text = "Up";
      this.btnUp.UseVisualStyleBackColor = true;
      point = new Point(416, 41);
      this.btnDown.Location = point;
      this.btnDown.Name = "btnDown";
      size = new Size(75, 23);
      this.btnDown.Size = size;
      this.btnDown.TabIndex = 2;
      this.btnDown.Text = "Down";
      this.btnDown.UseVisualStyleBackColor = true;
      point = new Point(416, 100);
      this.btnAdd.Location = point;
      this.btnAdd.Name = "btnAdd";
      size = new Size(75, 23);
      this.btnAdd.Size = size;
      this.btnAdd.TabIndex = 3;
      this.btnAdd.Text = "Add";
      this.btnAdd.UseVisualStyleBackColor = true;
      point = new Point(416, 158);
      this.btnDelete.Location = point;
      this.btnDelete.Name = "btnDelete";
      size = new Size(75, 23);
      this.btnDelete.Size = size;
      this.btnDelete.TabIndex = 4;
      this.btnDelete.Text = "Remove";
      this.btnDelete.UseVisualStyleBackColor = true;
      point = new Point(416, 187);
      this.btnedit.Location = point;
      this.btnedit.Name = "btnedit";
      size = new Size(75, 23);
      this.btnedit.Size = size;
      this.btnedit.TabIndex = 5;
      this.btnedit.Text = "Edit";
      this.btnedit.UseVisualStyleBackColor = true;
      point = new Point(416, 391);
      this.btnOK.Location = point;
      this.btnOK.Name = "btnOK";
      size = new Size(75, 23);
      this.btnOK.Size = size;
      this.btnOK.TabIndex = 6;
      this.btnOK.Text = "OK";
      this.btnOK.UseVisualStyleBackColor = true;
      point = new Point(416, 420);
      this.btnCancel.Location = point;
      this.btnCancel.Name = "btnCancel";
      size = new Size(75, 23);
      this.btnCancel.Size = size;
      this.btnCancel.TabIndex = 7;
      this.btnCancel.Text = "Cancel";
      this.btnCancel.UseVisualStyleBackColor = true;
      point = new Point(416, 129);
      this.btnClone.Location = point;
      this.btnClone.Name = "btnClone";
      size = new Size(75, 23);
      this.btnClone.Size = size;
      this.btnClone.TabIndex = 8;
      this.btnClone.Text = "Clone";
      this.btnClone.UseVisualStyleBackColor = true;
      this.AutoScaleMode = AutoScaleMode.None;
      size = new Size(501, 454);
      this.ClientSize = size;
      this.Controls.Add((Control) this.btnClone);
      this.Controls.Add((Control) this.btnCancel);
      this.Controls.Add((Control) this.btnOK);
      this.Controls.Add((Control) this.btnedit);
      this.Controls.Add((Control) this.btnDelete);
      this.Controls.Add((Control) this.btnAdd);
      this.Controls.Add((Control) this.btnDown);
      this.Controls.Add((Control) this.btnUp);
      this.Controls.Add((Control) this.lvEntity);
      this.Font = new Font("Arial", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.FormBorderStyle = FormBorderStyle.FixedDialog;
      this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = nameof (frmEntityListing);
      this.ShowInTaskbar = false;
      this.StartPosition = FormStartPosition.CenterScreen;
      this.Text = "Entity Editor";
      this.ResumeLayout(false);
    }

    public void ListAddItem(int Index)
    {
      this.lvEntity.Items.Add(new ListViewItem(new string[3]
      {
        DatabaseAPI.Database.Entities[Index].UID,
        DatabaseAPI.Database.Entities[Index].DisplayName,
        Enum.GetName(DatabaseAPI.Database.Entities[Index].EntityType.GetType(), (object) DatabaseAPI.Database.Entities[Index].EntityType)
      }, Index));
      this.lvEntity.Items[this.lvEntity.Items.Count - 1].Selected = true;
      this.lvEntity.Items[this.lvEntity.Items.Count - 1].EnsureVisible();
    }

    public void ListUpdateItem(int Index)
    {
      string[] strArray = new string[3]
      {
        DatabaseAPI.Database.Entities[Index].UID,
        DatabaseAPI.Database.Entities[Index].DisplayName,
        Enum.GetName(DatabaseAPI.Database.Entities[Index].EntityType.GetType(), (object) DatabaseAPI.Database.Entities[Index].EntityType)
      };
      int num = strArray.Length - 1;
      for (int index = 0; index <= num; ++index)
        this.lvEntity.Items[Index].SubItems[index].Text = strArray[index];
      this.lvEntity.Items[Index].EnsureVisible();
      this.lvEntity.Refresh();
    }

    private void lvEntity_DoubleClick(object sender, EventArgs e)
    {
      this.btnEdit_Click(RuntimeHelpers.GetObjectValue(sender), e);
    }
  }
}
