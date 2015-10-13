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
	/// IUserSystemCase interface for NHibernate mapped table 'User_SystemCase'.
	/// </summary>
	public interface IUserSystemCase
	{
		#region Public Properties
		
		int Id
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
	/// UserSystemCase object for NHibernate mapped table 'User_SystemCase'.
	/// </summary>
	[Serializable]
	public class UserSystemCase : IUserSystemCase
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
		public UserSystemCase() {}
		
		public UserSystemCase(int pUnitId, int pCaseId, int pUserId, int pParentId, bool pIsAdmin)
		{
			this.unitid = pUnitId; 
			this.caseid = pCaseId; 
			this.userid = pUserId; 
			this.parentid = pParentId; 
			this.isadmin = pIsAdmin; 
		}
		
		public UserSystemCase(int pId)
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
		
		public int UnitId
		{
			get { return unitid; }
			set { _bIsChanged |= (unitid != value); unitid = value; }
			
		}
		
		public int CaseId
		{
			get { return caseid; }
			set { _bIsChanged |= (caseid != value); caseid = value; }
			
		}
		
		public int UserId
		{
			get { return userid; }
			set { _bIsChanged |= (userid != value); userid = value; }
			
		}
		
		public int ParentId
		{
			get { return parentid; }
			set { _bIsChanged |= (parentid != value); parentid = value; }
			
		}
		
		public bool IsAdmin
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
	
	#region Custom ICollection interface for UserSystemCase 

	
	public interface IUserSystemCaseCollection : ICollection
	{
		UserSystemCase this[int index]{	get; set; }
		void Add(UserSystemCase pUserSystemCase);
		void Clear();
	}
	
	[Serializable]
	public class UserSystemCaseCollection : IUserSystemCaseCollection
	{
		private IList<UserSystemCase> _arrayInternal;

		public UserSystemCaseCollection()
		{
			_arrayInternal = new List<UserSystemCase>();
		}
		
		public UserSystemCaseCollection( IList<UserSystemCase> pSource )
		{
			_arrayInternal = pSource;
			if(_arrayInternal == null)
			{
				_arrayInternal = new List<UserSystemCase>();
			}
		}

		public UserSystemCase this[int index]
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
		public void CopyTo(Array array, int index){ _arrayInternal.CopyTo((UserSystemCase[])array, index); }
		public IEnumerator GetEnumerator() { return _arrayInternal.GetEnumerator(); }
		public void Add(UserSystemCase pUserSystemCase) { _arrayInternal.Add(pUserSystemCase); }
		public void Clear() { _arrayInternal.Clear(); }
		public IList<UserSystemCase> GetList() { return _arrayInternal; }
	 }
	
	#endregion
}
