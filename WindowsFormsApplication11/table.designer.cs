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

namespace WindowsFormsApplication11
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="Database2")]
	public partial class tableDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertTable(Table instance);
    partial void UpdateTable(Table instance);
    partial void DeleteTable(Table instance);
    #endregion
		
		public tableDataContext() : 
				base(global::WindowsFormsApplication11.Properties.Settings.Default.Database2ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public tableDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public tableDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public tableDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public tableDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Table> Tables
		{
			get
			{
				return this.GetTable<Table>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.[Table]")]
	public partial class Table : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _referansnum;
		
		private string _müsteri_adı;
		
		private string _yüktürü;
		
		private string _yükmiktarı;
		
		private string _göndericiAdres;
		
		private string _alıcıAdres;
		
		private string _gönSehir;
		
		private string _alanSehir;
		
		private int _telefon;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnreferansnumChanging(int value);
    partial void OnreferansnumChanged();
    partial void Onmüsteri_adıChanging(string value);
    partial void Onmüsteri_adıChanged();
    partial void OnyüktürüChanging(string value);
    partial void OnyüktürüChanged();
    partial void OnyükmiktarıChanging(string value);
    partial void OnyükmiktarıChanged();
    partial void OngöndericiAdresChanging(string value);
    partial void OngöndericiAdresChanged();
    partial void OnalıcıAdresChanging(string value);
    partial void OnalıcıAdresChanged();
    partial void OngönSehirChanging(string value);
    partial void OngönSehirChanged();
    partial void OnalanSehirChanging(string value);
    partial void OnalanSehirChanged();
    partial void OntelefonChanging(int value);
    partial void OntelefonChanged();
    #endregion
		
		public Table()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_referansnum", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int referansnum
		{
			get
			{
				return this._referansnum;
			}
			set
			{
				if ((this._referansnum != value))
				{
					this.OnreferansnumChanging(value);
					this.SendPropertyChanging();
					this._referansnum = value;
					this.SendPropertyChanged("referansnum");
					this.OnreferansnumChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[müsteri adı]", Storage="_müsteri_adı", DbType="NChar(10) NOT NULL", CanBeNull=false)]
		public string müsteri_adı
		{
			get
			{
				return this._müsteri_adı;
			}
			set
			{
				if ((this._müsteri_adı != value))
				{
					this.Onmüsteri_adıChanging(value);
					this.SendPropertyChanging();
					this._müsteri_adı = value;
					this.SendPropertyChanged("müsteri_adı");
					this.Onmüsteri_adıChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_yüktürü", DbType="NChar(10) NOT NULL", CanBeNull=false)]
		public string yüktürü
		{
			get
			{
				return this._yüktürü;
			}
			set
			{
				if ((this._yüktürü != value))
				{
					this.OnyüktürüChanging(value);
					this.SendPropertyChanging();
					this._yüktürü = value;
					this.SendPropertyChanged("yüktürü");
					this.OnyüktürüChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_yükmiktarı", DbType="NChar(10) NOT NULL", CanBeNull=false)]
		public string yükmiktarı
		{
			get
			{
				return this._yükmiktarı;
			}
			set
			{
				if ((this._yükmiktarı != value))
				{
					this.OnyükmiktarıChanging(value);
					this.SendPropertyChanging();
					this._yükmiktarı = value;
					this.SendPropertyChanged("yükmiktarı");
					this.OnyükmiktarıChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_göndericiAdres", DbType="NChar(10) NOT NULL", CanBeNull=false)]
		public string göndericiAdres
		{
			get
			{
				return this._göndericiAdres;
			}
			set
			{
				if ((this._göndericiAdres != value))
				{
					this.OngöndericiAdresChanging(value);
					this.SendPropertyChanging();
					this._göndericiAdres = value;
					this.SendPropertyChanged("göndericiAdres");
					this.OngöndericiAdresChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_alıcıAdres", DbType="NChar(10) NOT NULL", CanBeNull=false)]
		public string alıcıAdres
		{
			get
			{
				return this._alıcıAdres;
			}
			set
			{
				if ((this._alıcıAdres != value))
				{
					this.OnalıcıAdresChanging(value);
					this.SendPropertyChanging();
					this._alıcıAdres = value;
					this.SendPropertyChanged("alıcıAdres");
					this.OnalıcıAdresChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_gönSehir", DbType="NChar(10) NOT NULL", CanBeNull=false)]
		public string gönSehir
		{
			get
			{
				return this._gönSehir;
			}
			set
			{
				if ((this._gönSehir != value))
				{
					this.OngönSehirChanging(value);
					this.SendPropertyChanging();
					this._gönSehir = value;
					this.SendPropertyChanged("gönSehir");
					this.OngönSehirChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_alanSehir", DbType="NChar(10) NOT NULL", CanBeNull=false)]
		public string alanSehir
		{
			get
			{
				return this._alanSehir;
			}
			set
			{
				if ((this._alanSehir != value))
				{
					this.OnalanSehirChanging(value);
					this.SendPropertyChanging();
					this._alanSehir = value;
					this.SendPropertyChanged("alanSehir");
					this.OnalanSehirChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_telefon", DbType="Int NOT NULL")]
		public int telefon
		{
			get
			{
				return this._telefon;
			}
			set
			{
				if ((this._telefon != value))
				{
					this.OntelefonChanging(value);
					this.SendPropertyChanging();
					this._telefon = value;
					this.SendPropertyChanged("telefon");
					this.OntelefonChanged();
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
