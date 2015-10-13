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
	/// IActiveGroup interface for NHibernate mapped table 'ActiveGroup'.
	/// </summary>
	public interface IActiveGroup
	{
		#region Public Properties
		
		int Id
		{
			get ;
			set ;
			  
		}
		
		int ActiveId
		{
			get ;
			set ;
			  
		}
		
		int CaseId
		{
			get ;
			set ;
			  
		}
		
		int GradeId
		{
			get ;
			set ;
			  
		}
		
		int Pindex
		{
			get ;
			set ;
			  
		}
		
		string Title
		{
			get ;
			set ;
			  
		}
		
		int UserCount
		{
			get ;
			set ;
			  
		}
		
		int AdminUserId
		{
			get ;
			set ;
			  
		}
		
		int CheckUserId
		{
			get ;
			set ;
			  
		}
		
		bool Status
		{
			get ;
			set ;
			  
		}
		
		bool SexFlag
		{
			get ;
			set ;
			  
		}
		
		int Sex
		{
			get ;
			set ;
			  
		}
		
		bool IsDeleted { get; set; }
		bool IsChanged { get; set; }
		
		#endregion 
	}

	/// <summary>
	/// ActiveGroup object for NHibernate mapped table 'ActiveGroup'.
	/// </summary>
	[Serializable]
	public class ActiveGroup : IActiveGroup
	{
		#region Member Variables

		protected int id;
		protected int activeid;
		protected int caseid;
		protected int gradeid;
		protected int pindex;
		protected string title;
		protected int usercount;
		protected int adminuserid;
		protected int checkuserid;
		protected bool status;
		protected bool sexflag;
		protected int sex;
		protected bool _bIsDeleted;
		protected bool _bIsChanged;
		#endregion
		
		#region Constructors
		public ActiveGroup() {}
		
		public ActiveGroup(int pActiveId, int pCaseId, int pGradeId, int pPindex, string pTitle, int pUserCount, int pAdminUserId, int pCheckUserId, bool pStatus, bool pSexFlag, int pSex)
		{
			this.activeid = pActiveId; 
			this.caseid = pCaseId; 
			this.gradeid = pGradeId; 
			this.pindex = pPindex; 
			this.title = pTitle; 
			this.usercount = pUserCount; 
			this.adminuserid = pAdminUserId; 
			this.checkuserid = pCheckUserId; 
			this.status = pStatus; 
			this.sexflag = pSexFlag; 
			this.sex = pSex; 
		}
		
		public ActiveGroup(int pId)
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
		
		public int ActiveId
		{
			get { return activeid; }
			set { _bIsChanged |= (activeid != value); activeid = value; }
			
		}
		
		public int CaseId
		{
			get { return caseid; }
			set { _bIsChanged |= (caseid != value); caseid = value; }
			
		}
		
		public int GradeId
		{
			get { return gradeid; }
			set { _bIsChanged |= (gradeid != value); gradeid = value; }
			
		}
		
		public int Pindex
		{
			get { return pindex; }
			set { _bIsChanged |= (pindex != value); pindex = value; }
			
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
		
		public int UserCount
		{
			get { return usercount; }
			set { _bIsChanged |= (usercount != value); usercount = value; }
			
		}
		
		public int AdminUserId
		{
			get { return adminuserid; }
			set { _bIsChanged |= (adminuserid != value); adminuserid = value; }
			
		}
		
		public int CheckUserId
		{
			get { return checkuserid; }
			set { _bIsChanged |= (checkuserid != value); checkuserid = value; }
			
		}
		
		public bool Status
		{
			get { return status; }
			set { _bIsChanged |= (status != value); status = value; }
			
		}
		
		public bool SexFlag
		{
			get { return sexflag; }
			set { _bIsChanged |= (sexflag != value); sexflag = value; }
			
		}
		
		public int Sex
		{
			get { return sex; }
			set { _bIsChanged |= (sex != value); sex = value; }
			
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
	
	#region Custom ICollection interface for ActiveGroup 

	
	public interface IActiveGroupCollection : ICollection
	{
		ActiveGroup this[int index]{	get; set; }
		void Add(ActiveGroup pActiveGroup);
		void Clear();
	}
	
	[Serializable]
	public class ActiveGroupCollection : IActiveGroupCollection
	{
		private IList<ActiveGroup> _arrayInternal;

		public ActiveGroupCollection()
		{
			_arrayInternal = new List<ActiveGroup>();
		}
		
		public ActiveGroupCollection( IList<ActiveGroup> pSource )
		{
			_arrayInternal = pSource;
			if(_arrayInternal == null)
			{
				_arrayInternal = new List<ActiveGroup>();
			}
		}

		public ActiveGroup this[int index]
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
		public void CopyTo(Array array, int index){ _arrayInternal.CopyTo((ActiveGroup[])array, index); }
		public IEnumerator GetEnumerator() { return _arrayInternal.GetEnumerator(); }
		public void Add(ActiveGroup pActiveGroup) { _arrayInternal.Add(pActiveGroup); }
		public void Clear() { _arrayInternal.Clear(); }
		public IList<ActiveGroup> GetList() { return _arrayInternal; }
	 }
	
	#endregion
}
