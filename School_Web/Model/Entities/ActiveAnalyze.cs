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
	/// IActiveAnalyze interface for NHibernate mapped table 'ActiveAnalyze'.
	/// </summary>
	public interface IActiveAnalyze
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
		
		int TypeId
		{
			get ;
			set ;
			  
		}
		
		double Data
		{
			get ;
			set ;
			  
		}
		
		int SortPindex
		{
			get ;
			set ;
			  
		}
		
		bool IsDeleted { get; set; }
		bool IsChanged { get; set; }
		
		#endregion 
	}

	/// <summary>
	/// ActiveAnalyze object for NHibernate mapped table 'ActiveAnalyze'.
	/// </summary>
	[Serializable]
	public class ActiveAnalyze : IActiveAnalyze
	{
		#region Member Variables

		protected int id;
		protected int activeid;
		protected int gradeid;
		protected int classid;
		protected int caseid;
		protected int typeid;
		protected double data;
		protected int sortpindex;
		protected bool _bIsDeleted;
		protected bool _bIsChanged;
		#endregion
		
		#region Constructors
		public ActiveAnalyze() {}
		
		public ActiveAnalyze(int pActiveId, int pGradeId, int pClassId, int pCaseId, int pTypeId, double pData, int pSortPindex)
		{
			this.activeid = pActiveId; 
			this.gradeid = pGradeId; 
			this.classid = pClassId; 
			this.caseid = pCaseId; 
			this.typeid = pTypeId; 
			this.data = pData; 
			this.sortpindex = pSortPindex; 
		}
		
		public ActiveAnalyze(int pId)
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
		
		public int TypeId
		{
			get { return typeid; }
			set { _bIsChanged |= (typeid != value); typeid = value; }
			
		}
		
		public double Data
		{
			get { return data; }
			set { _bIsChanged |= (data != value); data = value; }
			
		}
		
		public int SortPindex
		{
			get { return sortpindex; }
			set { _bIsChanged |= (sortpindex != value); sortpindex = value; }
			
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
	
	#region Custom ICollection interface for ActiveAnalyze 

	
	public interface IActiveAnalyzeCollection : ICollection
	{
		ActiveAnalyze this[int index]{	get; set; }
		void Add(ActiveAnalyze pActiveAnalyze);
		void Clear();
	}
	
	[Serializable]
	public class ActiveAnalyzeCollection : IActiveAnalyzeCollection
	{
		private IList<ActiveAnalyze> _arrayInternal;

		public ActiveAnalyzeCollection()
		{
			_arrayInternal = new List<ActiveAnalyze>();
		}
		
		public ActiveAnalyzeCollection( IList<ActiveAnalyze> pSource )
		{
			_arrayInternal = pSource;
			if(_arrayInternal == null)
			{
				_arrayInternal = new List<ActiveAnalyze>();
			}
		}

		public ActiveAnalyze this[int index]
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
		public void CopyTo(Array array, int index){ _arrayInternal.CopyTo((ActiveAnalyze[])array, index); }
		public IEnumerator GetEnumerator() { return _arrayInternal.GetEnumerator(); }
		public void Add(ActiveAnalyze pActiveAnalyze) { _arrayInternal.Add(pActiveAnalyze); }
		public void Clear() { _arrayInternal.Clear(); }
		public IList<ActiveAnalyze> GetList() { return _arrayInternal; }
	 }
	
	#endregion
}
