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
	/// IRsGwcd interface for NHibernate mapped table 'Rs_gwcd'.
	/// </summary>
	public interface IRsGwcd
	{
		#region Public Properties
		
		int Gwid
		{
			get ;
			set ;
			  
		}
		
		int Groupid
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
		
		DateTime Pubdate
		{
			get ;
			set ;
			  
		}
		
		bool Checked
		{
			get ;
			set ;
			  
		}
		
		int AdminId
		{
			get ;
			set ;
			  
		}
		
		int Typeid
		{
			get ;
			set ;
			  
		}
		
		string Sh
		{
			get ;
			set ;
			  
		}
		
		string Fh
		{
			get ;
			set ;
			  
		}
		
		bool IsDeleted { get; set; }
		bool IsChanged { get; set; }
		
		#endregion 
	}

	/// <summary>
	/// RsGwcd object for NHibernate mapped table 'Rs_gwcd'.
	/// </summary>
	[Serializable]
	public class RsGwcd : IRsGwcd
	{
		#region Member Variables

		protected int gwid;
		protected int groupid;
		protected string title;
		protected string content;
		protected DateTime pubdate;
		protected bool checked;
		protected int adminid;
		protected int typeid;
		protected string sh;
		protected string fh;
		protected bool _bIsDeleted;
		protected bool _bIsChanged;
		#endregion
		
		#region Constructors
		public RsGwcd() {}
		
		public RsGwcd(int pGwid, int pGroupid, string pTitle, string pContent, DateTime pPubdate, bool pChecked, int pAdminId, int pTypeid, string pSh, string pFh)
		{
			this.gwid = pGwid; 
			this.groupid = pGroupid; 
			this.title = pTitle; 
			this.content = pContent; 
			this.pubdate = pPubdate; 
			this.checked = pChecked; 
			this.adminid = pAdminId; 
			this.typeid = pTypeid; 
			this.sh = pSh; 
			this.fh = pFh; 
		}
		
		public RsGwcd(int pGwid)
		{
			this.gwid = pGwid; 
		}
		
		#endregion
		
		#region Public Properties
		
		public int Gwid
		{
			get { return gwid; }
			set { _bIsChanged |= (gwid != value); gwid = value; }
			
		}
		
		public int Groupid
		{
			get { return groupid; }
			set { _bIsChanged |= (groupid != value); groupid = value; }
			
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
		
		public DateTime Pubdate
		{
			get { return pubdate; }
			set { _bIsChanged |= (pubdate != value); pubdate = value; }
			
		}
		
		public bool Checked
		{
			get { return checked; }
			set { _bIsChanged |= (checked != value); checked = value; }
			
		}
		
		public int AdminId
		{
			get { return adminid; }
			set { _bIsChanged |= (adminid != value); adminid = value; }
			
		}
		
		public int Typeid
		{
			get { return typeid; }
			set { _bIsChanged |= (typeid != value); typeid = value; }
			
		}
		
		public string Sh
		{
			get { return sh; }
			set 
			{
			  if (value != null && value.Length > 50)
			    throw new ArgumentOutOfRangeException("Sh", "Sh value, cannot contain more than 50 characters");
			  _bIsChanged |= (sh != value); 
			  sh = value; 
			}
			
		}
		
		public string Fh
		{
			get { return fh; }
			set 
			{
			  if (value != null && value.Length > 50)
			    throw new ArgumentOutOfRangeException("Fh", "Fh value, cannot contain more than 50 characters");
			  _bIsChanged |= (fh != value); 
			  fh = value; 
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
	
	#region Custom ICollection interface for RsGwcd 

	
	public interface IRsGwcdCollection : ICollection
	{
		RsGwcd this[int index]{	get; set; }
		void Add(RsGwcd pRsGwcd);
		void Clear();
	}
	
	[Serializable]
	public class RsGwcdCollection : IRsGwcdCollection
	{
		private IList<RsGwcd> _arrayInternal;

		public RsGwcdCollection()
		{
			_arrayInternal = new List<RsGwcd>();
		}
		
		public RsGwcdCollection( IList<RsGwcd> pSource )
		{
			_arrayInternal = pSource;
			if(_arrayInternal == null)
			{
				_arrayInternal = new List<RsGwcd>();
			}
		}

		public RsGwcd this[int index]
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
		public void CopyTo(Array array, int index){ _arrayInternal.CopyTo((RsGwcd[])array, index); }
		public IEnumerator GetEnumerator() { return _arrayInternal.GetEnumerator(); }
		public void Add(RsGwcd pRsGwcd) { _arrayInternal.Add(pRsGwcd); }
		public void Clear() { _arrayInternal.Clear(); }
		public IList<RsGwcd> GetList() { return _arrayInternal; }
	 }
	
	#endregion
}
