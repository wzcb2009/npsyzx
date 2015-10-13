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
	/// ISubject interface for NHibernate mapped table 'Subject'.
	/// </summary>
	public interface ISubject
	{
		#region Public Properties
		
		int Id
		{
			get ;
			set ;
			  
		}
		
		string SubjectName
		{
			get ;
			set ;
			  
		}
		
		short Pindex
		{
			get ;
			set ;
			  
		}
		
		string Sname
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
	/// Subject object for NHibernate mapped table 'Subject'.
	/// </summary>
	[Serializable]
	public class Subject : ISubject
	{
		#region Member Variables

		protected int id;
		protected string subjectname;
		protected short pindex;
		protected string sname;
		protected int weeknum;
		protected bool _bIsDeleted;
		protected bool _bIsChanged;
		#endregion
		
		#region Constructors
		public Subject() {}
		
		public Subject(string pSubjectName, short pPindex, string pSname, int pWeekNum)
		{
			this.subjectname = pSubjectName; 
			this.pindex = pPindex; 
			this.sname = pSname; 
			this.weeknum = pWeekNum; 
		}
		
		public Subject(string pSubjectName)
		{
			this.subjectname = pSubjectName; 
		}
		
		public Subject(int pId)
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
		
		public string SubjectName
		{
			get { return subjectname; }
			set 
			{
			  if (value != null && value.Length > 50)
			    throw new ArgumentOutOfRangeException("SubjectName", "SubjectName value, cannot contain more than 50 characters");
			  _bIsChanged |= (subjectname != value); 
			  subjectname = value; 
			}
			
		}
		
		public short Pindex
		{
			get { return pindex; }
			set { _bIsChanged |= (pindex != value); pindex = value; }
			
		}
		
		public string Sname
		{
			get { return sname; }
			set 
			{
			  if (value != null && value.Length > 50)
			    throw new ArgumentOutOfRangeException("Sname", "Sname value, cannot contain more than 50 characters");
			  _bIsChanged |= (sname != value); 
			  sname = value; 
			}
			
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
	
	#region Custom ICollection interface for Subject 

	
	public interface ISubjectCollection : ICollection
	{
		Subject this[int index]{	get; set; }
		void Add(Subject pSubject);
		void Clear();
	}
	
	[Serializable]
	public class SubjectCollection : ISubjectCollection
	{
		private IList<Subject> _arrayInternal;

		public SubjectCollection()
		{
			_arrayInternal = new List<Subject>();
		}
		
		public SubjectCollection( IList<Subject> pSource )
		{
			_arrayInternal = pSource;
			if(_arrayInternal == null)
			{
				_arrayInternal = new List<Subject>();
			}
		}

		public Subject this[int index]
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
		public void CopyTo(Array array, int index){ _arrayInternal.CopyTo((Subject[])array, index); }
		public IEnumerator GetEnumerator() { return _arrayInternal.GetEnumerator(); }
		public void Add(Subject pSubject) { _arrayInternal.Add(pSubject); }
		public void Clear() { _arrayInternal.Clear(); }
		public IList<Subject> GetList() { return _arrayInternal; }
	 }
	
	#endregion
}
