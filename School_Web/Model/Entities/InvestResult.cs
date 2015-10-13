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
	/// IInvestResult interface for NHibernate mapped table 'Invest_Result'.
	/// </summary>
	public interface IInvestResult
	{
		#region Public Properties
		
		int InvestUserId
		{
			get ;
			set ;
			  
		}
		
		int InvestClassSubjectId
		{
			get ;
			set ;
			  
		}
		
		int ObjUserId
		{
			get ;
			set ;
			  
		}
		
		int ByUserId
		{
			get ;
			set ;
			  
		}
		
		int ItemId
		{
			get ;
			set ;
			  
		}
		
		int InvestWeightId
		{
			get ;
			set ;
			  
		}
		
		bool IsDeleted { get; set; }
		bool IsChanged { get; set; }
		
		#endregion 
	}

	/// <summary>
	/// InvestResult object for NHibernate mapped table 'Invest_Result'.
	/// </summary>
	[Serializable]
	public class InvestResult : IInvestResult
	{
		#region Member Variables

		protected int investuserid;
		protected int investclasssubjectid;
		protected int objuserid;
		protected int byuserid;
		protected int itemid;
		protected int investweightid;
		protected bool _bIsDeleted;
		protected bool _bIsChanged;
		#endregion
		
		#region Constructors
		public InvestResult() {}
		
		public InvestResult(int pInvestClassSubjectId, int pObjUserId, int pByUserId, int pItemId, int pInvestWeightId)
		{
			this.investclasssubjectid = pInvestClassSubjectId; 
			this.objuserid = pObjUserId; 
			this.byuserid = pByUserId; 
			this.itemid = pItemId; 
			this.investweightid = pInvestWeightId; 
		}
		
		public InvestResult(int pInvestUserId)
		{
			this.investuserid = pInvestUserId; 
		}
		
		#endregion
		
		#region Public Properties
		
		public int InvestUserId
		{
			get { return investuserid; }
			set { _bIsChanged |= (investuserid != value); investuserid = value; }
			
		}
		
		public int InvestClassSubjectId
		{
			get { return investclasssubjectid; }
			set { _bIsChanged |= (investclasssubjectid != value); investclasssubjectid = value; }
			
		}
		
		public int ObjUserId
		{
			get { return objuserid; }
			set { _bIsChanged |= (objuserid != value); objuserid = value; }
			
		}
		
		public int ByUserId
		{
			get { return byuserid; }
			set { _bIsChanged |= (byuserid != value); byuserid = value; }
			
		}
		
		public int ItemId
		{
			get { return itemid; }
			set { _bIsChanged |= (itemid != value); itemid = value; }
			
		}
		
		public int InvestWeightId
		{
			get { return investweightid; }
			set { _bIsChanged |= (investweightid != value); investweightid = value; }
			
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
	
	#region Custom ICollection interface for InvestResult 

	
	public interface IInvestResultCollection : ICollection
	{
		InvestResult this[int index]{	get; set; }
		void Add(InvestResult pInvestResult);
		void Clear();
	}
	
	[Serializable]
	public class InvestResultCollection : IInvestResultCollection
	{
		private IList<InvestResult> _arrayInternal;

		public InvestResultCollection()
		{
			_arrayInternal = new List<InvestResult>();
		}
		
		public InvestResultCollection( IList<InvestResult> pSource )
		{
			_arrayInternal = pSource;
			if(_arrayInternal == null)
			{
				_arrayInternal = new List<InvestResult>();
			}
		}

		public InvestResult this[int index]
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
		public void CopyTo(Array array, int index){ _arrayInternal.CopyTo((InvestResult[])array, index); }
		public IEnumerator GetEnumerator() { return _arrayInternal.GetEnumerator(); }
		public void Add(InvestResult pInvestResult) { _arrayInternal.Add(pInvestResult); }
		public void Clear() { _arrayInternal.Clear(); }
		public IList<InvestResult> GetList() { return _arrayInternal; }
	 }
	
	#endregion
}
