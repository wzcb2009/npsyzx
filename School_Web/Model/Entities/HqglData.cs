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
	/// IHqglData interface for NHibernate mapped table 'hqgl_data'.
	/// </summary>
	public interface IHqglData
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
		
		string Title
		{
			get ;
			set ;
			  
		}
		
		int Caseid
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
		
		bool State
		{
			get ;
			set ;
			  
		}
		
		int CheckUserid
		{
			get ;
			set ;
			  
		}
		
		DateTime CheckPubdate
		{
			get ;
			set ;
			  
		}
		
		bool IsDeleted { get; set; }
		bool IsChanged { get; set; }
		
		#endregion 
	}

	/// <summary>
	/// HqglData object for NHibernate mapped table 'hqgl_data'.
	/// </summary>
	[Serializable]
	public class HqglData : IHqglData
	{
		#region Member Variables

		protected int id;
		protected int termid;
		protected int userid;
		protected string title;
		protected int caseid;
		protected string content;
		protected DateTime pubdate;
		protected bool state;
		protected int checkuserid;
		protected DateTime checkpubdate;
		protected bool _bIsDeleted;
		protected bool _bIsChanged;
		#endregion
		
		#region Constructors
		public HqglData() {}
		
		public HqglData(int pId, int pTermid, int pUserid, string pTitle, int pCaseid, string pContent, DateTime pPubdate, bool pState, int pCheckUserid, DateTime pCheckPubdate)
		{
			this.id = pId; 
			this.termid = pTermid; 
			this.userid = pUserid; 
			this.title = pTitle; 
			this.caseid = pCaseid; 
			this.content = pContent; 
			this.pubdate = pPubdate; 
			this.state = pState; 
			this.checkuserid = pCheckUserid; 
			this.checkpubdate = pCheckPubdate; 
		}
		
		public HqglData(int pId)
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
		
		public int Caseid
		{
			get { return caseid; }
			set { _bIsChanged |= (caseid != value); caseid = value; }
			
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
		
		public bool State
		{
			get { return state; }
			set { _bIsChanged |= (state != value); state = value; }
			
		}
		
		public int CheckUserid
		{
			get { return checkuserid; }
			set { _bIsChanged |= (checkuserid != value); checkuserid = value; }
			
		}
		
		public DateTime CheckPubdate
		{
			get { return checkpubdate; }
			set { _bIsChanged |= (checkpubdate != value); checkpubdate = value; }
			
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
	
	#region Custom ICollection interface for HqglData 

	
	public interface IHqglDataCollection : ICollection
	{
		HqglData this[int index]{	get; set; }
		void Add(HqglData pHqglData);
		void Clear();
	}
	
	[Serializable]
	public class HqglDataCollection : IHqglDataCollection
	{
		private IList<HqglData> _arrayInternal;

		public HqglDataCollection()
		{
			_arrayInternal = new List<HqglData>();
		}
		
		public HqglDataCollection( IList<HqglData> pSource )
		{
			_arrayInternal = pSource;
			if(_arrayInternal == null)
			{
				_arrayInternal = new List<HqglData>();
			}
		}

		public HqglData this[int index]
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
		public void CopyTo(Array array, int index){ _arrayInternal.CopyTo((HqglData[])array, index); }
		public IEnumerator GetEnumerator() { return _arrayInternal.GetEnumerator(); }
		public void Add(HqglData pHqglData) { _arrayInternal.Add(pHqglData); }
		public void Clear() { _arrayInternal.Clear(); }
		public IList<HqglData> GetList() { return _arrayInternal; }
	 }
	
	#endregion
}
