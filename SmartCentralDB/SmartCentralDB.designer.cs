﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DB
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	public partial class SmartCentralDB : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertCentral(Central instance);
    partial void UpdateCentral(Central instance);
    partial void DeleteCentral(Central instance);
    partial void InsertCabina(Cabina instance);
    partial void UpdateCabina(Cabina instance);
    partial void DeleteCabina(Cabina instance);
    partial void InsertDP(DP instance);
    partial void UpdateDP(DP instance);
    partial void DeleteDP(DP instance);
    partial void InsertUser(User instance);
    partial void UpdateUser(User instance);
    partial void DeleteUser(User instance);
    partial void InsertCabel(Cabel instance);
    partial void UpdateCabel(Cabel instance);
    partial void DeleteCabel(Cabel instance);
    partial void Insertj(j instance);
    partial void Updatej(j instance);
    partial void Deletej(j instance);
    #endregion
		
		public SmartCentralDB() : 
				base(global::SmartCentralDB.Properties.Settings.Default.DataSourceConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public SmartCentralDB(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public SmartCentralDB(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public SmartCentralDB(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public SmartCentralDB(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Central> Centrals
		{
			get
			{
				return this.GetTable<Central>();
			}
		}
		
		public System.Data.Linq.Table<Cabina> Cabinas
		{
			get
			{
				return this.GetTable<Cabina>();
			}
		}
		
		public System.Data.Linq.Table<DP> DPs
		{
			get
			{
				return this.GetTable<DP>();
			}
		}
		
		public System.Data.Linq.Table<User> Users
		{
			get
			{
				return this.GetTable<User>();
			}
		}
		
		public System.Data.Linq.Table<Cabel> Cabels
		{
			get
			{
				return this.GetTable<Cabel>();
			}
		}
		
		public System.Data.Linq.Table<j> js
		{
			get
			{
				return this.GetTable<j>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="Centrals")]
	public partial class Central : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _IDcentral = default(int);
		
		private string _CentralName;
		
		private EntitySet<Cabel> _Cabels;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnCentralNameChanging(string value);
    partial void OnCentralNameChanged();
    #endregion
		
		public Central()
		{
			this._Cabels = new EntitySet<Cabel>(new Action<Cabel>(this.attach_Cabels), new Action<Cabel>(this.detach_Cabels));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IDcentral", AutoSync=AutoSync.OnInsert, IsPrimaryKey=true, IsDbGenerated=true, UpdateCheck=UpdateCheck.Never)]
		public int IDcentral
		{
			get
			{
				return this._IDcentral;
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CentralName", DbType="nvarchar(30)", CanBeNull=false)]
		public string CentralName
		{
			get
			{
				return this._CentralName;
			}
			set
			{
				if ((this._CentralName != value))
				{
					this.OnCentralNameChanging(value);
					this.SendPropertyChanging();
					this._CentralName = value;
					this.SendPropertyChanged("CentralName");
					this.OnCentralNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Central_Cabel", Storage="_Cabels", ThisKey="IDcentral", OtherKey="IDcentral")]
		public EntitySet<Cabel> Cabels
		{
			get
			{
				return this._Cabels;
			}
			set
			{
				this._Cabels.Assign(value);
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_Cabels(Cabel entity)
		{
			this.SendPropertyChanging();
			entity.Central = this;
		}
		
		private void detach_Cabels(Cabel entity)
		{
			this.SendPropertyChanging();
			entity.Central = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="Cabinas")]
	public partial class Cabina : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _IDcabina;
		
		private int _IDCable;
		
		private string _CABINA;
		
		private string _Area;
		
		private string _picture;
		
		private string _Xaxes;
		
		private string _Yaxes;
		
		private string _CabinaGeneral;
		
		private string _ODU;
		
		private EntitySet<DP> _DPs;
		
		private EntityRef<Cabel> _Cabel;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDcabinaChanging(int value);
    partial void OnIDcabinaChanged();
    partial void OnIDCableChanging(int value);
    partial void OnIDCableChanged();
    partial void OnCABINAChanging(string value);
    partial void OnCABINAChanged();
    partial void OnAreaChanging(string value);
    partial void OnAreaChanged();
    partial void OnpictureChanging(string value);
    partial void OnpictureChanged();
    partial void OnXaxesChanging(string value);
    partial void OnXaxesChanged();
    partial void OnYaxesChanging(string value);
    partial void OnYaxesChanged();
    partial void OnCabinaGeneralChanging(string value);
    partial void OnCabinaGeneralChanged();
    partial void OnODUChanging(string value);
    partial void OnODUChanged();
    #endregion
		
		public Cabina()
		{
			this._DPs = new EntitySet<DP>(new Action<DP>(this.attach_DPs), new Action<DP>(this.detach_DPs));
			this._Cabel = default(EntityRef<Cabel>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IDcabina", AutoSync=AutoSync.OnInsert, IsPrimaryKey=true, IsDbGenerated=true, UpdateCheck=UpdateCheck.Never)]
		public int IDcabina
		{
			get
			{
				return this._IDcabina;
			}
			set
			{
				if ((this._IDcabina != value))
				{
					this.OnIDcabinaChanging(value);
					this.SendPropertyChanging();
					this._IDcabina = value;
					this.SendPropertyChanged("IDcabina");
					this.OnIDcabinaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IDCable", DbType="int")]
		public int IDCable
		{
			get
			{
				return this._IDCable;
			}
			set
			{
				if ((this._IDCable != value))
				{
					if (this._Cabel.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnIDCableChanging(value);
					this.SendPropertyChanging();
					this._IDCable = value;
					this.SendPropertyChanged("IDCable");
					this.OnIDCableChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CABINA", DbType="nvarchar(10)", CanBeNull=false)]
		public string CABINA
		{
			get
			{
				return this._CABINA;
			}
			set
			{
				if ((this._CABINA != value))
				{
					this.OnCABINAChanging(value);
					this.SendPropertyChanging();
					this._CABINA = value;
					this.SendPropertyChanged("CABINA");
					this.OnCABINAChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Area", DbType="nvarchar(200)", CanBeNull=false)]
		public string Area
		{
			get
			{
				return this._Area;
			}
			set
			{
				if ((this._Area != value))
				{
					this.OnAreaChanging(value);
					this.SendPropertyChanging();
					this._Area = value;
					this.SendPropertyChanged("Area");
					this.OnAreaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_picture", DbType="nvarchar(1)", CanBeNull=false)]
		public string picture
		{
			get
			{
				return this._picture;
			}
			set
			{
				if ((this._picture != value))
				{
					this.OnpictureChanging(value);
					this.SendPropertyChanging();
					this._picture = value;
					this.SendPropertyChanged("picture");
					this.OnpictureChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Xaxes", DbType="nvarchar(1)", CanBeNull=false)]
		public string Xaxes
		{
			get
			{
				return this._Xaxes;
			}
			set
			{
				if ((this._Xaxes != value))
				{
					this.OnXaxesChanging(value);
					this.SendPropertyChanging();
					this._Xaxes = value;
					this.SendPropertyChanged("Xaxes");
					this.OnXaxesChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Yaxes", DbType="nvarchar(1)", CanBeNull=false)]
		public string Yaxes
		{
			get
			{
				return this._Yaxes;
			}
			set
			{
				if ((this._Yaxes != value))
				{
					this.OnYaxesChanging(value);
					this.SendPropertyChanging();
					this._Yaxes = value;
					this.SendPropertyChanged("Yaxes");
					this.OnYaxesChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CabinaGeneral", DbType="nvarchar(30)", CanBeNull=false)]
		public string CabinaGeneral
		{
			get
			{
				return this._CabinaGeneral;
			}
			set
			{
				if ((this._CabinaGeneral != value))
				{
					this.OnCabinaGeneralChanging(value);
					this.SendPropertyChanging();
					this._CabinaGeneral = value;
					this.SendPropertyChanged("CabinaGeneral");
					this.OnCabinaGeneralChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ODU", DbType="nvarchar(10)", CanBeNull=false)]
		public string ODU
		{
			get
			{
				return this._ODU;
			}
			set
			{
				if ((this._ODU != value))
				{
					this.OnODUChanging(value);
					this.SendPropertyChanging();
					this._ODU = value;
					this.SendPropertyChanged("ODU");
					this.OnODUChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Cabina_DP", Storage="_DPs", ThisKey="IDcabina", OtherKey="IDcabina")]
		public EntitySet<DP> DPs
		{
			get
			{
				return this._DPs;
			}
			set
			{
				this._DPs.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Cabel_Cabina", Storage="_Cabel", ThisKey="IDCable", OtherKey="IDCable", IsForeignKey=true)]
		public Cabel Cabel
		{
			get
			{
				return this._Cabel.Entity;
			}
			set
			{
				Cabel previousValue = this._Cabel.Entity;
				if (((previousValue != value) 
							|| (this._Cabel.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Cabel.Entity = null;
						previousValue.Cabinas.Remove(this);
					}
					this._Cabel.Entity = value;
					if ((value != null))
					{
						value.Cabinas.Add(this);
						this._IDCable = value.IDCable;
					}
					else
					{
						this._IDCable = default(int);
					}
					this.SendPropertyChanged("Cabel");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_DPs(DP entity)
		{
			this.SendPropertyChanging();
			entity.Cabina = this;
		}
		
		private void detach_DPs(DP entity)
		{
			this.SendPropertyChanging();
			entity.Cabina = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="DPs")]
	public partial class DP : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _IDdp;
		
		private int _IDcabina;
		
		private string _Area;
		
		private string _picture;
		
		private string _Xaxes;
		
		private string _Yaxes;
		
		private string _DPNumber;
		
		private string _DPGeneral;
		
		private EntityRef<Cabina> _Cabina;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDdpChanging(int value);
    partial void OnIDdpChanged();
    partial void OnIDcabinaChanging(int value);
    partial void OnIDcabinaChanged();
    partial void OnAreaChanging(string value);
    partial void OnAreaChanged();
    partial void OnpictureChanging(string value);
    partial void OnpictureChanged();
    partial void OnXaxesChanging(string value);
    partial void OnXaxesChanged();
    partial void OnYaxesChanging(string value);
    partial void OnYaxesChanged();
    partial void OnDPNumberChanging(string value);
    partial void OnDPNumberChanged();
    partial void OnDPGeneralChanging(string value);
    partial void OnDPGeneralChanged();
    #endregion
		
		public DP()
		{
			this._Cabina = default(EntityRef<Cabina>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IDdp", AutoSync=AutoSync.OnInsert, IsPrimaryKey=true, IsDbGenerated=true)]
		public int IDdp
		{
			get
			{
				return this._IDdp;
			}
			set
			{
				if ((this._IDdp != value))
				{
					this.OnIDdpChanging(value);
					this.SendPropertyChanging();
					this._IDdp = value;
					this.SendPropertyChanged("IDdp");
					this.OnIDdpChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IDcabina", DbType="int")]
		public int IDcabina
		{
			get
			{
				return this._IDcabina;
			}
			set
			{
				if ((this._IDcabina != value))
				{
					if (this._Cabina.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnIDcabinaChanging(value);
					this.SendPropertyChanging();
					this._IDcabina = value;
					this.SendPropertyChanged("IDcabina");
					this.OnIDcabinaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Area", DbType="nvarchar(200)", CanBeNull=false)]
		public string Area
		{
			get
			{
				return this._Area;
			}
			set
			{
				if ((this._Area != value))
				{
					this.OnAreaChanging(value);
					this.SendPropertyChanging();
					this._Area = value;
					this.SendPropertyChanged("Area");
					this.OnAreaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_picture", DbType="nvarchar(1)", CanBeNull=false)]
		public string picture
		{
			get
			{
				return this._picture;
			}
			set
			{
				if ((this._picture != value))
				{
					this.OnpictureChanging(value);
					this.SendPropertyChanging();
					this._picture = value;
					this.SendPropertyChanged("picture");
					this.OnpictureChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Xaxes", DbType="nvarchar(1)", CanBeNull=false)]
		public string Xaxes
		{
			get
			{
				return this._Xaxes;
			}
			set
			{
				if ((this._Xaxes != value))
				{
					this.OnXaxesChanging(value);
					this.SendPropertyChanging();
					this._Xaxes = value;
					this.SendPropertyChanged("Xaxes");
					this.OnXaxesChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Yaxes", DbType="nvarchar(1)", CanBeNull=false)]
		public string Yaxes
		{
			get
			{
				return this._Yaxes;
			}
			set
			{
				if ((this._Yaxes != value))
				{
					this.OnYaxesChanging(value);
					this.SendPropertyChanging();
					this._Yaxes = value;
					this.SendPropertyChanged("Yaxes");
					this.OnYaxesChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DPNumber", DbType="nvarchar(10)", CanBeNull=false)]
		public string DPNumber
		{
			get
			{
				return this._DPNumber;
			}
			set
			{
				if ((this._DPNumber != value))
				{
					this.OnDPNumberChanging(value);
					this.SendPropertyChanging();
					this._DPNumber = value;
					this.SendPropertyChanged("DPNumber");
					this.OnDPNumberChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DPGeneral", DbType="nvarchar(40)", CanBeNull=false)]
		public string DPGeneral
		{
			get
			{
				return this._DPGeneral;
			}
			set
			{
				if ((this._DPGeneral != value))
				{
					this.OnDPGeneralChanging(value);
					this.SendPropertyChanging();
					this._DPGeneral = value;
					this.SendPropertyChanged("DPGeneral");
					this.OnDPGeneralChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Cabina_DP", Storage="_Cabina", ThisKey="IDcabina", OtherKey="IDcabina", IsForeignKey=true)]
		public Cabina Cabina
		{
			get
			{
				return this._Cabina.Entity;
			}
			set
			{
				Cabina previousValue = this._Cabina.Entity;
				if (((previousValue != value) 
							|| (this._Cabina.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Cabina.Entity = null;
						previousValue.DPs.Remove(this);
					}
					this._Cabina.Entity = value;
					if ((value != null))
					{
						value.DPs.Add(this);
						this._IDcabina = value.IDcabina;
					}
					else
					{
						this._IDcabina = default(int);
					}
					this.SendPropertyChanged("Cabina");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="Users")]
	public partial class User : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _ID;
		
		private string _PassWord;
		
		private string _Name;
		
		private string _Degre;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(string value);
    partial void OnIDChanged();
    partial void OnPassWordChanging(string value);
    partial void OnPassWordChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    partial void OnDegreChanging(string value);
    partial void OnDegreChanged();
    #endregion
		
		public User()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", DbType="nvarchar(30)", CanBeNull=false, IsPrimaryKey=true)]
		public string ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._ID = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PassWord", DbType="nvarchar(30)", CanBeNull=false)]
		public string PassWord
		{
			get
			{
				return this._PassWord;
			}
			set
			{
				if ((this._PassWord != value))
				{
					this.OnPassWordChanging(value);
					this.SendPropertyChanging();
					this._PassWord = value;
					this.SendPropertyChanged("PassWord");
					this.OnPassWordChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="nvarchar(30)", CanBeNull=false)]
		public string Name
		{
			get
			{
				return this._Name;
			}
			set
			{
				if ((this._Name != value))
				{
					this.OnNameChanging(value);
					this.SendPropertyChanging();
					this._Name = value;
					this.SendPropertyChanged("Name");
					this.OnNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Degre", DbType="nvarchar(30)", CanBeNull=false)]
		public string Degre
		{
			get
			{
				return this._Degre;
			}
			set
			{
				if ((this._Degre != value))
				{
					this.OnDegreChanging(value);
					this.SendPropertyChanging();
					this._Degre = value;
					this.SendPropertyChanged("Degre");
					this.OnDegreChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="Cabels")]
	public partial class Cabel : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _IDCable;
		
		private int _IDcentral;
		
		private string _CableNumber;
		
		private string _CabelGenral;
		
		private string _PunctuationBG;
		
		private string _PunctuationEN;
		
		private EntitySet<Cabina> _Cabinas;
		
		private EntityRef<Central> _Central;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDCableChanging(int value);
    partial void OnIDCableChanged();
    partial void OnIDcentralChanging(int value);
    partial void OnIDcentralChanged();
    partial void OnCableNumberChanging(string value);
    partial void OnCableNumberChanged();
    partial void OnCabelGenralChanging(string value);
    partial void OnCabelGenralChanged();
    partial void OnPunctuationBGChanging(string value);
    partial void OnPunctuationBGChanged();
    partial void OnPunctuationENChanging(string value);
    partial void OnPunctuationENChanged();
    #endregion
		
		public Cabel()
		{
			this._Cabinas = new EntitySet<Cabina>(new Action<Cabina>(this.attach_Cabinas), new Action<Cabina>(this.detach_Cabinas));
			this._Central = default(EntityRef<Central>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IDCable", AutoSync=AutoSync.OnInsert, IsPrimaryKey=true, IsDbGenerated=true)]
		public int IDCable
		{
			get
			{
				return this._IDCable;
			}
			set
			{
				if ((this._IDCable != value))
				{
					this.OnIDCableChanging(value);
					this.SendPropertyChanging();
					this._IDCable = value;
					this.SendPropertyChanged("IDCable");
					this.OnIDCableChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IDcentral", DbType="int")]
		public int IDcentral
		{
			get
			{
				return this._IDcentral;
			}
			set
			{
				if ((this._IDcentral != value))
				{
					if (this._Central.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnIDcentralChanging(value);
					this.SendPropertyChanging();
					this._IDcentral = value;
					this.SendPropertyChanged("IDcentral");
					this.OnIDcentralChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CableNumber", DbType="nvarchar(10)", CanBeNull=false)]
		public string CableNumber
		{
			get
			{
				return this._CableNumber;
			}
			set
			{
				if ((this._CableNumber != value))
				{
					this.OnCableNumberChanging(value);
					this.SendPropertyChanging();
					this._CableNumber = value;
					this.SendPropertyChanged("CableNumber");
					this.OnCableNumberChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CabelGenral", DbType="nvarchar(10)", CanBeNull=false)]
		public string CabelGenral
		{
			get
			{
				return this._CabelGenral;
			}
			set
			{
				if ((this._CabelGenral != value))
				{
					this.OnCabelGenralChanging(value);
					this.SendPropertyChanging();
					this._CabelGenral = value;
					this.SendPropertyChanged("CabelGenral");
					this.OnCabelGenralChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PunctuationBG", DbType="nvarchar(11)", CanBeNull=false)]
		public string PunctuationBG
		{
			get
			{
				return this._PunctuationBG;
			}
			set
			{
				if ((this._PunctuationBG != value))
				{
					this.OnPunctuationBGChanging(value);
					this.SendPropertyChanging();
					this._PunctuationBG = value;
					this.SendPropertyChanged("PunctuationBG");
					this.OnPunctuationBGChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PunctuationEN", DbType="nvarchar(11)", CanBeNull=false)]
		public string PunctuationEN
		{
			get
			{
				return this._PunctuationEN;
			}
			set
			{
				if ((this._PunctuationEN != value))
				{
					this.OnPunctuationENChanging(value);
					this.SendPropertyChanging();
					this._PunctuationEN = value;
					this.SendPropertyChanged("PunctuationEN");
					this.OnPunctuationENChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Cabel_Cabina", Storage="_Cabinas", ThisKey="IDCable", OtherKey="IDCable")]
		public EntitySet<Cabina> Cabinas
		{
			get
			{
				return this._Cabinas;
			}
			set
			{
				this._Cabinas.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Central_Cabel", Storage="_Central", ThisKey="IDcentral", OtherKey="IDcentral", IsForeignKey=true)]
		public Central Central
		{
			get
			{
				return this._Central.Entity;
			}
			set
			{
				Central previousValue = this._Central.Entity;
				if (((previousValue != value) 
							|| (this._Central.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Central.Entity = null;
						previousValue.Cabels.Remove(this);
					}
					this._Central.Entity = value;
					if ((value != null))
					{
						value.Cabels.Add(this);
						this._IDcentral = value.IDcentral;
					}
					else
					{
						this._IDcentral = default(int);
					}
					this.SendPropertyChanged("Central");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_Cabinas(Cabina entity)
		{
			this.SendPropertyChanging();
			entity.Cabel = this;
		}
		
		private void detach_Cabinas(Cabina entity)
		{
			this.SendPropertyChanging();
			entity.Cabel = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="js")]
	public partial class j : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _i;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OniChanging(int value);
    partial void OniChanged();
    #endregion
		
		public j()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_i", DbType="int", IsPrimaryKey=true)]
		public int i
		{
			get
			{
				return this._i;
			}
			set
			{
				if ((this._i != value))
				{
					this.OniChanging(value);
					this.SendPropertyChanging();
					this._i = value;
					this.SendPropertyChanged("i");
					this.OniChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
}
#pragma warning restore 1591