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
	/// IExamClassSubject interface for NHibernate mapped table 'Exam_class_subject'.
	/// </summary>
	public interface IExamClassSubject
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
		
		int Classid
		{
			get ;
			set ;
			  
		}
		
		int Subjectid
		{
			get ;
			set ;
			  
		}
		
		int Allmarks
		{
			get ;
			set ;
			  
		}
		
		int MarksPercent
		{
			get ;
			set ;
			  
		}
		
		int ChkTeacherid
		{
			get ;
			set ;
			  
		}
		
		int MagTeacherid
		{
			get ;
			set ;
			  
		}
		
		bool Checkflag
		{
			get ;
			set ;
			  
		}
		
		bool Totalflag
		{
			get ;
			set ;
			  
		}
		
		bool IsDeleted { get; set; }
		bool IsChanged { get; set; }
		
		#endregion 
	}

	/// <summary>
	/// ExamClassSubject object for NHibernate mapped table 'Exam_class_subject'.
	/// </summary>
	[Serializable]
	public class ExamClassSubject : IExamClassSubject
	{
		#region Member Variables

		protected int id;
		protected int examid;
		protected int classid;
		protected int subjectid;
		protected int allmarks;
		protected int markspercent;
		protected int chkteacherid;
		protected int magteacherid;
		protected bool checkflag;
		protected bool totalflag;
		protected bool _bIsDeleted;
		protected bool _bIsChanged;
		#endregion
		
		#region Constructors
		public ExamClassSubject() {}
		
		public ExamClassSubject(int pExamid, int pClassid, int pSubjectid, int pAllmarks, int pMarksPercent, int pChkTeacherid, int pMagTeacherid, bool pCheckflag, bool pTotalflag)
		{
			this.examid = pExamid; 
			this.classid = pClassid; 
			this.subjectid = pSubjectid; 
			this.allmarks = pAllmarks; 
			this.markspercent = pMarksPercent; 
			this.chkteacherid = pChkTeacherid; 
			this.magteacherid = pMagTeacherid; 
			this.checkflag = pCheckflag; 
			this.totalflag = pTotalflag; 
		}
		
		public ExamClassSubject(int pId)
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
		
		public int Classid
		{
			get { return classid; }
			set { _bIsChanged |= (classid != value); classid = value; }
			
		}
		
		public int Subjectid
		{
			get { return subjectid; }
			set { _bIsChanged |= (subjectid != value); subjectid = value; }
			
		}
		
		public int Allmarks
		{
			get { return allmarks; }
			set { _bIsChanged |= (allmarks != value); allmarks = value; }
			
		}
		
		public int MarksPercent
		{
			get { return markspercent; }
			set { _bIsChanged |= (markspercent != value); markspercent = value; }
			
		}
		
		public int ChkTeacherid
		{
			get { return chkteacherid; }
			set { _bIsChanged |= (chkteacherid != value); chkteacherid = value; }
			
		}
		
		public int MagTeacherid
		{
			get { return magteacherid; }
			set { _bIsChanged |= (magteacherid != value); magteacherid = value; }
			
		}
		
		public bool Checkflag
		{
			get { return checkflag; }
			set { _bIsChanged |= (checkflag != value); checkflag = value; }
			
		}
		
		public bool Totalflag
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
	
	#region Custom ICollection interface for ExamClassSubject 

	
	public interface IExamClassSubjectCollection : ICollection
	{
		ExamClassSubject this[int index]{	get; set; }
		void Add(ExamClassSubject pExamClassSubject);
		void Clear();
	}
	
	[Serializable]
	public class ExamClassSubjectCollection : IExamClassSubjectCollection
	{
		private IList<ExamClassSubject> _arrayInternal;

		public ExamClassSubjectCollection()
		{
			_arrayInternal = new List<ExamClassSubject>();
		}
		
		public ExamClassSubjectCollection( IList<ExamClassSubject> pSource )
		{
			_arrayInternal = pSource;
			if(_arrayInternal == null)
			{
				_arrayInternal = new List<ExamClassSubject>();
			}
		}

		public ExamClassSubject this[int index]
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
		public void CopyTo(Array array, int index){ _arrayInternal.CopyTo((ExamClassSubject[])array, index); }
		public IEnumerator GetEnumerator() { return _arrayInternal.GetEnumerator(); }
		public void Add(ExamClassSubject pExamClassSubject) { _arrayInternal.Add(pExamClassSubject); }
		public void Clear() { _arrayInternal.Clear(); }
		public IList<ExamClassSubject> GetList() { return _arrayInternal; }
	 }
	
	#endregion
}
