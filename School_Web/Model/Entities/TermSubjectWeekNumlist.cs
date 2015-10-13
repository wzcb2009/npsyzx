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
	/// ITermSubjectWeekNumlist interface for NHibernate mapped table 'Term_Subject_WeekNumlist'.
	/// </summary>
	public interface ITermSubjectWeekNumlist
	{
		#region Public Properties
		
		int Id
		{
			get ;
			set ;
			  
		}
		
		int Termid
		{
			get ;
			set ;
			  
		}
		
		int Gradeid
		{
			get ;
			set ;
			  
		}
		
		int Subjectid
		{
			get ;
			set ;
			  
		}
		
		int WeekNum
		{
			get ;
			set ;
			  
		}
		
		bool IsDeleted { get; set; }
		bool IsChanged { get; set; }
		
		#endregion 
	}

	/// <summary>
	/// TermSubjectWeekNumlist object for NHibernate mapped table 'Term_Subject_WeekNumlist'.
	/// </summary>
	[Serializable]
	public class TermSubjectWeekNumlist : ITermSubjectWeekNumlist
	{
		#region Member Variables

		protected int id;
		protected int termid;
		protected int gradeid;
		protected int subjectid;
		protected int weeknum;
		protected bool _bIsDeleted;
		protected bool _bIsChanged;
		#endregion
		
		#region Constructors
		public TermSubjectWeekNumlist() {}
		
		public TermSubjectWeekNumlist(int pTermid, int pGradeid, int pSubjectid, int pWeekNum)
		{
			this.termid = pTermid; 
			this.gradeid = pGradeid; 
			this.subjectid = pSubjectid; 
			this.weeknum = pWeekNum; 
		}
		
		public TermSubjectWeekNumlist(int pId)
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
		
		public int Termid
		{
			get { return termid; }
			set { _bIsChanged |= (termid != value); termid = value; }
			
		}
		
		public int Gradeid
		{
			get { return gradeid; }
			set { _bIsChanged |= (gradeid != value); gradeid = value; }
			
		}
		
		public int Subjectid
		{
			get { return subjectid; }
			set { _bIsChanged |= (subjectid != value); subjectid = value; }
			
		}
		
		public int WeekNum
		{
			get { return weeknum; }
			set { _bIsChanged |= (weeknum != value); weeknum = value; }
			
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
	
	#region Custom ICollection interface for TermSubjectWeekNumlist 

	
	public interface ITermSubjectWeekNumlistCollection : ICollection
	{
		TermSubjectWeekNumlist this[int index]{	get; set; }
		void Add(TermSubjectWeekNumlist pTermSubjectWeekNumlist);
		void Clear();
	}
	
	[Serializable]
	public class TermSubjectWeekNumlistCollection : ITermSubjectWeekNumlistCollection
	{
		private IList<TermSubjectWeekNumlist> _arrayInternal;

		public TermSubjectWeekNumlistCollection()
		{
			_arrayInternal = new List<TermSubjectWeekNumlist>();
		}
		
		public TermSubjectWeekNumlistCollection( IList<TermSubjectWeekNumlist> pSource )
		{
			_arrayInternal = pSource;
			if(_arrayInternal == null)
			{
				_arrayInternal = new List<TermSubjectWeekNumlist>();
			}
		}

		public TermSubjectWeekNumlist this[int index]
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
		public void CopyTo(Array array, int index){ _arrayInternal.CopyTo((TermSubjectWeekNumlist[])array, index); }
		public IEnumerator GetEnumerator() { return _arrayInternal.GetEnumerator(); }
		public void Add(TermSubjectWeekNumlist pTermSubjectWeekNumlist) { _arrayInternal.Add(pTermSubjectWeekNumlist); }
		public void Clear() { _arrayInternal.Clear(); }
		public IList<TermSubjectWeekNumlist> GetList() { return _arrayInternal; }
	 }
	
	#endregion
}
