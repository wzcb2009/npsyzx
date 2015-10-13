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
	/// ILzpjTermZyList interface for NHibernate mapped table 'lzpj_Term_zy_list'.
	/// </summary>
	public interface ILzpjTermZyList
	{
		#region Public Properties
		
		int Id
		{
			get ;
			set ;
			  
		}
		
		int Userid
		{
			get ;
			set ;
			  
		}
		
		int JdId
		{
			get ;
			set ;
			  
		}
		
		string Title
		{
			get ;
			set ;
			  
		}
		
		string Filepath
		{
			get ;
			set ;
			  
		}
		
		string Filetype
		{
			get ;
			set ;
			  
		}
		
		double Filesize
		{
			get ;
			set ;
			  
		}
		
		int ZyTypeid
		{
			get ;
			set ;
			  
		}
		
		DateTime Pubdate
		{
			get ;
			set ;
			  
		}
		
		bool MbFlag
		{
			get ;
			set ;
			  
		}
		
		int Clicks
		{
			get ;
			set ;
			  
		}
		
		bool IsDeleted { get; set; }
		bool IsChanged { get; set; }
		
		#endregion 
	}

	/// <summary>
	/// LzpjTermZyList object for NHibernate mapped table 'lzpj_Term_zy_list'.
	/// </summary>
	[Serializable]
	public class LzpjTermZyList : ILzpjTermZyList
	{
		#region Member Variables

		protected int id;
		protected int userid;
		protected int jdid;
		protected string title;
		protected string filepath;
		protected string filetype;
		protected double filesize;
		protected int zytypeid;
		protected DateTime pubdate;
		protected bool mbflag;
		protected int clicks;
		protected bool _bIsDeleted;
		protected bool _bIsChanged;
		#endregion
		
		#region Constructors
		public LzpjTermZyList() {}
		
		public LzpjTermZyList(int pUserid, int pJdId, string pTitle, string pFilepath, string pFiletype, double pFilesize, int pZyTypeid, DateTime pPubdate, bool pMbFlag, int pClicks)
		{
			this.userid = pUserid; 
			this.jdid = pJdId; 
			this.title = pTitle; 
			this.filepath = pFilepath; 
			this.filetype = pFiletype; 
			this.filesize = pFilesize; 
			this.zytypeid = pZyTypeid; 
			this.pubdate = pPubdate; 
			this.mbflag = pMbFlag; 
			this.clicks = pClicks; 
		}
		
		#endregion
		
		#region Public Properties
		
		public int Id
		{
			get { return id; }
			set { _bIsChanged |= (id != value); id = value; }
			
		}
		
		public int Userid
		{
			get { return userid; }
			set { _bIsChanged |= (userid != value); userid = value; }
			
		}
		
		public int JdId
		{
			get { return jdid; }
			set { _bIsChanged |= (jdid != value); jdid = value; }
			
		}
		
		public string Title
		{
			get { return title; }
			set 
			{
			  if (value != null && value.Length > 255)
			    throw new ArgumentOutOfRangeException("Title", "Title value, cannot contain more than 255 characters");
			  _bIsChanged |= (title != value); 
			  title = value; 
			}
			
		}
		
		public string Filepath
		{
			get { return filepath; }
			set 
			{
			  if (value != null && value.Length > 255)
			    throw new ArgumentOutOfRangeException("Filepath", "Filepath value, cannot contain more than 255 characters");
			  _bIsChanged |= (filepath != value); 
			  filepath = value; 
			}
			
		}
		
		public string Filetype
		{
			get { return filetype; }
			set 
			{
			  if (value != null && value.Length > 200)
			    throw new ArgumentOutOfRangeException("Filetype", "Filetype value, cannot contain more than 200 characters");
			  _bIsChanged |= (filetype != value); 
			  filetype = value; 
			}
			
		}
		
		public double Filesize
		{
			get { return filesize; }
			set { _bIsChanged |= (filesize != value); filesize = value; }
			
		}
		
		public int ZyTypeid
		{
			get { return zytypeid; }
			set { _bIsChanged |= (zytypeid != value); zytypeid = value; }
			
		}
		
		public DateTime Pubdate
		{
			get { return pubdate; }
			set { _bIsChanged |= (pubdate != value); pubdate = value; }
			
		}
		
		public bool MbFlag
		{
			get { return mbflag; }
			set { _bIsChanged |= (mbflag != value); mbflag = value; }
			
		}
		
		public int Clicks
		{
			get { return clicks; }
			set { _bIsChanged |= (clicks != value); clicks = value; }
			
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
	
	#region Custom ICollection interface for LzpjTermZyList 

	
	public interface ILzpjTermZyListCollection : ICollection
	{
		LzpjTermZyList this[int index]{	get; set; }
		void Add(LzpjTermZyList pLzpjTermZyList);
		void Clear();
	}
	
	[Serializable]
	public class LzpjTermZyListCollection : ILzpjTermZyListCollection
	{
		private IList<LzpjTermZyList> _arrayInternal;

		public LzpjTermZyListCollection()
		{
			_arrayInternal = new List<LzpjTermZyList>();
		}
		
		public LzpjTermZyListCollection( IList<LzpjTermZyList> pSource )
		{
			_arrayInternal = pSource;
			if(_arrayInternal == null)
			{
				_arrayInternal = new List<LzpjTermZyList>();
			}
		}

		public LzpjTermZyList this[int index]
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
		public void CopyTo(Array array, int index){ _arrayInternal.CopyTo((LzpjTermZyList[])array, index); }
		public IEnumerator GetEnumerator() { return _arrayInternal.GetEnumerator(); }
		public void Add(LzpjTermZyList pLzpjTermZyList) { _arrayInternal.Add(pLzpjTermZyList); }
		public void Clear() { _arrayInternal.Clear(); }
		public IList<LzpjTermZyList> GetList() { return _arrayInternal; }
	 }
	
	#endregion
}
