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
	/// IUser_SystemCase interface for NHibernate mapped table 'User_SystemCase'.
	/// </summary>
	public interface IUser_SystemCase
	{
		#region Public Properties
		
		int id
		{
			get ;
			set ;
			  
		}
		
		int UnitId
		{
			get ;
			set ;
			  
		}
		
		int CaseId
		{
			get ;
			set ;
			  
		}
		
		int UserId
		{
			get ;
			set ;
			  
		}
		
		int ParentId
		{
			get ;
			set ;
			  
		}
		
		bool IsAdmin
		{
			get ;
			set ;
			  
		}
		
		bool IsDeleted { get; set; }
		bool IsChanged { get; set; }
		
		#endregion 
	}

	/// <summary>
	/// User_SystemCase object for NHibernate mapped table 'User_SystemCase'.
	/// </summary>
	[Serializable]
	public class User_SystemCase : IUser_SystemCase
	{
		#region Member Variables

		protected int id;
		protected int unitid;
		protected int caseid;
		protected int userid;
		protected int parentid;
		protected bool isadmin;
		protected bool _bIsDeleted;
		protected bool _bIsChanged;
		#endregion
		
		#region Constructors
		public User_SystemCase() {}
		
		public User_SystemCase(int pUnitId, int pCaseId, int pUserId, int pParentId, bool pIsAdmin)
		{
			this.unitid = pUnitId; 
			this.caseid = pCaseId; 
			this.userid = pUserId; 
			this.parentid = pParentId; 
			this.isadmin = pIsAdmin; 
		}
		
		public User_SystemCase(int pId)
		{
			this.id = pId; 
		}
		
		#endregion
		
		#region Public Properties
		
		public virtual int id
		{
			get { return id; }
			set { _bIsChanged |= (id != value); id = value; }
			
		}
		
		public virtual int UnitId
		{
			get { return unitid; }
			set { _bIsChanged |= (unitid != value); unitid = value; }
			
		}
		
		public virtual int CaseId
		{
			get { return caseid; }
			set { _bIsChanged |= (caseid != value); caseid = value; }
			
		}
		
		public virtual int UserId
		{
			get { return userid; }
			set { _bIsChanged |= (userid != value); userid = value; }
			
		}
		
		public virtual int ParentId
		{
			get { return parentid; }
			set { _bIsChanged |= (parentid != value); parentid = value; }
			
		}
		
		public virtual bool IsAdmin
		{
			get { return isadmin; }
			set { _bIsChanged |= (isadmin != value); isadmin = value; }
			
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
	
	#region Custom ICollection interface for User_SystemCase 

	
	public interface IUser_SystemCaseCollection : ICollection
	{
		User_SystemCase this[int index]{	get; set; }
		void Add(User_SystemCase pUser_SystemCase);
		void Clear();
	}
	
	[Serializable]
	public class User_SystemCaseCollection : IUser_SystemCaseCollection
	{
		private IList<User_SystemCase> _arrayInternal;

		public User_SystemCaseCollection()
		{
			_arrayInternal = new List<User_SystemCase>();
		}
		
		public User_SystemCaseCollection( IList<User_SystemCase> pSource )
		{
			_arrayInternal = pSource;
			if(_arrayInternal == null)
			{
				_arrayInternal = new List<User_SystemCase>();
			}
		}

		public User_SystemCase this[int index]
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
		public void CopyTo(Array array, int index){ _arrayInternal.CopyTo((User_SystemCase[])array, index); }
		public IEnumerator GetEnumerator() { return _arrayInternal.GetEnumerator(); }
		public void Add(User_SystemCase pUser_SystemCase) { _arrayInternal.Add(pUser_SystemCase); }
		public void Clear() { _arrayInternal.Clear(); }
		public IList<User_SystemCase> GetList() { return _arrayInternal; }
	 }
	
	#endregion
}
