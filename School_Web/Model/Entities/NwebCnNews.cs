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
	/// INwebCnNews interface for NHibernate mapped table 'NwebCn_News'.
	/// </summary>
	public interface INwebCnNews
	{
		#region Public Properties
		
		int Id
		{
			get ;
			set ;
			  
		}
		
		string NewsName
		{
			get ;
			set ;
			  
		}
		
		bool ViewFlag
		{
			get ;
			set ;
			  
		}
		
		int Sortid
		{
			get ;
			set ;
			  
		}
		
		string SortPath
		{
			get ;
			set ;
			  
		}
		
		string Groupid
		{
			get ;
			set ;
			  
		}
		
		string Exclusive
		{
			get ;
			set ;
			  
		}
		
		bool NoticeFlag
		{
			get ;
			set ;
			  
		}
		
		string Source
		{
			get ;
			set ;
			  
		}
		
		string NewsPic
		{
			get ;
			set ;
			  
		}
		
		string Content
		{
			get ;
			set ;
			  
		}
		
		int ClickNumber
		{
			get ;
			set ;
			  
		}
		
		DateTime AddTime
		{
			get ;
			set ;
			  
		}
		
		bool IsDeleted { get; set; }
		bool IsChanged { get; set; }
		
		#endregion 
	}

	/// <summary>
	/// NwebCnNews object for NHibernate mapped table 'NwebCn_News'.
	/// </summary>
	[Serializable]
	public class NwebCnNews : INwebCnNews
	{
		#region Member Variables

		protected int id;
		protected string newsname;
		protected bool viewflag;
		protected int sortid;
		protected string sortpath;
		protected string groupid;
		protected string exclusive;
		protected bool noticeflag;
		protected string source;
		protected string newspic;
		protected string content;
		protected int clicknumber;
		protected DateTime addtime;
		protected bool _bIsDeleted;
		protected bool _bIsChanged;
		#endregion
		
		#region Constructors
		public NwebCnNews() {}
		
		public NwebCnNews(int pId, string pNewsName, bool pViewFlag, int pSortid, string pSortPath, string pGroupid, string pExclusive, bool pNoticeFlag, string pSource, string pNewsPic, string pContent, int pClickNumber, DateTime pAddTime)
		{
			this.id = pId; 
			this.newsname = pNewsName; 
			this.viewflag = pViewFlag; 
			this.sortid = pSortid; 
			this.sortpath = pSortPath; 
			this.groupid = pGroupid; 
			this.exclusive = pExclusive; 
			this.noticeflag = pNoticeFlag; 
			this.source = pSource; 
			this.newspic = pNewsPic; 
			this.content = pContent; 
			this.clicknumber = pClickNumber; 
			this.addtime = pAddTime; 
		}
		
		public NwebCnNews(int pId, bool pViewFlag, bool pNoticeFlag)
		{
			this.id = pId; 
			this.viewflag = pViewFlag; 
			this.noticeflag = pNoticeFlag; 
		}
		
		#endregion
		
		#region Public Properties
		
		public int Id
		{
			get { return id; }
			set { _bIsChanged |= (id != value); id = value; }
			
		}
		
		public string NewsName
		{
			get { return newsname; }
			set 
			{
			  if (value != null && value.Length > 200)
			    throw new ArgumentOutOfRangeException("NewsName", "NewsName value, cannot contain more than 200 characters");
			  _bIsChanged |= (newsname != value); 
			  newsname = value; 
			}
			
		}
		
		public bool ViewFlag
		{
			get { return viewflag; }
			set { _bIsChanged |= (viewflag != value); viewflag = value; }
			
		}
		
		public int Sortid
		{
			get { return sortid; }
			set { _bIsChanged |= (sortid != value); sortid = value; }
			
		}
		
		public string SortPath
		{
			get { return sortpath; }
			set 
			{
			  if (value != null && value.Length > 50)
			    throw new ArgumentOutOfRangeException("SortPath", "SortPath value, cannot contain more than 50 characters");
			  _bIsChanged |= (sortpath != value); 
			  sortpath = value; 
			}
			
		}
		
		public string Groupid
		{
			get { return groupid; }
			set 
			{
			  if (value != null && value.Length > 18)
			    throw new ArgumentOutOfRangeException("Groupid", "Groupid value, cannot contain more than 18 characters");
			  _bIsChanged |= (groupid != value); 
			  groupid = value; 
			}
			
		}
		
		public string Exclusive
		{
			get { return exclusive; }
			set 
			{
			  if (value != null && value.Length > 2)
			    throw new ArgumentOutOfRangeException("Exclusive", "Exclusive value, cannot contain more than 2 characters");
			  _bIsChanged |= (exclusive != value); 
			  exclusive = value; 
			}
			
		}
		
		public bool NoticeFlag
		{
			get { return noticeflag; }
			set { _bIsChanged |= (noticeflag != value); noticeflag = value; }
			
		}
		
		public string Source
		{
			get { return source; }
			set 
			{
			  if (value != null && value.Length > 100)
			    throw new ArgumentOutOfRangeException("Source", "Source value, cannot contain more than 100 characters");
			  _bIsChanged |= (source != value); 
			  source = value; 
			}
			
		}
		
		public string NewsPic
		{
			get { return newspic; }
			set 
			{
			  if (value != null && value.Length > 255)
			    throw new ArgumentOutOfRangeException("NewsPic", "NewsPic value, cannot contain more than 255 characters");
			  _bIsChanged |= (newspic != value); 
			  newspic = value; 
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
		
		public int ClickNumber
		{
			get { return clicknumber; }
			set { _bIsChanged |= (clicknumber != value); clicknumber = value; }
			
		}
		
		public DateTime AddTime
		{
			get { return addtime; }
			set { _bIsChanged |= (addtime != value); addtime = value; }
			
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
	
	#region Custom ICollection interface for NwebCnNews 

	
	public interface INwebCnNewsCollection : ICollection
	{
		NwebCnNews this[int index]{	get; set; }
		void Add(NwebCnNews pNwebCnNews);
		void Clear();
	}
	
	[Serializable]
	public class NwebCnNewsCollection : INwebCnNewsCollection
	{
		private IList<NwebCnNews> _arrayInternal;

		public NwebCnNewsCollection()
		{
			_arrayInternal = new List<NwebCnNews>();
		}
		
		public NwebCnNewsCollection( IList<NwebCnNews> pSource )
		{
			_arrayInternal = pSource;
			if(_arrayInternal == null)
			{
				_arrayInternal = new List<NwebCnNews>();
			}
		}

		public NwebCnNews this[int index]
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
		public void CopyTo(Array array, int index){ _arrayInternal.CopyTo((NwebCnNews[])array, index); }
		public IEnumerator GetEnumerator() { return _arrayInternal.GetEnumerator(); }
		public void Add(NwebCnNews pNwebCnNews) { _arrayInternal.Add(pNwebCnNews); }
		public void Clear() { _arrayInternal.Clear(); }
		public IList<NwebCnNews> GetList() { return _arrayInternal; }
	 }
	
	#endregion
}
