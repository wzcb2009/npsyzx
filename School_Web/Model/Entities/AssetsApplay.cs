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
	/// IAssetsApplay interface for NHibernate mapped table 'assets_applay'.
	/// </summary>
	public interface IAssetsApplay
	{
		#region Public Properties
		
		int Id
		{
			get ;
			set ;
			  
		}
		
		string Product
		{
			get ;
			set ;
			  
		}
		
		int Num
		{
			get ;
			set ;
			  
		}
		
		decimal Price
		{
			get ;
			set ;
			  
		}
		
		string Content
		{
			get ;
			set ;
			  
		}
		
		string AppUserid
		{
			get ;
			set ;
			  
		}
		
		DateTime AppDate
		{
			get ;
			set ;
			  
		}
		
		int SCheckUserid
		{
			get ;
			set ;
			  
		}
		
		DateTime SCheckDate
		{
			get ;
			set ;
			  
		}
		
		int ECheckUserid
		{
			get ;
			set ;
			  
		}
		
		DateTime ECheckDate
		{
			get ;
			set ;
			  
		}
		
		int CheckType
		{
			get ;
			set ;
			  
		}
		
		string Cgzk
		{
			get ;
			set ;
			  
		}
		
		DateTime CgzkDate
		{
			get ;
			set ;
			  
		}
		
		bool State
		{
			get ;
			set ;
			  
		}
		
		bool IsDeleted { get; set; }
		bool IsChanged { get; set; }
		
		#endregion 
	}

	/// <summary>
	/// AssetsApplay object for NHibernate mapped table 'assets_applay'.
	/// </summary>
	[Serializable]
	public class AssetsApplay : IAssetsApplay
	{
		#region Member Variables

		protected int id;
		protected string product;
		protected int num;
		protected decimal price;
		protected string content;
		protected string appuserid;
		protected DateTime appdate;
		protected int scheckuserid;
		protected DateTime scheckdate;
		protected int echeckuserid;
		protected DateTime echeckdate;
		protected int checktype;
		protected string cgzk;
		protected DateTime cgzkdate;
		protected bool state;
		protected bool _bIsDeleted;
		protected bool _bIsChanged;
		#endregion
		
		#region Constructors
		public AssetsApplay() {}
		
		public AssetsApplay(string pProduct, int pNum, decimal pPrice, string pContent, string pAppUserid, DateTime pAppDate, int pScheckUserid, DateTime pScheckDate, int pEcheckUserid, DateTime pEcheckDate, int pCheckType, string pCgzk, DateTime pCgzkDate, bool pState)
		{
			this.product = pProduct; 
			this.num = pNum; 
			this.price = pPrice; 
			this.content = pContent; 
			this.appuserid = pAppUserid; 
			this.appdate = pAppDate; 
			this.scheckuserid = pScheckUserid; 
			this.scheckdate = pScheckDate; 
			this.echeckuserid = pEcheckUserid; 
			this.echeckdate = pEcheckDate; 
			this.checktype = pCheckType; 
			this.cgzk = pCgzk; 
			this.cgzkdate = pCgzkDate; 
			this.state = pState; 
		}
		
		public AssetsApplay(int pId)
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
		
		public string Product
		{
			get { return product; }
			set 
			{
			  if (value != null && value.Length > 50)
			    throw new ArgumentOutOfRangeException("Product", "Product value, cannot contain more than 50 characters");
			  _bIsChanged |= (product != value); 
			  product = value; 
			}
			
		}
		
		public int Num
		{
			get { return num; }
			set { _bIsChanged |= (num != value); num = value; }
			
		}
		
		public decimal Price
		{
			get { return price; }
			set { _bIsChanged |= (price != value); price = value; }
			
		}
		
		public string Content
		{
			get { return content; }
			set 
			{
			  if (value != null && value.Length > 50)
			    throw new ArgumentOutOfRangeException("Content", "Content value, cannot contain more than 50 characters");
			  _bIsChanged |= (content != value); 
			  content = value; 
			}
			
		}
		
		public string AppUserid
		{
			get { return appuserid; }
			set 
			{
			  if (value != null && value.Length > 50)
			    throw new ArgumentOutOfRangeException("AppUserid", "AppUserid value, cannot contain more than 50 characters");
			  _bIsChanged |= (appuserid != value); 
			  appuserid = value; 
			}
			
		}
		
		public DateTime AppDate
		{
			get { return appdate; }
			set { _bIsChanged |= (appdate != value); appdate = value; }
			
		}
		
		public int SCheckUserid
		{
			get { return scheckuserid; }
			set { _bIsChanged |= (scheckuserid != value); scheckuserid = value; }
			
		}
		
		public DateTime SCheckDate
		{
			get { return scheckdate; }
			set { _bIsChanged |= (scheckdate != value); scheckdate = value; }
			
		}
		
		public int ECheckUserid
		{
			get { return echeckuserid; }
			set { _bIsChanged |= (echeckuserid != value); echeckuserid = value; }
			
		}
		
		public DateTime ECheckDate
		{
			get { return echeckdate; }
			set { _bIsChanged |= (echeckdate != value); echeckdate = value; }
			
		}
		
		public int CheckType
		{
			get { return checktype; }
			set { _bIsChanged |= (checktype != value); checktype = value; }
			
		}
		
		public string Cgzk
		{
			get { return cgzk; }
			set 
			{
			  if (value != null && value.Length > 1073741823)
			    throw new ArgumentOutOfRangeException("Cgzk", "Cgzk value, cannot contain more than 1073741823 characters");
			  _bIsChanged |= (cgzk != value); 
			  cgzk = value; 
			}
			
		}
		
		public DateTime CgzkDate
		{
			get { return cgzkdate; }
			set { _bIsChanged |= (cgzkdate != value); cgzkdate = value; }
			
		}
		
		public bool State
		{
			get { return state; }
			set { _bIsChanged |= (state != value); state = value; }
			
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
	
	#region Custom ICollection interface for AssetsApplay 

	
	public interface IAssetsApplayCollection : ICollection
	{
		AssetsApplay this[int index]{	get; set; }
		void Add(AssetsApplay pAssetsApplay);
		void Clear();
	}
	
	[Serializable]
	public class AssetsApplayCollection : IAssetsApplayCollection
	{
		private IList<AssetsApplay> _arrayInternal;

		public AssetsApplayCollection()
		{
			_arrayInternal = new List<AssetsApplay>();
		}
		
		public AssetsApplayCollection( IList<AssetsApplay> pSource )
		{
			_arrayInternal = pSource;
			if(_arrayInternal == null)
			{
				_arrayInternal = new List<AssetsApplay>();
			}
		}

		public AssetsApplay this[int index]
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
		public void CopyTo(Array array, int index){ _arrayInternal.CopyTo((AssetsApplay[])array, index); }
		public IEnumerator GetEnumerator() { return _arrayInternal.GetEnumerator(); }
		public void Add(AssetsApplay pAssetsApplay) { _arrayInternal.Add(pAssetsApplay); }
		public void Clear() { _arrayInternal.Clear(); }
		public IList<AssetsApplay> GetList() { return _arrayInternal; }
	 }
	
	#endregion
}
