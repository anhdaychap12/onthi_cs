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

namespace QL_LSV.Models
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="QL_LSV")]
	public partial class DataQL_LSVDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void Inserttbl_Lop(tbl_Lop instance);
    partial void Updatetbl_Lop(tbl_Lop instance);
    partial void Deletetbl_Lop(tbl_Lop instance);
    partial void Inserttbl_Sinhvien(tbl_Sinhvien instance);
    partial void Updatetbl_Sinhvien(tbl_Sinhvien instance);
    partial void Deletetbl_Sinhvien(tbl_Sinhvien instance);
    #endregion
		
		public DataQL_LSVDataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["QL_LSVConnectionString"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DataQL_LSVDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataQL_LSVDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataQL_LSVDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataQL_LSVDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<tbl_Lop> tbl_Lops
		{
			get
			{
				return this.GetTable<tbl_Lop>();
			}
		}
		
		public System.Data.Linq.Table<tbl_Sinhvien> tbl_Sinhviens
		{
			get
			{
				return this.GetTable<tbl_Sinhvien>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.tbl_Lop")]
	public partial class tbl_Lop : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _id;
		
		private string _l_malop;
		
		private string _l_name;
		
		private EntitySet<tbl_Sinhvien> _tbl_Sinhviens;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidChanging(int value);
    partial void OnidChanged();
    partial void Onl_malopChanging(string value);
    partial void Onl_malopChanged();
    partial void Onl_nameChanging(string value);
    partial void Onl_nameChanged();
    #endregion
		
		public tbl_Lop()
		{
			this._tbl_Sinhviens = new EntitySet<tbl_Sinhvien>(new Action<tbl_Sinhvien>(this.attach_tbl_Sinhviens), new Action<tbl_Sinhvien>(this.detach_tbl_Sinhviens));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int id
		{
			get
			{
				return this._id;
			}
			set
			{
				if ((this._id != value))
				{
					this.OnidChanging(value);
					this.SendPropertyChanging();
					this._id = value;
					this.SendPropertyChanged("id");
					this.OnidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_l_malop", DbType="NVarChar(50)")]
		public string l_malop
		{
			get
			{
				return this._l_malop;
			}
			set
			{
				if ((this._l_malop != value))
				{
					this.Onl_malopChanging(value);
					this.SendPropertyChanging();
					this._l_malop = value;
					this.SendPropertyChanged("l_malop");
					this.Onl_malopChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_l_name", DbType="NVarChar(50)")]
		public string l_name
		{
			get
			{
				return this._l_name;
			}
			set
			{
				if ((this._l_name != value))
				{
					this.Onl_nameChanging(value);
					this.SendPropertyChanging();
					this._l_name = value;
					this.SendPropertyChanged("l_name");
					this.Onl_nameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="tbl_Lop_tbl_Sinhvien", Storage="_tbl_Sinhviens", ThisKey="id", OtherKey="id_lop")]
		public EntitySet<tbl_Sinhvien> tbl_Sinhviens
		{
			get
			{
				return this._tbl_Sinhviens;
			}
			set
			{
				this._tbl_Sinhviens.Assign(value);
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
		
		private void attach_tbl_Sinhviens(tbl_Sinhvien entity)
		{
			this.SendPropertyChanging();
			entity.tbl_Lop = this;
		}
		
		private void detach_tbl_Sinhviens(tbl_Sinhvien entity)
		{
			this.SendPropertyChanging();
			entity.tbl_Lop = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.tbl_Sinhvien")]
	public partial class tbl_Sinhvien : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _id;
		
		private string _sv_mssv;
		
		private string _sv_name;
		
		private System.Nullable<System.DateTime> _sv_birthday;
		
		private string _sv_address;
		
		private string _sv_gender;
		
		private System.Nullable<int> _id_lop;
		
		private EntityRef<tbl_Lop> _tbl_Lop;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidChanging(int value);
    partial void OnidChanged();
    partial void Onsv_mssvChanging(string value);
    partial void Onsv_mssvChanged();
    partial void Onsv_nameChanging(string value);
    partial void Onsv_nameChanged();
    partial void Onsv_birthdayChanging(System.Nullable<System.DateTime> value);
    partial void Onsv_birthdayChanged();
    partial void Onsv_addressChanging(string value);
    partial void Onsv_addressChanged();
    partial void Onsv_genderChanging(string value);
    partial void Onsv_genderChanged();
    partial void Onid_lopChanging(System.Nullable<int> value);
    partial void Onid_lopChanged();
    #endregion
		
		public tbl_Sinhvien()
		{
			this._tbl_Lop = default(EntityRef<tbl_Lop>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int id
		{
			get
			{
				return this._id;
			}
			set
			{
				if ((this._id != value))
				{
					this.OnidChanging(value);
					this.SendPropertyChanging();
					this._id = value;
					this.SendPropertyChanged("id");
					this.OnidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_sv_mssv", DbType="NVarChar(50)")]
		public string sv_mssv
		{
			get
			{
				return this._sv_mssv;
			}
			set
			{
				if ((this._sv_mssv != value))
				{
					this.Onsv_mssvChanging(value);
					this.SendPropertyChanging();
					this._sv_mssv = value;
					this.SendPropertyChanged("sv_mssv");
					this.Onsv_mssvChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_sv_name", DbType="NVarChar(50)")]
		public string sv_name
		{
			get
			{
				return this._sv_name;
			}
			set
			{
				if ((this._sv_name != value))
				{
					this.Onsv_nameChanging(value);
					this.SendPropertyChanging();
					this._sv_name = value;
					this.SendPropertyChanged("sv_name");
					this.Onsv_nameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_sv_birthday", DbType="DateTime")]
		public System.Nullable<System.DateTime> sv_birthday
		{
			get
			{
				return this._sv_birthday;
			}
			set
			{
				if ((this._sv_birthday != value))
				{
					this.Onsv_birthdayChanging(value);
					this.SendPropertyChanging();
					this._sv_birthday = value;
					this.SendPropertyChanged("sv_birthday");
					this.Onsv_birthdayChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_sv_address", DbType="NVarChar(100)")]
		public string sv_address
		{
			get
			{
				return this._sv_address;
			}
			set
			{
				if ((this._sv_address != value))
				{
					this.Onsv_addressChanging(value);
					this.SendPropertyChanging();
					this._sv_address = value;
					this.SendPropertyChanged("sv_address");
					this.Onsv_addressChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_sv_gender", DbType="NVarChar(10)")]
		public string sv_gender
		{
			get
			{
				return this._sv_gender;
			}
			set
			{
				if ((this._sv_gender != value))
				{
					this.Onsv_genderChanging(value);
					this.SendPropertyChanging();
					this._sv_gender = value;
					this.SendPropertyChanged("sv_gender");
					this.Onsv_genderChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id_lop", DbType="Int")]
		public System.Nullable<int> id_lop
		{
			get
			{
				return this._id_lop;
			}
			set
			{
				if ((this._id_lop != value))
				{
					if (this._tbl_Lop.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.Onid_lopChanging(value);
					this.SendPropertyChanging();
					this._id_lop = value;
					this.SendPropertyChanged("id_lop");
					this.Onid_lopChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="tbl_Lop_tbl_Sinhvien", Storage="_tbl_Lop", ThisKey="id_lop", OtherKey="id", IsForeignKey=true)]
		public tbl_Lop tbl_Lop
		{
			get
			{
				return this._tbl_Lop.Entity;
			}
			set
			{
				tbl_Lop previousValue = this._tbl_Lop.Entity;
				if (((previousValue != value) 
							|| (this._tbl_Lop.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._tbl_Lop.Entity = null;
						previousValue.tbl_Sinhviens.Remove(this);
					}
					this._tbl_Lop.Entity = value;
					if ((value != null))
					{
						value.tbl_Sinhviens.Add(this);
						this._id_lop = value.id;
					}
					else
					{
						this._id_lop = default(Nullable<int>);
					}
					this.SendPropertyChanged("tbl_Lop");
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