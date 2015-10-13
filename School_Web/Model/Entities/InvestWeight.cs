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
	/// IInvestWeight interface for NHibernate mapped table 'Invest_weight'.
	/// </summary>
	public interface IInvestWeight
	{
		#region Public Properties
		
		int Id
		{
			get ;
			set ;
			  
		}
		
		string WTitle
		{
			get ;
			set ;
			  
		}
		
		double Weight
		{
			get ;
			set ;
			  
		}
		
		int InvestId
		{
			get ;
			set ;
			  
		}
		
		bool IsDeleted { get; set; }
		bool IsChanged { get; set; }
		
		#endregion 
	}

	/// <summary>
	/// InvestWeight object for NHibernate mapped table 'Invest_weight'.
	/// </summary>
	[Serializable]
	public class InvestWeight : IInvestWeight
	{
		#region Member Variables

		protected int id;
		protected string wtitle;
		protected double weight;
		protected int investid;
		protected bool _bIsDeleted;
		protected bool _bIsChanged;
		#endregion
		
		#region Constructors
		public InvestWeight() {}
		
		public InvestWeight(string pWtitle, double pWeight, int pInvestId)
		{
			this.wtitle = pWtitle; 
			this.weight = pWeight; 
			this.investid = pInvestId; 
		}
		
		public InvestWeight(int pId)
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
		
		public string WTitle
		{
			get { return wtitle; }
			set 
			{
			  if (value != null && value.Length > 50)
			    throw new ArgumentOutOfRangeException("WTitle", "WTitle value, cannot contain more than 50 characters");
			  _bIsChanged |= (wtitle != value); 
			  wtitle = value; 
			}
			
		}
		
		public double Weight
		{
			get { return weight; }
			set { _bIsChanged |= (weight != value); weight = value; }
			
		}
		
		public int InvestId
		{
			get { return investid; }
			set { _bIsChanged |= (investid != value); investid = value; }
			
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
	
	#region Custom ICollection interface for InvestWeight 

	
	public interface IInvestWeightCollection : ICollection
	{
		InvestWeight this[int index]{	get; set; }
		void Add(InvestWeight pInvestWeight);
		void Clear();
	}
	
	[Serializable]
	public class InvestWeightCollection : IInvestWeightCollection
	{
		private IList<InvestWeight> _arrayInternal;

		public InvestWeightCollection()
		{
			_arrayInternal = new List<InvestWeight>();
		}
		
		public InvestWeightCollection( IList<InvestWeight> pSource )
		{
			_arrayInternal = pSource;
			if(_arrayInternal == null)
			{
				_arrayInternal = new List<InvestWeight>();
			}
		}

		public InvestWeight this[int index]
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
		public void CopyTo(Array array, int index){ _arrayInternal.CopyTo((InvestWeight[])array, index); }
		public IEnumerator GetEnumerator() { return _arrayInternal.GetEnumerator(); }
		public void Add(InvestWeight pInvestWeight) { _arrayInternal.Add(pInvestWeight); }
		public void Clear() { _arrayInternal.Clear(); }
		public IList<InvestWeight> GetList() { return _arrayInternal; }
	 }
	
	#endregion
}
