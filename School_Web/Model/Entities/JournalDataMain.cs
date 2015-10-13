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
	/// IJournalDataMain interface for NHibernate mapped table 'Journal_data_main'.
	/// </summary>
	public interface IJournalDataMain
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
		
		int Caseid
		{
			get ;
			set ;
			  
		}
		
		string Codenum
		{
			get ;
			set ;
			  
		}
		
		string Title
		{
			get ;
			set ;
			  
		}
		
		string Zy
		{
			get ;
			set ;
			  
		}
		
		string Keywords
		{
			get ;
			set ;
			  
		}
		
		int WordNum
		{
			get ;
			set ;
			  
		}
		
		string Src
		{
			get ;
			set ;
			  
		}
		
		DateTime TgDate
		{
			get ;
			set ;
			  
		}
		
		int State
		{
			get ;
			set ;
			  
		}
		
		DateTime FbDate
		{
			get ;
			set ;
			  
		}
		
		string Author
		{
			get ;
			set ;
			  
		}
		
		string AuthorUnit
		{
			get ;
			set ;
			  
		}
		
		DateTime UpdateDate
		{
			get ;
			set ;
			  
		}
		
		bool IsDeleted { get; set; }
		bool IsChanged { get; set; }
		
		#endregion 
	}

	/// <summary>
	/// JournalDataMain object for NHibernate mapped table 'Journal_data_main'.
	/// </summary>
	[Serializable]
	public class JournalDataMain : IJournalDataMain
	{
		#region Member Variables

		protected int id;
		protected int userid;
		protected int caseid;
		protected string codenum;
		protected string title;
		protected string zy;
		protected string keywords;
		protected int wordnum;
		protected string src;
		protected DateTime tgdate;
		protected int state;
		protected DateTime fbdate;
		protected string author;
		protected string authorunit;
		protected DateTime updatedate;
		protected bool _bIsDeleted;
		protected bool _bIsChanged;
		#endregion
		
		#region Constructors
		public JournalDataMain() {}
		
		public JournalDataMain(int pUserid, int pCaseid, string pCodenum, string pTitle, string pZy, string pKeywords, int pWordNum, string pSrc, DateTime pTgDate, int pState, DateTime pFbDate, string pAuthor, string pAuthorUnit, DateTime pUpdateDate)
		{
			this.userid = pUserid; 
			this.caseid = pCaseid; 
			this.codenum = pCodenum; 
			this.title = pTitle; 
			this.zy = pZy; 
			this.keywords = pKeywords; 
			this.wordnum = pWordNum; 
			this.src = pSrc; 
			this.tgdate = pTgDate; 
			this.state = pState; 
			this.fbdate = pFbDate; 
			this.author = pAuthor; 
			this.authorunit = pAuthorUnit; 
			this.updatedate = pUpdateDate; 
		}
		
		public JournalDataMain(int pId)
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
		
		public int Userid
		{
			get { return userid; }
			set { _bIsChanged |= (userid != value); userid = value; }
			
		}
		
		public int Caseid
		{
			get { return caseid; }
			set { _bIsChanged |= (caseid != value); caseid = value; }
			
		}
		
		public string Codenum
		{
			get { return codenum; }
			set 
			{
			  if (value != null && value.Length > 50)
			    throw new ArgumentOutOfRangeException("Codenum", "Codenum value, cannot contain more than 50 characters");
			  _bIsChanged |= (codenum != value); 
			  codenum = value; 
			}
			
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
		
		public string Zy
		{
			get { return zy; }
			set 
			{
			  if (value != null && value.Length > 1073741823)
			    throw new ArgumentOutOfRangeException("Zy", "Zy value, cannot contain more than 1073741823 characters");
			  _bIsChanged |= (zy != value); 
			  zy = value; 
			}
			
		}
		
		public string Keywords
		{
			get { return keywords; }
			set 
			{
			  if (value != null && value.Length > 1073741823)
			    throw new ArgumentOutOfRangeException("Keywords", "Keywords value, cannot contain more than 1073741823 characters");
			  _bIsChanged |= (keywords != value); 
			  keywords = value; 
			}
			
		}
		
		public int WordNum
		{
			get { return wordnum; }
			set { _bIsChanged |= (wordnum != value); wordnum = value; }
			
		}
		
		public string Src
		{
			get { return src; }
			set 
			{
			  if (value != null && value.Length > 50)
			    throw new ArgumentOutOfRangeException("Src", "Src value, cannot contain more than 50 characters");
			  _bIsChanged |= (src != value); 
			  src = value; 
			}
			
		}
		
		public DateTime TgDate
		{
			get { return tgdate; }
			set { _bIsChanged |= (tgdate != value); tgdate = value; }
			
		}
		
		public int State
		{
			get { return state; }
			set { _bIsChanged |= (state != value); state = value; }
			
		}
		
		public DateTime FbDate
		{
			get { return fbdate; }
			set { _bIsChanged |= (fbdate != value); fbdate = value; }
			
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
		
		public string AuthorUnit
		{
			get { return authorunit; }
			set 
			{
			  if (value != null && value.Length > 50)
			    throw new ArgumentOutOfRangeException("AuthorUnit", "AuthorUnit value, cannot contain more than 50 characters");
			  _bIsChanged |= (authorunit != value); 
			  authorunit = value; 
			}
			
		}
		
		public DateTime UpdateDate
		{
			get { return updatedate; }
			set { _bIsChanged |= (updatedate != value); updatedate = value; }
			
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
	
	#region Custom ICollection interface for JournalDataMain 

	
	public interface IJournalDataMainCollection : ICollection
	{
		JournalDataMain this[int index]{	get; set; }
		void Add(JournalDataMain pJournalDataMain);
		void Clear();
	}
	
	[Serializable]
	public class JournalDataMainCollection : IJournalDataMainCollection
	{
		private IList<JournalDataMain> _arrayInternal;

		public JournalDataMainCollection()
		{
			_arrayInternal = new List<JournalDataMain>();
		}
		
		public JournalDataMainCollection( IList<JournalDataMain> pSource )
		{
			_arrayInternal = pSource;
			if(_arrayInternal == null)
			{
				_arrayInternal = new List<JournalDataMain>();
			}
		}

		public JournalDataMain this[int index]
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
		public void CopyTo(Array array, int index){ _arrayInternal.CopyTo((JournalDataMain[])array, index); }
		public IEnumerator GetEnumerator() { return _arrayInternal.GetEnumerator(); }
		public void Add(JournalDataMain pJournalDataMain) { _arrayInternal.Add(pJournalDataMain); }
		public void Clear() { _arrayInternal.Clear(); }
		public IList<JournalDataMain> GetList() { return _arrayInternal; }
	 }
	
	#endregion
}
