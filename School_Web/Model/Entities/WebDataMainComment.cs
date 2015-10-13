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
	/// IWebDataMainComment interface for NHibernate mapped table 'Web_data_main_comment'.
	/// </summary>
	public interface IWebDataMainComment
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
		
		string Author
		{
			get ;
			set ;
			  
		}
		
		int Teacherid
		{
			get ;
			set ;
			  
		}
		
		int Studentid
		{
			get ;
			set ;
			  
		}
		
		string Title
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
		
		int Clicks
		{
			get ;
			set ;
			  
		}
		
		bool Status
		{
			get ;
			set ;
			  
		}
		
		bool IsDeleted { get; set; }
		bool IsChanged { get; set; }
		
		#endregion 
	}

	/// <summary>
	/// WebDataMainComment object for NHibernate mapped table 'Web_data_main_comment'.
	/// </summary>
	[Serializable]
	public class WebDataMainComment : IWebDataMainComment
	{
		#region Member Variables

		protected int id;
		protected int parentid;
		protected string author;
		protected int teacherid;
		protected int studentid;
		protected string title;
		protected string content;
		protected DateTime pubdate;
		protected int clicks;
		protected bool status;
		protected bool _bIsDeleted;
		protected bool _bIsChanged;
		#endregion
		
		#region Constructors
		public WebDataMainComment() {}
		
		public WebDataMainComment(int pId, int pParentid, string pAuthor, int pTeacherid, int pStudentid, string pTitle, string pContent, DateTime pPubdate, int pClicks, bool pStatus)
		{
			this.id = pId; 
			this.parentid = pParentid; 
			this.author = pAuthor; 
			this.teacherid = pTeacherid; 
			this.studentid = pStudentid; 
			this.title = pTitle; 
			this.content = pContent; 
			this.pubdate = pPubdate; 
			this.clicks = pClicks; 
			this.status = pStatus; 
		}
		
		public WebDataMainComment(int pId)
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
		
		public int Teacherid
		{
			get { return teacherid; }
			set { _bIsChanged |= (teacherid != value); teacherid = value; }
			
		}
		
		public int Studentid
		{
			get { return studentid; }
			set { _bIsChanged |= (studentid != value); studentid = value; }
			
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
		
		public int Clicks
		{
			get { return clicks; }
			set { _bIsChanged |= (clicks != value); clicks = value; }
			
		}
		
		public bool Status
		{
			get { return status; }
			set { _bIsChanged |= (status != value); status = value; }
			
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
	
	#region Custom ICollection interface for WebDataMainComment 

	
	public interface IWebDataMainCommentCollection : ICollection
	{
		WebDataMainComment this[int index]{	get; set; }
		void Add(WebDataMainComment pWebDataMainComment);
		void Clear();
	}
	
	[Serializable]
	public class WebDataMainCommentCollection : IWebDataMainCommentCollection
	{
		private IList<WebDataMainComment> _arrayInternal;

		public WebDataMainCommentCollection()
		{
			_arrayInternal = new List<WebDataMainComment>();
		}
		
		public WebDataMainCommentCollection( IList<WebDataMainComment> pSource )
		{
			_arrayInternal = pSource;
			if(_arrayInternal == null)
			{
				_arrayInternal = new List<WebDataMainComment>();
			}
		}

		public WebDataMainComment this[int index]
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
		public void CopyTo(Array array, int index){ _arrayInternal.CopyTo((WebDataMainComment[])array, index); }
		public IEnumerator GetEnumerator() { return _arrayInternal.GetEnumerator(); }
		public void Add(WebDataMainComment pWebDataMainComment) { _arrayInternal.Add(pWebDataMainComment); }
		public void Clear() { _arrayInternal.Clear(); }
		public IList<WebDataMainComment> GetList() { return _arrayInternal; }
	 }
	
	#endregion
}
