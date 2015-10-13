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
	/// IActiveCaseSet interface for NHibernate mapped table 'ActiveCaseSet'.
	/// </summary>
	public interface IActiveCaseSet
	{
		#region Public Properties
		
		int Id
		{
			get ;
			set ;
			  
		}
		
		int Activeid
		{
			get ;
			set ;
			  
		}
		
		int GradeId
		{
			get ;
			set ;
			  
		}
		
		int ClassId
		{
			get ;
			set ;
			  
		}
		
		int CaseId
		{
			get ;
			set ;
			  
		}
		
		int Cent
		{
			get ;
			set ;
			  
		}
		
		int PercentNum
		{
			get ;
			set ;
			  
		}
		
		bool TotalFlag
		{
			get ;
			set ;
			  
		}
		
		bool IsDeleted { get; set; }
		bool IsChanged { get; set; }
		
		#endregion 
	}

	/// <summary>
	/// ActiveCaseSet object for NHibernate mapped table 'ActiveCaseSet'.
	/// </summary>
	[Serializable]
	public class ActiveCaseSet : IActiveCaseSet
	{
		#region Member Variables

		protected int id;
		protected int activeid;
		protected int gradeid;
		protected int classid;
		protected int caseid;
		protected int cent;
		protected int percentnum;
		protected bool totalflag;
		protected bool _bIsDeleted;
		protected bool _bIsChanged;
		#endregion
		
		#region Constructors
		public ActiveCaseSet() {}
		
		public ActiveCaseSet(int pActiveid, int pGradeId, int pClassId, int pCaseId, int pCent, int pPercentNum, bool pTotalFlag)
		{
			this.activeid = pActiveid; 
			this.gradeid = pGradeId; 
			this.classid = pClassId; 
			this.caseid = pCaseId; 
			this.cent = pCent; 
			this.percentnum = pPercentNum; 
			this.totalflag = pTotalFlag; 
		}
		
		public ActiveCaseSet(int pId)
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
		
		public int Activeid
		{
			get { return activeid; }
			set { _bIsChanged |= (activeid != value); activeid = value; }
			
		}
		
		public int GradeId
		{
			get { return gradeid; }
			set { _bIsChanged |= (gradeid != value); gradeid = value; }
			
		}
		
		public int ClassId
		{
			get { return classid; }
			set { _bIsChanged |= (classid != value); classid = value; }
			
		}
		
		public int CaseId
		{
			get { return caseid; }
			set { _bIsChanged |= (caseid != value); caseid = value; }
			
		}
		
		public int Cent
		{
			get { return cent; }
			set { _bIsChanged |= (cent != value); cent = value; }
			
		}
		
		public int PercentNum
		{
			get { return percentnum; }
			set { _bIsChanged |= (percentnum != value); percentnum = value; }
			
		}
		
		public bool TotalFlag
		{
			get { return totalflag; }
			set { _bIsChanged |= (totalflag != value); totalflag = value; }
			
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
	
	#region Custom ICollection interface for ActiveCaseSet 

	
	public interface IActiveCaseSetCollection : ICollection
	{
		ActiveCaseSet this[int index]{	get; set; }
		void Add(ActiveCaseSet pActiveCaseSet);
		void Clear();
	}
	
	[Serializable]
	public class ActiveCaseSetCollection : IActiveCaseSetCollection
	{
		private IList<ActiveCaseSet> _arrayInternal;

		public ActiveCaseSetCollection()
		{
			_arrayInternal = new List<ActiveCaseSet>();
		}
		
		public ActiveCaseSetCollection( IList<ActiveCaseSet> pSource )
		{
			_arrayInternal = pSource;
			if(_arrayInternal == null)
			{
				_arrayInternal = new List<ActiveCaseSet>();
			}
		}

		public ActiveCaseSet this[int index]
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
		public void CopyTo(Array array, int index){ _arrayInternal.CopyTo((ActiveCaseSet[])array, index); }
		public IEnumerator GetEnumerator() { return _arrayInternal.GetEnumerator(); }
		public void Add(ActiveCaseSet pActiveCaseSet) { _arrayInternal.Add(pActiveCaseSet); }
		public void Clear() { _arrayInternal.Clear(); }
		public IList<ActiveCaseSet> GetList() { return _arrayInternal; }
	 }
	
	#endregion
}
