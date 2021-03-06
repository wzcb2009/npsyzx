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
	/// IActiveCase interface for NHibernate mapped table 'Active_Case'.
	/// </summary>
	public interface IActiveCase
	{
		#region Public Properties
		
		int Caseid
		{
			get ;
			set ;
			  
		}
		
		string Casename
		{
			get ;
			set ;
			  
		}
		
		int Parentid
		{
			get ;
			set ;
			  
		}
		
		int Pindex
		{
			get ;
			set ;
			  
		}
		
		string Bz
		{
			get ;
			set ;
			  
		}
		
		int Roleid
		{
			get ;
			set ;
			  
		}
		
		int Groupid
		{
			get ;
			set ;
			  
		}
		
		bool Grouped
		{
			get ;
			set ;
			  
		}
		
		bool IsDeleted { get; set; }
		bool IsChanged { get; set; }
		
		#endregion 
	}

	/// <summary>
	/// ActiveCase object for NHibernate mapped table 'Active_Case'.
	/// </summary>
	[Serializable]
	public class ActiveCase : IActiveCase
	{
		#region Member Variables

		protected int caseid;
		protected string casename;
		protected int parentid;
		protected int pindex;
		protected string bz;
		protected int roleid;
		protected int groupid;
		protected bool grouped;
		protected bool _bIsDeleted;
		protected bool _bIsChanged;
		#endregion
		
		#region Constructors
		public ActiveCase() {}
		
		public ActiveCase(int pCaseid, string pCasename, int pParentid, int pPindex, string pBz, int pRoleid, int pGroupid, bool pGrouped)
		{
			this.caseid = pCaseid; 
			this.casename = pCasename; 
			this.parentid = pParentid; 
			this.pindex = pPindex; 
			this.bz = pBz; 
			this.roleid = pRoleid; 
			this.groupid = pGroupid; 
			this.grouped = pGrouped; 
		}
		
		public ActiveCase(int pCaseid)
		{
			this.caseid = pCaseid; 
		}
		
		#endregion
		
		#region Public Properties
		
		public int Caseid
		{
			get { return caseid; }
			set { _bIsChanged |= (caseid != value); caseid = value; }
			
		}
		
		public string Casename
		{
			get { return casename; }
			set 
			{
			  if (value != null && value.Length > 50)
			    throw new ArgumentOutOfRangeException("Casename", "Casename value, cannot contain more than 50 characters");
			  _bIsChanged |= (casename != value); 
			  casename = value; 
			}
			
		}
		
		public int Parentid
		{
			get { return parentid; }
			set { _bIsChanged |= (parentid != value); parentid = value; }
			
		}
		
		public int Pindex
		{
			get { return pindex; }
			set { _bIsChanged |= (pindex != value); pindex = value; }
			
		}
		
		public string Bz
		{
			get { return bz; }
			set 
			{
			  if (value != null && value.Length > 250)
			    throw new ArgumentOutOfRangeException("Bz", "Bz value, cannot contain more than 250 characters");
			  _bIsChanged |= (bz != value); 
			  bz = value; 
			}
			
		}
		
		public int Roleid
		{
			get { return roleid; }
			set { _bIsChanged |= (roleid != value); roleid = value; }
			
		}
		
		public int Groupid
		{
			get { return groupid; }
			set { _bIsChanged |= (groupid != value); groupid = value; }
			
		}
		
		public bool Grouped
		{
			get { return grouped; }
			set { _bIsChanged |= (grouped != value); grouped = value; }
			
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
	
	#region Custom ICollection interface for ActiveCase 

	
	public interface IActiveCaseCollection : ICollection
	{
		ActiveCase this[int index]{	get; set; }
		void Add(ActiveCase pActiveCase);
		void Clear();
	}
	
	[Serializable]
	public class ActiveCaseCollection : IActiveCaseCollection
	{
		private IList<ActiveCase> _arrayInternal;

		public ActiveCaseCollection()
		{
			_arrayInternal = new List<ActiveCase>();
		}
		
		public ActiveCaseCollection( IList<ActiveCase> pSource )
		{
			_arrayInternal = pSource;
			if(_arrayInternal == null)
			{
				_arrayInternal = new List<ActiveCase>();
			}
		}

		public ActiveCase this[int index]
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
		public void CopyTo(Array array, int index){ _arrayInternal.CopyTo((ActiveCase[])array, index); }
		public IEnumerator GetEnumerator() { return _arrayInternal.GetEnumerator(); }
		public void Add(ActiveCase pActiveCase) { _arrayInternal.Add(pActiveCase); }
		public void Clear() { _arrayInternal.Clear(); }
		public IList<ActiveCase> GetList() { return _arrayInternal; }
	 }
	
	#endregion
}
