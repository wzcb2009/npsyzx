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
	/// ILzpjTermJxjdList interface for NHibernate mapped table 'lzpj_Term_jxjd_list'.
	/// </summary>
	public interface ILzpjTermJxjdList
	{
		#region Public Properties
		
		int Id
		{
			get ;
			set ;
			  
		}
		
		int Userid
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
		
		int Termid
		{
			get ;
			set ;
			  
		}
		
		int Weeknum
		{
			get ;
			set ;
			  
		}
		
		string Title
		{
			get ;
			set ;
			  
		}
		
		int CourseTimes
		{
			get ;
			set ;
			  
		}
		
		DateTime Pubdate
		{
			get ;
			set ;
			  
		}
		
		int Pindex
		{
			get ;
			set ;
			  
		}
		
		bool TypeFlag
		{
			get ;
			set ;
			  
		}
		
		bool IsDeleted { get; set; }
		bool IsChanged { get; set; }
		
		#endregion 
	}

	/// <summary>
	/// LzpjTermJxjdList object for NHibernate mapped table 'lzpj_Term_jxjd_list'.
	/// </summary>
	[Serializable]
	public class LzpjTermJxjdList : ILzpjTermJxjdList
	{
		#region Member Variables

		protected int id;
		protected int userid;
		protected int gradeid;
		protected int subjectid;
		protected int termid;
		protected int weeknum;
		protected string title;
		protected int coursetimes;
		protected DateTime pubdate;
		protected int pindex;
		protected bool typeflag;
		protected bool _bIsDeleted;
		protected bool _bIsChanged;
		#endregion
		
		#region Constructors
		public LzpjTermJxjdList() {}
		
		public LzpjTermJxjdList(int pUserid, int pGradeid, int pSubjectid, int pTermid, int pWeeknum, string pTitle, int pCourseTimes, DateTime pPubdate, int pPindex, bool pTypeFlag)
		{
			this.userid = pUserid; 
			this.gradeid = pGradeid; 
			this.subjectid = pSubjectid; 
			this.termid = pTermid; 
			this.weeknum = pWeeknum; 
			this.title = pTitle; 
			this.coursetimes = pCourseTimes; 
			this.pubdate = pPubdate; 
			this.pindex = pPindex; 
			this.typeflag = pTypeFlag; 
		}
		
		public LzpjTermJxjdList(int pId)
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
		
		public int Userid
		{
			get { return userid; }
			set { _bIsChanged |= (userid != value); userid = value; }
			
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
		
		public int Termid
		{
			get { return termid; }
			set { _bIsChanged |= (termid != value); termid = value; }
			
		}
		
		public int Weeknum
		{
			get { return weeknum; }
			set { _bIsChanged |= (weeknum != value); weeknum = value; }
			
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
		
		public int CourseTimes
		{
			get { return coursetimes; }
			set { _bIsChanged |= (coursetimes != value); coursetimes = value; }
			
		}
		
		public DateTime Pubdate
		{
			get { return pubdate; }
			set { _bIsChanged |= (pubdate != value); pubdate = value; }
			
		}
		
		public int Pindex
		{
			get { return pindex; }
			set { _bIsChanged |= (pindex != value); pindex = value; }
			
		}
		
		public bool TypeFlag
		{
			get { return typeflag; }
			set { _bIsChanged |= (typeflag != value); typeflag = value; }
			
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
	
	#region Custom ICollection interface for LzpjTermJxjdList 

	
	public interface ILzpjTermJxjdListCollection : ICollection
	{
		LzpjTermJxjdList this[int index]{	get; set; }
		void Add(LzpjTermJxjdList pLzpjTermJxjdList);
		void Clear();
	}
	
	[Serializable]
	public class LzpjTermJxjdListCollection : ILzpjTermJxjdListCollection
	{
		private IList<LzpjTermJxjdList> _arrayInternal;

		public LzpjTermJxjdListCollection()
		{
			_arrayInternal = new List<LzpjTermJxjdList>();
		}
		
		public LzpjTermJxjdListCollection( IList<LzpjTermJxjdList> pSource )
		{
			_arrayInternal = pSource;
			if(_arrayInternal == null)
			{
				_arrayInternal = new List<LzpjTermJxjdList>();
			}
		}

		public LzpjTermJxjdList this[int index]
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
		public void CopyTo(Array array, int index){ _arrayInternal.CopyTo((LzpjTermJxjdList[])array, index); }
		public IEnumerator GetEnumerator() { return _arrayInternal.GetEnumerator(); }
		public void Add(LzpjTermJxjdList pLzpjTermJxjdList) { _arrayInternal.Add(pLzpjTermJxjdList); }
		public void Clear() { _arrayInternal.Clear(); }
		public IList<LzpjTermJxjdList> GetList() { return _arrayInternal; }
	 }
	
	#endregion
}
