﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Modelo
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="DbRendevu")]
	public partial class ORMDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Definiciones de métodos de extensibilidad
    partial void OnCreated();
    partial void InsertAgendamiento(Agendamiento instance);
    partial void UpdateAgendamiento(Agendamiento instance);
    partial void DeleteAgendamiento(Agendamiento instance);
    partial void InsertUsuarios(Usuarios instance);
    partial void UpdateUsuarios(Usuarios instance);
    partial void DeleteUsuarios(Usuarios instance);
    partial void InsertIdioma(Idioma instance);
    partial void UpdateIdioma(Idioma instance);
    partial void DeleteIdioma(Idioma instance);
    partial void InsertNivel(Nivel instance);
    partial void UpdateNivel(Nivel instance);
    partial void DeleteNivel(Nivel instance);
    partial void InsertPermisos(Permisos instance);
    partial void UpdatePermisos(Permisos instance);
    partial void DeletePermisos(Permisos instance);
    partial void InsertSalon(Salon instance);
    partial void UpdateSalon(Salon instance);
    partial void DeleteSalon(Salon instance);
    #endregion
		
		public ORMDataContext() : 
				base(global::Modelo.Properties.Settings.Default.DbRendevuConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public ORMDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public ORMDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public ORMDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public ORMDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Agendamiento> Agendamiento
		{
			get
			{
				return this.GetTable<Agendamiento>();
			}
		}
		
		public System.Data.Linq.Table<Usuarios> Usuarios
		{
			get
			{
				return this.GetTable<Usuarios>();
			}
		}
		
		public System.Data.Linq.Table<Idioma> Idioma
		{
			get
			{
				return this.GetTable<Idioma>();
			}
		}
		
		public System.Data.Linq.Table<Nivel> Nivel
		{
			get
			{
				return this.GetTable<Nivel>();
			}
		}
		
		public System.Data.Linq.Table<Permisos> Permisos
		{
			get
			{
				return this.GetTable<Permisos>();
			}
		}
		
		public System.Data.Linq.Table<Salon> Salon
		{
			get
			{
				return this.GetTable<Salon>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Agendamiento")]
	public partial class Agendamiento : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _IdAgendamiento;
		
		private int _UsuarioId;
		
		private System.Nullable<int> _IdSalon;
		
		private System.Nullable<int> _IdNivel;
		
		private System.Nullable<int> _IdIdioma;
		
		private System.Nullable<System.DateTime> _Fecha;
		
		private System.Nullable<System.TimeSpan> _HoraInicio;
		
		private System.Nullable<System.TimeSpan> _HoraFinal;
		
		private EntityRef<Usuarios> _Usuarios;
		
		private EntityRef<Idioma> _Idioma;
		
		private EntityRef<Nivel> _Nivel;
		
		private EntityRef<Salon> _Salon;
		
    #region Definiciones de métodos de extensibilidad
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdAgendamientoChanging(int value);
    partial void OnIdAgendamientoChanged();
    partial void OnUsuarioIdChanging(int value);
    partial void OnUsuarioIdChanged();
    partial void OnIdSalonChanging(System.Nullable<int> value);
    partial void OnIdSalonChanged();
    partial void OnIdNivelChanging(System.Nullable<int> value);
    partial void OnIdNivelChanged();
    partial void OnIdIdiomaChanging(System.Nullable<int> value);
    partial void OnIdIdiomaChanged();
    partial void OnFechaChanging(System.Nullable<System.DateTime> value);
    partial void OnFechaChanged();
    partial void OnHoraInicioChanging(System.Nullable<System.TimeSpan> value);
    partial void OnHoraInicioChanged();
    partial void OnHoraFinalChanging(System.Nullable<System.TimeSpan> value);
    partial void OnHoraFinalChanged();
    #endregion
		
		public Agendamiento()
		{
			this._Usuarios = default(EntityRef<Usuarios>);
			this._Idioma = default(EntityRef<Idioma>);
			this._Nivel = default(EntityRef<Nivel>);
			this._Salon = default(EntityRef<Salon>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IdAgendamiento", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int IdAgendamiento
		{
			get
			{
				return this._IdAgendamiento;
			}
			set
			{
				if ((this._IdAgendamiento != value))
				{
					this.OnIdAgendamientoChanging(value);
					this.SendPropertyChanging();
					this._IdAgendamiento = value;
					this.SendPropertyChanged("IdAgendamiento");
					this.OnIdAgendamientoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UsuarioId", DbType="Int NOT NULL")]
		public int UsuarioId
		{
			get
			{
				return this._UsuarioId;
			}
			set
			{
				if ((this._UsuarioId != value))
				{
					if (this._Usuarios.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnUsuarioIdChanging(value);
					this.SendPropertyChanging();
					this._UsuarioId = value;
					this.SendPropertyChanged("UsuarioId");
					this.OnUsuarioIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IdSalon", DbType="Int")]
		public System.Nullable<int> IdSalon
		{
			get
			{
				return this._IdSalon;
			}
			set
			{
				if ((this._IdSalon != value))
				{
					if (this._Salon.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnIdSalonChanging(value);
					this.SendPropertyChanging();
					this._IdSalon = value;
					this.SendPropertyChanged("IdSalon");
					this.OnIdSalonChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IdNivel", DbType="Int")]
		public System.Nullable<int> IdNivel
		{
			get
			{
				return this._IdNivel;
			}
			set
			{
				if ((this._IdNivel != value))
				{
					if (this._Nivel.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnIdNivelChanging(value);
					this.SendPropertyChanging();
					this._IdNivel = value;
					this.SendPropertyChanged("IdNivel");
					this.OnIdNivelChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IdIdioma", DbType="Int")]
		public System.Nullable<int> IdIdioma
		{
			get
			{
				return this._IdIdioma;
			}
			set
			{
				if ((this._IdIdioma != value))
				{
					if (this._Idioma.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnIdIdiomaChanging(value);
					this.SendPropertyChanging();
					this._IdIdioma = value;
					this.SendPropertyChanged("IdIdioma");
					this.OnIdIdiomaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Fecha", DbType="Date")]
		public System.Nullable<System.DateTime> Fecha
		{
			get
			{
				return this._Fecha;
			}
			set
			{
				if ((this._Fecha != value))
				{
					this.OnFechaChanging(value);
					this.SendPropertyChanging();
					this._Fecha = value;
					this.SendPropertyChanged("Fecha");
					this.OnFechaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_HoraInicio", DbType="Time")]
		public System.Nullable<System.TimeSpan> HoraInicio
		{
			get
			{
				return this._HoraInicio;
			}
			set
			{
				if ((this._HoraInicio != value))
				{
					this.OnHoraInicioChanging(value);
					this.SendPropertyChanging();
					this._HoraInicio = value;
					this.SendPropertyChanged("HoraInicio");
					this.OnHoraInicioChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_HoraFinal", DbType="Time")]
		public System.Nullable<System.TimeSpan> HoraFinal
		{
			get
			{
				return this._HoraFinal;
			}
			set
			{
				if ((this._HoraFinal != value))
				{
					this.OnHoraFinalChanging(value);
					this.SendPropertyChanging();
					this._HoraFinal = value;
					this.SendPropertyChanged("HoraFinal");
					this.OnHoraFinalChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Usuarios_Agendamiento", Storage="_Usuarios", ThisKey="UsuarioId", OtherKey="UsuarioId", IsForeignKey=true, DeleteOnNull=true, DeleteRule="CASCADE")]
		public Usuarios Usuarios
		{
			get
			{
				return this._Usuarios.Entity;
			}
			set
			{
				Usuarios previousValue = this._Usuarios.Entity;
				if (((previousValue != value) 
							|| (this._Usuarios.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Usuarios.Entity = null;
						previousValue.Agendamiento.Remove(this);
					}
					this._Usuarios.Entity = value;
					if ((value != null))
					{
						value.Agendamiento.Add(this);
						this._UsuarioId = value.UsuarioId;
					}
					else
					{
						this._UsuarioId = default(int);
					}
					this.SendPropertyChanged("Usuarios");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Idioma_Agendamiento", Storage="_Idioma", ThisKey="IdIdioma", OtherKey="IdIdioma", IsForeignKey=true, DeleteRule="CASCADE")]
		public Idioma Idioma
		{
			get
			{
				return this._Idioma.Entity;
			}
			set
			{
				Idioma previousValue = this._Idioma.Entity;
				if (((previousValue != value) 
							|| (this._Idioma.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Idioma.Entity = null;
						previousValue.Agendamiento.Remove(this);
					}
					this._Idioma.Entity = value;
					if ((value != null))
					{
						value.Agendamiento.Add(this);
						this._IdIdioma = value.IdIdioma;
					}
					else
					{
						this._IdIdioma = default(Nullable<int>);
					}
					this.SendPropertyChanged("Idioma");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Nivel_Agendamiento", Storage="_Nivel", ThisKey="IdNivel", OtherKey="IdNivel", IsForeignKey=true, DeleteRule="CASCADE")]
		public Nivel Nivel
		{
			get
			{
				return this._Nivel.Entity;
			}
			set
			{
				Nivel previousValue = this._Nivel.Entity;
				if (((previousValue != value) 
							|| (this._Nivel.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Nivel.Entity = null;
						previousValue.Agendamiento.Remove(this);
					}
					this._Nivel.Entity = value;
					if ((value != null))
					{
						value.Agendamiento.Add(this);
						this._IdNivel = value.IdNivel;
					}
					else
					{
						this._IdNivel = default(Nullable<int>);
					}
					this.SendPropertyChanged("Nivel");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Salon_Agendamiento", Storage="_Salon", ThisKey="IdSalon", OtherKey="IdSalon", IsForeignKey=true, DeleteRule="CASCADE")]
		public Salon Salon
		{
			get
			{
				return this._Salon.Entity;
			}
			set
			{
				Salon previousValue = this._Salon.Entity;
				if (((previousValue != value) 
							|| (this._Salon.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Salon.Entity = null;
						previousValue.Agendamiento.Remove(this);
					}
					this._Salon.Entity = value;
					if ((value != null))
					{
						value.Agendamiento.Add(this);
						this._IdSalon = value.IdSalon;
					}
					else
					{
						this._IdSalon = default(Nullable<int>);
					}
					this.SendPropertyChanged("Salon");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Usuarios")]
	public partial class Usuarios : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _UsuarioId;
		
		private string _TipoDocId;
		
		private string _RolId;
		
		private string _CiudadId;
		
		private string _Cedula;
		
		private string _Nombres;
		
		private string _Apellido1;
		
		private string _Apellido2;
		
		private string _Direccion;
		
		private string _Sexo;
		
		private string _Email;
		
		private string _Telefono;
		
		private System.Nullable<int> _Edad;
		
		private string _Clave;
		
		private System.Nullable<System.DateTime> _FechaIngreso;
		
		private System.Data.Linq.Binary _Imagen;
		
		private System.Nullable<bool> _Estado;
		
		private System.Nullable<int> _IpPermisos;
		
		private EntitySet<Agendamiento> _Agendamiento;
		
		private EntityRef<Permisos> _Permisos;
		
    #region Definiciones de métodos de extensibilidad
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnUsuarioIdChanging(int value);
    partial void OnUsuarioIdChanged();
    partial void OnTipoDocIdChanging(string value);
    partial void OnTipoDocIdChanged();
    partial void OnRolIdChanging(string value);
    partial void OnRolIdChanged();
    partial void OnCiudadIdChanging(string value);
    partial void OnCiudadIdChanged();
    partial void OnCedulaChanging(string value);
    partial void OnCedulaChanged();
    partial void OnNombresChanging(string value);
    partial void OnNombresChanged();
    partial void OnApellido1Changing(string value);
    partial void OnApellido1Changed();
    partial void OnApellido2Changing(string value);
    partial void OnApellido2Changed();
    partial void OnDireccionChanging(string value);
    partial void OnDireccionChanged();
    partial void OnSexoChanging(string value);
    partial void OnSexoChanged();
    partial void OnEmailChanging(string value);
    partial void OnEmailChanged();
    partial void OnTelefonoChanging(string value);
    partial void OnTelefonoChanged();
    partial void OnEdadChanging(System.Nullable<int> value);
    partial void OnEdadChanged();
    partial void OnClaveChanging(string value);
    partial void OnClaveChanged();
    partial void OnFechaIngresoChanging(System.Nullable<System.DateTime> value);
    partial void OnFechaIngresoChanged();
    partial void OnImagenChanging(System.Data.Linq.Binary value);
    partial void OnImagenChanged();
    partial void OnEstadoChanging(System.Nullable<bool> value);
    partial void OnEstadoChanged();
    partial void OnIpPermisosChanging(System.Nullable<int> value);
    partial void OnIpPermisosChanged();
    #endregion
		
		public Usuarios()
		{
			this._Agendamiento = new EntitySet<Agendamiento>(new Action<Agendamiento>(this.attach_Agendamiento), new Action<Agendamiento>(this.detach_Agendamiento));
			this._Permisos = default(EntityRef<Permisos>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UsuarioId", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int UsuarioId
		{
			get
			{
				return this._UsuarioId;
			}
			set
			{
				if ((this._UsuarioId != value))
				{
					this.OnUsuarioIdChanging(value);
					this.SendPropertyChanging();
					this._UsuarioId = value;
					this.SendPropertyChanged("UsuarioId");
					this.OnUsuarioIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TipoDocId", DbType="VarChar(15)")]
		public string TipoDocId
		{
			get
			{
				return this._TipoDocId;
			}
			set
			{
				if ((this._TipoDocId != value))
				{
					this.OnTipoDocIdChanging(value);
					this.SendPropertyChanging();
					this._TipoDocId = value;
					this.SendPropertyChanged("TipoDocId");
					this.OnTipoDocIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_RolId", DbType="VarChar(15)")]
		public string RolId
		{
			get
			{
				return this._RolId;
			}
			set
			{
				if ((this._RolId != value))
				{
					this.OnRolIdChanging(value);
					this.SendPropertyChanging();
					this._RolId = value;
					this.SendPropertyChanged("RolId");
					this.OnRolIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CiudadId", DbType="VarChar(15)")]
		public string CiudadId
		{
			get
			{
				return this._CiudadId;
			}
			set
			{
				if ((this._CiudadId != value))
				{
					this.OnCiudadIdChanging(value);
					this.SendPropertyChanging();
					this._CiudadId = value;
					this.SendPropertyChanged("CiudadId");
					this.OnCiudadIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Cedula", DbType="VarChar(15) NOT NULL", CanBeNull=false)]
		public string Cedula
		{
			get
			{
				return this._Cedula;
			}
			set
			{
				if ((this._Cedula != value))
				{
					this.OnCedulaChanging(value);
					this.SendPropertyChanging();
					this._Cedula = value;
					this.SendPropertyChanged("Cedula");
					this.OnCedulaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Nombres", DbType="VarChar(50)")]
		public string Nombres
		{
			get
			{
				return this._Nombres;
			}
			set
			{
				if ((this._Nombres != value))
				{
					this.OnNombresChanging(value);
					this.SendPropertyChanging();
					this._Nombres = value;
					this.SendPropertyChanged("Nombres");
					this.OnNombresChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Apellido1", DbType="VarChar(50)")]
		public string Apellido1
		{
			get
			{
				return this._Apellido1;
			}
			set
			{
				if ((this._Apellido1 != value))
				{
					this.OnApellido1Changing(value);
					this.SendPropertyChanging();
					this._Apellido1 = value;
					this.SendPropertyChanged("Apellido1");
					this.OnApellido1Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Apellido2", DbType="VarChar(50)")]
		public string Apellido2
		{
			get
			{
				return this._Apellido2;
			}
			set
			{
				if ((this._Apellido2 != value))
				{
					this.OnApellido2Changing(value);
					this.SendPropertyChanging();
					this._Apellido2 = value;
					this.SendPropertyChanged("Apellido2");
					this.OnApellido2Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Direccion", DbType="VarChar(50)")]
		public string Direccion
		{
			get
			{
				return this._Direccion;
			}
			set
			{
				if ((this._Direccion != value))
				{
					this.OnDireccionChanging(value);
					this.SendPropertyChanging();
					this._Direccion = value;
					this.SendPropertyChanged("Direccion");
					this.OnDireccionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Sexo", DbType="VarChar(50)")]
		public string Sexo
		{
			get
			{
				return this._Sexo;
			}
			set
			{
				if ((this._Sexo != value))
				{
					this.OnSexoChanging(value);
					this.SendPropertyChanging();
					this._Sexo = value;
					this.SendPropertyChanged("Sexo");
					this.OnSexoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Email", DbType="VarChar(50)")]
		public string Email
		{
			get
			{
				return this._Email;
			}
			set
			{
				if ((this._Email != value))
				{
					this.OnEmailChanging(value);
					this.SendPropertyChanging();
					this._Email = value;
					this.SendPropertyChanged("Email");
					this.OnEmailChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Telefono", DbType="VarChar(50)")]
		public string Telefono
		{
			get
			{
				return this._Telefono;
			}
			set
			{
				if ((this._Telefono != value))
				{
					this.OnTelefonoChanging(value);
					this.SendPropertyChanging();
					this._Telefono = value;
					this.SendPropertyChanged("Telefono");
					this.OnTelefonoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Edad", DbType="Int")]
		public System.Nullable<int> Edad
		{
			get
			{
				return this._Edad;
			}
			set
			{
				if ((this._Edad != value))
				{
					this.OnEdadChanging(value);
					this.SendPropertyChanging();
					this._Edad = value;
					this.SendPropertyChanged("Edad");
					this.OnEdadChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Clave", DbType="VarChar(50)")]
		public string Clave
		{
			get
			{
				return this._Clave;
			}
			set
			{
				if ((this._Clave != value))
				{
					this.OnClaveChanging(value);
					this.SendPropertyChanging();
					this._Clave = value;
					this.SendPropertyChanged("Clave");
					this.OnClaveChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FechaIngreso", DbType="Date")]
		public System.Nullable<System.DateTime> FechaIngreso
		{
			get
			{
				return this._FechaIngreso;
			}
			set
			{
				if ((this._FechaIngreso != value))
				{
					this.OnFechaIngresoChanging(value);
					this.SendPropertyChanging();
					this._FechaIngreso = value;
					this.SendPropertyChanged("FechaIngreso");
					this.OnFechaIngresoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Imagen", DbType="Image", UpdateCheck=UpdateCheck.Never)]
		public System.Data.Linq.Binary Imagen
		{
			get
			{
				return this._Imagen;
			}
			set
			{
				if ((this._Imagen != value))
				{
					this.OnImagenChanging(value);
					this.SendPropertyChanging();
					this._Imagen = value;
					this.SendPropertyChanged("Imagen");
					this.OnImagenChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Estado", DbType="Bit")]
		public System.Nullable<bool> Estado
		{
			get
			{
				return this._Estado;
			}
			set
			{
				if ((this._Estado != value))
				{
					this.OnEstadoChanging(value);
					this.SendPropertyChanging();
					this._Estado = value;
					this.SendPropertyChanged("Estado");
					this.OnEstadoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IpPermisos", DbType="Int")]
		public System.Nullable<int> IpPermisos
		{
			get
			{
				return this._IpPermisos;
			}
			set
			{
				if ((this._IpPermisos != value))
				{
					if (this._Permisos.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnIpPermisosChanging(value);
					this.SendPropertyChanging();
					this._IpPermisos = value;
					this.SendPropertyChanged("IpPermisos");
					this.OnIpPermisosChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Usuarios_Agendamiento", Storage="_Agendamiento", ThisKey="UsuarioId", OtherKey="UsuarioId")]
		public EntitySet<Agendamiento> Agendamiento
		{
			get
			{
				return this._Agendamiento;
			}
			set
			{
				this._Agendamiento.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Permisos_Usuarios", Storage="_Permisos", ThisKey="IpPermisos", OtherKey="IdPermisos", IsForeignKey=true, DeleteRule="CASCADE")]
		public Permisos Permisos
		{
			get
			{
				return this._Permisos.Entity;
			}
			set
			{
				Permisos previousValue = this._Permisos.Entity;
				if (((previousValue != value) 
							|| (this._Permisos.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Permisos.Entity = null;
						previousValue.Usuarios.Remove(this);
					}
					this._Permisos.Entity = value;
					if ((value != null))
					{
						value.Usuarios.Add(this);
						this._IpPermisos = value.IdPermisos;
					}
					else
					{
						this._IpPermisos = default(Nullable<int>);
					}
					this.SendPropertyChanged("Permisos");
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
		
		private void attach_Agendamiento(Agendamiento entity)
		{
			this.SendPropertyChanging();
			entity.Usuarios = this;
		}
		
		private void detach_Agendamiento(Agendamiento entity)
		{
			this.SendPropertyChanging();
			entity.Usuarios = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Idioma")]
	public partial class Idioma : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _IdIdioma;
		
		private string _Descripcion;
		
		private EntitySet<Agendamiento> _Agendamiento;
		
    #region Definiciones de métodos de extensibilidad
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdIdiomaChanging(int value);
    partial void OnIdIdiomaChanged();
    partial void OnDescripcionChanging(string value);
    partial void OnDescripcionChanged();
    #endregion
		
		public Idioma()
		{
			this._Agendamiento = new EntitySet<Agendamiento>(new Action<Agendamiento>(this.attach_Agendamiento), new Action<Agendamiento>(this.detach_Agendamiento));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IdIdioma", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int IdIdioma
		{
			get
			{
				return this._IdIdioma;
			}
			set
			{
				if ((this._IdIdioma != value))
				{
					this.OnIdIdiomaChanging(value);
					this.SendPropertyChanging();
					this._IdIdioma = value;
					this.SendPropertyChanged("IdIdioma");
					this.OnIdIdiomaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Descripcion", DbType="VarChar(50)")]
		public string Descripcion
		{
			get
			{
				return this._Descripcion;
			}
			set
			{
				if ((this._Descripcion != value))
				{
					this.OnDescripcionChanging(value);
					this.SendPropertyChanging();
					this._Descripcion = value;
					this.SendPropertyChanged("Descripcion");
					this.OnDescripcionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Idioma_Agendamiento", Storage="_Agendamiento", ThisKey="IdIdioma", OtherKey="IdIdioma")]
		public EntitySet<Agendamiento> Agendamiento
		{
			get
			{
				return this._Agendamiento;
			}
			set
			{
				this._Agendamiento.Assign(value);
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
		
		private void attach_Agendamiento(Agendamiento entity)
		{
			this.SendPropertyChanging();
			entity.Idioma = this;
		}
		
		private void detach_Agendamiento(Agendamiento entity)
		{
			this.SendPropertyChanging();
			entity.Idioma = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Nivel")]
	public partial class Nivel : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _IdNivel;
		
		private string _Descripcion;
		
		private EntitySet<Agendamiento> _Agendamiento;
		
    #region Definiciones de métodos de extensibilidad
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdNivelChanging(int value);
    partial void OnIdNivelChanged();
    partial void OnDescripcionChanging(string value);
    partial void OnDescripcionChanged();
    #endregion
		
		public Nivel()
		{
			this._Agendamiento = new EntitySet<Agendamiento>(new Action<Agendamiento>(this.attach_Agendamiento), new Action<Agendamiento>(this.detach_Agendamiento));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IdNivel", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int IdNivel
		{
			get
			{
				return this._IdNivel;
			}
			set
			{
				if ((this._IdNivel != value))
				{
					this.OnIdNivelChanging(value);
					this.SendPropertyChanging();
					this._IdNivel = value;
					this.SendPropertyChanged("IdNivel");
					this.OnIdNivelChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Descripcion", DbType="VarChar(50)")]
		public string Descripcion
		{
			get
			{
				return this._Descripcion;
			}
			set
			{
				if ((this._Descripcion != value))
				{
					this.OnDescripcionChanging(value);
					this.SendPropertyChanging();
					this._Descripcion = value;
					this.SendPropertyChanged("Descripcion");
					this.OnDescripcionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Nivel_Agendamiento", Storage="_Agendamiento", ThisKey="IdNivel", OtherKey="IdNivel")]
		public EntitySet<Agendamiento> Agendamiento
		{
			get
			{
				return this._Agendamiento;
			}
			set
			{
				this._Agendamiento.Assign(value);
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
		
		private void attach_Agendamiento(Agendamiento entity)
		{
			this.SendPropertyChanging();
			entity.Nivel = this;
		}
		
		private void detach_Agendamiento(Agendamiento entity)
		{
			this.SendPropertyChanging();
			entity.Nivel = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Permisos")]
	public partial class Permisos : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _IdPermisos;
		
		private string _Descripcion;
		
		private EntitySet<Usuarios> _Usuarios;
		
    #region Definiciones de métodos de extensibilidad
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdPermisosChanging(int value);
    partial void OnIdPermisosChanged();
    partial void OnDescripcionChanging(string value);
    partial void OnDescripcionChanged();
    #endregion
		
		public Permisos()
		{
			this._Usuarios = new EntitySet<Usuarios>(new Action<Usuarios>(this.attach_Usuarios), new Action<Usuarios>(this.detach_Usuarios));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IdPermisos", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int IdPermisos
		{
			get
			{
				return this._IdPermisos;
			}
			set
			{
				if ((this._IdPermisos != value))
				{
					this.OnIdPermisosChanging(value);
					this.SendPropertyChanging();
					this._IdPermisos = value;
					this.SendPropertyChanged("IdPermisos");
					this.OnIdPermisosChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Descripcion", DbType="VarChar(50)")]
		public string Descripcion
		{
			get
			{
				return this._Descripcion;
			}
			set
			{
				if ((this._Descripcion != value))
				{
					this.OnDescripcionChanging(value);
					this.SendPropertyChanging();
					this._Descripcion = value;
					this.SendPropertyChanged("Descripcion");
					this.OnDescripcionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Permisos_Usuarios", Storage="_Usuarios", ThisKey="IdPermisos", OtherKey="IpPermisos")]
		public EntitySet<Usuarios> Usuarios
		{
			get
			{
				return this._Usuarios;
			}
			set
			{
				this._Usuarios.Assign(value);
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
		
		private void attach_Usuarios(Usuarios entity)
		{
			this.SendPropertyChanging();
			entity.Permisos = this;
		}
		
		private void detach_Usuarios(Usuarios entity)
		{
			this.SendPropertyChanging();
			entity.Permisos = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Salon")]
	public partial class Salon : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _IdSalon;
		
		private string _Numero;
		
		private EntitySet<Agendamiento> _Agendamiento;
		
    #region Definiciones de métodos de extensibilidad
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdSalonChanging(int value);
    partial void OnIdSalonChanged();
    partial void OnNumeroChanging(string value);
    partial void OnNumeroChanged();
    #endregion
		
		public Salon()
		{
			this._Agendamiento = new EntitySet<Agendamiento>(new Action<Agendamiento>(this.attach_Agendamiento), new Action<Agendamiento>(this.detach_Agendamiento));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IdSalon", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int IdSalon
		{
			get
			{
				return this._IdSalon;
			}
			set
			{
				if ((this._IdSalon != value))
				{
					this.OnIdSalonChanging(value);
					this.SendPropertyChanging();
					this._IdSalon = value;
					this.SendPropertyChanged("IdSalon");
					this.OnIdSalonChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Numero", DbType="VarChar(10)")]
		public string Numero
		{
			get
			{
				return this._Numero;
			}
			set
			{
				if ((this._Numero != value))
				{
					this.OnNumeroChanging(value);
					this.SendPropertyChanging();
					this._Numero = value;
					this.SendPropertyChanged("Numero");
					this.OnNumeroChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Salon_Agendamiento", Storage="_Agendamiento", ThisKey="IdSalon", OtherKey="IdSalon")]
		public EntitySet<Agendamiento> Agendamiento
		{
			get
			{
				return this._Agendamiento;
			}
			set
			{
				this._Agendamiento.Assign(value);
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
		
		private void attach_Agendamiento(Agendamiento entity)
		{
			this.SendPropertyChanging();
			entity.Salon = this;
		}
		
		private void detach_Agendamiento(Agendamiento entity)
		{
			this.SendPropertyChanging();
			entity.Salon = null;
		}
	}
}
#pragma warning restore 1591