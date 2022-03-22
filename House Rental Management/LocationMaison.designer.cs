﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace House_Rental_Management
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="miniProject")]
	public partial class LocationMaisonDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Définitions de méthodes d'extensibilité
    partial void OnCreated();
    partial void Insertutilisateur(utilisateur instance);
    partial void Updateutilisateur(utilisateur instance);
    partial void Deleteutilisateur(utilisateur instance);
    partial void Insertappartement(appartement instance);
    partial void Updateappartement(appartement instance);
    partial void Deleteappartement(appartement instance);
    partial void Insertcategorie(categorie instance);
    partial void Updatecategorie(categorie instance);
    partial void Deletecategorie(categorie instance);
    partial void Insertlocataire(locataire instance);
    partial void Updatelocataire(locataire instance);
    partial void Deletelocataire(locataire instance);
    partial void Insertlocation(location instance);
    partial void Updatelocation(location instance);
    partial void Deletelocation(location instance);
    partial void Insertproprietaire(proprietaire instance);
    partial void Updateproprietaire(proprietaire instance);
    partial void Deleteproprietaire(proprietaire instance);
    #endregion
		
		public LocationMaisonDataContext() : 
				base(global::House_Rental_Management.Properties.Settings.Default.miniProjectConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public LocationMaisonDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public LocationMaisonDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public LocationMaisonDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public LocationMaisonDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<utilisateur> utilisateur
		{
			get
			{
				return this.GetTable<utilisateur>();
			}
		}
		
		public System.Data.Linq.Table<appartement> appartement
		{
			get
			{
				return this.GetTable<appartement>();
			}
		}
		
		public System.Data.Linq.Table<categorie> categorie
		{
			get
			{
				return this.GetTable<categorie>();
			}
		}
		
		public System.Data.Linq.Table<locataire> locataire
		{
			get
			{
				return this.GetTable<locataire>();
			}
		}
		
		public System.Data.Linq.Table<location> location
		{
			get
			{
				return this.GetTable<location>();
			}
		}
		
		public System.Data.Linq.Table<proprietaire> proprietaire
		{
			get
			{
				return this.GetTable<proprietaire>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.utilisateur")]
	public partial class utilisateur : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _login;
		
		private string _password;
		
    #region Définitions de méthodes d'extensibilité
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnloginChanging(string value);
    partial void OnloginChanged();
    partial void OnpasswordChanging(string value);
    partial void OnpasswordChanged();
    #endregion
		
		public utilisateur()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_login", DbType="VarChar(250) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string login
		{
			get
			{
				return this._login;
			}
			set
			{
				if ((this._login != value))
				{
					this.OnloginChanging(value);
					this.SendPropertyChanging();
					this._login = value;
					this.SendPropertyChanged("login");
					this.OnloginChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_password", DbType="VarChar(MAX)")]
		public string password
		{
			get
			{
				return this._password;
			}
			set
			{
				if ((this._password != value))
				{
					this.OnpasswordChanging(value);
					this.SendPropertyChanging();
					this._password = value;
					this.SendPropertyChanged("password");
					this.OnpasswordChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.appartement")]
	public partial class appartement : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private long _idApp;
		
		private string _addressApp;
		
		private string _typeApp;
		
		private System.Nullable<decimal> _prixApp;
		
		private System.Nullable<long> _idProp;
		
		private System.Nullable<long> _idCategorie;
		
		private string _folderPath;
		
		private EntitySet<location> _location;
		
		private EntityRef<categorie> _categorie;
		
		private EntityRef<proprietaire> _proprietaire;
		
    #region Définitions de méthodes d'extensibilité
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidAppChanging(long value);
    partial void OnidAppChanged();
    partial void OnaddressAppChanging(string value);
    partial void OnaddressAppChanged();
    partial void OntypeAppChanging(string value);
    partial void OntypeAppChanged();
    partial void OnprixAppChanging(System.Nullable<decimal> value);
    partial void OnprixAppChanged();
    partial void OnidPropChanging(System.Nullable<long> value);
    partial void OnidPropChanged();
    partial void OnidCategorieChanging(System.Nullable<long> value);
    partial void OnidCategorieChanged();
    partial void OnfolderPathChanging(string value);
    partial void OnfolderPathChanged();
    #endregion
		
		public appartement()
		{
			this._location = new EntitySet<location>(new Action<location>(this.attach_location), new Action<location>(this.detach_location));
			this._categorie = default(EntityRef<categorie>);
			this._proprietaire = default(EntityRef<proprietaire>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_idApp", AutoSync=AutoSync.OnInsert, DbType="BigInt NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public long idApp
		{
			get
			{
				return this._idApp;
			}
			set
			{
				if ((this._idApp != value))
				{
					this.OnidAppChanging(value);
					this.SendPropertyChanging();
					this._idApp = value;
					this.SendPropertyChanged("idApp");
					this.OnidAppChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_addressApp", DbType="VarChar(100) NOT NULL", CanBeNull=false)]
		public string addressApp
		{
			get
			{
				return this._addressApp;
			}
			set
			{
				if ((this._addressApp != value))
				{
					this.OnaddressAppChanging(value);
					this.SendPropertyChanging();
					this._addressApp = value;
					this.SendPropertyChanged("addressApp");
					this.OnaddressAppChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_typeApp", DbType="VarChar(100) NOT NULL", CanBeNull=false)]
		public string typeApp
		{
			get
			{
				return this._typeApp;
			}
			set
			{
				if ((this._typeApp != value))
				{
					this.OntypeAppChanging(value);
					this.SendPropertyChanging();
					this._typeApp = value;
					this.SendPropertyChanged("typeApp");
					this.OntypeAppChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_prixApp", DbType="Money")]
		public System.Nullable<decimal> prixApp
		{
			get
			{
				return this._prixApp;
			}
			set
			{
				if ((this._prixApp != value))
				{
					this.OnprixAppChanging(value);
					this.SendPropertyChanging();
					this._prixApp = value;
					this.SendPropertyChanged("prixApp");
					this.OnprixAppChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_idProp", DbType="BigInt")]
		public System.Nullable<long> idProp
		{
			get
			{
				return this._idProp;
			}
			set
			{
				if ((this._idProp != value))
				{
					if (this._proprietaire.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnidPropChanging(value);
					this.SendPropertyChanging();
					this._idProp = value;
					this.SendPropertyChanged("idProp");
					this.OnidPropChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_idCategorie", DbType="BigInt")]
		public System.Nullable<long> idCategorie
		{
			get
			{
				return this._idCategorie;
			}
			set
			{
				if ((this._idCategorie != value))
				{
					if (this._categorie.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnidCategorieChanging(value);
					this.SendPropertyChanging();
					this._idCategorie = value;
					this.SendPropertyChanged("idCategorie");
					this.OnidCategorieChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_folderPath", DbType="NVarChar(MAX)")]
		public string folderPath
		{
			get
			{
				return this._folderPath;
			}
			set
			{
				if ((this._folderPath != value))
				{
					this.OnfolderPathChanging(value);
					this.SendPropertyChanging();
					this._folderPath = value;
					this.SendPropertyChanged("folderPath");
					this.OnfolderPathChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="appartement_location", Storage="_location", ThisKey="idApp", OtherKey="idApp")]
		public EntitySet<location> location
		{
			get
			{
				return this._location;
			}
			set
			{
				this._location.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="categorie_appartement", Storage="_categorie", ThisKey="idCategorie", OtherKey="idCategorie", IsForeignKey=true)]
		public categorie categorie
		{
			get
			{
				return this._categorie.Entity;
			}
			set
			{
				categorie previousValue = this._categorie.Entity;
				if (((previousValue != value) 
							|| (this._categorie.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._categorie.Entity = null;
						previousValue.appartement.Remove(this);
					}
					this._categorie.Entity = value;
					if ((value != null))
					{
						value.appartement.Add(this);
						this._idCategorie = value.idCategorie;
					}
					else
					{
						this._idCategorie = default(Nullable<long>);
					}
					this.SendPropertyChanged("categorie");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="proprietaire_appartement", Storage="_proprietaire", ThisKey="idProp", OtherKey="idProp", IsForeignKey=true)]
		public proprietaire proprietaire
		{
			get
			{
				return this._proprietaire.Entity;
			}
			set
			{
				proprietaire previousValue = this._proprietaire.Entity;
				if (((previousValue != value) 
							|| (this._proprietaire.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._proprietaire.Entity = null;
						previousValue.appartement.Remove(this);
					}
					this._proprietaire.Entity = value;
					if ((value != null))
					{
						value.appartement.Add(this);
						this._idProp = value.idProp;
					}
					else
					{
						this._idProp = default(Nullable<long>);
					}
					this.SendPropertyChanged("proprietaire");
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
		
		private void attach_location(location entity)
		{
			this.SendPropertyChanging();
			entity.appartement = this;
		}
		
		private void detach_location(location entity)
		{
			this.SendPropertyChanging();
			entity.appartement = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.categorie")]
	public partial class categorie : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private long _idCategorie;
		
		private string _categorie1;
		
		private string _remarque;
		
		private EntitySet<appartement> _appartement;
		
    #region Définitions de méthodes d'extensibilité
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidCategorieChanging(long value);
    partial void OnidCategorieChanged();
    partial void Oncategorie1Changing(string value);
    partial void Oncategorie1Changed();
    partial void OnremarqueChanging(string value);
    partial void OnremarqueChanged();
    #endregion
		
		public categorie()
		{
			this._appartement = new EntitySet<appartement>(new Action<appartement>(this.attach_appartement), new Action<appartement>(this.detach_appartement));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_idCategorie", AutoSync=AutoSync.OnInsert, DbType="BigInt NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public long idCategorie
		{
			get
			{
				return this._idCategorie;
			}
			set
			{
				if ((this._idCategorie != value))
				{
					this.OnidCategorieChanging(value);
					this.SendPropertyChanging();
					this._idCategorie = value;
					this.SendPropertyChanged("idCategorie");
					this.OnidCategorieChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="categorie", Storage="_categorie1", DbType="VarChar(50)")]
		public string categorie1
		{
			get
			{
				return this._categorie1;
			}
			set
			{
				if ((this._categorie1 != value))
				{
					this.Oncategorie1Changing(value);
					this.SendPropertyChanging();
					this._categorie1 = value;
					this.SendPropertyChanged("categorie1");
					this.Oncategorie1Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_remarque", DbType="VarChar(MAX)")]
		public string remarque
		{
			get
			{
				return this._remarque;
			}
			set
			{
				if ((this._remarque != value))
				{
					this.OnremarqueChanging(value);
					this.SendPropertyChanging();
					this._remarque = value;
					this.SendPropertyChanged("remarque");
					this.OnremarqueChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="categorie_appartement", Storage="_appartement", ThisKey="idCategorie", OtherKey="idCategorie")]
		public EntitySet<appartement> appartement
		{
			get
			{
				return this._appartement;
			}
			set
			{
				this._appartement.Assign(value);
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
		
		private void attach_appartement(appartement entity)
		{
			this.SendPropertyChanging();
			entity.categorie = this;
		}
		
		private void detach_appartement(appartement entity)
		{
			this.SendPropertyChanging();
			entity.categorie = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.locataire")]
	public partial class locataire : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private long _idLocataire;
		
		private string _nomLocataire;
		
		private string _telLoc;
		
		private string _genreLoc;
		
		private EntitySet<location> _location;
		
    #region Définitions de méthodes d'extensibilité
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidLocataireChanging(long value);
    partial void OnidLocataireChanged();
    partial void OnnomLocataireChanging(string value);
    partial void OnnomLocataireChanged();
    partial void OntelLocChanging(string value);
    partial void OntelLocChanged();
    partial void OngenreLocChanging(string value);
    partial void OngenreLocChanged();
    #endregion
		
		public locataire()
		{
			this._location = new EntitySet<location>(new Action<location>(this.attach_location), new Action<location>(this.detach_location));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_idLocataire", AutoSync=AutoSync.OnInsert, DbType="BigInt NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public long idLocataire
		{
			get
			{
				return this._idLocataire;
			}
			set
			{
				if ((this._idLocataire != value))
				{
					this.OnidLocataireChanging(value);
					this.SendPropertyChanging();
					this._idLocataire = value;
					this.SendPropertyChanged("idLocataire");
					this.OnidLocataireChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_nomLocataire", DbType="VarChar(100) NOT NULL", CanBeNull=false)]
		public string nomLocataire
		{
			get
			{
				return this._nomLocataire;
			}
			set
			{
				if ((this._nomLocataire != value))
				{
					this.OnnomLocataireChanging(value);
					this.SendPropertyChanging();
					this._nomLocataire = value;
					this.SendPropertyChanged("nomLocataire");
					this.OnnomLocataireChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_telLoc", DbType="VarChar(20) NOT NULL", CanBeNull=false)]
		public string telLoc
		{
			get
			{
				return this._telLoc;
			}
			set
			{
				if ((this._telLoc != value))
				{
					this.OntelLocChanging(value);
					this.SendPropertyChanging();
					this._telLoc = value;
					this.SendPropertyChanged("telLoc");
					this.OntelLocChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_genreLoc", DbType="VarChar(10) NOT NULL", CanBeNull=false)]
		public string genreLoc
		{
			get
			{
				return this._genreLoc;
			}
			set
			{
				if ((this._genreLoc != value))
				{
					this.OngenreLocChanging(value);
					this.SendPropertyChanging();
					this._genreLoc = value;
					this.SendPropertyChanged("genreLoc");
					this.OngenreLocChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="locataire_location", Storage="_location", ThisKey="idLocataire", OtherKey="idLocataire")]
		public EntitySet<location> location
		{
			get
			{
				return this._location;
			}
			set
			{
				this._location.Assign(value);
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
		
		private void attach_location(location entity)
		{
			this.SendPropertyChanging();
			entity.locataire = this;
		}
		
		private void detach_location(location entity)
		{
			this.SendPropertyChanging();
			entity.locataire = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.location")]
	public partial class location : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private long _idLocation;
		
		private System.Nullable<long> _idApp;
		
		private System.Nullable<long> _idLocataire;
		
		private string _periode;
		
		private System.Nullable<decimal> _cout;
		
		private EntityRef<appartement> _appartement;
		
		private EntityRef<locataire> _locataire;
		
    #region Définitions de méthodes d'extensibilité
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidLocationChanging(long value);
    partial void OnidLocationChanged();
    partial void OnidAppChanging(System.Nullable<long> value);
    partial void OnidAppChanged();
    partial void OnidLocataireChanging(System.Nullable<long> value);
    partial void OnidLocataireChanged();
    partial void OnperiodeChanging(string value);
    partial void OnperiodeChanged();
    partial void OncoutChanging(System.Nullable<decimal> value);
    partial void OncoutChanged();
    #endregion
		
		public location()
		{
			this._appartement = default(EntityRef<appartement>);
			this._locataire = default(EntityRef<locataire>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_idLocation", AutoSync=AutoSync.OnInsert, DbType="BigInt NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public long idLocation
		{
			get
			{
				return this._idLocation;
			}
			set
			{
				if ((this._idLocation != value))
				{
					this.OnidLocationChanging(value);
					this.SendPropertyChanging();
					this._idLocation = value;
					this.SendPropertyChanged("idLocation");
					this.OnidLocationChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_idApp", DbType="BigInt")]
		public System.Nullable<long> idApp
		{
			get
			{
				return this._idApp;
			}
			set
			{
				if ((this._idApp != value))
				{
					if (this._appartement.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnidAppChanging(value);
					this.SendPropertyChanging();
					this._idApp = value;
					this.SendPropertyChanged("idApp");
					this.OnidAppChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_idLocataire", DbType="BigInt")]
		public System.Nullable<long> idLocataire
		{
			get
			{
				return this._idLocataire;
			}
			set
			{
				if ((this._idLocataire != value))
				{
					if (this._locataire.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnidLocataireChanging(value);
					this.SendPropertyChanging();
					this._idLocataire = value;
					this.SendPropertyChanged("idLocataire");
					this.OnidLocataireChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_periode", DbType="VarChar(50)")]
		public string periode
		{
			get
			{
				return this._periode;
			}
			set
			{
				if ((this._periode != value))
				{
					this.OnperiodeChanging(value);
					this.SendPropertyChanging();
					this._periode = value;
					this.SendPropertyChanged("periode");
					this.OnperiodeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_cout", DbType="Money")]
		public System.Nullable<decimal> cout
		{
			get
			{
				return this._cout;
			}
			set
			{
				if ((this._cout != value))
				{
					this.OncoutChanging(value);
					this.SendPropertyChanging();
					this._cout = value;
					this.SendPropertyChanged("cout");
					this.OncoutChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="appartement_location", Storage="_appartement", ThisKey="idApp", OtherKey="idApp", IsForeignKey=true)]
		public appartement appartement
		{
			get
			{
				return this._appartement.Entity;
			}
			set
			{
				appartement previousValue = this._appartement.Entity;
				if (((previousValue != value) 
							|| (this._appartement.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._appartement.Entity = null;
						previousValue.location.Remove(this);
					}
					this._appartement.Entity = value;
					if ((value != null))
					{
						value.location.Add(this);
						this._idApp = value.idApp;
					}
					else
					{
						this._idApp = default(Nullable<long>);
					}
					this.SendPropertyChanged("appartement");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="locataire_location", Storage="_locataire", ThisKey="idLocataire", OtherKey="idLocataire", IsForeignKey=true)]
		public locataire locataire
		{
			get
			{
				return this._locataire.Entity;
			}
			set
			{
				locataire previousValue = this._locataire.Entity;
				if (((previousValue != value) 
							|| (this._locataire.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._locataire.Entity = null;
						previousValue.location.Remove(this);
					}
					this._locataire.Entity = value;
					if ((value != null))
					{
						value.location.Add(this);
						this._idLocataire = value.idLocataire;
					}
					else
					{
						this._idLocataire = default(Nullable<long>);
					}
					this.SendPropertyChanged("locataire");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.proprietaire")]
	public partial class proprietaire : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private long _idProp;
		
		private string _nomProp;
		
		private string _telProp;
		
		private string _genreProp;
		
		private EntitySet<appartement> _appartement;
		
    #region Définitions de méthodes d'extensibilité
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidPropChanging(long value);
    partial void OnidPropChanged();
    partial void OnnomPropChanging(string value);
    partial void OnnomPropChanged();
    partial void OntelPropChanging(string value);
    partial void OntelPropChanged();
    partial void OngenrePropChanging(string value);
    partial void OngenrePropChanged();
    #endregion
		
		public proprietaire()
		{
			this._appartement = new EntitySet<appartement>(new Action<appartement>(this.attach_appartement), new Action<appartement>(this.detach_appartement));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_idProp", AutoSync=AutoSync.OnInsert, DbType="BigInt NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public long idProp
		{
			get
			{
				return this._idProp;
			}
			set
			{
				if ((this._idProp != value))
				{
					this.OnidPropChanging(value);
					this.SendPropertyChanging();
					this._idProp = value;
					this.SendPropertyChanged("idProp");
					this.OnidPropChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_nomProp", DbType="VarChar(100) NOT NULL", CanBeNull=false)]
		public string nomProp
		{
			get
			{
				return this._nomProp;
			}
			set
			{
				if ((this._nomProp != value))
				{
					this.OnnomPropChanging(value);
					this.SendPropertyChanging();
					this._nomProp = value;
					this.SendPropertyChanged("nomProp");
					this.OnnomPropChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_telProp", DbType="VarChar(20) NOT NULL", CanBeNull=false)]
		public string telProp
		{
			get
			{
				return this._telProp;
			}
			set
			{
				if ((this._telProp != value))
				{
					this.OntelPropChanging(value);
					this.SendPropertyChanging();
					this._telProp = value;
					this.SendPropertyChanged("telProp");
					this.OntelPropChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_genreProp", DbType="VarChar(10) NOT NULL", CanBeNull=false)]
		public string genreProp
		{
			get
			{
				return this._genreProp;
			}
			set
			{
				if ((this._genreProp != value))
				{
					this.OngenrePropChanging(value);
					this.SendPropertyChanging();
					this._genreProp = value;
					this.SendPropertyChanged("genreProp");
					this.OngenrePropChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="proprietaire_appartement", Storage="_appartement", ThisKey="idProp", OtherKey="idProp")]
		public EntitySet<appartement> appartement
		{
			get
			{
				return this._appartement;
			}
			set
			{
				this._appartement.Assign(value);
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
		
		private void attach_appartement(appartement entity)
		{
			this.SendPropertyChanging();
			entity.proprietaire = this;
		}
		
		private void detach_appartement(appartement entity)
		{
			this.SendPropertyChanging();
			entity.proprietaire = null;
		}
	}
}
#pragma warning restore 1591