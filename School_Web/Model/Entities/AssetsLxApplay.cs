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
	/// IAssetsLxApplay interface for NHibernate mapped table 'assets_lx_applay'.
	/// </summary>
	public interface IAssetsLxApplay
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
		
		string Ys
		{
			get ;
			set ;
			  
		}
		
		string Sg
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
		
		int State
		{
			get ;
			set ;
			  
		}
		
		string Js
		{
			get ;
			set ;
			  
		}
		
		DateTime JsDate
		{
			get ;
			set ;
			  
		}
		
		string Bz
		{
			get ;
			set ;
			  
		}
		
		bool IsDeleted { get; set; }
		bool IsChanged { get; set; }
		
		#endregion 
	}

	/// <summary>
	/// AssetsLxApplay object for NHibernate mapped table 'assets_lx_applay'.
	/// </summary>
	[Serializable]
	public class AssetsLxApplay : IAssetsLxApplay
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
		protected string ys;
		protected string sg;
		protected string cgzk;
		protected DateTime cgzkdate;
		protected int state;
		protected string js;
		protected DateTime jsdate;
		protected string bz;
		protected bool _bIsDeleted;
		protected bool _bIsChanged;
		#endregion
		
		#region Constructors
		public AssetsLxApplay() {}
		
		public AssetsLxApplay(int pId, string pProduct, int pNum, decimal pPrice, string pContent, string pAppUserid, DateTime pAppDate, int pScheckUserid, DateTime pScheckDate, int pEcheckUserid, DateTime pEcheckDate, int pCheckType, string pYs, string pSg, string pCgzk, DateTime pCgzkDate, int pState, string pJs, DateTime pJsDate, string pBz)
		{
			this.id = pId; 
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
			this.ys = pYs; 
			this.sg = pSg; 
			this.cgzk = pCgzk; 
			this.cgzkdate = pCgzkDate; 
			this.state = pState; 
			this.js = pJs; 
			this.jsdate = pJsDate; 
			this.bz = pBz; 
		}
		
		public AssetsLxApplay(int pId)
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
		
		public string Ys
		{
			get { return ys; }
			set 
			{
			  if (value != null && value.Length > 250)
			    throw new ArgumentOutOfRangeException("Ys", "Ys value, cannot contain more than 250 characters");
			  _bIsChanged |= (ys != value); 
			  ys = value; 
			}
			
		}
		
		public string Sg
		{
			get { return sg; }
			set 
			{
			  if (value != null && value.Length > 250)
			    throw new ArgumentOutOfRangeException("Sg", "Sg value, cannot contain more than 250 characters");
			  _bIsChanged |= (sg != value); 
			  sg = value; 
			}
			
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
		
		public int State
		{
			get { return state; }
			set { _bIsChanged |= (state != value); state = value; }
			
		}
		
		public string Js
		{
			get { return js; }
			set 
			{
			  if (value != null && value.Length > 50)
			    throw new ArgumentOutOfRangeException("Js", "Js value, cannot contain more than 50 characters");
			  _bIsChanged |= (js != value); 
			  js = value; 
			}
			
		}
		
		public DateTime JsDate
		{
			get { return jsdate; }
			set { _bIsChanged |= (jsdate != value); jsdate = value; }
			
		}
		
		public string Bz
		{
			get { return bz; }
			set 
			{
			  if (value != null && value.Length > 50)
			    throw new ArgumentOutOfRangeException("Bz", "Bz value, cannot contain more than 50 characters");
			  _bIsChanged |= (bz != value); 
			  bz = value; 
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
	
	#region Custom ICollection interface for AssetsLxApplay 

	
	public interface IAssetsLxApplayCollection : ICollection
	{
		AssetsLxApplay this[int index]{	get; set; }
		void Add(AssetsLxApplay pAssetsLxApplay);
		void Clear();
	}
	
	[Serializable]
	public class AssetsLxApplayCollection : IAssetsLxApplayCollection
	{
		private IList<AssetsLxApplay> _arrayInternal;

		public AssetsLxApplayCollection()
		{
			_arrayInternal = new List<AssetsLxApplay>();
		}
		
		public AssetsLxApplayCollection( IList<AssetsLxApplay> pSource )
		{
			_arrayInternal = pSource;
			if(_arrayInternal == null)
			{
				_arrayInternal = new List<AssetsLxApplay>();
			}
		}

		public AssetsLxApplay this[int index]
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
		public void CopyTo(Array array, int index){ _arrayInternal.CopyTo((AssetsLxApplay[])array, index); }
		public IEnumerator GetEnumerator() { return _arrayInternal.GetEnumerator(); }
		public void Add(AssetsLxApplay pAssetsLxApplay) { _arrayInternal.Add(pAssetsLxApplay); }
		public void Clear() { _arrayInternal.Clear(); }
		public IList<AssetsLxApplay> GetList() { return _arrayInternal; }
	 }
	
	#endregion
}
