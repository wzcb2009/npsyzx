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
	/// ILabData interface for NHibernate mapped table 'Lab_data'.
	/// </summary>
	public interface ILabData
	{
		#region Public Properties
		
		int Id
		{
			get ;
			set ;
			  
		}
		
		int Caseid
		{
			get ;
			set ;
			  
		}
		
		string Title
		{
			get ;
			set ;
			  
		}
		
		int Pindex
		{
			get ;
			set ;
			  
		}
		
		int Num
		{
			get ;
			set ;
			  
		}
		
		string Dw
		{
			get ;
			set ;
			  
		}
		
		DateTime Pubdate
		{
			get ;
			set ;
			  
		}
		
		string Manager
		{
			get ;
			set ;
			  
		}
		
		int Location
		{
			get ;
			set ;
			  
		}
		
		bool IsDeleted { get; set; }
		bool IsChanged { get; set; }
		
		#endregion 
	}

	/// <summary>
	/// LabData object for NHibernate mapped table 'Lab_data'.
	/// </summary>
	[Serializable]
	public class LabData : ILabData
	{
		#region Member Variables

		protected int id;
		protected int caseid;
		protected string title;
		protected int pindex;
		protected int num;
		protected string dw;
		protected DateTime pubdate;
		protected string manager;
		protected int location;
		protected bool _bIsDeleted;
		protected bool _bIsChanged;
		#endregion
		
		#region Constructors
		public LabData() {}
		
		public LabData(int pId, int pCaseid, string pTitle, int pPindex, int pNum, string pDw, DateTime pPubdate, string pManager, int pLocation)
		{
			this.id = pId; 
			this.caseid = pCaseid; 
			this.title = pTitle; 
			this.pindex = pPindex; 
			this.num = pNum; 
			this.dw = pDw; 
			this.pubdate = pPubdate; 
			this.manager = pManager; 
			this.location = pLocation; 
		}
		
		public LabData(int pId)
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
		
		public int Caseid
		{
			get { return caseid; }
			set { _bIsChanged |= (caseid != value); caseid = value; }
			
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
		
		public int Pindex
		{
			get { return pindex; }
			set { _bIsChanged |= (pindex != value); pindex = value; }
			
		}
		
		public int Num
		{
			get { return num; }
			set { _bIsChanged |= (num != value); num = value; }
			
		}
		
		public string Dw
		{
			get { return dw; }
			set 
			{
			  if (value != null && value.Length > 50)
			    throw new ArgumentOutOfRangeException("Dw", "Dw value, cannot contain more than 50 characters");
			  _bIsChanged |= (dw != value); 
			  dw = value; 
			}
			
		}
		
		public DateTime Pubdate
		{
			get { return pubdate; }
			set { _bIsChanged |= (pubdate != value); pubdate = value; }
			
		}
		
		public string Manager
		{
			get { return manager; }
			set 
			{
			  if (value != null && value.Length > 50)
			    throw new ArgumentOutOfRangeException("Manager", "Manager value, cannot contain more than 50 characters");
			  _bIsChanged |= (manager != value); 
			  manager = value; 
			}
			
		}
		
		public int Location
		{
			get { return location; }
			set { _bIsChanged |= (location != value); location = value; }
			
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
	
	#region Custom ICollection interface for LabData 

	
	public interface ILabDataCollection : ICollection
	{
		LabData this[int index]{	get; set; }
		void Add(LabData pLabData);
		void Clear();
	}
	
	[Serializable]
	public class LabDataCollection : ILabDataCollection
	{
		private IList<LabData> _arrayInternal;

		public LabDataCollection()
		{
			_arrayInternal = new List<LabData>();
		}
		
		public LabDataCollection( IList<LabData> pSource )
		{
			_arrayInternal = pSource;
			if(_arrayInternal == null)
			{
				_arrayInternal = new List<LabData>();
			}
		}

		public LabData this[int index]
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
		public void CopyTo(Array array, int index){ _arrayInternal.CopyTo((LabData[])array, index); }
		public IEnumerator GetEnumerator() { return _arrayInternal.GetEnumerator(); }
		public void Add(LabData pLabData) { _arrayInternal.Add(pLabData); }
		public void Clear() { _arrayInternal.Clear(); }
		public IList<LabData> GetList() { return _arrayInternal; }
	 }
	
	#endregion
}
