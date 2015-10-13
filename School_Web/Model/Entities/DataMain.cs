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
	/// IDataMain interface for NHibernate mapped table 'Data_Main'.
	/// </summary>
	public interface IDataMain
	{
		#region Public Properties
		
		int Id
		{
			get ;
			set ;
			  
		}
		
		int Moduleid
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
		
		int Userid
		{
			get ;
			set ;
			  
		}
		
		int UnitId
		{
			get ;
			set ;
			  
		}
		
		int Caseid
		{
			get ;
			set ;
			  
		}
		
		int Pindex
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
		
		bool IsDeleted { get; set; }
		bool IsChanged { get; set; }
		
		#endregion 
	}

	/// <summary>
	/// DataMain object for NHibernate mapped table 'Data_Main'.
	/// </summary>
	[Serializable]
	public class DataMain : IDataMain
	{
		#region Member Variables

		protected int id;
		protected int moduleid;
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
		protected string title;
		protected string remark;
		protected string content;
		protected double cent;
		protected DateTime enddate;
		protected string caseids;
		protected string docgetnum;
		protected string docnum;
		protected bool _bIsDeleted;
		protected bool _bIsChanged;
		#endregion
		
		#region Constructors
		public DataMain() {}
		
		public DataMain(int pModuleid, int pZyTypeid, int pParentId, int pUserid, int pUnitId, int pCaseid, int pPindex, int pBrowCount, bool pStatus, bool pCmd, bool pUserRight, string pAuthor, DateTime pPubDate, string pTitle, string pRemark, string pContent, double pCent, DateTime pEndDate, string pCaseids, string pDocGetNum, string pDocNum)
		{
			this.moduleid = pModuleid; 
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
			this.title = pTitle; 
			this.remark = pRemark; 
			this.content = pContent; 
			this.cent = pCent; 
			this.enddate = pEndDate; 
			this.caseids = pCaseids; 
			this.docgetnum = pDocGetNum; 
			this.docnum = pDocNum; 
		}
		
		public DataMain(int pId)
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
		
		public int Moduleid
		{
			get { return moduleid; }
			set { _bIsChanged |= (moduleid != value); moduleid = value; }
			
		}
		
		public int ZyTypeid
		{
			get { return zytypeid; }
			set { _bIsChanged |= (zytypeid != value); zytypeid = value; }
			
		}
		
		public int ParentId
		{
			get { return parentid; }
			set { _bIsChanged |= (parentid != value); parentid = value; }
			
		}
		
		public int Userid
		{
			get { return userid; }
			set { _bIsChanged |= (userid != value); userid = value; }
			
		}
		
		public int UnitId
		{
			get { return unitid; }
			set { _bIsChanged |= (unitid != value); unitid = value; }
			
		}
		
		public int Caseid
		{
			get { return caseid; }
			set { _bIsChanged |= (caseid != value); caseid = value; }
			
		}
		
		public int Pindex
		{
			get { return pindex; }
			set { _bIsChanged |= (pindex != value); pindex = value; }
			
		}
		
		public int BrowCount
		{
			get { return browcount; }
			set { _bIsChanged |= (browcount != value); browcount = value; }
			
		}
		
		public bool Status
		{
			get { return status; }
			set { _bIsChanged |= (status != value); status = value; }
			
		}
		
		public bool Cmd
		{
			get { return cmd; }
			set { _bIsChanged |= (cmd != value); cmd = value; }
			
		}
		
		public bool UserRight
		{
			get { return userright; }
			set { _bIsChanged |= (userright != value); userright = value; }
			
		}
		
		public string Author
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
		
		public DateTime PubDate
		{
			get { return pubdate; }
			set { _bIsChanged |= (pubdate != value); pubdate = value; }
			
		}
		
		public string Title
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
		
		public double Cent
		{
			get { return cent; }
			set { _bIsChanged |= (cent != value); cent = value; }
			
		}
		
		public DateTime EndDate
		{
			get { return enddate; }
			set { _bIsChanged |= (enddate != value); enddate = value; }
			
		}
		
		public string Caseids
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
		
		public string DocGetNum
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
		
		public string DocNum
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
	
	#region Custom ICollection interface for DataMain 

	
	public interface IDataMainCollection : ICollection
	{
		DataMain this[int index]{	get; set; }
		void Add(DataMain pDataMain);
		void Clear();
	}
	
	[Serializable]
	public class DataMainCollection : IDataMainCollection
	{
		private IList<DataMain> _arrayInternal;

		public DataMainCollection()
		{
			_arrayInternal = new List<DataMain>();
		}
		
		public DataMainCollection( IList<DataMain> pSource )
		{
			_arrayInternal = pSource;
			if(_arrayInternal == null)
			{
				_arrayInternal = new List<DataMain>();
			}
		}

		public DataMain this[int index]
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
		public void CopyTo(Array array, int index){ _arrayInternal.CopyTo((DataMain[])array, index); }
		public IEnumerator GetEnumerator() { return _arrayInternal.GetEnumerator(); }
		public void Add(DataMain pDataMain) { _arrayInternal.Add(pDataMain); }
		public void Clear() { _arrayInternal.Clear(); }
		public IList<DataMain> GetList() { return _arrayInternal; }
	 }
	
	#endregion
}
