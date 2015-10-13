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
	/// IComment interface for NHibernate mapped table 'Comment'.
	/// </summary>
	public interface IComment
	{
		#region Public Properties
		
		int Id
		{
			get ;
			set ;
			  
		}
		
		int CaseId
		{
			get ;
			set ;
			  
		}
		
		int Userid
		{
			get ;
			set ;
			  
		}
		
		int ParentId
		{
			get ;
			set ;
			  
		}
		
		string Content
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
		
		int Cent
		{
			get ;
			set ;
			  
		}
		
		int ByUserId
		{
			get ;
			set ;
			  
		}
		
		bool IsDeleted { get; set; }
		bool IsChanged { get; set; }
		
		#endregion 
	}

	/// <summary>
	/// Comment object for NHibernate mapped table 'Comment'.
	/// </summary>
	[Serializable]
	public class Comment : IComment
	{
		#region Member Variables

		protected int id;
		protected int caseid;
		protected int userid;
		protected int parentid;
		protected string content;
		protected DateTime pubdate;
		protected bool status;
		protected int cent;
		protected int byuserid;
		protected bool _bIsDeleted;
		protected bool _bIsChanged;
		#endregion
		
		#region Constructors
		public Comment() {}
		
		public Comment(int pCaseId, int pUserid, int pParentId, string pContent, DateTime pPubdate, bool pStatus, int pCent, int pByUserId)
		{
			this.caseid = pCaseId; 
			this.userid = pUserid; 
			this.parentid = pParentId; 
			this.content = pContent; 
			this.pubdate = pPubdate; 
			this.status = pStatus; 
			this.cent = pCent; 
			this.byuserid = pByUserId; 
		}
		
		public Comment(int pId)
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
		
		public int CaseId
		{
			get { return caseid; }
			set { _bIsChanged |= (caseid != value); caseid = value; }
			
		}
		
		public int Userid
		{
			get { return userid; }
			set { _bIsChanged |= (userid != value); userid = value; }
			
		}
		
		public int ParentId
		{
			get { return parentid; }
			set { _bIsChanged |= (parentid != value); parentid = value; }
			
		}
		
		public string Content
		{
			get { return content; }
			set 
			{
			  if (value != null && value.Length > 1073741823)
			    throw new ArgumentOutOfRangeException("Content", "Content value, cannot contain more than 1073741823 characters");
			  _bIsChanged |= (content != value); 
			  content = value; 
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
		
		public int Cent
		{
			get { return cent; }
			set { _bIsChanged |= (cent != value); cent = value; }
			
		}
		
		public int ByUserId
		{
			get { return byuserid; }
			set { _bIsChanged |= (byuserid != value); byuserid = value; }
			
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
	
	#region Custom ICollection interface for Comment 

	
	public interface ICommentCollection : ICollection
	{
		Comment this[int index]{	get; set; }
		void Add(Comment pComment);
		void Clear();
	}
	
	[Serializable]
	public class CommentCollection : ICommentCollection
	{
		private IList<Comment> _arrayInternal;

		public CommentCollection()
		{
			_arrayInternal = new List<Comment>();
		}
		
		public CommentCollection( IList<Comment> pSource )
		{
			_arrayInternal = pSource;
			if(_arrayInternal == null)
			{
				_arrayInternal = new List<Comment>();
			}
		}

		public Comment this[int index]
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
		public void CopyTo(Array array, int index){ _arrayInternal.CopyTo((Comment[])array, index); }
		public IEnumerator GetEnumerator() { return _arrayInternal.GetEnumerator(); }
		public void Add(Comment pComment) { _arrayInternal.Add(pComment); }
		public void Clear() { _arrayInternal.Clear(); }
		public IList<Comment> GetList() { return _arrayInternal; }
	 }
	
	#endregion
}
