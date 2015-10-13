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
	/// IRsGwcdViewUserlist interface for NHibernate mapped table 'RS_gwcd_ViewUserlist'.
	/// </summary>
	public interface IRsGwcdViewUserlist
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
		
		int Gwid
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
		
		string Yj
		{
			get ;
			set ;
			  
		}
		
		bool IsDeleted { get; set; }
		bool IsChanged { get; set; }
		
		#endregion 
	}

	/// <summary>
	/// RsGwcdViewUserlist object for NHibernate mapped table 'RS_gwcd_ViewUserlist'.
	/// </summary>
	[Serializable]
	public class RsGwcdViewUserlist : IRsGwcdViewUserlist
	{
		#region Member Variables

		protected int id;
		protected int userid;
		protected int gwid;
		protected DateTime pubdate;
		protected int clicks;
		protected string yj;
		protected bool _bIsDeleted;
		protected bool _bIsChanged;
		#endregion
		
		#region Constructors
		public RsGwcdViewUserlist() {}
		
		public RsGwcdViewUserlist(int pUserid, int pGwid, DateTime pPubdate, int pClicks, string pYj)
		{
			this.userid = pUserid; 
			this.gwid = pGwid; 
			this.pubdate = pPubdate; 
			this.clicks = pClicks; 
			this.yj = pYj; 
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
		
		public int Gwid
		{
			get { return gwid; }
			set { _bIsChanged |= (gwid != value); gwid = value; }
			
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
		
		public string Yj
		{
			get { return yj; }
			set 
			{
			  if (value != null && value.Length > 1073741823)
			    throw new ArgumentOutOfRangeException("Yj", "Yj value, cannot contain more than 1073741823 characters");
			  _bIsChanged |= (yj != value); 
			  yj = value; 
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
	
	#region Custom ICollection interface for RsGwcdViewUserlist 

	
	public interface IRsGwcdViewUserlistCollection : ICollection
	{
		RsGwcdViewUserlist this[int index]{	get; set; }
		void Add(RsGwcdViewUserlist pRsGwcdViewUserlist);
		void Clear();
	}
	
	[Serializable]
	public class RsGwcdViewUserlistCollection : IRsGwcdViewUserlistCollection
	{
		private IList<RsGwcdViewUserlist> _arrayInternal;

		public RsGwcdViewUserlistCollection()
		{
			_arrayInternal = new List<RsGwcdViewUserlist>();
		}
		
		public RsGwcdViewUserlistCollection( IList<RsGwcdViewUserlist> pSource )
		{
			_arrayInternal = pSource;
			if(_arrayInternal == null)
			{
				_arrayInternal = new List<RsGwcdViewUserlist>();
			}
		}

		public RsGwcdViewUserlist this[int index]
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
		public void CopyTo(Array array, int index){ _arrayInternal.CopyTo((RsGwcdViewUserlist[])array, index); }
		public IEnumerator GetEnumerator() { return _arrayInternal.GetEnumerator(); }
		public void Add(RsGwcdViewUserlist pRsGwcdViewUserlist) { _arrayInternal.Add(pRsGwcdViewUserlist); }
		public void Clear() { _arrayInternal.Clear(); }
		public IList<RsGwcdViewUserlist> GetList() { return _arrayInternal; }
	 }
	
	#endregion
}
