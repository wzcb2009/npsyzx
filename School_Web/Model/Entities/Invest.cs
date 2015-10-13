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
	/// IInvest interface for NHibernate mapped table 'Invest'.
	/// </summary>
	public interface IInvest
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
		
		int RoleId
		{
			get ;
			set ;
			  
		}
		
		int AdminId
		{
			get ;
			set ;
			  
		}
		
		string Title
		{
			get ;
			set ;
			  
		}
		
		string Content
		{
			get ;
			set ;
			  
		}
		
		DateTime StartDate
		{
			get ;
			set ;
			  
		}
		
		DateTime EndDate
		{
			get ;
			set ;
			  
		}
		
		bool Used
		{
			get ;
			set ;
			  
		}
		
		DateTime Pubdate
		{
			get ;
			set ;
			  
		}
		
		bool ShowJy
		{
			get ;
			set ;
			  
		}
		
		bool ShowFs
		{
			get ;
			set ;
			  
		}
		
		bool ShowZp
		{
			get ;
			set ;
			  
		}
		
		int ModelTypeid
		{
			get ;
			set ;
			  
		}
		
		bool IsDeleted { get; set; }
		bool IsChanged { get; set; }
		
		#endregion 
	}

	/// <summary>
	/// Invest object for NHibernate mapped table 'Invest'.
	/// </summary>
	[Serializable]
	public class Invest : IInvest
	{
		#region Member Variables

		protected int id;
		protected int termid;
		protected int roleid;
		protected int adminid;
		protected string title;
		protected string content;
		protected DateTime startdate;
		protected DateTime enddate;
		protected bool used;
		protected DateTime pubdate;
		protected bool showjy;
		protected bool showfs;
		protected bool showzp;
		protected int modeltypeid;
		protected bool _bIsDeleted;
		protected bool _bIsChanged;
		#endregion
		
		#region Constructors
		public Invest() {}
		
		public Invest(int pTermid, int pRoleId, int pAdminId, string pTitle, string pContent, DateTime pStartDate, DateTime pEndDate, bool pUsed, DateTime pPubdate, bool pShowJy, bool pShowFs, bool pShowZp, int pModelTypeid)
		{
			this.termid = pTermid; 
			this.roleid = pRoleId; 
			this.adminid = pAdminId; 
			this.title = pTitle; 
			this.content = pContent; 
			this.startdate = pStartDate; 
			this.enddate = pEndDate; 
			this.used = pUsed; 
			this.pubdate = pPubdate; 
			this.showjy = pShowJy; 
			this.showfs = pShowFs; 
			this.showzp = pShowZp; 
			this.modeltypeid = pModelTypeid; 
		}
		
		public Invest(string pTitle, DateTime pStartDate, DateTime pEndDate, bool pUsed, DateTime pPubdate)
		{
			this.title = pTitle; 
			this.startdate = pStartDate; 
			this.enddate = pEndDate; 
			this.used = pUsed; 
			this.pubdate = pPubdate; 
		}
		
		public Invest(int pId)
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
		
		public int RoleId
		{
			get { return roleid; }
			set { _bIsChanged |= (roleid != value); roleid = value; }
			
		}
		
		public int AdminId
		{
			get { return adminid; }
			set { _bIsChanged |= (adminid != value); adminid = value; }
			
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
		
		public DateTime StartDate
		{
			get { return startdate; }
			set { _bIsChanged |= (startdate != value); startdate = value; }
			
		}
		
		public DateTime EndDate
		{
			get { return enddate; }
			set { _bIsChanged |= (enddate != value); enddate = value; }
			
		}
		
		public bool Used
		{
			get { return used; }
			set { _bIsChanged |= (used != value); used = value; }
			
		}
		
		public DateTime Pubdate
		{
			get { return pubdate; }
			set { _bIsChanged |= (pubdate != value); pubdate = value; }
			
		}
		
		public bool ShowJy
		{
			get { return showjy; }
			set { _bIsChanged |= (showjy != value); showjy = value; }
			
		}
		
		public bool ShowFs
		{
			get { return showfs; }
			set { _bIsChanged |= (showfs != value); showfs = value; }
			
		}
		
		public bool ShowZp
		{
			get { return showzp; }
			set { _bIsChanged |= (showzp != value); showzp = value; }
			
		}
		
		public int ModelTypeid
		{
			get { return modeltypeid; }
			set { _bIsChanged |= (modeltypeid != value); modeltypeid = value; }
			
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
	
	#region Custom ICollection interface for Invest 

	
	public interface IInvestCollection : ICollection
	{
		Invest this[int index]{	get; set; }
		void Add(Invest pInvest);
		void Clear();
	}
	
	[Serializable]
	public class InvestCollection : IInvestCollection
	{
		private IList<Invest> _arrayInternal;

		public InvestCollection()
		{
			_arrayInternal = new List<Invest>();
		}
		
		public InvestCollection( IList<Invest> pSource )
		{
			_arrayInternal = pSource;
			if(_arrayInternal == null)
			{
				_arrayInternal = new List<Invest>();
			}
		}

		public Invest this[int index]
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
		public void CopyTo(Array array, int index){ _arrayInternal.CopyTo((Invest[])array, index); }
		public IEnumerator GetEnumerator() { return _arrayInternal.GetEnumerator(); }
		public void Add(Invest pInvest) { _arrayInternal.Add(pInvest); }
		public void Clear() { _arrayInternal.Clear(); }
		public IList<Invest> GetList() { return _arrayInternal; }
	 }
	
	#endregion
}
