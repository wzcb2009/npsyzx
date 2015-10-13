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
	/// IEventUser interface for NHibernate mapped table 'EventUser'.
	/// </summary>
	public interface IEventUser
	{
		#region Public Properties
		
		int EventUserid
		{
			get ;
			set ;
			  
		}
		
		int Eventid
		{
			get ;
			set ;
			  
		}
		
		int UserId
		{
			get ;
			set ;
			  
		}
		
		int Pindex
		{
			get ;
			set ;
			  
		}
		
		int EventCaseid
		{
			get ;
			set ;
			  
		}
		
		DateTime Pubdate
		{
			get ;
			set ;
			  
		}
		
		int CheckCaseId
		{
			get ;
			set ;
			  
		}
		
		string Remark
		{
			get ;
			set ;
			  
		}
		
		bool IsDeleted { get; set; }
		bool IsChanged { get; set; }
		
		#endregion 
	}

	/// <summary>
	/// EventUser object for NHibernate mapped table 'EventUser'.
	/// </summary>
	[Serializable]
	public class EventUser : IEventUser
	{
		#region Member Variables

		protected int eventuserid;
		protected int eventid;
		protected int userid;
		protected int pindex;
		protected int eventcaseid;
		protected DateTime pubdate;
		protected int checkcaseid;
		protected string remark;
		protected bool _bIsDeleted;
		protected bool _bIsChanged;
		#endregion
		
		#region Constructors
		public EventUser() {}
		
		public EventUser(int pEventid, int pUserId, int pPindex, int pEventCaseid, DateTime pPubdate, int pCheckCaseId, string pRemark)
		{
			this.eventid = pEventid; 
			this.userid = pUserId; 
			this.pindex = pPindex; 
			this.eventcaseid = pEventCaseid; 
			this.pubdate = pPubdate; 
			this.checkcaseid = pCheckCaseId; 
			this.remark = pRemark; 
		}
		
		public EventUser(int pEventUserid)
		{
			this.eventuserid = pEventUserid; 
		}
		
		#endregion
		
		#region Public Properties
		
		public int EventUserid
		{
			get { return eventuserid; }
			set { _bIsChanged |= (eventuserid != value); eventuserid = value; }
			
		}
		
		public int Eventid
		{
			get { return eventid; }
			set { _bIsChanged |= (eventid != value); eventid = value; }
			
		}
		
		public int UserId
		{
			get { return userid; }
			set { _bIsChanged |= (userid != value); userid = value; }
			
		}
		
		public int Pindex
		{
			get { return pindex; }
			set { _bIsChanged |= (pindex != value); pindex = value; }
			
		}
		
		public int EventCaseid
		{
			get { return eventcaseid; }
			set { _bIsChanged |= (eventcaseid != value); eventcaseid = value; }
			
		}
		
		public DateTime Pubdate
		{
			get { return pubdate; }
			set { _bIsChanged |= (pubdate != value); pubdate = value; }
			
		}
		
		public int CheckCaseId
		{
			get { return checkcaseid; }
			set { _bIsChanged |= (checkcaseid != value); checkcaseid = value; }
			
		}
		
		public string Remark
		{
			get { return remark; }
			set 
			{
			  if (value != null && value.Length > 250)
			    throw new ArgumentOutOfRangeException("Remark", "Remark value, cannot contain more than 250 characters");
			  _bIsChanged |= (remark != value); 
			  remark = value; 
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
	
	#region Custom ICollection interface for EventUser 

	
	public interface IEventUserCollection : ICollection
	{
		EventUser this[int index]{	get; set; }
		void Add(EventUser pEventUser);
		void Clear();
	}
	
	[Serializable]
	public class EventUserCollection : IEventUserCollection
	{
		private IList<EventUser> _arrayInternal;

		public EventUserCollection()
		{
			_arrayInternal = new List<EventUser>();
		}
		
		public EventUserCollection( IList<EventUser> pSource )
		{
			_arrayInternal = pSource;
			if(_arrayInternal == null)
			{
				_arrayInternal = new List<EventUser>();
			}
		}

		public EventUser this[int index]
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
		public void CopyTo(Array array, int index){ _arrayInternal.CopyTo((EventUser[])array, index); }
		public IEnumerator GetEnumerator() { return _arrayInternal.GetEnumerator(); }
		public void Add(EventUser pEventUser) { _arrayInternal.Add(pEventUser); }
		public void Clear() { _arrayInternal.Clear(); }
		public IList<EventUser> GetList() { return _arrayInternal; }
	 }
	
	#endregion
}
