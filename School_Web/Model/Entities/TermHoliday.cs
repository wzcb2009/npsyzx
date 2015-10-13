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
	/// ITermHoliday interface for NHibernate mapped table 'Term_Holiday'.
	/// </summary>
	public interface ITermHoliday
	{
		#region Public Properties
		
		int Id
		{
			get ;
			set ;
			  
		}
		
		int Termid
		{
			get ;
			set ;
			  
		}
		
		string Title
		{
			get ;
			set ;
			  
		}
		
		DateTime HDate
		{
			get ;
			set ;
			  
		}
		
		string Bz
		{
			get ;
			set ;
			  
		}
		
		int Type
		{
			get ;
			set ;
			  
		}
		
		DateTime WDate
		{
			get ;
			set ;
			  
		}
		
		bool IsDeleted { get; set; }
		bool IsChanged { get; set; }
		
		#endregion 
	}

	/// <summary>
	/// TermHoliday object for NHibernate mapped table 'Term_Holiday'.
	/// </summary>
	[Serializable]
	public class TermHoliday : ITermHoliday
	{
		#region Member Variables

		protected int id;
		protected int termid;
		protected string title;
		protected DateTime hdate;
		protected string bz;
		protected int type;
		protected DateTime wdate;
		protected bool _bIsDeleted;
		protected bool _bIsChanged;
		#endregion
		
		#region Constructors
		public TermHoliday() {}
		
		public TermHoliday(int pTermid, string pTitle, DateTime pHdate, string pBz, int pType, DateTime pWdate)
		{
			this.termid = pTermid; 
			this.title = pTitle; 
			this.hdate = pHdate; 
			this.bz = pBz; 
			this.type = pType; 
			this.wdate = pWdate; 
		}
		
		public TermHoliday(int pId)
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
		
		public int Termid
		{
			get { return termid; }
			set { _bIsChanged |= (termid != value); termid = value; }
			
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
		
		public DateTime HDate
		{
			get { return hdate; }
			set { _bIsChanged |= (hdate != value); hdate = value; }
			
		}
		
		public string Bz
		{
			get { return bz; }
			set 
			{
			  if (value != null && value.Length > 50)
			    throw new ArgumentOutOfRangeException("Bz", "Bz value, cannot contain more than 50 characters");
			  _bIsChanged |= (bz != value); 
			  bz = value; 
			}
			
		}
		
		public int Type
		{
			get { return type; }
			set { _bIsChanged |= (type != value); type = value; }
			
		}
		
		public DateTime WDate
		{
			get { return wdate; }
			set { _bIsChanged |= (wdate != value); wdate = value; }
			
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
	
	#region Custom ICollection interface for TermHoliday 

	
	public interface ITermHolidayCollection : ICollection
	{
		TermHoliday this[int index]{	get; set; }
		void Add(TermHoliday pTermHoliday);
		void Clear();
	}
	
	[Serializable]
	public class TermHolidayCollection : ITermHolidayCollection
	{
		private IList<TermHoliday> _arrayInternal;

		public TermHolidayCollection()
		{
			_arrayInternal = new List<TermHoliday>();
		}
		
		public TermHolidayCollection( IList<TermHoliday> pSource )
		{
			_arrayInternal = pSource;
			if(_arrayInternal == null)
			{
				_arrayInternal = new List<TermHoliday>();
			}
		}

		public TermHoliday this[int index]
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
		public void CopyTo(Array array, int index){ _arrayInternal.CopyTo((TermHoliday[])array, index); }
		public IEnumerator GetEnumerator() { return _arrayInternal.GetEnumerator(); }
		public void Add(TermHoliday pTermHoliday) { _arrayInternal.Add(pTermHoliday); }
		public void Clear() { _arrayInternal.Clear(); }
		public IList<TermHoliday> GetList() { return _arrayInternal; }
	 }
	
	#endregion
}
