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
	/// IWebDataMain interface for NHibernate mapped table 'Web_Data_main'.
	/// </summary>
	public interface IWebDataMain
	{
		#region Public Properties
		
		int Id
		{
			get ;
			set ;
			  
		}
		
		int Pindex
		{
			get ;
			set ;
			  
		}
		
		int Caseid
		{
			get ;
			set ;
			  
		}
		
		string Showstyle
		{
			get ;
			set ;
			  
		}
		
		int Userid
		{
			get ;
			set ;
			  
		}
		
		bool Status
		{
			get ;
			set ;
			  
		}
		
		int Zytypeid
		{
			get ;
			set ;
			  
		}
		
		int Browcount
		{
			get ;
			set ;
			  
		}
		
		bool UserRight
		{
			get ;
			set ;
			  
		}
		
		int CopyId
		{
			get ;
			set ;
			  
		}
		
		DateTime Pubdate
		{
			get ;
			set ;
			  
		}
		
		DateTime UpdateDate
		{
			get ;
			set ;
			  
		}
		
		string Title
		{
			get ;
			set ;
			  
		}
		
		string Attachment
		{
			get ;
			set ;
			  
		}
		
		string Attachsize
		{
			get ;
			set ;
			  
		}
		
		string AttachData
		{
			get ;
			set ;
			  
		}
		
		string Content
		{
			get ;
			set ;
			  
		}
		
		string Author
		{
			get ;
			set ;
			  
		}
		
		bool Cmd
		{
			get ;
			set ;
			  
		}
		
		int Termid
		{
			get ;
			set ;
			  
		}
		
		int Subjectid
		{
			get ;
			set ;
			  
		}
		
		bool IsDeleted { get; set; }
		bool IsChanged { get; set; }
		
		#endregion 
	}

	/// <summary>
	/// WebDataMain object for NHibernate mapped table 'Web_Data_main'.
	/// </summary>
	[Serializable]
	public class WebDataMain : IWebDataMain
	{
		#region Member Variables

		protected int id;
		protected int pindex;
		protected int caseid;
		protected string showstyle;
		protected int userid;
		protected bool status;
		protected int zytypeid;
		protected int browcount;
		protected bool userright;
		protected int copyid;
		protected DateTime pubdate;
		protected DateTime updatedate;
		protected string title;
		protected string attachment;
		protected string attachsize;
		protected string attachdata;
		protected string content;
		protected string author;
		protected bool cmd;
		protected int termid;
		protected int subjectid;
		protected bool _bIsDeleted;
		protected bool _bIsChanged;
		#endregion
		
		#region Constructors
		public WebDataMain() {}
		
		public WebDataMain(int pPindex, int pCaseid, string pShowstyle, int pUserid, bool pStatus, int pZytypeid, int pBrowcount, bool pUserRight, int pCopyId, DateTime pPubdate, DateTime pUpdateDate, string pTitle, string pAttachment, string pAttachsize, string pAttachData, string pContent, string pAuthor, bool pCmd, int pTermid, int pSubjectid)
		{
			this.pindex = pPindex; 
			this.caseid = pCaseid; 
			this.showstyle = pShowstyle; 
			this.userid = pUserid; 
			this.status = pStatus; 
			this.zytypeid = pZytypeid; 
			this.browcount = pBrowcount; 
			this.userright = pUserRight; 
			this.copyid = pCopyId; 
			this.pubdate = pPubdate; 
			this.updatedate = pUpdateDate; 
			this.title = pTitle; 
			this.attachment = pAttachment; 
			this.attachsize = pAttachsize; 
			this.attachdata = pAttachData; 
			this.content = pContent; 
			this.author = pAuthor; 
			this.cmd = pCmd; 
			this.termid = pTermid; 
			this.subjectid = pSubjectid; 
		}
		
		public WebDataMain(int pId)
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
		
		public int Pindex
		{
			get { return pindex; }
			set { _bIsChanged |= (pindex != value); pindex = value; }
			
		}
		
		public int Caseid
		{
			get { return caseid; }
			set { _bIsChanged |= (caseid != value); caseid = value; }
			
		}
		
		public string Showstyle
		{
			get { return showstyle; }
			set 
			{
			  if (value != null && value.Length > 50)
			    throw new ArgumentOutOfRangeException("Showstyle", "Showstyle value, cannot contain more than 50 characters");
			  _bIsChanged |= (showstyle != value); 
			  showstyle = value; 
			}
			
		}
		
		public int Userid
		{
			get { return userid; }
			set { _bIsChanged |= (userid != value); userid = value; }
			
		}
		
		public bool Status
		{
			get { return status; }
			set { _bIsChanged |= (status != value); status = value; }
			
		}
		
		public int Zytypeid
		{
			get { return zytypeid; }
			set { _bIsChanged |= (zytypeid != value); zytypeid = value; }
			
		}
		
		public int Browcount
		{
			get { return browcount; }
			set { _bIsChanged |= (browcount != value); browcount = value; }
			
		}
		
		public bool UserRight
		{
			get { return userright; }
			set { _bIsChanged |= (userright != value); userright = value; }
			
		}
		
		public int CopyId
		{
			get { return copyid; }
			set { _bIsChanged |= (copyid != value); copyid = value; }
			
		}
		
		public DateTime Pubdate
		{
			get { return pubdate; }
			set { _bIsChanged |= (pubdate != value); pubdate = value; }
			
		}
		
		public DateTime UpdateDate
		{
			get { return updatedate; }
			set { _bIsChanged |= (updatedate != value); updatedate = value; }
			
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
		
		public string Attachment
		{
			get { return attachment; }
			set 
			{
			  if (value != null && value.Length > 250)
			    throw new ArgumentOutOfRangeException("Attachment", "Attachment value, cannot contain more than 250 characters");
			  _bIsChanged |= (attachment != value); 
			  attachment = value; 
			}
			
		}
		
		public string Attachsize
		{
			get { return attachsize; }
			set 
			{
			  if (value != null && value.Length > 50)
			    throw new ArgumentOutOfRangeException("Attachsize", "Attachsize value, cannot contain more than 50 characters");
			  _bIsChanged |= (attachsize != value); 
			  attachsize = value; 
			}
			
		}
		
		public string AttachData
		{
			get { return attachdata; }
			set 
			{
			  if (value != null && value.Length > 250)
			    throw new ArgumentOutOfRangeException("AttachData", "AttachData value, cannot contain more than 250 characters");
			  _bIsChanged |= (attachdata != value); 
			  attachdata = value; 
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
		
		public bool Cmd
		{
			get { return cmd; }
			set { _bIsChanged |= (cmd != value); cmd = value; }
			
		}
		
		public int Termid
		{
			get { return termid; }
			set { _bIsChanged |= (termid != value); termid = value; }
			
		}
		
		public int Subjectid
		{
			get { return subjectid; }
			set { _bIsChanged |= (subjectid != value); subjectid = value; }
			
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
	
	#region Custom ICollection interface for WebDataMain 

	
	public interface IWebDataMainCollection : ICollection
	{
		WebDataMain this[int index]{	get; set; }
		void Add(WebDataMain pWebDataMain);
		void Clear();
	}
	
	[Serializable]
	public class WebDataMainCollection : IWebDataMainCollection
	{
		private IList<WebDataMain> _arrayInternal;

		public WebDataMainCollection()
		{
			_arrayInternal = new List<WebDataMain>();
		}
		
		public WebDataMainCollection( IList<WebDataMain> pSource )
		{
			_arrayInternal = pSource;
			if(_arrayInternal == null)
			{
				_arrayInternal = new List<WebDataMain>();
			}
		}

		public WebDataMain this[int index]
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
		public void CopyTo(Array array, int index){ _arrayInternal.CopyTo((WebDataMain[])array, index); }
		public IEnumerator GetEnumerator() { return _arrayInternal.GetEnumerator(); }
		public void Add(WebDataMain pWebDataMain) { _arrayInternal.Add(pWebDataMain); }
		public void Clear() { _arrayInternal.Clear(); }
		public IList<WebDataMain> GetList() { return _arrayInternal; }
	 }
	
	#endregion
}
