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
	/// IJournalQkFilelist interface for NHibernate mapped table 'Journal_QK_Filelist'.
	/// </summary>
	public interface IJournalQkFilelist
	{
		#region Public Properties
		
		int Id
		{
			get ;
			set ;
			  
		}
		
		int Qkid
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
		
		int Userid
		{
			get ;
			set ;
			  
		}
		
		double Filesize
		{
			get ;
			set ;
			  
		}
		
		bool IndexFlag
		{
			get ;
			set ;
			  
		}
		
		bool IsDeleted { get; set; }
		bool IsChanged { get; set; }
		
		#endregion 
	}

	/// <summary>
	/// JournalQkFilelist object for NHibernate mapped table 'Journal_QK_Filelist'.
	/// </summary>
	[Serializable]
	public class JournalQkFilelist : IJournalQkFilelist
	{
		#region Member Variables

		protected int id;
		protected int qkid;
		protected string title;
		protected string filepath;
		protected DateTime pubdate;
		protected int clicks;
		protected int userid;
		protected double filesize;
		protected bool indexflag;
		protected bool _bIsDeleted;
		protected bool _bIsChanged;
		#endregion
		
		#region Constructors
		public JournalQkFilelist() {}
		
		public JournalQkFilelist(int pQkid, string pTitle, string pFilepath, DateTime pPubdate, int pClicks, int pUserid, double pFilesize, bool pIndexFlag)
		{
			this.qkid = pQkid; 
			this.title = pTitle; 
			this.filepath = pFilepath; 
			this.pubdate = pPubdate; 
			this.clicks = pClicks; 
			this.userid = pUserid; 
			this.filesize = pFilesize; 
			this.indexflag = pIndexFlag; 
		}
		
		public JournalQkFilelist(int pId)
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
		
		public int Qkid
		{
			get { return qkid; }
			set { _bIsChanged |= (qkid != value); qkid = value; }
			
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
		
		public string Filepath
		{
			get { return filepath; }
			set 
			{
			  if (value != null && value.Length > 250)
			    throw new ArgumentOutOfRangeException("Filepath", "Filepath value, cannot contain more than 250 characters");
			  _bIsChanged |= (filepath != value); 
			  filepath = value; 
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
		
		public int Userid
		{
			get { return userid; }
			set { _bIsChanged |= (userid != value); userid = value; }
			
		}
		
		public double Filesize
		{
			get { return filesize; }
			set { _bIsChanged |= (filesize != value); filesize = value; }
			
		}
		
		public bool IndexFlag
		{
			get { return indexflag; }
			set { _bIsChanged |= (indexflag != value); indexflag = value; }
			
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
	
	#region Custom ICollection interface for JournalQkFilelist 

	
	public interface IJournalQkFilelistCollection : ICollection
	{
		JournalQkFilelist this[int index]{	get; set; }
		void Add(JournalQkFilelist pJournalQkFilelist);
		void Clear();
	}
	
	[Serializable]
	public class JournalQkFilelistCollection : IJournalQkFilelistCollection
	{
		private IList<JournalQkFilelist> _arrayInternal;

		public JournalQkFilelistCollection()
		{
			_arrayInternal = new List<JournalQkFilelist>();
		}
		
		public JournalQkFilelistCollection( IList<JournalQkFilelist> pSource )
		{
			_arrayInternal = pSource;
			if(_arrayInternal == null)
			{
				_arrayInternal = new List<JournalQkFilelist>();
			}
		}

		public JournalQkFilelist this[int index]
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
		public void CopyTo(Array array, int index){ _arrayInternal.CopyTo((JournalQkFilelist[])array, index); }
		public IEnumerator GetEnumerator() { return _arrayInternal.GetEnumerator(); }
		public void Add(JournalQkFilelist pJournalQkFilelist) { _arrayInternal.Add(pJournalQkFilelist); }
		public void Clear() { _arrayInternal.Clear(); }
		public IList<JournalQkFilelist> GetList() { return _arrayInternal; }
	 }
	
	#endregion
}
