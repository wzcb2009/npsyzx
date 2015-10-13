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
	/// INwebCnNewsSort interface for NHibernate mapped table 'NwebCn_NewsSort'.
	/// </summary>
	public interface INwebCnNewsSort
	{
		#region Public Properties
		
		int Id
		{
			get ;
			set ;
			  
		}
		
		string SortName
		{
			get ;
			set ;
			  
		}
		
		bool ViewFlag
		{
			get ;
			set ;
			  
		}
		
		short Parentid
		{
			get ;
			set ;
			  
		}
		
		string SortPath
		{
			get ;
			set ;
			  
		}
		
		int ClickNumber
		{
			get ;
			set ;
			  
		}
		
		bool IsDeleted { get; set; }
		bool IsChanged { get; set; }
		
		#endregion 
	}

	/// <summary>
	/// NwebCnNewsSort object for NHibernate mapped table 'NwebCn_NewsSort'.
	/// </summary>
	[Serializable]
	public class NwebCnNewsSort : INwebCnNewsSort
	{
		#region Member Variables

		protected int id;
		protected string sortname;
		protected bool viewflag;
		protected short parentid;
		protected string sortpath;
		protected int clicknumber;
		protected bool _bIsDeleted;
		protected bool _bIsChanged;
		#endregion
		
		#region Constructors
		public NwebCnNewsSort() {}
		
		public NwebCnNewsSort(int pId, string pSortName, bool pViewFlag, short pParentid, string pSortPath, int pClickNumber)
		{
			this.id = pId; 
			this.sortname = pSortName; 
			this.viewflag = pViewFlag; 
			this.parentid = pParentid; 
			this.sortpath = pSortPath; 
			this.clicknumber = pClickNumber; 
		}
		
		public NwebCnNewsSort(int pId, bool pViewFlag)
		{
			this.id = pId; 
			this.viewflag = pViewFlag; 
		}
		
		#endregion
		
		#region Public Properties
		
		public int Id
		{
			get { return id; }
			set { _bIsChanged |= (id != value); id = value; }
			
		}
		
		public string SortName
		{
			get { return sortname; }
			set 
			{
			  if (value != null && value.Length > 50)
			    throw new ArgumentOutOfRangeException("SortName", "SortName value, cannot contain more than 50 characters");
			  _bIsChanged |= (sortname != value); 
			  sortname = value; 
			}
			
		}
		
		public bool ViewFlag
		{
			get { return viewflag; }
			set { _bIsChanged |= (viewflag != value); viewflag = value; }
			
		}
		
		public short Parentid
		{
			get { return parentid; }
			set { _bIsChanged |= (parentid != value); parentid = value; }
			
		}
		
		public string SortPath
		{
			get { return sortpath; }
			set 
			{
			  if (value != null && value.Length > 50)
			    throw new ArgumentOutOfRangeException("SortPath", "SortPath value, cannot contain more than 50 characters");
			  _bIsChanged |= (sortpath != value); 
			  sortpath = value; 
			}
			
		}
		
		public int ClickNumber
		{
			get { return clicknumber; }
			set { _bIsChanged |= (clicknumber != value); clicknumber = value; }
			
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
	
	#region Custom ICollection interface for NwebCnNewsSort 

	
	public interface INwebCnNewsSortCollection : ICollection
	{
		NwebCnNewsSort this[int index]{	get; set; }
		void Add(NwebCnNewsSort pNwebCnNewsSort);
		void Clear();
	}
	
	[Serializable]
	public class NwebCnNewsSortCollection : INwebCnNewsSortCollection
	{
		private IList<NwebCnNewsSort> _arrayInternal;

		public NwebCnNewsSortCollection()
		{
			_arrayInternal = new List<NwebCnNewsSort>();
		}
		
		public NwebCnNewsSortCollection( IList<NwebCnNewsSort> pSource )
		{
			_arrayInternal = pSource;
			if(_arrayInternal == null)
			{
				_arrayInternal = new List<NwebCnNewsSort>();
			}
		}

		public NwebCnNewsSort this[int index]
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
		public void CopyTo(Array array, int index){ _arrayInternal.CopyTo((NwebCnNewsSort[])array, index); }
		public IEnumerator GetEnumerator() { return _arrayInternal.GetEnumerator(); }
		public void Add(NwebCnNewsSort pNwebCnNewsSort) { _arrayInternal.Add(pNwebCnNewsSort); }
		public void Clear() { _arrayInternal.Clear(); }
		public IList<NwebCnNewsSort> GetList() { return _arrayInternal; }
	 }
	
	#endregion
}
