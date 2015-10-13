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
	/// IActive interface for NHibernate mapped table 'Active'.
	/// </summary>
	public interface IActive
	{
		#region Public Properties
		
		int Id
		{
			get ;
			set ;
			  
		}
		
		int Parentid
		{
			get ;
			set ;
			  
		}
		
		string OrderCode
		{
			get ;
			set ;
			  
		}
		
		int Termid
		{
			get ;
			set ;
			  
		}
		
		int Caseid
		{
			get ;
			set ;
			  
		}
		
		int GroupId
		{
			get ;
			set ;
			  
		}
		
		int TypeId
		{
			get ;
			set ;
			  
		}
		
		string Title
		{
			get ;
			set ;
			  
		}
		
		string Remark
		{
			get ;
			set ;
			  
		}
		
		int UserId
		{
			get ;
			set ;
			  
		}
		
		string CaseIdlist
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
		
		int LessonPindex
		{
			get ;
			set ;
			  
		}
		
		bool Status
		{
			get ;
			set ;
			  
		}
		
		string Picurl
		{
			get ;
			set ;
			  
		}
		
		bool IsDeleted { get; set; }
		bool IsChanged { get; set; }
		
		#endregion 
	}

	/// <summary>
	/// Active object for NHibernate mapped table 'Active'.
	/// </summary>
	[Serializable]
	public class Active : IActive
	{
		#region Member Variables

		protected int id;
		protected int parentid;
		protected string ordercode;
		protected int termid;
		protected int caseid;
		protected int groupid;
		protected int typeid;
		protected string title;
		protected string remark;
		protected int userid;
		protected string caseidlist;
		protected DateTime startdate;
		protected DateTime enddate;
		protected int lessonpindex;
		protected bool status;
		protected string picurl;
		protected bool _bIsDeleted;
		protected bool _bIsChanged;
		#endregion
		
		#region Constructors
		public Active() {}
		
		public Active(int pParentid, string pOrderCode, int pTermid, int pCaseid, int pGroupId, int pTypeId, string pTitle, string pRemark, int pUserId, string pCaseIdlist, DateTime pStartDate, DateTime pEndDate, int pLessonPindex, bool pStatus, string pPicurl)
		{
			this.parentid = pParentid; 
			this.ordercode = pOrderCode; 
			this.termid = pTermid; 
			this.caseid = pCaseid; 
			this.groupid = pGroupId; 
			this.typeid = pTypeId; 
			this.title = pTitle; 
			this.remark = pRemark; 
			this.userid = pUserId; 
			this.caseidlist = pCaseIdlist; 
			this.startdate = pStartDate; 
			this.enddate = pEndDate; 
			this.lessonpindex = pLessonPindex; 
			this.status = pStatus; 
			this.picurl = pPicurl; 
		}
		
		public Active(int pId)
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
		
		public int Parentid
		{
			get { return parentid; }
			set { _bIsChanged |= (parentid != value); parentid = value; }
			
		}
		
		public string OrderCode
		{
			get { return ordercode; }
			set 
			{
			  if (value != null && value.Length > 50)
			    throw new ArgumentOutOfRangeException("OrderCode", "OrderCode value, cannot contain more than 50 characters");
			  _bIsChanged |= (ordercode != value); 
			  ordercode = value; 
			}
			
		}
		
		public int Termid
		{
			get { return termid; }
			set { _bIsChanged |= (termid != value); termid = value; }
			
		}
		
		public int Caseid
		{
			get { return caseid; }
			set { _bIsChanged |= (caseid != value); caseid = value; }
			
		}
		
		public int GroupId
		{
			get { return groupid; }
			set { _bIsChanged |= (groupid != value); groupid = value; }
			
		}
		
		public int TypeId
		{
			get { return typeid; }
			set { _bIsChanged |= (typeid != value); typeid = value; }
			
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
		
		public string Remark
		{
			get { return remark; }
			set 
			{
			  if (value != null && value.Length > 1073741823)
			    throw new ArgumentOutOfRangeException("Remark", "Remark value, cannot contain more than 1073741823 characters");
			  _bIsChanged |= (remark != value); 
			  remark = value; 
			}
			
		}
		
		public int UserId
		{
			get { return userid; }
			set { _bIsChanged |= (userid != value); userid = value; }
			
		}
		
		public string CaseIdlist
		{
			get { return caseidlist; }
			set 
			{
			  if (value != null && value.Length > 500)
			    throw new ArgumentOutOfRangeException("CaseIdlist", "CaseIdlist value, cannot contain more than 500 characters");
			  _bIsChanged |= (caseidlist != value); 
			  caseidlist = value; 
			}
			
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
		
		public int LessonPindex
		{
			get { return lessonpindex; }
			set { _bIsChanged |= (lessonpindex != value); lessonpindex = value; }
			
		}
		
		public bool Status
		{
			get { return status; }
			set { _bIsChanged |= (status != value); status = value; }
			
		}
		
		public string Picurl
		{
			get { return picurl; }
			set 
			{
			  if (value != null && value.Length > 250)
			    throw new ArgumentOutOfRangeException("Picurl", "Picurl value, cannot contain more than 250 characters");
			  _bIsChanged |= (picurl != value); 
			  picurl = value; 
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
	
	#region Custom ICollection interface for Active 

	
	public interface IActiveCollection : ICollection
	{
		Active this[int index]{	get; set; }
		void Add(Active pActive);
		void Clear();
	}
	
	[Serializable]
	public class ActiveCollection : IActiveCollection
	{
		private IList<Active> _arrayInternal;

		public ActiveCollection()
		{
			_arrayInternal = new List<Active>();
		}
		
		public ActiveCollection( IList<Active> pSource )
		{
			_arrayInternal = pSource;
			if(_arrayInternal == null)
			{
				_arrayInternal = new List<Active>();
			}
		}

		public Active this[int index]
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
		public void CopyTo(Array array, int index){ _arrayInternal.CopyTo((Active[])array, index); }
		public IEnumerator GetEnumerator() { return _arrayInternal.GetEnumerator(); }
		public void Add(Active pActive) { _arrayInternal.Add(pActive); }
		public void Clear() { _arrayInternal.Clear(); }
		public IList<Active> GetList() { return _arrayInternal; }
	 }
	
	#endregion
}
