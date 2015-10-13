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
	/// IExamClassSubjectRight interface for NHibernate mapped table 'exam_class_subject_right'.
	/// </summary>
	public interface IExamClassSubjectRight
	{
		#region Public Properties
		
		int ExamClassSubjectId
		{
			get ;
			set ;
			  
		}
		
		int TypeTeacherid
		{
			get ;
			set ;
			  
		}
		
		bool IsDeleted { get; set; }
		bool IsChanged { get; set; }
		
		#endregion 
	}

	/// <summary>
	/// ExamClassSubjectRight object for NHibernate mapped table 'exam_class_subject_right'.
	/// </summary>
	[Serializable]
	public class ExamClassSubjectRight : IExamClassSubjectRight
	{
		#region Member Variables

		protected int examclasssubjectid;
		protected int typeteacherid;
		protected bool _bIsDeleted;
		protected bool _bIsChanged;
		#endregion
		
		#region Constructors
		public ExamClassSubjectRight() {}
		
		public ExamClassSubjectRight(int pExamClassSubjectId, int pTypeTeacherid)
		{
			this.examclasssubjectid = pExamClassSubjectId; 
			this.typeteacherid = pTypeTeacherid; 
		}
		
		#endregion
		
		#region Public Properties
		
		public int ExamClassSubjectId
		{
			get { return examclasssubjectid; }
			set { _bIsChanged |= (examclasssubjectid != value); examclasssubjectid = value; }
			
		}
		
		public int TypeTeacherid
		{
			get { return typeteacherid; }
			set { _bIsChanged |= (typeteacherid != value); typeteacherid = value; }
			
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
	
	#region Custom ICollection interface for ExamClassSubjectRight 

	
	public interface IExamClassSubjectRightCollection : ICollection
	{
		ExamClassSubjectRight this[int index]{	get; set; }
		void Add(ExamClassSubjectRight pExamClassSubjectRight);
		void Clear();
	}
	
	[Serializable]
	public class ExamClassSubjectRightCollection : IExamClassSubjectRightCollection
	{
		private IList<ExamClassSubjectRight> _arrayInternal;

		public ExamClassSubjectRightCollection()
		{
			_arrayInternal = new List<ExamClassSubjectRight>();
		}
		
		public ExamClassSubjectRightCollection( IList<ExamClassSubjectRight> pSource )
		{
			_arrayInternal = pSource;
			if(_arrayInternal == null)
			{
				_arrayInternal = new List<ExamClassSubjectRight>();
			}
		}

		public ExamClassSubjectRight this[int index]
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
		public void CopyTo(Array array, int index){ _arrayInternal.CopyTo((ExamClassSubjectRight[])array, index); }
		public IEnumerator GetEnumerator() { return _arrayInternal.GetEnumerator(); }
		public void Add(ExamClassSubjectRight pExamClassSubjectRight) { _arrayInternal.Add(pExamClassSubjectRight); }
		public void Clear() { _arrayInternal.Clear(); }
		public IList<ExamClassSubjectRight> GetList() { return _arrayInternal; }
	 }
	
	#endregion
}
