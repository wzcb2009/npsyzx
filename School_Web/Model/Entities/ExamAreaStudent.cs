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
	/// IExamAreaStudent interface for NHibernate mapped table 'Exam_Area_Student'.
	/// </summary>
	public interface IExamAreaStudent
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
		
		int ExamAreaId
		{
			get ;
			set ;
			  
		}
		
		long StudentId
		{
			get ;
			set ;
			  
		}
		
		int SortNum
		{
			get ;
			set ;
			  
		}
		
		bool IsDeleted { get; set; }
		bool IsChanged { get; set; }
		
		#endregion 
	}

	/// <summary>
	/// ExamAreaStudent object for NHibernate mapped table 'Exam_Area_Student'.
	/// </summary>
	[Serializable]
	public class ExamAreaStudent : IExamAreaStudent
	{
		#region Member Variables

		protected long id;
		protected int examid;
		protected int examareaid;
		protected long studentid;
		protected int sortnum;
		protected bool _bIsDeleted;
		protected bool _bIsChanged;
		#endregion
		
		#region Constructors
		public ExamAreaStudent() {}
		
		public ExamAreaStudent(int pExamid, int pExamAreaId, long pStudentId, int pSortNum)
		{
			this.examid = pExamid; 
			this.examareaid = pExamAreaId; 
			this.studentid = pStudentId; 
			this.sortnum = pSortNum; 
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
		
		public int ExamAreaId
		{
			get { return examareaid; }
			set { _bIsChanged |= (examareaid != value); examareaid = value; }
			
		}
		
		public long StudentId
		{
			get { return studentid; }
			set { _bIsChanged |= (studentid != value); studentid = value; }
			
		}
		
		public int SortNum
		{
			get { return sortnum; }
			set { _bIsChanged |= (sortnum != value); sortnum = value; }
			
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
	
	#region Custom ICollection interface for ExamAreaStudent 

	
	public interface IExamAreaStudentCollection : ICollection
	{
		ExamAreaStudent this[int index]{	get; set; }
		void Add(ExamAreaStudent pExamAreaStudent);
		void Clear();
	}
	
	[Serializable]
	public class ExamAreaStudentCollection : IExamAreaStudentCollection
	{
		private IList<ExamAreaStudent> _arrayInternal;

		public ExamAreaStudentCollection()
		{
			_arrayInternal = new List<ExamAreaStudent>();
		}
		
		public ExamAreaStudentCollection( IList<ExamAreaStudent> pSource )
		{
			_arrayInternal = pSource;
			if(_arrayInternal == null)
			{
				_arrayInternal = new List<ExamAreaStudent>();
			}
		}

		public ExamAreaStudent this[int index]
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
		public void CopyTo(Array array, int index){ _arrayInternal.CopyTo((ExamAreaStudent[])array, index); }
		public IEnumerator GetEnumerator() { return _arrayInternal.GetEnumerator(); }
		public void Add(ExamAreaStudent pExamAreaStudent) { _arrayInternal.Add(pExamAreaStudent); }
		public void Clear() { _arrayInternal.Clear(); }
		public IList<ExamAreaStudent> GetList() { return _arrayInternal; }
	 }
	
	#endregion
}
