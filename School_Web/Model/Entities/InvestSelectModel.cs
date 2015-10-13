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
	/// IInvestSelectModel interface for NHibernate mapped table 'Invest_select_model'.
	/// </summary>
	public interface IInvestSelectModel
	{
		#region Public Properties
		
		int Id
		{
			get ;
			set ;
			  
		}
		
		int InvestId
		{
			get ;
			set ;
			  
		}
		
		int InvestModelId
		{
			get ;
			set ;
			  
		}
		
		int Pindex
		{
			get ;
			set ;
			  
		}
		
		bool NeedContent
		{
			get ;
			set ;
			  
		}
		
		int ThInfoshowtype
		{
			get ;
			set ;
			  
		}
		
		bool IsDeleted { get; set; }
		bool IsChanged { get; set; }
		
		#endregion 
	}

	/// <summary>
	/// InvestSelectModel object for NHibernate mapped table 'Invest_select_model'.
	/// </summary>
	[Serializable]
	public class InvestSelectModel : IInvestSelectModel
	{
		#region Member Variables

		protected int id;
		protected int investid;
		protected int investmodelid;
		protected int pindex;
		protected bool needcontent;
		protected int thinfoshowtype;
		protected bool _bIsDeleted;
		protected bool _bIsChanged;
		#endregion
		
		#region Constructors
		public InvestSelectModel() {}
		
		public InvestSelectModel(int pId, int pInvestId, int pInvestModelId, int pPindex, bool pNeedContent, int pThInfoshowtype)
		{
			this.id = pId; 
			this.investid = pInvestId; 
			this.investmodelid = pInvestModelId; 
			this.pindex = pPindex; 
			this.needcontent = pNeedContent; 
			this.thinfoshowtype = pThInfoshowtype; 
		}
		
		public InvestSelectModel(int pId)
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
		
		public int InvestId
		{
			get { return investid; }
			set { _bIsChanged |= (investid != value); investid = value; }
			
		}
		
		public int InvestModelId
		{
			get { return investmodelid; }
			set { _bIsChanged |= (investmodelid != value); investmodelid = value; }
			
		}
		
		public int Pindex
		{
			get { return pindex; }
			set { _bIsChanged |= (pindex != value); pindex = value; }
			
		}
		
		public bool NeedContent
		{
			get { return needcontent; }
			set { _bIsChanged |= (needcontent != value); needcontent = value; }
			
		}
		
		public int ThInfoshowtype
		{
			get { return thinfoshowtype; }
			set { _bIsChanged |= (thinfoshowtype != value); thinfoshowtype = value; }
			
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
	
	#region Custom ICollection interface for InvestSelectModel 

	
	public interface IInvestSelectModelCollection : ICollection
	{
		InvestSelectModel this[int index]{	get; set; }
		void Add(InvestSelectModel pInvestSelectModel);
		void Clear();
	}
	
	[Serializable]
	public class InvestSelectModelCollection : IInvestSelectModelCollection
	{
		private IList<InvestSelectModel> _arrayInternal;

		public InvestSelectModelCollection()
		{
			_arrayInternal = new List<InvestSelectModel>();
		}
		
		public InvestSelectModelCollection( IList<InvestSelectModel> pSource )
		{
			_arrayInternal = pSource;
			if(_arrayInternal == null)
			{
				_arrayInternal = new List<InvestSelectModel>();
			}
		}

		public InvestSelectModel this[int index]
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
		public void CopyTo(Array array, int index){ _arrayInternal.CopyTo((InvestSelectModel[])array, index); }
		public IEnumerator GetEnumerator() { return _arrayInternal.GetEnumerator(); }
		public void Add(InvestSelectModel pInvestSelectModel) { _arrayInternal.Add(pInvestSelectModel); }
		public void Clear() { _arrayInternal.Clear(); }
		public IList<InvestSelectModel> GetList() { return _arrayInternal; }
	 }
	
	#endregion
}
