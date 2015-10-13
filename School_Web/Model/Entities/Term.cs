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
	/// ITerm interface for NHibernate mapped table 'Term'.
	/// </summary>
	public interface ITerm
	{
		#region Public Properties
		
		int TermId
		{
			get ;
			set ;
			  
		}
		
		string Termname
		{
			get ;
			set ;
			  
		}
		
		bool State
		{
			get ;
			set ;
			  
		}
		
		DateTime WkStartDate
		{
			get ;
			set ;
			  
		}
		
		int WkNum
		{
			get ;
			set ;
			  
		}
		
		bool CurFlag
		{
			get ;
			set ;
			  
		}
		
		int Pindex
		{
			get ;
			set ;
			  
		}
		
		bool IsDeleted { get; set; }
		bool IsChanged { get; set; }
		
		#endregion 
	}

	/// <summary>
	/// Term object for NHibernate mapped table 'Term'.
	/// </summary>
	[Serializable]
	public class Term : ITerm
	{
		#region Member Variables

		protected int termid;
		protected string termname;
		protected bool state;
		protected DateTime wkstartdate;
		protected int wknum;
		protected bool curflag;
		protected int pindex;
		protected bool _bIsDeleted;
		protected bool _bIsChanged;
		#endregion
		
		#region Constructors
		public Term() {}
		
		public Term(string pTermname, bool pState, DateTime pWkStartDate, int pWkNum, bool pCurFlag, int pPindex)
		{
			this.termname = pTermname; 
			this.state = pState; 
			this.wkstartdate = pWkStartDate; 
			this.wknum = pWkNum; 
			this.curflag = pCurFlag; 
			this.pindex = pPindex; 
		}
		
		public Term(int pTermId)
		{
			this.termid = pTermId; 
		}
		
		#endregion
		
		#region Public Properties
		
		public int TermId
		{
			get { return termid; }
			set { _bIsChanged |= (termid != value); termid = value; }
			
		}
		
		public string Termname
		{
			get { return termname; }
			set 
			{
			  if (value != null && value.Length > 50)
			    throw new ArgumentOutOfRangeException("Termname", "Termname value, cannot contain more than 50 characters");
			  _bIsChanged |= (termname != value); 
			  termname = value; 
			}
			
		}
		
		public bool State
		{
			get { return state; }
			set { _bIsChanged |= (state != value); state = value; }
			
		}
		
		public DateTime WkStartDate
		{
			get { return wkstartdate; }
			set { _bIsChanged |= (wkstartdate != value); wkstartdate = value; }
			
		}
		
		public int WkNum
		{
			get { return wknum; }
			set { _bIsChanged |= (wknum != value); wknum = value; }
			
		}
		
		public bool CurFlag
		{
			get { return curflag; }
			set { _bIsChanged |= (curflag != value); curflag = value; }
			
		}
		
		public int Pindex
		{
			get { return pindex; }
			set { _bIsChanged |= (pindex != value); pindex = value; }
			
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
	
	#region Custom ICollection interface for Term 

	
	public interface ITermCollection : ICollection
	{
		Term this[int index]{	get; set; }
		void Add(Term pTerm);
		void Clear();
	}
	
	[Serializable]
	public class TermCollection : ITermCollection
	{
		private IList<Term> _arrayInternal;

		public TermCollection()
		{
			_arrayInternal = new List<Term>();
		}
		
		public TermCollection( IList<Term> pSource )
		{
			_arrayInternal = pSource;
			if(_arrayInternal == null)
			{
				_arrayInternal = new List<Term>();
			}
		}

		public Term this[int index]
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
		public void CopyTo(Array array, int index){ _arrayInternal.CopyTo((Term[])array, index); }
		public IEnumerator GetEnumerator() { return _arrayInternal.GetEnumerator(); }
		public void Add(Term pTerm) { _arrayInternal.Add(pTerm); }
		public void Clear() { _arrayInternal.Clear(); }
		public IList<Term> GetList() { return _arrayInternal; }
	 }
	
	#endregion
}
