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
	/// IExamCompareExamList interface for NHibernate mapped table 'Exam_CompareExam_list'.
	/// </summary>
	public interface IExamCompareExamList
	{
		#region Public Properties
		
		int Id
		{
			get ;
			set ;
			  
		}
		
		int Examid
		{
			get ;
			set ;
			  
		}
		
		int Gradeid
		{
			get ;
			set ;
			  
		}
		
		int Preexamid
		{
			get ;
			set ;
			  
		}
		
		bool IsDeleted { get; set; }
		bool IsChanged { get; set; }
		
		#endregion 
	}

	/// <summary>
	/// ExamCompareExamList object for NHibernate mapped table 'Exam_CompareExam_list'.
	/// </summary>
	[Serializable]
	public class ExamCompareExamList : IExamCompareExamList
	{
		#region Member Variables

		protected int id;
		protected int examid;
		protected int gradeid;
		protected int preexamid;
		protected bool _bIsDeleted;
		protected bool _bIsChanged;
		#endregion
		
		#region Constructors
		public ExamCompareExamList() {}
		
		public ExamCompareExamList(int pExamid, int pGradeid, int pPreexamid)
		{
			this.examid = pExamid; 
			this.gradeid = pGradeid; 
			this.preexamid = pPreexamid; 
		}
		
		public ExamCompareExamList(int pId)
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
		
		public int Examid
		{
			get { return examid; }
			set { _bIsChanged |= (examid != value); examid = value; }
			
		}
		
		public int Gradeid
		{
			get { return gradeid; }
			set { _bIsChanged |= (gradeid != value); gradeid = value; }
			
		}
		
		public int Preexamid
		{
			get { return preexamid; }
			set { _bIsChanged |= (preexamid != value); preexamid = value; }
			
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
	
	#region Custom ICollection interface for ExamCompareExamList 

	
	public interface IExamCompareExamListCollection : ICollection
	{
		ExamCompareExamList this[int index]{	get; set; }
		void Add(ExamCompareExamList pExamCompareExamList);
		void Clear();
	}
	
	[Serializable]
	public class ExamCompareExamListCollection : IExamCompareExamListCollection
	{
		private IList<ExamCompareExamList> _arrayInternal;

		public ExamCompareExamListCollection()
		{
			_arrayInternal = new List<ExamCompareExamList>();
		}
		
		public ExamCompareExamListCollection( IList<ExamCompareExamList> pSource )
		{
			_arrayInternal = pSource;
			if(_arrayInternal == null)
			{
				_arrayInternal = new List<ExamCompareExamList>();
			}
		}

		public ExamCompareExamList this[int index]
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
		public void CopyTo(Array array, int index){ _arrayInternal.CopyTo((ExamCompareExamList[])array, index); }
		public IEnumerator GetEnumerator() { return _arrayInternal.GetEnumerator(); }
		public void Add(ExamCompareExamList pExamCompareExamList) { _arrayInternal.Add(pExamCompareExamList); }
		public void Clear() { _arrayInternal.Clear(); }
		public IList<ExamCompareExamList> GetList() { return _arrayInternal; }
	 }
	
	#endregion
}
