/*
using MyGeneration/Template/NHibernate (c) by Sharp 1.4
based on OHM (alvy77@hotmail.com)
*/
using System;
using System.Collections;
using System.Collections.Generic;

namespace Model
{

	/// <summary>
	/// IUserViewList interface for NHibernate mapped table 'UserViewList'.
	/// </summary>
	public interface IUserViewList
	{
		#region Public Properties
		
		int Id
		{
			get ;
			set ;
			  
		}
		
		int ModuleId
		{
			get ;
			set ;
			  
		}
		
		int ObjUserid
		{
			get ;
			set ;
			  
		}
		
		int Parentid
		{
			get ;
			set ;
			  
		}
		
		int UserId
		{
			get ;
			set ;
			  
		}
		
		DateTime Pubdate
		{
			get ;
			set ;
			  
		}
		
		DateTime LastDate
		{
			get ;
			set ;
			  
		}
		
		string Ip
		{
			get ;
			set ;
			  
		}
		
		int Clicks
		{
			get ;
			set ;
			  
		}
		
		bool IsDeleted { get; set; }
		bool IsChanged { get; set; }
		
		#endregion 
	}

	/// <summary>
	/// UserViewList object for NHibernate mapped table 'UserViewList'.
	/// </summary>
	[Serializable]
	public class UserViewList : IUserViewList
	{
		#region Member Variables

		protected int id;
		protected int moduleid;
		protected int objuserid;
		protected int parentid;
		protected int userid;
		protected DateTime pubdate;
		protected DateTime lastdate;
		protected string ip;
		protected int clicks;
		protected bool _bIsDeleted;
		protected bool _bIsChanged;
		#endregion
		
		#region Constructors
		public UserViewList() {}
		
		public UserViewList(int pModuleId, int pObjUserid, int pParentid, int pUserId, DateTime pPubdate, DateTime pLastDate, string pIp, int pClicks)
		{
			this.moduleid = pModuleId; 
			this.objuserid = pObjUserid; 
			this.parentid = pParentid; 
			this.userid = pUserId; 
			this.pubdate = pPubdate; 
			this.lastdate = pLastDate; 
			this.ip = pIp; 
			this.clicks = pClicks; 
		}
		
		public UserViewList(int pId)
		{
			this.id = pId; 
		}
		
		#endregion
		
		#region Public Properties
		
		public int Id
		{
			get { return id; }
			set { _bIsChanged |= (id != value); id = value; }
			
		}
		
		public int ModuleId
		{
			get { return moduleid; }
			set { _bIsChanged |= (moduleid != value); moduleid = value; }
			
		}
		
		public int ObjUserid
		{
			get { return objuserid; }
			set { _bIsChanged |= (objuserid != value); objuserid = value; }
			
		}
		
		public int Parentid
		{
			get { return parentid; }
			set { _bIsChanged |= (parentid != value); parentid = value; }
			
		}
		
		public int UserId
		{
			get { return userid; }
			set { _bIsChanged |= (userid != value); userid = value; }
			
		}
		
		public DateTime Pubdate
		{
			get { return pubdate; }
			set { _bIsChanged |= (pubdate != value); pubdate = value; }
			
		}
		
		public DateTime LastDate
		{
			get { return lastdate; }
			set { _bIsChanged |= (lastdate != value); lastdate = value; }
			
		}
		
		public string Ip
		{
			get { return ip; }
			set 
			{
			  if (value != null && value.Length > 50)
			    throw new ArgumentOutOfRangeException("Ip", "Ip value, cannot contain more than 50 characters");
			  _bIsChanged |= (ip != value); 
			  ip = value; 
			}
			
		}
		
		public int Clicks
		{
			get { return clicks; }
			set { _bIsChanged |= (clicks != value); clicks = value; }
			
		}
		

		public bool IsDeleted
		{
			get
			{
				return _bIsDeleted;
			}
			set
			{
				_bIsDeleted = value;
			}
		}
		
		public bool IsChanged
		{
			get
			{
				return _bIsChanged;
			}
			set
			{
				_bIsChanged = value;
			}
		}
		
		#endregion 
	}
	
	#region Custom ICollection interface for UserViewList 

	
	public interface IUserViewListCollection : ICollection
	{
		UserViewList this[int index]{	get; set; }
		void Add(UserViewList pUserViewList);
		void Clear();
	}
	
	[Serializable]
	public class UserViewListCollection : IUserViewListCollection
	{
		private IList<UserViewList> _arrayInternal;

		public UserViewListCollection()
		{
			_arrayInternal = new List<UserViewList>();
		}
		
		public UserViewListCollection( IList<UserViewList> pSource )
		{
			_arrayInternal = pSource;
			if(_arrayInternal == null)
			{
				_arrayInternal = new List<UserViewList>();
			}
		}

		public UserViewList this[int index]
		{
			get
			{
				return _arrayInternal[index];
			}
			set
			{
				_arrayInternal[index] = value;
			}
		}

		public int Count { get { return _arrayInternal.Count; } }
		public bool IsSynchronized { get { return false; } }
		public object SyncRoot { get { return _arrayInternal; } }
		public void CopyTo(Array array, int index){ _arrayInternal.CopyTo((UserViewList[])array, index); }
		public IEnumerator GetEnumerator() { return _arrayInternal.GetEnumerator(); }
		public void Add(UserViewList pUserViewList) { _arrayInternal.Add(pUserViewList); }
		public void Clear() { _arrayInternal.Clear(); }
		public IList<UserViewList> GetList() { return _arrayInternal; }
	 }
	
	#endregion
}
