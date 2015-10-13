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
	/// IWorkApply interface for NHibernate mapped table 'WorkApply'.
	/// </summary>
	public interface IWorkApply
	{
		#region Public Properties
		
		int Id
		{
			get ;
			set ;
			  
		}
		
		int TypeId
		{
			get ;
			set ;
			  
		}
		
		int CaseId
		{
			get ;
			set ;
			  
		}
		
		int UserId
		{
			get ;
			set ;
			  
		}
		
		string Author
		{
			get ;
			set ;
			  
		}
		
		string Tel
		{
			get ;
			set ;
			  
		}
		
		string Zw
		{
			get ;
			set ;
			  
		}
		
		DateTime Sd
		{
			get ;
			set ;
			  
		}
		
		DateTime Ed
		{
			get ;
			set ;
			  
		}
		
		int LessonCount
		{
			get ;
			set ;
			  
		}
		
		string EventInfo
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
		
		bool Status
		{
			get ;
			set ;
			  
		}
		
		int CheckUserId
		{
			get ;
			set ;
			  
		}
		
		string CheckInfo
		{
			get ;
			set ;
			  
		}
		
		bool UserChecked
		{
			get ;
			set ;
			  
		}
		
		DateTime CheckedPubdate
		{
			get ;
			set ;
			  
		}
		
		int CheckUserId2
		{
			get ;
			set ;
			  
		}
		
		string CheckInfo2
		{
			get ;
			set ;
			  
		}
		
		bool UserChecked2
		{
			get ;
			set ;
			  
		}
		
		DateTime CheckedPubdate2
		{
			get ;
			set ;
			  
		}
		
		bool IsDeleted { get; set; }
		bool IsChanged { get; set; }
		
		#endregion 
	}

	/// <summary>
	/// WorkApply object for NHibernate mapped table 'WorkApply'.
	/// </summary>
	[Serializable]
	public class WorkApply : IWorkApply
	{
		#region Member Variables

		protected int id;
		protected int typeid;
		protected int caseid;
		protected int userid;
		protected string author;
		protected string tel;
		protected string zw;
		protected DateTime sd;
		protected DateTime ed;
		protected int lessoncount;
		protected string eventinfo;
		protected string remark;
		protected DateTime pubdate;
		protected bool status;
		protected int checkuserid;
		protected string checkinfo;
		protected bool userchecked;
		protected DateTime checkedpubdate;
		protected int checkuserid2;
		protected string checkinfo2;
		protected bool userchecked2;
		protected DateTime checkedpubdate2;
		protected bool _bIsDeleted;
		protected bool _bIsChanged;
		#endregion
		
		#region Constructors
		public WorkApply() {}
		
		public WorkApply(int pTypeId, int pCaseId, int pUserId, string pAuthor, string pTel, string pZw, DateTime pSd, DateTime pEd, int pLessonCount, string pEventInfo, string pRemark, DateTime pPubdate, bool pStatus, int pCheckUserId, string pCheckInfo, bool pUserChecked, DateTime pCheckedPubdate, int pCheckUserId2, string pCheckInfo2, bool pUserChecked2, DateTime pCheckedPubdate2)
		{
			this.typeid = pTypeId; 
			this.caseid = pCaseId; 
			this.userid = pUserId; 
			this.author = pAuthor; 
			this.tel = pTel; 
			this.zw = pZw; 
			this.sd = pSd; 
			this.ed = pEd; 
			this.lessoncount = pLessonCount; 
			this.eventinfo = pEventInfo; 
			this.remark = pRemark; 
			this.pubdate = pPubdate; 
			this.status = pStatus; 
			this.checkuserid = pCheckUserId; 
			this.checkinfo = pCheckInfo; 
			this.userchecked = pUserChecked; 
			this.checkedpubdate = pCheckedPubdate; 
			this.checkuserid2 = pCheckUserId2; 
			this.checkinfo2 = pCheckInfo2; 
			this.userchecked2 = pUserChecked2; 
			this.checkedpubdate2 = pCheckedPubdate2; 
		}
		
		public WorkApply(DateTime pPubdate)
		{
			this.pubdate = pPubdate; 
		}
		
		public WorkApply(int pId)
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
		
		public int TypeId
		{
			get { return typeid; }
			set { _bIsChanged |= (typeid != value); typeid = value; }
			
		}
		
		public int CaseId
		{
			get { return caseid; }
			set { _bIsChanged |= (caseid != value); caseid = value; }
			
		}
		
		public int UserId
		{
			get { return userid; }
			set { _bIsChanged |= (userid != value); userid = value; }
			
		}
		
		public string Author
		{
			get { return author; }
			set 
			{
			  if (value != null && value.Length > 50)
			    throw new ArgumentOutOfRangeException("Author", "Author value, cannot contain more than 50 characters");
			  _bIsChanged |= (author != value); 
			  author = value; 
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
		
		public string Zw
		{
			get { return zw; }
			set 
			{
			  if (value != null && value.Length > 50)
			    throw new ArgumentOutOfRangeException("Zw", "Zw value, cannot contain more than 50 characters");
			  _bIsChanged |= (zw != value); 
			  zw = value; 
			}
			
		}
		
		public DateTime Sd
		{
			get { return sd; }
			set { _bIsChanged |= (sd != value); sd = value; }
			
		}
		
		public DateTime Ed
		{
			get { return ed; }
			set { _bIsChanged |= (ed != value); ed = value; }
			
		}
		
		public int LessonCount
		{
			get { return lessoncount; }
			set { _bIsChanged |= (lessoncount != value); lessoncount = value; }
			
		}
		
		public string EventInfo
		{
			get { return eventinfo; }
			set 
			{
			  if (value != null && value.Length > 4000)
			    throw new ArgumentOutOfRangeException("EventInfo", "EventInfo value, cannot contain more than 4000 characters");
			  _bIsChanged |= (eventinfo != value); 
			  eventinfo = value; 
			}
			
		}
		
		public string Remark
		{
			get { return remark; }
			set 
			{
			  if (value != null && value.Length > 4000)
			    throw new ArgumentOutOfRangeException("Remark", "Remark value, cannot contain more than 4000 characters");
			  _bIsChanged |= (remark != value); 
			  remark = value; 
			}
			
		}
		
		public DateTime Pubdate
		{
			get { return pubdate; }
			set { _bIsChanged |= (pubdate != value); pubdate = value; }
			
		}
		
		public bool Status
		{
			get { return status; }
			set { _bIsChanged |= (status != value); status = value; }
			
		}
		
		public int CheckUserId
		{
			get { return checkuserid; }
			set { _bIsChanged |= (checkuserid != value); checkuserid = value; }
			
		}
		
		public string CheckInfo
		{
			get { return checkinfo; }
			set 
			{
			  if (value != null && value.Length > 50)
			    throw new ArgumentOutOfRangeException("CheckInfo", "CheckInfo value, cannot contain more than 50 characters");
			  _bIsChanged |= (checkinfo != value); 
			  checkinfo = value; 
			}
			
		}
		
		public bool UserChecked
		{
			get { return userchecked; }
			set { _bIsChanged |= (userchecked != value); userchecked = value; }
			
		}
		
		public DateTime CheckedPubdate
		{
			get { return checkedpubdate; }
			set { _bIsChanged |= (checkedpubdate != value); checkedpubdate = value; }
			
		}
		
		public int CheckUserId2
		{
			get { return checkuserid2; }
			set { _bIsChanged |= (checkuserid2 != value); checkuserid2 = value; }
			
		}
		
		public string CheckInfo2
		{
			get { return checkinfo2; }
			set 
			{
			  if (value != null && value.Length > 50)
			    throw new ArgumentOutOfRangeException("CheckInfo2", "CheckInfo2 value, cannot contain more than 50 characters");
			  _bIsChanged |= (checkinfo2 != value); 
			  checkinfo2 = value; 
			}
			
		}
		
		public bool UserChecked2
		{
			get { return userchecked2; }
			set { _bIsChanged |= (userchecked2 != value); userchecked2 = value; }
			
		}
		
		public DateTime CheckedPubdate2
		{
			get { return checkedpubdate2; }
			set { _bIsChanged |= (checkedpubdate2 != value); checkedpubdate2 = value; }
			
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
	
	#region Custom ICollection interface for WorkApply 

	
	public interface IWorkApplyCollection : ICollection
	{
		WorkApply this[int index]{	get; set; }
		void Add(WorkApply pWorkApply);
		void Clear();
	}
	
	[Serializable]
	public class WorkApplyCollection : IWorkApplyCollection
	{
		private IList<WorkApply> _arrayInternal;

		public WorkApplyCollection()
		{
			_arrayInternal = new List<WorkApply>();
		}
		
		public WorkApplyCollection( IList<WorkApply> pSource )
		{
			_arrayInternal = pSource;
			if(_arrayInternal == null)
			{
				_arrayInternal = new List<WorkApply>();
			}
		}

		public WorkApply this[int index]
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
		public void CopyTo(Array array, int index){ _arrayInternal.CopyTo((WorkApply[])array, index); }
		public IEnumerator GetEnumerator() { return _arrayInternal.GetEnumerator(); }
		public void Add(WorkApply pWorkApply) { _arrayInternal.Add(pWorkApply); }
		public void Clear() { _arrayInternal.Clear(); }
		public IList<WorkApply> GetList() { return _arrayInternal; }
	 }
	
	#endregion
}
