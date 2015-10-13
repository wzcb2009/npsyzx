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
	/// IActiveePortAwardTotal interface for NHibernate mapped table 'ActiveePortAwardTotal'.
	/// </summary>
	public interface IActiveePortAwardTotal
	{
		#region Public Properties
		
		int Id
		{
			get ;
			set ;
			  
		}
		
		int ActiveId
		{
			get ;
			set ;
			  
		}
		
		int UserId
		{
			get ;
			set ;
			  
		}
		
		double Total
		{
			get ;
			set ;
			  
		}
		
		int ClassSortIndex
		{
			get ;
			set ;
			  
		}
		
		int GradeSortIndex
		{
			get ;
			set ;
			  
		}
		
		bool IsDeleted { get; set; }
		bool IsChanged { get; set; }
		
		#endregion 
	}

	/// <summary>
	/// ActiveePortAwardTotal object for NHibernate mapped table 'ActiveePortAwardTotal'.
	/// </summary>
	[Serializable]
	public class ActiveePortAwardTotal : IActiveePortAwardTotal
	{
		#region Member Variables

		protected int id;
		protected int activeid;
		protected int userid;
		protected double total;
		protected int classsortindex;
		protected int gradesortindex;
		protected bool _bIsDeleted;
		protected bool _bIsChanged;
		#endregion
		
		#region Constructors
		public ActiveePortAwardTotal() {}
		
		public ActiveePortAwardTotal(int pActiveId, int pUserId, double pTotal, int pClassSortIndex, int pGradeSortIndex)
		{
			this.activeid = pActiveId; 
			this.userid = pUserId; 
			this.total = pTotal; 
			this.classsortindex = pClassSortIndex; 
			this.gradesortindex = pGradeSortIndex; 
		}
		
		public ActiveePortAwardTotal(int pId)
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
		
		public int ActiveId
		{
			get { return activeid; }
			set { _bIsChanged |= (activeid != value); activeid = value; }
			
		}
		
		public int UserId
		{
			get { return userid; }
			set { _bIsChanged |= (userid != value); userid = value; }
			
		}
		
		public double Total
		{
			get { return total; }
			set { _bIsChanged |= (total != value); total = value; }
			
		}
		
		public int ClassSortIndex
		{
			get { return classsortindex; }
			set { _bIsChanged |= (classsortindex != value); classsortindex = value; }
			
		}
		
		public int GradeSortIndex
		{
			get { return gradesortindex; }
			set { _bIsChanged |= (gradesortindex != value); gradesortindex = value; }
			
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
	
	#region Custom ICollection interface for ActiveePortAwardTotal 

	
	public interface IActiveePortAwardTotalCollection : ICollection
	{
		ActiveePortAwardTotal this[int index]{	get; set; }
		void Add(ActiveePortAwardTotal pActiveePortAwardTotal);
		void Clear();
	}
	
	[Serializable]
	public class ActiveePortAwardTotalCollection : IActiveePortAwardTotalCollection
	{
		private IList<ActiveePortAwardTotal> _arrayInternal;

		public ActiveePortAwardTotalCollection()
		{
			_arrayInternal = new List<ActiveePortAwardTotal>();
		}
		
		public ActiveePortAwardTotalCollection( IList<ActiveePortAwardTotal> pSource )
		{
			_arrayInternal = pSource;
			if(_arrayInternal == null)
			{
				_arrayInternal = new List<ActiveePortAwardTotal>();
			}
		}

		public ActiveePortAwardTotal this[int index]
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
		public void CopyTo(Array array, int index){ _arrayInternal.CopyTo((ActiveePortAwardTotal[])array, index); }
		public IEnumerator GetEnumerator() { return _arrayInternal.GetEnumerator(); }
		public void Add(ActiveePortAwardTotal pActiveePortAwardTotal) { _arrayInternal.Add(pActiveePortAwardTotal); }
		public void Clear() { _arrayInternal.Clear(); }
		public IList<ActiveePortAwardTotal> GetList() { return _arrayInternal; }
	 }
	
	#endregion
}
