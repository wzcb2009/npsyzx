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
	/// IUserEvent interface for NHibernate mapped table 'UserEvent'.
	/// </summary>
	public interface IUserEvent
	{
		#region Public Properties
		
		int Id
		{
			get ;
			set ;
			  
		}
		
		int YearNum
		{
			get ;
			set ;
			  
		}
		
		int UserId
		{
			get ;
			set ;
			  
		}
		
		string Title
		{
			get ;
			set ;
			  
		}
		
		int CaseId
		{
			get ;
			set ;
			  
		}
		
		int LevelId
		{
			get ;
			set ;
			  
		}
		
		DateTime StartDate
		{
			get ;
			set ;
			  
		}
		
		DateTime EndDate
		{
			get ;
			set ;
			  
		}
		
		string Remark
		{
			get ;
			set ;
			  
		}
		
		DateTime Pubdate
		{
			get ;
			set ;
			  
		}
		
		DateTime CheckedDate
		{
			get ;
			set ;
			  
		}
		
		string CheckName
		{
			get ;
			set ;
			  
		}
		
		bool IsDeleted { get; set; }
		bool IsChanged { get; set; }
		
		#endregion 
	}

	/// <summary>
	/// UserEvent object for NHibernate mapped table 'UserEvent'.
	/// </summary>
	[Serializable]
	public class UserEvent : IUserEvent
	{
		#region Member Variables

		protected int id;
		protected int yearnum;
		protected int userid;
		protected string title;
		protected int caseid;
		protected int levelid;
		protected DateTime startdate;
		protected DateTime enddate;
		protected string remark;
		protected DateTime pubdate;
		protected DateTime checkeddate;
		protected string checkname;
		protected bool _bIsDeleted;
		protected bool _bIsChanged;
		#endregion
		
		#region Constructors
		public UserEvent() {}
		
		public UserEvent(int pYearNum, int pUserId, string pTitle, int pCaseId, int pLevelId, DateTime pStartDate, DateTime pEndDate, string pRemark, DateTime pPubdate, DateTime pCheckedDate, string pCheckName)
		{
			this.yearnum = pYearNum; 
			this.userid = pUserId; 
			this.title = pTitle; 
			this.caseid = pCaseId; 
			this.levelid = pLevelId; 
			this.startdate = pStartDate; 
			this.enddate = pEndDate; 
			this.remark = pRemark; 
			this.pubdate = pPubdate; 
			this.checkeddate = pCheckedDate; 
			this.checkname = pCheckName; 
		}
		
		public UserEvent(int pId)
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
		
		public int YearNum
		{
			get { return yearnum; }
			set { _bIsChanged |= (yearnum != value); yearnum = value; }
			
		}
		
		public int UserId
		{
			get { return userid; }
			set { _bIsChanged |= (userid != value); userid = value; }
			
		}
		
		public string Title
		{
			get { return title; }
			set 
			{
			  if (value != null && value.Length > 250)
			    throw new ArgumentOutOfRangeException("Title", "Title value, cannot contain more than 250 characters");
			  _bIsChanged |= (title != value); 
			  title = value; 
			}
			
		}
		
		public int CaseId
		{
			get { return caseid; }
			set { _bIsChanged |= (caseid != value); caseid = value; }
			
		}
		
		public int LevelId
		{
			get { return levelid; }
			set { _bIsChanged |= (levelid != value); levelid = value; }
			
		}
		
		public DateTime StartDate
		{
			get { return startdate; }
			set { _bIsChanged |= (startdate != value); startdate = value; }
			
		}
		
		public DateTime EndDate
		{
			get { return enddate; }
			set { _bIsChanged |= (enddate != value); enddate = value; }
			
		}
		
		public string Remark
		{
			get { return remark; }
			set 
			{
			  if (value != null && value.Length > 500)
			    throw new ArgumentOutOfRangeException("Remark", "Remark value, cannot contain more than 500 characters");
			  _bIsChanged |= (remark != value); 
			  remark = value; 
			}
			
		}
		
		public DateTime Pubdate
		{
			get { return pubdate; }
			set { _bIsChanged |= (pubdate != value); pubdate = value; }
			
		}
		
		public DateTime CheckedDate
		{
			get { return checkeddate; }
			set { _bIsChanged |= (checkeddate != value); checkeddate = value; }
			
		}
		
		public string CheckName
		{
			get { return checkname; }
			set 
			{
			  if (value != null && value.Length > 50)
			    throw new ArgumentOutOfRangeException("CheckName", "CheckName value, cannot contain more than 50 characters");
			  _bIsChanged |= (checkname != value); 
			  checkname = value; 
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
	
	#region Custom ICollection interface for UserEvent 

	
	public interface IUserEventCollection : ICollection
	{
		UserEvent this[int index]{	get; set; }
		void Add(UserEvent pUserEvent);
		void Clear();
	}
	
	[Serializable]
	public class UserEventCollection : IUserEventCollection
	{
		private IList<UserEvent> _arrayInternal;

		public UserEventCollection()
		{
			_arrayInternal = new List<UserEvent>();
		}
		
		public UserEventCollection( IList<UserEvent> pSource )
		{
			_arrayInternal = pSource;
			if(_arrayInternal == null)
			{
				_arrayInternal = new List<UserEvent>();
			}
		}

		public UserEvent this[int index]
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
		public void CopyTo(Array array, int index){ _arrayInternal.CopyTo((UserEvent[])array, index); }
		public IEnumerator GetEnumerator() { return _arrayInternal.GetEnumerator(); }
		public void Add(UserEvent pUserEvent) { _arrayInternal.Add(pUserEvent); }
		public void Clear() { _arrayInternal.Clear(); }
		public IList<UserEvent> GetList() { return _arrayInternal; }
	 }
	
	#endregion
}
