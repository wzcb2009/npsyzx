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
	/// IWorkUser interface for NHibernate mapped table 'WorkUser'.
	/// </summary>
	public interface IWorkUser
	{
		#region Public Properties
		
		int Id
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
	/// WorkUser object for NHibernate mapped table 'WorkUser'.
	/// </summary>
	[Serializable]
	public class WorkUser : IWorkUser
	{
		#region Member Variables

		protected int id;
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
		public WorkUser() {}
		
		public WorkUser(int pEventid, int pUserId, int pPindex, int pEventCaseid, DateTime pPubdate, int pCheckCaseId, string pRemark)
		{
			this.eventid = pEventid; 
			this.userid = pUserId; 
			this.pindex = pPindex; 
			this.eventcaseid = pEventCaseid; 
			this.pubdate = pPubdate; 
			this.checkcaseid = pCheckCaseId; 
			this.remark = pRemark; 
		}
		
		public WorkUser(int pId)
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
	
	#region Custom ICollection interface for WorkUser 

	
	public interface IWorkUserCollection : ICollection
	{
		WorkUser this[int index]{	get; set; }
		void Add(WorkUser pWorkUser);
		void Clear();
	}
	
	[Serializable]
	public class WorkUserCollection : IWorkUserCollection
	{
		private IList<WorkUser> _arrayInternal;

		public WorkUserCollection()
		{
			_arrayInternal = new List<WorkUser>();
		}
		
		public WorkUserCollection( IList<WorkUser> pSource )
		{
			_arrayInternal = pSource;
			if(_arrayInternal == null)
			{
				_arrayInternal = new List<WorkUser>();
			}
		}

		public WorkUser this[int index]
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
		public void CopyTo(Array array, int index){ _arrayInternal.CopyTo((WorkUser[])array, index); }
		public IEnumerator GetEnumerator() { return _arrayInternal.GetEnumerator(); }
		public void Add(WorkUser pWorkUser) { _arrayInternal.Add(pWorkUser); }
		public void Clear() { _arrayInternal.Clear(); }
		public IList<WorkUser> GetList() { return _arrayInternal; }
	 }
	
	#endregion
}
