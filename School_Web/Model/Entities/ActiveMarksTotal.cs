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
	/// IActiveMarksTotal interface for NHibernate mapped table 'ActiveMarksTotal'.
	/// </summary>
	public interface IActiveMarksTotal
	{
		#region Public Properties
		
		int Id
		{
			get ;
			set ;
			  
		}
		
		int ActiveId
		{
			get ;
			set ;
			  
		}
		
		int UserId
		{
			get ;
			set ;
			  
		}
		
		int ParentCaseId
		{
			get ;
			set ;
			  
		}
		
		int CaseId
		{
			get ;
			set ;
			  
		}
		
		double Total
		{
			get ;
			set ;
			  
		}
		
		int ClassSortIndex
		{
			get ;
			set ;
			  
		}
		
		int GradeSortIndex
		{
			get ;
			set ;
			  
		}
		
		bool IsDeleted { get; set; }
		bool IsChanged { get; set; }
		
		#endregion 
	}

	/// <summary>
	/// ActiveMarksTotal object for NHibernate mapped table 'ActiveMarksTotal'.
	/// </summary>
	[Serializable]
	public class ActiveMarksTotal : IActiveMarksTotal
	{
		#region Member Variables

		protected int id;
		protected int activeid;
		protected int userid;
		protected int parentcaseid;
		protected int caseid;
		protected double total;
		protected int classsortindex;
		protected int gradesortindex;
		protected bool _bIsDeleted;
		protected bool _bIsChanged;
		#endregion
		
		#region Constructors
		public ActiveMarksTotal() {}
		
		public ActiveMarksTotal(int pActiveId, int pUserId, int pParentCaseId, int pCaseId, double pTotal, int pClassSortIndex, int pGradeSortIndex)
		{
			this.activeid = pActiveId; 
			this.userid = pUserId; 
			this.parentcaseid = pParentCaseId; 
			this.caseid = pCaseId; 
			this.total = pTotal; 
			this.classsortindex = pClassSortIndex; 
			this.gradesortindex = pGradeSortIndex; 
		}
		
		public ActiveMarksTotal(int pId)
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
		
		public int ActiveId
		{
			get { return activeid; }
			set { _bIsChanged |= (activeid != value); activeid = value; }
			
		}
		
		public int UserId
		{
			get { return userid; }
			set { _bIsChanged |= (userid != value); userid = value; }
			
		}
		
		public int ParentCaseId
		{
			get { return parentcaseid; }
			set { _bIsChanged |= (parentcaseid != value); parentcaseid = value; }
			
		}
		
		public int CaseId
		{
			get { return caseid; }
			set { _bIsChanged |= (caseid != value); caseid = value; }
			
		}
		
		public double Total
		{
			get { return total; }
			set { _bIsChanged |= (total != value); total = value; }
			
		}
		
		public int ClassSortIndex
		{
			get { return classsortindex; }
			set { _bIsChanged |= (classsortindex != value); classsortindex = value; }
			
		}
		
		public int GradeSortIndex
		{
			get { return gradesortindex; }
			set { _bIsChanged |= (gradesortindex != value); gradesortindex = value; }
			
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
	
	#region Custom ICollection interface for ActiveMarksTotal 

	
	public interface IActiveMarksTotalCollection : ICollection
	{
		ActiveMarksTotal this[int index]{	get; set; }
		void Add(ActiveMarksTotal pActiveMarksTotal);
		void Clear();
	}
	
	[Serializable]
	public class ActiveMarksTotalCollection : IActiveMarksTotalCollection
	{
		private IList<ActiveMarksTotal> _arrayInternal;

		public ActiveMarksTotalCollection()
		{
			_arrayInternal = new List<ActiveMarksTotal>();
		}
		
		public ActiveMarksTotalCollection( IList<ActiveMarksTotal> pSource )
		{
			_arrayInternal = pSource;
			if(_arrayInternal == null)
			{
				_arrayInternal = new List<ActiveMarksTotal>();
			}
		}

		public ActiveMarksTotal this[int index]
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
		public void CopyTo(Array array, int index){ _arrayInternal.CopyTo((ActiveMarksTotal[])array, index); }
		public IEnumerator GetEnumerator() { return _arrayInternal.GetEnumerator(); }
		public void Add(ActiveMarksTotal pActiveMarksTotal) { _arrayInternal.Add(pActiveMarksTotal); }
		public void Clear() { _arrayInternal.Clear(); }
		public IList<ActiveMarksTotal> GetList() { return _arrayInternal; }
	 }
	
	#endregion
}
