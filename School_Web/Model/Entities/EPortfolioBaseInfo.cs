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
	/// IEPortfolioBaseInfo interface for NHibernate mapped table 'ePortfolio_BaseInfo'.
	/// </summary>
	public interface IEPortfolioBaseInfo
	{
		#region Public Properties
		
		int Id
		{
			get ;
			set ;
			  
		}
		
		int UserId
		{
			get ;
			set ;
			  
		}
		
		string Truename
		{
			get ;
			set ;
			  
		}
		
		string PicSrc
		{
			get ;
			set ;
			  
		}
		
		string Zw
		{
			get ;
			set ;
			  
		}
		
		string Sex
		{
			get ;
			set ;
			  
		}
		
		string Csny
		{
			get ;
			set ;
			  
		}
		
		string Jg
		{
			get ;
			set ;
			  
		}
		
		string Zgxl
		{
			get ;
			set ;
			  
		}
		
		string Bysj
		{
			get ;
			set ;
			  
		}
		
		string Byxx
		{
			get ;
			set ;
			  
		}
		
		string Sxzy
		{
			get ;
			set ;
			  
		}
		
		string Cjgzsj
		{
			get ;
			set ;
			  
		}
		
		string Zyjszw
		{
			get ;
			set ;
			  
		}
		
		string Jssj
		{
			get ;
			set ;
			  
		}
		
		string Zzmm
		{
			get ;
			set ;
			  
		}
		
		string Hjqk
		{
			get ;
			set ;
			  
		}
		
		bool Checked
		{
			get ;
			set ;
			  
		}
		
		string Email
		{
			get ;
			set ;
			  
		}
		
		string Tel
		{
			get ;
			set ;
			  
		}
		
		string Mtel
		{
			get ;
			set ;
			  
		}
		
		string Smtel
		{
			get ;
			set ;
			  
		}
		
		string Gzyl
		{
			get ;
			set ;
			  
		}
		
		string Bzrnx
		{
			get ;
			set ;
			  
		}
		
		DateTime Pubdate
		{
			get ;
			set ;
			  
		}
		
		string Address
		{
			get ;
			set ;
			  
		}
		
		bool IsDeleted { get; set; }
		bool IsChanged { get; set; }
		
		#endregion 
	}

	/// <summary>
	/// EPortfolioBaseInfo object for NHibernate mapped table 'ePortfolio_BaseInfo'.
	/// </summary>
	[Serializable]
	public class EPortfolioBaseInfo : IEPortfolioBaseInfo
	{
		#region Member Variables

		protected int id;
		protected int userid;
		protected string truename;
		protected string picsrc;
		protected string zw;
		protected string sex;
		protected string csny;
		protected string jg;
		protected string zgxl;
		protected string bysj;
		protected string byxx;
		protected string sxzy;
		protected string cjgzsj;
		protected string zyjszw;
		protected string jssj;
		protected string zzmm;
		protected string hjqk;
		protected bool checked;
		protected string email;
		protected string tel;
		protected string mtel;
		protected string smtel;
		protected string gzyl;
		protected string bzrnx;
		protected DateTime pubdate;
		protected string address;
		protected bool _bIsDeleted;
		protected bool _bIsChanged;
		#endregion
		
		#region Constructors
		public EPortfolioBaseInfo() {}
		
		public EPortfolioBaseInfo(int pUserId, string pTruename, string pPicSrc, string pZw, string pSex, string pCsny, string pJg, string pZgxl, string pBysj, string pByxx, string pSxzy, string pCjgzsj, string pZyjszw, string pJssj, string pZzmm, string pHjqk, bool pChecked, string pEmail, string pTel, string pMtel, string pSmtel, string pGzyl, string pBzrnx, DateTime pPubdate, string pAddress)
		{
			this.userid = pUserId; 
			this.truename = pTruename; 
			this.picsrc = pPicSrc; 
			this.zw = pZw; 
			this.sex = pSex; 
			this.csny = pCsny; 
			this.jg = pJg; 
			this.zgxl = pZgxl; 
			this.bysj = pBysj; 
			this.byxx = pByxx; 
			this.sxzy = pSxzy; 
			this.cjgzsj = pCjgzsj; 
			this.zyjszw = pZyjszw; 
			this.jssj = pJssj; 
			this.zzmm = pZzmm; 
			this.hjqk = pHjqk; 
			this.checked = pChecked; 
			this.email = pEmail; 
			this.tel = pTel; 
			this.mtel = pMtel; 
			this.smtel = pSmtel; 
			this.gzyl = pGzyl; 
			this.bzrnx = pBzrnx; 
			this.pubdate = pPubdate; 
			this.address = pAddress; 
		}
		
		#endregion
		
		#region Public Properties
		
		public int Id
		{
			get { return id; }
			set { _bIsChanged |= (id != value); id = value; }
			
		}
		
		public int UserId
		{
			get { return userid; }
			set { _bIsChanged |= (userid != value); userid = value; }
			
		}
		
		public string Truename
		{
			get { return truename; }
			set 
			{
			  if (value != null && value.Length > 50)
			    throw new ArgumentOutOfRangeException("Truename", "Truename value, cannot contain more than 50 characters");
			  _bIsChanged |= (truename != value); 
			  truename = value; 
			}
			
		}
		
		public string PicSrc
		{
			get { return picsrc; }
			set 
			{
			  if (value != null && value.Length > 200)
			    throw new ArgumentOutOfRangeException("PicSrc", "PicSrc value, cannot contain more than 200 characters");
			  _bIsChanged |= (picsrc != value); 
			  picsrc = value; 
			}
			
		}
		
		public string Zw
		{
			get { return zw; }
			set 
			{
			  if (value != null && value.Length > 50)
			    throw new ArgumentOutOfRangeException("Zw", "Zw value, cannot contain more than 50 characters");
			  _bIsChanged |= (zw != value); 
			  zw = value; 
			}
			
		}
		
		public string Sex
		{
			get { return sex; }
			set 
			{
			  if (value != null && value.Length > 50)
			    throw new ArgumentOutOfRangeException("Sex", "Sex value, cannot contain more than 50 characters");
			  _bIsChanged |= (sex != value); 
			  sex = value; 
			}
			
		}
		
		public string Csny
		{
			get { return csny; }
			set 
			{
			  if (value != null && value.Length > 50)
			    throw new ArgumentOutOfRangeException("Csny", "Csny value, cannot contain more than 50 characters");
			  _bIsChanged |= (csny != value); 
			  csny = value; 
			}
			
		}
		
		public string Jg
		{
			get { return jg; }
			set 
			{
			  if (value != null && value.Length > 50)
			    throw new ArgumentOutOfRangeException("Jg", "Jg value, cannot contain more than 50 characters");
			  _bIsChanged |= (jg != value); 
			  jg = value; 
			}
			
		}
		
		public string Zgxl
		{
			get { return zgxl; }
			set 
			{
			  if (value != null && value.Length > 50)
			    throw new ArgumentOutOfRangeException("Zgxl", "Zgxl value, cannot contain more than 50 characters");
			  _bIsChanged |= (zgxl != value); 
			  zgxl = value; 
			}
			
		}
		
		public string Bysj
		{
			get { return bysj; }
			set 
			{
			  if (value != null && value.Length > 50)
			    throw new ArgumentOutOfRangeException("Bysj", "Bysj value, cannot contain more than 50 characters");
			  _bIsChanged |= (bysj != value); 
			  bysj = value; 
			}
			
		}
		
		public string Byxx
		{
			get { return byxx; }
			set 
			{
			  if (value != null && value.Length > 50)
			    throw new ArgumentOutOfRangeException("Byxx", "Byxx value, cannot contain more than 50 characters");
			  _bIsChanged |= (byxx != value); 
			  byxx = value; 
			}
			
		}
		
		public string Sxzy
		{
			get { return sxzy; }
			set 
			{
			  if (value != null && value.Length > 50)
			    throw new ArgumentOutOfRangeException("Sxzy", "Sxzy value, cannot contain more than 50 characters");
			  _bIsChanged |= (sxzy != value); 
			  sxzy = value; 
			}
			
		}
		
		public string Cjgzsj
		{
			get { return cjgzsj; }
			set 
			{
			  if (value != null && value.Length > 50)
			    throw new ArgumentOutOfRangeException("Cjgzsj", "Cjgzsj value, cannot contain more than 50 characters");
			  _bIsChanged |= (cjgzsj != value); 
			  cjgzsj = value; 
			}
			
		}
		
		public string Zyjszw
		{
			get { return zyjszw; }
			set 
			{
			  if (value != null && value.Length > 50)
			    throw new ArgumentOutOfRangeException("Zyjszw", "Zyjszw value, cannot contain more than 50 characters");
			  _bIsChanged |= (zyjszw != value); 
			  zyjszw = value; 
			}
			
		}
		
		public string Jssj
		{
			get { return jssj; }
			set 
			{
			  if (value != null && value.Length > 50)
			    throw new ArgumentOutOfRangeException("Jssj", "Jssj value, cannot contain more than 50 characters");
			  _bIsChanged |= (jssj != value); 
			  jssj = value; 
			}
			
		}
		
		public string Zzmm
		{
			get { return zzmm; }
			set 
			{
			  if (value != null && value.Length > 50)
			    throw new ArgumentOutOfRangeException("Zzmm", "Zzmm value, cannot contain more than 50 characters");
			  _bIsChanged |= (zzmm != value); 
			  zzmm = value; 
			}
			
		}
		
		public string Hjqk
		{
			get { return hjqk; }
			set 
			{
			  if (value != null && value.Length > 1073741823)
			    throw new ArgumentOutOfRangeException("Hjqk", "Hjqk value, cannot contain more than 1073741823 characters");
			  _bIsChanged |= (hjqk != value); 
			  hjqk = value; 
			}
			
		}
		
		public bool Checked
		{
			get { return checked; }
			set { _bIsChanged |= (checked != value); checked = value; }
			
		}
		
		public string Email
		{
			get { return email; }
			set 
			{
			  if (value != null && value.Length > 50)
			    throw new ArgumentOutOfRangeException("Email", "Email value, cannot contain more than 50 characters");
			  _bIsChanged |= (email != value); 
			  email = value; 
			}
			
		}
		
		public string Tel
		{
			get { return tel; }
			set 
			{
			  if (value != null && value.Length > 50)
			    throw new ArgumentOutOfRangeException("Tel", "Tel value, cannot contain more than 50 characters");
			  _bIsChanged |= (tel != value); 
			  tel = value; 
			}
			
		}
		
		public string Mtel
		{
			get { return mtel; }
			set 
			{
			  if (value != null && value.Length > 50)
			    throw new ArgumentOutOfRangeException("Mtel", "Mtel value, cannot contain more than 50 characters");
			  _bIsChanged |= (mtel != value); 
			  mtel = value; 
			}
			
		}
		
		public string Smtel
		{
			get { return smtel; }
			set 
			{
			  if (value != null && value.Length > 50)
			    throw new ArgumentOutOfRangeException("Smtel", "Smtel value, cannot contain more than 50 characters");
			  _bIsChanged |= (smtel != value); 
			  smtel = value; 
			}
			
		}
		
		public string Gzyl
		{
			get { return gzyl; }
			set 
			{
			  if (value != null && value.Length > 1073741823)
			    throw new ArgumentOutOfRangeException("Gzyl", "Gzyl value, cannot contain more than 1073741823 characters");
			  _bIsChanged |= (gzyl != value); 
			  gzyl = value; 
			}
			
		}
		
		public string Bzrnx
		{
			get { return bzrnx; }
			set 
			{
			  if (value != null && value.Length > 1073741823)
			    throw new ArgumentOutOfRangeException("Bzrnx", "Bzrnx value, cannot contain more than 1073741823 characters");
			  _bIsChanged |= (bzrnx != value); 
			  bzrnx = value; 
			}
			
		}
		
		public DateTime Pubdate
		{
			get { return pubdate; }
			set { _bIsChanged |= (pubdate != value); pubdate = value; }
			
		}
		
		public string Address
		{
			get { return address; }
			set 
			{
			  if (value != null && value.Length > 250)
			    throw new ArgumentOutOfRangeException("Address", "Address value, cannot contain more than 250 characters");
			  _bIsChanged |= (address != value); 
			  address = value; 
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
	
	#region Custom ICollection interface for EPortfolioBaseInfo 

	
	public interface IEPortfolioBaseInfoCollection : ICollection
	{
		EPortfolioBaseInfo this[int index]{	get; set; }
		void Add(EPortfolioBaseInfo pEPortfolioBaseInfo);
		void Clear();
	}
	
	[Serializable]
	public class EPortfolioBaseInfoCollection : IEPortfolioBaseInfoCollection
	{
		private IList<EPortfolioBaseInfo> _arrayInternal;

		public EPortfolioBaseInfoCollection()
		{
			_arrayInternal = new List<EPortfolioBaseInfo>();
		}
		
		public EPortfolioBaseInfoCollection( IList<EPortfolioBaseInfo> pSource )
		{
			_arrayInternal = pSource;
			if(_arrayInternal == null)
			{
				_arrayInternal = new List<EPortfolioBaseInfo>();
			}
		}

		public EPortfolioBaseInfo this[int index]
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
		public void CopyTo(Array array, int index){ _arrayInternal.CopyTo((EPortfolioBaseInfo[])array, index); }
		public IEnumerator GetEnumerator() { return _arrayInternal.GetEnumerator(); }
		public void Add(EPortfolioBaseInfo pEPortfolioBaseInfo) { _arrayInternal.Add(pEPortfolioBaseInfo); }
		public void Clear() { _arrayInternal.Clear(); }
		public IList<EPortfolioBaseInfo> GetList() { return _arrayInternal; }
	 }
	
	#endregion
}
