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
	/// IAssets interface for NHibernate mapped table 'Assets'.
	/// </summary>
	public interface IAssets
	{
		#region Public Properties
		
		int Assetsid
		{
			get ;
			set ;
			  
		}
		
		int Typeid
		{
			get ;
			set ;
			  
		}
		
		int MagUserid
		{
			get ;
			set ;
			  
		}
		
		int Caseid
		{
			get ;
			set ;
			  
		}
		
		string CardCode
		{
			get ;
			set ;
			  
		}
		
		string Barcode
		{
			get ;
			set ;
			  
		}
		
		string Title
		{
			get ;
			set ;
			  
		}
		
		string TitlePin
		{
			get ;
			set ;
			  
		}
		
		decimal Price
		{
			get ;
			set ;
			  
		}
		
		int Number
		{
			get ;
			set ;
			  
		}
		
		string Unit
		{
			get ;
			set ;
			  
		}
		
		string Remark
		{
			get ;
			set ;
			  
		}
		
		DateTime Pubdate
		{
			get ;
			set ;
			  
		}
		
		DateTime AccountedPubdate
		{
			get ;
			set ;
			  
		}
		
		DateTime BuyPubdate
		{
			get ;
			set ;
			  
		}
		
		string Format
		{
			get ;
			set ;
			  
		}
		
		string FactoryNumber
		{
			get ;
			set ;
			  
		}
		
		string Factory
		{
			get ;
			set ;
			  
		}
		
		string Style
		{
			get ;
			set ;
			  
		}
		
		DateTime PurchaseDate
		{
			get ;
			set ;
			  
		}
		
		DateTime ManufactureDate
		{
			get ;
			set ;
			  
		}
		
		DateTime PeriodLimitDate
		{
			get ;
			set ;
			  
		}
		
		string Country
		{
			get ;
			set ;
			  
		}
		
		string InvoiceCode
		{
			get ;
			set ;
			  
		}
		
		int FundCaseid
		{
			get ;
			set ;
			  
		}
		
		int SourceCaseid
		{
			get ;
			set ;
			  
		}
		
		int ApplyCaseid
		{
			get ;
			set ;
			  
		}
		
		string PurchaseCode
		{
			get ;
			set ;
			  
		}
		
		string Supplier
		{
			get ;
			set ;
			  
		}
		
		string SupplierManager
		{
			get ;
			set ;
			  
		}
		
		decimal ForeignCurrencyPrice
		{
			get ;
			set ;
			  
		}
		
		decimal TransportationCosts
		{
			get ;
			set ;
			  
		}
		
		decimal Penalty
		{
			get ;
			set ;
			  
		}
		
		decimal OtherCost
		{
			get ;
			set ;
			  
		}
		
		int LevelCount
		{
			get ;
			set ;
			  
		}
		
		bool IsDeleted { get; set; }
		bool IsChanged { get; set; }
		
		#endregion 
	}

	/// <summary>
	/// Assets object for NHibernate mapped table 'Assets'.
	/// </summary>
	[Serializable]
	public class Assets : IAssets
	{
		#region Member Variables

		protected int assetsid;
		protected int typeid;
		protected int maguserid;
		protected int caseid;
		protected string cardcode;
		protected string barcode;
		protected string title;
		protected string titlepin;
		protected decimal price;
		protected int number;
		protected string unit;
		protected string remark;
		protected DateTime pubdate;
		protected DateTime accountedpubdate;
		protected DateTime buypubdate;
		protected string format;
		protected string factorynumber;
		protected string factory;
		protected string style;
		protected DateTime purchasedate;
		protected DateTime manufacturedate;
		protected DateTime periodlimitdate;
		protected string country;
		protected string invoicecode;
		protected int fundcaseid;
		protected int sourcecaseid;
		protected int applycaseid;
		protected string purchasecode;
		protected string supplier;
		protected string suppliermanager;
		protected decimal foreigncurrencyprice;
		protected decimal transportationcosts;
		protected decimal penalty;
		protected decimal othercost;
		protected int levelcount;
		protected bool _bIsDeleted;
		protected bool _bIsChanged;
		#endregion
		
		#region Constructors
		public Assets() {}
		
		public Assets(int pTypeid, int pMagUserid, int pCaseid, string pCardCode, string pBarcode, string pTitle, string pTitlePin, decimal pPrice, int pNumber, string pUnit, string pRemark, DateTime pPubdate, DateTime pAccountedPubdate, DateTime pBuyPubdate, string pFormat, string pFactoryNumber, string pFactory, string pStyle, DateTime pPurchaseDate, DateTime pManufactureDate, DateTime pPeriodLimitDate, string pCountry, string pInvoiceCode, int pFundCaseid, int pSourceCaseid, int pApplyCaseid, string pPurchaseCode, string pSupplier, string pSupplierManager, decimal pForeignCurrencyPrice, decimal pTransportationCosts, decimal pPenalty, decimal pOtherCost, int pLevelCount)
		{
			this.typeid = pTypeid; 
			this.maguserid = pMagUserid; 
			this.caseid = pCaseid; 
			this.cardcode = pCardCode; 
			this.barcode = pBarcode; 
			this.title = pTitle; 
			this.titlepin = pTitlePin; 
			this.price = pPrice; 
			this.number = pNumber; 
			this.unit = pUnit; 
			this.remark = pRemark; 
			this.pubdate = pPubdate; 
			this.accountedpubdate = pAccountedPubdate; 
			this.buypubdate = pBuyPubdate; 
			this.format = pFormat; 
			this.factorynumber = pFactoryNumber; 
			this.factory = pFactory; 
			this.style = pStyle; 
			this.purchasedate = pPurchaseDate; 
			this.manufacturedate = pManufactureDate; 
			this.periodlimitdate = pPeriodLimitDate; 
			this.country = pCountry; 
			this.invoicecode = pInvoiceCode; 
			this.fundcaseid = pFundCaseid; 
			this.sourcecaseid = pSourceCaseid; 
			this.applycaseid = pApplyCaseid; 
			this.purchasecode = pPurchaseCode; 
			this.supplier = pSupplier; 
			this.suppliermanager = pSupplierManager; 
			this.foreigncurrencyprice = pForeignCurrencyPrice; 
			this.transportationcosts = pTransportationCosts; 
			this.penalty = pPenalty; 
			this.othercost = pOtherCost; 
			this.levelcount = pLevelCount; 
		}
		
		public Assets(int pAssetsid)
		{
			this.assetsid = pAssetsid; 
		}
		
		#endregion
		
		#region Public Properties
		
		public int Assetsid
		{
			get { return assetsid; }
			set { _bIsChanged |= (assetsid != value); assetsid = value; }
			
		}
		
		public int Typeid
		{
			get { return typeid; }
			set { _bIsChanged |= (typeid != value); typeid = value; }
			
		}
		
		public int MagUserid
		{
			get { return maguserid; }
			set { _bIsChanged |= (maguserid != value); maguserid = value; }
			
		}
		
		public int Caseid
		{
			get { return caseid; }
			set { _bIsChanged |= (caseid != value); caseid = value; }
			
		}
		
		public string CardCode
		{
			get { return cardcode; }
			set 
			{
			  if (value != null && value.Length > 50)
			    throw new ArgumentOutOfRangeException("CardCode", "CardCode value, cannot contain more than 50 characters");
			  _bIsChanged |= (cardcode != value); 
			  cardcode = value; 
			}
			
		}
		
		public string Barcode
		{
			get { return barcode; }
			set 
			{
			  if (value != null && value.Length > 50)
			    throw new ArgumentOutOfRangeException("Barcode", "Barcode value, cannot contain more than 50 characters");
			  _bIsChanged |= (barcode != value); 
			  barcode = value; 
			}
			
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
		
		public string TitlePin
		{
			get { return titlepin; }
			set 
			{
			  if (value != null && value.Length > 50)
			    throw new ArgumentOutOfRangeException("TitlePin", "TitlePin value, cannot contain more than 50 characters");
			  _bIsChanged |= (titlepin != value); 
			  titlepin = value; 
			}
			
		}
		
		public decimal Price
		{
			get { return price; }
			set { _bIsChanged |= (price != value); price = value; }
			
		}
		
		public int Number
		{
			get { return number; }
			set { _bIsChanged |= (number != value); number = value; }
			
		}
		
		public string Unit
		{
			get { return unit; }
			set 
			{
			  if (value != null && value.Length > 50)
			    throw new ArgumentOutOfRangeException("Unit", "Unit value, cannot contain more than 50 characters");
			  _bIsChanged |= (unit != value); 
			  unit = value; 
			}
			
		}
		
		public string Remark
		{
			get { return remark; }
			set 
			{
			  if (value != null && value.Length > 50)
			    throw new ArgumentOutOfRangeException("Remark", "Remark value, cannot contain more than 50 characters");
			  _bIsChanged |= (remark != value); 
			  remark = value; 
			}
			
		}
		
		public DateTime Pubdate
		{
			get { return pubdate; }
			set { _bIsChanged |= (pubdate != value); pubdate = value; }
			
		}
		
		public DateTime AccountedPubdate
		{
			get { return accountedpubdate; }
			set { _bIsChanged |= (accountedpubdate != value); accountedpubdate = value; }
			
		}
		
		public DateTime BuyPubdate
		{
			get { return buypubdate; }
			set { _bIsChanged |= (buypubdate != value); buypubdate = value; }
			
		}
		
		public string Format
		{
			get { return format; }
			set 
			{
			  if (value != null && value.Length > 50)
			    throw new ArgumentOutOfRangeException("Format", "Format value, cannot contain more than 50 characters");
			  _bIsChanged |= (format != value); 
			  format = value; 
			}
			
		}
		
		public string FactoryNumber
		{
			get { return factorynumber; }
			set 
			{
			  if (value != null && value.Length > 50)
			    throw new ArgumentOutOfRangeException("FactoryNumber", "FactoryNumber value, cannot contain more than 50 characters");
			  _bIsChanged |= (factorynumber != value); 
			  factorynumber = value; 
			}
			
		}
		
		public string Factory
		{
			get { return factory; }
			set 
			{
			  if (value != null && value.Length > 50)
			    throw new ArgumentOutOfRangeException("Factory", "Factory value, cannot contain more than 50 characters");
			  _bIsChanged |= (factory != value); 
			  factory = value; 
			}
			
		}
		
		public string Style
		{
			get { return style; }
			set 
			{
			  if (value != null && value.Length > 50)
			    throw new ArgumentOutOfRangeException("Style", "Style value, cannot contain more than 50 characters");
			  _bIsChanged |= (style != value); 
			  style = value; 
			}
			
		}
		
		public DateTime PurchaseDate
		{
			get { return purchasedate; }
			set { _bIsChanged |= (purchasedate != value); purchasedate = value; }
			
		}
		
		public DateTime ManufactureDate
		{
			get { return manufacturedate; }
			set { _bIsChanged |= (manufacturedate != value); manufacturedate = value; }
			
		}
		
		public DateTime PeriodLimitDate
		{
			get { return periodlimitdate; }
			set { _bIsChanged |= (periodlimitdate != value); periodlimitdate = value; }
			
		}
		
		public string Country
		{
			get { return country; }
			set 
			{
			  if (value != null && value.Length > 50)
			    throw new ArgumentOutOfRangeException("Country", "Country value, cannot contain more than 50 characters");
			  _bIsChanged |= (country != value); 
			  country = value; 
			}
			
		}
		
		public string InvoiceCode
		{
			get { return invoicecode; }
			set 
			{
			  if (value != null && value.Length > 50)
			    throw new ArgumentOutOfRangeException("InvoiceCode", "InvoiceCode value, cannot contain more than 50 characters");
			  _bIsChanged |= (invoicecode != value); 
			  invoicecode = value; 
			}
			
		}
		
		public int FundCaseid
		{
			get { return fundcaseid; }
			set { _bIsChanged |= (fundcaseid != value); fundcaseid = value; }
			
		}
		
		public int SourceCaseid
		{
			get { return sourcecaseid; }
			set { _bIsChanged |= (sourcecaseid != value); sourcecaseid = value; }
			
		}
		
		public int ApplyCaseid
		{
			get { return applycaseid; }
			set { _bIsChanged |= (applycaseid != value); applycaseid = value; }
			
		}
		
		public string PurchaseCode
		{
			get { return purchasecode; }
			set 
			{
			  if (value != null && value.Length > 50)
			    throw new ArgumentOutOfRangeException("PurchaseCode", "PurchaseCode value, cannot contain more than 50 characters");
			  _bIsChanged |= (purchasecode != value); 
			  purchasecode = value; 
			}
			
		}
		
		public string Supplier
		{
			get { return supplier; }
			set 
			{
			  if (value != null && value.Length > 50)
			    throw new ArgumentOutOfRangeException("Supplier", "Supplier value, cannot contain more than 50 characters");
			  _bIsChanged |= (supplier != value); 
			  supplier = value; 
			}
			
		}
		
		public string SupplierManager
		{
			get { return suppliermanager; }
			set 
			{
			  if (value != null && value.Length > 50)
			    throw new ArgumentOutOfRangeException("SupplierManager", "SupplierManager value, cannot contain more than 50 characters");
			  _bIsChanged |= (suppliermanager != value); 
			  suppliermanager = value; 
			}
			
		}
		
		public decimal ForeignCurrencyPrice
		{
			get { return foreigncurrencyprice; }
			set { _bIsChanged |= (foreigncurrencyprice != value); foreigncurrencyprice = value; }
			
		}
		
		public decimal TransportationCosts
		{
			get { return transportationcosts; }
			set { _bIsChanged |= (transportationcosts != value); transportationcosts = value; }
			
		}
		
		public decimal Penalty
		{
			get { return penalty; }
			set { _bIsChanged |= (penalty != value); penalty = value; }
			
		}
		
		public decimal OtherCost
		{
			get { return othercost; }
			set { _bIsChanged |= (othercost != value); othercost = value; }
			
		}
		
		public int LevelCount
		{
			get { return levelcount; }
			set { _bIsChanged |= (levelcount != value); levelcount = value; }
			
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
	
	#region Custom ICollection interface for Assets 

	
	public interface IAssetsCollection : ICollection
	{
		Assets this[int index]{	get; set; }
		void Add(Assets pAssets);
		void Clear();
	}
	
	[Serializable]
	public class AssetsCollection : IAssetsCollection
	{
		private IList<Assets> _arrayInternal;

		public AssetsCollection()
		{
			_arrayInternal = new List<Assets>();
		}
		
		public AssetsCollection( IList<Assets> pSource )
		{
			_arrayInternal = pSource;
			if(_arrayInternal == null)
			{
				_arrayInternal = new List<Assets>();
			}
		}

		public Assets this[int index]
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
		public void CopyTo(Array array, int index){ _arrayInternal.CopyTo((Assets[])array, index); }
		public IEnumerator GetEnumerator() { return _arrayInternal.GetEnumerator(); }
		public void Add(Assets pAssets) { _arrayInternal.Add(pAssets); }
		public void Clear() { _arrayInternal.Clear(); }
		public IList<Assets> GetList() { return _arrayInternal; }
	 }
	
	#endregion
}
