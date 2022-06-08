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

namespace Hexx.Server.Db
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="Hexx")]
	public partial class DatabaseDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertUser(User instance);
    partial void UpdateUser(User instance);
    partial void DeleteUser(User instance);
    partial void InsertUserOnTable(UserOnTable instance);
    partial void UpdateUserOnTable(UserOnTable instance);
    partial void DeleteUserOnTable(UserOnTable instance);
    partial void InsertTable(Table instance);
    partial void UpdateTable(Table instance);
    partial void DeleteTable(Table instance);
    partial void InsertGame(Game instance);
    partial void UpdateGame(Game instance);
    partial void DeleteGame(Game instance);
    partial void InsertUserData(UserData instance);
    partial void UpdateUserData(UserData instance);
    partial void DeleteUserData(UserData instance);
    partial void InsertUserToken(UserToken instance);
    partial void UpdateUserToken(UserToken instance);
    partial void DeleteUserToken(UserToken instance);
    #endregion
		
		public DatabaseDataContext() : 
				base(global::Hexx.Server.Properties.Settings.Default.HexxConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DatabaseDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DatabaseDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DatabaseDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DatabaseDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<User> Users
		{
			get
			{
				return this.GetTable<User>();
			}
		}
		
		public System.Data.Linq.Table<UserOnTable> UserOnTables
		{
			get
			{
				return this.GetTable<UserOnTable>();
			}
		}
		
		public System.Data.Linq.Table<Table> Tables
		{
			get
			{
				return this.GetTable<Table>();
			}
		}
		
		public System.Data.Linq.Table<Game> Games
		{
			get
			{
				return this.GetTable<Game>();
			}
		}
		
		public System.Data.Linq.Table<GameMove> GameMoves
		{
			get
			{
				return this.GetTable<GameMove>();
			}
		}
		
		public System.Data.Linq.Table<UserData> UserDatas
		{
			get
			{
				return this.GetTable<UserData>();
			}
		}
		
		public System.Data.Linq.Table<UserToken> UserTokens
		{
			get
			{
				return this.GetTable<UserToken>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Users")]
	public partial class User : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID;
		
		private string _Name;
		
		private string _Password;
		
		private string _Mail;
		
		private EntitySet<UserOnTable> _UserOnTables;
		
		private EntitySet<Table> _Tables;
		
		private EntitySet<Table> _Tables1;
		
		private EntitySet<Game> _Games;
		
		private EntitySet<Game> _Games1;
		
		private EntityRef<UserData> _UserData;
		
		private EntityRef<UserToken> _UserToken;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    partial void OnPasswordChanging(string value);
    partial void OnPasswordChanged();
    partial void OnMailChanging(string value);
    partial void OnMailChanged();
    #endregion
		
		public User()
		{
			this._UserOnTables = new EntitySet<UserOnTable>(new Action<UserOnTable>(this.attach_UserOnTables), new Action<UserOnTable>(this.detach_UserOnTables));
			this._Tables = new EntitySet<Table>(new Action<Table>(this.attach_Tables), new Action<Table>(this.detach_Tables));
			this._Tables1 = new EntitySet<Table>(new Action<Table>(this.attach_Tables1), new Action<Table>(this.detach_Tables1));
			this._Games = new EntitySet<Game>(new Action<Game>(this.attach_Games), new Action<Game>(this.detach_Games));
			this._Games1 = new EntitySet<Game>(new Action<Game>(this.attach_Games1), new Action<Game>(this.detach_Games1));
			this._UserData = default(EntityRef<UserData>);
			this._UserToken = default(EntityRef<UserToken>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int ID
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="VarChar(30) NOT NULL", CanBeNull=false)]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Password", DbType="VarChar(64) NOT NULL", CanBeNull=false)]
		public string Password
		{
			get
			{
				return this._Password;
			}
			set
			{
				if ((this._Password != value))
				{
					this.OnPasswordChanging(value);
					this.SendPropertyChanging();
					this._Password = value;
					this.SendPropertyChanged("Password");
					this.OnPasswordChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Mail", DbType="VarChar(100) NOT NULL", CanBeNull=false)]
		public string Mail
		{
			get
			{
				return this._Mail;
			}
			set
			{
				if ((this._Mail != value))
				{
					this.OnMailChanging(value);
					this.SendPropertyChanging();
					this._Mail = value;
					this.SendPropertyChanged("Mail");
					this.OnMailChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="User_UsersOnTable", Storage="_UserOnTables", ThisKey="ID", OtherKey="User")]
		public EntitySet<UserOnTable> UserOnTables
		{
			get
			{
				return this._UserOnTables;
			}
			set
			{
				this._UserOnTables.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="User_Table", Storage="_Tables", ThisKey="ID", OtherKey="Seat1")]
		public EntitySet<Table> Tables
		{
			get
			{
				return this._Tables;
			}
			set
			{
				this._Tables.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="User_Table1", Storage="_Tables1", ThisKey="ID", OtherKey="Seat2")]
		public EntitySet<Table> Tables1
		{
			get
			{
				return this._Tables1;
			}
			set
			{
				this._Tables1.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="User_Game", Storage="_Games", ThisKey="ID", OtherKey="Player1")]
		public EntitySet<Game> Games
		{
			get
			{
				return this._Games;
			}
			set
			{
				this._Games.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="User_Game1", Storage="_Games1", ThisKey="ID", OtherKey="Player2")]
		public EntitySet<Game> Games1
		{
			get
			{
				return this._Games1;
			}
			set
			{
				this._Games1.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="User_UserData", Storage="_UserData", ThisKey="ID", OtherKey="ID", IsUnique=true, IsForeignKey=false)]
		public UserData UserData
		{
			get
			{
				return this._UserData.Entity;
			}
			set
			{
				UserData previousValue = this._UserData.Entity;
				if (((previousValue != value) 
							|| (this._UserData.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._UserData.Entity = null;
						previousValue.User = null;
					}
					this._UserData.Entity = value;
					if ((value != null))
					{
						value.User = this;
					}
					this.SendPropertyChanged("UserData");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="User_UserToken", Storage="_UserToken", ThisKey="ID", OtherKey="ID", IsUnique=true, IsForeignKey=false)]
		public UserToken UserToken
		{
			get
			{
				return this._UserToken.Entity;
			}
			set
			{
				UserToken previousValue = this._UserToken.Entity;
				if (((previousValue != value) 
							|| (this._UserToken.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._UserToken.Entity = null;
						previousValue.User = null;
					}
					this._UserToken.Entity = value;
					if ((value != null))
					{
						value.User = this;
					}
					this.SendPropertyChanged("UserToken");
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
		
		private void attach_UserOnTables(UserOnTable entity)
		{
			this.SendPropertyChanging();
			entity.User1 = this;
		}
		
		private void detach_UserOnTables(UserOnTable entity)
		{
			this.SendPropertyChanging();
			entity.User1 = null;
		}
		
		private void attach_Tables(Table entity)
		{
			this.SendPropertyChanging();
			entity.User = this;
		}
		
		private void detach_Tables(Table entity)
		{
			this.SendPropertyChanging();
			entity.User = null;
		}
		
		private void attach_Tables1(Table entity)
		{
			this.SendPropertyChanging();
			entity.User1 = this;
		}
		
		private void detach_Tables1(Table entity)
		{
			this.SendPropertyChanging();
			entity.User1 = null;
		}
		
		private void attach_Games(Game entity)
		{
			this.SendPropertyChanging();
			entity.User = this;
		}
		
		private void detach_Games(Game entity)
		{
			this.SendPropertyChanging();
			entity.User = null;
		}
		
		private void attach_Games1(Game entity)
		{
			this.SendPropertyChanging();
			entity.User1 = this;
		}
		
		private void detach_Games1(Game entity)
		{
			this.SendPropertyChanging();
			entity.User1 = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.UsersOnTable")]
	public partial class UserOnTable : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Table;
		
		private int _User;
		
		private EntityRef<User> _User1;
		
		private EntityRef<Table> _Table1;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnTableChanging(int value);
    partial void OnTableChanged();
    partial void OnUserChanging(int value);
    partial void OnUserChanged();
    #endregion
		
		public UserOnTable()
		{
			this._User1 = default(EntityRef<User>);
			this._Table1 = default(EntityRef<Table>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[Table]", Storage="_Table", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int Table
		{
			get
			{
				return this._Table;
			}
			set
			{
				if ((this._Table != value))
				{
					this.OnTableChanging(value);
					this.SendPropertyChanging();
					this._Table = value;
					this.SendPropertyChanged("Table");
					this.OnTableChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[User]", Storage="_User", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int User
		{
			get
			{
				return this._User;
			}
			set
			{
				if ((this._User != value))
				{
					this.OnUserChanging(value);
					this.SendPropertyChanging();
					this._User = value;
					this.SendPropertyChanged("User");
					this.OnUserChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="User_UsersOnTable", Storage="_User1", ThisKey="User", OtherKey="ID", IsForeignKey=true)]
		public User User1
		{
			get
			{
				return this._User1.Entity;
			}
			set
			{
				User previousValue = this._User1.Entity;
				if (((previousValue != value) 
							|| (this._User1.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._User1.Entity = null;
						previousValue.UserOnTables.Remove(this);
					}
					this._User1.Entity = value;
					if ((value != null))
					{
						value.UserOnTables.Add(this);
						this._User = value.ID;
					}
					else
					{
						this._User = default(int);
					}
					this.SendPropertyChanged("User1");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Table_UsersOnTable", Storage="_Table1", ThisKey="Table", OtherKey="Number", IsForeignKey=true)]
		public Table Table1
		{
			get
			{
				return this._Table1.Entity;
			}
			set
			{
				Table previousValue = this._Table1.Entity;
				if (((previousValue != value) 
							|| (this._Table1.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Table1.Entity = null;
						previousValue.UserOnTables.Remove(this);
					}
					this._Table1.Entity = value;
					if ((value != null))
					{
						value.UserOnTables.Add(this);
						this._Table = value.Number;
					}
					else
					{
						this._Table = default(int);
					}
					this.SendPropertyChanged("Table1");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Tables")]
	public partial class Table : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Number;
		
		private int _GameID;
		
		private System.Nullable<int> _Seat1;
		
		private System.Nullable<int> _Seat2;
		
		private int _BoardSize;
		
		private int _TimeForPlayer;
		
		private EntitySet<UserOnTable> _UserOnTables;
		
		private EntityRef<User> _User;
		
		private EntityRef<User> _User1;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnNumberChanging(int value);
    partial void OnNumberChanged();
    partial void OnGameIDChanging(int value);
    partial void OnGameIDChanged();
    partial void OnSeat1Changing(System.Nullable<int> value);
    partial void OnSeat1Changed();
    partial void OnSeat2Changing(System.Nullable<int> value);
    partial void OnSeat2Changed();
    partial void OnBoardSizeChanging(int value);
    partial void OnBoardSizeChanged();
    partial void OnTimeForPlayerChanging(int value);
    partial void OnTimeForPlayerChanged();
    #endregion
		
		public Table()
		{
			this._UserOnTables = new EntitySet<UserOnTable>(new Action<UserOnTable>(this.attach_UserOnTables), new Action<UserOnTable>(this.detach_UserOnTables));
			this._User = default(EntityRef<User>);
			this._User1 = default(EntityRef<User>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Number", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int Number
		{
			get
			{
				return this._Number;
			}
			set
			{
				if ((this._Number != value))
				{
					this.OnNumberChanging(value);
					this.SendPropertyChanging();
					this._Number = value;
					this.SendPropertyChanged("Number");
					this.OnNumberChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_GameID", DbType="Int NOT NULL")]
		public int GameID
		{
			get
			{
				return this._GameID;
			}
			set
			{
				if ((this._GameID != value))
				{
					this.OnGameIDChanging(value);
					this.SendPropertyChanging();
					this._GameID = value;
					this.SendPropertyChanged("GameID");
					this.OnGameIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Seat1", DbType="Int")]
		public System.Nullable<int> Seat1
		{
			get
			{
				return this._Seat1;
			}
			set
			{
				if ((this._Seat1 != value))
				{
					if (this._User.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnSeat1Changing(value);
					this.SendPropertyChanging();
					this._Seat1 = value;
					this.SendPropertyChanged("Seat1");
					this.OnSeat1Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Seat2", DbType="Int")]
		public System.Nullable<int> Seat2
		{
			get
			{
				return this._Seat2;
			}
			set
			{
				if ((this._Seat2 != value))
				{
					if (this._User1.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnSeat2Changing(value);
					this.SendPropertyChanging();
					this._Seat2 = value;
					this.SendPropertyChanged("Seat2");
					this.OnSeat2Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_BoardSize", DbType="Int NOT NULL")]
		public int BoardSize
		{
			get
			{
				return this._BoardSize;
			}
			set
			{
				if ((this._BoardSize != value))
				{
					this.OnBoardSizeChanging(value);
					this.SendPropertyChanging();
					this._BoardSize = value;
					this.SendPropertyChanged("BoardSize");
					this.OnBoardSizeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TimeForPlayer", DbType="Int NOT NULL")]
		public int TimeForPlayer
		{
			get
			{
				return this._TimeForPlayer;
			}
			set
			{
				if ((this._TimeForPlayer != value))
				{
					this.OnTimeForPlayerChanging(value);
					this.SendPropertyChanging();
					this._TimeForPlayer = value;
					this.SendPropertyChanged("TimeForPlayer");
					this.OnTimeForPlayerChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Table_UsersOnTable", Storage="_UserOnTables", ThisKey="Number", OtherKey="Table")]
		public EntitySet<UserOnTable> UserOnTables
		{
			get
			{
				return this._UserOnTables;
			}
			set
			{
				this._UserOnTables.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="User_Table", Storage="_User", ThisKey="Seat1", OtherKey="ID", IsForeignKey=true)]
		public User User
		{
			get
			{
				return this._User.Entity;
			}
			set
			{
				User previousValue = this._User.Entity;
				if (((previousValue != value) 
							|| (this._User.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._User.Entity = null;
						previousValue.Tables.Remove(this);
					}
					this._User.Entity = value;
					if ((value != null))
					{
						value.Tables.Add(this);
						this._Seat1 = value.ID;
					}
					else
					{
						this._Seat1 = default(Nullable<int>);
					}
					this.SendPropertyChanged("User");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="User_Table1", Storage="_User1", ThisKey="Seat2", OtherKey="ID", IsForeignKey=true)]
		public User User1
		{
			get
			{
				return this._User1.Entity;
			}
			set
			{
				User previousValue = this._User1.Entity;
				if (((previousValue != value) 
							|| (this._User1.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._User1.Entity = null;
						previousValue.Tables1.Remove(this);
					}
					this._User1.Entity = value;
					if ((value != null))
					{
						value.Tables1.Add(this);
						this._Seat2 = value.ID;
					}
					else
					{
						this._Seat2 = default(Nullable<int>);
					}
					this.SendPropertyChanged("User1");
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
		
		private void attach_UserOnTables(UserOnTable entity)
		{
			this.SendPropertyChanging();
			entity.Table1 = this;
		}
		
		private void detach_UserOnTables(UserOnTable entity)
		{
			this.SendPropertyChanging();
			entity.Table1 = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Games")]
	public partial class Game : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID;
		
		private int _Player1;
		
		private int _Player2;
		
		private bool _Ongoing;
		
		private int _BoardSize;
		
		private int _TimeForPlayer;
		
		private int _StartTime;
		
		private EntityRef<User> _User;
		
		private EntityRef<User> _User1;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnPlayer1Changing(int value);
    partial void OnPlayer1Changed();
    partial void OnPlayer2Changing(int value);
    partial void OnPlayer2Changed();
    partial void OnOngoingChanging(bool value);
    partial void OnOngoingChanged();
    partial void OnBoardSizeChanging(int value);
    partial void OnBoardSizeChanged();
    partial void OnTimeForPlayerChanging(int value);
    partial void OnTimeForPlayerChanged();
    partial void OnStartTimeChanging(int value);
    partial void OnStartTimeChanged();
    #endregion
		
		public Game()
		{
			this._User = default(EntityRef<User>);
			this._User1 = default(EntityRef<User>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int ID
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Player1", DbType="Int NOT NULL")]
		public int Player1
		{
			get
			{
				return this._Player1;
			}
			set
			{
				if ((this._Player1 != value))
				{
					if (this._User.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnPlayer1Changing(value);
					this.SendPropertyChanging();
					this._Player1 = value;
					this.SendPropertyChanged("Player1");
					this.OnPlayer1Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Player2", DbType="Int NOT NULL")]
		public int Player2
		{
			get
			{
				return this._Player2;
			}
			set
			{
				if ((this._Player2 != value))
				{
					if (this._User1.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnPlayer2Changing(value);
					this.SendPropertyChanging();
					this._Player2 = value;
					this.SendPropertyChanged("Player2");
					this.OnPlayer2Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Ongoing", DbType="Bit NOT NULL")]
		public bool Ongoing
		{
			get
			{
				return this._Ongoing;
			}
			set
			{
				if ((this._Ongoing != value))
				{
					this.OnOngoingChanging(value);
					this.SendPropertyChanging();
					this._Ongoing = value;
					this.SendPropertyChanged("Ongoing");
					this.OnOngoingChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_BoardSize", DbType="Int NOT NULL")]
		public int BoardSize
		{
			get
			{
				return this._BoardSize;
			}
			set
			{
				if ((this._BoardSize != value))
				{
					this.OnBoardSizeChanging(value);
					this.SendPropertyChanging();
					this._BoardSize = value;
					this.SendPropertyChanged("BoardSize");
					this.OnBoardSizeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TimeForPlayer", DbType="Int NOT NULL")]
		public int TimeForPlayer
		{
			get
			{
				return this._TimeForPlayer;
			}
			set
			{
				if ((this._TimeForPlayer != value))
				{
					this.OnTimeForPlayerChanging(value);
					this.SendPropertyChanging();
					this._TimeForPlayer = value;
					this.SendPropertyChanged("TimeForPlayer");
					this.OnTimeForPlayerChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_StartTime", DbType="Int NOT NULL")]
		public int StartTime
		{
			get
			{
				return this._StartTime;
			}
			set
			{
				if ((this._StartTime != value))
				{
					this.OnStartTimeChanging(value);
					this.SendPropertyChanging();
					this._StartTime = value;
					this.SendPropertyChanged("StartTime");
					this.OnStartTimeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="User_Game", Storage="_User", ThisKey="Player1", OtherKey="ID", IsForeignKey=true)]
		public User User
		{
			get
			{
				return this._User.Entity;
			}
			set
			{
				User previousValue = this._User.Entity;
				if (((previousValue != value) 
							|| (this._User.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._User.Entity = null;
						previousValue.Games.Remove(this);
					}
					this._User.Entity = value;
					if ((value != null))
					{
						value.Games.Add(this);
						this._Player1 = value.ID;
					}
					else
					{
						this._Player1 = default(int);
					}
					this.SendPropertyChanged("User");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="User_Game1", Storage="_User1", ThisKey="Player2", OtherKey="ID", IsForeignKey=true)]
		public User User1
		{
			get
			{
				return this._User1.Entity;
			}
			set
			{
				User previousValue = this._User1.Entity;
				if (((previousValue != value) 
							|| (this._User1.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._User1.Entity = null;
						previousValue.Games1.Remove(this);
					}
					this._User1.Entity = value;
					if ((value != null))
					{
						value.Games1.Add(this);
						this._Player2 = value.ID;
					}
					else
					{
						this._Player2 = default(int);
					}
					this.SendPropertyChanged("User1");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.GameMoves")]
	public partial class GameMove
	{
		
		private int _GameID;
		
		private int _Player;
		
		private int _FieldFrom;
		
		private int _FieldTo;
		
		private int _Time;
		
		public GameMove()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_GameID", DbType="Int NOT NULL")]
		public int GameID
		{
			get
			{
				return this._GameID;
			}
			set
			{
				if ((this._GameID != value))
				{
					this._GameID = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Player", DbType="Int NOT NULL")]
		public int Player
		{
			get
			{
				return this._Player;
			}
			set
			{
				if ((this._Player != value))
				{
					this._Player = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FieldFrom", DbType="Int NOT NULL")]
		public int FieldFrom
		{
			get
			{
				return this._FieldFrom;
			}
			set
			{
				if ((this._FieldFrom != value))
				{
					this._FieldFrom = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FieldTo", DbType="Int NOT NULL")]
		public int FieldTo
		{
			get
			{
				return this._FieldTo;
			}
			set
			{
				if ((this._FieldTo != value))
				{
					this._FieldTo = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Time", DbType="Int NOT NULL")]
		public int Time
		{
			get
			{
				return this._Time;
			}
			set
			{
				if ((this._Time != value))
				{
					this._Time = value;
				}
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.UserData")]
	public partial class UserData : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID = default(int);
		
		private string _Name;
		
		private System.Nullable<System.DateTime> _BirthDate;
		
		private System.DateTime _CreationDate;
		
		private int _Rank;
		
		private EntityRef<User> _User;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    partial void OnBirthDateChanging(System.Nullable<System.DateTime> value);
    partial void OnBirthDateChanged();
    partial void OnCreationDateChanging(System.DateTime value);
    partial void OnCreationDateChanged();
    partial void OnRankChanging(int value);
    partial void OnRankChanged();
    #endregion
		
		public UserData()
		{
			this._User = default(EntityRef<User>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", DbType="Int NOT NULL", IsPrimaryKey=true, UpdateCheck=UpdateCheck.Never)]
		public int ID
		{
			get
			{
				return this._ID;
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="VarChar(50)")]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_BirthDate", DbType="Date")]
		public System.Nullable<System.DateTime> BirthDate
		{
			get
			{
				return this._BirthDate;
			}
			set
			{
				if ((this._BirthDate != value))
				{
					this.OnBirthDateChanging(value);
					this.SendPropertyChanging();
					this._BirthDate = value;
					this.SendPropertyChanged("BirthDate");
					this.OnBirthDateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CreationDate", DbType="Date NOT NULL")]
		public System.DateTime CreationDate
		{
			get
			{
				return this._CreationDate;
			}
			set
			{
				if ((this._CreationDate != value))
				{
					this.OnCreationDateChanging(value);
					this.SendPropertyChanging();
					this._CreationDate = value;
					this.SendPropertyChanged("CreationDate");
					this.OnCreationDateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Rank", DbType="Int NOT NULL")]
		public int Rank
		{
			get
			{
				return this._Rank;
			}
			set
			{
				if ((this._Rank != value))
				{
					this.OnRankChanging(value);
					this.SendPropertyChanging();
					this._Rank = value;
					this.SendPropertyChanged("Rank");
					this.OnRankChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="User_UserData", Storage="_User", ThisKey="ID", OtherKey="ID", IsForeignKey=true)]
		public User User
		{
			get
			{
				return this._User.Entity;
			}
			set
			{
				User previousValue = this._User.Entity;
				if (((previousValue != value) 
							|| (this._User.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._User.Entity = null;
						previousValue.UserData = null;
					}
					this._User.Entity = value;
					if ((value != null))
					{
						value.UserData = this;
						this._ID = value.ID;
					}
					else
					{
						this._ID = default(int);
					}
					this.SendPropertyChanged("User");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.UserTokens")]
	public partial class UserToken : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID;
		
		private string _Token;
		
		private string _ClientGuid;
		
		private EntityRef<User> _User;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnTokenChanging(string value);
    partial void OnTokenChanged();
    partial void OnClientGuidChanging(string value);
    partial void OnClientGuidChanged();
    #endregion
		
		public UserToken()
		{
			this._User = default(EntityRef<User>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					if (this._User.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._ID = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Token", DbType="VarChar(64) NOT NULL", CanBeNull=false)]
		public string Token
		{
			get
			{
				return this._Token;
			}
			set
			{
				if ((this._Token != value))
				{
					this.OnTokenChanging(value);
					this.SendPropertyChanging();
					this._Token = value;
					this.SendPropertyChanged("Token");
					this.OnTokenChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ClientGuid", DbType="VarChar(32) NOT NULL", CanBeNull=false)]
		public string ClientGuid
		{
			get
			{
				return this._ClientGuid;
			}
			set
			{
				if ((this._ClientGuid != value))
				{
					this.OnClientGuidChanging(value);
					this.SendPropertyChanging();
					this._ClientGuid = value;
					this.SendPropertyChanged("ClientGuid");
					this.OnClientGuidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="User_UserToken", Storage="_User", ThisKey="ID", OtherKey="ID", IsForeignKey=true)]
		public User User
		{
			get
			{
				return this._User.Entity;
			}
			set
			{
				User previousValue = this._User.Entity;
				if (((previousValue != value) 
							|| (this._User.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._User.Entity = null;
						previousValue.UserToken = null;
					}
					this._User.Entity = value;
					if ((value != null))
					{
						value.UserToken = this;
						this._ID = value.ID;
					}
					else
					{
						this._ID = default(int);
					}
					this.SendPropertyChanged("User");
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