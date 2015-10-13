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
	/// IGuestBookClass interface for NHibernate mapped table 'GuestBook_Class'.
	/// </summary>
	public interface IGuestBookClass
	{
		#region Public Properties
		
		int Id
		{
			get ;
			set ;
			  
		}
		
		string DictNo
		{
			get ;
			set ;
			  
		}
		
		string DictName
		{
			get ;
			set ;
			  
		}
		
		bool Lock
		{
			get ;
			set ;
			  
		}
		
		bool IsDeleted { get; set; }
		bool IsChanged { get; set; }
		
		#endregion 
	}

	/// <summary>
	/// GuestBookClass object for NHibernate mapped table 'GuestBook_Class'.
	/// </summary>
	[Serializable]
	public class GuestBookClass : IGuestBookClass
	{
		#region Member Variables

		protected int id;
		protected string dictno;
		protected string dictname;
		protected bool lock;
		protected bool _bIsDeleted;
		protected bool _bIsChanged;
		#endregion
		
		#region Constructors
		public GuestBookClass() {}
		
		public GuestBookClass(int pId, string pDictNo, string pDictName, bool pLock)
		{
			this.id = pId; 
			this.dictno = pDictNo; 
			this.dictname = pDictName; 
			this.lock = pLock; 
		}
		
		public GuestBookClass(int pId)
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
		
		public string DictNo
		{
			get { return dictno; }
			set 
			{
			  if (value != null && value.Length > 50)
			    throw new ArgumentOutOfRangeException("DictNo", "DictNo value, cannot contain more than 50 characters");
			  _bIsChanged |= (dictno != value); 
			  dictno = value; 
			}
			
		}
		
		public string DictName
		{
			get { return dictname; }
			set 
			{
			  if (value != null && value.Length > 60)
			    throw new ArgumentOutOfRangeException("DictName", "DictName value, cannot contain more than 60 characters");
			  _bIsChanged |= (dictname != value); 
			  dictname = value; 
			}
			
		}
		
		public bool Lock
		{
			get { return lock; }
			set { _bIsChanged |= (lock != value); lock = value; }
			
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
	
	#region Custom ICollection interface for GuestBookClass 

	
	public interface IGuestBookClassCollection : ICollection
	{
		GuestBookClass this[int index]{	get; set; }
		void Add(GuestBookClass pGuestBookClass);
		void Clear();
	}
	
	[Serializable]
	public class GuestBookClassCollection : IGuestBookClassCollection
	{
		private IList<GuestBookClass> _arrayInternal;

		public GuestBookClassCollection()
		{
			_arrayInternal = new List<GuestBookClass>();
		}
		
		public GuestBookClassCollection( IList<GuestBookClass> pSource )
		{
			_arrayInternal = pSource;
			if(_arrayInternal == null)
			{
				_arrayInternal = new List<GuestBookClass>();
			}
		}

		public GuestBookClass this[int index]
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
		public void CopyTo(Array array, int index){ _arrayInternal.CopyTo((GuestBookClass[])array, index); }
		public IEnumerator GetEnumerator() { return _arrayInternal.GetEnumerator(); }
		public void Add(GuestBookClass pGuestBookClass) { _arrayInternal.Add(pGuestBookClass); }
		public void Clear() { _arrayInternal.Clear(); }
		public IList<GuestBookClass> GetList() { return _arrayInternal; }
	 }
	
	#endregion
}
