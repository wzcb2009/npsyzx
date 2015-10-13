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
	/// IHqglCase interface for NHibernate mapped table 'hqgl_case'.
	/// </summary>
	public interface IHqglCase
	{
		#region Public Properties
		
		int Caseid
		{
			get ;
			set ;
			  
		}
		
		string Casename
		{
			get ;
			set ;
			  
		}
		
		int Typeid
		{
			get ;
			set ;
			  
		}
		
		bool IsDeleted { get; set; }
		bool IsChanged { get; set; }
		
		#endregion 
	}

	/// <summary>
	/// HqglCase object for NHibernate mapped table 'hqgl_case'.
	/// </summary>
	[Serializable]
	public class HqglCase : IHqglCase
	{
		#region Member Variables

		protected int caseid;
		protected string casename;
		protected int typeid;
		protected bool _bIsDeleted;
		protected bool _bIsChanged;
		#endregion
		
		#region Constructors
		public HqglCase() {}
		
		public HqglCase(int pCaseid, string pCasename, int pTypeid)
		{
			this.caseid = pCaseid; 
			this.casename = pCasename; 
			this.typeid = pTypeid; 
		}
		
		public HqglCase(int pCaseid)
		{
			this.caseid = pCaseid; 
		}
		
		#endregion
		
		#region Public Properties
		
		public int Caseid
		{
			get { return caseid; }
			set { _bIsChanged |= (caseid != value); caseid = value; }
			
		}
		
		public string Casename
		{
			get { return casename; }
			set 
			{
			  if (value != null && value.Length > 50)
			    throw new ArgumentOutOfRangeException("Casename", "Casename value, cannot contain more than 50 characters");
			  _bIsChanged |= (casename != value); 
			  casename = value; 
			}
			
		}
		
		public int Typeid
		{
			get { return typeid; }
			set { _bIsChanged |= (typeid != value); typeid = value; }
			
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
	
	#region Custom ICollection interface for HqglCase 

	
	public interface IHqglCaseCollection : ICollection
	{
		HqglCase this[int index]{	get; set; }
		void Add(HqglCase pHqglCase);
		void Clear();
	}
	
	[Serializable]
	public class HqglCaseCollection : IHqglCaseCollection
	{
		private IList<HqglCase> _arrayInternal;

		public HqglCaseCollection()
		{
			_arrayInternal = new List<HqglCase>();
		}
		
		public HqglCaseCollection( IList<HqglCase> pSource )
		{
			_arrayInternal = pSource;
			if(_arrayInternal == null)
			{
				_arrayInternal = new List<HqglCase>();
			}
		}

		public HqglCase this[int index]
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
		public void CopyTo(Array array, int index){ _arrayInternal.CopyTo((HqglCase[])array, index); }
		public IEnumerator GetEnumerator() { return _arrayInternal.GetEnumerator(); }
		public void Add(HqglCase pHqglCase) { _arrayInternal.Add(pHqglCase); }
		public void Clear() { _arrayInternal.Clear(); }
		public IList<HqglCase> GetList() { return _arrayInternal; }
	 }
	
	#endregion
}
