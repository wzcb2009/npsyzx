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
	/// IUserClassSubject interface for NHibernate mapped table 'UserClassSubject'.
	/// </summary>
	public interface IUserClassSubject
	{
		#region Public Properties
		
		int Id
		{
			get ;
			set ;
			  
		}
		
		int TermId
		{
			get ;
			set ;
			  
		}
		
		int Classid
		{
			get ;
			set ;
			  
		}
		
		int GradeId
		{
			get ;
			set ;
			  
		}
		
		int SubjectId
		{
			get ;
			set ;
			  
		}
		
		int UserId
		{
			get ;
			set ;
			  
		}
		
		bool Status
		{
			get ;
			set ;
			  
		}
		
		DateTime Pubdate
		{
			get ;
			set ;
			  
		}
		
		bool IsAdmin
		{
			get ;
			set ;
			  
		}
		
		bool IsDeleted { get; set; }
		bool IsChanged { get; set; }
		
		#endregion 
	}

	/// <summary>
	/// UserClassSubject object for NHibernate mapped table 'UserClassSubject'.
	/// </summary>
	[Serializable]
	public class UserClassSubject : IUserClassSubject
	{
		#region Member Variables

		protected int id;
		protected int termid;
		protected int classid;
		protected int gradeid;
		protected int subjectid;
		protected int userid;
		protected bool status;
		protected DateTime pubdate;
		protected bool isadmin;
		protected bool _bIsDeleted;
		protected bool _bIsChanged;
		#endregion
		
		#region Constructors
		public UserClassSubject() {}
		
		public UserClassSubject(int pTermId, int pClassid, int pGradeId, int pSubjectId, int pUserId, bool pStatus, DateTime pPubdate, bool pIsAdmin)
		{
			this.termid = pTermId; 
			this.classid = pClassid; 
			this.gradeid = pGradeId; 
			this.subjectid = pSubjectId; 
			this.userid = pUserId; 
			this.status = pStatus; 
			this.pubdate = pPubdate; 
			this.isadmin = pIsAdmin; 
		}
		
		public UserClassSubject(int pId)
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
		
		public int TermId
		{
			get { return termid; }
			set { _bIsChanged |= (termid != value); termid = value; }
			
		}
		
		public int Classid
		{
			get { return classid; }
			set { _bIsChanged |= (classid != value); classid = value; }
			
		}
		
		public int GradeId
		{
			get { return gradeid; }
			set { _bIsChanged |= (gradeid != value); gradeid = value; }
			
		}
		
		public int SubjectId
		{
			get { return subjectid; }
			set { _bIsChanged |= (subjectid != value); subjectid = value; }
			
		}
		
		public int UserId
		{
			get { return userid; }
			set { _bIsChanged |= (userid != value); userid = value; }
			
		}
		
		public bool Status
		{
			get { return status; }
			set { _bIsChanged |= (status != value); status = value; }
			
		}
		
		public DateTime Pubdate
		{
			get { return pubdate; }
			set { _bIsChanged |= (pubdate != value); pubdate = value; }
			
		}
		
		public bool IsAdmin
		{
			get { return isadmin; }
			set { _bIsChanged |= (isadmin != value); isadmin = value; }
			
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
	
	#region Custom ICollection interface for UserClassSubject 

	
	public interface IUserClassSubjectCollection : ICollection
	{
		UserClassSubject this[int index]{	get; set; }
		void Add(UserClassSubject pUserClassSubject);
		void Clear();
	}
	
	[Serializable]
	public class UserClassSubjectCollection : IUserClassSubjectCollection
	{
		private IList<UserClassSubject> _arrayInternal;

		public UserClassSubjectCollection()
		{
			_arrayInternal = new List<UserClassSubject>();
		}
		
		public UserClassSubjectCollection( IList<UserClassSubject> pSource )
		{
			_arrayInternal = pSource;
			if(_arrayInternal == null)
			{
				_arrayInternal = new List<UserClassSubject>();
			}
		}

		public UserClassSubject this[int index]
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
		public void CopyTo(Array array, int index){ _arrayInternal.CopyTo((UserClassSubject[])array, index); }
		public IEnumerator GetEnumerator() { return _arrayInternal.GetEnumerator(); }
		public void Add(UserClassSubject pUserClassSubject) { _arrayInternal.Add(pUserClassSubject); }
		public void Clear() { _arrayInternal.Clear(); }
		public IList<UserClassSubject> GetList() { return _arrayInternal; }
	 }
	
	#endregion
}
