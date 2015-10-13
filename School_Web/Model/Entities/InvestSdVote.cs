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
	/// IInvestSdVote interface for NHibernate mapped table 'Invest_SD_Vote'.
	/// </summary>
	public interface IInvestSdVote
	{
		#region Public Properties
		
		int Id
		{
			get ;
			set ;
			  
		}
		
		int Investid
		{
			get ;
			set ;
			  
		}
		
		int ObjUserid
		{
			get ;
			set ;
			  
		}
		
		int ByUserid
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
	/// InvestSdVote object for NHibernate mapped table 'Invest_SD_Vote'.
	/// </summary>
	[Serializable]
	public class InvestSdVote : IInvestSdVote
	{
		#region Member Variables

		protected int id;
		protected int investid;
		protected int objuserid;
		protected int byuserid;
		protected int cent;
		protected bool _bIsDeleted;
		protected bool _bIsChanged;
		#endregion
		
		#region Constructors
		public InvestSdVote() {}
		
		public InvestSdVote(int pId, int pInvestid, int pObjUserid, int pByUserid, int pCent)
		{
			this.id = pId; 
			this.investid = pInvestid; 
			this.objuserid = pObjUserid; 
			this.byuserid = pByUserid; 
			this.cent = pCent; 
		}
		
		public InvestSdVote(int pId)
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
		
		public int Investid
		{
			get { return investid; }
			set { _bIsChanged |= (investid != value); investid = value; }
			
		}
		
		public int ObjUserid
		{
			get { return objuserid; }
			set { _bIsChanged |= (objuserid != value); objuserid = value; }
			
		}
		
		public int ByUserid
		{
			get { return byuserid; }
			set { _bIsChanged |= (byuserid != value); byuserid = value; }
			
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
	
	#region Custom ICollection interface for InvestSdVote 

	
	public interface IInvestSdVoteCollection : ICollection
	{
		InvestSdVote this[int index]{	get; set; }
		void Add(InvestSdVote pInvestSdVote);
		void Clear();
	}
	
	[Serializable]
	public class InvestSdVoteCollection : IInvestSdVoteCollection
	{
		private IList<InvestSdVote> _arrayInternal;

		public InvestSdVoteCollection()
		{
			_arrayInternal = new List<InvestSdVote>();
		}
		
		public InvestSdVoteCollection( IList<InvestSdVote> pSource )
		{
			_arrayInternal = pSource;
			if(_arrayInternal == null)
			{
				_arrayInternal = new List<InvestSdVote>();
			}
		}

		public InvestSdVote this[int index]
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
		public void CopyTo(Array array, int index){ _arrayInternal.CopyTo((InvestSdVote[])array, index); }
		public IEnumerator GetEnumerator() { return _arrayInternal.GetEnumerator(); }
		public void Add(InvestSdVote pInvestSdVote) { _arrayInternal.Add(pInvestSdVote); }
		public void Clear() { _arrayInternal.Clear(); }
		public IList<InvestSdVote> GetList() { return _arrayInternal; }
	 }
	
	#endregion
}
