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
	/// IHoliday interface for NHibernate mapped table 'Holiday'.
	/// </summary>
	public interface IHoliday
	{
		#region Public Properties
		
		int Id
		{
			get ;
			set ;
			  
		}
		
		string HName
		{
			get ;
			set ;
			  
		}
		
		int HMonth
		{
			get ;
			set ;
			  
		}
		
		int HDay
		{
			get ;
			set ;
			  
		}
		
		int HNum
		{
			get ;
			set ;
			  
		}
		
		bool IsDeleted { get; set; }
		bool IsChanged { get; set; }
		
		#endregion 
	}

	/// <summary>
	/// Holiday object for NHibernate mapped table 'Holiday'.
	/// </summary>
	[Serializable]
	public class Holiday : IHoliday
	{
		#region Member Variables

		protected int id;
		protected string hname;
		protected int hmonth;
		protected int hday;
		protected int hnum;
		protected bool _bIsDeleted;
		protected bool _bIsChanged;
		#endregion
		
		#region Constructors
		public Holiday() {}
		
		public Holiday(string pHname, int pHmonth, int pHday, int pHnum)
		{
			this.hname = pHname; 
			this.hmonth = pHmonth; 
			this.hday = pHday; 
			this.hnum = pHnum; 
		}
		
		public Holiday(int pId)
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
		
		public string HName
		{
			get { return hname; }
			set 
			{
			  if (value != null && value.Length > 50)
			    throw new ArgumentOutOfRangeException("HName", "HName value, cannot contain more than 50 characters");
			  _bIsChanged |= (hname != value); 
			  hname = value; 
			}
			
		}
		
		public int HMonth
		{
			get { return hmonth; }
			set { _bIsChanged |= (hmonth != value); hmonth = value; }
			
		}
		
		public int HDay
		{
			get { return hday; }
			set { _bIsChanged |= (hday != value); hday = value; }
			
		}
		
		public int HNum
		{
			get { return hnum; }
			set { _bIsChanged |= (hnum != value); hnum = value; }
			
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
	
	#region Custom ICollection interface for Holiday 

	
	public interface IHolidayCollection : ICollection
	{
		Holiday this[int index]{	get; set; }
		void Add(Holiday pHoliday);
		void Clear();
	}
	
	[Serializable]
	public class HolidayCollection : IHolidayCollection
	{
		private IList<Holiday> _arrayInternal;

		public HolidayCollection()
		{
			_arrayInternal = new List<Holiday>();
		}
		
		public HolidayCollection( IList<Holiday> pSource )
		{
			_arrayInternal = pSource;
			if(_arrayInternal == null)
			{
				_arrayInternal = new List<Holiday>();
			}
		}

		public Holiday this[int index]
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
		public void CopyTo(Array array, int index){ _arrayInternal.CopyTo((Holiday[])array, index); }
		public IEnumerator GetEnumerator() { return _arrayInternal.GetEnumerator(); }
		public void Add(Holiday pHoliday) { _arrayInternal.Add(pHoliday); }
		public void Clear() { _arrayInternal.Clear(); }
		public IList<Holiday> GetList() { return _arrayInternal; }
	 }
	
	#endregion
}
