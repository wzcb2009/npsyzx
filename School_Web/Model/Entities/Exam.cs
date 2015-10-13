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
	/// IExam interface for NHibernate mapped table 'Exam'.
	/// </summary>
	public interface IExam
	{
		#region Public Properties
		
		int ExamId
		{
			get ;
			set ;
			  
		}
		
		string Title
		{
			get ;
			set ;
			  
		}
		
		int Termid
		{
			get ;
			set ;
			  
		}
		
		DateTime Pubdate
		{
			get ;
			set ;
			  
		}
		
		int TeacherId
		{
			get ;
			set ;
			  
		}
		
		bool SystemFlag
		{
			get ;
			set ;
			  
		}
		
		int Typeid
		{
			get ;
			set ;
			  
		}
		
		int PreexamId
		{
			get ;
			set ;
			  
		}
		
		int AddExamStyle
		{
			get ;
			set ;
			  
		}
		
		int Pindex
		{
			get ;
			set ;
			  
		}
		
		bool IsDeleted { get; set; }
		bool IsChanged { get; set; }
		
		#endregion 
	}

	/// <summary>
	/// Exam object for NHibernate mapped table 'Exam'.
	/// </summary>
	[Serializable]
	public class Exam : IExam
	{
		#region Member Variables

		protected int examid;
		protected string title;
		protected int termid;
		protected DateTime pubdate;
		protected int teacherid;
		protected bool systemflag;
		protected int typeid;
		protected int preexamid;
		protected int addexamstyle;
		protected int pindex;
		protected bool _bIsDeleted;
		protected bool _bIsChanged;
		#endregion
		
		#region Constructors
		public Exam() {}
		
		public Exam(string pTitle, int pTermid, DateTime pPubdate, int pTeacherId, bool pSystemFlag, int pTypeid, int pPreexamId, int pAddExamStyle, int pPindex)
		{
			this.title = pTitle; 
			this.termid = pTermid; 
			this.pubdate = pPubdate; 
			this.teacherid = pTeacherId; 
			this.systemflag = pSystemFlag; 
			this.typeid = pTypeid; 
			this.preexamid = pPreexamId; 
			this.addexamstyle = pAddExamStyle; 
			this.pindex = pPindex; 
		}
		
		public Exam(int pExamId)
		{
			this.examid = pExamId; 
		}
		
		#endregion
		
		#region Public Properties
		
		public int ExamId
		{
			get { return examid; }
			set { _bIsChanged |= (examid != value); examid = value; }
			
		}
		
		public string Title
		{
			get { return title; }
			set 
			{
			  if (value != null && value.Length > 50)
			    throw new ArgumentOutOfRangeException("Title", "Title value, cannot contain more than 50 characters");
			  _bIsChanged |= (title != value); 
			  title = value; 
			}
			
		}
		
		public int Termid
		{
			get { return termid; }
			set { _bIsChanged |= (termid != value); termid = value; }
			
		}
		
		public DateTime Pubdate
		{
			get { return pubdate; }
			set { _bIsChanged |= (pubdate != value); pubdate = value; }
			
		}
		
		public int TeacherId
		{
			get { return teacherid; }
			set { _bIsChanged |= (teacherid != value); teacherid = value; }
			
		}
		
		public bool SystemFlag
		{
			get { return systemflag; }
			set { _bIsChanged |= (systemflag != value); systemflag = value; }
			
		}
		
		public int Typeid
		{
			get { return typeid; }
			set { _bIsChanged |= (typeid != value); typeid = value; }
			
		}
		
		public int PreexamId
		{
			get { return preexamid; }
			set { _bIsChanged |= (preexamid != value); preexamid = value; }
			
		}
		
		public int AddExamStyle
		{
			get { return addexamstyle; }
			set { _bIsChanged |= (addexamstyle != value); addexamstyle = value; }
			
		}
		
		public int Pindex
		{
			get { return pindex; }
			set { _bIsChanged |= (pindex != value); pindex = value; }
			
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
	
	#region Custom ICollection interface for Exam 

	
	public interface IExamCollection : ICollection
	{
		Exam this[int index]{	get; set; }
		void Add(Exam pExam);
		void Clear();
	}
	
	[Serializable]
	public class ExamCollection : IExamCollection
	{
		private IList<Exam> _arrayInternal;

		public ExamCollection()
		{
			_arrayInternal = new List<Exam>();
		}
		
		public ExamCollection( IList<Exam> pSource )
		{
			_arrayInternal = pSource;
			if(_arrayInternal == null)
			{
				_arrayInternal = new List<Exam>();
			}
		}

		public Exam this[int index]
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
		public void CopyTo(Array array, int index){ _arrayInternal.CopyTo((Exam[])array, index); }
		public IEnumerator GetEnumerator() { return _arrayInternal.GetEnumerator(); }
		public void Add(Exam pExam) { _arrayInternal.Add(pExam); }
		public void Clear() { _arrayInternal.Clear(); }
		public IList<Exam> GetList() { return _arrayInternal; }
	 }
	
	#endregion
}
