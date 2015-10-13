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
	/// IUserClassSubjectData interface for NHibernate mapped table 'UserClassSubjectData'.
	/// </summary>
	public interface IUserClassSubjectData
	{
		#region Public Properties
		
		int Id
		{
			get ;
			set ;
			  
		}
		
		int UserId
		{
			get ;
			set ;
			  
		}
		
		int ClassId
		{
			get ;
			set ;
			  
		}
		
		int SubjectId
		{
			get ;
			set ;
			  
		}
		
		int Pindex
		{
			get ;
			set ;
			  
		}
		
		int WeekNum
		{
			get ;
			set ;
			  
		}
		
		int TermId
		{
			get ;
			set ;
			  
		}
		
		int ParentId
		{
			get ;
			set ;
			  
		}
		
		int EventCaseId
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
		
		bool UserChecked
		{
			get ;
			set ;
			  
		}
		
		bool IsDeleted { get; set; }
		bool IsChanged { get; set; }
		
		#endregion 
	}

	/// <summary>
	/// UserClassSubjectData object for NHibernate mapped table 'UserClassSubjectData'.
	/// </summary>
	[Serializable]
	public class UserClassSubjectData : IUserClassSubjectData
	{
		#region Member Variables

		protected int id;
		protected int userid;
		protected int classid;
		protected int subjectid;
		protected int pindex;
		protected int weeknum;
		protected int termid;
		protected int parentid;
		protected int eventcaseid;
		protected string remark;
		protected DateTime pubdate;
		protected bool userchecked;
		protected bool _bIsDeleted;
		protected bool _bIsChanged;
		#endregion
		
		#region Constructors
		public UserClassSubjectData() {}
		
		public UserClassSubjectData(int pUserId, int pClassId, int pSubjectId, int pPindex, int pWeekNum, int pTermId, int pParentId, int pEventCaseId, string pRemark, DateTime pPubdate, bool pUserChecked)
		{
			this.userid = pUserId; 
			this.classid = pClassId; 
			this.subjectid = pSubjectId; 
			this.pindex = pPindex; 
			this.weeknum = pWeekNum; 
			this.termid = pTermId; 
			this.parentid = pParentId; 
			this.eventcaseid = pEventCaseId; 
			this.remark = pRemark; 
			this.pubdate = pPubdate; 
			this.userchecked = pUserChecked; 
		}
		
		public UserClassSubjectData(int pId)
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
		
		public int UserId
		{
			get { return userid; }
			set { _bIsChanged |= (userid != value); userid = value; }
			
		}
		
		public int ClassId
		{
			get { return classid; }
			set { _bIsChanged |= (classid != value); classid = value; }
			
		}
		
		public int SubjectId
		{
			get { return subjectid; }
			set { _bIsChanged |= (subjectid != value); subjectid = value; }
			
		}
		
		public int Pindex
		{
			get { return pindex; }
			set { _bIsChanged |= (pindex != value); pindex = value; }
			
		}
		
		public int WeekNum
		{
			get { return weeknum; }
			set { _bIsChanged |= (weeknum != value); weeknum = value; }
			
		}
		
		public int TermId
		{
			get { return termid; }
			set { _bIsChanged |= (termid != value); termid = value; }
			
		}
		
		public int ParentId
		{
			get { return parentid; }
			set { _bIsChanged |= (parentid != value); parentid = value; }
			
		}
		
		public int EventCaseId
		{
			get { return eventcaseid; }
			set { _bIsChanged |= (eventcaseid != value); eventcaseid = value; }
			
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
		
		public bool UserChecked
		{
			get { return userchecked; }
			set { _bIsChanged |= (userchecked != value); userchecked = value; }
			
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
	
	#region Custom ICollection interface for UserClassSubjectData 

	
	public interface IUserClassSubjectDataCollection : ICollection
	{
		UserClassSubjectData this[int index]{	get; set; }
		void Add(UserClassSubjectData pUserClassSubjectData);
		void Clear();
	}
	
	[Serializable]
	public class UserClassSubjectDataCollection : IUserClassSubjectDataCollection
	{
		private IList<UserClassSubjectData> _arrayInternal;

		public UserClassSubjectDataCollection()
		{
			_arrayInternal = new List<UserClassSubjectData>();
		}
		
		public UserClassSubjectDataCollection( IList<UserClassSubjectData> pSource )
		{
			_arrayInternal = pSource;
			if(_arrayInternal == null)
			{
				_arrayInternal = new List<UserClassSubjectData>();
			}
		}

		public UserClassSubjectData this[int index]
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
		public void CopyTo(Array array, int index){ _arrayInternal.CopyTo((UserClassSubjectData[])array, index); }
		public IEnumerator GetEnumerator() { return _arrayInternal.GetEnumerator(); }
		public void Add(UserClassSubjectData pUserClassSubjectData) { _arrayInternal.Add(pUserClassSubjectData); }
		public void Clear() { _arrayInternal.Clear(); }
		public IList<UserClassSubjectData> GetList() { return _arrayInternal; }
	 }
	
	#endregion
}
