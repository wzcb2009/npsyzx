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
	/// IData_Main interface for NHibernate mapped table 'Data_Main'.
	/// </summary>
	public interface IData_Main
	{
		#region Public Properties
		
		int ID
		{
			get ;
			set ;
			  
		}
		
		int ZyTypeid
		{
			get ;
			set ;
			  
		}
		
		int ParentId
		{
			get ;
			set ;
			  
		}
		
		int UserID
		{
			get ;
			set ;
			  
		}
		
		int UnitId
		{
			get ;
			set ;
			  
		}
		
		int CaseID
		{
			get ;
			set ;
			  
		}
		
		int PIndex
		{
			get ;
			set ;
			  
		}
		
		int BrowCount
		{
			get ;
			set ;
			  
		}
		
		bool Status
		{
			get ;
			set ;
			  
		}
		
		bool Cmd
		{
			get ;
			set ;
			  
		}
		
		bool UserRight
		{
			get ;
			set ;
			  
		}
		
		string Author
		{
			get ;
			set ;
			  
		}
		
		DateTime PubDate
		{
			get ;
			set ;
			  
		}
		
		string DocGetNum
		{
			get ;
			set ;
			  
		}
		
		string DocNum
		{
			get ;
			set ;
			  
		}
		
		string Title
		{
			get ;
			set ;
			  
		}
		
		string Remark
		{
			get ;
			set ;
			  
		}
		
		string Content
		{
			get ;
			set ;
			  
		}
		
		double Cent
		{
			get ;
			set ;
			  
		}
		
		DateTime EndDate
		{
			get ;
			set ;
			  
		}
		
		string Caseids
		{
			get ;
			set ;
			  
		}
		
		bool IsDeleted { get; set; }
		bool IsChanged { get; set; }
		
		#endregion 
	}

	/// <summary>
	/// Data_Main object for NHibernate mapped table 'Data_Main'.
	/// </summary>
	[Serializable]
	public class Data_Main : IData_Main
	{
		#region Member Variables

		protected int id;
		protected int zytypeid;
		protected int parentid;
		protected int userid;
		protected int unitid;
		protected int caseid;
		protected int pindex;
		protected int browcount;
		protected bool status;
		protected bool cmd;
		protected bool userright;
		protected string author;
		protected DateTime pubdate;
		protected string docgetnum;
		protected string docnum;
		protected string title;
		protected string remark;
		protected string content;
		protected double cent;
		protected DateTime enddate;
		protected string caseids;
		protected bool _bIsDeleted;
		protected bool _bIsChanged;
		#endregion
		
		#region Constructors
		public Data_Main() {}
		
		public Data_Main(int pZyTypeid, int pParentId, int pUserid, int pUnitId, int pCaseid, int pPindex, int pBrowCount, bool pStatus, bool pCmd, bool pUserRight, string pAuthor, DateTime pPubDate, string pDocGetNum, string pDocNum, string pTitle, string pRemark, string pContent, double pCent, DateTime pEndDate, string pCaseids)
		{
			this.zytypeid = pZyTypeid; 
			this.parentid = pParentId; 
			this.userid = pUserid; 
			this.unitid = pUnitId; 
			this.caseid = pCaseid; 
			this.pindex = pPindex; 
			this.browcount = pBrowCount; 
			this.status = pStatus; 
			this.cmd = pCmd; 
			this.userright = pUserRight; 
			this.author = pAuthor; 
			this.pubdate = pPubDate; 
			this.docgetnum = pDocGetNum; 
			this.docnum = pDocNum; 
			this.title = pTitle; 
			this.remark = pRemark; 
			this.content = pContent; 
			this.cent = pCent; 
			this.enddate = pEndDate; 
			this.caseids = pCaseids; 
		}
		
		public Data_Main(int pId)
		{
			this.id = pId; 
		}
		
		#endregion
		
		#region Public Properties
		
		public virtual int ID
		{
			get { return id; }
			set { _bIsChanged |= (id != value); id = value; }
			
		}
		
		public virtual int ZyTypeid
		{
			get { return zytypeid; }
			set { _bIsChanged |= (zytypeid != value); zytypeid = value; }
			
		}
		
		public virtual int ParentId
		{
			get { return parentid; }
			set { _bIsChanged |= (parentid != value); parentid = value; }
			
		}
		
		public virtual int UserID
		{
			get { return userid; }
			set { _bIsChanged |= (userid != value); userid = value; }
			
		}
		
		public virtual int UnitId
		{
			get { return unitid; }
			set { _bIsChanged |= (unitid != value); unitid = value; }
			
		}
		
		public virtual int CaseID
		{
			get { return caseid; }
			set { _bIsChanged |= (caseid != value); caseid = value; }
			
		}
		
		public virtual int PIndex
		{
			get { return pindex; }
			set { _bIsChanged |= (pindex != value); pindex = value; }
			
		}
		
		public virtual int BrowCount
		{
			get { return browcount; }
			set { _bIsChanged |= (browcount != value); browcount = value; }
			
		}
		
		public virtual bool Status
		{
			get { return status; }
			set { _bIsChanged |= (status != value); status = value; }
			
		}
		
		public virtual bool Cmd
		{
			get { return cmd; }
			set { _bIsChanged |= (cmd != value); cmd = value; }
			
		}
		
		public virtual bool UserRight
		{
			get { return userright; }
			set { _bIsChanged |= (userright != value); userright = value; }
			
		}
		
		public virtual string Author
		{
			get { return author; }
			set 
			{
			  if (value != null && value.Length > 250)
			    throw new ArgumentOutOfRangeException("Author", "Author value, cannot contain more than 250 characters");
			  _bIsChanged |= (author != value); 
			  author = value; 
			}
			
		}
		
		public virtual DateTime PubDate
		{
			get { return pubdate; }
			set { _bIsChanged |= (pubdate != value); pubdate = value; }
			
		}
		
		public virtual string DocGetNum
		{
			get { return docgetnum; }
			set 
			{
			  if (value != null && value.Length > 50)
			    throw new ArgumentOutOfRangeException("DocGetNum", "DocGetNum value, cannot contain more than 50 characters");
			  _bIsChanged |= (docgetnum != value); 
			  docgetnum = value; 
			}
			
		}
		
		public virtual string DocNum
		{
			get { return docnum; }
			set 
			{
			  if (value != null && value.Length > 50)
			    throw new ArgumentOutOfRangeException("DocNum", "DocNum value, cannot contain more than 50 characters");
			  _bIsChanged |= (docnum != value); 
			  docnum = value; 
			}
			
		}
		
		public virtual string Title
		{
			get { return title; }
			set 
			{
			  if (value != null && value.Length > 100)
			    throw new ArgumentOutOfRangeException("Title", "Title value, cannot contain more than 100 characters");
			  _bIsChanged |= (title != value); 
			  title = value; 
			}
			
		}
		
		public virtual string Remark
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
		
		public virtual string Content
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
		
		public virtual double Cent
		{
			get { return cent; }
			set { _bIsChanged |= (cent != value); cent = value; }
			
		}
		
		public virtual DateTime EndDate
		{
			get { return enddate; }
			set { _bIsChanged |= (enddate != value); enddate = value; }
			
		}
		
		public virtual string Caseids
		{
			get { return caseids; }
			set 
			{
			  if (value != null && value.Length > 250)
			    throw new ArgumentOutOfRangeException("Caseids", "Caseids value, cannot contain more than 250 characters");
			  _bIsChanged |= (caseids != value); 
			  caseids = value; 
			}
			
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
	
	#region Custom ICollection interface for Data_Main 

	
	public interface IData_MainCollection : ICollection
	{
		Data_Main this[int index]{	get; set; }
		void Add(Data_Main pData_Main);
		void Clear();
	}
	
	[Serializable]
	public class Data_MainCollection : IData_MainCollection
	{
		private IList<Data_Main> _arrayInternal;

		public Data_MainCollection()
		{
			_arrayInternal = new List<Data_Main>();
		}
		
		public Data_MainCollection( IList<Data_Main> pSource )
		{
			_arrayInternal = pSource;
			if(_arrayInternal == null)
			{
				_arrayInternal = new List<Data_Main>();
			}
		}

		public Data_Main this[int index]
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
		public void CopyTo(Array array, int index){ _arrayInternal.CopyTo((Data_Main[])array, index); }
		public IEnumerator GetEnumerator() { return _arrayInternal.GetEnumerator(); }
		public void Add(Data_Main pData_Main) { _arrayInternal.Add(pData_Main); }
		public void Clear() { _arrayInternal.Clear(); }
		public IList<Data_Main> GetList() { return _arrayInternal; }
	 }
	
	#endregion
}
