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
	/// IJournalUserRolelist interface for NHibernate mapped table 'Journal_USER_Rolelist'.
	/// </summary>
	public interface IJournalUserRolelist
	{
		#region Public Properties
		
		int Id
		{
			get ;
			set ;
			  
		}
		
		int Userid
		{
			get ;
			set ;
			  
		}
		
		int Roleid
		{
			get ;
			set ;
			  
		}
		
		bool IsDeleted { get; set; }
		bool IsChanged { get; set; }
		
		#endregion 
	}

	/// <summary>
	/// JournalUserRolelist object for NHibernate mapped table 'Journal_USER_Rolelist'.
	/// </summary>
	[Serializable]
	public class JournalUserRolelist : IJournalUserRolelist
	{
		#region Member Variables

		protected int id;
		protected int userid;
		protected int roleid;
		protected bool _bIsDeleted;
		protected bool _bIsChanged;
		#endregion
		
		#region Constructors
		public JournalUserRolelist() {}
		
		public JournalUserRolelist(int pId, int pUserid, int pRoleid)
		{
			this.id = pId; 
			this.userid = pUserid; 
			this.roleid = pRoleid; 
		}
		
		public JournalUserRolelist(int pId)
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
		
		public int Userid
		{
			get { return userid; }
			set { _bIsChanged |= (userid != value); userid = value; }
			
		}
		
		public int Roleid
		{
			get { return roleid; }
			set { _bIsChanged |= (roleid != value); roleid = value; }
			
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
	
	#region Custom ICollection interface for JournalUserRolelist 

	
	public interface IJournalUserRolelistCollection : ICollection
	{
		JournalUserRolelist this[int index]{	get; set; }
		void Add(JournalUserRolelist pJournalUserRolelist);
		void Clear();
	}
	
	[Serializable]
	public class JournalUserRolelistCollection : IJournalUserRolelistCollection
	{
		private IList<JournalUserRolelist> _arrayInternal;

		public JournalUserRolelistCollection()
		{
			_arrayInternal = new List<JournalUserRolelist>();
		}
		
		public JournalUserRolelistCollection( IList<JournalUserRolelist> pSource )
		{
			_arrayInternal = pSource;
			if(_arrayInternal == null)
			{
				_arrayInternal = new List<JournalUserRolelist>();
			}
		}

		public JournalUserRolelist this[int index]
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
		public void CopyTo(Array array, int index){ _arrayInternal.CopyTo((JournalUserRolelist[])array, index); }
		public IEnumerator GetEnumerator() { return _arrayInternal.GetEnumerator(); }
		public void Add(JournalUserRolelist pJournalUserRolelist) { _arrayInternal.Add(pJournalUserRolelist); }
		public void Clear() { _arrayInternal.Clear(); }
		public IList<JournalUserRolelist> GetList() { return _arrayInternal; }
	 }
	
	#endregion
}
