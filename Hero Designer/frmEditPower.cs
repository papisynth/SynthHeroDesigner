﻿// Decompiled with JetBrains decompiler
// Type: Hero_Designer.frmEditPower
// Assembly: Hero Designer, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 971EB14D-7E2B-4ADC-89DF-A9C8225AA28C
// Assembly location: C:\Users\robin\Documents\Mids Hero-20190421T164236Z-001\Mids Hero\Hero Designer.exe

using Base.Data_Classes;
using Base.Display;
using Base.Master_Classes;
using Import;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace Hero_Designer
{
  public class frmEditPower : Form
  {
    [AccessedThroughProperty("btnCancel")]
    private Button _btnCancel;
    [AccessedThroughProperty("btnCSVImport")]
    private Button _btnCSVImport;
    [AccessedThroughProperty("btnFullCopy")]
    private Button _btnFullCopy;
    [AccessedThroughProperty("btnFullPaste")]
    private Button _btnFullPaste;
    [AccessedThroughProperty("btnFXAdd")]
    private Button _btnFXAdd;
    [AccessedThroughProperty("btnFXDown")]
    private Button _btnFXDown;
    [AccessedThroughProperty("btnFXDuplicate")]
    private Button _btnFXDuplicate;
    [AccessedThroughProperty("btnFXEdit")]
    private Button _btnFXEdit;
    [AccessedThroughProperty("btnFXRemove")]
    private Button _btnFXRemove;
    [AccessedThroughProperty("btnFXUp")]
    private Button _btnFXUp;
    [AccessedThroughProperty("btnMutexAdd")]
    private Button _btnMutexAdd;
    [AccessedThroughProperty("btnOK")]
    private Button _btnOK;
    [AccessedThroughProperty("btnPrDown")]
    private Button _btnPrDown;
    [AccessedThroughProperty("btnPrReset")]
    private Button _btnPrReset;
    [AccessedThroughProperty("btnPrSetNone")]
    private Button _btnPrSetNone;
    [AccessedThroughProperty("btnPrUp")]
    private Button _btnPrUp;
    [AccessedThroughProperty("btnSetDamage")]
    private Button _btnSetDamage;
    [AccessedThroughProperty("btnSPAdd")]
    private Button _btnSPAdd;
    [AccessedThroughProperty("btnSPRemove")]
    private Button _btnSPRemove;
    [AccessedThroughProperty("cbEffectArea")]
    private ComboBox _cbEffectArea;
    [AccessedThroughProperty("cbForcedClass")]
    private ComboBox _cbForcedClass;
    [AccessedThroughProperty("cbNameGroup")]
    private ComboBox _cbNameGroup;
    [AccessedThroughProperty("cbNameSet")]
    private ComboBox _cbNameSet;
    [AccessedThroughProperty("cbNotify")]
    private ComboBox _cbNotify;
    [AccessedThroughProperty("cbPowerType")]
    private ComboBox _cbPowerType;
    [AccessedThroughProperty("chkAltSub")]
    private CheckBox _chkAltSub;
    [AccessedThroughProperty("chkAlwaysToggle")]
    private CheckBox _chkAlwaysToggle;
    [AccessedThroughProperty("chkBoostBoostable")]
    private CheckBox _chkBoostBoostable;
    [AccessedThroughProperty("chkBoostUsePlayerLevel")]
    private CheckBox _chkBoostUsePlayerLevel;
    [AccessedThroughProperty("chkBuffCycle")]
    private CheckBox _chkBuffCycle;
    [AccessedThroughProperty("chkGraphFix")]
    private CheckBox _chkGraphFix;
    [AccessedThroughProperty("chkHidden")]
    private CheckBox _chkHidden;
    [AccessedThroughProperty("chkIgnoreStrength")]
    private CheckBox _chkIgnoreStrength;
    [AccessedThroughProperty("chkLos")]
    private CheckBox _chkLos;
    [AccessedThroughProperty("chkMutexAuto")]
    private CheckBox _chkMutexAuto;
    [AccessedThroughProperty("chkMutexSkip")]
    private CheckBox _chkMutexSkip;
    [AccessedThroughProperty("chkNoAUReq")]
    private CheckBox _chkNoAUReq;
    [AccessedThroughProperty("chkNoAutoUpdate")]
    private CheckBox _chkNoAutoUpdate;
    [AccessedThroughProperty("chkPRFrontLoad")]
    private CheckBox _chkPRFrontLoad;
    [AccessedThroughProperty("chkScale")]
    private CheckBox _chkScale;
    [AccessedThroughProperty("chkSortOverride")]
    private CheckBox _chkSortOverride;
    [AccessedThroughProperty("chkSubInclude")]
    private CheckBox _chkSubInclude;
    [AccessedThroughProperty("chkSummonDisplayEntity")]
    private CheckBox _chkSummonDisplayEntity;
    [AccessedThroughProperty("chkSummonStealAttributes")]
    private CheckBox _chkSummonStealAttributes;
    [AccessedThroughProperty("chkSummonStealEffects")]
    private CheckBox _chkSummonStealEffects;
    [AccessedThroughProperty("clbClassExclude")]
    private CheckedListBox _clbClassExclude;
    [AccessedThroughProperty("clbClassReq")]
    private CheckedListBox _clbClassReq;
    [AccessedThroughProperty("clbFlags")]
    private CheckedListBox _clbFlags;
    [AccessedThroughProperty("clbMutex")]
    private CheckedListBox _clbMutex;
    [AccessedThroughProperty("ColumnHeader1")]
    private ColumnHeader _ColumnHeader1;
    [AccessedThroughProperty("ColumnHeader10")]
    private ColumnHeader _ColumnHeader10;
    [AccessedThroughProperty("ColumnHeader11")]
    private ColumnHeader _ColumnHeader11;
    [AccessedThroughProperty("ColumnHeader2")]
    private ColumnHeader _ColumnHeader2;
    [AccessedThroughProperty("ColumnHeader3")]
    private ColumnHeader _ColumnHeader3;
    [AccessedThroughProperty("ColumnHeader4")]
    private ColumnHeader _ColumnHeader4;
    [AccessedThroughProperty("ColumnHeader6")]
    private ColumnHeader _ColumnHeader6;
    [AccessedThroughProperty("ColumnHeader7")]
    private ColumnHeader _ColumnHeader7;
    [AccessedThroughProperty("ColumnHeader8")]
    private ColumnHeader _ColumnHeader8;
    [AccessedThroughProperty("ColumnHeader9")]
    private ColumnHeader _ColumnHeader9;
    [AccessedThroughProperty("GroupBox1")]
    private GroupBox _GroupBox1;
    [AccessedThroughProperty("GroupBox10")]
    private GroupBox _GroupBox10;
    [AccessedThroughProperty("GroupBox11")]
    private GroupBox _GroupBox11;
    [AccessedThroughProperty("GroupBox2")]
    private GroupBox _GroupBox2;
    [AccessedThroughProperty("GroupBox3")]
    private GroupBox _GroupBox3;
    [AccessedThroughProperty("GroupBox4")]
    private GroupBox _GroupBox4;
    [AccessedThroughProperty("GroupBox5")]
    private GroupBox _GroupBox5;
    [AccessedThroughProperty("GroupBox6")]
    private GroupBox _GroupBox6;
    [AccessedThroughProperty("GroupBox7")]
    private GroupBox _GroupBox7;
    [AccessedThroughProperty("GroupBox8")]
    private GroupBox _GroupBox8;
    [AccessedThroughProperty("GroupBox9")]
    private GroupBox _GroupBox9;
    [AccessedThroughProperty("Label1")]
    private Label _Label1;
    [AccessedThroughProperty("Label10")]
    private Label _Label10;
    [AccessedThroughProperty("Label11")]
    private Label _Label11;
    [AccessedThroughProperty("Label12")]
    private Label _Label12;
    [AccessedThroughProperty("Label13")]
    private Label _Label13;
    [AccessedThroughProperty("Label14")]
    private Label _Label14;
    [AccessedThroughProperty("Label15")]
    private Label _Label15;
    [AccessedThroughProperty("Label16")]
    private Label _Label16;
    [AccessedThroughProperty("Label17")]
    private Label _Label17;
    [AccessedThroughProperty("Label18")]
    private Label _Label18;
    [AccessedThroughProperty("Label2")]
    private Label _Label2;
    [AccessedThroughProperty("Label20")]
    private Label _Label20;
    [AccessedThroughProperty("Label21")]
    private Label _Label21;
    [AccessedThroughProperty("Label22")]
    private Label _Label22;
    [AccessedThroughProperty("Label23")]
    private Label _Label23;
    [AccessedThroughProperty("Label24")]
    private Label _Label24;
    [AccessedThroughProperty("Label26")]
    private Label _Label26;
    [AccessedThroughProperty("Label27")]
    private Label _Label27;
    [AccessedThroughProperty("Label28")]
    private Label _Label28;
    [AccessedThroughProperty("Label29")]
    private Label _Label29;
    [AccessedThroughProperty("Label3")]
    private Label _Label3;
    [AccessedThroughProperty("Label30")]
    private Label _Label30;
    [AccessedThroughProperty("Label31")]
    private Label _Label31;
    [AccessedThroughProperty("Label32")]
    private Label _Label32;
    [AccessedThroughProperty("Label33")]
    private Label _Label33;
    [AccessedThroughProperty("Label34")]
    private Label _Label34;
    [AccessedThroughProperty("Label35")]
    private Label _Label35;
    [AccessedThroughProperty("Label36")]
    private Label _Label36;
    [AccessedThroughProperty("Label37")]
    private Label _Label37;
    [AccessedThroughProperty("Label38")]
    private Label _Label38;
    [AccessedThroughProperty("Label39")]
    private Label _Label39;
    [AccessedThroughProperty("Label4")]
    private Label _Label4;
    [AccessedThroughProperty("Label40")]
    private Label _Label40;
    [AccessedThroughProperty("Label41")]
    private Label _Label41;
    [AccessedThroughProperty("Label42")]
    private Label _Label42;
    [AccessedThroughProperty("Label43")]
    private Label _Label43;
    [AccessedThroughProperty("Label44")]
    private Label _Label44;
    [AccessedThroughProperty("Label45")]
    private Label _Label45;
    [AccessedThroughProperty("Label46")]
    private Label _Label46;
    [AccessedThroughProperty("Label47")]
    private Label _Label47;
    [AccessedThroughProperty("Label5")]
    private Label _Label5;
    [AccessedThroughProperty("Label6")]
    private Label _Label6;
    [AccessedThroughProperty("Label7")]
    private Label _Label7;
    [AccessedThroughProperty("Label8")]
    private Label _Label8;
    [AccessedThroughProperty("Label9")]
    private Label _Label9;
    [AccessedThroughProperty("lblAcc")]
    private Label _lblAcc;
    [AccessedThroughProperty("lblEndCost")]
    private Label _lblEndCost;
    [AccessedThroughProperty("lblEnhName")]
    private Label _lblEnhName;
    [AccessedThroughProperty("lblInvSet")]
    private Label _lblInvSet;
    [AccessedThroughProperty("lblNameFull")]
    private Label _lblNameFull;
    [AccessedThroughProperty("lblNameUnique")]
    private Label _lblNameUnique;
    [AccessedThroughProperty("lblStaticIndex")]
    private Label _lblStaticIndex;
    [AccessedThroughProperty("lvDisablePass1")]
    private ListBox _lvDisablePass1;
    [AccessedThroughProperty("lvDisablePass4")]
    private ListBox _lvDisablePass4;
    [AccessedThroughProperty("lvFX")]
    private ListBox _lvFX;
    [AccessedThroughProperty("lvPrGroup")]
    private ListView _lvPrGroup;
    [AccessedThroughProperty("lvPrListing")]
    private ListView _lvPrListing;
    [AccessedThroughProperty("lvPrPower")]
    private ListView _lvPrPower;
    [AccessedThroughProperty("lvPrSet")]
    private ListView _lvPrSet;
    [AccessedThroughProperty("lvSPGroup")]
    private ListView _lvSPGroup;
    [AccessedThroughProperty("lvSPPower")]
    private ListView _lvSPPower;
    [AccessedThroughProperty("lvSPSelected")]
    private ListView _lvSPSelected;
    [AccessedThroughProperty("lvSPSet")]
    private ListView _lvSPSet;
    [AccessedThroughProperty("pbEnhancementList")]
    private PictureBox _pbEnhancementList;
    [AccessedThroughProperty("pbEnhancements")]
    private PictureBox _pbEnhancements;
    [AccessedThroughProperty("pbInvSetList")]
    private PictureBox _pbInvSetList;
    [AccessedThroughProperty("pbInvSetUsed")]
    private PictureBox _pbInvSetUsed;
    [AccessedThroughProperty("pnlFX")]
    private Panel _pnlFX;
    [AccessedThroughProperty("rbFlagAffected")]
    private RadioButton _rbFlagAffected;
    [AccessedThroughProperty("rbFlagAutoHit")]
    private RadioButton _rbFlagAutoHit;
    [AccessedThroughProperty("rbFlagCast")]
    private RadioButton _rbFlagCast;
    [AccessedThroughProperty("rbFlagCastThrough")]
    private RadioButton _rbFlagCastThrough;
    [AccessedThroughProperty("rbFlagDisallow")]
    private RadioButton _rbFlagDisallow;
    [AccessedThroughProperty("rbFlagRequired")]
    private RadioButton _rbFlagRequired;
    [AccessedThroughProperty("rbFlagTargets")]
    private RadioButton _rbFlagTargets;
    [AccessedThroughProperty("rbFlagTargetsSec")]
    private RadioButton _rbFlagTargetsSec;
    [AccessedThroughProperty("rbFlagVector")]
    private RadioButton _rbFlagVector;
    [AccessedThroughProperty("rbPrAdd")]
    private Button _rbPrAdd;
    [AccessedThroughProperty("rbPrPowerA")]
    private RadioButton _rbPrPowerA;
    [AccessedThroughProperty("rbPrPowerB")]
    private RadioButton _rbPrPowerB;
    [AccessedThroughProperty("rbPrRemove")]
    private Button _rbPrRemove;
    [AccessedThroughProperty("tcPower")]
    private TabControl _tcPower;
    [AccessedThroughProperty("tpBasic")]
    private TabPage _tpBasic;
    [AccessedThroughProperty("tpEffects")]
    private TabPage _tpEffects;
    [AccessedThroughProperty("tpEnh")]
    private TabPage _tpEnh;
    [AccessedThroughProperty("tpMutex")]
    private TabPage _tpMutex;
    [AccessedThroughProperty("tpPreReq")]
    private TabPage _tpPreReq;
    [AccessedThroughProperty("tpSets")]
    private TabPage _tpSets;
    [AccessedThroughProperty("tpSpecialEnh")]
    private TabPage _tpSpecialEnh;
    [AccessedThroughProperty("tpSubPower")]
    private TabPage _tpSubPower;
    [AccessedThroughProperty("tpText")]
    private TabPage _tpText;
    [AccessedThroughProperty("txtAcc")]
    private TextBox _txtAcc;
    [AccessedThroughProperty("txtActivate")]
    private TextBox _txtActivate;
    [AccessedThroughProperty("txtArc")]
    private TextBox _txtArc;
    [AccessedThroughProperty("txtCastTime")]
    private TextBox _txtCastTime;
    [AccessedThroughProperty("txtDescLong")]
    private TextBox _txtDescLong;
    [AccessedThroughProperty("txtDescShort")]
    private TextBox _txtDescShort;
    [AccessedThroughProperty("txtEndCost")]
    private TextBox _txtEndCost;
    [AccessedThroughProperty("txtInterrupt")]
    private TextBox _txtInterrupt;
    [AccessedThroughProperty("txtLevel")]
    private TextBox _txtLevel;
    [AccessedThroughProperty("txtLifeTimeGame")]
    private TextBox _txtLifeTimeGame;
    [AccessedThroughProperty("txtLifeTimeReal")]
    private TextBox _txtLifeTimeReal;
    [AccessedThroughProperty("txtMaxTargets")]
    private TextBox _txtMaxTargets;
    [AccessedThroughProperty("txtNameDisplay")]
    private TextBox _txtNameDisplay;
    [AccessedThroughProperty("txtNamePower")]
    private TextBox _txtNamePower;
    [AccessedThroughProperty("txtNumCharges")]
    private TextBox _txtNumCharges;
    [AccessedThroughProperty("txtRadius")]
    private TextBox _txtRadius;
    [AccessedThroughProperty("txtRange")]
    private TextBox _txtRange;
    [AccessedThroughProperty("txtRangeSec")]
    private TextBox _txtRangeSec;
    [AccessedThroughProperty("txtRechargeTime")]
    private TextBox _txtRechargeTime;
    [AccessedThroughProperty("txtScaleName")]
    private TextBox _txtScaleName;
    [AccessedThroughProperty("txtUseageTime")]
    private TextBox _txtUseageTime;
    [AccessedThroughProperty("txtVisualLocation")]
    private TextBox _txtVisualLocation;
    [AccessedThroughProperty("udScaleMax")]
    private NumericUpDown _udScaleMax;
    [AccessedThroughProperty("udScaleMin")]
    private NumericUpDown _udScaleMin;
    protected Requirement backup_Requires;
    private ExtendedBitmap bxEnhPicked;
    private ExtendedBitmap bxEnhPicker;
    protected ExtendedBitmap bxSet;
    protected ExtendedBitmap bxSetList;
    private IContainer components;
    protected int enhAcross;
    protected int enhPadding;
    public IPower myPower;
    protected bool ReqChanging;
    protected bool Updating;

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

    internal virtual Button btnCSVImport
    {
      get
      {
        return this._btnCSVImport;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.btnCSVImport_Click);
        if (this._btnCSVImport != null)
          this._btnCSVImport.Click -= eventHandler;
        this._btnCSVImport = value;
        if (this._btnCSVImport == null)
          return;
        this._btnCSVImport.Click += eventHandler;
      }
    }

    internal virtual Button btnFullCopy
    {
      get
      {
        return this._btnFullCopy;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.btnFullCopy_Click);
        if (this._btnFullCopy != null)
          this._btnFullCopy.Click -= eventHandler;
        this._btnFullCopy = value;
        if (this._btnFullCopy == null)
          return;
        this._btnFullCopy.Click += eventHandler;
      }
    }

    internal virtual Button btnFullPaste
    {
      get
      {
        return this._btnFullPaste;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.btnFullPaste_Click);
        if (this._btnFullPaste != null)
          this._btnFullPaste.Click -= eventHandler;
        this._btnFullPaste = value;
        if (this._btnFullPaste == null)
          return;
        this._btnFullPaste.Click += eventHandler;
      }
    }

    internal virtual Button btnFXAdd
    {
      get
      {
        return this._btnFXAdd;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.btnFXAdd_Click);
        if (this._btnFXAdd != null)
          this._btnFXAdd.Click -= eventHandler;
        this._btnFXAdd = value;
        if (this._btnFXAdd == null)
          return;
        this._btnFXAdd.Click += eventHandler;
      }
    }

    internal virtual Button btnFXDown
    {
      get
      {
        return this._btnFXDown;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.btnFXDown_Click);
        if (this._btnFXDown != null)
          this._btnFXDown.Click -= eventHandler;
        this._btnFXDown = value;
        if (this._btnFXDown == null)
          return;
        this._btnFXDown.Click += eventHandler;
      }
    }

    internal virtual Button btnFXDuplicate
    {
      get
      {
        return this._btnFXDuplicate;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.btnFXDuplicate_Click);
        if (this._btnFXDuplicate != null)
          this._btnFXDuplicate.Click -= eventHandler;
        this._btnFXDuplicate = value;
        if (this._btnFXDuplicate == null)
          return;
        this._btnFXDuplicate.Click += eventHandler;
      }
    }

    internal virtual Button btnFXEdit
    {
      get
      {
        return this._btnFXEdit;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.btnFXEdit_Click);
        if (this._btnFXEdit != null)
          this._btnFXEdit.Click -= eventHandler;
        this._btnFXEdit = value;
        if (this._btnFXEdit == null)
          return;
        this._btnFXEdit.Click += eventHandler;
      }
    }

    internal virtual Button btnFXRemove
    {
      get
      {
        return this._btnFXRemove;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.btnFXRemove_Click);
        if (this._btnFXRemove != null)
          this._btnFXRemove.Click -= eventHandler;
        this._btnFXRemove = value;
        if (this._btnFXRemove == null)
          return;
        this._btnFXRemove.Click += eventHandler;
      }
    }

    internal virtual Button btnFXUp
    {
      get
      {
        return this._btnFXUp;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.btnFXUp_Click);
        if (this._btnFXUp != null)
          this._btnFXUp.Click -= eventHandler;
        this._btnFXUp = value;
        if (this._btnFXUp == null)
          return;
        this._btnFXUp.Click += eventHandler;
      }
    }

    internal virtual Button btnMutexAdd
    {
      get
      {
        return this._btnMutexAdd;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.btnMutexAdd_Click);
        if (this._btnMutexAdd != null)
          this._btnMutexAdd.Click -= eventHandler;
        this._btnMutexAdd = value;
        if (this._btnMutexAdd == null)
          return;
        this._btnMutexAdd.Click += eventHandler;
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

    internal virtual Button btnPrDown
    {
      get
      {
        return this._btnPrDown;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.btnPrDown_Click);
        if (this._btnPrDown != null)
          this._btnPrDown.Click -= eventHandler;
        this._btnPrDown = value;
        if (this._btnPrDown == null)
          return;
        this._btnPrDown.Click += eventHandler;
      }
    }

    internal virtual Button btnPrReset
    {
      get
      {
        return this._btnPrReset;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.btnPrReset_Click);
        if (this._btnPrReset != null)
          this._btnPrReset.Click -= eventHandler;
        this._btnPrReset = value;
        if (this._btnPrReset == null)
          return;
        this._btnPrReset.Click += eventHandler;
      }
    }

    internal virtual Button btnPrSetNone
    {
      get
      {
        return this._btnPrSetNone;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.btnPrSetNone_Click);
        if (this._btnPrSetNone != null)
          this._btnPrSetNone.Click -= eventHandler;
        this._btnPrSetNone = value;
        if (this._btnPrSetNone == null)
          return;
        this._btnPrSetNone.Click += eventHandler;
      }
    }

    internal virtual Button btnPrUp
    {
      get
      {
        return this._btnPrUp;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.btnPrUp_Click);
        if (this._btnPrUp != null)
          this._btnPrUp.Click -= eventHandler;
        this._btnPrUp = value;
        if (this._btnPrUp == null)
          return;
        this._btnPrUp.Click += eventHandler;
      }
    }

    internal virtual Button btnSetDamage
    {
      get
      {
        return this._btnSetDamage;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._btnSetDamage = value;
      }
    }

    internal virtual Button btnSPAdd
    {
      get
      {
        return this._btnSPAdd;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.btnSPAdd_Click);
        if (this._btnSPAdd != null)
          this._btnSPAdd.Click -= eventHandler;
        this._btnSPAdd = value;
        if (this._btnSPAdd == null)
          return;
        this._btnSPAdd.Click += eventHandler;
      }
    }

    internal virtual Button btnSPRemove
    {
      get
      {
        return this._btnSPRemove;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.btnSPRemove_Click);
        if (this._btnSPRemove != null)
          this._btnSPRemove.Click -= eventHandler;
        this._btnSPRemove = value;
        if (this._btnSPRemove == null)
          return;
        this._btnSPRemove.Click += eventHandler;
      }
    }

    internal virtual ComboBox cbEffectArea
    {
      get
      {
        return this._cbEffectArea;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.cbEffectArea_SelectedIndexChanged);
        if (this._cbEffectArea != null)
          this._cbEffectArea.SelectedIndexChanged -= eventHandler;
        this._cbEffectArea = value;
        if (this._cbEffectArea == null)
          return;
        this._cbEffectArea.SelectedIndexChanged += eventHandler;
      }
    }

    internal virtual ComboBox cbForcedClass
    {
      get
      {
        return this._cbForcedClass;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.cbForcedClass_SelectedIndexChanged);
        if (this._cbForcedClass != null)
          this._cbForcedClass.SelectedIndexChanged -= eventHandler;
        this._cbForcedClass = value;
        if (this._cbForcedClass == null)
          return;
        this._cbForcedClass.SelectedIndexChanged += eventHandler;
      }
    }

    internal virtual ComboBox cbNameGroup
    {
      get
      {
        return this._cbNameGroup;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler1 = new EventHandler(this.cbNameGroup_TextChanged);
        EventHandler eventHandler2 = new EventHandler(this.cbNameGroup_SelectedIndexChanged);
        EventHandler eventHandler3 = new EventHandler(this.cbNameGroup_Leave);
        if (this._cbNameGroup != null)
        {
          this._cbNameGroup.TextChanged -= eventHandler1;
          this._cbNameGroup.SelectedIndexChanged -= eventHandler2;
          this._cbNameGroup.Leave -= eventHandler3;
        }
        this._cbNameGroup = value;
        if (this._cbNameGroup == null)
          return;
        this._cbNameGroup.TextChanged += eventHandler1;
        this._cbNameGroup.SelectedIndexChanged += eventHandler2;
        this._cbNameGroup.Leave += eventHandler3;
      }
    }

    internal virtual ComboBox cbNameSet
    {
      get
      {
        return this._cbNameSet;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler1 = new EventHandler(this.cbNameSet_TextChanged);
        EventHandler eventHandler2 = new EventHandler(this.cbNameSet_SelectedIndexChanged);
        EventHandler eventHandler3 = new EventHandler(this.cbNameSet_Leave);
        if (this._cbNameSet != null)
        {
          this._cbNameSet.TextChanged -= eventHandler1;
          this._cbNameSet.SelectedIndexChanged -= eventHandler2;
          this._cbNameSet.Leave -= eventHandler3;
        }
        this._cbNameSet = value;
        if (this._cbNameSet == null)
          return;
        this._cbNameSet.TextChanged += eventHandler1;
        this._cbNameSet.SelectedIndexChanged += eventHandler2;
        this._cbNameSet.Leave += eventHandler3;
      }
    }

    internal virtual ComboBox cbNotify
    {
      get
      {
        return this._cbNotify;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.cbNotify_SelectedIndexChanged);
        if (this._cbNotify != null)
          this._cbNotify.SelectedIndexChanged -= eventHandler;
        this._cbNotify = value;
        if (this._cbNotify == null)
          return;
        this._cbNotify.SelectedIndexChanged += eventHandler;
      }
    }

    internal virtual ComboBox cbPowerType
    {
      get
      {
        return this._cbPowerType;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.cbPowerType_SelectedIndexChanged);
        if (this._cbPowerType != null)
          this._cbPowerType.SelectedIndexChanged -= eventHandler;
        this._cbPowerType = value;
        if (this._cbPowerType == null)
          return;
        this._cbPowerType.SelectedIndexChanged += eventHandler;
      }
    }

    internal virtual CheckBox chkAltSub
    {
      get
      {
        return this._chkAltSub;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.chkAltSub_CheckedChanged);
        if (this._chkAltSub != null)
          this._chkAltSub.CheckedChanged -= eventHandler;
        this._chkAltSub = value;
        if (this._chkAltSub == null)
          return;
        this._chkAltSub.CheckedChanged += eventHandler;
      }
    }

    internal virtual CheckBox chkAlwaysToggle
    {
      get
      {
        return this._chkAlwaysToggle;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.chkAlwaysToggle_CheckedChanged);
        if (this._chkAlwaysToggle != null)
          this._chkAlwaysToggle.CheckedChanged -= eventHandler;
        this._chkAlwaysToggle = value;
        if (this._chkAlwaysToggle == null)
          return;
        this._chkAlwaysToggle.CheckedChanged += eventHandler;
      }
    }

    internal virtual CheckBox chkBoostBoostable
    {
      get
      {
        return this._chkBoostBoostable;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.chkBoostBoostable_CheckedChanged);
        if (this._chkBoostBoostable != null)
          this._chkBoostBoostable.CheckedChanged -= eventHandler;
        this._chkBoostBoostable = value;
        if (this._chkBoostBoostable == null)
          return;
        this._chkBoostBoostable.CheckedChanged += eventHandler;
      }
    }

    internal virtual CheckBox chkBoostUsePlayerLevel
    {
      get
      {
        return this._chkBoostUsePlayerLevel;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.chkBoostUsePlayerLevel_CheckedChanged);
        if (this._chkBoostUsePlayerLevel != null)
          this._chkBoostUsePlayerLevel.CheckedChanged -= eventHandler;
        this._chkBoostUsePlayerLevel = value;
        if (this._chkBoostUsePlayerLevel == null)
          return;
        this._chkBoostUsePlayerLevel.CheckedChanged += eventHandler;
      }
    }

    internal virtual CheckBox chkBuffCycle
    {
      get
      {
        return this._chkBuffCycle;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.chkBuffCycle_CheckedChanged);
        if (this._chkBuffCycle != null)
          this._chkBuffCycle.CheckedChanged -= eventHandler;
        this._chkBuffCycle = value;
        if (this._chkBuffCycle == null)
          return;
        this._chkBuffCycle.CheckedChanged += eventHandler;
      }
    }

    internal virtual CheckBox chkGraphFix
    {
      get
      {
        return this._chkGraphFix;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.chkGraphFix_CheckedChanged);
        if (this._chkGraphFix != null)
          this._chkGraphFix.CheckedChanged -= eventHandler;
        this._chkGraphFix = value;
        if (this._chkGraphFix == null)
          return;
        this._chkGraphFix.CheckedChanged += eventHandler;
      }
    }

    internal virtual CheckBox chkHidden
    {
      get
      {
        return this._chkHidden;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.chkHidden_CheckedChanged);
        if (this._chkHidden != null)
          this._chkHidden.CheckedChanged -= eventHandler;
        this._chkHidden = value;
        if (this._chkHidden == null)
          return;
        this._chkHidden.CheckedChanged += eventHandler;
      }
    }

    internal virtual CheckBox chkIgnoreStrength
    {
      get
      {
        return this._chkIgnoreStrength;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.chkIgnoreStrength_CheckedChanged);
        if (this._chkIgnoreStrength != null)
          this._chkIgnoreStrength.CheckedChanged -= eventHandler;
        this._chkIgnoreStrength = value;
        if (this._chkIgnoreStrength == null)
          return;
        this._chkIgnoreStrength.CheckedChanged += eventHandler;
      }
    }

    internal virtual CheckBox chkLos
    {
      get
      {
        return this._chkLos;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.chkLos_CheckedChanged);
        if (this._chkLos != null)
          this._chkLos.CheckedChanged -= eventHandler;
        this._chkLos = value;
        if (this._chkLos == null)
          return;
        this._chkLos.CheckedChanged += eventHandler;
      }
    }

    internal virtual CheckBox chkMutexAuto
    {
      get
      {
        return this._chkMutexAuto;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.chkMutexAuto_CheckedChanged);
        if (this._chkMutexAuto != null)
          this._chkMutexAuto.CheckedChanged -= eventHandler;
        this._chkMutexAuto = value;
        if (this._chkMutexAuto == null)
          return;
        this._chkMutexAuto.CheckedChanged += eventHandler;
      }
    }

    internal virtual CheckBox chkMutexSkip
    {
      get
      {
        return this._chkMutexSkip;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.chkMutexSkip_CheckedChanged);
        if (this._chkMutexSkip != null)
          this._chkMutexSkip.CheckedChanged -= eventHandler;
        this._chkMutexSkip = value;
        if (this._chkMutexSkip == null)
          return;
        this._chkMutexSkip.CheckedChanged += eventHandler;
      }
    }

    internal virtual CheckBox chkNoAUReq
    {
      get
      {
        return this._chkNoAUReq;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.chkNoAUReq_CheckedChanged);
        if (this._chkNoAUReq != null)
          this._chkNoAUReq.CheckedChanged -= eventHandler;
        this._chkNoAUReq = value;
        if (this._chkNoAUReq == null)
          return;
        this._chkNoAUReq.CheckedChanged += eventHandler;
      }
    }

    internal virtual CheckBox chkNoAutoUpdate
    {
      get
      {
        return this._chkNoAutoUpdate;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.chkNoAutoUpdate_CheckedChanged);
        if (this._chkNoAutoUpdate != null)
          this._chkNoAutoUpdate.CheckedChanged -= eventHandler;
        this._chkNoAutoUpdate = value;
        if (this._chkNoAutoUpdate == null)
          return;
        this._chkNoAutoUpdate.CheckedChanged += eventHandler;
      }
    }

    internal virtual CheckBox chkPRFrontLoad
    {
      get
      {
        return this._chkPRFrontLoad;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.chkPRFrontLoad_CheckedChanged);
        if (this._chkPRFrontLoad != null)
          this._chkPRFrontLoad.CheckedChanged -= eventHandler;
        this._chkPRFrontLoad = value;
        if (this._chkPRFrontLoad == null)
          return;
        this._chkPRFrontLoad.CheckedChanged += eventHandler;
      }
    }

    internal virtual CheckBox chkScale
    {
      get
      {
        return this._chkScale;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.chkScale_CheckedChanged);
        if (this._chkScale != null)
          this._chkScale.CheckedChanged -= eventHandler;
        this._chkScale = value;
        if (this._chkScale == null)
          return;
        this._chkScale.CheckedChanged += eventHandler;
      }
    }

    internal virtual CheckBox chkSortOverride
    {
      get
      {
        return this._chkSortOverride;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.chkSortOverride_CheckedChanged);
        if (this._chkSortOverride != null)
          this._chkSortOverride.CheckedChanged -= eventHandler;
        this._chkSortOverride = value;
        if (this._chkSortOverride == null)
          return;
        this._chkSortOverride.CheckedChanged += eventHandler;
      }
    }

    internal virtual CheckBox chkSubInclude
    {
      get
      {
        return this._chkSubInclude;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.chkSubInclude_CheckedChanged);
        if (this._chkSubInclude != null)
          this._chkSubInclude.CheckedChanged -= eventHandler;
        this._chkSubInclude = value;
        if (this._chkSubInclude == null)
          return;
        this._chkSubInclude.CheckedChanged += eventHandler;
      }
    }

    internal virtual CheckBox chkSummonDisplayEntity
    {
      get
      {
        return this._chkSummonDisplayEntity;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.chkSummonDisplayEntity_CheckedChanged);
        if (this._chkSummonDisplayEntity != null)
          this._chkSummonDisplayEntity.CheckedChanged -= eventHandler;
        this._chkSummonDisplayEntity = value;
        if (this._chkSummonDisplayEntity == null)
          return;
        this._chkSummonDisplayEntity.CheckedChanged += eventHandler;
      }
    }

    internal virtual CheckBox chkSummonStealAttributes
    {
      get
      {
        return this._chkSummonStealAttributes;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.chkSummonStealAttributes_CheckedChanged);
        if (this._chkSummonStealAttributes != null)
          this._chkSummonStealAttributes.CheckedChanged -= eventHandler;
        this._chkSummonStealAttributes = value;
        if (this._chkSummonStealAttributes == null)
          return;
        this._chkSummonStealAttributes.CheckedChanged += eventHandler;
      }
    }

    internal virtual CheckBox chkSummonStealEffects
    {
      get
      {
        return this._chkSummonStealEffects;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.chkSummonStealEffects_CheckedChanged);
        if (this._chkSummonStealEffects != null)
          this._chkSummonStealEffects.CheckedChanged -= eventHandler;
        this._chkSummonStealEffects = value;
        if (this._chkSummonStealEffects == null)
          return;
        this._chkSummonStealEffects.CheckedChanged += eventHandler;
      }
    }

    internal virtual CheckedListBox clbClassExclude
    {
      get
      {
        return this._clbClassExclude;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._clbClassExclude = value;
      }
    }

    internal virtual CheckedListBox clbClassReq
    {
      get
      {
        return this._clbClassReq;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._clbClassReq = value;
      }
    }

    internal virtual CheckedListBox clbFlags
    {
      get
      {
        return this._clbFlags;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        ItemCheckEventHandler checkEventHandler = new ItemCheckEventHandler(this.clbFlags_ItemCheck);
        if (this._clbFlags != null)
          this._clbFlags.ItemCheck -= checkEventHandler;
        this._clbFlags = value;
        if (this._clbFlags == null)
          return;
        this._clbFlags.ItemCheck += checkEventHandler;
      }
    }

    internal virtual CheckedListBox clbMutex
    {
      get
      {
        return this._clbMutex;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._clbMutex = value;
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

    internal virtual ColumnHeader ColumnHeader10
    {
      get
      {
        return this._ColumnHeader10;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._ColumnHeader10 = value;
      }
    }

    internal virtual ColumnHeader ColumnHeader11
    {
      get
      {
        return this._ColumnHeader11;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._ColumnHeader11 = value;
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

    internal virtual ColumnHeader ColumnHeader7
    {
      get
      {
        return this._ColumnHeader7;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._ColumnHeader7 = value;
      }
    }

    internal virtual ColumnHeader ColumnHeader8
    {
      get
      {
        return this._ColumnHeader8;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._ColumnHeader8 = value;
      }
    }

    internal virtual ColumnHeader ColumnHeader9
    {
      get
      {
        return this._ColumnHeader9;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._ColumnHeader9 = value;
      }
    }

    internal virtual GroupBox GroupBox1
    {
      get
      {
        return this._GroupBox1;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._GroupBox1 = value;
      }
    }

    internal virtual GroupBox GroupBox10
    {
      get
      {
        return this._GroupBox10;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._GroupBox10 = value;
      }
    }

    internal virtual GroupBox GroupBox11
    {
      get
      {
        return this._GroupBox11;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._GroupBox11 = value;
      }
    }

    internal virtual GroupBox GroupBox2
    {
      get
      {
        return this._GroupBox2;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._GroupBox2 = value;
      }
    }

    internal virtual GroupBox GroupBox3
    {
      get
      {
        return this._GroupBox3;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._GroupBox3 = value;
      }
    }

    internal virtual GroupBox GroupBox4
    {
      get
      {
        return this._GroupBox4;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._GroupBox4 = value;
      }
    }

    internal virtual GroupBox GroupBox5
    {
      get
      {
        return this._GroupBox5;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._GroupBox5 = value;
      }
    }

    internal virtual GroupBox GroupBox6
    {
      get
      {
        return this._GroupBox6;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._GroupBox6 = value;
      }
    }

    internal virtual GroupBox GroupBox7
    {
      get
      {
        return this._GroupBox7;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._GroupBox7 = value;
      }
    }

    internal virtual GroupBox GroupBox8
    {
      get
      {
        return this._GroupBox8;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._GroupBox8 = value;
      }
    }

    internal virtual GroupBox GroupBox9
    {
      get
      {
        return this._GroupBox9;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._GroupBox9 = value;
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

    internal virtual Label Label10
    {
      get
      {
        return this._Label10;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._Label10 = value;
      }
    }

    internal virtual Label Label11
    {
      get
      {
        return this._Label11;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._Label11 = value;
      }
    }

    internal virtual Label Label12
    {
      get
      {
        return this._Label12;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._Label12 = value;
      }
    }

    internal virtual Label Label13
    {
      get
      {
        return this._Label13;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._Label13 = value;
      }
    }

    internal virtual Label Label14
    {
      get
      {
        return this._Label14;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._Label14 = value;
      }
    }

    internal virtual Label Label15
    {
      get
      {
        return this._Label15;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._Label15 = value;
      }
    }

    internal virtual Label Label16
    {
      get
      {
        return this._Label16;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._Label16 = value;
      }
    }

    internal virtual Label Label17
    {
      get
      {
        return this._Label17;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._Label17 = value;
      }
    }

    internal virtual Label Label18
    {
      get
      {
        return this._Label18;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._Label18 = value;
      }
    }

    internal virtual Label Label2
    {
      get
      {
        return this._Label2;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._Label2 = value;
      }
    }

    internal virtual Label Label20
    {
      get
      {
        return this._Label20;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._Label20 = value;
      }
    }

    internal virtual Label Label21
    {
      get
      {
        return this._Label21;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._Label21 = value;
      }
    }

    internal virtual Label Label22
    {
      get
      {
        return this._Label22;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._Label22 = value;
      }
    }

    internal virtual Label Label23
    {
      get
      {
        return this._Label23;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._Label23 = value;
      }
    }

    internal virtual Label Label24
    {
      get
      {
        return this._Label24;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._Label24 = value;
      }
    }

    internal virtual Label Label26
    {
      get
      {
        return this._Label26;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._Label26 = value;
      }
    }

    internal virtual Label Label27
    {
      get
      {
        return this._Label27;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._Label27 = value;
      }
    }

    internal virtual Label Label28
    {
      get
      {
        return this._Label28;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._Label28 = value;
      }
    }

    internal virtual Label Label29
    {
      get
      {
        return this._Label29;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._Label29 = value;
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

    internal virtual Label Label30
    {
      get
      {
        return this._Label30;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._Label30 = value;
      }
    }

    internal virtual Label Label31
    {
      get
      {
        return this._Label31;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._Label31 = value;
      }
    }

    internal virtual Label Label32
    {
      get
      {
        return this._Label32;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._Label32 = value;
      }
    }

    internal virtual Label Label33
    {
      get
      {
        return this._Label33;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._Label33 = value;
      }
    }

    internal virtual Label Label34
    {
      get
      {
        return this._Label34;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._Label34 = value;
      }
    }

    internal virtual Label Label35
    {
      get
      {
        return this._Label35;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._Label35 = value;
      }
    }

    internal virtual Label Label36
    {
      get
      {
        return this._Label36;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._Label36 = value;
      }
    }

    internal virtual Label Label37
    {
      get
      {
        return this._Label37;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._Label37 = value;
      }
    }

    internal virtual Label Label38
    {
      get
      {
        return this._Label38;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._Label38 = value;
      }
    }

    internal virtual Label Label39
    {
      get
      {
        return this._Label39;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._Label39 = value;
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

    internal virtual Label Label40
    {
      get
      {
        return this._Label40;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._Label40 = value;
      }
    }

    internal virtual Label Label41
    {
      get
      {
        return this._Label41;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._Label41 = value;
      }
    }

    internal virtual Label Label42
    {
      get
      {
        return this._Label42;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._Label42 = value;
      }
    }

    internal virtual Label Label43
    {
      get
      {
        return this._Label43;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._Label43 = value;
      }
    }

    internal virtual Label Label44
    {
      get
      {
        return this._Label44;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._Label44 = value;
      }
    }

    internal virtual Label Label45
    {
      get
      {
        return this._Label45;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._Label45 = value;
      }
    }

    internal virtual Label Label46
    {
      get
      {
        return this._Label46;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._Label46 = value;
      }
    }

    internal virtual Label Label47
    {
      get
      {
        return this._Label47;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._Label47 = value;
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

    internal virtual Label Label7
    {
      get
      {
        return this._Label7;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._Label7 = value;
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

    internal virtual Label Label9
    {
      get
      {
        return this._Label9;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._Label9 = value;
      }
    }

    internal virtual Label lblAcc
    {
      get
      {
        return this._lblAcc;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._lblAcc = value;
      }
    }

    internal virtual Label lblEndCost
    {
      get
      {
        return this._lblEndCost;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._lblEndCost = value;
      }
    }

    internal virtual Label lblEnhName
    {
      get
      {
        return this._lblEnhName;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._lblEnhName = value;
      }
    }

    internal virtual Label lblInvSet
    {
      get
      {
        return this._lblInvSet;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._lblInvSet = value;
      }
    }

    internal virtual Label lblNameFull
    {
      get
      {
        return this._lblNameFull;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._lblNameFull = value;
      }
    }

    internal virtual Label lblNameUnique
    {
      get
      {
        return this._lblNameUnique;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._lblNameUnique = value;
      }
    }

    internal virtual Label lblStaticIndex
    {
      get
      {
        return this._lblStaticIndex;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.lblStaticIndex_Click);
        if (this._lblStaticIndex != null)
          this._lblStaticIndex.Click -= eventHandler;
        this._lblStaticIndex = value;
        if (this._lblStaticIndex == null)
          return;
        this._lblStaticIndex.Click += eventHandler;
      }
    }

    internal virtual ListBox lvDisablePass1
    {
      get
      {
        return this._lvDisablePass1;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.lvDisablePass1_SelectedIndexChanged);
        if (this._lvDisablePass1 != null)
          this._lvDisablePass1.SelectedIndexChanged -= eventHandler;
        this._lvDisablePass1 = value;
        if (this._lvDisablePass1 == null)
          return;
        this._lvDisablePass1.SelectedIndexChanged += eventHandler;
      }
    }

    internal virtual ListBox lvDisablePass4
    {
      get
      {
        return this._lvDisablePass4;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.lvDisablePass4_SelectedIndexChanged);
        if (this._lvDisablePass4 != null)
          this._lvDisablePass4.SelectedIndexChanged -= eventHandler;
        this._lvDisablePass4 = value;
        if (this._lvDisablePass4 == null)
          return;
        this._lvDisablePass4.SelectedIndexChanged += eventHandler;
      }
    }

    internal virtual ListBox lvFX
    {
      get
      {
        return this._lvFX;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        KeyPressEventHandler pressEventHandler = new KeyPressEventHandler(this.lvFX_KeyPress);
        EventHandler eventHandler = new EventHandler(this.lvFX_DoubleClick);
        if (this._lvFX != null)
        {
          this._lvFX.KeyPress -= pressEventHandler;
          this._lvFX.DoubleClick -= eventHandler;
        }
        this._lvFX = value;
        if (this._lvFX == null)
          return;
        this._lvFX.KeyPress += pressEventHandler;
        this._lvFX.DoubleClick += eventHandler;
      }
    }

    internal virtual ListView lvPrGroup
    {
      get
      {
        return this._lvPrGroup;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.lvPrGroup_SelectedIndexChanged);
        if (this._lvPrGroup != null)
          this._lvPrGroup.SelectedIndexChanged -= eventHandler;
        this._lvPrGroup = value;
        if (this._lvPrGroup == null)
          return;
        this._lvPrGroup.SelectedIndexChanged += eventHandler;
      }
    }

    internal virtual ListView lvPrListing
    {
      get
      {
        return this._lvPrListing;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.lvPrListing_SelectedIndexChanged);
        if (this._lvPrListing != null)
          this._lvPrListing.SelectedIndexChanged -= eventHandler;
        this._lvPrListing = value;
        if (this._lvPrListing == null)
          return;
        this._lvPrListing.SelectedIndexChanged += eventHandler;
      }
    }

    internal virtual ListView lvPrPower
    {
      get
      {
        return this._lvPrPower;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.lvPrPower_SelectedIndexChanged);
        if (this._lvPrPower != null)
          this._lvPrPower.SelectedIndexChanged -= eventHandler;
        this._lvPrPower = value;
        if (this._lvPrPower == null)
          return;
        this._lvPrPower.SelectedIndexChanged += eventHandler;
      }
    }

    internal virtual ListView lvPrSet
    {
      get
      {
        return this._lvPrSet;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.lvPrSet_SelectedIndexChanged);
        if (this._lvPrSet != null)
          this._lvPrSet.SelectedIndexChanged -= eventHandler;
        this._lvPrSet = value;
        if (this._lvPrSet == null)
          return;
        this._lvPrSet.SelectedIndexChanged += eventHandler;
      }
    }

    internal virtual ListView lvSPGroup
    {
      get
      {
        return this._lvSPGroup;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.lvSPGroup_SelectedIndexChanged);
        if (this._lvSPGroup != null)
          this._lvSPGroup.SelectedIndexChanged -= eventHandler;
        this._lvSPGroup = value;
        if (this._lvSPGroup == null)
          return;
        this._lvSPGroup.SelectedIndexChanged += eventHandler;
      }
    }

    internal virtual ListView lvSPPower
    {
      get
      {
        return this._lvSPPower;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.lvSPPower_SelectedIndexChanged);
        if (this._lvSPPower != null)
          this._lvSPPower.SelectedIndexChanged -= eventHandler;
        this._lvSPPower = value;
        if (this._lvSPPower == null)
          return;
        this._lvSPPower.SelectedIndexChanged += eventHandler;
      }
    }

    internal virtual ListView lvSPSelected
    {
      get
      {
        return this._lvSPSelected;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._lvSPSelected = value;
      }
    }

    internal virtual ListView lvSPSet
    {
      get
      {
        return this._lvSPSet;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.lvSPSet_SelectedIndexChanged);
        if (this._lvSPSet != null)
          this._lvSPSet.SelectedIndexChanged -= eventHandler;
        this._lvSPSet = value;
        if (this._lvSPSet == null)
          return;
        this._lvSPSet.SelectedIndexChanged += eventHandler;
      }
    }

    internal virtual PictureBox pbEnhancementList
    {
      get
      {
        return this._pbEnhancementList;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        MouseEventHandler mouseEventHandler1 = new MouseEventHandler(this.pbEnhancementList_MouseDown);
        MouseEventHandler mouseEventHandler2 = new MouseEventHandler(this.pbEnhancementList_Hover);
        PaintEventHandler paintEventHandler = new PaintEventHandler(this.pbEnhancementList_Paint);
        if (this._pbEnhancementList != null)
        {
          this._pbEnhancementList.MouseDown -= mouseEventHandler1;
          this._pbEnhancementList.MouseMove -= mouseEventHandler2;
          this._pbEnhancementList.Paint -= paintEventHandler;
        }
        this._pbEnhancementList = value;
        if (this._pbEnhancementList == null)
          return;
        this._pbEnhancementList.MouseDown += mouseEventHandler1;
        this._pbEnhancementList.MouseMove += mouseEventHandler2;
        this._pbEnhancementList.Paint += paintEventHandler;
      }
    }

    internal virtual PictureBox pbEnhancements
    {
      get
      {
        return this._pbEnhancements;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        MouseEventHandler mouseEventHandler1 = new MouseEventHandler(this.pbEnhancements_MouseDown);
        MouseEventHandler mouseEventHandler2 = new MouseEventHandler(this.pbEnhancements_Hover);
        PaintEventHandler paintEventHandler = new PaintEventHandler(this.pbEnhancements_Paint);
        if (this._pbEnhancements != null)
        {
          this._pbEnhancements.MouseDown -= mouseEventHandler1;
          this._pbEnhancements.MouseMove -= mouseEventHandler2;
          this._pbEnhancements.Paint -= paintEventHandler;
        }
        this._pbEnhancements = value;
        if (this._pbEnhancements == null)
          return;
        this._pbEnhancements.MouseDown += mouseEventHandler1;
        this._pbEnhancements.MouseMove += mouseEventHandler2;
        this._pbEnhancements.Paint += paintEventHandler;
      }
    }

    internal virtual PictureBox pbInvSetList
    {
      get
      {
        return this._pbInvSetList;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        MouseEventHandler mouseEventHandler1 = new MouseEventHandler(this.pbInvSetList_MouseMove);
        MouseEventHandler mouseEventHandler2 = new MouseEventHandler(this.pbInvSetList_MouseDown);
        PaintEventHandler paintEventHandler = new PaintEventHandler(this.pbInvSetList_Paint);
        if (this._pbInvSetList != null)
        {
          this._pbInvSetList.MouseMove -= mouseEventHandler1;
          this._pbInvSetList.MouseDown -= mouseEventHandler2;
          this._pbInvSetList.Paint -= paintEventHandler;
        }
        this._pbInvSetList = value;
        if (this._pbInvSetList == null)
          return;
        this._pbInvSetList.MouseMove += mouseEventHandler1;
        this._pbInvSetList.MouseDown += mouseEventHandler2;
        this._pbInvSetList.Paint += paintEventHandler;
      }
    }

    internal virtual PictureBox pbInvSetUsed
    {
      get
      {
        return this._pbInvSetUsed;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        MouseEventHandler mouseEventHandler1 = new MouseEventHandler(this.pbInvSetUsed_MouseDown);
        MouseEventHandler mouseEventHandler2 = new MouseEventHandler(this.pbInvSetUsed_MouseMove);
        PaintEventHandler paintEventHandler = new PaintEventHandler(this.pbInvSetUsed_Paint);
        if (this._pbInvSetUsed != null)
        {
          this._pbInvSetUsed.MouseDown -= mouseEventHandler1;
          this._pbInvSetUsed.MouseMove -= mouseEventHandler2;
          this._pbInvSetUsed.Paint -= paintEventHandler;
        }
        this._pbInvSetUsed = value;
        if (this._pbInvSetUsed == null)
          return;
        this._pbInvSetUsed.MouseDown += mouseEventHandler1;
        this._pbInvSetUsed.MouseMove += mouseEventHandler2;
        this._pbInvSetUsed.Paint += paintEventHandler;
      }
    }

    internal virtual Panel pnlFX
    {
      get
      {
        return this._pnlFX;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._pnlFX = value;
      }
    }

    internal virtual RadioButton rbFlagAffected
    {
      get
      {
        return this._rbFlagAffected;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.rbFlagX_CheckedChanged);
        if (this._rbFlagAffected != null)
          this._rbFlagAffected.CheckedChanged -= eventHandler;
        this._rbFlagAffected = value;
        if (this._rbFlagAffected == null)
          return;
        this._rbFlagAffected.CheckedChanged += eventHandler;
      }
    }

    internal virtual RadioButton rbFlagAutoHit
    {
      get
      {
        return this._rbFlagAutoHit;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.rbFlagX_CheckedChanged);
        if (this._rbFlagAutoHit != null)
          this._rbFlagAutoHit.CheckedChanged -= eventHandler;
        this._rbFlagAutoHit = value;
        if (this._rbFlagAutoHit == null)
          return;
        this._rbFlagAutoHit.CheckedChanged += eventHandler;
      }
    }

    internal virtual RadioButton rbFlagCast
    {
      get
      {
        return this._rbFlagCast;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.rbFlagX_CheckedChanged);
        if (this._rbFlagCast != null)
          this._rbFlagCast.CheckedChanged -= eventHandler;
        this._rbFlagCast = value;
        if (this._rbFlagCast == null)
          return;
        this._rbFlagCast.CheckedChanged += eventHandler;
      }
    }

    internal virtual RadioButton rbFlagCastThrough
    {
      get
      {
        return this._rbFlagCastThrough;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.rbFlagX_CheckedChanged);
        if (this._rbFlagCastThrough != null)
          this._rbFlagCastThrough.CheckedChanged -= eventHandler;
        this._rbFlagCastThrough = value;
        if (this._rbFlagCastThrough == null)
          return;
        this._rbFlagCastThrough.CheckedChanged += eventHandler;
      }
    }

    internal virtual RadioButton rbFlagDisallow
    {
      get
      {
        return this._rbFlagDisallow;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.rbFlagX_CheckedChanged);
        if (this._rbFlagDisallow != null)
          this._rbFlagDisallow.CheckedChanged -= eventHandler;
        this._rbFlagDisallow = value;
        if (this._rbFlagDisallow == null)
          return;
        this._rbFlagDisallow.CheckedChanged += eventHandler;
      }
    }

    internal virtual RadioButton rbFlagRequired
    {
      get
      {
        return this._rbFlagRequired;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.rbFlagX_CheckedChanged);
        if (this._rbFlagRequired != null)
          this._rbFlagRequired.CheckedChanged -= eventHandler;
        this._rbFlagRequired = value;
        if (this._rbFlagRequired == null)
          return;
        this._rbFlagRequired.CheckedChanged += eventHandler;
      }
    }

    internal virtual RadioButton rbFlagTargets
    {
      get
      {
        return this._rbFlagTargets;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.rbFlagX_CheckedChanged);
        if (this._rbFlagTargets != null)
          this._rbFlagTargets.CheckedChanged -= eventHandler;
        this._rbFlagTargets = value;
        if (this._rbFlagTargets == null)
          return;
        this._rbFlagTargets.CheckedChanged += eventHandler;
      }
    }

    internal virtual RadioButton rbFlagTargetsSec
    {
      get
      {
        return this._rbFlagTargetsSec;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.rbFlagX_CheckedChanged);
        if (this._rbFlagTargetsSec != null)
          this._rbFlagTargetsSec.CheckedChanged -= eventHandler;
        this._rbFlagTargetsSec = value;
        if (this._rbFlagTargetsSec == null)
          return;
        this._rbFlagTargetsSec.CheckedChanged += eventHandler;
      }
    }

    internal virtual RadioButton rbFlagVector
    {
      get
      {
        return this._rbFlagVector;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.rbFlagX_CheckedChanged);
        if (this._rbFlagVector != null)
          this._rbFlagVector.CheckedChanged -= eventHandler;
        this._rbFlagVector = value;
        if (this._rbFlagVector == null)
          return;
        this._rbFlagVector.CheckedChanged += eventHandler;
      }
    }

    internal virtual Button rbPrAdd
    {
      get
      {
        return this._rbPrAdd;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.rbPrAdd_Click);
        if (this._rbPrAdd != null)
          this._rbPrAdd.Click -= eventHandler;
        this._rbPrAdd = value;
        if (this._rbPrAdd == null)
          return;
        this._rbPrAdd.Click += eventHandler;
      }
    }

    internal virtual RadioButton rbPrPowerA
    {
      get
      {
        return this._rbPrPowerA;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.rbPrPowerX_CheckedChanged);
        if (this._rbPrPowerA != null)
          this._rbPrPowerA.CheckedChanged -= eventHandler;
        this._rbPrPowerA = value;
        if (this._rbPrPowerA == null)
          return;
        this._rbPrPowerA.CheckedChanged += eventHandler;
      }
    }

    internal virtual RadioButton rbPrPowerB
    {
      get
      {
        return this._rbPrPowerB;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.rbPrPowerX_CheckedChanged);
        if (this._rbPrPowerB != null)
          this._rbPrPowerB.CheckedChanged -= eventHandler;
        this._rbPrPowerB = value;
        if (this._rbPrPowerB == null)
          return;
        this._rbPrPowerB.CheckedChanged += eventHandler;
      }
    }

    internal virtual Button rbPrRemove
    {
      get
      {
        return this._rbPrRemove;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.rbPrRemove_Click);
        if (this._rbPrRemove != null)
          this._rbPrRemove.Click -= eventHandler;
        this._rbPrRemove = value;
        if (this._rbPrRemove == null)
          return;
        this._rbPrRemove.Click += eventHandler;
      }
    }

    internal virtual TabControl tcPower
    {
      get
      {
        return this._tcPower;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._tcPower = value;
      }
    }

    internal virtual TabPage tpBasic
    {
      get
      {
        return this._tpBasic;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._tpBasic = value;
      }
    }

    internal virtual TabPage tpEffects
    {
      get
      {
        return this._tpEffects;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._tpEffects = value;
      }
    }

    internal virtual TabPage tpEnh
    {
      get
      {
        return this._tpEnh;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._tpEnh = value;
      }
    }

    internal virtual TabPage tpMutex
    {
      get
      {
        return this._tpMutex;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._tpMutex = value;
      }
    }

    internal virtual TabPage tpPreReq
    {
      get
      {
        return this._tpPreReq;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._tpPreReq = value;
      }
    }

    internal virtual TabPage tpSets
    {
      get
      {
        return this._tpSets;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._tpSets = value;
      }
    }

    internal virtual TabPage tpSpecialEnh
    {
      get
      {
        return this._tpSpecialEnh;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._tpSpecialEnh = value;
      }
    }

    internal virtual TabPage tpSubPower
    {
      get
      {
        return this._tpSubPower;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._tpSubPower = value;
      }
    }

    internal virtual TabPage tpText
    {
      get
      {
        return this._tpText;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._tpText = value;
      }
    }

    internal virtual TextBox txtAcc
    {
      get
      {
        return this._txtAcc;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler1 = new EventHandler(this.txtAcc_Leave);
        EventHandler eventHandler2 = new EventHandler(this.txtAcc_TextChanged);
        if (this._txtAcc != null)
        {
          this._txtAcc.Leave -= eventHandler1;
          this._txtAcc.TextChanged -= eventHandler2;
        }
        this._txtAcc = value;
        if (this._txtAcc == null)
          return;
        this._txtAcc.Leave += eventHandler1;
        this._txtAcc.TextChanged += eventHandler2;
      }
    }

    internal virtual TextBox txtActivate
    {
      get
      {
        return this._txtActivate;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler1 = new EventHandler(this.txtActivate_Leave);
        EventHandler eventHandler2 = new EventHandler(this.txtActivate_TextChanged);
        if (this._txtActivate != null)
        {
          this._txtActivate.Leave -= eventHandler1;
          this._txtActivate.TextChanged -= eventHandler2;
        }
        this._txtActivate = value;
        if (this._txtActivate == null)
          return;
        this._txtActivate.Leave += eventHandler1;
        this._txtActivate.TextChanged += eventHandler2;
      }
    }

    internal virtual TextBox txtArc
    {
      get
      {
        return this._txtArc;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler1 = new EventHandler(this.txtArc_Leave);
        EventHandler eventHandler2 = new EventHandler(this.txtArc_TextChanged);
        if (this._txtArc != null)
        {
          this._txtArc.Leave -= eventHandler1;
          this._txtArc.TextChanged -= eventHandler2;
        }
        this._txtArc = value;
        if (this._txtArc == null)
          return;
        this._txtArc.Leave += eventHandler1;
        this._txtArc.TextChanged += eventHandler2;
      }
    }

    internal virtual TextBox txtCastTime
    {
      get
      {
        return this._txtCastTime;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler1 = new EventHandler(this.txtCastTime_Leave);
        EventHandler eventHandler2 = new EventHandler(this.txtCastTime_TextChanged);
        if (this._txtCastTime != null)
        {
          this._txtCastTime.Leave -= eventHandler1;
          this._txtCastTime.TextChanged -= eventHandler2;
        }
        this._txtCastTime = value;
        if (this._txtCastTime == null)
          return;
        this._txtCastTime.Leave += eventHandler1;
        this._txtCastTime.TextChanged += eventHandler2;
      }
    }

    internal virtual TextBox txtDescLong
    {
      get
      {
        return this._txtDescLong;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.txtDescLong_TextChanged);
        if (this._txtDescLong != null)
          this._txtDescLong.TextChanged -= eventHandler;
        this._txtDescLong = value;
        if (this._txtDescLong == null)
          return;
        this._txtDescLong.TextChanged += eventHandler;
      }
    }

    internal virtual TextBox txtDescShort
    {
      get
      {
        return this._txtDescShort;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.txtDescShort_TextChanged);
        if (this._txtDescShort != null)
          this._txtDescShort.TextChanged -= eventHandler;
        this._txtDescShort = value;
        if (this._txtDescShort == null)
          return;
        this._txtDescShort.TextChanged += eventHandler;
      }
    }

    internal virtual TextBox txtEndCost
    {
      get
      {
        return this._txtEndCost;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler1 = new EventHandler(this.txtEndCost_Leave);
        EventHandler eventHandler2 = new EventHandler(this.txtEndCost_TextChanged);
        if (this._txtEndCost != null)
        {
          this._txtEndCost.Leave -= eventHandler1;
          this._txtEndCost.TextChanged -= eventHandler2;
        }
        this._txtEndCost = value;
        if (this._txtEndCost == null)
          return;
        this._txtEndCost.Leave += eventHandler1;
        this._txtEndCost.TextChanged += eventHandler2;
      }
    }

    internal virtual TextBox txtInterrupt
    {
      get
      {
        return this._txtInterrupt;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler1 = new EventHandler(this.txtInterrupt_Leave);
        EventHandler eventHandler2 = new EventHandler(this.txtInterrupt_TextChanged);
        if (this._txtInterrupt != null)
        {
          this._txtInterrupt.Leave -= eventHandler1;
          this._txtInterrupt.TextChanged -= eventHandler2;
        }
        this._txtInterrupt = value;
        if (this._txtInterrupt == null)
          return;
        this._txtInterrupt.Leave += eventHandler1;
        this._txtInterrupt.TextChanged += eventHandler2;
      }
    }

    internal virtual TextBox txtLevel
    {
      get
      {
        return this._txtLevel;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler1 = new EventHandler(this.txtLevel_Leave);
        EventHandler eventHandler2 = new EventHandler(this.txtLevel_TextChanged);
        if (this._txtLevel != null)
        {
          this._txtLevel.Leave -= eventHandler1;
          this._txtLevel.TextChanged -= eventHandler2;
        }
        this._txtLevel = value;
        if (this._txtLevel == null)
          return;
        this._txtLevel.Leave += eventHandler1;
        this._txtLevel.TextChanged += eventHandler2;
      }
    }

    internal virtual TextBox txtLifeTimeGame
    {
      get
      {
        return this._txtLifeTimeGame;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler1 = new EventHandler(this.txtLifeTimeGame_TextChanged);
        EventHandler eventHandler2 = new EventHandler(this.txtLifeTimeGame_Leave);
        if (this._txtLifeTimeGame != null)
        {
          this._txtLifeTimeGame.TextChanged -= eventHandler1;
          this._txtLifeTimeGame.Leave -= eventHandler2;
        }
        this._txtLifeTimeGame = value;
        if (this._txtLifeTimeGame == null)
          return;
        this._txtLifeTimeGame.TextChanged += eventHandler1;
        this._txtLifeTimeGame.Leave += eventHandler2;
      }
    }

    internal virtual TextBox txtLifeTimeReal
    {
      get
      {
        return this._txtLifeTimeReal;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler1 = new EventHandler(this.txtLifeTimeReal_TextChanged);
        EventHandler eventHandler2 = new EventHandler(this.txtLifeTimeReal_Leave);
        if (this._txtLifeTimeReal != null)
        {
          this._txtLifeTimeReal.TextChanged -= eventHandler1;
          this._txtLifeTimeReal.Leave -= eventHandler2;
        }
        this._txtLifeTimeReal = value;
        if (this._txtLifeTimeReal == null)
          return;
        this._txtLifeTimeReal.TextChanged += eventHandler1;
        this._txtLifeTimeReal.Leave += eventHandler2;
      }
    }

    internal virtual TextBox txtMaxTargets
    {
      get
      {
        return this._txtMaxTargets;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler1 = new EventHandler(this.txtMaxTargets_Leave);
        EventHandler eventHandler2 = new EventHandler(this.txtMaxTargets_TextChanged);
        if (this._txtMaxTargets != null)
        {
          this._txtMaxTargets.Leave -= eventHandler1;
          this._txtMaxTargets.TextChanged -= eventHandler2;
        }
        this._txtMaxTargets = value;
        if (this._txtMaxTargets == null)
          return;
        this._txtMaxTargets.Leave += eventHandler1;
        this._txtMaxTargets.TextChanged += eventHandler2;
      }
    }

    internal virtual TextBox txtNameDisplay
    {
      get
      {
        return this._txtNameDisplay;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.txtPowerName_TextChanged);
        if (this._txtNameDisplay != null)
          this._txtNameDisplay.TextChanged -= eventHandler;
        this._txtNameDisplay = value;
        if (this._txtNameDisplay == null)
          return;
        this._txtNameDisplay.TextChanged += eventHandler;
      }
    }

    internal virtual TextBox txtNamePower
    {
      get
      {
        return this._txtNamePower;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler1 = new EventHandler(this.txtNamePower_TextChanged);
        EventHandler eventHandler2 = new EventHandler(this.txtNamePower_Leave);
        if (this._txtNamePower != null)
        {
          this._txtNamePower.TextChanged -= eventHandler1;
          this._txtNamePower.Leave -= eventHandler2;
        }
        this._txtNamePower = value;
        if (this._txtNamePower == null)
          return;
        this._txtNamePower.TextChanged += eventHandler1;
        this._txtNamePower.Leave += eventHandler2;
      }
    }

    internal virtual TextBox txtNumCharges
    {
      get
      {
        return this._txtNumCharges;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler1 = new EventHandler(this.txtNumCharges_TextChanged);
        EventHandler eventHandler2 = new EventHandler(this.txtNumCharges_Leave);
        if (this._txtNumCharges != null)
        {
          this._txtNumCharges.TextChanged -= eventHandler1;
          this._txtNumCharges.Leave -= eventHandler2;
        }
        this._txtNumCharges = value;
        if (this._txtNumCharges == null)
          return;
        this._txtNumCharges.TextChanged += eventHandler1;
        this._txtNumCharges.Leave += eventHandler2;
      }
    }

    internal virtual TextBox txtRadius
    {
      get
      {
        return this._txtRadius;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler1 = new EventHandler(this.txtRadius_Leave);
        EventHandler eventHandler2 = new EventHandler(this.txtRadius_TextChanged);
        if (this._txtRadius != null)
        {
          this._txtRadius.Leave -= eventHandler1;
          this._txtRadius.TextChanged -= eventHandler2;
        }
        this._txtRadius = value;
        if (this._txtRadius == null)
          return;
        this._txtRadius.Leave += eventHandler1;
        this._txtRadius.TextChanged += eventHandler2;
      }
    }

    internal virtual TextBox txtRange
    {
      get
      {
        return this._txtRange;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler1 = new EventHandler(this.txtRange_Leave);
        EventHandler eventHandler2 = new EventHandler(this.txtRange_TextChanged);
        if (this._txtRange != null)
        {
          this._txtRange.Leave -= eventHandler1;
          this._txtRange.TextChanged -= eventHandler2;
        }
        this._txtRange = value;
        if (this._txtRange == null)
          return;
        this._txtRange.Leave += eventHandler1;
        this._txtRange.TextChanged += eventHandler2;
      }
    }

    internal virtual TextBox txtRangeSec
    {
      get
      {
        return this._txtRangeSec;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler1 = new EventHandler(this.txtRangeSec_TextChanged);
        EventHandler eventHandler2 = new EventHandler(this.txtRangeSec_Leave);
        if (this._txtRangeSec != null)
        {
          this._txtRangeSec.TextChanged -= eventHandler1;
          this._txtRangeSec.Leave -= eventHandler2;
        }
        this._txtRangeSec = value;
        if (this._txtRangeSec == null)
          return;
        this._txtRangeSec.TextChanged += eventHandler1;
        this._txtRangeSec.Leave += eventHandler2;
      }
    }

    internal virtual TextBox txtRechargeTime
    {
      get
      {
        return this._txtRechargeTime;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler1 = new EventHandler(this.txtRechargeTime_Leave);
        EventHandler eventHandler2 = new EventHandler(this.txtRechargeTime_TextChanged);
        if (this._txtRechargeTime != null)
        {
          this._txtRechargeTime.Leave -= eventHandler1;
          this._txtRechargeTime.TextChanged -= eventHandler2;
        }
        this._txtRechargeTime = value;
        if (this._txtRechargeTime == null)
          return;
        this._txtRechargeTime.Leave += eventHandler1;
        this._txtRechargeTime.TextChanged += eventHandler2;
      }
    }

    internal virtual TextBox txtScaleName
    {
      get
      {
        return this._txtScaleName;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.txtScaleName_TextChanged);
        if (this._txtScaleName != null)
          this._txtScaleName.TextChanged -= eventHandler;
        this._txtScaleName = value;
        if (this._txtScaleName == null)
          return;
        this._txtScaleName.TextChanged += eventHandler;
      }
    }

    internal virtual TextBox txtUseageTime
    {
      get
      {
        return this._txtUseageTime;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler1 = new EventHandler(this.txtUseageTime_TextChanged);
        EventHandler eventHandler2 = new EventHandler(this.txtUseageTime_Leave);
        if (this._txtUseageTime != null)
        {
          this._txtUseageTime.TextChanged -= eventHandler1;
          this._txtUseageTime.Leave -= eventHandler2;
        }
        this._txtUseageTime = value;
        if (this._txtUseageTime == null)
          return;
        this._txtUseageTime.TextChanged += eventHandler1;
        this._txtUseageTime.Leave += eventHandler2;
      }
    }

    internal virtual TextBox txtVisualLocation
    {
      get
      {
        return this._txtVisualLocation;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler1 = new EventHandler(this.txtVisualLocation_Leave);
        EventHandler eventHandler2 = new EventHandler(this.txtVisualLocation_TextChanged);
        if (this._txtVisualLocation != null)
        {
          this._txtVisualLocation.Leave -= eventHandler1;
          this._txtVisualLocation.TextChanged -= eventHandler2;
        }
        this._txtVisualLocation = value;
        if (this._txtVisualLocation == null)
          return;
        this._txtVisualLocation.Leave += eventHandler1;
        this._txtVisualLocation.TextChanged += eventHandler2;
      }
    }

    internal virtual NumericUpDown udScaleMax
    {
      get
      {
        return this._udScaleMax;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler1 = new EventHandler(this.udScaleMax_ValueChanged);
        EventHandler eventHandler2 = new EventHandler(this.udScaleMax_Leave);
        KeyPressEventHandler pressEventHandler = new KeyPressEventHandler(this.udScaleMax_KeyPress);
        if (this._udScaleMax != null)
        {
          this._udScaleMax.ValueChanged -= eventHandler1;
          this._udScaleMax.Leave -= eventHandler2;
          this._udScaleMax.KeyPress -= pressEventHandler;
        }
        this._udScaleMax = value;
        if (this._udScaleMax == null)
          return;
        this._udScaleMax.ValueChanged += eventHandler1;
        this._udScaleMax.Leave += eventHandler2;
        this._udScaleMax.KeyPress += pressEventHandler;
      }
    }

    internal virtual NumericUpDown udScaleMin
    {
      get
      {
        return this._udScaleMin;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler1 = new EventHandler(this.udScaleMin_ValueChanged);
        EventHandler eventHandler2 = new EventHandler(this.udScaleMin_Leave);
        KeyPressEventHandler pressEventHandler = new KeyPressEventHandler(this.udScaleMin_KeyPress);
        if (this._udScaleMin != null)
        {
          this._udScaleMin.ValueChanged -= eventHandler1;
          this._udScaleMin.Leave -= eventHandler2;
          this._udScaleMin.KeyPress -= pressEventHandler;
        }
        this._udScaleMin = value;
        if (this._udScaleMin == null)
          return;
        this._udScaleMin.ValueChanged += eventHandler1;
        this._udScaleMin.Leave += eventHandler2;
        this._udScaleMin.KeyPress += pressEventHandler;
      }
    }

    public frmEditPower(ref IPower iPower)
    {
      this.Load += new EventHandler(this.frmEditPower_Load);
      this.enhPadding = 6;
      this.enhAcross = 8;
      this.Updating = true;
      this.ReqChanging = false;
      this.InitializeComponent();
      this.myPower = (IPower) new Power(iPower);
      this.backup_Requires = new Requirement(this.myPower.Requires);
    }

    private void btnCancel_Click(object sender, EventArgs e)
    {
      this.DialogResult = DialogResult.Cancel;
      this.Hide();
    }

    private void btnCSVImport_Click(object sender, EventArgs e)
    {
      string str = Clipboard.GetDataObject().GetData("System.String", true).ToString();
      if (!(str != ""))
        return;
      if (new PowerData(str.Replace("\t", ",")).IsValid)
      {
        int num = (int) Interaction.MsgBox((object) "Import successful.", MsgBoxStyle.OkOnly, (object) null);
        this.refresh_PowerData();
      }
      else
      {
        int num1 = (int) Interaction.MsgBox((object) "Import failed. No changes made.", MsgBoxStyle.OkOnly, (object) null);
      }
    }

    private void btnFullCopy_Click(object sender, EventArgs e)
    {
      DataFormats.Format format = DataFormats.GetFormat("mhdPowerBIN");
      MemoryStream memoryStream = new MemoryStream();
      BinaryWriter writer = new BinaryWriter((Stream) memoryStream);
      this.myPower.StoreTo(ref writer);
      writer.Close();
      Clipboard.SetDataObject((object) new DataObject(format.Name, (object) memoryStream.GetBuffer()));
      memoryStream.Close();
    }

    private void btnFullPaste_Click(object sender, EventArgs e)
    {
      DataFormats.Format format = DataFormats.GetFormat("mhdPowerBIN");
      string groupName = this.myPower.GroupName;
      string setName = this.myPower.SetName;
      if (!Clipboard.ContainsData(format.Name))
      {
        int num = (int) Interaction.MsgBox((object) "No power data on the clipboard!", MsgBoxStyle.Information, (object) "Unable to Paste");
      }
      else
      {
        MemoryStream memoryStream = new MemoryStream((byte[]) Clipboard.GetDataObject().GetData(format.Name));
        BinaryReader reader = new BinaryReader((Stream) memoryStream);
        this.myPower = (IPower) new Power(reader);
        this.myPower.GroupName = groupName;
        this.myPower.SetName = setName;
        this.SetFullName();
        this.refresh_PowerData();
        reader.Close();
        memoryStream.Close();
      }
    }

    private void btnFXAdd_Click(object sender, EventArgs e)
    {
      IEffect iFX = (IEffect) new Effect((IPower) null);
      frmPowerEffect frmPowerEffect = new frmPowerEffect(ref iFX);
      if (frmPowerEffect.ShowDialog() != DialogResult.OK)
        return;
      IPower power1 = this.myPower;
      IPower power2 = power1;
      IEffect[] effectArray = (IEffect[]) Utils.CopyArray((Array) power2.Effects, (Array) new IEffect[power1.Effects.Length + 1]);
      power2.Effects = effectArray;
      power1.Effects[power1.Effects.Length - 1] = (IEffect) frmPowerEffect.myFX.Clone();
      this.RefreshFXData(0);
      this.lvFX.SelectedIndex = this.lvFX.Items.Count - 1;
    }

    private void btnFXDown_Click(object sender, EventArgs e)
    {
      if (this.lvFX.SelectedIndices.Count <= 0)
        return;
      int selectedIndex = this.lvFX.SelectedIndices[0];
      if (selectedIndex <= this.myPower.Effects.Length - 2)
      {
        IEffect[] effectArray = new IEffect[2]
        {
          (IEffect) this.myPower.Effects[selectedIndex].Clone(),
          (IEffect) this.myPower.Effects[selectedIndex + 1].Clone()
        };
        this.myPower.Effects[selectedIndex] = (IEffect) effectArray[1].Clone();
        this.myPower.Effects[selectedIndex + 1] = (IEffect) effectArray[0].Clone();
        this.RefreshFXData(0);
        this.lvFX.SelectedIndex = selectedIndex + 1;
      }
    }

    private void btnFXDuplicate_Click(object sender, EventArgs e)
    {
      if (this.lvFX.SelectedIndices.Count <= 0)
        return;
      IEffect iFX = (IEffect) this.myPower.Effects[this.lvFX.SelectedIndices[0]].Clone();
      frmPowerEffect frmPowerEffect = new frmPowerEffect(ref iFX);
      if (frmPowerEffect.ShowDialog() == DialogResult.OK)
      {
        IPower power1 = this.myPower;
        IPower power2 = power1;
        IEffect[] effectArray = (IEffect[]) Utils.CopyArray((Array) power2.Effects, (Array) new IEffect[power1.Effects.Length + 1]);
        power2.Effects = effectArray;
        power1.Effects[power1.Effects.Length - 1] = (IEffect) frmPowerEffect.myFX.Clone();
        this.RefreshFXData(0);
        this.lvFX.SelectedIndex = this.lvFX.Items.Count - 1;
      }
    }

    private void btnFXEdit_Click(object sender, EventArgs e)
    {
      if (this.lvFX.SelectedIndices.Count <= 0)
        return;
      int selectedIndex = this.lvFX.SelectedIndices[0];
      IEffect iFX = (IEffect) this.myPower.Effects[selectedIndex].Clone();
      frmPowerEffect frmPowerEffect = new frmPowerEffect(ref iFX);
      if (frmPowerEffect.ShowDialog() == DialogResult.OK)
      {
        this.myPower.Effects[selectedIndex] = (IEffect) frmPowerEffect.myFX.Clone();
        this.RefreshFXData(0);
        this.lvFX.SelectedIndex = selectedIndex;
      }
    }

    private void btnFXRemove_Click(object sender, EventArgs e)
    {
      if (this.lvFX.SelectedIndex < 0)
        return;
      IEffect[] effectArray = new IEffect[this.myPower.Effects.Length - 1 + 1];
      int selectedIndex = this.lvFX.SelectedIndex;
      int num1 = effectArray.Length - 1;
      for (int index = 0; index <= num1; ++index)
        effectArray[index] = (IEffect) this.myPower.Effects[index].Clone();
      this.myPower.Effects = new IEffect[this.myPower.Effects.Length - 2 + 1];
      int index1 = 0;
      int num2 = effectArray.Length - 1;
      for (int index2 = 0; index2 <= num2; ++index2)
      {
        if (index2 != selectedIndex)
        {
          this.myPower.Effects[index1] = effectArray[index2];
          ++index1;
        }
      }
      this.RefreshFXData(0);
      if (this.lvFX.Items.Count > selectedIndex)
        this.lvFX.SelectedIndex = selectedIndex;
      else if (this.lvFX.Items.Count > selectedIndex - 1)
        this.lvFX.SelectedIndex = selectedIndex - 1;
    }

    private void btnFXUp_Click(object sender, EventArgs e)
    {
      if (this.lvFX.SelectedIndices.Count <= 0)
        return;
      int selectedIndex = this.lvFX.SelectedIndices[0];
      IEffect[] effectArray = new IEffect[2];
      if (selectedIndex >= 1)
      {
        effectArray[0] = (IEffect) this.myPower.Effects[selectedIndex].Clone();
        effectArray[1] = (IEffect) this.myPower.Effects[selectedIndex - 1].Clone();
        this.myPower.Effects[selectedIndex] = (IEffect) effectArray[1].Clone();
        this.myPower.Effects[selectedIndex - 1] = (IEffect) effectArray[0].Clone();
        this.RefreshFXData(0);
        this.lvFX.SelectedIndex = selectedIndex - 1;
      }
    }

    private void btnMutexAdd_Click(object sender, EventArgs e)
    {
      string b = Interaction.InputBox("Please enter a new group name. It must be different to all the others", "Add Mutex Group", "New_Group", -1, -1).Replace(" ", "_");
      int count = this.clbMutex.Items.Count;
      int index = 0;
      if (index > count)
        return;
      if (string.Equals(this.clbMutex.Items[index].ToString(), b, StringComparison.OrdinalIgnoreCase))
      {
        int num = (int) Interaction.MsgBox((object) ("'" + b + "' is not unique!"), MsgBoxStyle.Information, (object) "Unable to add");
      }
      else
      {
        this.clbMutex.Items.Add((object) b, true);
        this.clbMutex.SelectedIndex = this.clbMutex.Items.Count - 1;
      }
    }

    private void btnOK_Click(object sender, EventArgs e)
    {
      IPower power = this.myPower;
      this.lblNameFull.Text = power.GroupName + "." + power.SetName + "." + power.PowerName;
      if (power.GroupName == "" | power.SetName == "" | power.PowerName == "")
      {
        int num1 = (int) Interaction.MsgBox((object) ("Power name '" + power.FullName + " is invalid."), MsgBoxStyle.Exclamation, (object) "No Can Do");
      }
      else if (!frmEditPower.PowerFullNameIsUnique(Conversions.ToString(power.PowerIndex), -1))
      {
        int num2 = (int) Interaction.MsgBox((object) ("Power name '" + power.FullName + " already exists, please enter a unique name."), MsgBoxStyle.Exclamation, (object) "No Can Do");
      }
      else
      {
        Array.Sort<string>(this.myPower.UIDSubPower);
        this.Store_Req_Classes();
        this.myPower.IsModified = true;
        if (this.myPower.VariableEnabled)
        {
          if (this.myPower.VariableMin >= this.myPower.VariableMax)
          {
            this.myPower.VariableMin = 0;
            if (this.myPower.VariableMax == 0)
              this.myPower.VariableMax = 1;
          }
          if (this.myPower.MaxTargets > 1 & this.myPower.MaxTargets != this.myPower.VariableMax)
            this.myPower.VariableMax = this.myPower.MaxTargets;
        }
        this.myPower.GroupMembership = new string[this.clbMutex.CheckedItems.Count - 1 + 1];
        this.myPower.NGroupMembership = new int[this.clbMutex.CheckedItems.Count - 1 + 1];
        int num3 = this.clbMutex.CheckedItems.Count - 1;
        for (int index = 0; index <= num3; ++index)
        {
          this.myPower.GroupMembership[index] = Conversions.ToString(this.clbMutex.CheckedItems[index]);
          this.myPower.NGroupMembership[index] = this.clbMutex.CheckedIndices[index];
        }
        this.DialogResult = DialogResult.OK;
        this.Hide();
      }
    }

    private void btnPrDown_Click(object sender, EventArgs e)
    {
      if (this.lvPrListing.SelectedItems.Count < 1)
        return;
      int num = (int) Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.lvPrListing.SelectedItems[0].Tag)));
      bool flag = this.lvPrListing.SelectedIndices[0] > this.myPower.Requires.PowerID.Length - 1;
      int index1 = num;
      int index2 = index1 + 1;
      string[][] strArray1 = new string[2][];
      string[] strArray2 = new string[2];
      strArray1[0] = strArray2;
      string[] strArray3 = new string[2];
      strArray1[1] = strArray3;
      if (flag)
      {
        if (num > this.myPower.Requires.PowerIDNot.Length - 2)
          return;
        strArray1[0][0] = this.myPower.Requires.PowerIDNot[index1][0];
        strArray1[0][1] = this.myPower.Requires.PowerIDNot[index1][1];
        strArray1[1][0] = this.myPower.Requires.PowerIDNot[index2][0];
        strArray1[1][1] = this.myPower.Requires.PowerIDNot[index2][1];
        this.myPower.Requires.PowerIDNot[index1][0] = strArray1[1][0];
        this.myPower.Requires.PowerIDNot[index1][1] = strArray1[1][1];
        this.myPower.Requires.PowerIDNot[index2][0] = strArray1[0][0];
        this.myPower.Requires.PowerIDNot[index2][1] = strArray1[0][1];
        index2 = this.lvPrListing.SelectedIndices[0] + 1;
      }
      else
      {
        if (num > this.myPower.Requires.PowerID.Length - 2)
          return;
        strArray1[0][0] = this.myPower.Requires.PowerID[index1][0];
        strArray1[0][1] = this.myPower.Requires.PowerID[index1][1];
        strArray1[1][0] = this.myPower.Requires.PowerID[index2][0];
        strArray1[1][1] = this.myPower.Requires.PowerID[index2][1];
        this.myPower.Requires.PowerID[index1][0] = strArray1[1][0];
        this.myPower.Requires.PowerID[index1][1] = strArray1[1][1];
        this.myPower.Requires.PowerID[index2][0] = strArray1[0][0];
        this.myPower.Requires.PowerID[index2][1] = strArray1[0][1];
      }
      this.FillTab_Req();
      this.lvPrListing.Items[index2].Selected = true;
      this.lvPrListing.Items[index2].EnsureVisible();
    }

    private void btnPrReset_Click(object sender, EventArgs e)
    {
      this.myPower.Requires = new Requirement(this.backup_Requires);
      this.FillTab_Req();
    }

    private void btnPrSetNone_Click(object sender, EventArgs e)
    {
      if (this.lvPrListing.SelectedItems.Count < 1)
        return;
      if (this.rbPrPowerA.Checked)
      {
        if (this.myPower.Requires.PowerID[this.lvPrListing.SelectedIndices[0]][1] != "")
        {
          this.myPower.Requires.PowerID[this.lvPrListing.SelectedIndices[0]][0] = this.myPower.Requires.PowerID[this.lvPrListing.SelectedIndices[0]][1];
          this.myPower.Requires.PowerID[this.lvPrListing.SelectedIndices[0]][1] = "";
        }
        else
          this.rbPrRemove_Click((object) this, new EventArgs());
      }
      else
        this.myPower.Requires.PowerID[this.lvPrListing.SelectedIndices[0]][1] = "";
      this.FillTab_Req();
    }

    private void btnPrUp_Click(object sender, EventArgs e)
    {
      if (this.lvPrListing.SelectedItems.Count < 1)
        return;
      int num = (int) Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.lvPrListing.SelectedItems[0].Tag)));
      bool flag = this.lvPrListing.SelectedIndices[0] > this.myPower.Requires.PowerID.Length - 1;
      if (num >= 1)
      {
        int index1 = num;
        int index2 = index1 - 1;
        string[][] strArray1 = new string[2][];
        string[] strArray2 = new string[2];
        strArray1[0] = strArray2;
        string[] strArray3 = new string[2];
        strArray1[1] = strArray3;
        if (flag)
        {
          strArray1[0][0] = this.myPower.Requires.PowerIDNot[index1][0];
          strArray1[0][1] = this.myPower.Requires.PowerIDNot[index1][1];
          strArray1[1][0] = this.myPower.Requires.PowerIDNot[index2][0];
          strArray1[1][1] = this.myPower.Requires.PowerIDNot[index2][1];
          this.myPower.Requires.PowerIDNot[index1][0] = strArray1[1][0];
          this.myPower.Requires.PowerIDNot[index1][1] = strArray1[1][1];
          this.myPower.Requires.PowerIDNot[index2][0] = strArray1[0][0];
          this.myPower.Requires.PowerIDNot[index2][1] = strArray1[0][1];
          index2 = this.lvPrListing.SelectedIndices[0] - 1;
        }
        else
        {
          strArray1[0][0] = this.myPower.Requires.PowerID[index1][0];
          strArray1[0][1] = this.myPower.Requires.PowerID[index1][1];
          strArray1[1][0] = this.myPower.Requires.PowerID[index2][0];
          strArray1[1][1] = this.myPower.Requires.PowerID[index2][1];
          this.myPower.Requires.PowerID[index1][0] = strArray1[1][0];
          this.myPower.Requires.PowerID[index1][1] = strArray1[1][1];
          this.myPower.Requires.PowerID[index2][0] = strArray1[0][0];
          this.myPower.Requires.PowerID[index2][1] = strArray1[0][1];
        }
        this.FillTab_Req();
        this.lvPrListing.Items[index2].Selected = true;
        this.lvPrListing.Items[index2].EnsureVisible();
      }
    }

    private void btnSPAdd_Click(object sender, EventArgs e)
    {
      if (this.lvSPPower.SelectedItems.Count < 1)
        return;
      string b = Conversions.ToString(this.lvSPPower.SelectedItems[0].Tag);
      int num = this.myPower.UIDSubPower.Length - 1;
      for (int index = 0; index <= num; ++index)
      {
        if (string.Equals(this.myPower.UIDSubPower[index], b, StringComparison.OrdinalIgnoreCase))
          return;
      }
      IPower power = this.myPower;
      string[] strArray = (string[]) Utils.CopyArray((Array) power.UIDSubPower, (Array) new string[this.myPower.UIDSubPower.Length + 1]);
      power.UIDSubPower = strArray;
      this.myPower.UIDSubPower[this.myPower.UIDSubPower.Length - 1] = b;
      this.SPFillList();
      this.lvSPSelected.Items[this.lvSPSelected.Items.Count - 1].Selected = true;
      this.lvSPSelected.Items[this.lvSPSelected.Items.Count - 1].EnsureVisible();
    }

    private void btnSPRemove_Click(object sender, EventArgs e)
    {
      if (this.lvSPSelected.SelectedItems.Count < 1)
        return;
      string text = this.lvSPSelected.SelectedItems[0].Text;
      string[] strArray = new string[this.myPower.UIDSubPower.Length - 2 + 1];
      int index1 = 0;
      int num1 = this.myPower.UIDSubPower.Length - 1;
      for (int index2 = 0; index2 <= num1; ++index2)
      {
        if (!string.Equals(this.myPower.UIDSubPower[index2], text, StringComparison.OrdinalIgnoreCase))
        {
          strArray[index1] = this.myPower.UIDSubPower[index2];
          ++index1;
        }
      }
      this.myPower.UIDSubPower = new string[strArray.Length - 1 + 1];
      Array.Copy((Array) strArray, (Array) this.myPower.UIDSubPower, strArray.Length);
      this.SPFillList();
      int num2 = index1 - 1;
      if (num2 > this.lvSPSelected.Items.Count - 1)
      {
        int num3 = this.lvSPSelected.Items.Count - 1;
      }
      else if (num2 >= 0)
        ;
      this.SPFillList();
      if (this.lvSPSelected.Items.Count > 0)
      {
        this.lvSPSelected.Items[this.lvSPSelected.Items.Count - 1].Selected = true;
        this.lvSPSelected.Items[this.lvSPSelected.Items.Count - 1].EnsureVisible();
      }
    }

    private void cbEffectArea_SelectedIndexChanged(object sender, EventArgs e)
    {
      if (this.Updating)
        return;
      this.myPower.EffectArea = (Enums.eEffectArea) this.cbEffectArea.SelectedIndex;
    }

    private void cbForcedClass_SelectedIndexChanged(object sender, EventArgs e)
    {
      if (this.Updating)
        return;
      int index = this.cbForcedClass.SelectedIndex - 1;
      this.myPower.ForcedClass = !(index < 0 | index > DatabaseAPI.Database.Classes.Length - 1) ? DatabaseAPI.Database.Classes[index].ClassName : "";
    }

    private void cbNameGroup_Leave(object sender, EventArgs e)
    {
      if (this.Updating)
        return;
      this.DisplayNameData();
    }

    private void cbNameGroup_SelectedIndexChanged(object sender, EventArgs e)
    {
      if (this.Updating)
        return;
      this.myPower.GroupName = this.cbNameGroup.Text;
      this.SetFullName();
    }

    private void cbNameGroup_TextChanged(object sender, EventArgs e)
    {
      if (this.Updating)
        return;
      this.myPower.GroupName = this.cbNameGroup.Text;
      this.SetFullName();
    }

    private void cbNameSet_Leave(object sender, EventArgs e)
    {
      if (this.Updating)
        return;
      this.DisplayNameData();
    }

    private void cbNameSet_SelectedIndexChanged(object sender, EventArgs e)
    {
      if (this.Updating)
        return;
      this.myPower.SetName = this.cbNameSet.Text;
      this.SetFullName();
    }

    private void cbNameSet_TextChanged(object sender, EventArgs e)
    {
      if (this.Updating)
        return;
      this.myPower.SetName = this.cbNameSet.Text;
      this.SetFullName();
    }

    private void cbNotify_SelectedIndexChanged(object sender, EventArgs e)
    {
      if (this.Updating)
        return;
      this.myPower.AIReport = (Enums.eNotify) this.cbNotify.SelectedIndex;
    }

    private void cbPowerType_SelectedIndexChanged(object sender, EventArgs e)
    {
      if (this.Updating)
        return;
      this.myPower.PowerType = (Enums.ePowerType) this.cbPowerType.SelectedIndex;
    }

    public void CheckScaleValues()
    {
      if (Conversion.Val(this.udScaleMin.Text) >= Conversion.Val(this.udScaleMax.Text))
      {
        this.udScaleMin.BackColor = Color.Coral;
        this.udScaleMax.BackColor = Color.Coral;
      }
      else
      {
        this.udScaleMin.BackColor = SystemColors.Window;
        this.udScaleMax.BackColor = SystemColors.Window;
      }
    }

    private void chkAltSub_CheckedChanged(object sender, EventArgs e)
    {
      if (this.Updating)
        return;
      this.myPower.SubIsAltColour = this.chkAltSub.Checked;
    }

    private void chkAlwaysToggle_CheckedChanged(object sender, EventArgs e)
    {
      if (this.Updating)
        return;
      this.myPower.AlwaysToggle = this.chkAlwaysToggle.Checked;
    }

    private void chkBoostBoostable_CheckedChanged(object sender, EventArgs e)
    {
      if (this.Updating)
        return;
      this.myPower.BoostBoostable = this.chkPRFrontLoad.Checked;
    }

    private void chkBoostUsePlayerLevel_CheckedChanged(object sender, EventArgs e)
    {
      if (this.Updating)
        return;
      this.myPower.BoostUsePlayerLevel = this.chkPRFrontLoad.Checked;
    }

    private void chkBuffCycle_CheckedChanged(object sender, EventArgs e)
    {
      if (this.Updating)
        return;
      this.myPower.ClickBuff = this.chkBuffCycle.Checked;
    }

    private void chkGraphFix_CheckedChanged(object sender, EventArgs e)
    {
      if (this.Updating)
        return;
      this.myPower.SkipMax = this.chkGraphFix.Checked;
    }

    private void chkHidden_CheckedChanged(object sender, EventArgs e)
    {
      if (this.Updating)
        return;
      this.myPower.HiddenPower = this.chkHidden.Checked;
    }

    private void chkIgnoreStrength_CheckedChanged(object sender, EventArgs e)
    {
      if (this.Updating)
        return;
      this.myPower.IgnoreStrength = this.chkIgnoreStrength.Checked;
    }

    private void chkLos_CheckedChanged(object sender, EventArgs e)
    {
      if (this.Updating)
        return;
      this.myPower.TargetLoS = this.chkLos.Checked;
    }

    private void chkMutexAuto_CheckedChanged(object sender, EventArgs e)
    {
      if (this.Updating)
        return;
      this.myPower.MutexAuto = this.chkMutexAuto.Checked;
    }

    private void chkMutexSkip_CheckedChanged(object sender, EventArgs e)
    {
      if (this.Updating)
        return;
      this.myPower.MutexIgnore = this.chkMutexSkip.Checked;
    }

    private void chkNoAUReq_CheckedChanged(object sender, EventArgs e)
    {
      if (this.Updating)
        return;
      this.myPower.NeverAutoUpdateRequirements = this.chkNoAUReq.Checked;
    }

    private void chkNoAutoUpdate_CheckedChanged(object sender, EventArgs e)
    {
      if (this.Updating)
        return;
      this.myPower.NeverAutoUpdate = this.chkNoAutoUpdate.Checked;
    }

    private void chkPRFrontLoad_CheckedChanged(object sender, EventArgs e)
    {
      if (this.Updating)
        return;
      this.myPower.AllowFrontLoading = this.chkPRFrontLoad.Checked;
    }

    private void chkScale_CheckedChanged(object sender, EventArgs e)
    {
      if (this.Updating)
        return;
      if (!this.myPower.VariableEnabled)
      {
        this.udScaleMin.Value = new Decimal(0);
        this.udScaleMax.Value = this.myPower.MaxTargets <= 1 ? new Decimal(3) : new Decimal(this.myPower.MaxTargets);
      }
      this.myPower.VariableEnabled = this.chkScale.Checked;
      this.udScaleMax.Enabled = this.myPower.VariableEnabled;
      this.udScaleMin.Enabled = this.myPower.VariableEnabled;
      this.txtScaleName.Enabled = this.myPower.VariableEnabled;
    }

    private void chkSortOverride_CheckedChanged(object sender, EventArgs e)
    {
      if (this.Updating)
        return;
      this.myPower.SortOverride = this.chkSortOverride.Checked;
    }

    private void chkSubInclude_CheckedChanged(object sender, EventArgs e)
    {
      if (this.Updating)
        return;
      this.myPower.IncludeFlag = this.chkSubInclude.Checked;
    }

    private void chkSummonDisplayEntity_CheckedChanged(object sender, EventArgs e)
    {
      if (this.Updating)
        return;
      this.myPower.ShowSummonAnyway = this.chkSummonDisplayEntity.Checked;
    }

    private void chkSummonStealAttributes_CheckedChanged(object sender, EventArgs e)
    {
      if (this.Updating)
        return;
      this.myPower.AbsorbSummonAttributes = this.chkSummonStealAttributes.Checked;
    }

    private void chkSummonStealEffects_CheckedChanged(object sender, EventArgs e)
    {
      if (this.Updating)
        return;
      this.myPower.AbsorbSummonEffects = this.chkSummonStealEffects.Checked;
    }

    private void clbFlags_ItemCheck(object sender, ItemCheckEventArgs e)
    {
      if (this.Updating)
        return;
      if (this.rbFlagCastThrough.Checked)
      {
        if (e.Index == 0)
          this.myPower.CastThroughHold = e.NewValue > CheckState.Unchecked;
      }
      else
      {
        int[] numArray = new int[26];
        int num1 = 0;
        int num2 = 1;
        int num3 = numArray.Length - 1;
        for (int index = 1; index <= num3; ++index)
        {
          numArray[index] = num2;
          num2 *= 2;
        }
        if (this.rbFlagAutoHit.Checked)
          num1 = (int) this.myPower.EntitiesAutoHit;
        else if (this.rbFlagAffected.Checked)
          num1 = (int) this.myPower.EntitiesAffected;
        else if (this.rbFlagTargets.Checked)
          num1 = (int) this.myPower.Target;
        else if (this.rbFlagTargetsSec.Checked)
          num1 = (int) this.myPower.TargetSecondary;
        else if (this.rbFlagCast.Checked)
          num1 = (int) this.myPower.CastFlags;
        else if (this.rbFlagVector.Checked)
          num1 = (int) this.myPower.AttackTypes;
        else if (this.rbFlagRequired.Checked)
          num1 = (int) this.myPower.ModesRequired;
        else if (this.rbFlagDisallow.Checked)
          num1 = (int) this.myPower.ModesDisallowed;
        if (e.CurrentValue == CheckState.Unchecked & e.NewValue == CheckState.Checked)
          num1 += numArray[e.Index];
        else if (e.CurrentValue == CheckState.Checked & e.NewValue == CheckState.Unchecked)
          num1 -= numArray[e.Index];
        if (this.rbFlagAutoHit.Checked)
          this.myPower.EntitiesAutoHit = (Enums.eEntity) num1;
        else if (this.rbFlagAffected.Checked)
          this.myPower.EntitiesAffected = (Enums.eEntity) num1;
        else if (this.rbFlagTargets.Checked)
          this.myPower.Target = (Enums.eEntity) num1;
        else if (this.rbFlagTargetsSec.Checked)
          this.myPower.TargetSecondary = (Enums.eEntity) num1;
        else if (this.rbFlagCast.Checked)
          this.myPower.CastFlags = (Enums.eCastFlags) num1;
        else if (this.rbFlagVector.Checked)
          this.myPower.AttackTypes = (Enums.eVector) num1;
        else if (this.rbFlagRequired.Checked)
          this.myPower.ModesRequired = (Enums.eModeFlags) num1;
        else if (this.rbFlagDisallow.Checked)
          this.myPower.ModesDisallowed = (Enums.eModeFlags) num1;
      }
    }

    private void DisplayNameData()
    {
      IPower power = this.myPower;
      this.lblNameFull.Text = power.GroupName + "." + power.SetName + "." + power.PowerName;
      if (power.GroupName == "" | power.SetName == "" | power.PowerName == "")
        this.lblNameUnique.Text = "This name is invalid.";
      else if (frmEditPower.PowerFullNameIsUnique(Conversions.ToString(power.PowerIndex), -1))
        this.lblNameUnique.Text = "This name is unique.";
      else
        this.lblNameUnique.Text = "This name is NOT unique.";
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void DrawAcceptedSets()
    {
      this.bxSet = new ExtendedBitmap(this.pbInvSetUsed.Width, this.pbInvSetUsed.Height);
      int enhPadding1 = this.enhPadding;
      int enhPadding2 = this.enhPadding;
      Font font = new Font(this.Font, FontStyle.Bold);
      StringFormat format = new StringFormat(StringFormatFlags.NoWrap);
      SolidBrush solidBrush1 = new SolidBrush(Color.Black);
      SolidBrush solidBrush2 = new SolidBrush(Color.FromArgb(0, (int) byte.MaxValue, 0));
      format.Alignment = StringAlignment.Center;
      format.LineAlignment = StringAlignment.Center;
      this.bxSet.Graphics.FillRectangle((Brush) new SolidBrush(Color.FromArgb(0, 0, 0)), this.bxSet.ClipRect);
      int num = this.myPower.SetTypes.Length - 1;
      for (int index = 0; index <= num; ++index)
      {
        Rectangle destRect = new Rectangle(enhPadding2, enhPadding1, 30, 30);
        this.bxSet.Graphics.DrawImage((Image) I9Gfx.SetTypes.Bitmap, destRect, I9Gfx.GetImageRect((int) this.myPower.SetTypes[index]), GraphicsUnit.Pixel);
        string s;
        switch (this.myPower.SetTypes[index])
        {
          case Enums.eSetType.MeleeST:
            s = "M\r\nST";
            break;
          case Enums.eSetType.RangedST:
            s = "R\r\nST";
            break;
          case Enums.eSetType.RangedAoE:
            s = "R\r\nAoE";
            break;
          case Enums.eSetType.MeleeAoE:
            s = "M\r\nAoE";
            break;
          case Enums.eSetType.Snipe:
            s = "S";
            break;
          default:
            s = "";
            break;
        }
        RectangleF layoutRectangle = new RectangleF((float) destRect.X, (float) destRect.Y, (float) destRect.Width, (float) destRect.Height);
        --layoutRectangle.X;
        this.bxSet.Graphics.DrawString(s, font, (Brush) solidBrush1, layoutRectangle, format);
        --layoutRectangle.Y;
        this.bxSet.Graphics.DrawString(s, font, (Brush) solidBrush1, layoutRectangle, format);
        ++layoutRectangle.X;
        this.bxSet.Graphics.DrawString(s, font, (Brush) solidBrush1, layoutRectangle, format);
        ++layoutRectangle.X;
        this.bxSet.Graphics.DrawString(s, font, (Brush) solidBrush1, layoutRectangle, format);
        ++layoutRectangle.Y;
        this.bxSet.Graphics.DrawString(s, font, (Brush) solidBrush1, layoutRectangle, format);
        ++layoutRectangle.Y;
        this.bxSet.Graphics.DrawString(s, font, (Brush) solidBrush1, layoutRectangle, format);
        --layoutRectangle.X;
        this.bxSet.Graphics.DrawString(s, font, (Brush) solidBrush1, layoutRectangle, format);
        --layoutRectangle.X;
        this.bxSet.Graphics.DrawString(s, font, (Brush) solidBrush1, layoutRectangle, format);
        layoutRectangle = new RectangleF((float) destRect.X, (float) destRect.Y, (float) destRect.Width, (float) destRect.Height);
        this.bxSet.Graphics.DrawString(s, font, (Brush) solidBrush2, layoutRectangle, format);
        enhPadding2 += 30 + this.enhPadding;
      }
      this.pbInvSetUsed.CreateGraphics().DrawImageUnscaled((Image) this.bxSet.Bitmap, 0, 0);
    }

    private void DrawSetList()
    {
      Enums.eSetType eSetType = Enums.eSetType.Untyped;
      this.bxSetList = new ExtendedBitmap(this.pbInvSetList.Width, this.pbInvSetList.Height);
      int enhPadding1 = this.enhPadding;
      int enhPadding2 = this.enhPadding;
      int num1 = 0;
      Font font = new Font(this.Font, FontStyle.Bold);
      StringFormat format = new StringFormat(StringFormatFlags.NoWrap);
      SolidBrush solidBrush1 = new SolidBrush(Color.Black);
      SolidBrush solidBrush2 = new SolidBrush(Color.FromArgb(0, (int) byte.MaxValue, 0));
      format.Alignment = StringAlignment.Center;
      format.LineAlignment = StringAlignment.Center;
      string[] names = Enum.GetNames(eSetType.GetType());
      this.bxSetList.Graphics.FillRectangle((Brush) new SolidBrush(Color.FromArgb(0, 0, 0)), this.bxSetList.ClipRect);
      int num2 = names.Length - 1;
      for (int index = 0; index <= num2; ++index)
      {
        Rectangle destRect = new Rectangle(enhPadding2, enhPadding1, 30, 30);
        this.bxSetList.Graphics.DrawImage((Image) I9Gfx.SetTypes.Bitmap, destRect, I9Gfx.GetImageRect(index), GraphicsUnit.Pixel);
        string s;
        switch ((Enums.eSetType) index)
        {
          case Enums.eSetType.MeleeST:
            s = "M\r\nST";
            break;
          case Enums.eSetType.RangedST:
            s = "R\r\nST";
            break;
          case Enums.eSetType.RangedAoE:
            s = "R\r\nAoE";
            break;
          case Enums.eSetType.MeleeAoE:
            s = "M\r\nAoE";
            break;
          case Enums.eSetType.Snipe:
            s = "S";
            break;
          case Enums.eSetType.UniversalDamage:
            s = "Dmg";
            break;
          default:
            s = "";
            break;
        }
        RectangleF layoutRectangle = new RectangleF((float) destRect.X, (float) destRect.Y, (float) destRect.Width, (float) destRect.Height);
        --layoutRectangle.X;
        this.bxSetList.Graphics.DrawString(s, font, (Brush) solidBrush1, layoutRectangle, format);
        --layoutRectangle.Y;
        this.bxSetList.Graphics.DrawString(s, font, (Brush) solidBrush1, layoutRectangle, format);
        ++layoutRectangle.X;
        this.bxSetList.Graphics.DrawString(s, font, (Brush) solidBrush1, layoutRectangle, format);
        ++layoutRectangle.X;
        this.bxSetList.Graphics.DrawString(s, font, (Brush) solidBrush1, layoutRectangle, format);
        ++layoutRectangle.Y;
        this.bxSetList.Graphics.DrawString(s, font, (Brush) solidBrush1, layoutRectangle, format);
        ++layoutRectangle.Y;
        this.bxSetList.Graphics.DrawString(s, font, (Brush) solidBrush1, layoutRectangle, format);
        --layoutRectangle.X;
        this.bxSetList.Graphics.DrawString(s, font, (Brush) solidBrush1, layoutRectangle, format);
        --layoutRectangle.X;
        this.bxSetList.Graphics.DrawString(s, font, (Brush) solidBrush1, layoutRectangle, format);
        layoutRectangle = new RectangleF((float) destRect.X, (float) destRect.Y, (float) destRect.Width, (float) destRect.Height);
        this.bxSetList.Graphics.DrawString(s, font, (Brush) solidBrush2, layoutRectangle, format);
        enhPadding2 += 30 + this.enhPadding;
        ++num1;
        if (num1 == this.enhAcross)
        {
          num1 = 0;
          enhPadding2 = this.enhPadding;
          enhPadding1 += 30 + this.enhPadding;
        }
      }
      this.pbInvSetList.CreateGraphics().DrawImageUnscaled((Image) this.bxSetList.Bitmap, 0, 0);
    }

    private void FillAdvAtrList()
    {
      int num1 = 0;
      System.Type type = this.myPower.EntitiesAutoHit.GetType();
      bool flag = true;
      bool updating = this.Updating;
      this.Updating = true;
      this.clbFlags.BeginUpdate();
      this.clbFlags.Items.Clear();
      if (this.rbFlagAutoHit.Checked)
      {
        type = this.myPower.EntitiesAutoHit.GetType();
        num1 = (int) this.myPower.EntitiesAutoHit;
      }
      else if (this.rbFlagAffected.Checked)
      {
        type = this.myPower.EntitiesAffected.GetType();
        num1 = (int) this.myPower.EntitiesAffected;
      }
      else if (this.rbFlagTargets.Checked)
      {
        type = this.myPower.Target.GetType();
        num1 = (int) this.myPower.Target;
      }
      else if (this.rbFlagTargetsSec.Checked)
      {
        type = this.myPower.TargetSecondary.GetType();
        num1 = (int) this.myPower.TargetSecondary;
      }
      else if (this.rbFlagCast.Checked)
      {
        type = this.myPower.CastFlags.GetType();
        num1 = (int) this.myPower.CastFlags;
      }
      else if (this.rbFlagVector.Checked)
      {
        type = this.myPower.AttackTypes.GetType();
        num1 = (int) this.myPower.AttackTypes;
      }
      else if (this.rbFlagRequired.Checked)
      {
        type = this.myPower.ModesRequired.GetType();
        num1 = (int) this.myPower.ModesRequired;
      }
      else if (this.rbFlagDisallow.Checked)
      {
        type = this.myPower.ModesDisallowed.GetType();
        num1 = (int) this.myPower.ModesDisallowed;
      }
      else if (this.rbFlagCastThrough.Checked)
      {
        flag = false;
        this.clbFlags.Items.Add((object) "Mez", this.myPower.CastThroughHold);
      }
      if (flag)
      {
        string[] names = Enum.GetNames(type);
        int[] values = (int[]) Enum.GetValues(type);
        int num2 = values.Length - 1;
        for (int index = 0; index <= num2; ++index)
        {
          bool isChecked = (values[index] & num1) != 0;
          this.clbFlags.Items.Add((object) names[index], isChecked);
        }
      }
      this.clbFlags.EndUpdate();
      this.Updating = updating;
    }

    private void FillCombo_Attribs()
    {
      Enums.ePowerType ePowerType = Enums.ePowerType.Click;
      bool updating = this.Updating;
      this.Updating = true;
      this.cbEffectArea.BeginUpdate();
      this.cbNotify.BeginUpdate();
      this.cbPowerType.BeginUpdate();
      this.cbEffectArea.Items.Clear();
      this.cbNotify.Items.Clear();
      this.cbPowerType.Items.Clear();
      this.cbEffectArea.Items.AddRange((object[]) Enum.GetNames(this.myPower.EffectArea.GetType()));
      this.cbNotify.Items.AddRange((object[]) Enum.GetNames(this.myPower.AIReport.GetType()));
      string[] names = Enum.GetNames(ePowerType.GetType());
      int num = names.Length - 1;
      for (int index = 0; index <= num; ++index)
        names[index] = names[index].Replace("_", "");
      this.cbPowerType.Items.AddRange((object[]) names);
      this.cbEffectArea.EndUpdate();
      this.cbNotify.EndUpdate();
      this.cbPowerType.EndUpdate();
      this.Updating = updating;
    }

    private void FillCombo_Basic()
    {
      bool updating = this.Updating;
      this.Updating = true;
      this.cbNameGroup.BeginUpdate();
      this.cbNameGroup.Items.Clear();
      foreach (object key in (IEnumerable<string>) DatabaseAPI.Database.PowersetGroups.Keys)
        this.cbNameGroup.Items.Add(key);
      this.cbNameGroup.EndUpdate();
      this.cbNameSet.BeginUpdate();
      this.cbNameSet.Items.Clear();
      int[] indexesByGroupName = DatabaseAPI.GetPowersetIndexesByGroupName(this.myPower.GroupName);
      int num1 = indexesByGroupName.Length - 1;
      for (int index = 0; index <= num1; ++index)
        this.cbNameSet.Items.Add((object) DatabaseAPI.Database.Powersets[indexesByGroupName[index]].SetName);
      this.cbNameSet.EndUpdate();
      this.cbForcedClass.BeginUpdate();
      this.cbForcedClass.Items.Clear();
      this.cbForcedClass.Items.Add((object) "None");
      int num2 = DatabaseAPI.Database.Classes.Length - 1;
      for (int index = 0; index <= num2; ++index)
        this.cbForcedClass.Items.Add((object) DatabaseAPI.Database.Classes[index].ClassName);
      this.cbForcedClass.EndUpdate();
      this.Updating = updating;
    }

    private void FillComboBoxes()
    {
      Enums.eEnhance eEnhance = Enums.eEnhance.X_RechargeTime;
      this.lvDisablePass1.BeginUpdate();
      this.lvDisablePass1.Items.Clear();
      this.lvDisablePass1.Items.AddRange((object[]) Enum.GetNames(eEnhance.GetType()));
      this.lvDisablePass1.EndUpdate();
      this.lvDisablePass4.BeginUpdate();
      this.lvDisablePass4.Items.Clear();
      this.lvDisablePass4.Items.AddRange((object[]) Enum.GetNames(eEnhance.GetType()));
      this.lvDisablePass4.EndUpdate();
    }

    private void FillTab_Attribs()
    {
      IPower power = this.myPower;
      string Style = "##0" + NumberFormatInfo.CurrentInfo.NumberDecimalSeparator + "0###";
      this.txtLevel.Text = Conversions.ToString(power.Level);
      this.txtAcc.Text = Strings.Format((object) power.Accuracy, Style);
      this.txtInterrupt.Text = Strings.Format((object) power.InterruptTime, Style);
      this.txtCastTime.Text = Strings.Format((object) power.CastTimeReal, Style);
      this.txtRechargeTime.Text = Strings.Format((object) power.RechargeTime, Style);
      this.txtActivate.Text = Strings.Format((object) power.ActivatePeriod, Style);
      this.txtEndCost.Text = Strings.Format((object) power.EndCost, Style);
      this.txtRange.Text = Strings.Format((object) power.Range, Style);
      this.txtRangeSec.Text = Strings.Format((object) power.RangeSecondary, Style);
      this.txtRadius.Text = Conversions.ToString(power.Radius);
      this.txtArc.Text = Conversions.ToString(power.Arc);
      this.txtMaxTargets.Text = Conversions.ToString(power.MaxTargets);
      this.cbPowerType.SelectedIndex = (int) power.PowerType;
      this.cbEffectArea.SelectedIndex = (int) power.EffectArea;
      this.cbNotify.SelectedIndex = (int) power.AIReport;
      this.chkLos.Checked = power.TargetLoS;
      this.chkIgnoreStrength.Checked = power.IgnoreStrength;
      this.txtNumCharges.Text = Conversions.ToString(power.NumCharges);
      this.txtUseageTime.Text = Conversions.ToString(power.UsageTime);
      this.txtLifeTimeGame.Text = Conversions.ToString(power.LifeTimeInGame);
      this.txtLifeTimeReal.Text = Conversions.ToString(power.LifeTime);
      this.rbFlagAutoHit.Checked = true;
      this.FillAdvAtrList();
    }

    private void FillTab_Basic()
    {
      IPower power = this.myPower;
      this.txtNameDisplay.Text = power.DisplayName;
      this.txtNamePower.Text = power.PowerName;
      this.cbNameGroup.Text = power.GroupName;
      this.cbNameSet.Text = power.SetName;
      this.DisplayNameData();
      this.txtDescLong.Text = power.DescLong;
      this.txtDescShort.Text = power.DescShort;
      this.udScaleMin.Value = new Decimal(power.VariableMin);
      this.udScaleMax.Value = new Decimal(power.VariableMax);
      this.txtScaleName.Text = power.VariableName;
      this.chkScale.Checked = power.VariableEnabled;
      this.chkBuffCycle.Checked = power.ClickBuff;
      this.chkAlwaysToggle.Checked = power.AlwaysToggle;
      this.chkGraphFix.Checked = this.myPower.SkipMax;
      this.chkAltSub.Checked = power.SubIsAltColour;
      this.chkSubInclude.Checked = power.IncludeFlag;
      this.chkSortOverride.Checked = power.SortOverride;
      this.txtVisualLocation.Text = Conversions.ToString(power.DisplayLocation);
      this.chkSummonStealEffects.Checked = power.AbsorbSummonEffects;
      this.chkSummonStealAttributes.Checked = power.AbsorbSummonAttributes;
      this.chkSummonDisplayEntity.Checked = power.ShowSummonAnyway;
      this.chkNoAUReq.Checked = this.myPower.NeverAutoUpdateRequirements;
      this.cbForcedClass.SelectedIndex = DatabaseAPI.NidFromUidClass(power.ForcedClass) + 1;
      this.chkNoAutoUpdate.Checked = this.myPower.NeverAutoUpdate;
      this.chkHidden.Visible = MidsContext.Config.MasterMode;
      this.chkHidden.Checked = this.myPower.HiddenPower;
    }

    private void FillTab_Disabling()
    {
      int num1 = this.myPower.IgnoreEnh.Length - 1;
      for (int index = 0; index <= num1; ++index)
      {
        if (this.myPower.IgnoreEnh[index] <= (Enums.eEnhance) (this.lvDisablePass1.Items.Count - 1))
          this.lvDisablePass1.SetSelected((int) this.myPower.IgnoreEnh[index], true);
      }
      int num2 = this.myPower.Ignore_Buff.Length - 1;
      for (int index = 0; index <= num2; ++index)
      {
        if (this.myPower.Ignore_Buff[index] <= (Enums.eEnhance) (this.lvDisablePass4.Items.Count - 1))
          this.lvDisablePass4.SetSelected((int) this.myPower.Ignore_Buff[index], true);
      }
    }

    private void FillTab_Effects()
    {
      this.RefreshFXData(0);
    }

    private void FillTab_Enhancements()
    {
      this.RedrawEnhList();
      this.chkPRFrontLoad.Checked = this.myPower.AllowFrontLoading;
      this.chkBoostBoostable.Checked = this.myPower.BoostBoostable;
      this.chkBoostUsePlayerLevel.Checked = this.myPower.BoostUsePlayerLevel;
    }

    private void FillTab_Mutex()
    {
      this.chkMutexAuto.Checked = this.myPower.MutexAuto;
      this.chkMutexSkip.Checked = this.myPower.MutexIgnore;
      this.clbMutex.BeginUpdate();
      this.clbMutex.Items.Clear();
      string[] strArray = DatabaseAPI.UidMutexAll();
      int num1 = strArray.Length - 1;
      for (int index1 = 0; index1 <= num1; ++index1)
      {
        bool isChecked = false;
        int num2 = this.myPower.GroupMembership.Length - 1;
        for (int index2 = 0; index2 <= num2; ++index2)
        {
          if (string.Equals(strArray[index1], this.myPower.GroupMembership[index2], StringComparison.OrdinalIgnoreCase))
          {
            isChecked = true;
            break;
          }
        }
        this.clbMutex.Items.Add((object) strArray[index1], isChecked);
      }
      this.clbMutex.EndUpdate();
    }

    private void FillTab_Req()
    {
      this.ReqChanging = true;
      this.lvPrListing.BeginUpdate();
      this.lvPrListing.Items.Clear();
      int num1 = this.myPower.Requires.PowerID.Length - 1;
      for (int index = 0; index <= num1; ++index)
      {
        string[] items = new string[3];
        if (this.myPower.Requires.PowerID[index].Length > 0)
        {
          items[0] = this.myPower.Requires.PowerID[index][0];
          if (this.myPower.Requires.PowerID[index][1] != "")
          {
            items[1] = "AND";
            items[2] = this.myPower.Requires.PowerID[index][1];
          }
          this.lvPrListing.Items.Add(new ListViewItem(items)
          {
            Tag = (object) index
          });
        }
      }
      int num2 = this.myPower.Requires.PowerIDNot.Length - 1;
      for (int index = 0; index <= num2; ++index)
      {
        string[] items = new string[3];
        if (this.myPower.Requires.PowerIDNot[index].Length > 0)
        {
          items[0] = "NOT " + this.myPower.Requires.PowerIDNot[index][0];
          if (this.myPower.Requires.PowerIDNot[index][1] != "")
          {
            items[1] = "AND";
            items[2] = "NOT " + this.myPower.Requires.PowerIDNot[index][1];
          }
          this.lvPrListing.Items.Add(new ListViewItem(items)
          {
            Tag = (object) index
          });
        }
      }
      this.lvPrListing.EndUpdate();
      this.ReqChanging = false;
      if (this.lvPrListing.Items.Count <= 0)
        return;
      this.lvPrListing.Items[0].Selected = true;
    }

    private void Filltab_ReqClasses()
    {
      this.clbClassReq.BeginUpdate();
      this.clbClassReq.Items.Clear();
      int num1 = DatabaseAPI.Database.Classes.Length - 1;
      for (int index1 = 0; index1 <= num1; ++index1)
      {
        bool isChecked = false;
        int num2 = this.myPower.Requires.ClassName.Length - 1;
        for (int index2 = 0; index2 <= num2; ++index2)
        {
          if (string.Equals(DatabaseAPI.Database.Classes[index1].ClassName, this.myPower.Requires.ClassName[index2], StringComparison.OrdinalIgnoreCase))
            isChecked = true;
        }
        this.clbClassReq.Items.Add((object) DatabaseAPI.Database.Classes[index1].ClassName, isChecked);
      }
      this.clbClassReq.EndUpdate();
      this.clbClassExclude.BeginUpdate();
      this.clbClassExclude.Items.Clear();
      int num3 = DatabaseAPI.Database.Classes.Length - 1;
      for (int index1 = 0; index1 <= num3; ++index1)
      {
        bool isChecked = false;
        int num2 = this.myPower.Requires.ClassNameNot.Length - 1;
        for (int index2 = 0; index2 <= num2; ++index2)
        {
          if (string.Equals(DatabaseAPI.Database.Classes[index1].ClassName, this.myPower.Requires.ClassNameNot[index2], StringComparison.OrdinalIgnoreCase))
            isChecked = true;
        }
        this.clbClassExclude.Items.Add((object) DatabaseAPI.Database.Classes[index1].ClassName, isChecked);
      }
      this.clbClassExclude.EndUpdate();
    }

    private void FillTab_Sets()
    {
      this.DrawAcceptedSets();
    }

    private void FillTab_SubPowers()
    {
      bool reqChanging = this.ReqChanging;
      this.ReqChanging = true;
      this.SP_GroupList();
      if (this.lvSPGroup.Items.Count > 0)
        this.lvSPGroup.Items[0].Selected = true;
      this.SP_SetList();
      if (this.lvSPSet.Items.Count > 0)
        this.lvSPSet.Items[0].Selected = true;
      this.SP_PowerList();
      this.ReqChanging = reqChanging;
      this.SPFillList();
    }

    private void frmEditPower_Load(object sender, EventArgs e)
    {
      this.RedrawEnhPicker();
      this.FillComboBoxes();
      this.DrawSetList();
      this.Req_GroupList();
      this.FillTab_SubPowers();
      this.refresh_PowerData();
      this.Updating = false;
    }

    private static int GetClassByID(int iID)
    {
      int num = DatabaseAPI.Database.EnhancementClasses.Length - 1;
      for (int index = 0; index <= num; ++index)
      {
        if (DatabaseAPI.Database.EnhancementClasses[index].ID == iID)
          return index;
      }
      return 0;
    }

    private int GetInvSetIndex(Point e)
    {
      int num1 = -1;
      int num2 = -1;
      int num3 = 0;
      do
      {
        if (e.X > (this.enhPadding + 30) * num3 & e.X < (this.enhPadding + 30) * (num3 + 1))
          num1 = num3;
        ++num3;
      }
      while (num3 <= 9);
      int num4 = 0;
      do
      {
        if (e.Y > (this.enhPadding + 30) * num4 & e.Y < (this.enhPadding + 30) * (num4 + 1))
          num2 = num4;
        ++num4;
      }
      while (num4 <= 10);
      return num1 + num2 * 10;
    }

    private int GetInvSetListIndex(Point e)
    {
      int num1 = -1;
      int num2 = -1;
      int num3 = this.enhAcross - 1;
      for (int index = 0; index <= num3; ++index)
      {
        if (e.X > (this.enhPadding + 30) * index & e.X < (this.enhPadding + 30) * (index + 1))
          num1 = index;
      }
      int num4 = 0;
      do
      {
        if (e.Y > (this.enhPadding + 30) * num4 & e.Y < (this.enhPadding + 30) * (num4 + 1))
          num2 = num4;
        ++num4;
      }
      while (num4 <= 10);
      return num1 + num2 * this.enhAcross;
    }

    [DebuggerStepThrough]
    private void InitializeComponent()
    {
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (frmEditPower));
      this.tcPower = new TabControl();
      this.tpText = new TabPage();
      this.chkNoAUReq = new CheckBox();
      this.chkNoAutoUpdate = new CheckBox();
      this.GroupBox4 = new GroupBox();
      this.chkSortOverride = new CheckBox();
      this.chkSubInclude = new CheckBox();
      this.chkAlwaysToggle = new CheckBox();
      this.chkBuffCycle = new CheckBox();
      this.chkGraphFix = new CheckBox();
      this.chkAltSub = new CheckBox();
      this.Label21 = new Label();
      this.txtVisualLocation = new TextBox();
      this.GroupBox7 = new GroupBox();
      this.cbForcedClass = new ComboBox();
      this.Label29 = new Label();
      this.GroupBox6 = new GroupBox();
      this.chkSummonDisplayEntity = new CheckBox();
      this.chkSummonStealAttributes = new CheckBox();
      this.chkSummonStealEffects = new CheckBox();
      this.GroupBox5 = new GroupBox();
      this.txtDescLong = new TextBox();
      this.txtDescShort = new TextBox();
      this.Label2 = new Label();
      this.Label3 = new Label();
      this.GroupBox3 = new GroupBox();
      this.Label28 = new Label();
      this.udScaleMax = new NumericUpDown();
      this.Label27 = new Label();
      this.udScaleMin = new NumericUpDown();
      this.Label26 = new Label();
      this.txtScaleName = new TextBox();
      this.chkScale = new CheckBox();
      this.GroupBox1 = new GroupBox();
      this.lblStaticIndex = new Label();
      this.chkHidden = new CheckBox();
      this.lblNameUnique = new Label();
      this.Label1 = new Label();
      this.lblNameFull = new Label();
      this.cbNameSet = new ComboBox();
      this.txtNameDisplay = new TextBox();
      this.cbNameGroup = new ComboBox();
      this.Label22 = new Label();
      this.Label31 = new Label();
      this.txtNamePower = new TextBox();
      this.Label33 = new Label();
      this.tpBasic = new TabPage();
      this.Label46 = new Label();
      this.Label47 = new Label();
      this.txtLifeTimeReal = new TextBox();
      this.Label44 = new Label();
      this.Label45 = new Label();
      this.txtLifeTimeGame = new TextBox();
      this.Label42 = new Label();
      this.Label43 = new Label();
      this.txtUseageTime = new TextBox();
      this.Label41 = new Label();
      this.txtNumCharges = new TextBox();
      this.chkIgnoreStrength = new CheckBox();
      this.Label12 = new Label();
      this.Label17 = new Label();
      this.txtRangeSec = new TextBox();
      this.Label18 = new Label();
      this.GroupBox9 = new GroupBox();
      this.rbFlagCastThrough = new RadioButton();
      this.rbFlagDisallow = new RadioButton();
      this.rbFlagRequired = new RadioButton();
      this.rbFlagVector = new RadioButton();
      this.rbFlagCast = new RadioButton();
      this.clbFlags = new CheckedListBox();
      this.rbFlagTargetsSec = new RadioButton();
      this.rbFlagTargets = new RadioButton();
      this.rbFlagAffected = new RadioButton();
      this.rbFlagAutoHit = new RadioButton();
      this.cbNotify = new ComboBox();
      this.chkLos = new CheckBox();
      this.txtMaxTargets = new TextBox();
      this.lblEndCost = new Label();
      this.Label20 = new Label();
      this.lblAcc = new Label();
      this.Label40 = new Label();
      this.Label39 = new Label();
      this.Label38 = new Label();
      this.Label37 = new Label();
      this.Label36 = new Label();
      this.Label35 = new Label();
      this.Label34 = new Label();
      this.Label16 = new Label();
      this.txtArc = new TextBox();
      this.Label15 = new Label();
      this.txtRadius = new TextBox();
      this.txtLevel = new TextBox();
      this.cbEffectArea = new ComboBox();
      this.Label14 = new Label();
      this.Label13 = new Label();
      this.txtEndCost = new TextBox();
      this.Label10 = new Label();
      this.txtActivate = new TextBox();
      this.Label11 = new Label();
      this.txtRechargeTime = new TextBox();
      this.Label8 = new Label();
      this.txtCastTime = new TextBox();
      this.Label9 = new Label();
      this.txtInterrupt = new TextBox();
      this.Label7 = new Label();
      this.txtRange = new TextBox();
      this.Label6 = new Label();
      this.txtAcc = new TextBox();
      this.cbPowerType = new ComboBox();
      this.Label5 = new Label();
      this.Label4 = new Label();
      this.tpEffects = new TabPage();
      this.lvFX = new ListBox();
      this.pnlFX = new Panel();
      this.btnSetDamage = new Button();
      this.btnFXEdit = new Button();
      this.btnFXDown = new Button();
      this.btnFXUp = new Button();
      this.btnFXRemove = new Button();
      this.btnFXDuplicate = new Button();
      this.btnFXAdd = new Button();
      this.tpEnh = new TabPage();
      this.chkBoostUsePlayerLevel = new CheckBox();
      this.chkBoostBoostable = new CheckBox();
      this.Label23 = new Label();
      this.pbEnhancements = new PictureBox();
      this.chkPRFrontLoad = new CheckBox();
      this.pbEnhancementList = new PictureBox();
      this.lblEnhName = new Label();
      this.tpSets = new TabPage();
      this.Label24 = new Label();
      this.lblInvSet = new Label();
      this.pbInvSetList = new PictureBox();
      this.pbInvSetUsed = new PictureBox();
      this.tpPreReq = new TabPage();
      this.GroupBox11 = new GroupBox();
      this.btnPrReset = new Button();
      this.btnPrSetNone = new Button();
      this.btnPrDown = new Button();
      this.btnPrUp = new Button();
      this.rbPrRemove = new Button();
      this.rbPrAdd = new Button();
      this.rbPrPowerB = new RadioButton();
      this.rbPrPowerA = new RadioButton();
      this.lvPrPower = new ListView();
      this.ColumnHeader9 = new ColumnHeader();
      this.lvPrSet = new ListView();
      this.ColumnHeader10 = new ColumnHeader();
      this.lvPrGroup = new ListView();
      this.ColumnHeader11 = new ColumnHeader();
      this.lvPrListing = new ListView();
      this.ColumnHeader6 = new ColumnHeader();
      this.ColumnHeader7 = new ColumnHeader();
      this.ColumnHeader8 = new ColumnHeader();
      this.GroupBox10 = new GroupBox();
      this.clbClassExclude = new CheckedListBox();
      this.GroupBox8 = new GroupBox();
      this.clbClassReq = new CheckedListBox();
      this.tpSpecialEnh = new TabPage();
      this.Label32 = new Label();
      this.Label30 = new Label();
      this.lvDisablePass4 = new ListBox();
      this.lvDisablePass1 = new ListBox();
      this.tpMutex = new TabPage();
      this.GroupBox2 = new GroupBox();
      this.btnMutexAdd = new Button();
      this.clbMutex = new CheckedListBox();
      this.chkMutexAuto = new CheckBox();
      this.chkMutexSkip = new CheckBox();
      this.tpSubPower = new TabPage();
      this.btnSPAdd = new Button();
      this.btnSPRemove = new Button();
      this.lvSPSelected = new ListView();
      this.ColumnHeader4 = new ColumnHeader();
      this.lvSPPower = new ListView();
      this.ColumnHeader1 = new ColumnHeader();
      this.lvSPSet = new ListView();
      this.ColumnHeader2 = new ColumnHeader();
      this.lvSPGroup = new ListView();
      this.ColumnHeader3 = new ColumnHeader();
      this.btnOK = new Button();
      this.btnCancel = new Button();
      this.btnFullPaste = new Button();
      this.btnFullCopy = new Button();
      this.btnCSVImport = new Button();
      this.tcPower.SuspendLayout();
      this.tpText.SuspendLayout();
      this.GroupBox4.SuspendLayout();
      this.GroupBox7.SuspendLayout();
      this.GroupBox6.SuspendLayout();
      this.GroupBox5.SuspendLayout();
      this.GroupBox3.SuspendLayout();
      this.udScaleMax.BeginInit();
      this.udScaleMin.BeginInit();
      this.GroupBox1.SuspendLayout();
      this.tpBasic.SuspendLayout();
      this.GroupBox9.SuspendLayout();
      this.tpEffects.SuspendLayout();
      this.pnlFX.SuspendLayout();
      this.tpEnh.SuspendLayout();
      ((ISupportInitialize) this.pbEnhancements).BeginInit();
      ((ISupportInitialize) this.pbEnhancementList).BeginInit();
      this.tpSets.SuspendLayout();
      ((ISupportInitialize) this.pbInvSetList).BeginInit();
      ((ISupportInitialize) this.pbInvSetUsed).BeginInit();
      this.tpPreReq.SuspendLayout();
      this.GroupBox11.SuspendLayout();
      this.GroupBox10.SuspendLayout();
      this.GroupBox8.SuspendLayout();
      this.tpSpecialEnh.SuspendLayout();
      this.tpMutex.SuspendLayout();
      this.GroupBox2.SuspendLayout();
      this.tpSubPower.SuspendLayout();
      this.SuspendLayout();
      this.tcPower.Controls.Add((Control) this.tpText);
      this.tcPower.Controls.Add((Control) this.tpBasic);
      this.tcPower.Controls.Add((Control) this.tpEffects);
      this.tcPower.Controls.Add((Control) this.tpEnh);
      this.tcPower.Controls.Add((Control) this.tpSets);
      this.tcPower.Controls.Add((Control) this.tpPreReq);
      this.tcPower.Controls.Add((Control) this.tpSpecialEnh);
      this.tcPower.Controls.Add((Control) this.tpMutex);
      this.tcPower.Controls.Add((Control) this.tpSubPower);
      Point point = new Point(8, 8);
      this.tcPower.Location = point;
      this.tcPower.Name = "tcPower";
      this.tcPower.SelectedIndex = 0;
      Size size = new Size(840, 364);
      this.tcPower.Size = size;
      this.tcPower.TabIndex = 2;
      this.tpText.Controls.Add((Control) this.chkNoAUReq);
      this.tpText.Controls.Add((Control) this.chkNoAutoUpdate);
      this.tpText.Controls.Add((Control) this.GroupBox4);
      this.tpText.Controls.Add((Control) this.GroupBox7);
      this.tpText.Controls.Add((Control) this.GroupBox6);
      this.tpText.Controls.Add((Control) this.GroupBox5);
      this.tpText.Controls.Add((Control) this.GroupBox3);
      this.tpText.Controls.Add((Control) this.GroupBox1);
      point = new Point(4, 23);
      this.tpText.Location = point;
      this.tpText.Name = "tpText";
      size = new Size(832, 337);
      this.tpText.Size = size;
      this.tpText.TabIndex = 2;
      this.tpText.Text = "Basic";
      this.tpText.UseVisualStyleBackColor = true;
      point = new Point(332, 293);
      this.chkNoAUReq.Location = point;
      this.chkNoAUReq.Name = "chkNoAUReq";
      size = new Size(269, 33);
      this.chkNoAUReq.Size = size;
      this.chkNoAUReq.TabIndex = 46;
      this.chkNoAUReq.Text = "Do not automatically update this power's requirements";
      this.chkNoAUReq.UseVisualStyleBackColor = true;
      point = new Point(13, 306);
      this.chkNoAutoUpdate.Location = point;
      this.chkNoAutoUpdate.Name = "chkNoAutoUpdate";
      size = new Size(313, 20);
      this.chkNoAutoUpdate.Size = size;
      this.chkNoAutoUpdate.TabIndex = 23;
      this.chkNoAutoUpdate.Text = "Do not automatically update this power during bulk-imports";
      this.chkNoAutoUpdate.UseVisualStyleBackColor = true;
      this.GroupBox4.Controls.Add((Control) this.chkSortOverride);
      this.GroupBox4.Controls.Add((Control) this.chkSubInclude);
      this.GroupBox4.Controls.Add((Control) this.chkAlwaysToggle);
      this.GroupBox4.Controls.Add((Control) this.chkBuffCycle);
      this.GroupBox4.Controls.Add((Control) this.chkGraphFix);
      this.GroupBox4.Controls.Add((Control) this.chkAltSub);
      this.GroupBox4.Controls.Add((Control) this.Label21);
      this.GroupBox4.Controls.Add((Control) this.txtVisualLocation);
      point = new Point(607, 115);
      this.GroupBox4.Location = point;
      this.GroupBox4.Name = "GroupBox4";
      size = new Size(214, 211);
      this.GroupBox4.Size = size;
      this.GroupBox4.TabIndex = 45;
      this.GroupBox4.TabStop = false;
      this.GroupBox4.Text = "MxD Special Flags";
      point = new Point(6, 96);
      this.chkSortOverride.Location = point;
      this.chkSortOverride.Name = "chkSortOverride";
      size = new Size(184, 22);
      this.chkSortOverride.Size = size;
      this.chkSortOverride.TabIndex = 42;
      this.chkSortOverride.Text = "Priority Sort Order";
      this.chkSortOverride.UseVisualStyleBackColor = true;
      point = new Point(6, 152);
      this.chkSubInclude.Location = point;
      this.chkSubInclude.Name = "chkSubInclude";
      size = new Size(153, 20);
      this.chkSubInclude.Size = size;
      this.chkSubInclude.TabIndex = 4;
      this.chkSubInclude.Text = "Sub-Power Include Flag";
      this.chkSubInclude.UseVisualStyleBackColor = true;
      point = new Point(6, 42);
      this.chkAlwaysToggle.Location = point;
      this.chkAlwaysToggle.Name = "chkAlwaysToggle";
      size = new Size(168, 20);
      this.chkAlwaysToggle.Size = size;
      this.chkAlwaysToggle.TabIndex = 1;
      this.chkAlwaysToggle.Text = "Toggle Defaults to ON";
      point = new Point(6, 16);
      this.chkBuffCycle.Location = point;
      this.chkBuffCycle.Name = "chkBuffCycle";
      size = new Size(168, 20);
      this.chkBuffCycle.Size = size;
      this.chkBuffCycle.TabIndex = 0;
      this.chkBuffCycle.Text = "Power is a Click-Buff";
      point = new Point(6, 68);
      this.chkGraphFix.Location = point;
      this.chkGraphFix.Name = "chkGraphFix";
      size = new Size(184, 22);
      this.chkGraphFix.Size = size;
      this.chkGraphFix.TabIndex = 2;
      this.chkGraphFix.Text = "Ignore when setting graph scale";
      this.chkGraphFix.UseVisualStyleBackColor = true;
      point = new Point(6, 124);
      this.chkAltSub.Location = point;
      this.chkAltSub.Name = "chkAltSub";
      size = new Size(183, 22);
      this.chkAltSub.Size = size;
      this.chkAltSub.TabIndex = 3;
      this.chkAltSub.Text = "Sub-Power Colour Flag (ToDo)";
      this.chkAltSub.UseVisualStyleBackColor = true;
      point = new Point(21, 178);
      this.Label21.Location = point;
      this.Label21.Name = "Label21";
      size = new Size(88, 20);
      this.Label21.Size = size;
      this.Label21.TabIndex = 41;
      this.Label21.Text = "Inherent Index:";
      this.Label21.TextAlign = ContentAlignment.MiddleRight;
      point = new Point(113, 178);
      this.txtVisualLocation.Location = point;
      this.txtVisualLocation.Name = "txtVisualLocation";
      size = new Size(76, 20);
      this.txtVisualLocation.Size = size;
      this.txtVisualLocation.TabIndex = 5;
      this.txtVisualLocation.Text = "0";
      this.GroupBox7.Controls.Add((Control) this.cbForcedClass);
      this.GroupBox7.Controls.Add((Control) this.Label29);
      point = new Point(332, 211);
      this.GroupBox7.Location = point;
      this.GroupBox7.Name = "GroupBox7";
      size = new Size(269, 74);
      this.GroupBox7.Size = size;
      this.GroupBox7.TabIndex = 22;
      this.GroupBox7.TabStop = false;
      this.GroupBox7.Text = "Forced Class";
      this.cbForcedClass.DropDownStyle = ComboBoxStyle.DropDownList;
      this.cbForcedClass.FormattingEnabled = true;
      point = new Point(88, 30);
      this.cbForcedClass.Location = point;
      this.cbForcedClass.Name = "cbForcedClass";
      size = new Size(175, 22);
      this.cbForcedClass.Size = size;
      this.cbForcedClass.TabIndex = 0;
      point = new Point(7, 30);
      this.Label29.Location = point;
      this.Label29.Name = "Label29";
      size = new Size(77, 20);
      this.Label29.Size = size;
      this.Label29.TabIndex = 18;
      this.Label29.Text = "Class Name:";
      this.Label29.TextAlign = ContentAlignment.MiddleRight;
      this.GroupBox6.Controls.Add((Control) this.chkSummonDisplayEntity);
      this.GroupBox6.Controls.Add((Control) this.chkSummonStealAttributes);
      this.GroupBox6.Controls.Add((Control) this.chkSummonStealEffects);
      point = new Point(332, 115);
      this.GroupBox6.Location = point;
      this.GroupBox6.Name = "GroupBox6";
      size = new Size(269, 90);
      this.GroupBox6.Size = size;
      this.GroupBox6.TabIndex = 21;
      this.GroupBox6.TabStop = false;
      this.GroupBox6.Text = "Summon Handling";
      point = new Point(6, 68);
      this.chkSummonDisplayEntity.Location = point;
      this.chkSummonDisplayEntity.Name = "chkSummonDisplayEntity";
      size = new Size(257, 20);
      this.chkSummonDisplayEntity.Size = size;
      this.chkSummonDisplayEntity.TabIndex = 2;
      this.chkSummonDisplayEntity.Text = "Display entity even if absorbed";
      this.chkSummonDisplayEntity.UseVisualStyleBackColor = true;
      point = new Point(6, 42);
      this.chkSummonStealAttributes.Location = point;
      this.chkSummonStealAttributes.Name = "chkSummonStealAttributes";
      size = new Size(257, 20);
      this.chkSummonStealAttributes.Size = size;
      this.chkSummonStealAttributes.TabIndex = 1;
      this.chkSummonStealAttributes.Text = "Power absorbs summoned entity's attributes\r\n";
      this.chkSummonStealAttributes.UseVisualStyleBackColor = true;
      point = new Point(6, 16);
      this.chkSummonStealEffects.Location = point;
      this.chkSummonStealEffects.Name = "chkSummonStealEffects";
      size = new Size(257, 20);
      this.chkSummonStealEffects.Size = size;
      this.chkSummonStealEffects.TabIndex = 0;
      this.chkSummonStealEffects.Text = "Power absorbs summoned entity's effects";
      this.chkSummonStealEffects.UseVisualStyleBackColor = true;
      this.GroupBox5.Controls.Add((Control) this.txtDescLong);
      this.GroupBox5.Controls.Add((Control) this.txtDescShort);
      this.GroupBox5.Controls.Add((Control) this.Label2);
      this.GroupBox5.Controls.Add((Control) this.Label3);
      point = new Point(332, 3);
      this.GroupBox5.Location = point;
      this.GroupBox5.Name = "GroupBox5";
      size = new Size(489, 106);
      this.GroupBox5.Size = size;
      this.GroupBox5.TabIndex = 20;
      this.GroupBox5.TabStop = false;
      this.GroupBox5.Text = "Descriptions";
      point = new Point(58, 42);
      this.txtDescLong.Location = point;
      this.txtDescLong.Multiline = true;
      this.txtDescLong.Name = "txtDescLong";
      this.txtDescLong.ScrollBars = ScrollBars.Vertical;
      size = new Size(425, 57);
      this.txtDescLong.Size = size;
      this.txtDescLong.TabIndex = 1;
      this.txtDescLong.Text = "Power Desc Long";
      point = new Point(58, 16);
      this.txtDescShort.Location = point;
      this.txtDescShort.Name = "txtDescShort";
      size = new Size(425, 20);
      this.txtDescShort.Size = size;
      this.txtDescShort.TabIndex = 0;
      this.txtDescShort.Text = "Power Desc Short";
      point = new Point(6, 16);
      this.Label2.Location = point;
      this.Label2.Name = "Label2";
      size = new Size(48, 20);
      this.Label2.Size = size;
      this.Label2.TabIndex = 3;
      this.Label2.Text = "Short:";
      this.Label2.TextAlign = ContentAlignment.MiddleRight;
      point = new Point(6, 42);
      this.Label3.Location = point;
      this.Label3.Name = "Label3";
      size = new Size(48, 20);
      this.Label3.Size = size;
      this.Label3.TabIndex = 5;
      this.Label3.Text = "Long";
      this.Label3.TextAlign = ContentAlignment.MiddleRight;
      this.GroupBox3.Controls.Add((Control) this.Label28);
      this.GroupBox3.Controls.Add((Control) this.udScaleMax);
      this.GroupBox3.Controls.Add((Control) this.Label27);
      this.GroupBox3.Controls.Add((Control) this.udScaleMin);
      this.GroupBox3.Controls.Add((Control) this.Label26);
      this.GroupBox3.Controls.Add((Control) this.txtScaleName);
      this.GroupBox3.Controls.Add((Control) this.chkScale);
      point = new Point(13, 199);
      this.GroupBox3.Location = point;
      this.GroupBox3.Name = "GroupBox3";
      size = new Size(313, 101);
      this.GroupBox3.Size = size;
      this.GroupBox3.TabIndex = 8;
      this.GroupBox3.TabStop = false;
      this.GroupBox3.Text = "Power Scaling";
      point = new Point(181, 72);
      this.Label28.Location = point;
      this.Label28.Name = "Label28";
      size = new Size(52, 20);
      this.Label28.Size = size;
      this.Label28.TabIndex = 7;
      this.Label28.Text = "To";
      this.Label28.TextAlign = ContentAlignment.MiddleCenter;
      point = new Point(239, 72);
      this.udScaleMax.Location = point;
      this.udScaleMax.Name = "udScaleMax";
      size = new Size(63, 20);
      this.udScaleMax.Size = size;
      this.udScaleMax.TabIndex = 3;
      point = new Point(5, 72);
      this.Label27.Location = point;
      this.Label27.Name = "Label27";
      size = new Size(101, 20);
      this.Label27.Size = size;
      this.Label27.TabIndex = 5;
      this.Label27.Text = "Scale Range:";
      this.Label27.TextAlign = ContentAlignment.MiddleRight;
      point = new Point(112, 72);
      this.udScaleMin.Location = point;
      this.udScaleMin.Name = "udScaleMin";
      size = new Size(63, 20);
      this.udScaleMin.Size = size;
      this.udScaleMin.TabIndex = 2;
      point = new Point(5, 46);
      this.Label26.Location = point;
      this.Label26.Name = "Label26";
      size = new Size(101, 20);
      this.Label26.Size = size;
      this.Label26.TabIndex = 3;
      this.Label26.Text = "Scaling Variable:";
      this.Label26.TextAlign = ContentAlignment.MiddleRight;
      point = new Point(112, 46);
      this.txtScaleName.Location = point;
      this.txtScaleName.Name = "txtScaleName";
      size = new Size(190, 20);
      this.txtScaleName.Size = size;
      this.txtScaleName.TabIndex = 1;
      this.txtScaleName.Text = "Foes Hit";
      point = new Point(6, 19);
      this.chkScale.Location = point;
      this.chkScale.Name = "chkScale";
      size = new Size(302, 21);
      this.chkScale.Size = size;
      this.chkScale.TabIndex = 0;
      this.chkScale.Text = "Enable scaling for this power";
      this.chkScale.UseVisualStyleBackColor = true;
      this.GroupBox1.Controls.Add((Control) this.lblStaticIndex);
      this.GroupBox1.Controls.Add((Control) this.chkHidden);
      this.GroupBox1.Controls.Add((Control) this.lblNameUnique);
      this.GroupBox1.Controls.Add((Control) this.Label1);
      this.GroupBox1.Controls.Add((Control) this.lblNameFull);
      this.GroupBox1.Controls.Add((Control) this.cbNameSet);
      this.GroupBox1.Controls.Add((Control) this.txtNameDisplay);
      this.GroupBox1.Controls.Add((Control) this.cbNameGroup);
      this.GroupBox1.Controls.Add((Control) this.Label22);
      this.GroupBox1.Controls.Add((Control) this.Label31);
      this.GroupBox1.Controls.Add((Control) this.txtNamePower);
      this.GroupBox1.Controls.Add((Control) this.Label33);
      point = new Point(13, 3);
      this.GroupBox1.Location = point;
      this.GroupBox1.Name = "GroupBox1";
      size = new Size(313, 190);
      this.GroupBox1.Size = size;
      this.GroupBox1.TabIndex = 19;
      this.GroupBox1.TabStop = false;
      this.GroupBox1.Text = "Name";
      this.lblStaticIndex.BorderStyle = BorderStyle.FixedSingle;
      point = new Point(6, 42);
      this.lblStaticIndex.Location = point;
      this.lblStaticIndex.Name = "lblStaticIndex";
      size = new Size(56, 20);
      this.lblStaticIndex.Size = size;
      this.lblStaticIndex.TabIndex = 25;
      this.lblStaticIndex.Text = "000";
      this.lblStaticIndex.TextAlign = ContentAlignment.MiddleCenter;
      point = new Point(5, 69);
      this.chkHidden.Location = point;
      this.chkHidden.Name = "chkHidden";
      size = new Size(57, 25);
      this.chkHidden.Size = size;
      this.chkHidden.TabIndex = 24;
      this.chkHidden.Text = "Hide";
      this.chkHidden.UseVisualStyleBackColor = true;
      point = new Point(6, 163);
      this.lblNameUnique.Location = point;
      this.lblNameUnique.Name = "lblNameUnique";
      size = new Size(296, 20);
      this.lblNameUnique.Size = size;
      this.lblNameUnique.TabIndex = 19;
      this.lblNameUnique.Text = "This name is unique.";
      this.lblNameUnique.TextAlign = ContentAlignment.MiddleCenter;
      point = new Point(6, 16);
      this.Label1.Location = point;
      this.Label1.Name = "Label1";
      size = new Size(96, 20);
      this.Label1.Size = size;
      this.Label1.TabIndex = 1;
      this.Label1.Text = "Display Name:";
      this.Label1.TextAlign = ContentAlignment.MiddleRight;
      this.lblNameFull.BorderStyle = BorderStyle.FixedSingle;
      point = new Point(9, (int) sbyte.MaxValue);
      this.lblNameFull.Location = point;
      this.lblNameFull.Name = "lblNameFull";
      size = new Size(293, 32);
      this.lblNameFull.Size = size;
      this.lblNameFull.TabIndex = 16;
      this.lblNameFull.Text = "Group_Name.Powerset_Name.Power_Name";
      this.lblNameFull.TextAlign = ContentAlignment.MiddleLeft;
      this.cbNameSet.FormattingEnabled = true;
      point = new Point(106, 70);
      this.cbNameSet.Location = point;
      this.cbNameSet.Name = "cbNameSet";
      size = new Size(196, 22);
      this.cbNameSet.Size = size;
      this.cbNameSet.TabIndex = 2;
      point = new Point(106, 16);
      this.txtNameDisplay.Location = point;
      this.txtNameDisplay.Name = "txtNameDisplay";
      size = new Size(196, 20);
      this.txtNameDisplay.Size = size;
      this.txtNameDisplay.TabIndex = 0;
      this.txtNameDisplay.Text = "PowerName";
      this.cbNameGroup.FormattingEnabled = true;
      point = new Point(106, 42);
      this.cbNameGroup.Location = point;
      this.cbNameGroup.Name = "cbNameGroup";
      size = new Size(196, 22);
      this.cbNameGroup.Size = size;
      this.cbNameGroup.TabIndex = 1;
      point = new Point(53, 42);
      this.Label22.Location = point;
      this.Label22.Name = "Label22";
      size = new Size(49, 20);
      this.Label22.Size = size;
      this.Label22.TabIndex = 10;
      this.Label22.Text = "Group:";
      this.Label22.TextAlign = ContentAlignment.MiddleRight;
      point = new Point(65, 70);
      this.Label31.Location = point;
      this.Label31.Name = "Label31";
      size = new Size(35, 20);
      this.Label31.Size = size;
      this.Label31.TabIndex = 12;
      this.Label31.Text = "Set:";
      this.Label31.TextAlign = ContentAlignment.MiddleRight;
      point = new Point(106, 98);
      this.txtNamePower.Location = point;
      this.txtNamePower.Name = "txtNamePower";
      size = new Size(196, 20);
      this.txtNamePower.Size = size;
      this.txtNamePower.TabIndex = 3;
      this.txtNamePower.Text = "PowerName";
      point = new Point(14, 98);
      this.Label33.Location = point;
      this.Label33.Name = "Label33";
      size = new Size(86, 20);
      this.Label33.Size = size;
      this.Label33.TabIndex = 14;
      this.Label33.Text = "Power Name:";
      this.Label33.TextAlign = ContentAlignment.MiddleRight;
      this.tpBasic.Controls.Add((Control) this.Label46);
      this.tpBasic.Controls.Add((Control) this.Label47);
      this.tpBasic.Controls.Add((Control) this.txtLifeTimeReal);
      this.tpBasic.Controls.Add((Control) this.Label44);
      this.tpBasic.Controls.Add((Control) this.Label45);
      this.tpBasic.Controls.Add((Control) this.txtLifeTimeGame);
      this.tpBasic.Controls.Add((Control) this.Label42);
      this.tpBasic.Controls.Add((Control) this.Label43);
      this.tpBasic.Controls.Add((Control) this.txtUseageTime);
      this.tpBasic.Controls.Add((Control) this.Label41);
      this.tpBasic.Controls.Add((Control) this.txtNumCharges);
      this.tpBasic.Controls.Add((Control) this.chkIgnoreStrength);
      this.tpBasic.Controls.Add((Control) this.Label12);
      this.tpBasic.Controls.Add((Control) this.Label17);
      this.tpBasic.Controls.Add((Control) this.txtRangeSec);
      this.tpBasic.Controls.Add((Control) this.Label18);
      this.tpBasic.Controls.Add((Control) this.GroupBox9);
      this.tpBasic.Controls.Add((Control) this.cbNotify);
      this.tpBasic.Controls.Add((Control) this.chkLos);
      this.tpBasic.Controls.Add((Control) this.txtMaxTargets);
      this.tpBasic.Controls.Add((Control) this.lblEndCost);
      this.tpBasic.Controls.Add((Control) this.Label20);
      this.tpBasic.Controls.Add((Control) this.lblAcc);
      this.tpBasic.Controls.Add((Control) this.Label40);
      this.tpBasic.Controls.Add((Control) this.Label39);
      this.tpBasic.Controls.Add((Control) this.Label38);
      this.tpBasic.Controls.Add((Control) this.Label37);
      this.tpBasic.Controls.Add((Control) this.Label36);
      this.tpBasic.Controls.Add((Control) this.Label35);
      this.tpBasic.Controls.Add((Control) this.Label34);
      this.tpBasic.Controls.Add((Control) this.Label16);
      this.tpBasic.Controls.Add((Control) this.txtArc);
      this.tpBasic.Controls.Add((Control) this.Label15);
      this.tpBasic.Controls.Add((Control) this.txtRadius);
      this.tpBasic.Controls.Add((Control) this.txtLevel);
      this.tpBasic.Controls.Add((Control) this.cbEffectArea);
      this.tpBasic.Controls.Add((Control) this.Label14);
      this.tpBasic.Controls.Add((Control) this.Label13);
      this.tpBasic.Controls.Add((Control) this.txtEndCost);
      this.tpBasic.Controls.Add((Control) this.Label10);
      this.tpBasic.Controls.Add((Control) this.txtActivate);
      this.tpBasic.Controls.Add((Control) this.Label11);
      this.tpBasic.Controls.Add((Control) this.txtRechargeTime);
      this.tpBasic.Controls.Add((Control) this.Label8);
      this.tpBasic.Controls.Add((Control) this.txtCastTime);
      this.tpBasic.Controls.Add((Control) this.Label9);
      this.tpBasic.Controls.Add((Control) this.txtInterrupt);
      this.tpBasic.Controls.Add((Control) this.Label7);
      this.tpBasic.Controls.Add((Control) this.txtRange);
      this.tpBasic.Controls.Add((Control) this.Label6);
      this.tpBasic.Controls.Add((Control) this.txtAcc);
      this.tpBasic.Controls.Add((Control) this.cbPowerType);
      this.tpBasic.Controls.Add((Control) this.Label5);
      this.tpBasic.Controls.Add((Control) this.Label4);
      point = new Point(4, 23);
      this.tpBasic.Location = point;
      this.tpBasic.Name = "tpBasic";
      size = new Size(832, 337);
      this.tpBasic.Size = size;
      this.tpBasic.TabIndex = 0;
      this.tpBasic.Text = "Power Attributes";
      this.tpBasic.UseVisualStyleBackColor = true;
      this.tpBasic.Visible = false;
      point = new Point(447, 219);
      this.Label46.Location = point;
      this.Label46.Name = "Label46";
      size = new Size(20, 20);
      this.Label46.Size = size;
      this.Label46.TabIndex = 118;
      this.Label46.Text = "s";
      this.Label46.TextAlign = ContentAlignment.MiddleLeft;
      point = new Point(256, 219);
      this.Label47.Location = point;
      this.Label47.Name = "Label47";
      size = new Size(124, 20);
      this.Label47.Size = size;
      this.Label47.TabIndex = 117;
      this.Label47.Text = "Life Time Real-World:";
      this.Label47.TextAlign = ContentAlignment.MiddleRight;
      point = new Point(384, 219);
      this.txtLifeTimeReal.Location = point;
      this.txtLifeTimeReal.Name = "txtLifeTimeReal";
      size = new Size(57, 20);
      this.txtLifeTimeReal.Size = size;
      this.txtLifeTimeReal.TabIndex = 116;
      this.txtLifeTimeReal.Text = "1";
      this.txtLifeTimeReal.TextAlign = HorizontalAlignment.Right;
      point = new Point(447, 193);
      this.Label44.Location = point;
      this.Label44.Name = "Label44";
      size = new Size(20, 20);
      this.Label44.Size = size;
      this.Label44.TabIndex = 115;
      this.Label44.Text = "s";
      this.Label44.TextAlign = ContentAlignment.MiddleLeft;
      point = new Point(256, 193);
      this.Label45.Location = point;
      this.Label45.Name = "Label45";
      size = new Size(124, 20);
      this.Label45.Size = size;
      this.Label45.TabIndex = 114;
      this.Label45.Text = "Life Time In-Game:";
      this.Label45.TextAlign = ContentAlignment.MiddleRight;
      point = new Point(384, 193);
      this.txtLifeTimeGame.Location = point;
      this.txtLifeTimeGame.Name = "txtLifeTimeGame";
      size = new Size(57, 20);
      this.txtLifeTimeGame.Size = size;
      this.txtLifeTimeGame.TabIndex = 113;
      this.txtLifeTimeGame.Text = "1";
      this.txtLifeTimeGame.TextAlign = HorizontalAlignment.Right;
      point = new Point(447, 167);
      this.Label42.Location = point;
      this.Label42.Name = "Label42";
      size = new Size(20, 20);
      this.Label42.Size = size;
      this.Label42.TabIndex = 112;
      this.Label42.Text = "s";
      this.Label42.TextAlign = ContentAlignment.MiddleLeft;
      point = new Point(256, 167);
      this.Label43.Location = point;
      this.Label43.Name = "Label43";
      size = new Size(124, 20);
      this.Label43.Size = size;
      this.Label43.TabIndex = 111;
      this.Label43.Text = "Usage Time:";
      this.Label43.TextAlign = ContentAlignment.MiddleRight;
      point = new Point(384, 167);
      this.txtUseageTime.Location = point;
      this.txtUseageTime.Name = "txtUseageTime";
      size = new Size(57, 20);
      this.txtUseageTime.Size = size;
      this.txtUseageTime.TabIndex = 110;
      this.txtUseageTime.Text = "1";
      this.txtUseageTime.TextAlign = HorizontalAlignment.Right;
      point = new Point(256, 141);
      this.Label41.Location = point;
      this.Label41.Name = "Label41";
      size = new Size(124, 20);
      this.Label41.Size = size;
      this.Label41.TabIndex = 108;
      this.Label41.Text = "Charge Count:";
      this.Label41.TextAlign = ContentAlignment.MiddleRight;
      point = new Point(384, 141);
      this.txtNumCharges.Location = point;
      this.txtNumCharges.Name = "txtNumCharges";
      size = new Size(57, 20);
      this.txtNumCharges.Size = size;
      this.txtNumCharges.TabIndex = 107;
      this.txtNumCharges.Text = "1";
      this.txtNumCharges.TextAlign = HorizontalAlignment.Right;
      this.chkIgnoreStrength.CheckAlign = ContentAlignment.MiddleRight;
      this.chkIgnoreStrength.Checked = true;
      this.chkIgnoreStrength.CheckState = CheckState.Checked;
      point = new Point(256, 116);
      this.chkIgnoreStrength.Location = point;
      this.chkIgnoreStrength.Name = "chkIgnoreStrength";
      size = new Size(223, 20);
      this.chkIgnoreStrength.Size = size;
      this.chkIgnoreStrength.TabIndex = 16;
      this.chkIgnoreStrength.Text = "Ignore Strength";
      this.chkIgnoreStrength.TextAlign = ContentAlignment.MiddleRight;
      point = new Point(180, 219);
      this.Label12.Location = point;
      this.Label12.Name = "Label12";
      size = new Size(20, 20);
      this.Label12.Size = size;
      this.Label12.TabIndex = 106;
      this.Label12.Text = "ft";
      this.Label12.TextAlign = ContentAlignment.MiddleLeft;
      point = new Point(9, 219);
      this.Label17.Location = point;
      this.Label17.Name = "Label17";
      size = new Size(104, 20);
      this.Label17.Size = size;
      this.Label17.TabIndex = 105;
      this.Label17.Text = "Secondary  Range:";
      this.Label17.TextAlign = ContentAlignment.MiddleRight;
      point = new Point(117, 219);
      this.txtRangeSec.Location = point;
      this.txtRangeSec.Name = "txtRangeSec";
      size = new Size(57, 20);
      this.txtRangeSec.Size = size;
      this.txtRangeSec.TabIndex = 8;
      this.txtRangeSec.Text = "1.0";
      this.txtRangeSec.TextAlign = HorizontalAlignment.Right;
      point = new Point(256, 63);
      this.Label18.Location = point;
      this.Label18.Name = "Label18";
      size = new Size(122, 20);
      this.Label18.Size = size;
      this.Label18.TabIndex = 33;
      this.Label18.Text = "Notify Mobs:";
      this.Label18.TextAlign = ContentAlignment.MiddleRight;
      this.GroupBox9.Controls.Add((Control) this.rbFlagCastThrough);
      this.GroupBox9.Controls.Add((Control) this.rbFlagDisallow);
      this.GroupBox9.Controls.Add((Control) this.rbFlagRequired);
      this.GroupBox9.Controls.Add((Control) this.rbFlagVector);
      this.GroupBox9.Controls.Add((Control) this.rbFlagCast);
      this.GroupBox9.Controls.Add((Control) this.clbFlags);
      this.GroupBox9.Controls.Add((Control) this.rbFlagTargetsSec);
      this.GroupBox9.Controls.Add((Control) this.rbFlagTargets);
      this.GroupBox9.Controls.Add((Control) this.rbFlagAffected);
      this.GroupBox9.Controls.Add((Control) this.rbFlagAutoHit);
      point = new Point(521, 8);
      this.GroupBox9.Location = point;
      this.GroupBox9.Name = "GroupBox9";
      size = new Size(300, 320);
      this.GroupBox9.Size = size;
      this.GroupBox9.TabIndex = 103;
      this.GroupBox9.TabStop = false;
      this.GroupBox9.Text = "Adv. Attributes";
      point = new Point(152, 111);
      this.rbFlagCastThrough.Location = point;
      this.rbFlagCastThrough.Name = "rbFlagCastThrough";
      size = new Size(140, 17);
      this.rbFlagCastThrough.Size = size;
      this.rbFlagCastThrough.TabIndex = 9;
      this.rbFlagCastThrough.TabStop = true;
      this.rbFlagCastThrough.Text = "Cast Through...";
      this.rbFlagCastThrough.UseVisualStyleBackColor = true;
      point = new Point(152, 88);
      this.rbFlagDisallow.Location = point;
      this.rbFlagDisallow.Name = "rbFlagDisallow";
      size = new Size(140, 17);
      this.rbFlagDisallow.Size = size;
      this.rbFlagDisallow.TabIndex = 7;
      this.rbFlagDisallow.TabStop = true;
      this.rbFlagDisallow.Text = "Modes Disallowed";
      this.rbFlagDisallow.UseVisualStyleBackColor = true;
      this.rbFlagRequired.CheckAlign = ContentAlignment.MiddleRight;
      point = new Point(6, 88);
      this.rbFlagRequired.Location = point;
      this.rbFlagRequired.Name = "rbFlagRequired";
      size = new Size(140, 17);
      this.rbFlagRequired.Size = size;
      this.rbFlagRequired.TabIndex = 6;
      this.rbFlagRequired.TabStop = true;
      this.rbFlagRequired.Text = "Modes Required";
      this.rbFlagRequired.TextAlign = ContentAlignment.MiddleRight;
      this.rbFlagRequired.UseVisualStyleBackColor = true;
      point = new Point(152, 65);
      this.rbFlagVector.Location = point;
      this.rbFlagVector.Name = "rbFlagVector";
      size = new Size(140, 17);
      this.rbFlagVector.Size = size;
      this.rbFlagVector.TabIndex = 5;
      this.rbFlagVector.TabStop = true;
      this.rbFlagVector.Text = "Vector / Damage Types";
      this.rbFlagVector.UseVisualStyleBackColor = true;
      this.rbFlagCast.CheckAlign = ContentAlignment.MiddleRight;
      point = new Point(6, 65);
      this.rbFlagCast.Location = point;
      this.rbFlagCast.Name = "rbFlagCast";
      size = new Size(140, 17);
      this.rbFlagCast.Size = size;
      this.rbFlagCast.TabIndex = 4;
      this.rbFlagCast.TabStop = true;
      this.rbFlagCast.Text = "Cast Flags";
      this.rbFlagCast.TextAlign = ContentAlignment.MiddleRight;
      this.rbFlagCast.UseVisualStyleBackColor = true;
      this.clbFlags.FormattingEnabled = true;
      point = new Point(6, 130);
      this.clbFlags.Location = point;
      this.clbFlags.Name = "clbFlags";
      size = new Size(288, 184);
      this.clbFlags.Size = size;
      this.clbFlags.TabIndex = 10;
      point = new Point(152, 42);
      this.rbFlagTargetsSec.Location = point;
      this.rbFlagTargetsSec.Name = "rbFlagTargetsSec";
      size = new Size(140, 17);
      this.rbFlagTargetsSec.Size = size;
      this.rbFlagTargetsSec.TabIndex = 3;
      this.rbFlagTargetsSec.TabStop = true;
      this.rbFlagTargetsSec.Text = "Secondary Targets";
      this.rbFlagTargetsSec.UseVisualStyleBackColor = true;
      this.rbFlagTargets.CheckAlign = ContentAlignment.MiddleRight;
      point = new Point(6, 42);
      this.rbFlagTargets.Location = point;
      this.rbFlagTargets.Name = "rbFlagTargets";
      size = new Size(140, 17);
      this.rbFlagTargets.Size = size;
      this.rbFlagTargets.TabIndex = 2;
      this.rbFlagTargets.TabStop = true;
      this.rbFlagTargets.Text = "Targets";
      this.rbFlagTargets.TextAlign = ContentAlignment.MiddleRight;
      this.rbFlagTargets.UseVisualStyleBackColor = true;
      point = new Point(152, 19);
      this.rbFlagAffected.Location = point;
      this.rbFlagAffected.Name = "rbFlagAffected";
      size = new Size(140, 17);
      this.rbFlagAffected.Size = size;
      this.rbFlagAffected.TabIndex = 1;
      this.rbFlagAffected.TabStop = true;
      this.rbFlagAffected.Text = "Entities Affected";
      this.rbFlagAffected.UseVisualStyleBackColor = true;
      this.rbFlagAutoHit.CheckAlign = ContentAlignment.MiddleRight;
      point = new Point(6, 19);
      this.rbFlagAutoHit.Location = point;
      this.rbFlagAutoHit.Name = "rbFlagAutoHit";
      size = new Size(140, 17);
      this.rbFlagAutoHit.Size = size;
      this.rbFlagAutoHit.TabIndex = 0;
      this.rbFlagAutoHit.TabStop = true;
      this.rbFlagAutoHit.Text = "Entities AutoHit";
      this.rbFlagAutoHit.TextAlign = ContentAlignment.MiddleRight;
      this.rbFlagAutoHit.UseVisualStyleBackColor = true;
      this.cbNotify.DropDownStyle = ComboBoxStyle.DropDownList;
      point = new Point(384, 63);
      this.cbNotify.Location = point;
      this.cbNotify.Name = "cbNotify";
      size = new Size(95, 22);
      this.cbNotify.Size = size;
      this.cbNotify.TabIndex = 14;
      this.chkLos.CheckAlign = ContentAlignment.MiddleRight;
      this.chkLos.Checked = true;
      this.chkLos.CheckState = CheckState.Checked;
      point = new Point(256, 90);
      this.chkLos.Location = point;
      this.chkLos.Name = "chkLos";
      size = new Size(223, 20);
      this.chkLos.Size = size;
      this.chkLos.TabIndex = 15;
      this.chkLos.Text = "Requires Line of Sight";
      this.chkLos.TextAlign = ContentAlignment.MiddleRight;
      point = new Point(117, 295);
      this.txtMaxTargets.Location = point;
      this.txtMaxTargets.Name = "txtMaxTargets";
      size = new Size(57, 20);
      this.txtMaxTargets.Size = size;
      this.txtMaxTargets.TabIndex = 11;
      this.txtMaxTargets.Text = "1";
      this.txtMaxTargets.TextAlign = HorizontalAlignment.Right;
      point = new Point(180, 167);
      this.lblEndCost.Location = point;
      this.lblEndCost.Name = "lblEndCost";
      size = new Size(50, 20);
      this.lblEndCost.Size = size;
      this.lblEndCost.TabIndex = 101;
      this.lblEndCost.Text = "(1.05/s)";
      this.lblEndCost.TextAlign = ContentAlignment.MiddleLeft;
      point = new Point(12, 295);
      this.Label20.Location = point;
      this.Label20.Name = "Label20";
      size = new Size(101, 20);
      this.Label20.Size = size;
      this.Label20.TabIndex = 39;
      this.Label20.Text = "Max Targets:";
      this.Label20.TextAlign = ContentAlignment.MiddleRight;
      point = new Point(180, 37);
      this.lblAcc.Location = point;
      this.lblAcc.Name = "lblAcc";
      size = new Size(50, 20);
      this.lblAcc.Size = size;
      this.lblAcc.TabIndex = 100;
      this.lblAcc.Text = "(75%)";
      this.lblAcc.TextAlign = ContentAlignment.MiddleLeft;
      point = new Point(180, 269);
      this.Label40.Location = point;
      this.Label40.Name = "Label40";
      size = new Size(30, 20);
      this.Label40.Size = size;
      this.Label40.TabIndex = 99;
      this.Label40.Text = "deg.";
      this.Label40.TextAlign = ContentAlignment.MiddleLeft;
      point = new Point(180, 245);
      this.Label39.Location = point;
      this.Label39.Name = "Label39";
      size = new Size(30, 20);
      this.Label39.Size = size;
      this.Label39.TabIndex = 98;
      this.Label39.Text = "ft";
      this.Label39.TextAlign = ContentAlignment.MiddleLeft;
      point = new Point(180, 193);
      this.Label38.Location = point;
      this.Label38.Name = "Label38";
      size = new Size(20, 20);
      this.Label38.Size = size;
      this.Label38.TabIndex = 97;
      this.Label38.Text = "ft";
      this.Label38.TextAlign = ContentAlignment.MiddleLeft;
      point = new Point(180, 141);
      this.Label37.Location = point;
      this.Label37.Name = "Label37";
      size = new Size(20, 20);
      this.Label37.Size = size;
      this.Label37.TabIndex = 96;
      this.Label37.Text = "s";
      this.Label37.TextAlign = ContentAlignment.MiddleLeft;
      point = new Point(180, 115);
      this.Label36.Location = point;
      this.Label36.Name = "Label36";
      size = new Size(20, 20);
      this.Label36.Size = size;
      this.Label36.TabIndex = 95;
      this.Label36.Text = "s";
      this.Label36.TextAlign = ContentAlignment.MiddleLeft;
      point = new Point(180, 89);
      this.Label35.Location = point;
      this.Label35.Name = "Label35";
      size = new Size(20, 20);
      this.Label35.Size = size;
      this.Label35.TabIndex = 94;
      this.Label35.Text = "s";
      this.Label35.TextAlign = ContentAlignment.MiddleLeft;
      point = new Point(180, 63);
      this.Label34.Location = point;
      this.Label34.Name = "Label34";
      size = new Size(20, 20);
      this.Label34.Size = size;
      this.Label34.TabIndex = 93;
      this.Label34.Text = "s";
      this.Label34.TextAlign = ContentAlignment.MiddleLeft;
      point = new Point(35, 269);
      this.Label16.Location = point;
      this.Label16.Name = "Label16";
      size = new Size(78, 20);
      this.Label16.Size = size;
      this.Label16.TabIndex = 30;
      this.Label16.Text = "Arc:";
      this.Label16.TextAlign = ContentAlignment.MiddleRight;
      point = new Point(117, 269);
      this.txtArc.Location = point;
      this.txtArc.Name = "txtArc";
      size = new Size(57, 20);
      this.txtArc.Size = size;
      this.txtArc.TabIndex = 10;
      this.txtArc.Text = "1";
      this.txtArc.TextAlign = HorizontalAlignment.Right;
      point = new Point(35, 245);
      this.Label15.Location = point;
      this.Label15.Name = "Label15";
      size = new Size(78, 20);
      this.Label15.Size = size;
      this.Label15.TabIndex = 28;
      this.Label15.Text = "Radius:";
      this.Label15.TextAlign = ContentAlignment.MiddleRight;
      point = new Point(117, 245);
      this.txtRadius.Location = point;
      this.txtRadius.Name = "txtRadius";
      size = new Size(57, 20);
      this.txtRadius.Size = size;
      this.txtRadius.TabIndex = 9;
      this.txtRadius.Text = "1";
      this.txtRadius.TextAlign = HorizontalAlignment.Right;
      point = new Point(117, 11);
      this.txtLevel.Location = point;
      this.txtLevel.Name = "txtLevel";
      size = new Size(57, 20);
      this.txtLevel.Size = size;
      this.txtLevel.TabIndex = 0;
      this.txtLevel.Text = "1";
      this.txtLevel.TextAlign = HorizontalAlignment.Right;
      this.cbEffectArea.DropDownStyle = ComboBoxStyle.DropDownList;
      this.cbEffectArea.Items.AddRange(new object[5]
      {
        (object) "None",
        (object) "Character",
        (object) "Sphere",
        (object) "Cone",
        (object) "Location"
      });
      point = new Point(384, 37);
      this.cbEffectArea.Location = point;
      this.cbEffectArea.Name = "cbEffectArea";
      size = new Size(95, 22);
      this.cbEffectArea.Size = size;
      this.cbEffectArea.TabIndex = 13;
      point = new Point(256, 37);
      this.Label14.Location = point;
      this.Label14.Name = "Label14";
      size = new Size(122, 20);
      this.Label14.Size = size;
      this.Label14.TabIndex = 24;
      this.Label14.Text = "Effect Area:";
      this.Label14.TextAlign = ContentAlignment.MiddleRight;
      point = new Point(9, 167);
      this.Label13.Location = point;
      this.Label13.Name = "Label13";
      size = new Size(104, 20);
      this.Label13.Size = size;
      this.Label13.TabIndex = 19;
      this.Label13.Text = "Endurance Cost:";
      this.Label13.TextAlign = ContentAlignment.MiddleRight;
      point = new Point(117, 167);
      this.txtEndCost.Location = point;
      this.txtEndCost.Name = "txtEndCost";
      size = new Size(57, 20);
      this.txtEndCost.Size = size;
      this.txtEndCost.TabIndex = 6;
      this.txtEndCost.Text = "1.0";
      this.txtEndCost.TextAlign = HorizontalAlignment.Right;
      point = new Point(9, 141);
      this.Label10.Location = point;
      this.Label10.Name = "Label10";
      size = new Size(104, 20);
      this.Label10.Size = size;
      this.Label10.TabIndex = 17;
      this.Label10.Text = "Activate Interval:";
      this.Label10.TextAlign = ContentAlignment.MiddleRight;
      point = new Point(117, 141);
      this.txtActivate.Location = point;
      this.txtActivate.Name = "txtActivate";
      size = new Size(57, 20);
      this.txtActivate.Size = size;
      this.txtActivate.TabIndex = 5;
      this.txtActivate.Text = "1.0";
      this.txtActivate.TextAlign = HorizontalAlignment.Right;
      point = new Point(9, 115);
      this.Label11.Location = point;
      this.Label11.Name = "Label11";
      size = new Size(104, 20);
      this.Label11.Size = size;
      this.Label11.TabIndex = 15;
      this.Label11.Text = "Recharge Time:";
      this.Label11.TextAlign = ContentAlignment.MiddleRight;
      point = new Point(117, 115);
      this.txtRechargeTime.Location = point;
      this.txtRechargeTime.Name = "txtRechargeTime";
      size = new Size(57, 20);
      this.txtRechargeTime.Size = size;
      this.txtRechargeTime.TabIndex = 4;
      this.txtRechargeTime.Text = "1.0";
      this.txtRechargeTime.TextAlign = HorizontalAlignment.Right;
      point = new Point(9, 89);
      this.Label8.Location = point;
      this.Label8.Name = "Label8";
      size = new Size(104, 20);
      this.Label8.Size = size;
      this.Label8.TabIndex = 13;
      this.Label8.Text = "Casting Time:";
      this.Label8.TextAlign = ContentAlignment.MiddleRight;
      point = new Point(117, 89);
      this.txtCastTime.Location = point;
      this.txtCastTime.Name = "txtCastTime";
      size = new Size(57, 20);
      this.txtCastTime.Size = size;
      this.txtCastTime.TabIndex = 3;
      this.txtCastTime.Text = "1.0";
      this.txtCastTime.TextAlign = HorizontalAlignment.Right;
      point = new Point(9, 63);
      this.Label9.Location = point;
      this.Label9.Name = "Label9";
      size = new Size(104, 20);
      this.Label9.Size = size;
      this.Label9.TabIndex = 11;
      this.Label9.Text = "Interruptable Time:";
      this.Label9.TextAlign = ContentAlignment.MiddleRight;
      point = new Point(117, 63);
      this.txtInterrupt.Location = point;
      this.txtInterrupt.Name = "txtInterrupt";
      size = new Size(57, 20);
      this.txtInterrupt.Size = size;
      this.txtInterrupt.TabIndex = 2;
      this.txtInterrupt.Text = "1.0";
      this.txtInterrupt.TextAlign = HorizontalAlignment.Right;
      point = new Point(9, 193);
      this.Label7.Location = point;
      this.Label7.Name = "Label7";
      size = new Size(104, 20);
      this.Label7.Size = size;
      this.Label7.TabIndex = 9;
      this.Label7.Text = "Range:";
      this.Label7.TextAlign = ContentAlignment.MiddleRight;
      point = new Point(117, 193);
      this.txtRange.Location = point;
      this.txtRange.Name = "txtRange";
      size = new Size(57, 20);
      this.txtRange.Size = size;
      this.txtRange.TabIndex = 7;
      this.txtRange.Text = "1.0";
      this.txtRange.TextAlign = HorizontalAlignment.Right;
      point = new Point(9, 37);
      this.Label6.Location = point;
      this.Label6.Name = "Label6";
      size = new Size(104, 20);
      this.Label6.Size = size;
      this.Label6.TabIndex = 7;
      this.Label6.Text = "Accuracy:";
      this.Label6.TextAlign = ContentAlignment.MiddleRight;
      point = new Point(117, 37);
      this.txtAcc.Location = point;
      this.txtAcc.Name = "txtAcc";
      size = new Size(57, 20);
      this.txtAcc.Size = size;
      this.txtAcc.TabIndex = 1;
      this.txtAcc.Text = "1.0";
      this.txtAcc.TextAlign = HorizontalAlignment.Right;
      this.cbPowerType.DropDownStyle = ComboBoxStyle.DropDownList;
      this.cbPowerType.Items.AddRange(new object[3]
      {
        (object) "Click",
        (object) "Passive",
        (object) "Toggle"
      });
      point = new Point(384, 11);
      this.cbPowerType.Location = point;
      this.cbPowerType.Name = "cbPowerType";
      size = new Size(95, 22);
      this.cbPowerType.Size = size;
      this.cbPowerType.TabIndex = 12;
      point = new Point(256, 11);
      this.Label5.Location = point;
      this.Label5.Name = "Label5";
      size = new Size(122, 20);
      this.Label5.Size = size;
      this.Label5.TabIndex = 4;
      this.Label5.Text = "Power Type:";
      this.Label5.TextAlign = ContentAlignment.MiddleRight;
      point = new Point(9, 11);
      this.Label4.Location = point;
      this.Label4.Name = "Label4";
      size = new Size(104, 20);
      this.Label4.Size = size;
      this.Label4.TabIndex = 2;
      this.Label4.Text = "Level Available:";
      this.Label4.TextAlign = ContentAlignment.MiddleRight;
      this.tpEffects.Controls.Add((Control) this.lvFX);
      this.tpEffects.Controls.Add((Control) this.pnlFX);
      point = new Point(4, 23);
      this.tpEffects.Location = point;
      this.tpEffects.Name = "tpEffects";
      size = new Size(832, 337);
      this.tpEffects.Size = size;
      this.tpEffects.TabIndex = 1;
      this.tpEffects.Text = "Effects";
      this.tpEffects.UseVisualStyleBackColor = true;
      this.tpEffects.Visible = false;
      this.lvFX.ItemHeight = 14;
      point = new Point(8, 8);
      this.lvFX.Location = point;
      this.lvFX.Name = "lvFX";
      size = new Size(744, 270);
      this.lvFX.Size = size;
      this.lvFX.TabIndex = 71;
      this.pnlFX.Controls.Add((Control) this.btnSetDamage);
      this.pnlFX.Controls.Add((Control) this.btnFXEdit);
      this.pnlFX.Controls.Add((Control) this.btnFXDown);
      this.pnlFX.Controls.Add((Control) this.btnFXUp);
      this.pnlFX.Controls.Add((Control) this.btnFXRemove);
      this.pnlFX.Controls.Add((Control) this.btnFXDuplicate);
      this.pnlFX.Controls.Add((Control) this.btnFXAdd);
      point = new Point(4, 4);
      this.pnlFX.Location = point;
      this.pnlFX.Name = "pnlFX";
      size = new Size(824, 332);
      this.pnlFX.Size = size;
      this.pnlFX.TabIndex = 71;
      point = new Point(312, 288);
      this.btnSetDamage.Location = point;
      this.btnSetDamage.Name = "btnSetDamage";
      size = new Size(212, 24);
      this.btnSetDamage.Size = size;
      this.btnSetDamage.TabIndex = 78;
      this.btnSetDamage.Text = "Set damage types from effect list";
      point = new Point(160, 288);
      this.btnFXEdit.Location = point;
      this.btnFXEdit.Name = "btnFXEdit";
      size = new Size(64, 24);
      this.btnFXEdit.Size = size;
      this.btnFXEdit.TabIndex = 77;
      this.btnFXEdit.Text = "Edit...";
      point = new Point(756, 40);
      this.btnFXDown.Location = point;
      this.btnFXDown.Name = "btnFXDown";
      size = new Size(64, 24);
      this.btnFXDown.Size = size;
      this.btnFXDown.TabIndex = 11;
      this.btnFXDown.Text = "Down";
      point = new Point(756, 8);
      this.btnFXUp.Location = point;
      this.btnFXUp.Name = "btnFXUp";
      size = new Size(64, 24);
      this.btnFXUp.Size = size;
      this.btnFXUp.TabIndex = 12;
      this.btnFXUp.Text = "Up";
      point = new Point(236, 288);
      this.btnFXRemove.Location = point;
      this.btnFXRemove.Name = "btnFXRemove";
      size = new Size(64, 24);
      this.btnFXRemove.Size = size;
      this.btnFXRemove.TabIndex = 10;
      this.btnFXRemove.Text = "Remove";
      point = new Point(84, 288);
      this.btnFXDuplicate.Location = point;
      this.btnFXDuplicate.Name = "btnFXDuplicate";
      size = new Size(64, 24);
      this.btnFXDuplicate.Size = size;
      this.btnFXDuplicate.TabIndex = 69;
      this.btnFXDuplicate.Text = "Duplicate";
      point = new Point(8, 288);
      this.btnFXAdd.Location = point;
      this.btnFXAdd.Name = "btnFXAdd";
      size = new Size(64, 24);
      this.btnFXAdd.Size = size;
      this.btnFXAdd.TabIndex = 9;
      this.btnFXAdd.Text = "Add";
      this.tpEnh.Controls.Add((Control) this.chkBoostUsePlayerLevel);
      this.tpEnh.Controls.Add((Control) this.chkBoostBoostable);
      this.tpEnh.Controls.Add((Control) this.Label23);
      this.tpEnh.Controls.Add((Control) this.pbEnhancements);
      this.tpEnh.Controls.Add((Control) this.chkPRFrontLoad);
      this.tpEnh.Controls.Add((Control) this.pbEnhancementList);
      this.tpEnh.Controls.Add((Control) this.lblEnhName);
      point = new Point(4, 23);
      this.tpEnh.Location = point;
      this.tpEnh.Name = "tpEnh";
      size = new Size(832, 337);
      this.tpEnh.Size = size;
      this.tpEnh.TabIndex = 9;
      this.tpEnh.Text = "Enhancements";
      this.tpEnh.UseVisualStyleBackColor = true;
      point = new Point(357, 136);
      this.chkBoostUsePlayerLevel.Location = point;
      this.chkBoostUsePlayerLevel.Name = "chkBoostUsePlayerLevel";
      size = new Size(324, 20);
      this.chkBoostUsePlayerLevel.Size = size;
      this.chkBoostUsePlayerLevel.TabIndex = 91;
      this.chkBoostUsePlayerLevel.Text = "Attuned Enhancement";
      point = new Point(357, 110);
      this.chkBoostBoostable.Location = point;
      this.chkBoostBoostable.Name = "chkBoostBoostable";
      size = new Size(324, 20);
      this.chkBoostBoostable.Size = size;
      this.chkBoostBoostable.TabIndex = 90;
      this.chkBoostBoostable.Text = "Allow Enhancement Boosters (Enhancement only)";
      point = new Point(24, 12);
      this.Label23.Location = point;
      this.Label23.Name = "Label23";
      size = new Size(300, 16);
      this.Label23.Size = size;
      this.Label23.TabIndex = 89;
      this.Label23.Text = "Enhancement Classes Accepted:";
      this.Label23.TextAlign = ContentAlignment.MiddleLeft;
      this.pbEnhancements.BackColor = Color.FromArgb((int) byte.MaxValue, 128, 0);
      point = new Point(24, 28);
      this.pbEnhancements.Location = point;
      this.pbEnhancements.Name = "pbEnhancements";
      size = new Size(416, 40);
      this.pbEnhancements.Size = size;
      this.pbEnhancements.TabIndex = 43;
      this.pbEnhancements.TabStop = false;
      point = new Point(357, 84);
      this.chkPRFrontLoad.Location = point;
      this.chkPRFrontLoad.Name = "chkPRFrontLoad";
      size = new Size(324, 20);
      this.chkPRFrontLoad.Size = size;
      this.chkPRFrontLoad.TabIndex = 88;
      this.chkPRFrontLoad.Text = "Allow front-loading of enhancement slots (for Kheld forms)";
      this.pbEnhancementList.BackColor = Color.FromArgb((int) byte.MaxValue, 192, 128);
      point = new Point(24, 84);
      this.pbEnhancementList.Location = point;
      this.pbEnhancementList.Name = "pbEnhancementList";
      size = new Size(316, 220);
      this.pbEnhancementList.Size = size;
      this.pbEnhancementList.TabIndex = 44;
      this.pbEnhancementList.TabStop = false;
      this.lblEnhName.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      point = new Point(21, 68);
      this.lblEnhName.Location = point;
      this.lblEnhName.Name = "lblEnhName";
      size = new Size(316, 16);
      this.lblEnhName.Size = size;
      this.lblEnhName.TabIndex = 46;
      this.tpSets.Controls.Add((Control) this.Label24);
      this.tpSets.Controls.Add((Control) this.lblInvSet);
      this.tpSets.Controls.Add((Control) this.pbInvSetList);
      this.tpSets.Controls.Add((Control) this.pbInvSetUsed);
      point = new Point(4, 23);
      this.tpSets.Location = point;
      this.tpSets.Name = "tpSets";
      size = new Size(832, 337);
      this.tpSets.Size = size;
      this.tpSets.TabIndex = 5;
      this.tpSets.Text = "Invention Set Types";
      this.tpSets.UseVisualStyleBackColor = true;
      point = new Point(24, 12);
      this.Label24.Location = point;
      this.Label24.Name = "Label24";
      size = new Size(300, 16);
      this.Label24.Size = size;
      this.Label24.TabIndex = 93;
      this.Label24.Text = "Invention Set Types Accepted:";
      this.Label24.TextAlign = ContentAlignment.MiddleLeft;
      this.lblInvSet.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      point = new Point(24, 68);
      this.lblInvSet.Location = point;
      this.lblInvSet.Name = "lblInvSet";
      size = new Size(316, 16);
      this.lblInvSet.Size = size;
      this.lblInvSet.TabIndex = 92;
      this.pbInvSetList.BackColor = Color.FromArgb(192, 192, (int) byte.MaxValue);
      point = new Point(24, 84);
      this.pbInvSetList.Location = point;
      this.pbInvSetList.Name = "pbInvSetList";
      size = new Size(316, 220);
      this.pbInvSetList.Size = size;
      this.pbInvSetList.TabIndex = 91;
      this.pbInvSetList.TabStop = false;
      this.pbInvSetUsed.BackColor = Color.FromArgb(128, 128, (int) byte.MaxValue);
      point = new Point(24, 28);
      this.pbInvSetUsed.Location = point;
      this.pbInvSetUsed.Name = "pbInvSetUsed";
      size = new Size(316, 40);
      this.pbInvSetUsed.Size = size;
      this.pbInvSetUsed.TabIndex = 90;
      this.pbInvSetUsed.TabStop = false;
      this.tpPreReq.Controls.Add((Control) this.GroupBox11);
      this.tpPreReq.Controls.Add((Control) this.GroupBox10);
      this.tpPreReq.Controls.Add((Control) this.GroupBox8);
      point = new Point(4, 23);
      this.tpPreReq.Location = point;
      this.tpPreReq.Name = "tpPreReq";
      size = new Size(832, 337);
      this.tpPreReq.Size = size;
      this.tpPreReq.TabIndex = 4;
      this.tpPreReq.Text = "Requirements";
      this.tpPreReq.UseVisualStyleBackColor = true;
      this.tpPreReq.Visible = false;
      this.GroupBox11.Controls.Add((Control) this.btnPrReset);
      this.GroupBox11.Controls.Add((Control) this.btnPrSetNone);
      this.GroupBox11.Controls.Add((Control) this.btnPrDown);
      this.GroupBox11.Controls.Add((Control) this.btnPrUp);
      this.GroupBox11.Controls.Add((Control) this.rbPrRemove);
      this.GroupBox11.Controls.Add((Control) this.rbPrAdd);
      this.GroupBox11.Controls.Add((Control) this.rbPrPowerB);
      this.GroupBox11.Controls.Add((Control) this.rbPrPowerA);
      this.GroupBox11.Controls.Add((Control) this.lvPrPower);
      this.GroupBox11.Controls.Add((Control) this.lvPrSet);
      this.GroupBox11.Controls.Add((Control) this.lvPrGroup);
      this.GroupBox11.Controls.Add((Control) this.lvPrListing);
      point = new Point(3, 14);
      this.GroupBox11.Location = point;
      this.GroupBox11.Name = "GroupBox11";
      size = new Size(611, 320);
      this.GroupBox11.Size = size;
      this.GroupBox11.TabIndex = 97;
      this.GroupBox11.TabStop = false;
      this.GroupBox11.Text = "Required Powers";
      point = new Point(432, 291);
      this.btnPrReset.Location = point;
      this.btnPrReset.Name = "btnPrReset";
      size = new Size(156, 23);
      this.btnPrReset.Size = size;
      this.btnPrReset.TabIndex = 15;
      this.btnPrReset.Text = "Reset";
      this.btnPrReset.UseVisualStyleBackColor = true;
      point = new Point(432, 153);
      this.btnPrSetNone.Location = point;
      this.btnPrSetNone.Name = "btnPrSetNone";
      size = new Size(156, 23);
      this.btnPrSetNone.Size = size;
      this.btnPrSetNone.TabIndex = 14;
      this.btnPrSetNone.Text = "Set Power A to None";
      this.btnPrSetNone.UseVisualStyleBackColor = true;
      point = new Point(513, 204);
      this.btnPrDown.Location = point;
      this.btnPrDown.Name = "btnPrDown";
      size = new Size(75, 23);
      this.btnPrDown.Size = size;
      this.btnPrDown.TabIndex = 13;
      this.btnPrDown.Text = "Down";
      this.btnPrDown.UseVisualStyleBackColor = true;
      point = new Point(432, 204);
      this.btnPrUp.Location = point;
      this.btnPrUp.Name = "btnPrUp";
      size = new Size(75, 23);
      this.btnPrUp.Size = size;
      this.btnPrUp.TabIndex = 12;
      this.btnPrUp.Text = "Up";
      this.btnPrUp.UseVisualStyleBackColor = true;
      point = new Point(432, 262);
      this.rbPrRemove.Location = point;
      this.rbPrRemove.Name = "rbPrRemove";
      size = new Size(156, 23);
      this.rbPrRemove.Size = size;
      this.rbPrRemove.TabIndex = 11;
      this.rbPrRemove.Text = "Remove Selected";
      this.rbPrRemove.UseVisualStyleBackColor = true;
      point = new Point(432, 233);
      this.rbPrAdd.Location = point;
      this.rbPrAdd.Name = "rbPrAdd";
      size = new Size(156, 23);
      this.rbPrAdd.Size = size;
      this.rbPrAdd.TabIndex = 10;
      this.rbPrAdd.Text = "Add New";
      this.rbPrAdd.UseVisualStyleBackColor = true;
      this.rbPrPowerB.Appearance = Appearance.Button;
      point = new Point(513, 124);
      this.rbPrPowerB.Location = point;
      this.rbPrPowerB.Name = "rbPrPowerB";
      size = new Size(75, 23);
      this.rbPrPowerB.Size = size;
      this.rbPrPowerB.TabIndex = 9;
      this.rbPrPowerB.Text = "Power B";
      this.rbPrPowerB.TextAlign = ContentAlignment.MiddleCenter;
      this.rbPrPowerB.UseVisualStyleBackColor = true;
      this.rbPrPowerA.Appearance = Appearance.Button;
      this.rbPrPowerA.Checked = true;
      point = new Point(432, 124);
      this.rbPrPowerA.Location = point;
      this.rbPrPowerA.Name = "rbPrPowerA";
      size = new Size(75, 23);
      this.rbPrPowerA.Size = size;
      this.rbPrPowerA.TabIndex = 8;
      this.rbPrPowerA.TabStop = true;
      this.rbPrPowerA.Text = "Power A";
      this.rbPrPowerA.TextAlign = ContentAlignment.MiddleCenter;
      this.rbPrPowerA.UseVisualStyleBackColor = true;
      this.lvPrPower.Columns.AddRange(new ColumnHeader[1]
      {
        this.ColumnHeader9
      });
      this.lvPrPower.FullRowSelect = true;
      this.lvPrPower.HeaderStyle = ColumnHeaderStyle.Nonclickable;
      this.lvPrPower.HideSelection = false;
      point = new Point(290, 108);
      this.lvPrPower.Location = point;
      this.lvPrPower.MultiSelect = false;
      this.lvPrPower.Name = "lvPrPower";
      size = new Size(136, 206);
      this.lvPrPower.Size = size;
      this.lvPrPower.TabIndex = 3;
      this.lvPrPower.UseCompatibleStateImageBehavior = false;
      this.lvPrPower.View = View.Details;
      this.ColumnHeader9.Text = "Power";
      this.ColumnHeader9.Width = 110;
      this.lvPrSet.Columns.AddRange(new ColumnHeader[1]
      {
        this.ColumnHeader10
      });
      this.lvPrSet.FullRowSelect = true;
      this.lvPrSet.HeaderStyle = ColumnHeaderStyle.Nonclickable;
      this.lvPrSet.HideSelection = false;
      point = new Point(148, 108);
      this.lvPrSet.Location = point;
      this.lvPrSet.MultiSelect = false;
      this.lvPrSet.Name = "lvPrSet";
      size = new Size(136, 206);
      this.lvPrSet.Size = size;
      this.lvPrSet.TabIndex = 2;
      this.lvPrSet.UseCompatibleStateImageBehavior = false;
      this.lvPrSet.View = View.Details;
      this.ColumnHeader10.Text = "Set";
      this.ColumnHeader10.Width = 110;
      this.lvPrGroup.Columns.AddRange(new ColumnHeader[1]
      {
        this.ColumnHeader11
      });
      this.lvPrGroup.FullRowSelect = true;
      this.lvPrGroup.HeaderStyle = ColumnHeaderStyle.Nonclickable;
      this.lvPrGroup.HideSelection = false;
      point = new Point(6, 108);
      this.lvPrGroup.Location = point;
      this.lvPrGroup.MultiSelect = false;
      this.lvPrGroup.Name = "lvPrGroup";
      size = new Size(136, 206);
      this.lvPrGroup.Size = size;
      this.lvPrGroup.TabIndex = 1;
      this.lvPrGroup.UseCompatibleStateImageBehavior = false;
      this.lvPrGroup.View = View.Details;
      this.ColumnHeader11.Text = "Group";
      this.ColumnHeader11.Width = 110;
      this.lvPrListing.Columns.AddRange(new ColumnHeader[3]
      {
        this.ColumnHeader6,
        this.ColumnHeader7,
        this.ColumnHeader8
      });
      this.lvPrListing.FullRowSelect = true;
      this.lvPrListing.HeaderStyle = ColumnHeaderStyle.Nonclickable;
      this.lvPrListing.HideSelection = false;
      point = new Point(6, 19);
      this.lvPrListing.Location = point;
      this.lvPrListing.MultiSelect = false;
      this.lvPrListing.Name = "lvPrListing";
      size = new Size(599, 83);
      this.lvPrListing.Size = size;
      this.lvPrListing.TabIndex = 0;
      this.lvPrListing.UseCompatibleStateImageBehavior = false;
      this.lvPrListing.View = View.Details;
      this.ColumnHeader6.Text = "Power A";
      this.ColumnHeader6.Width = 265;
      this.ColumnHeader7.Text = "";
      this.ColumnHeader7.TextAlign = HorizontalAlignment.Center;
      this.ColumnHeader7.Width = 40;
      this.ColumnHeader8.Text = "Power B";
      this.ColumnHeader8.Width = 265;
      this.GroupBox10.Controls.Add((Control) this.clbClassExclude);
      point = new Point(620, 157);
      this.GroupBox10.Location = point;
      this.GroupBox10.Name = "GroupBox10";
      size = new Size(207, 137);
      this.GroupBox10.Size = size;
      this.GroupBox10.TabIndex = 96;
      this.GroupBox10.TabStop = false;
      this.GroupBox10.Text = "Excluded Classes";
      this.clbClassExclude.FormattingEnabled = true;
      point = new Point(6, 19);
      this.clbClassExclude.Location = point;
      this.clbClassExclude.Name = "clbClassExclude";
      size = new Size(192, 109);
      this.clbClassExclude.Size = size;
      this.clbClassExclude.TabIndex = 0;
      this.GroupBox8.Controls.Add((Control) this.clbClassReq);
      point = new Point(620, 14);
      this.GroupBox8.Location = point;
      this.GroupBox8.Name = "GroupBox8";
      size = new Size(207, 137);
      this.GroupBox8.Size = size;
      this.GroupBox8.TabIndex = 95;
      this.GroupBox8.TabStop = false;
      this.GroupBox8.Text = "Reqired Classes";
      this.clbClassReq.FormattingEnabled = true;
      point = new Point(6, 19);
      this.clbClassReq.Location = point;
      this.clbClassReq.Name = "clbClassReq";
      size = new Size(192, 109);
      this.clbClassReq.Size = size;
      this.clbClassReq.TabIndex = 0;
      this.tpSpecialEnh.Controls.Add((Control) this.Label32);
      this.tpSpecialEnh.Controls.Add((Control) this.Label30);
      this.tpSpecialEnh.Controls.Add((Control) this.lvDisablePass4);
      this.tpSpecialEnh.Controls.Add((Control) this.lvDisablePass1);
      point = new Point(4, 23);
      this.tpSpecialEnh.Location = point;
      this.tpSpecialEnh.Name = "tpSpecialEnh";
      this.tpSpecialEnh.Padding = new Padding(3);
      size = new Size(832, 337);
      this.tpSpecialEnh.Size = size;
      this.tpSpecialEnh.TabIndex = 7;
      this.tpSpecialEnh.Text = "Enhancement Disabling";
      this.tpSpecialEnh.UseVisualStyleBackColor = true;
      point = new Point(246, 7);
      this.Label32.Location = point;
      this.Label32.Name = "Label32";
      size = new Size(211, 34);
      this.Label32.Size = size;
      this.Label32.TabIndex = 113;
      this.Label32.Text = "Pass Four\r\n(Buffs applied after ED)";
      point = new Point(7, 7);
      this.Label30.Location = point;
      this.Label30.Name = "Label30";
      size = new Size(211, 34);
      this.Label30.Size = size;
      this.Label30.TabIndex = 112;
      this.Label30.Text = "Pass One\r\n(Enhancements before ED is applied)";
      this.lvDisablePass4.ItemHeight = 14;
      point = new Point(245, 44);
      this.lvDisablePass4.Location = point;
      this.lvDisablePass4.Name = "lvDisablePass4";
      this.lvDisablePass4.SelectionMode = SelectionMode.MultiSimple;
      size = new Size(212, 284);
      this.lvDisablePass4.Size = size;
      this.lvDisablePass4.TabIndex = 111;
      this.lvDisablePass1.ItemHeight = 14;
      point = new Point(6, 44);
      this.lvDisablePass1.Location = point;
      this.lvDisablePass1.Name = "lvDisablePass1";
      this.lvDisablePass1.SelectionMode = SelectionMode.MultiSimple;
      size = new Size(212, 284);
      this.lvDisablePass1.Size = size;
      this.lvDisablePass1.TabIndex = 110;
      this.tpMutex.Controls.Add((Control) this.GroupBox2);
      this.tpMutex.Controls.Add((Control) this.chkMutexAuto);
      this.tpMutex.Controls.Add((Control) this.chkMutexSkip);
      point = new Point(4, 23);
      this.tpMutex.Location = point;
      this.tpMutex.Name = "tpMutex";
      size = new Size(832, 337);
      this.tpMutex.Size = size;
      this.tpMutex.TabIndex = 8;
      this.tpMutex.Text = "Mutal Exclusivity";
      this.tpMutex.UseVisualStyleBackColor = true;
      this.GroupBox2.Controls.Add((Control) this.btnMutexAdd);
      this.GroupBox2.Controls.Add((Control) this.clbMutex);
      point = new Point(9, 14);
      this.GroupBox2.Location = point;
      this.GroupBox2.Name = "GroupBox2";
      size = new Size(325, 312);
      this.GroupBox2.Size = size;
      this.GroupBox2.TabIndex = 5;
      this.GroupBox2.TabStop = false;
      this.GroupBox2.Text = "Group Membership";
      point = new Point(6, 283);
      this.btnMutexAdd.Location = point;
      this.btnMutexAdd.Name = "btnMutexAdd";
      size = new Size(124, 23);
      this.btnMutexAdd.Size = size;
      this.btnMutexAdd.TabIndex = 1;
      this.btnMutexAdd.Text = "Add New Group...";
      this.btnMutexAdd.UseVisualStyleBackColor = true;
      this.clbMutex.FormattingEnabled = true;
      point = new Point(6, 19);
      this.clbMutex.Location = point;
      this.clbMutex.Name = "clbMutex";
      size = new Size(313, 259);
      this.clbMutex.Size = size;
      this.clbMutex.TabIndex = 0;
      point = new Point(340, 57);
      this.chkMutexAuto.Location = point;
      this.chkMutexAuto.Name = "chkMutexAuto";
      size = new Size(217, 18);
      this.chkMutexAuto.Size = size;
      this.chkMutexAuto.TabIndex = 4;
      this.chkMutexAuto.Text = "Auto-Detoggle other powers";
      this.chkMutexAuto.UseVisualStyleBackColor = true;
      point = new Point(340, 33);
      this.chkMutexSkip.Location = point;
      this.chkMutexSkip.Name = "chkMutexSkip";
      size = new Size(217, 18);
      this.chkMutexSkip.Size = size;
      this.chkMutexSkip.TabIndex = 3;
      this.chkMutexSkip.Text = "Skip Mutal Exclusivity for this power";
      this.chkMutexSkip.UseVisualStyleBackColor = true;
      this.tpSubPower.Controls.Add((Control) this.btnSPAdd);
      this.tpSubPower.Controls.Add((Control) this.btnSPRemove);
      this.tpSubPower.Controls.Add((Control) this.lvSPSelected);
      this.tpSubPower.Controls.Add((Control) this.lvSPPower);
      this.tpSubPower.Controls.Add((Control) this.lvSPSet);
      this.tpSubPower.Controls.Add((Control) this.lvSPGroup);
      point = new Point(4, 23);
      this.tpSubPower.Location = point;
      this.tpSubPower.Name = "tpSubPower";
      size = new Size(832, 337);
      this.tpSubPower.Size = size;
      this.tpSubPower.TabIndex = 10;
      this.tpSubPower.Text = "Sub-Powers";
      this.tpSubPower.UseVisualStyleBackColor = true;
      point = new Point(437, 141);
      this.btnSPAdd.Location = point;
      this.btnSPAdd.Name = "btnSPAdd";
      size = new Size(48, 23);
      this.btnSPAdd.Size = size;
      this.btnSPAdd.TabIndex = 13;
      this.btnSPAdd.Text = ">>";
      this.btnSPAdd.UseVisualStyleBackColor = true;
      point = new Point(437, 170);
      this.btnSPRemove.Location = point;
      this.btnSPRemove.Name = "btnSPRemove";
      size = new Size(48, 23);
      this.btnSPRemove.Size = size;
      this.btnSPRemove.TabIndex = 12;
      this.btnSPRemove.Text = "<<";
      this.btnSPRemove.UseVisualStyleBackColor = true;
      this.lvSPSelected.Columns.AddRange(new ColumnHeader[1]
      {
        this.ColumnHeader4
      });
      this.lvSPSelected.FullRowSelect = true;
      this.lvSPSelected.HeaderStyle = ColumnHeaderStyle.Nonclickable;
      this.lvSPSelected.HideSelection = false;
      point = new Point(491, 16);
      this.lvSPSelected.Location = point;
      this.lvSPSelected.MultiSelect = false;
      this.lvSPSelected.Name = "lvSPSelected";
      size = new Size(324, 305);
      this.lvSPSelected.Size = size;
      this.lvSPSelected.TabIndex = 7;
      this.lvSPSelected.UseCompatibleStateImageBehavior = false;
      this.lvSPSelected.View = View.Details;
      this.ColumnHeader4.Text = "Power";
      this.ColumnHeader4.Width = 293;
      this.lvSPPower.Columns.AddRange(new ColumnHeader[1]
      {
        this.ColumnHeader1
      });
      this.lvSPPower.FullRowSelect = true;
      this.lvSPPower.HeaderStyle = ColumnHeaderStyle.Nonclickable;
      this.lvSPPower.HideSelection = false;
      point = new Point(295, 16);
      this.lvSPPower.Location = point;
      this.lvSPPower.MultiSelect = false;
      this.lvSPPower.Name = "lvSPPower";
      size = new Size(136, 305);
      this.lvSPPower.Size = size;
      this.lvSPPower.TabIndex = 6;
      this.lvSPPower.UseCompatibleStateImageBehavior = false;
      this.lvSPPower.View = View.Details;
      this.ColumnHeader1.Text = "Power";
      this.ColumnHeader1.Width = 110;
      this.lvSPSet.Columns.AddRange(new ColumnHeader[1]
      {
        this.ColumnHeader2
      });
      this.lvSPSet.FullRowSelect = true;
      this.lvSPSet.HeaderStyle = ColumnHeaderStyle.Nonclickable;
      this.lvSPSet.HideSelection = false;
      point = new Point(153, 16);
      this.lvSPSet.Location = point;
      this.lvSPSet.MultiSelect = false;
      this.lvSPSet.Name = "lvSPSet";
      size = new Size(136, 305);
      this.lvSPSet.Size = size;
      this.lvSPSet.TabIndex = 5;
      this.lvSPSet.UseCompatibleStateImageBehavior = false;
      this.lvSPSet.View = View.Details;
      this.ColumnHeader2.Text = "Set";
      this.ColumnHeader2.Width = 110;
      this.lvSPGroup.Columns.AddRange(new ColumnHeader[1]
      {
        this.ColumnHeader3
      });
      this.lvSPGroup.FullRowSelect = true;
      this.lvSPGroup.HeaderStyle = ColumnHeaderStyle.Nonclickable;
      this.lvSPGroup.HideSelection = false;
      point = new Point(11, 16);
      this.lvSPGroup.Location = point;
      this.lvSPGroup.MultiSelect = false;
      this.lvSPGroup.Name = "lvSPGroup";
      size = new Size(136, 305);
      this.lvSPGroup.Size = size;
      this.lvSPGroup.TabIndex = 4;
      this.lvSPGroup.UseCompatibleStateImageBehavior = false;
      this.lvSPGroup.View = View.Details;
      this.ColumnHeader3.Text = "Group";
      this.ColumnHeader3.Width = 110;
      this.btnOK.DialogResult = DialogResult.OK;
      point = new Point(740, 380);
      this.btnOK.Location = point;
      this.btnOK.Name = "btnOK";
      size = new Size(104, 36);
      this.btnOK.Size = size;
      this.btnOK.TabIndex = 3;
      this.btnOK.Text = "OK";
      this.btnCancel.DialogResult = DialogResult.Cancel;
      point = new Point(632, 380);
      this.btnCancel.Location = point;
      this.btnCancel.Name = "btnCancel";
      size = new Size(104, 36);
      this.btnCancel.Size = size;
      this.btnCancel.TabIndex = 4;
      this.btnCancel.Text = "Cancel";
      point = new Point(434, 380);
      this.btnFullPaste.Location = point;
      this.btnFullPaste.Name = "btnFullPaste";
      size = new Size(104, 36);
      this.btnFullPaste.Size = size;
      this.btnFullPaste.TabIndex = 5;
      this.btnFullPaste.Text = "Paste";
      this.btnFullPaste.UseVisualStyleBackColor = true;
      point = new Point(324, 380);
      this.btnFullCopy.Location = point;
      this.btnFullCopy.Name = "btnFullCopy";
      size = new Size(104, 36);
      this.btnFullCopy.Size = size;
      this.btnFullCopy.TabIndex = 6;
      this.btnFullCopy.Text = "Copy";
      this.btnFullCopy.UseVisualStyleBackColor = true;
      point = new Point(8, 380);
      this.btnCSVImport.Location = point;
      this.btnCSVImport.Name = "btnCSVImport";
      size = new Size(151, 36);
      this.btnCSVImport.Size = size;
      this.btnCSVImport.TabIndex = 7;
      this.btnCSVImport.Text = "Import CSV String";
      this.btnCSVImport.UseVisualStyleBackColor = true;
      this.AcceptButton = (IButtonControl) this.btnOK;
      size = new Size(5, 13);
      this.AutoScaleBaseSize = size;
      this.CancelButton = (IButtonControl) this.btnCancel;
      size = new Size(870, 428);
      this.ClientSize = size;
      this.Controls.Add((Control) this.btnCSVImport);
      this.Controls.Add((Control) this.btnFullCopy);
      this.Controls.Add((Control) this.btnFullPaste);
      this.Controls.Add((Control) this.btnCancel);
      this.Controls.Add((Control) this.btnOK);
      this.Controls.Add((Control) this.tcPower);
      this.Font = new Font("Arial", 11f, FontStyle.Regular, GraphicsUnit.Pixel, (byte) 0);
      this.FormBorderStyle = FormBorderStyle.FixedSingle;
      this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = nameof (frmEditPower);
      this.ShowInTaskbar = false;
      this.StartPosition = FormStartPosition.CenterParent;
      this.Text = "Edit Power (Group_Name.Set_Name.Power_Name)";
      this.tcPower.ResumeLayout(false);
      this.tpText.ResumeLayout(false);
      this.GroupBox4.ResumeLayout(false);
      this.GroupBox4.PerformLayout();
      this.GroupBox7.ResumeLayout(false);
      this.GroupBox6.ResumeLayout(false);
      this.GroupBox5.ResumeLayout(false);
      this.GroupBox5.PerformLayout();
      this.GroupBox3.ResumeLayout(false);
      this.GroupBox3.PerformLayout();
      this.udScaleMax.EndInit();
      this.udScaleMin.EndInit();
      this.GroupBox1.ResumeLayout(false);
      this.GroupBox1.PerformLayout();
      this.tpBasic.ResumeLayout(false);
      this.tpBasic.PerformLayout();
      this.GroupBox9.ResumeLayout(false);
      this.tpEffects.ResumeLayout(false);
      this.pnlFX.ResumeLayout(false);
      this.tpEnh.ResumeLayout(false);
      ((ISupportInitialize) this.pbEnhancements).EndInit();
      ((ISupportInitialize) this.pbEnhancementList).EndInit();
      this.tpSets.ResumeLayout(false);
      ((ISupportInitialize) this.pbInvSetList).EndInit();
      ((ISupportInitialize) this.pbInvSetUsed).EndInit();
      this.tpPreReq.ResumeLayout(false);
      this.GroupBox11.ResumeLayout(false);
      this.GroupBox10.ResumeLayout(false);
      this.GroupBox8.ResumeLayout(false);
      this.tpSpecialEnh.ResumeLayout(false);
      this.tpMutex.ResumeLayout(false);
      this.GroupBox2.ResumeLayout(false);
      this.tpSubPower.ResumeLayout(false);
      this.ResumeLayout(false);
    }

    private void lblStaticIndex_Click(object sender, EventArgs e)
    {
      string s = Interaction.InputBox("Insert new static index for this power.", "", Conversions.ToString(this.myPower.StaticIndex), -1, -1);
      try
      {
        int num1 = int.Parse(s);
        if (num1 < 0)
        {
          int num2 = (int) Interaction.MsgBox((object) "The static index cannot be a negative number.", MsgBoxStyle.Exclamation, (object) null);
        }
        else
        {
          this.lblStaticIndex.Text = Conversions.ToString(num1);
          this.myPower.StaticIndex = num1;
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        int num = (int) Interaction.MsgBox((object) ex.Message, MsgBoxStyle.OkOnly, (object) null);
        ProjectData.ClearProjectError();
      }
    }

    private void lvDisablePass1_SelectedIndexChanged(object sender, EventArgs e)
    {
      if (this.Updating)
        return;
      IPower power = this.myPower;
      this.myPower.IgnoreEnh = new Enums.eEnhance[this.lvDisablePass1.SelectedIndices.Count - 1 + 1];
      int num = this.lvDisablePass1.SelectedIndices.Count - 1;
      for (int index = 0; index <= num; ++index)
        this.myPower.IgnoreEnh[index] = (Enums.eEnhance) this.lvDisablePass1.SelectedIndices[index];
    }

    private void lvDisablePass4_SelectedIndexChanged(object sender, EventArgs e)
    {
      if (this.Updating)
        return;
      IPower power = this.myPower;
      this.myPower.Ignore_Buff = new Enums.eEnhance[this.lvDisablePass4.SelectedIndices.Count - 1 + 1];
      int num = this.lvDisablePass4.SelectedIndices.Count - 1;
      for (int index = 0; index <= num; ++index)
        this.myPower.Ignore_Buff[index] = (Enums.eEnhance) this.lvDisablePass4.SelectedIndices[index];
    }

    private void lvFX_DoubleClick(object sender, EventArgs e)
    {
      this.btnFXEdit_Click(RuntimeHelpers.GetObjectValue(sender), e);
    }

    private void lvFX_KeyPress(object sender, KeyPressEventArgs e)
    {
    }

    private void lvPrGroup_SelectedIndexChanged(object sender, EventArgs e)
    {
      if (this.ReqChanging || this.lvPrGroup.SelectedItems.Count <= 0)
        return;
      this.Req_SetList();
      if (this.lvPrSet.Items.Count > 0)
        this.lvPrSet.Items[0].Selected = true;
    }

    private void lvPrListing_SelectedIndexChanged(object sender, EventArgs e)
    {
      this.Req_Listing_IndexChanged();
    }

    private void lvPrPower_SelectedIndexChanged(object sender, EventArgs e)
    {
      if (this.ReqChanging)
        return;
      this.Req_UpdateItem();
    }

    private void lvPrSet_SelectedIndexChanged(object sender, EventArgs e)
    {
      if (this.ReqChanging || this.lvPrSet.SelectedItems.Count <= 0)
        return;
      this.Req_PowerList();
    }

    private void lvSPGroup_SelectedIndexChanged(object sender, EventArgs e)
    {
      if (this.ReqChanging || this.lvSPGroup.SelectedItems.Count <= 0)
        return;
      this.SP_SetList();
      if (this.lvSPSet.Items.Count > 0)
        this.lvSPSet.Items[0].Selected = true;
    }

    private void lvSPPower_SelectedIndexChanged(object sender, EventArgs e)
    {
    }

    private void lvSPSet_SelectedIndexChanged(object sender, EventArgs e)
    {
      if (this.ReqChanging || this.lvSPSet.SelectedItems.Count <= 0)
        return;
      this.SP_PowerList();
    }

    private void pbEnhancementList_Hover(object sender, MouseEventArgs e)
    {
      int num1 = -1;
      int num2 = -1;
      int num3 = this.enhAcross - 1;
      for (int index = 0; index <= num3; ++index)
      {
        if (e.X > (this.enhPadding + 30) * index & e.X < (this.enhPadding + 30) * (index + 1))
          num1 = index;
      }
      int num4 = 0;
      do
      {
        if (e.Y > (this.enhPadding + 30) * num4 & e.Y < (this.enhPadding + 30) * (num4 + 1))
          num2 = num4;
        ++num4;
      }
      while (num4 <= 10);
      int index1 = num1 + num2 * this.enhAcross;
      if (index1 < DatabaseAPI.Database.EnhancementClasses.Length & num1 > -1 & num2 > -1)
        this.lblEnhName.Text = DatabaseAPI.Database.EnhancementClasses[index1].Name;
      else
        this.lblEnhName.Text = "";
    }

    private void pbEnhancementList_MouseDown(object sender, MouseEventArgs e)
    {
      int num1 = -1;
      int num2 = -1;
      int num3 = this.enhAcross - 1;
      for (int index = 0; index <= num3; ++index)
      {
        if (e.X > (this.enhPadding + 30) * index & e.X < (this.enhPadding + 30) * (index + 1))
          num1 = index;
      }
      int num4 = 0;
      do
      {
        if (e.Y > (this.enhPadding + 30) * num4 & e.Y < (this.enhPadding + 30) * (num4 + 1))
          num2 = num4;
        ++num4;
      }
      while (num4 <= 10);
      int index1 = num1 + num2 * this.enhAcross;
      if (!(index1 <= DatabaseAPI.Database.EnhancementClasses.Length - 1 & num1 > -1 & num2 > -1))
        return;
      bool flag = false;
      int num5 = this.myPower.Enhancements.Length - 1;
      for (int index2 = 0; index2 <= num5; ++index2)
      {
        if (this.myPower.Enhancements[index2] == DatabaseAPI.Database.EnhancementClasses[index1].ID)
          flag = true;
      }
      if (!flag)
      {
        IPower power = this.myPower;
        int[] numArray = (int[]) Utils.CopyArray((Array) power.Enhancements, (Array) new int[this.myPower.Enhancements.Length + 1]);
        power.Enhancements = numArray;
        this.myPower.Enhancements[this.myPower.Enhancements.Length - 1] = DatabaseAPI.Database.EnhancementClasses[index1].ID;
        Array.Sort<int>(this.myPower.Enhancements);
        this.RedrawEnhList();
      }
    }

    private void pbEnhancementList_Paint(object sender, PaintEventArgs e)
    {
      if (this.bxEnhPicker == null)
        return;
      e.Graphics.DrawImageUnscaled((Image) this.bxEnhPicker.Bitmap, 0, 0);
    }

    private void pbEnhancements_Hover(object sender, MouseEventArgs e)
    {
      int num = -1;
      int length = this.myPower.Enhancements.Length;
      for (int index = 0; index <= length; ++index)
      {
        if (e.X > (this.enhPadding + 30) * index & e.X < (this.enhPadding + 30) * (index + 1))
          num = index;
      }
      int index1 = num;
      if (index1 < this.myPower.Enhancements.Length & num > -1)
        this.lblEnhName.Text = DatabaseAPI.Database.EnhancementClasses[frmEditPower.GetClassByID(this.myPower.Enhancements[index1])].Name;
      else
        this.lblEnhName.Text = "";
    }

    private void pbEnhancements_MouseDown(object sender, MouseEventArgs e)
    {
      int num1 = -1;
      int length = this.myPower.Enhancements.Length;
      for (int index = 0; index <= length; ++index)
      {
        if (e.X > (this.enhPadding + 30) * index & e.X < (this.enhPadding + 30) * (index + 1))
          num1 = index;
      }
      int num2 = num1;
      if (!(num2 < this.myPower.Enhancements.Length & num1 > -1))
        return;
      IPower power = this.myPower;
      int[] numArray = new int[power.Enhancements.Length - 1 + 1];
      int num3 = power.Enhancements.Length - 1;
      for (int index = 0; index <= num3; ++index)
        numArray[index] = power.Enhancements[index];
      int index1 = 0;
      power.Enhancements = new int[power.Enhancements.Length - 2 + 1];
      int num4 = numArray.Length - 1;
      for (int index2 = 0; index2 <= num4; ++index2)
      {
        if (index2 != num2)
        {
          power.Enhancements[index1] = numArray[index2];
          ++index1;
        }
      }
      Array.Sort<int>(power.Enhancements);
      this.RedrawEnhList();
    }

    private void pbEnhancements_Paint(object sender, PaintEventArgs e)
    {
      if (this.bxEnhPicked == null)
        return;
      e.Graphics.DrawImageUnscaled((Image) this.bxEnhPicked.Bitmap, 0, 0);
    }

    private void pbInvSetList_MouseDown(object sender, MouseEventArgs e)
    {
      Enums.eSetType eSetType = Enums.eSetType.Untyped;
      int invSetListIndex = this.GetInvSetListIndex(new Point(e.X, e.Y));
      string[] names = Enum.GetNames(eSetType.GetType());
      if (!(invSetListIndex < names.Length & invSetListIndex > -1))
        return;
      bool flag = false;
      int num = this.myPower.SetTypes.Length - 1;
      for (int index = 0; index <= num; ++index)
      {
        if (this.myPower.SetTypes[index] == (Enums.eSetType) invSetListIndex)
          flag = true;
      }
      if (!(flag | this.myPower.SetTypes.Length > 10))
      {
        IPower power = this.myPower;
        Enums.eSetType[] eSetTypeArray = (Enums.eSetType[]) Utils.CopyArray((Array) power.SetTypes, (Array) new Enums.eSetType[this.myPower.SetTypes.Length + 1]);
        power.SetTypes = eSetTypeArray;
        this.myPower.SetTypes[this.myPower.SetTypes.Length - 1] = (Enums.eSetType) invSetListIndex;
        Array.Sort<Enums.eSetType>(this.myPower.SetTypes);
        this.DrawAcceptedSets();
      }
    }

    private void pbInvSetList_MouseMove(object sender, MouseEventArgs e)
    {
      Enums.eSetType eSetType = Enums.eSetType.Untyped;
      int invSetListIndex = this.GetInvSetListIndex(new Point(e.X, e.Y));
      string[] names = Enum.GetNames(eSetType.GetType());
      if (invSetListIndex < names.Length & invSetListIndex > -1)
        this.lblInvSet.Text = names[invSetListIndex];
      else
        this.lblInvSet.Text = "";
    }

    private void pbInvSetList_Paint(object sender, PaintEventArgs e)
    {
      if (this.bxSetList == null)
        return;
      e.Graphics.DrawImageUnscaled((Image) this.bxSetList.Bitmap, 0, 0);
    }

    private void pbInvSetUsed_MouseDown(object sender, MouseEventArgs e)
    {
      int invSetIndex = this.GetInvSetIndex(new Point(e.X, e.Y));
      if (!(invSetIndex < this.myPower.SetTypes.Length & invSetIndex > -1))
        return;
      int[] numArray = new int[this.myPower.SetTypes.Length - 1 + 1];
      int num1 = this.myPower.SetTypes.Length - 1;
      for (int index = 0; index <= num1; ++index)
        numArray[index] = (int) this.myPower.SetTypes[index];
      int index1 = 0;
      this.myPower.SetTypes = new Enums.eSetType[this.myPower.SetTypes.Length - 2 + 1];
      int num2 = numArray.Length - 1;
      for (int index2 = 0; index2 <= num2; ++index2)
      {
        if (index2 != invSetIndex)
        {
          this.myPower.SetTypes[index1] = (Enums.eSetType) numArray[index2];
          ++index1;
        }
      }
      Array.Sort<Enums.eSetType>(this.myPower.SetTypes);
      this.DrawAcceptedSets();
    }

    private void pbInvSetUsed_MouseMove(object sender, MouseEventArgs e)
    {
      Enums.eSetType eSetType = Enums.eSetType.Untyped;
      int invSetIndex = this.GetInvSetIndex(new Point(e.X, e.Y));
      string[] names = Enum.GetNames(eSetType.GetType());
      if (invSetIndex < this.myPower.SetTypes.Length & invSetIndex > -1)
        this.lblInvSet.Text = names[(int) this.myPower.SetTypes[invSetIndex]];
      else
        this.lblInvSet.Text = "";
    }

    private void pbInvSetUsed_Paint(object sender, PaintEventArgs e)
    {
      if (this.bxSet == null)
        return;
      e.Graphics.DrawImageUnscaled((Image) this.bxSet.Bitmap, 0, 0);
    }

    private static bool PowerFullNameIsUnique(string iFullName, int skipId = -1)
    {
      if (!string.IsNullOrEmpty(iFullName))
      {
        int num = DatabaseAPI.Database.Power.Length - 1;
        for (int index = 0; index <= num; ++index)
        {
          if (index != skipId && string.Equals(DatabaseAPI.Database.Power[index].FullName, iFullName, StringComparison.OrdinalIgnoreCase))
            return false;
        }
      }
      return true;
    }

    private void rbFlagX_CheckedChanged(object sender, EventArgs e)
    {
      if (this.Updating)
        return;
      this.FillAdvAtrList();
    }

    private void rbPrAdd_Click(object sender, EventArgs e)
    {
      if (Interaction.MsgBox((object) "If this power is required to be present, click 'Yes'.\r\nIf this power must NOT be present, click 'No'.", MsgBoxStyle.YesNo, (object) "Query") == MsgBoxResult.No)
      {
        this.myPower.Requires.PowerIDNot = (string[][]) Utils.CopyArray((Array) this.myPower.Requires.PowerIDNot, (Array) new string[this.myPower.Requires.PowerIDNot.Length + 1][]);
        this.myPower.Requires.PowerIDNot[this.myPower.Requires.PowerIDNot.Length - 1] = new string[2];
        this.myPower.Requires.PowerIDNot[this.myPower.Requires.PowerIDNot.Length - 1][0] = "Empty";
        this.myPower.Requires.PowerIDNot[this.myPower.Requires.PowerIDNot.Length - 1][1] = "";
        this.FillTab_Req();
        this.lvPrListing.Items[this.lvPrListing.Items.Count - 1].Selected = true;
        this.lvPrListing.Items[this.lvPrListing.Items.Count - 1].EnsureVisible();
      }
      else
      {
        this.myPower.Requires.PowerID = (string[][]) Utils.CopyArray((Array) this.myPower.Requires.PowerID, (Array) new string[this.myPower.Requires.PowerID.Length + 1][]);
        this.myPower.Requires.PowerID[this.myPower.Requires.PowerID.Length - 1] = new string[2];
        this.myPower.Requires.PowerID[this.myPower.Requires.PowerID.Length - 1][0] = "Empty";
        this.myPower.Requires.PowerID[this.myPower.Requires.PowerID.Length - 1][1] = "";
        this.FillTab_Req();
        this.lvPrListing.Items[this.myPower.Requires.PowerID.Length - 1].Selected = true;
        this.lvPrListing.Items[this.myPower.Requires.PowerID.Length - 1].EnsureVisible();
      }
    }

    private void rbPrPowerX_CheckedChanged(object sender, EventArgs e)
    {
      if (sender.GetType() == this.rbPrPowerB.GetType() && ((Control) sender).Text == "Power B")
        return;
      if (this.rbPrPowerA.Checked)
        this.btnPrSetNone.Text = "Set Power A to None";
      else
        this.btnPrSetNone.Text = "Set Power B to None";
      this.Req_Listing_IndexChanged();
    }

    private void rbPrRemove_Click(object sender, EventArgs e)
    {
      if (this.lvPrListing.SelectedItems.Count < 1)
        return;
      int num1 = (int) Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.lvPrListing.SelectedItems[0].Tag)));
      if (this.lvPrListing.SelectedIndices[0] > this.myPower.Requires.PowerID.Length - 1)
      {
        string[][] strArray1 = new string[this.myPower.Requires.PowerIDNot.Length - 1 + 1][];
        int num2 = num1;
        int num3 = strArray1.Length - 1;
        for (int index = 0; index <= num3; ++index)
        {
          string[] strArray2 = new string[2];
          strArray1[index] = strArray2;
          strArray1[index][0] = this.myPower.Requires.PowerIDNot[index][0];
          strArray1[index][1] = this.myPower.Requires.PowerIDNot[index][1];
        }
        this.myPower.Requires.PowerIDNot = new string[this.myPower.Requires.PowerIDNot.Length - 2 + 1][];
        int index1 = 0;
        int num4 = strArray1.Length - 1;
        for (int index2 = 0; index2 <= num4; ++index2)
        {
          if (index2 != num2)
          {
            string[] strArray2 = new string[2];
            this.myPower.Requires.PowerIDNot[index1] = strArray2;
            this.myPower.Requires.PowerIDNot[index1][0] = strArray1[index2][0];
            this.myPower.Requires.PowerIDNot[index1][1] = strArray1[index2][1];
            ++index1;
          }
        }
      }
      else
      {
        string[][] strArray1 = new string[this.myPower.Requires.PowerID.Length - 1 + 1][];
        int num2 = num1;
        int num3 = strArray1.Length - 1;
        for (int index = 0; index <= num3; ++index)
        {
          string[] strArray2 = new string[2];
          strArray1[index] = strArray2;
          strArray1[index][0] = this.myPower.Requires.PowerID[index][0];
          strArray1[index][1] = this.myPower.Requires.PowerID[index][1];
        }
        this.myPower.Requires.PowerID = new string[this.myPower.Requires.PowerID.Length - 2 + 1][];
        int index1 = 0;
        int num4 = strArray1.Length - 1;
        for (int index2 = 0; index2 <= num4; ++index2)
        {
          if (index2 != num2)
          {
            this.myPower.Requires.PowerID[index1] = new string[2];
            this.myPower.Requires.PowerID[index1][0] = strArray1[index2][0];
            this.myPower.Requires.PowerID[index1][1] = strArray1[index2][1];
            ++index1;
          }
        }
      }
      this.FillTab_Req();
    }

    private void RedrawEnhList()
    {
      this.bxEnhPicked = new ExtendedBitmap(this.pbEnhancements.Width, this.pbEnhancements.Height);
      int enhPadding1 = this.enhPadding;
      int enhPadding2 = this.enhPadding;
      this.bxEnhPicked.Graphics.FillRectangle((Brush) new SolidBrush(Color.FromArgb(0, 0, 0)), this.bxEnhPicked.ClipRect);
      Graphics graphics = this.bxEnhPicked.Graphics;
      Pen pen = new Pen(Color.FromArgb(0, 0, (int) byte.MaxValue), 1f);
      Size size = this.bxEnhPicked.Size;
      int width = size.Width - 1;
      size = this.bxEnhPicked.Size;
      int height = size.Height - 1;
      graphics.DrawRectangle(pen, 0, 0, width, height);
      int num = this.myPower.Enhancements.Length - 1;
      for (int index = 0; index <= num; ++index)
      {
        Rectangle destRect = new Rectangle(enhPadding2, enhPadding1, 30, 30);
        this.bxEnhPicked.Graphics.DrawImage((Image) I9Gfx.Classes.Bitmap, destRect, I9Gfx.GetImageRect(frmEditPower.GetClassByID(this.myPower.Enhancements[index])), GraphicsUnit.Pixel);
        enhPadding2 += 30 + this.enhPadding;
      }
      this.pbEnhancements.CreateGraphics().DrawImageUnscaled((Image) this.bxEnhPicked.Bitmap, 0, 0);
    }

    private void RedrawEnhPicker()
    {
      this.pbEnhancementList.Width = (this.enhPadding + 30) * this.enhAcross + this.enhPadding;
      this.pbEnhancementList.Height = (this.enhPadding + 30) * 6 + this.enhPadding;
      this.bxEnhPicker = new ExtendedBitmap(this.pbEnhancementList.Width, this.pbEnhancementList.Height);
      int enhPadding1 = this.enhPadding;
      int enhPadding2 = this.enhPadding;
      int num1 = 0;
      this.bxEnhPicker.Graphics.FillRectangle((Brush) new SolidBrush(Color.FromArgb(0, 0, 0)), this.bxEnhPicker.ClipRect);
      Graphics graphics = this.bxEnhPicker.Graphics;
      Pen pen = new Pen(Color.FromArgb(0, 0, (int) byte.MaxValue), 1f);
      Size size = this.bxEnhPicker.Size;
      int width = size.Width - 1;
      size = this.bxEnhPicker.Size;
      int height = size.Height - 1;
      graphics.DrawRectangle(pen, 0, 0, width, height);
      int num2 = DatabaseAPI.Database.EnhancementClasses.Length - 1;
      for (int index = 0; index <= num2; ++index)
      {
        Rectangle destRect = new Rectangle(enhPadding2, enhPadding1, 30, 30);
        this.bxEnhPicker.Graphics.DrawImage((Image) I9Gfx.Classes.Bitmap, destRect, I9Gfx.GetImageRect(index), GraphicsUnit.Pixel);
        enhPadding2 += 30 + this.enhPadding;
        ++num1;
        if (num1 == this.enhAcross)
        {
          num1 = 0;
          enhPadding2 = this.enhPadding;
          enhPadding1 += 30 + this.enhPadding;
        }
      }
      this.pbEnhancementList.CreateGraphics().DrawImageUnscaled((Image) this.bxEnhPicker.Bitmap, 0, 0);
    }

    private void refresh_PowerData()
    {
      this.Text = "Edit Power (" + this.myPower.FullName + ")";
      this.lblStaticIndex.Text = Conversions.ToString(this.myPower.StaticIndex);
      this.FillCombo_Basic();
      this.FillTab_Basic();
      this.FillCombo_Attribs();
      this.FillTab_Attribs();
      this.FillTab_Effects();
      this.FillTab_Enhancements();
      this.FillTab_Sets();
      this.FillTab_Req();
      this.Filltab_ReqClasses();
      this.FillTab_Disabling();
      this.FillTab_Mutex();
      this.SetDynamics();
    }

    private void RefreshFXData(int Index = 0)
    {
      IPower power = this.myPower;
      this.lvFX.BeginUpdate();
      this.lvFX.Items.Clear();
      int num = power.Effects.Length - 1;
      for (int index = 0; index <= num; ++index)
        this.lvFX.Items.Add((object) power.Effects[index].BuildEffectString(false, "", false, false, true).Replace("\r\n", " - "));
      this.lvFX.EndUpdate();
      if (this.lvFX.Items.Count > Index)
        this.lvFX.SelectedIndex = Index;
      else
        this.lvFX.SelectedIndex = this.lvFX.Items.Count - 1;
    }

    private void Req_GroupList()
    {
      this.lvPrGroup.BeginUpdate();
      this.lvPrGroup.Items.Clear();
      foreach (string key in (IEnumerable<string>) DatabaseAPI.Database.PowersetGroups.Keys)
        this.lvPrGroup.Items.Add(key);
      this.lvPrGroup.EndUpdate();
    }

    private void Req_Listing_IndexChanged()
    {
      if (this.lvPrListing.SelectedIndices.Count < 1)
        return;
      int index = (int) Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.lvPrListing.SelectedItems[0].Tag)));
      this.ReqDisplayPower(this.lvPrListing.SelectedIndices[0] <= this.myPower.Requires.PowerID.Length - 1 ? (!this.rbPrPowerA.Checked ? this.myPower.Requires.PowerID[index][1] : this.myPower.Requires.PowerID[index][0]) : (!this.rbPrPowerA.Checked ? this.myPower.Requires.PowerIDNot[index][1] : this.myPower.Requires.PowerIDNot[index][0]));
    }

    private void Req_PowerList()
    {
      this.lvPrPower.BeginUpdate();
      this.lvPrPower.Items.Clear();
      if (this.lvPrSet.SelectedIndices.Count < 1)
      {
        this.lvPrPower.EndUpdate();
      }
      else
      {
        int index1 = DatabaseAPI.NidFromUidPowerset(Conversions.ToString(this.lvPrSet.SelectedItems[0].Tag));
        if (index1 > -1)
        {
          int num = DatabaseAPI.Database.Powersets[index1].Powers.Length - 1;
          for (int index2 = 0; index2 <= num; ++index2)
          {
            if (!DatabaseAPI.Database.Powersets[index1].Powers[index2].HiddenPower)
              this.lvPrPower.Items.Add(DatabaseAPI.Database.Powersets[index1].Powers[index2].PowerName);
          }
        }
        this.lvPrPower.EndUpdate();
      }
    }

    private void Req_SetList()
    {
      this.lvPrSet.BeginUpdate();
      this.lvPrSet.Items.Clear();
      if (this.lvPrGroup.SelectedIndices.Count < 1)
      {
        this.lvPrSet.EndUpdate();
      }
      else
      {
        int[] indexesByGroupName = DatabaseAPI.GetPowersetIndexesByGroupName(this.lvPrGroup.SelectedItems[0].Text);
        int num = indexesByGroupName.Length - 1;
        for (int index = 0; index <= num; ++index)
        {
          this.lvPrSet.Items.Add(DatabaseAPI.Database.Powersets[indexesByGroupName[index]].SetName);
          this.lvPrSet.Items[this.lvPrSet.Items.Count - 1].Tag = (object) DatabaseAPI.Database.Powersets[indexesByGroupName[index]].FullName;
        }
        this.lvPrSet.EndUpdate();
      }
    }

    private void Req_UpdateItem()
    {
      if (this.lvPrListing.SelectedIndices.Count < 1 | this.lvPrGroup.SelectedIndices.Count < 1 | this.lvPrSet.SelectedIndices.Count < 1 | this.lvPrPower.SelectedIndices.Count < 1)
        return;
      string str = this.lvPrGroup.SelectedItems[0].Text + "." + this.lvPrSet.SelectedItems[0].Text + "." + this.lvPrPower.SelectedItems[0].Text;
      int index = (int) Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.lvPrListing.SelectedItems[0].Tag)));
      if (this.lvPrListing.SelectedIndices[0] > this.myPower.Requires.PowerID.Length - 1)
      {
        if (this.rbPrPowerA.Checked)
        {
          this.myPower.Requires.PowerIDNot[index][0] = str;
          this.lvPrListing.SelectedItems[0].SubItems[0].Text = "NOT " + str;
        }
        else
        {
          this.myPower.Requires.PowerIDNot[index][1] = str;
          this.lvPrListing.SelectedItems[0].SubItems[2].Text = "NOT " + str;
        }
      }
      else if (this.rbPrPowerA.Checked)
      {
        this.myPower.Requires.PowerID[index][0] = str;
        this.lvPrListing.SelectedItems[0].SubItems[0].Text = str;
      }
      else
      {
        this.myPower.Requires.PowerID[index][1] = str;
        this.lvPrListing.SelectedItems[0].SubItems[2].Text = str;
      }
    }

    private void ReqDisplayPower(string iPower)
    {
      this.ReqChanging = true;
      string[] strArray = iPower.Split(".".ToCharArray());
      if (strArray.Length > 0)
      {
        int num = this.lvPrGroup.Items.Count - 1;
        for (int index = 0; index <= num; ++index)
        {
          if (string.Equals(this.lvPrGroup.Items[index].Text, strArray[0], StringComparison.OrdinalIgnoreCase))
          {
            this.lvPrGroup.Items[index].Selected = true;
            this.lvPrGroup.Items[index].EnsureVisible();
            break;
          }
        }
      }
      this.Req_SetList();
      if (strArray.Length > 1)
      {
        int num = this.lvPrSet.Items.Count - 1;
        for (int index = 0; index <= num; ++index)
        {
          if (string.Equals(this.lvPrSet.Items[index].Text, strArray[1], StringComparison.OrdinalIgnoreCase))
          {
            this.lvPrSet.Items[index].Selected = true;
            this.lvPrSet.Items[index].EnsureVisible();
            break;
          }
        }
      }
      this.Req_PowerList();
      if (strArray.Length > 2)
      {
        int num = this.lvPrPower.Items.Count - 1;
        for (int index = 0; index <= num; ++index)
        {
          if (string.Equals(this.lvPrPower.Items[index].Text, strArray[2], StringComparison.OrdinalIgnoreCase))
          {
            this.lvPrPower.Items[index].Selected = true;
            this.lvPrPower.Items[index].EnsureVisible();
            break;
          }
        }
      }
      this.ReqChanging = false;
    }

    private void SetDynamics()
    {
      IPower power = this.myPower;
      this.chkBuffCycle.Enabled = power.PowerType == Enums.ePowerType.Click;
      this.chkAlwaysToggle.Enabled = power.PowerType == Enums.ePowerType.Toggle;
      if ((double) power.ActivatePeriod > 0.0 & power.PowerType == Enums.ePowerType.Toggle)
        this.lblEndCost.Text = "(" + Strings.Format((object) (float) ((double) power.EndCost / (double) power.ActivatePeriod), "##0" + NumberFormatInfo.CurrentInfo.NumberDecimalSeparator + "##") + "/s)";
      else
        this.lblEndCost.Text = "";
      this.lblAcc.Text = "(" + Strings.Format((object) (float) ((double) power.Accuracy * (double) MidsContext.Config.BaseAcc * 100.0), "##0" + NumberFormatInfo.CurrentInfo.NumberDecimalSeparator + "#") + "%)";
    }

    private void SetFullName()
    {
      IPower power = this.myPower;
      power.FullName = power.GroupName + "." + power.SetName + "." + power.PowerName;
    }

    private void SP_GroupList()
    {
      this.lvSPGroup.BeginUpdate();
      this.lvSPGroup.Items.Clear();
      foreach (string key in (IEnumerable<string>) DatabaseAPI.Database.PowersetGroups.Keys)
        this.lvSPGroup.Items.Add(key);
      this.lvSPGroup.EndUpdate();
    }

    private void SP_PowerList()
    {
      this.lvSPPower.BeginUpdate();
      this.lvSPPower.Items.Clear();
      if (this.lvSPSet.SelectedIndices.Count < 1)
      {
        this.lvSPPower.EndUpdate();
      }
      else
      {
        int index1 = DatabaseAPI.NidFromUidPowerset(Conversions.ToString(this.lvSPSet.SelectedItems[0].Tag));
        if (index1 > -1)
        {
          int num = DatabaseAPI.Database.Powersets[index1].Powers.Length - 1;
          for (int index2 = 0; index2 <= num; ++index2)
          {
            if (!DatabaseAPI.Database.Powersets[index1].Powers[index2].HiddenPower)
            {
              this.lvSPPower.Items.Add(DatabaseAPI.Database.Powersets[index1].Powers[index2].PowerName);
              this.lvSPPower.Items[this.lvSPPower.Items.Count - 1].Tag = (object) DatabaseAPI.Database.Powersets[index1].Powers[index2].FullName;
            }
          }
        }
        this.lvSPPower.EndUpdate();
      }
    }

    private void SP_SetList()
    {
      this.lvSPSet.BeginUpdate();
      this.lvSPSet.Items.Clear();
      if (this.lvSPGroup.SelectedIndices.Count < 1)
      {
        this.lvSPSet.EndUpdate();
      }
      else
      {
        int[] indexesByGroupName = DatabaseAPI.GetPowersetIndexesByGroupName(this.lvSPGroup.SelectedItems[0].Text);
        int num = indexesByGroupName.Length - 1;
        for (int index = 0; index <= num; ++index)
        {
          this.lvSPSet.Items.Add(DatabaseAPI.Database.Powersets[indexesByGroupName[index]].SetName);
          this.lvSPSet.Items[this.lvSPSet.Items.Count - 1].Tag = (object) DatabaseAPI.Database.Powersets[indexesByGroupName[index]].FullName;
        }
        this.lvSPSet.EndUpdate();
      }
    }

    private void SPFillList()
    {
      this.lvSPSelected.BeginUpdate();
      this.lvSPSelected.Items.Clear();
      int num = this.myPower.UIDSubPower.Length - 1;
      for (int index = 0; index <= num; ++index)
        this.lvSPSelected.Items.Add(this.myPower.UIDSubPower[index]);
      this.lvSPSelected.EndUpdate();
    }

    private void Store_Req_Classes()
    {
      this.myPower.Requires.ClassName = new string[this.clbClassReq.CheckedIndices.Count - 1 + 1];
      int num1 = this.clbClassReq.CheckedIndices.Count - 1;
      for (int index = 0; index <= num1; ++index)
        this.myPower.Requires.ClassName[index] = DatabaseAPI.Database.Classes[this.clbClassReq.CheckedIndices[index]].ClassName;
      this.myPower.Requires.ClassNameNot = new string[this.clbClassExclude.CheckedIndices.Count - 1 + 1];
      int num2 = this.clbClassExclude.CheckedIndices.Count - 1;
      for (int index = 0; index <= num2; ++index)
        this.myPower.Requires.ClassNameNot[index] = DatabaseAPI.Database.Classes[this.clbClassExclude.CheckedIndices[index]].ClassName;
    }

    private void txtAcc_Leave(object sender, EventArgs e)
    {
      if (this.Updating)
        return;
      this.txtAcc.Text = Conversions.ToString(this.myPower.Accuracy);
    }

    private void txtAcc_TextChanged(object sender, EventArgs e)
    {
      if (this.Updating)
        return;
      IPower power = this.myPower;
      float num = (float) Conversion.Val(this.txtAcc.Text);
      if ((double) num >= 0.0 & (double) num <= 100.0)
        power.Accuracy = num;
    }

    private void txtActivate_Leave(object sender, EventArgs e)
    {
      if (this.Updating)
        return;
      this.txtActivate.Text = Conversions.ToString(this.myPower.ActivatePeriod);
    }

    private void txtActivate_TextChanged(object sender, EventArgs e)
    {
      if (this.Updating)
        return;
      IPower power = this.myPower;
      float num = (float) Conversion.Val(this.txtActivate.Text);
      if ((double) num >= 0.0 & (double) num <= 2147483904.0)
        power.ActivatePeriod = num;
    }

    private void txtArc_Leave(object sender, EventArgs e)
    {
      if (this.Updating)
        return;
      this.txtArc.Text = Conversions.ToString(this.myPower.Arc);
    }

    private void txtArc_TextChanged(object sender, EventArgs e)
    {
      if (this.Updating)
        return;
      IPower power = this.myPower;
      float num = (float) Conversion.Val(this.txtArc.Text);
      if ((double) num >= 0.0 & (double) num <= 2147483904.0)
        power.Arc = (int) Math.Round((double) num);
    }

    private void txtCastTime_Leave(object sender, EventArgs e)
    {
      if (this.Updating)
        return;
      this.txtCastTime.Text = Conversions.ToString(this.myPower.CastTimeReal);
    }

    private void txtCastTime_TextChanged(object sender, EventArgs e)
    {
      if (this.Updating)
        return;
      IPower power = this.myPower;
      float num = (float) Conversion.Val(this.txtCastTime.Text);
      if ((double) num >= 0.0 & (double) num <= 100.0)
        power.CastTimeReal = num;
    }

    private void txtDescLong_TextChanged(object sender, EventArgs e)
    {
      if (this.Updating)
        return;
      this.myPower.DescLong = this.txtDescLong.Text;
    }

    private void txtDescShort_TextChanged(object sender, EventArgs e)
    {
      if (this.Updating)
        return;
      this.myPower.DescShort = this.txtDescShort.Text;
    }

    private void txtEndCost_Leave(object sender, EventArgs e)
    {
      if (this.Updating)
        return;
      this.txtEndCost.Text = Conversions.ToString(this.myPower.EndCost);
    }

    private void txtEndCost_TextChanged(object sender, EventArgs e)
    {
      if (this.Updating)
        return;
      IPower power = this.myPower;
      float num = (float) Conversion.Val(this.txtEndCost.Text);
      if ((double) num >= 0.0 & (double) num <= 2147483904.0)
        power.EndCost = num;
    }

    private void txtInterrupt_Leave(object sender, EventArgs e)
    {
      if (this.Updating)
        return;
      this.txtInterrupt.Text = Conversions.ToString(this.myPower.InterruptTime);
    }

    private void txtInterrupt_TextChanged(object sender, EventArgs e)
    {
      if (this.Updating)
        return;
      IPower power = this.myPower;
      float num = (float) Conversion.Val(this.txtInterrupt.Text);
      if ((double) num >= 0.0 & (double) num <= 100.0)
        power.InterruptTime = num;
    }

    private void txtLevel_Leave(object sender, EventArgs e)
    {
      if (this.Updating)
        return;
      this.txtLevel.Text = Conversions.ToString(this.myPower.Level);
    }

    private void txtLevel_TextChanged(object sender, EventArgs e)
    {
      if (this.Updating)
        return;
      IPower power = this.myPower;
      int num = (int) Math.Round(Conversion.Val(this.txtLevel.Text));
      if (num >= 0 & num < 51)
        power.Level = num;
    }

    private void txtLifeTimeGame_Leave(object sender, EventArgs e)
    {
      if (this.Updating)
        return;
      this.txtLifeTimeGame.Text = Conversions.ToString(this.myPower.LifeTimeInGame);
    }

    private void txtLifeTimeGame_TextChanged(object sender, EventArgs e)
    {
      if (this.Updating)
        return;
      IPower power = this.myPower;
      float num = (float) Conversion.Val(this.txtLifeTimeGame.Text);
      if ((double) num >= 0.0 & (double) num < 2147483904.0)
        power.LifeTimeInGame = (int) Math.Round((double) num);
    }

    private void txtLifeTimeReal_Leave(object sender, EventArgs e)
    {
      if (this.Updating)
        return;
      this.txtLifeTimeReal.Text = Conversions.ToString(this.myPower.LifeTime);
    }

    private void txtLifeTimeReal_TextChanged(object sender, EventArgs e)
    {
      if (this.Updating)
        return;
      IPower power = this.myPower;
      float num = (float) Conversion.Val(this.txtLifeTimeReal.Text);
      if ((double) num >= 0.0 & (double) num < 2147483904.0)
        power.LifeTime = (int) Math.Round((double) num);
    }

    private void txtMaxTargets_Leave(object sender, EventArgs e)
    {
      if (this.Updating)
        return;
      this.txtMaxTargets.Text = Conversions.ToString(this.myPower.MaxTargets);
    }

    private void txtMaxTargets_TextChanged(object sender, EventArgs e)
    {
      if (this.Updating)
        return;
      IPower power = this.myPower;
      float num = (float) Conversion.Val(this.txtMaxTargets.Text);
      if ((double) num >= 0.0 & (double) num <= 2147483904.0)
        power.MaxTargets = (int) Math.Round((double) num);
    }

    private void txtNamePower_Leave(object sender, EventArgs e)
    {
      if (this.Updating)
        return;
      this.DisplayNameData();
    }

    private void txtNamePower_TextChanged(object sender, EventArgs e)
    {
      if (this.Updating)
        return;
      this.myPower.PowerName = this.txtNamePower.Text;
      this.SetFullName();
    }

    private void txtNumCharges_Leave(object sender, EventArgs e)
    {
      if (this.Updating)
        return;
      this.txtNumCharges.Text = Conversions.ToString(this.myPower.NumCharges);
    }

    private void txtNumCharges_TextChanged(object sender, EventArgs e)
    {
      if (this.Updating)
        return;
      IPower power = this.myPower;
      float num = (float) Conversion.Val(this.txtNumCharges.Text);
      if ((double) num >= 0.0 & (double) num < 2147483904.0)
        power.NumCharges = (int) Math.Round((double) num);
    }

    private void txtPowerName_TextChanged(object sender, EventArgs e)
    {
      if (this.Updating)
        return;
      this.myPower.DisplayName = this.txtNameDisplay.Text;
    }

    private void txtRadius_Leave(object sender, EventArgs e)
    {
      if (this.Updating)
        return;
      this.txtRadius.Text = Conversions.ToString(this.myPower.Radius);
    }

    private void txtRadius_TextChanged(object sender, EventArgs e)
    {
      if (this.Updating)
        return;
      IPower power = this.myPower;
      float num = (float) Conversion.Val(this.txtRadius.Text);
      if ((double) num >= 0.0 & (double) num <= 2147483904.0)
        power.Radius = (float) (int) Math.Round((double) num);
    }

    private void txtRange_Leave(object sender, EventArgs e)
    {
      if (this.Updating)
        return;
      this.txtRange.Text = Conversions.ToString(this.myPower.Range);
    }

    private void txtRange_TextChanged(object sender, EventArgs e)
    {
      if (this.Updating)
        return;
      IPower power = this.myPower;
      float num = (float) Conversion.Val(this.txtRange.Text);
      if ((double) num >= 0.0 & (double) num < 2147483904.0)
        power.Range = num;
    }

    private void txtRangeSec_Leave(object sender, EventArgs e)
    {
      if (this.Updating)
        return;
      this.txtRangeSec.Text = Conversions.ToString(this.myPower.RangeSecondary);
    }

    private void txtRangeSec_TextChanged(object sender, EventArgs e)
    {
      if (this.Updating)
        return;
      IPower power = this.myPower;
      float num = (float) Conversion.Val(this.txtRangeSec.Text);
      if ((double) num >= 0.0 & (double) num < 2147483904.0)
        power.RangeSecondary = num;
    }

    private void txtRechargeTime_Leave(object sender, EventArgs e)
    {
      if (this.Updating)
        return;
      this.txtRechargeTime.Text = Conversions.ToString(this.myPower.RechargeTime);
    }

    private void txtRechargeTime_TextChanged(object sender, EventArgs e)
    {
      if (this.Updating)
        return;
      IPower power = this.myPower;
      float num = (float) Conversion.Val(this.txtRechargeTime.Text);
      if ((double) num >= 0.0 & (double) num <= 2147483904.0)
        power.RechargeTime = num;
    }

    private void txtScaleName_TextChanged(object sender, EventArgs e)
    {
      if (this.Updating)
        return;
      this.myPower.VariableName = this.txtScaleName.Text;
    }

    private void txtUseageTime_Leave(object sender, EventArgs e)
    {
      if (this.Updating)
        return;
      this.txtUseageTime.Text = Conversions.ToString(this.myPower.UsageTime);
    }

    private void txtUseageTime_TextChanged(object sender, EventArgs e)
    {
      if (this.Updating)
        return;
      IPower power = this.myPower;
      float num = (float) Conversion.Val(this.txtUseageTime.Text);
      if ((double) num >= 0.0 & (double) num < 2147483904.0)
        power.UsageTime = (int) Math.Round((double) num);
    }

    private void txtVisualLocation_Leave(object sender, EventArgs e)
    {
      if (this.Updating)
        return;
      this.txtVisualLocation.Text = Conversions.ToString(this.myPower.DisplayLocation);
    }

    private void txtVisualLocation_TextChanged(object sender, EventArgs e)
    {
      if (this.Updating)
        return;
      IPower power = this.myPower;
      float num = (float) Conversion.Val(this.txtVisualLocation.Text);
      if ((double) num >= 0.0 & (double) num <= 2147483904.0)
        power.DisplayLocation = (int) Math.Round((double) num);
    }

    private void udScaleMax_KeyPress(object sender, KeyPressEventArgs e)
    {
      this.CheckScaleValues();
    }

    private void udScaleMax_Leave(object sender, EventArgs e)
    {
      this.myPower.VariableMax = (int) Math.Round(Conversion.Val(this.udScaleMax.Text));
      this.CheckScaleValues();
    }

    private void udScaleMax_ValueChanged(object sender, EventArgs e)
    {
      this.myPower.VariableMax = Convert.ToInt32(this.udScaleMax.Value);
      this.CheckScaleValues();
    }

    private void udScaleMin_KeyPress(object sender, KeyPressEventArgs e)
    {
      this.CheckScaleValues();
    }

    private void udScaleMin_Leave(object sender, EventArgs e)
    {
      this.myPower.VariableMin = (int) Math.Round(Conversion.Val(this.udScaleMin.Text));
      this.CheckScaleValues();
    }

    private void udScaleMin_ValueChanged(object sender, EventArgs e)
    {
      this.myPower.VariableMin = Convert.ToInt32(this.udScaleMin.Value);
      this.CheckScaleValues();
    }
  }
}
