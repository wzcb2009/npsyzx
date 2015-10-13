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
	/// IPrinter interface for NHibernate mapped table 'Printer'.
	/// </summary>
	public interface IPrinter
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
		
		string Url
		{
			get ;
			set ;
			  
		}
		
		string PageSize
		{
			get ;
			set ;
			  
		}
		
		double MarginLeft
		{
			get ;
			set ;
			  
		}
		
		double MarginRight
		{
			get ;
			set ;
			  
		}
		
		double MarginTop
		{
			get ;
			set ;
			  
		}
		
		double MarginButom
		{
			get ;
			set ;
			  
		}
		
		int CopyCount
		{
			get ;
			set ;
			  
		}
		
		bool ShowBarCode
		{
			get ;
			set ;
			  
		}
		
		string PageHeader
		{
			get ;
			set ;
			  
		}
		
		string PageFooter
		{
			get ;
			set ;
			  
		}
		
		int IsLandScape
		{
			get ;
			set ;
			  
		}
		
		string Contenturl
		{
			get ;
			set ;
			  
		}
		
		bool State
		{
			get ;
			set ;
			  
		}
		
		int UserId
		{
			get ;
			set ;
			  
		}
		
		bool IsDeleted { get; set; }
		bool IsChanged { get; set; }
		
		#endregion 
	}

	/// <summary>
	/// Printer object for NHibernate mapped table 'Printer'.
	/// </summary>
	[Serializable]
	public class Printer : IPrinter
	{
		#region Member Variables

		protected int id;
		protected string title;
		protected string url;
		protected string pagesize;
		protected double marginleft;
		protected double marginright;
		protected double margintop;
		protected double marginbutom;
		protected int copycount;
		protected bool showbarcode;
		protected string pageheader;
		protected string pagefooter;
		protected int islandscape;
		protected string contenturl;
		protected bool state;
		protected int userid;
		protected bool _bIsDeleted;
		protected bool _bIsChanged;
		#endregion
		
		#region Constructors
		public Printer() {}
		
		public Printer(string pTitle, string pUrl, string pPageSize, double pMarginLeft, double pMarginRight, double pMarginTop, double pMarginButom, int pCopyCount, bool pShowBarCode, string pPageHeader, string pPageFooter, int pIsLandScape, string pContenturl, bool pState, int pUserId)
		{
			this.title = pTitle; 
			this.url = pUrl; 
			this.pagesize = pPageSize; 
			this.marginleft = pMarginLeft; 
			this.marginright = pMarginRight; 
			this.margintop = pMarginTop; 
			this.marginbutom = pMarginButom; 
			this.copycount = pCopyCount; 
			this.showbarcode = pShowBarCode; 
			this.pageheader = pPageHeader; 
			this.pagefooter = pPageFooter; 
			this.islandscape = pIsLandScape; 
			this.contenturl = pContenturl; 
			this.state = pState; 
			this.userid = pUserId; 
		}
		
		public Printer(int pId)
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
			  if (value != null && value.Length > 50)
			    throw new ArgumentOutOfRangeException("Title", "Title value, cannot contain more than 50 characters");
			  _bIsChanged |= (title != value); 
			  title = value; 
			}
			
		}
		
		public string Url
		{
			get { return url; }
			set 
			{
			  if (value != null && value.Length > 50)
			    throw new ArgumentOutOfRangeException("Url", "Url value, cannot contain more than 50 characters");
			  _bIsChanged |= (url != value); 
			  url = value; 
			}
			
		}
		
		public string PageSize
		{
			get { return pagesize; }
			set 
			{
			  if (value != null && value.Length > 50)
			    throw new ArgumentOutOfRangeException("PageSize", "PageSize value, cannot contain more than 50 characters");
			  _bIsChanged |= (pagesize != value); 
			  pagesize = value; 
			}
			
		}
		
		public double MarginLeft
		{
			get { return marginleft; }
			set { _bIsChanged |= (marginleft != value); marginleft = value; }
			
		}
		
		public double MarginRight
		{
			get { return marginright; }
			set { _bIsChanged |= (marginright != value); marginright = value; }
			
		}
		
		public double MarginTop
		{
			get { return margintop; }
			set { _bIsChanged |= (margintop != value); margintop = value; }
			
		}
		
		public double MarginButom
		{
			get { return marginbutom; }
			set { _bIsChanged |= (marginbutom != value); marginbutom = value; }
			
		}
		
		public int CopyCount
		{
			get { return copycount; }
			set { _bIsChanged |= (copycount != value); copycount = value; }
			
		}
		
		public bool ShowBarCode
		{
			get { return showbarcode; }
			set { _bIsChanged |= (showbarcode != value); showbarcode = value; }
			
		}
		
		public string PageHeader
		{
			get { return pageheader; }
			set 
			{
			  if (value != null && value.Length > 250)
			    throw new ArgumentOutOfRangeException("PageHeader", "PageHeader value, cannot contain more than 250 characters");
			  _bIsChanged |= (pageheader != value); 
			  pageheader = value; 
			}
			
		}
		
		public string PageFooter
		{
			get { return pagefooter; }
			set 
			{
			  if (value != null && value.Length > 250)
			    throw new ArgumentOutOfRangeException("PageFooter", "PageFooter value, cannot contain more than 250 characters");
			  _bIsChanged |= (pagefooter != value); 
			  pagefooter = value; 
			}
			
		}
		
		public int IsLandScape
		{
			get { return islandscape; }
			set { _bIsChanged |= (islandscape != value); islandscape = value; }
			
		}
		
		public string Contenturl
		{
			get { return contenturl; }
			set 
			{
			  if (value != null && value.Length > 250)
			    throw new ArgumentOutOfRangeException("Contenturl", "Contenturl value, cannot contain more than 250 characters");
			  _bIsChanged |= (contenturl != value); 
			  contenturl = value; 
			}
			
		}
		
		public bool State
		{
			get { return state; }
			set { _bIsChanged |= (state != value); state = value; }
			
		}
		
		public int UserId
		{
			get { return userid; }
			set { _bIsChanged |= (userid != value); userid = value; }
			
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
	
	#region Custom ICollection interface for Printer 

	
	public interface IPrinterCollection : ICollection
	{
		Printer this[int index]{	get; set; }
		void Add(Printer pPrinter);
		void Clear();
	}
	
	[Serializable]
	public class PrinterCollection : IPrinterCollection
	{
		private IList<Printer> _arrayInternal;

		public PrinterCollection()
		{
			_arrayInternal = new List<Printer>();
		}
		
		public PrinterCollection( IList<Printer> pSource )
		{
			_arrayInternal = pSource;
			if(_arrayInternal == null)
			{
				_arrayInternal = new List<Printer>();
			}
		}

		public Printer this[int index]
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
		public void CopyTo(Array array, int index){ _arrayInternal.CopyTo((Printer[])array, index); }
		public IEnumerator GetEnumerator() { return _arrayInternal.GetEnumerator(); }
		public void Add(Printer pPrinter) { _arrayInternal.Add(pPrinter); }
		public void Clear() { _arrayInternal.Clear(); }
		public IList<Printer> GetList() { return _arrayInternal; }
	 }
	
	#endregion
}
