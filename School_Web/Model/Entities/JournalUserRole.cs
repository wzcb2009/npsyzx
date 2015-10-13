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
	/// IJournalUserRole interface for NHibernate mapped table 'Journal_user_role'.
	/// </summary>
	public interface IJournalUserRole
	{
		#region Public Properties
		
		int Id
		{
			get ;
			set ;
			  
		}
		
		string Rolename
		{
			get ;
			set ;
			  
		}
		
		string CheckState
		{
			get ;
			set ;
			  
		}
		
		string Syslmid
		{
			get ;
			set ;
			  
		}
		
		bool IsDeleted { get; set; }
		bool IsChanged { get; set; }
		
		#endregion 
	}

	/// <summary>
	/// JournalUserRole object for NHibernate mapped table 'Journal_user_role'.
	/// </summary>
	[Serializable]
	public class JournalUserRole : IJournalUserRole
	{
		#region Member Variables

		protected int id;
		protected string rolename;
		protected string checkstate;
		protected string syslmid;
		protected bool _bIsDeleted;
		protected bool _bIsChanged;
		#endregion
		
		#region Constructors
		public JournalUserRole() {}
		
		public JournalUserRole(int pId, string pRolename, string pCheckState, string pSyslmid)
		{
			this.id = pId; 
			this.rolename = pRolename; 
			this.checkstate = pCheckState; 
			this.syslmid = pSyslmid; 
		}
		
		public JournalUserRole(int pId)
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
		
		public string Rolename
		{
			get { return rolename; }
			set 
			{
			  if (value != null && value.Length > 50)
			    throw new ArgumentOutOfRangeException("Rolename", "Rolename value, cannot contain more than 50 characters");
			  _bIsChanged |= (rolename != value); 
			  rolename = value; 
			}
			
		}
		
		public string CheckState
		{
			get { return checkstate; }
			set 
			{
			  if (value != null && value.Length > 50)
			    throw new ArgumentOutOfRangeException("CheckState", "CheckState value, cannot contain more than 50 characters");
			  _bIsChanged |= (checkstate != value); 
			  checkstate = value; 
			}
			
		}
		
		public string Syslmid
		{
			get { return syslmid; }
			set 
			{
			  if (value != null && value.Length > 250)
			    throw new ArgumentOutOfRangeException("Syslmid", "Syslmid value, cannot contain more than 250 characters");
			  _bIsChanged |= (syslmid != value); 
			  syslmid = value; 
			}
			
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
	
	#region Custom ICollection interface for JournalUserRole 

	
	public interface IJournalUserRoleCollection : ICollection
	{
		JournalUserRole this[int index]{	get; set; }
		void Add(JournalUserRole pJournalUserRole);
		void Clear();
	}
	
	[Serializable]
	public class JournalUserRoleCollection : IJournalUserRoleCollection
	{
		private IList<JournalUserRole> _arrayInternal;

		public JournalUserRoleCollection()
		{
			_arrayInternal = new List<JournalUserRole>();
		}
		
		public JournalUserRoleCollection( IList<JournalUserRole> pSource )
		{
			_arrayInternal = pSource;
			if(_arrayInternal == null)
			{
				_arrayInternal = new List<JournalUserRole>();
			}
		}

		public JournalUserRole this[int index]
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
		public void CopyTo(Array array, int index){ _arrayInternal.CopyTo((JournalUserRole[])array, index); }
		public IEnumerator GetEnumerator() { return _arrayInternal.GetEnumerator(); }
		public void Add(JournalUserRole pJournalUserRole) { _arrayInternal.Add(pJournalUserRole); }
		public void Clear() { _arrayInternal.Clear(); }
		public IList<JournalUserRole> GetList() { return _arrayInternal; }
	 }
	
	#endregion
}
