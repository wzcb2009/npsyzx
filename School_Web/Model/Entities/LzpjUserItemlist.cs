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
	/// ILzpjUserItemlist interface for NHibernate mapped table 'lzpj_user_itemlist'.
	/// </summary>
	public interface ILzpjUserItemlist
	{
		#region Public Properties
		
		int Id
		{
			get ;
			set ;
			  
		}
		
		int Termid
		{
			get ;
			set ;
			  
		}
		
		int Userid
		{
			get ;
			set ;
			  
		}
		
		int Itemid
		{
			get ;
			set ;
			  
		}
		
		int ItemDjId
		{
			get ;
			set ;
			  
		}
		
		string Title
		{
			get ;
			set ;
			  
		}
		
		string FilePath
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
		
		int Caseid
		{
			get ;
			set ;
			  
		}
		
		bool IsDeleted { get; set; }
		bool IsChanged { get; set; }
		
		#endregion 
	}

	/// <summary>
	/// LzpjUserItemlist object for NHibernate mapped table 'lzpj_user_itemlist'.
	/// </summary>
	[Serializable]
	public class LzpjUserItemlist : ILzpjUserItemlist
	{
		#region Member Variables

		protected int id;
		protected int termid;
		protected int userid;
		protected int itemid;
		protected int itemdjid;
		protected string title;
		protected string filepath;
		protected string content;
		protected DateTime pubdate;
		protected int caseid;
		protected bool _bIsDeleted;
		protected bool _bIsChanged;
		#endregion
		
		#region Constructors
		public LzpjUserItemlist() {}
		
		public LzpjUserItemlist(int pTermid, int pUserid, int pItemid, int pItemDjId, string pTitle, string pFilePath, string pContent, DateTime pPubdate, int pCaseid)
		{
			this.termid = pTermid; 
			this.userid = pUserid; 
			this.itemid = pItemid; 
			this.itemdjid = pItemDjId; 
			this.title = pTitle; 
			this.filepath = pFilePath; 
			this.content = pContent; 
			this.pubdate = pPubdate; 
			this.caseid = pCaseid; 
		}
		
		#endregion
		
		#region Public Properties
		
		public int Id
		{
			get { return id; }
			set { _bIsChanged |= (id != value); id = value; }
			
		}
		
		public int Termid
		{
			get { return termid; }
			set { _bIsChanged |= (termid != value); termid = value; }
			
		}
		
		public int Userid
		{
			get { return userid; }
			set { _bIsChanged |= (userid != value); userid = value; }
			
		}
		
		public int Itemid
		{
			get { return itemid; }
			set { _bIsChanged |= (itemid != value); itemid = value; }
			
		}
		
		public int ItemDjId
		{
			get { return itemdjid; }
			set { _bIsChanged |= (itemdjid != value); itemdjid = value; }
			
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
		
		public string FilePath
		{
			get { return filepath; }
			set 
			{
			  if (value != null && value.Length > 250)
			    throw new ArgumentOutOfRangeException("FilePath", "FilePath value, cannot contain more than 250 characters");
			  _bIsChanged |= (filepath != value); 
			  filepath = value; 
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
		
		public int Caseid
		{
			get { return caseid; }
			set { _bIsChanged |= (caseid != value); caseid = value; }
			
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
	
	#region Custom ICollection interface for LzpjUserItemlist 

	
	public interface ILzpjUserItemlistCollection : ICollection
	{
		LzpjUserItemlist this[int index]{	get; set; }
		void Add(LzpjUserItemlist pLzpjUserItemlist);
		void Clear();
	}
	
	[Serializable]
	public class LzpjUserItemlistCollection : ILzpjUserItemlistCollection
	{
		private IList<LzpjUserItemlist> _arrayInternal;

		public LzpjUserItemlistCollection()
		{
			_arrayInternal = new List<LzpjUserItemlist>();
		}
		
		public LzpjUserItemlistCollection( IList<LzpjUserItemlist> pSource )
		{
			_arrayInternal = pSource;
			if(_arrayInternal == null)
			{
				_arrayInternal = new List<LzpjUserItemlist>();
			}
		}

		public LzpjUserItemlist this[int index]
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
		public void CopyTo(Array array, int index){ _arrayInternal.CopyTo((LzpjUserItemlist[])array, index); }
		public IEnumerator GetEnumerator() { return _arrayInternal.GetEnumerator(); }
		public void Add(LzpjUserItemlist pLzpjUserItemlist) { _arrayInternal.Add(pLzpjUserItemlist); }
		public void Clear() { _arrayInternal.Clear(); }
		public IList<LzpjUserItemlist> GetList() { return _arrayInternal; }
	 }
	
	#endregion
}
