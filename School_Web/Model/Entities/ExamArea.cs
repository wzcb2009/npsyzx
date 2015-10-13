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
	/// IExamArea interface for NHibernate mapped table 'Exam_Area'.
	/// </summary>
	public interface IExamArea
	{
		#region Public Properties
		
		long AreaId
		{
			get ;
			set ;
			  
		}
		
		long ExamId
		{
			get ;
			set ;
			  
		}
		
		int GradeId
		{
			get ;
			set ;
			  
		}
		
		int ExamNum
		{
			get ;
			set ;
			  
		}
		
		string ClassName
		{
			get ;
			set ;
			  
		}
		
		int Num
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
		
		bool IsDeleted { get; set; }
		bool IsChanged { get; set; }
		
		#endregion 
	}

	/// <summary>
	/// ExamArea object for NHibernate mapped table 'Exam_Area'.
	/// </summary>
	[Serializable]
	public class ExamArea : IExamArea
	{
		#region Member Variables

		protected long areaid;
		protected long examid;
		protected int gradeid;
		protected int examnum;
		protected string classname;
		protected int num;
		protected int chkteacherid;
		protected int magteacherid;
		protected bool checkflag;
		protected bool _bIsDeleted;
		protected bool _bIsChanged;
		#endregion
		
		#region Constructors
		public ExamArea() {}
		
		public ExamArea(long pExamId, int pGradeId, int pExamNum, string pClassName, int pNum, int pChkTeacherid, int pMagTeacherid, bool pCheckflag)
		{
			this.examid = pExamId; 
			this.gradeid = pGradeId; 
			this.examnum = pExamNum; 
			this.classname = pClassName; 
			this.num = pNum; 
			this.chkteacherid = pChkTeacherid; 
			this.magteacherid = pMagTeacherid; 
			this.checkflag = pCheckflag; 
		}
		
		#endregion
		
		#region Public Properties
		
		public long AreaId
		{
			get { return areaid; }
			set { _bIsChanged |= (areaid != value); areaid = value; }
			
		}
		
		public long ExamId
		{
			get { return examid; }
			set { _bIsChanged |= (examid != value); examid = value; }
			
		}
		
		public int GradeId
		{
			get { return gradeid; }
			set { _bIsChanged |= (gradeid != value); gradeid = value; }
			
		}
		
		public int ExamNum
		{
			get { return examnum; }
			set { _bIsChanged |= (examnum != value); examnum = value; }
			
		}
		
		public string ClassName
		{
			get { return classname; }
			set 
			{
			  if (value != null && value.Length > 50)
			    throw new ArgumentOutOfRangeException("ClassName", "ClassName value, cannot contain more than 50 characters");
			  _bIsChanged |= (classname != value); 
			  classname = value; 
			}
			
		}
		
		public int Num
		{
			get { return num; }
			set { _bIsChanged |= (num != value); num = value; }
			
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
	
	#region Custom ICollection interface for ExamArea 

	
	public interface IExamAreaCollection : ICollection
	{
		ExamArea this[int index]{	get; set; }
		void Add(ExamArea pExamArea);
		void Clear();
	}
	
	[Serializable]
	public class ExamAreaCollection : IExamAreaCollection
	{
		private IList<ExamArea> _arrayInternal;

		public ExamAreaCollection()
		{
			_arrayInternal = new List<ExamArea>();
		}
		
		public ExamAreaCollection( IList<ExamArea> pSource )
		{
			_arrayInternal = pSource;
			if(_arrayInternal == null)
			{
				_arrayInternal = new List<ExamArea>();
			}
		}

		public ExamArea this[int index]
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
		public void CopyTo(Array array, int index){ _arrayInternal.CopyTo((ExamArea[])array, index); }
		public IEnumerator GetEnumerator() { return _arrayInternal.GetEnumerator(); }
		public void Add(ExamArea pExamArea) { _arrayInternal.Add(pExamArea); }
		public void Clear() { _arrayInternal.Clear(); }
		public IList<ExamArea> GetList() { return _arrayInternal; }
	 }
	
	#endregion
}
