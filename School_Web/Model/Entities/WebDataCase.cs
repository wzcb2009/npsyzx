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
	/// IWebDataCase interface for NHibernate mapped table 'Web_Data_Case'.
	/// </summary>
	public interface IWebDataCase
	{
		#region Public Properties
		
		int Id
		{
			get ;
			set ;
			  
		}
		
		int Parentid
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
		
		string CaseName
		{
			get ;
			set ;
			  
		}
		
		int CaseType
		{
			get ;
			set ;
			  
		}
		
		string CaseLayer
		{
			get ;
			set ;
			  
		}
		
		string CaseReg
		{
			get ;
			set ;
			  
		}
		
		string CaseData
		{
			get ;
			set ;
			  
		}
		
		string ShowStyle
		{
			get ;
			set ;
			  
		}
		
		string ShowType
		{
			get ;
			set ;
			  
		}
		
		string OpenType
		{
			get ;
			set ;
			  
		}
		
		string Description
		{
			get ;
			set ;
			  
		}
		
		int IsContribute
		{
			get ;
			set ;
			  
		}
		
		DateTime PubDate
		{
			get ;
			set ;
			  
		}
		
		bool Showend
		{
			get ;
			set ;
			  
		}
		
		int Depth
		{
			get ;
			set ;
			  
		}
		
		int IndexType
		{
			get ;
			set ;
			  
		}
		
		bool Iscomment
		{
			get ;
			set ;
			  
		}
		
		string UserRight
		{
			get ;
			set ;
			  
		}
		
		int Subjectid
		{
			get ;
			set ;
			  
		}
		
		int Kgradeid
		{
			get ;
			set ;
			  
		}
		
		bool IsDeleted { get; set; }
		bool IsChanged { get; set; }
		
		#endregion 
	}

	/// <summary>
	/// WebDataCase object for NHibernate mapped table 'Web_Data_Case'.
	/// </summary>
	[Serializable]
	public class WebDataCase : IWebDataCase
	{
		#region Member Variables

		protected int id;
		protected int parentid;
		protected int pindex;
		protected int caseid;
		protected string casename;
		protected int casetype;
		protected string caselayer;
		protected string casereg;
		protected string casedata;
		protected string showstyle;
		protected string showtype;
		protected string opentype;
		protected string description;
		protected int iscontribute;
		protected DateTime pubdate;
		protected bool showend;
		protected int depth;
		protected int indextype;
		protected bool iscomment;
		protected string userright;
		protected int subjectid;
		protected int kgradeid;
		protected bool _bIsDeleted;
		protected bool _bIsChanged;
		#endregion
		
		#region Constructors
		public WebDataCase() {}
		
		public WebDataCase(int pParentid, int pPindex, int pCaseid, string pCaseName, int pCaseType, string pCaseLayer, string pCaseReg, string pCaseData, string pShowStyle, string pShowType, string pOpenType, string pDescription, int pIsContribute, DateTime pPubDate, bool pShowend, int pDepth, int pIndexType, bool pIscomment, string pUserRight, int pSubjectid, int pKgradeid)
		{
			this.parentid = pParentid; 
			this.pindex = pPindex; 
			this.caseid = pCaseid; 
			this.casename = pCaseName; 
			this.casetype = pCaseType; 
			this.caselayer = pCaseLayer; 
			this.casereg = pCaseReg; 
			this.casedata = pCaseData; 
			this.showstyle = pShowStyle; 
			this.showtype = pShowType; 
			this.opentype = pOpenType; 
			this.description = pDescription; 
			this.iscontribute = pIsContribute; 
			this.pubdate = pPubDate; 
			this.showend = pShowend; 
			this.depth = pDepth; 
			this.indextype = pIndexType; 
			this.iscomment = pIscomment; 
			this.userright = pUserRight; 
			this.subjectid = pSubjectid; 
			this.kgradeid = pKgradeid; 
		}
		
		public WebDataCase(int pId)
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
		
		public int Parentid
		{
			get { return parentid; }
			set { _bIsChanged |= (parentid != value); parentid = value; }
			
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
		
		public string CaseName
		{
			get { return casename; }
			set 
			{
			  if (value != null && value.Length > 100)
			    throw new ArgumentOutOfRangeException("CaseName", "CaseName value, cannot contain more than 100 characters");
			  _bIsChanged |= (casename != value); 
			  casename = value; 
			}
			
		}
		
		public int CaseType
		{
			get { return casetype; }
			set { _bIsChanged |= (casetype != value); casetype = value; }
			
		}
		
		public string CaseLayer
		{
			get { return caselayer; }
			set 
			{
			  if (value != null && value.Length > 100)
			    throw new ArgumentOutOfRangeException("CaseLayer", "CaseLayer value, cannot contain more than 100 characters");
			  _bIsChanged |= (caselayer != value); 
			  caselayer = value; 
			}
			
		}
		
		public string CaseReg
		{
			get { return casereg; }
			set 
			{
			  if (value != null && value.Length > 200)
			    throw new ArgumentOutOfRangeException("CaseReg", "CaseReg value, cannot contain more than 200 characters");
			  _bIsChanged |= (casereg != value); 
			  casereg = value; 
			}
			
		}
		
		public string CaseData
		{
			get { return casedata; }
			set 
			{
			  if (value != null && value.Length > 2000)
			    throw new ArgumentOutOfRangeException("CaseData", "CaseData value, cannot contain more than 2000 characters");
			  _bIsChanged |= (casedata != value); 
			  casedata = value; 
			}
			
		}
		
		public string ShowStyle
		{
			get { return showstyle; }
			set 
			{
			  if (value != null && value.Length > 200)
			    throw new ArgumentOutOfRangeException("ShowStyle", "ShowStyle value, cannot contain more than 200 characters");
			  _bIsChanged |= (showstyle != value); 
			  showstyle = value; 
			}
			
		}
		
		public string ShowType
		{
			get { return showtype; }
			set 
			{
			  if (value != null && value.Length > 2)
			    throw new ArgumentOutOfRangeException("ShowType", "ShowType value, cannot contain more than 2 characters");
			  _bIsChanged |= (showtype != value); 
			  showtype = value; 
			}
			
		}
		
		public string OpenType
		{
			get { return opentype; }
			set 
			{
			  if (value != null && value.Length > 50)
			    throw new ArgumentOutOfRangeException("OpenType", "OpenType value, cannot contain more than 50 characters");
			  _bIsChanged |= (opentype != value); 
			  opentype = value; 
			}
			
		}
		
		public string Description
		{
			get { return description; }
			set 
			{
			  if (value != null && value.Length > 250)
			    throw new ArgumentOutOfRangeException("Description", "Description value, cannot contain more than 250 characters");
			  _bIsChanged |= (description != value); 
			  description = value; 
			}
			
		}
		
		public int IsContribute
		{
			get { return iscontribute; }
			set { _bIsChanged |= (iscontribute != value); iscontribute = value; }
			
		}
		
		public DateTime PubDate
		{
			get { return pubdate; }
			set { _bIsChanged |= (pubdate != value); pubdate = value; }
			
		}
		
		public bool Showend
		{
			get { return showend; }
			set { _bIsChanged |= (showend != value); showend = value; }
			
		}
		
		public int Depth
		{
			get { return depth; }
			set { _bIsChanged |= (depth != value); depth = value; }
			
		}
		
		public int IndexType
		{
			get { return indextype; }
			set { _bIsChanged |= (indextype != value); indextype = value; }
			
		}
		
		public bool Iscomment
		{
			get { return iscomment; }
			set { _bIsChanged |= (iscomment != value); iscomment = value; }
			
		}
		
		public string UserRight
		{
			get { return userright; }
			set 
			{
			  if (value != null && value.Length > 50)
			    throw new ArgumentOutOfRangeException("UserRight", "UserRight value, cannot contain more than 50 characters");
			  _bIsChanged |= (userright != value); 
			  userright = value; 
			}
			
		}
		
		public int Subjectid
		{
			get { return subjectid; }
			set { _bIsChanged |= (subjectid != value); subjectid = value; }
			
		}
		
		public int Kgradeid
		{
			get { return kgradeid; }
			set { _bIsChanged |= (kgradeid != value); kgradeid = value; }
			
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
	
	#region Custom ICollection interface for WebDataCase 

	
	public interface IWebDataCaseCollection : ICollection
	{
		WebDataCase this[int index]{	get; set; }
		void Add(WebDataCase pWebDataCase);
		void Clear();
	}
	
	[Serializable]
	public class WebDataCaseCollection : IWebDataCaseCollection
	{
		private IList<WebDataCase> _arrayInternal;

		public WebDataCaseCollection()
		{
			_arrayInternal = new List<WebDataCase>();
		}
		
		public WebDataCaseCollection( IList<WebDataCase> pSource )
		{
			_arrayInternal = pSource;
			if(_arrayInternal == null)
			{
				_arrayInternal = new List<WebDataCase>();
			}
		}

		public WebDataCase this[int index]
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
		public void CopyTo(Array array, int index){ _arrayInternal.CopyTo((WebDataCase[])array, index); }
		public IEnumerator GetEnumerator() { return _arrayInternal.GetEnumerator(); }
		public void Add(WebDataCase pWebDataCase) { _arrayInternal.Add(pWebDataCase); }
		public void Clear() { _arrayInternal.Clear(); }
		public IList<WebDataCase> GetList() { return _arrayInternal; }
	 }
	
	#endregion
}
