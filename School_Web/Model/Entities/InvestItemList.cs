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
	/// IInvestItemList interface for NHibernate mapped table 'Invest_ItemList'.
	/// </summary>
	public interface IInvestItemList
	{
		#region Public Properties
		
		long ItemId
		{
			get ;
			set ;
			  
		}
		
		int Pindex
		{
			get ;
			set ;
			  
		}
		
		int InvestId
		{
			get ;
			set ;
			  
		}
		
		string Title
		{
			get ;
			set ;
			  
		}
		
		int Cent
		{
			get ;
			set ;
			  
		}
		
		bool IsDeleted { get; set; }
		bool IsChanged { get; set; }
		
		#endregion 
	}

	/// <summary>
	/// InvestItemList object for NHibernate mapped table 'Invest_ItemList'.
	/// </summary>
	[Serializable]
	public class InvestItemList : IInvestItemList
	{
		#region Member Variables

		protected long itemid;
		protected int pindex;
		protected int investid;
		protected string title;
		protected int cent;
		protected bool _bIsDeleted;
		protected bool _bIsChanged;
		#endregion
		
		#region Constructors
		public InvestItemList() {}
		
		public InvestItemList(int pPindex, int pInvestId, string pTitle, int pCent)
		{
			this.pindex = pPindex; 
			this.investid = pInvestId; 
			this.title = pTitle; 
			this.cent = pCent; 
		}
		
		public InvestItemList(int pInvestId, string pTitle, int pCent)
		{
			this.investid = pInvestId; 
			this.title = pTitle; 
			this.cent = pCent; 
		}
		
		public InvestItemList(long pItemId)
		{
			this.itemid = pItemId; 
		}
		
		#endregion
		
		#region Public Properties
		
		public long ItemId
		{
			get { return itemid; }
			set { _bIsChanged |= (itemid != value); itemid = value; }
			
		}
		
		public int Pindex
		{
			get { return pindex; }
			set { _bIsChanged |= (pindex != value); pindex = value; }
			
		}
		
		public int InvestId
		{
			get { return investid; }
			set { _bIsChanged |= (investid != value); investid = value; }
			
		}
		
		public string Title
		{
			get { return title; }
			set 
			{
			  if (value != null && value.Length > 250)
			    throw new ArgumentOutOfRangeException("Title", "Title value, cannot contain more than 250 characters");
			  _bIsChanged |= (title != value); 
			  title = value; 
			}
			
		}
		
		public int Cent
		{
			get { return cent; }
			set { _bIsChanged |= (cent != value); cent = value; }
			
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
	
	#region Custom ICollection interface for InvestItemList 

	
	public interface IInvestItemListCollection : ICollection
	{
		InvestItemList this[int index]{	get; set; }
		void Add(InvestItemList pInvestItemList);
		void Clear();
	}
	
	[Serializable]
	public class InvestItemListCollection : IInvestItemListCollection
	{
		private IList<InvestItemList> _arrayInternal;

		public InvestItemListCollection()
		{
			_arrayInternal = new List<InvestItemList>();
		}
		
		public InvestItemListCollection( IList<InvestItemList> pSource )
		{
			_arrayInternal = pSource;
			if(_arrayInternal == null)
			{
				_arrayInternal = new List<InvestItemList>();
			}
		}

		public InvestItemList this[int index]
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
		public void CopyTo(Array array, int index){ _arrayInternal.CopyTo((InvestItemList[])array, index); }
		public IEnumerator GetEnumerator() { return _arrayInternal.GetEnumerator(); }
		public void Add(InvestItemList pInvestItemList) { _arrayInternal.Add(pInvestItemList); }
		public void Clear() { _arrayInternal.Clear(); }
		public IList<InvestItemList> GetList() { return _arrayInternal; }
	 }
	
	#endregion
}
