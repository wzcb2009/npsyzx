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
	/// IExamMarks interface for NHibernate mapped table 'Exam_Marks'.
	/// </summary>
	public interface IExamMarks
	{
		#region Public Properties
		
		long Marksid
		{
			get ;
			set ;
			  
		}
		
		int ExamClassSubjectId
		{
			get ;
			set ;
			  
		}
		
		long Studentid
		{
			get ;
			set ;
			  
		}
		
		double Cent
		{
			get ;
			set ;
			  
		}
		
		bool IsDeleted { get; set; }
		bool IsChanged { get; set; }
		
		#endregion 
	}

	/// <summary>
	/// ExamMarks object for NHibernate mapped table 'Exam_Marks'.
	/// </summary>
	[Serializable]
	public class ExamMarks : IExamMarks
	{
		#region Member Variables

		protected long marksid;
		protected int examclasssubjectid;
		protected long studentid;
		protected double cent;
		protected bool _bIsDeleted;
		protected bool _bIsChanged;
		#endregion
		
		#region Constructors
		public ExamMarks() {}
		
		public ExamMarks(int pExamClassSubjectId, long pStudentid, double pCent)
		{
			this.examclasssubjectid = pExamClassSubjectId; 
			this.studentid = pStudentid; 
			this.cent = pCent; 
		}
		
		public ExamMarks(long pStudentid)
		{
			this.studentid = pStudentid; 
		}
		
		#endregion
		
		#region Public Properties
		
		public long Marksid
		{
			get { return marksid; }
			set { _bIsChanged |= (marksid != value); marksid = value; }
			
		}
		
		public int ExamClassSubjectId
		{
			get { return examclasssubjectid; }
			set { _bIsChanged |= (examclasssubjectid != value); examclasssubjectid = value; }
			
		}
		
		public long Studentid
		{
			get { return studentid; }
			set { _bIsChanged |= (studentid != value); studentid = value; }
			
		}
		
		public double Cent
		{
			get { return cent; }
			set { _bIsChanged |= (cent != value); cent = value; }
			
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
	
	#region Custom ICollection interface for ExamMarks 

	
	public interface IExamMarksCollection : ICollection
	{
		ExamMarks this[int index]{	get; set; }
		void Add(ExamMarks pExamMarks);
		void Clear();
	}
	
	[Serializable]
	public class ExamMarksCollection : IExamMarksCollection
	{
		private IList<ExamMarks> _arrayInternal;

		public ExamMarksCollection()
		{
			_arrayInternal = new List<ExamMarks>();
		}
		
		public ExamMarksCollection( IList<ExamMarks> pSource )
		{
			_arrayInternal = pSource;
			if(_arrayInternal == null)
			{
				_arrayInternal = new List<ExamMarks>();
			}
		}

		public ExamMarks this[int index]
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
		public void CopyTo(Array array, int index){ _arrayInternal.CopyTo((ExamMarks[])array, index); }
		public IEnumerator GetEnumerator() { return _arrayInternal.GetEnumerator(); }
		public void Add(ExamMarks pExamMarks) { _arrayInternal.Add(pExamMarks); }
		public void Clear() { _arrayInternal.Clear(); }
		public IList<ExamMarks> GetList() { return _arrayInternal; }
	 }
	
	#endregion
}
