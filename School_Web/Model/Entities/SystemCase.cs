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
	/// ISystemCase interface for NHibernate mapped table 'SystemCase'.
	/// </summary>
	public interface ISystemCase
	{
		#region Public Properties
		
		int Id
		{
			get ;
			set ;
			  
		}
		
		int Pindex
		{
			get ;
			set ;
			  
		}
		
		int ParentId
		{
			get ;
			set ;
			  
		}
		
		int CaseId
		{
			get ;
			set ;
			  
		}
		
		string CaseName
		{
			get ;
			set ;
			  
		}
		
		DateTime PubDate
		{
			get ;
			set ;
			  
		}
		
		int UserId
		{
			get ;
			set ;
			  
		}
		
		bool IsShowFlag
		{
			get ;
			set ;
			  
		}
		
		string CaseData
		{
			get ;
			set ;
			  
		}
		
		int CaseDataTypeid
		{
			get ;
			set ;
			  
		}
		
		int TypeId
		{
			get ;
			set ;
			  
		}
		
		int UnitId
		{
			get ;
			set ;
			  
		}
		
		bool IsDeleted { get; set; }
		bool IsChanged { get; set; }
		
		#endregion 
	}

	/// <summary>
	/// SystemCase object for NHibernate mapped table 'SystemCase'.
	/// </summary>
	[Serializable]
	public class SystemCase : ISystemCase
	{
		#region Member Variables

		protected int id;
		protected int pindex;
		protected int parentid;
		protected int caseid;
		protected string casename;
		protected DateTime pubdate;
		protected int userid;
		protected bool isshowflag;
		protected string casedata;
		protected int casedatatypeid;
		protected int typeid;
		protected int unitid;
		protected bool _bIsDeleted;
		protected bool _bIsChanged;
		#endregion
		
		#region Constructors
		public SystemCase() {}
		
		public SystemCase(int pPindex, int pParentId, int pCaseId, string pCaseName, DateTime pPubDate, int pUserId, bool pIsShowFlag, string pCaseData, int pCaseDataTypeid, int pTypeId, int pUnitId)
		{
			this.pindex = pPindex; 
			this.parentid = pParentId; 
			this.caseid = pCaseId; 
			this.casename = pCaseName; 
			this.pubdate = pPubDate; 
			this.userid = pUserId; 
			this.isshowflag = pIsShowFlag; 
			this.casedata = pCaseData; 
			this.casedatatypeid = pCaseDataTypeid; 
			this.typeid = pTypeId; 
			this.unitid = pUnitId; 
		}
		
		public SystemCase(int pId)
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
		
		public int Pindex
		{
			get { return pindex; }
			set { _bIsChanged |= (pindex != value); pindex = value; }
			
		}
		
		public int ParentId
		{
			get { return parentid; }
			set { _bIsChanged |= (parentid != value); parentid = value; }
			
		}
		
		public int CaseId
		{
			get { return caseid; }
			set { _bIsChanged |= (caseid != value); caseid = value; }
			
		}
		
		public string CaseName
		{
			get { return casename; }
			set 
			{
			  if (value != null && value.Length > 250)
			    throw new ArgumentOutOfRangeException("CaseName", "CaseName value, cannot contain more than 250 characters");
			  _bIsChanged |= (casename != value); 
			  casename = value; 
			}
			
		}
		
		public DateTime PubDate
		{
			get { return pubdate; }
			set { _bIsChanged |= (pubdate != value); pubdate = value; }
			
		}
		
		public int UserId
		{
			get { return userid; }
			set { _bIsChanged |= (userid != value); userid = value; }
			
		}
		
		public bool IsShowFlag
		{
			get { return isshowflag; }
			set { _bIsChanged |= (isshowflag != value); isshowflag = value; }
			
		}
		
		public string CaseData
		{
			get { return casedata; }
			set 
			{
			  if (value != null && value.Length > 4000)
			    throw new ArgumentOutOfRangeException("CaseData", "CaseData value, cannot contain more than 4000 characters");
			  _bIsChanged |= (casedata != value); 
			  casedata = value; 
			}
			
		}
		
		public int CaseDataTypeid
		{
			get { return casedatatypeid; }
			set { _bIsChanged |= (casedatatypeid != value); casedatatypeid = value; }
			
		}
		
		public int TypeId
		{
			get { return typeid; }
			set { _bIsChanged |= (typeid != value); typeid = value; }
			
		}
		
		public int UnitId
		{
			get { return unitid; }
			set { _bIsChanged |= (unitid != value); unitid = value; }
			
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
	
	#region Custom ICollection interface for SystemCase 

	
	public interface ISystemCaseCollection : ICollection
	{
		SystemCase this[int index]{	get; set; }
		void Add(SystemCase pSystemCase);
		void Clear();
	}
	
	[Serializable]
	public class SystemCaseCollection : ISystemCaseCollection
	{
		private IList<SystemCase> _arrayInternal;

		public SystemCaseCollection()
		{
			_arrayInternal = new List<SystemCase>();
		}
		
		public SystemCaseCollection( IList<SystemCase> pSource )
		{
			_arrayInternal = pSource;
			if(_arrayInternal == null)
			{
				_arrayInternal = new List<SystemCase>();
			}
		}

		public SystemCase this[int index]
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
		public void CopyTo(Array array, int index){ _arrayInternal.CopyTo((SystemCase[])array, index); }
		public IEnumerator GetEnumerator() { return _arrayInternal.GetEnumerator(); }
		public void Add(SystemCase pSystemCase) { _arrayInternal.Add(pSystemCase); }
		public void Clear() { _arrayInternal.Clear(); }
		public IList<SystemCase> GetList() { return _arrayInternal; }
	 }
	
	#endregion
}
