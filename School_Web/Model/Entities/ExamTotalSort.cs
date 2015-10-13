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
	/// IExamTotalSort interface for NHibernate mapped table 'Exam_total_sort'.
	/// </summary>
	public interface IExamTotalSort
	{
		#region Public Properties
		
		long Id
		{
			get ;
			set ;
			  
		}
		
		int Examid
		{
			get ;
			set ;
			  
		}
		
		int Studentid
		{
			get ;
			set ;
			  
		}
		
		double Total
		{
			get ;
			set ;
			  
		}
		
		double Qzf
		{
			get ;
			set ;
			  
		}
		
		bool IsDeleted { get; set; }
		bool IsChanged { get; set; }
		
		#endregion 
	}

	/// <summary>
	/// ExamTotalSort object for NHibernate mapped table 'Exam_total_sort'.
	/// </summary>
	[Serializable]
	public class ExamTotalSort : IExamTotalSort
	{
		#region Member Variables

		protected long id;
		protected int examid;
		protected int studentid;
		protected double total;
		protected double qzf;
		protected bool _bIsDeleted;
		protected bool _bIsChanged;
		#endregion
		
		#region Constructors
		public ExamTotalSort() {}
		
		public ExamTotalSort(int pExamid, int pStudentid, double pTotal, double pQzf)
		{
			this.examid = pExamid; 
			this.studentid = pStudentid; 
			this.total = pTotal; 
			this.qzf = pQzf; 
		}
		
		#endregion
		
		#region Public Properties
		
		public long Id
		{
			get { return id; }
			set { _bIsChanged |= (id != value); id = value; }
			
		}
		
		public int Examid
		{
			get { return examid; }
			set { _bIsChanged |= (examid != value); examid = value; }
			
		}
		
		public int Studentid
		{
			get { return studentid; }
			set { _bIsChanged |= (studentid != value); studentid = value; }
			
		}
		
		public double Total
		{
			get { return total; }
			set { _bIsChanged |= (total != value); total = value; }
			
		}
		
		public double Qzf
		{
			get { return qzf; }
			set { _bIsChanged |= (qzf != value); qzf = value; }
			
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
	
	#region Custom ICollection interface for ExamTotalSort 

	
	public interface IExamTotalSortCollection : ICollection
	{
		ExamTotalSort this[int index]{	get; set; }
		void Add(ExamTotalSort pExamTotalSort);
		void Clear();
	}
	
	[Serializable]
	public class ExamTotalSortCollection : IExamTotalSortCollection
	{
		private IList<ExamTotalSort> _arrayInternal;

		public ExamTotalSortCollection()
		{
			_arrayInternal = new List<ExamTotalSort>();
		}
		
		public ExamTotalSortCollection( IList<ExamTotalSort> pSource )
		{
			_arrayInternal = pSource;
			if(_arrayInternal == null)
			{
				_arrayInternal = new List<ExamTotalSort>();
			}
		}

		public ExamTotalSort this[int index]
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
		public void CopyTo(Array array, int index){ _arrayInternal.CopyTo((ExamTotalSort[])array, index); }
		public IEnumerator GetEnumerator() { return _arrayInternal.GetEnumerator(); }
		public void Add(ExamTotalSort pExamTotalSort) { _arrayInternal.Add(pExamTotalSort); }
		public void Clear() { _arrayInternal.Clear(); }
		public IList<ExamTotalSort> GetList() { return _arrayInternal; }
	 }
	
	#endregion
}
