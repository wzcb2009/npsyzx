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
	/// IActiveArea interface for NHibernate mapped table 'ActiveArea'.
	/// </summary>
	public interface IActiveArea
	{
		#region Public Properties
		
		long Id
		{
			get ;
			set ;
			  
		}
		
		long ActiveId
		{
			get ;
			set ;
			  
		}
		
		int GroupId
		{
			get ;
			set ;
			  
		}
		
		int Pindex
		{
			get ;
			set ;
			  
		}
		
		string Address
		{
			get ;
			set ;
			  
		}
		
		int UserCount
		{
			get ;
			set ;
			  
		}
		
		int UserId
		{
			get ;
			set ;
			  
		}
		
		bool UserChecked
		{
			get ;
			set ;
			  
		}
		
		DateTime Pubdate
		{
			get ;
			set ;
			  
		}
		
		bool IsDeleted { get; set; }
		bool IsChanged { get; set; }
		
		#endregion 
	}

	/// <summary>
	/// ActiveArea object for NHibernate mapped table 'ActiveArea'.
	/// </summary>
	[Serializable]
	public class ActiveArea : IActiveArea
	{
		#region Member Variables

		protected long id;
		protected long activeid;
		protected int groupid;
		protected int pindex;
		protected string address;
		protected int usercount;
		protected int userid;
		protected bool userchecked;
		protected DateTime pubdate;
		protected bool _bIsDeleted;
		protected bool _bIsChanged;
		#endregion
		
		#region Constructors
		public ActiveArea() {}
		
		public ActiveArea(long pActiveId, int pGroupId, int pPindex, string pAddress, int pUserCount, int pUserId, bool pUserChecked, DateTime pPubdate)
		{
			this.activeid = pActiveId; 
			this.groupid = pGroupId; 
			this.pindex = pPindex; 
			this.address = pAddress; 
			this.usercount = pUserCount; 
			this.userid = pUserId; 
			this.userchecked = pUserChecked; 
			this.pubdate = pPubdate; 
		}
		
		public ActiveArea(int pUserCount)
		{
			this.usercount = pUserCount; 
		}
		
		public ActiveArea(long pId)
		{
			this.id = pId; 
		}
		
		#endregion
		
		#region Public Properties
		
		public long Id
		{
			get { return id; }
			set { _bIsChanged |= (id != value); id = value; }
			
		}
		
		public long ActiveId
		{
			get { return activeid; }
			set { _bIsChanged |= (activeid != value); activeid = value; }
			
		}
		
		public int GroupId
		{
			get { return groupid; }
			set { _bIsChanged |= (groupid != value); groupid = value; }
			
		}
		
		public int Pindex
		{
			get { return pindex; }
			set { _bIsChanged |= (pindex != value); pindex = value; }
			
		}
		
		public string Address
		{
			get { return address; }
			set 
			{
			  if (value != null && value.Length > 50)
			    throw new ArgumentOutOfRangeException("Address", "Address value, cannot contain more than 50 characters");
			  _bIsChanged |= (address != value); 
			  address = value; 
			}
			
		}
		
		public int UserCount
		{
			get { return usercount; }
			set { _bIsChanged |= (usercount != value); usercount = value; }
			
		}
		
		public int UserId
		{
			get { return userid; }
			set { _bIsChanged |= (userid != value); userid = value; }
			
		}
		
		public bool UserChecked
		{
			get { return userchecked; }
			set { _bIsChanged |= (userchecked != value); userchecked = value; }
			
		}
		
		public DateTime Pubdate
		{
			get { return pubdate; }
			set { _bIsChanged |= (pubdate != value); pubdate = value; }
			
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
	
	#region Custom ICollection interface for ActiveArea 

	
	public interface IActiveAreaCollection : ICollection
	{
		ActiveArea this[int index]{	get; set; }
		void Add(ActiveArea pActiveArea);
		void Clear();
	}
	
	[Serializable]
	public class ActiveAreaCollection : IActiveAreaCollection
	{
		private IList<ActiveArea> _arrayInternal;

		public ActiveAreaCollection()
		{
			_arrayInternal = new List<ActiveArea>();
		}
		
		public ActiveAreaCollection( IList<ActiveArea> pSource )
		{
			_arrayInternal = pSource;
			if(_arrayInternal == null)
			{
				_arrayInternal = new List<ActiveArea>();
			}
		}

		public ActiveArea this[int index]
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
		public void CopyTo(Array array, int index){ _arrayInternal.CopyTo((ActiveArea[])array, index); }
		public IEnumerator GetEnumerator() { return _arrayInternal.GetEnumerator(); }
		public void Add(ActiveArea pActiveArea) { _arrayInternal.Add(pActiveArea); }
		public void Clear() { _arrayInternal.Clear(); }
		public IList<ActiveArea> GetList() { return _arrayInternal; }
	 }
	
	#endregion
}
