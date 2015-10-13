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
	/// IInvestSubjectlist interface for NHibernate mapped table 'Invest_subjectlist'.
	/// </summary>
	public interface IInvestSubjectlist
	{
		#region Public Properties
		
		int Id
		{
			get ;
			set ;
			  
		}
		
		int Classid
		{
			get ;
			set ;
			  
		}
		
		int Pindex
		{
			get ;
			set ;
			  
		}
		
		int Subjectid
		{
			get ;
			set ;
			  
		}
		
		bool Sexed
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
	/// InvestSubjectlist object for NHibernate mapped table 'Invest_subjectlist'.
	/// </summary>
	[Serializable]
	public class InvestSubjectlist : IInvestSubjectlist
	{
		#region Member Variables

		protected int id;
		protected int classid;
		protected int pindex;
		protected int subjectid;
		protected bool sexed;
		protected int investid;
		protected bool _bIsDeleted;
		protected bool _bIsChanged;
		#endregion
		
		#region Constructors
		public InvestSubjectlist() {}
		
		public InvestSubjectlist(int pClassid, int pPindex, int pSubjectid, bool pSexed, int pInvestId)
		{
			this.classid = pClassid; 
			this.pindex = pPindex; 
			this.subjectid = pSubjectid; 
			this.sexed = pSexed; 
			this.investid = pInvestId; 
		}
		
		public InvestSubjectlist(int pId)
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
		
		public int Classid
		{
			get { return classid; }
			set { _bIsChanged |= (classid != value); classid = value; }
			
		}
		
		public int Pindex
		{
			get { return pindex; }
			set { _bIsChanged |= (pindex != value); pindex = value; }
			
		}
		
		public int Subjectid
		{
			get { return subjectid; }
			set { _bIsChanged |= (subjectid != value); subjectid = value; }
			
		}
		
		public bool Sexed
		{
			get { return sexed; }
			set { _bIsChanged |= (sexed != value); sexed = value; }
			
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
	
	#region Custom ICollection interface for InvestSubjectlist 

	
	public interface IInvestSubjectlistCollection : ICollection
	{
		InvestSubjectlist this[int index]{	get; set; }
		void Add(InvestSubjectlist pInvestSubjectlist);
		void Clear();
	}
	
	[Serializable]
	public class InvestSubjectlistCollection : IInvestSubjectlistCollection
	{
		private IList<InvestSubjectlist> _arrayInternal;

		public InvestSubjectlistCollection()
		{
			_arrayInternal = new List<InvestSubjectlist>();
		}
		
		public InvestSubjectlistCollection( IList<InvestSubjectlist> pSource )
		{
			_arrayInternal = pSource;
			if(_arrayInternal == null)
			{
				_arrayInternal = new List<InvestSubjectlist>();
			}
		}

		public InvestSubjectlist this[int index]
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
		public void CopyTo(Array array, int index){ _arrayInternal.CopyTo((InvestSubjectlist[])array, index); }
		public IEnumerator GetEnumerator() { return _arrayInternal.GetEnumerator(); }
		public void Add(InvestSubjectlist pInvestSubjectlist) { _arrayInternal.Add(pInvestSubjectlist); }
		public void Clear() { _arrayInternal.Clear(); }
		public IList<InvestSubjectlist> GetList() { return _arrayInternal; }
	 }
	
	#endregion
}
