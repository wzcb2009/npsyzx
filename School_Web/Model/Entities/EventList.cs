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
	/// IEventList interface for NHibernate mapped table 'EventList'.
	/// </summary>
	public interface IEventList
	{
		#region Public Properties
		
		int Id
		{
			get ;
			set ;
			  
		}
		
		string CodeNumber
		{
			get ;
			set ;
			  
		}
		
		int UserId
		{
			get ;
			set ;
			  
		}
		
		int Caseid
		{
			get ;
			set ;
			  
		}
		
		int UnitId
		{
			get ;
			set ;
			  
		}
		
		int LevelId
		{
			get ;
			set ;
			  
		}
		
		int Number
		{
			get ;
			set ;
			  
		}
		
		double Price
		{
			get ;
			set ;
			  
		}
		
		string Title
		{
			get ;
			set ;
			  
		}
		
		string TrueName
		{
			get ;
			set ;
			  
		}
		
		string Tel
		{
			get ;
			set ;
			  
		}
		
		DateTime Pubdate
		{
			get ;
			set ;
			  
		}
		
		string Address
		{
			get ;
			set ;
			  
		}
		
		string Remak
		{
			get ;
			set ;
			  
		}
		
		bool IsDeleted { get; set; }
		bool IsChanged { get; set; }
		
		#endregion 
	}

	/// <summary>
	/// EventList object for NHibernate mapped table 'EventList'.
	/// </summary>
	[Serializable]
	public class EventList : IEventList
	{
		#region Member Variables

		protected int id;
		protected string codenumber;
		protected int userid;
		protected int caseid;
		protected int unitid;
		protected int levelid;
		protected int number;
		protected double price;
		protected string title;
		protected string truename;
		protected string tel;
		protected DateTime pubdate;
		protected string address;
		protected string remak;
		protected bool _bIsDeleted;
		protected bool _bIsChanged;
		#endregion
		
		#region Constructors
		public EventList() {}
		
		public EventList(string pCodeNumber, int pUserId, int pCaseid, int pUnitId, int pLevelId, int pNumber, double pPrice, string pTitle, string pTrueName, string pTel, DateTime pPubdate, string pAddress, string pRemak)
		{
			this.codenumber = pCodeNumber; 
			this.userid = pUserId; 
			this.caseid = pCaseid; 
			this.unitid = pUnitId; 
			this.levelid = pLevelId; 
			this.number = pNumber; 
			this.price = pPrice; 
			this.title = pTitle; 
			this.truename = pTrueName; 
			this.tel = pTel; 
			this.pubdate = pPubdate; 
			this.address = pAddress; 
			this.remak = pRemak; 
		}
		
		public EventList(int pId)
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
		
		public string CodeNumber
		{
			get { return codenumber; }
			set 
			{
			  if (value != null && value.Length > 50)
			    throw new ArgumentOutOfRangeException("CodeNumber", "CodeNumber value, cannot contain more than 50 characters");
			  _bIsChanged |= (codenumber != value); 
			  codenumber = value; 
			}
			
		}
		
		public int UserId
		{
			get { return userid; }
			set { _bIsChanged |= (userid != value); userid = value; }
			
		}
		
		public int Caseid
		{
			get { return caseid; }
			set { _bIsChanged |= (caseid != value); caseid = value; }
			
		}
		
		public int UnitId
		{
			get { return unitid; }
			set { _bIsChanged |= (unitid != value); unitid = value; }
			
		}
		
		public int LevelId
		{
			get { return levelid; }
			set { _bIsChanged |= (levelid != value); levelid = value; }
			
		}
		
		public int Number
		{
			get { return number; }
			set { _bIsChanged |= (number != value); number = value; }
			
		}
		
		public double Price
		{
			get { return price; }
			set { _bIsChanged |= (price != value); price = value; }
			
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
		
		public string TrueName
		{
			get { return truename; }
			set 
			{
			  if (value != null && value.Length > 50)
			    throw new ArgumentOutOfRangeException("TrueName", "TrueName value, cannot contain more than 50 characters");
			  _bIsChanged |= (truename != value); 
			  truename = value; 
			}
			
		}
		
		public string Tel
		{
			get { return tel; }
			set 
			{
			  if (value != null && value.Length > 50)
			    throw new ArgumentOutOfRangeException("Tel", "Tel value, cannot contain more than 50 characters");
			  _bIsChanged |= (tel != value); 
			  tel = value; 
			}
			
		}
		
		public DateTime Pubdate
		{
			get { return pubdate; }
			set { _bIsChanged |= (pubdate != value); pubdate = value; }
			
		}
		
		public string Address
		{
			get { return address; }
			set 
			{
			  if (value != null && value.Length > 50)
			    throw new ArgumentOutOfRangeException("Address", "Address value, cannot contain more than 50 characters");
			  _bIsChanged |= (address != value); 
			  address = value; 
			}
			
		}
		
		public string Remak
		{
			get { return remak; }
			set 
			{
			  if (value != null && value.Length > 1073741823)
			    throw new ArgumentOutOfRangeException("Remak", "Remak value, cannot contain more than 1073741823 characters");
			  _bIsChanged |= (remak != value); 
			  remak = value; 
			}
			
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
	
	#region Custom ICollection interface for EventList 

	
	public interface IEventListCollection : ICollection
	{
		EventList this[int index]{	get; set; }
		void Add(EventList pEventList);
		void Clear();
	}
	
	[Serializable]
	public class EventListCollection : IEventListCollection
	{
		private IList<EventList> _arrayInternal;

		public EventListCollection()
		{
			_arrayInternal = new List<EventList>();
		}
		
		public EventListCollection( IList<EventList> pSource )
		{
			_arrayInternal = pSource;
			if(_arrayInternal == null)
			{
				_arrayInternal = new List<EventList>();
			}
		}

		public EventList this[int index]
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
		public void CopyTo(Array array, int index){ _arrayInternal.CopyTo((EventList[])array, index); }
		public IEnumerator GetEnumerator() { return _arrayInternal.GetEnumerator(); }
		public void Add(EventList pEventList) { _arrayInternal.Add(pEventList); }
		public void Clear() { _arrayInternal.Clear(); }
		public IList<EventList> GetList() { return _arrayInternal; }
	 }
	
	#endregion
}
