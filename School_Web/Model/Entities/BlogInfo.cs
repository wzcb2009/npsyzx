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
	/// IBlogInfo interface for NHibernate mapped table 'BlogInfo'.
	/// </summary>
	public interface IBlogInfo
	{
		#region Public Properties
		
		int Id
		{
			get ;
			set ;
			  
		}
		
		string Title
		{
			get ;
			set ;
			  
		}
		
		string SecondTitle
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
		
		string Nickname
		{
			get ;
			set ;
			  
		}
		
		string TempPath
		{
			get ;
			set ;
			  
		}
		
		string Username
		{
			get ;
			set ;
			  
		}
		
		string TrueName
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
		
		int LevelId
		{
			get ;
			set ;
			  
		}
		
		bool IsDeleted { get; set; }
		bool IsChanged { get; set; }
		
		#endregion 
	}

	/// <summary>
	/// BlogInfo object for NHibernate mapped table 'BlogInfo'.
	/// </summary>
	[Serializable]
	public class BlogInfo : IBlogInfo
	{
		#region Member Variables

		protected int id;
		protected string title;
		protected string secondtitle;
		protected string remark;
		protected int userid;
		protected string nickname;
		protected string temppath;
		protected string username;
		protected string truename;
		protected DateTime pubdate;
		protected int clicks;
		protected int levelid;
		protected bool _bIsDeleted;
		protected bool _bIsChanged;
		#endregion
		
		#region Constructors
		public BlogInfo() {}
		
		public BlogInfo(string pTitle, string pSecondTitle, string pRemark, int pUserId, string pNickname, string pTempPath, string pUsername, string pTrueName, DateTime pPubdate, int pClicks, int pLevelId)
		{
			this.title = pTitle; 
			this.secondtitle = pSecondTitle; 
			this.remark = pRemark; 
			this.userid = pUserId; 
			this.nickname = pNickname; 
			this.temppath = pTempPath; 
			this.username = pUsername; 
			this.truename = pTrueName; 
			this.pubdate = pPubdate; 
			this.clicks = pClicks; 
			this.levelid = pLevelId; 
		}
		
		public BlogInfo(int pId)
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
		
		public string SecondTitle
		{
			get { return secondtitle; }
			set 
			{
			  if (value != null && value.Length > 50)
			    throw new ArgumentOutOfRangeException("SecondTitle", "SecondTitle value, cannot contain more than 50 characters");
			  _bIsChanged |= (secondtitle != value); 
			  secondtitle = value; 
			}
			
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
		
		public int UserId
		{
			get { return userid; }
			set { _bIsChanged |= (userid != value); userid = value; }
			
		}
		
		public string Nickname
		{
			get { return nickname; }
			set 
			{
			  if (value != null && value.Length > 50)
			    throw new ArgumentOutOfRangeException("Nickname", "Nickname value, cannot contain more than 50 characters");
			  _bIsChanged |= (nickname != value); 
			  nickname = value; 
			}
			
		}
		
		public string TempPath
		{
			get { return temppath; }
			set 
			{
			  if (value != null && value.Length > 50)
			    throw new ArgumentOutOfRangeException("TempPath", "TempPath value, cannot contain more than 50 characters");
			  _bIsChanged |= (temppath != value); 
			  temppath = value; 
			}
			
		}
		
		public string Username
		{
			get { return username; }
			set 
			{
			  if (value != null && value.Length > 50)
			    throw new ArgumentOutOfRangeException("Username", "Username value, cannot contain more than 50 characters");
			  _bIsChanged |= (username != value); 
			  username = value; 
			}
			
		}
		
		public string TrueName
		{
			get { return truename; }
			set 
			{
			  if (value != null && value.Length > 50)
			    throw new ArgumentOutOfRangeException("TrueName", "TrueName value, cannot contain more than 50 characters");
			  _bIsChanged |= (truename != value); 
			  truename = value; 
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
		
		public int LevelId
		{
			get { return levelid; }
			set { _bIsChanged |= (levelid != value); levelid = value; }
			
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
	
	#region Custom ICollection interface for BlogInfo 

	
	public interface IBlogInfoCollection : ICollection
	{
		BlogInfo this[int index]{	get; set; }
		void Add(BlogInfo pBlogInfo);
		void Clear();
	}
	
	[Serializable]
	public class BlogInfoCollection : IBlogInfoCollection
	{
		private IList<BlogInfo> _arrayInternal;

		public BlogInfoCollection()
		{
			_arrayInternal = new List<BlogInfo>();
		}
		
		public BlogInfoCollection( IList<BlogInfo> pSource )
		{
			_arrayInternal = pSource;
			if(_arrayInternal == null)
			{
				_arrayInternal = new List<BlogInfo>();
			}
		}

		public BlogInfo this[int index]
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
		public void CopyTo(Array array, int index){ _arrayInternal.CopyTo((BlogInfo[])array, index); }
		public IEnumerator GetEnumerator() { return _arrayInternal.GetEnumerator(); }
		public void Add(BlogInfo pBlogInfo) { _arrayInternal.Add(pBlogInfo); }
		public void Clear() { _arrayInternal.Clear(); }
		public IList<BlogInfo> GetList() { return _arrayInternal; }
	 }
	
	#endregion
}
