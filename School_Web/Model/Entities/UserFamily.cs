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
	/// IUserFamily interface for NHibernate mapped table 'UserFamily'.
	/// </summary>
	public interface IUserFamily
	{
		#region Public Properties
		
		int UserFamilyId
		{
			get ;
			set ;
			  
		}
		
		int UserId
		{
			get ;
			set ;
			  
		}
		
		int Pindex
		{
			get ;
			set ;
			  
		}
		
		string Truename
		{
			get ;
			set ;
			  
		}
		
		string RelationShip
		{
			get ;
			set ;
			  
		}
		
		string Working
		{
			get ;
			set ;
			  
		}
		
		int Age
		{
			get ;
			set ;
			  
		}
		
		string Party
		{
			get ;
			set ;
			  
		}
		
		string Healthy
		{
			get ;
			set ;
			  
		}
		
		string Remark
		{
			get ;
			set ;
			  
		}
		
		DateTime Pubdate
		{
			get ;
			set ;
			  
		}
		
		int MagUserid
		{
			get ;
			set ;
			  
		}
		
		bool State
		{
			get ;
			set ;
			  
		}
		
		DateTime CheckDate
		{
			get ;
			set ;
			  
		}
		
		bool IsDeleted { get; set; }
		bool IsChanged { get; set; }
		
		#endregion 
	}

	/// <summary>
	/// UserFamily object for NHibernate mapped table 'UserFamily'.
	/// </summary>
	[Serializable]
	public class UserFamily : IUserFamily
	{
		#region Member Variables

		protected int userfamilyid;
		protected int userid;
		protected int pindex;
		protected string truename;
		protected string relationship;
		protected string working;
		protected int age;
		protected string party;
		protected string healthy;
		protected string remark;
		protected DateTime pubdate;
		protected int maguserid;
		protected bool state;
		protected DateTime checkdate;
		protected bool _bIsDeleted;
		protected bool _bIsChanged;
		#endregion
		
		#region Constructors
		public UserFamily() {}
		
		public UserFamily(int pUserId, int pPindex, string pTruename, string pRelationShip, string pWorking, int pAge, string pParty, string pHealthy, string pRemark, DateTime pPubdate, int pMagUserid, bool pState, DateTime pCheckDate)
		{
			this.userid = pUserId; 
			this.pindex = pPindex; 
			this.truename = pTruename; 
			this.relationship = pRelationShip; 
			this.working = pWorking; 
			this.age = pAge; 
			this.party = pParty; 
			this.healthy = pHealthy; 
			this.remark = pRemark; 
			this.pubdate = pPubdate; 
			this.maguserid = pMagUserid; 
			this.state = pState; 
			this.checkdate = pCheckDate; 
		}
		
		public UserFamily(int pUserFamilyId)
		{
			this.userfamilyid = pUserFamilyId; 
		}
		
		#endregion
		
		#region Public Properties
		
		public int UserFamilyId
		{
			get { return userfamilyid; }
			set { _bIsChanged |= (userfamilyid != value); userfamilyid = value; }
			
		}
		
		public int UserId
		{
			get { return userid; }
			set { _bIsChanged |= (userid != value); userid = value; }
			
		}
		
		public int Pindex
		{
			get { return pindex; }
			set { _bIsChanged |= (pindex != value); pindex = value; }
			
		}
		
		public string Truename
		{
			get { return truename; }
			set 
			{
			  if (value != null && value.Length > 50)
			    throw new ArgumentOutOfRangeException("Truename", "Truename value, cannot contain more than 50 characters");
			  _bIsChanged |= (truename != value); 
			  truename = value; 
			}
			
		}
		
		public string RelationShip
		{
			get { return relationship; }
			set 
			{
			  if (value != null && value.Length > 50)
			    throw new ArgumentOutOfRangeException("RelationShip", "RelationShip value, cannot contain more than 50 characters");
			  _bIsChanged |= (relationship != value); 
			  relationship = value; 
			}
			
		}
		
		public string Working
		{
			get { return working; }
			set 
			{
			  if (value != null && value.Length > 50)
			    throw new ArgumentOutOfRangeException("Working", "Working value, cannot contain more than 50 characters");
			  _bIsChanged |= (working != value); 
			  working = value; 
			}
			
		}
		
		public int Age
		{
			get { return age; }
			set { _bIsChanged |= (age != value); age = value; }
			
		}
		
		public string Party
		{
			get { return party; }
			set 
			{
			  if (value != null && value.Length > 50)
			    throw new ArgumentOutOfRangeException("Party", "Party value, cannot contain more than 50 characters");
			  _bIsChanged |= (party != value); 
			  party = value; 
			}
			
		}
		
		public string Healthy
		{
			get { return healthy; }
			set 
			{
			  if (value != null && value.Length > 50)
			    throw new ArgumentOutOfRangeException("Healthy", "Healthy value, cannot contain more than 50 characters");
			  _bIsChanged |= (healthy != value); 
			  healthy = value; 
			}
			
		}
		
		public string Remark
		{
			get { return remark; }
			set 
			{
			  if (value != null && value.Length > 50)
			    throw new ArgumentOutOfRangeException("Remark", "Remark value, cannot contain more than 50 characters");
			  _bIsChanged |= (remark != value); 
			  remark = value; 
			}
			
		}
		
		public DateTime Pubdate
		{
			get { return pubdate; }
			set { _bIsChanged |= (pubdate != value); pubdate = value; }
			
		}
		
		public int MagUserid
		{
			get { return maguserid; }
			set { _bIsChanged |= (maguserid != value); maguserid = value; }
			
		}
		
		public bool State
		{
			get { return state; }
			set { _bIsChanged |= (state != value); state = value; }
			
		}
		
		public DateTime CheckDate
		{
			get { return checkdate; }
			set { _bIsChanged |= (checkdate != value); checkdate = value; }
			
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
	
	#region Custom ICollection interface for UserFamily 

	
	public interface IUserFamilyCollection : ICollection
	{
		UserFamily this[int index]{	get; set; }
		void Add(UserFamily pUserFamily);
		void Clear();
	}
	
	[Serializable]
	public class UserFamilyCollection : IUserFamilyCollection
	{
		private IList<UserFamily> _arrayInternal;

		public UserFamilyCollection()
		{
			_arrayInternal = new List<UserFamily>();
		}
		
		public UserFamilyCollection( IList<UserFamily> pSource )
		{
			_arrayInternal = pSource;
			if(_arrayInternal == null)
			{
				_arrayInternal = new List<UserFamily>();
			}
		}

		public UserFamily this[int index]
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
		public void CopyTo(Array array, int index){ _arrayInternal.CopyTo((UserFamily[])array, index); }
		public IEnumerator GetEnumerator() { return _arrayInternal.GetEnumerator(); }
		public void Add(UserFamily pUserFamily) { _arrayInternal.Add(pUserFamily); }
		public void Clear() { _arrayInternal.Clear(); }
		public IList<UserFamily> GetList() { return _arrayInternal; }
	 }
	
	#endregion
}
