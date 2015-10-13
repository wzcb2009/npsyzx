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
	/// IDataMainCaseSet interface for NHibernate mapped table 'DataMainCaseSet'.
	/// </summary>
	public interface IDataMainCaseSet
	{
		#region Public Properties
		
		int Id
		{
			get ;
			set ;
			  
		}
		
		int Parentid
		{
			get ;
			set ;
			  
		}
		
		int Caseid
		{
			get ;
			set ;
			  
		}
		
		string CaseName
		{
			get ;
			set ;
			  
		}
		
		int DataMainId
		{
			get ;
			set ;
			  
		}
		
		bool IsDeleted { get; set; }
		bool IsChanged { get; set; }
		
		#endregion 
	}

	/// <summary>
	/// DataMainCaseSet object for NHibernate mapped table 'DataMainCaseSet'.
	/// </summary>
	[Serializable]
	public class DataMainCaseSet : IDataMainCaseSet
	{
		#region Member Variables

		protected int id;
		protected int parentid;
		protected int caseid;
		protected string casename;
		protected int datamainid;
		protected bool _bIsDeleted;
		protected bool _bIsChanged;
		#endregion
		
		#region Constructors
		public DataMainCaseSet() {}
		
		public DataMainCaseSet(int pParentid, int pCaseid, string pCaseName, int pDataMainId)
		{
			this.parentid = pParentid; 
			this.caseid = pCaseid; 
			this.casename = pCaseName; 
			this.datamainid = pDataMainId; 
		}
		
		public DataMainCaseSet(int pId)
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
		
		public int Parentid
		{
			get { return parentid; }
			set { _bIsChanged |= (parentid != value); parentid = value; }
			
		}
		
		public int Caseid
		{
			get { return caseid; }
			set { _bIsChanged |= (caseid != value); caseid = value; }
			
		}
		
		public string CaseName
		{
			get { return casename; }
			set 
			{
			  if (value != null && value.Length > 50)
			    throw new ArgumentOutOfRangeException("CaseName", "CaseName value, cannot contain more than 50 characters");
			  _bIsChanged |= (casename != value); 
			  casename = value; 
			}
			
		}
		
		public int DataMainId
		{
			get { return datamainid; }
			set { _bIsChanged |= (datamainid != value); datamainid = value; }
			
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
	
	#region Custom ICollection interface for DataMainCaseSet 

	
	public interface IDataMainCaseSetCollection : ICollection
	{
		DataMainCaseSet this[int index]{	get; set; }
		void Add(DataMainCaseSet pDataMainCaseSet);
		void Clear();
	}
	
	[Serializable]
	public class DataMainCaseSetCollection : IDataMainCaseSetCollection
	{
		private IList<DataMainCaseSet> _arrayInternal;

		public DataMainCaseSetCollection()
		{
			_arrayInternal = new List<DataMainCaseSet>();
		}
		
		public DataMainCaseSetCollection( IList<DataMainCaseSet> pSource )
		{
			_arrayInternal = pSource;
			if(_arrayInternal == null)
			{
				_arrayInternal = new List<DataMainCaseSet>();
			}
		}

		public DataMainCaseSet this[int index]
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
		public void CopyTo(Array array, int index){ _arrayInternal.CopyTo((DataMainCaseSet[])array, index); }
		public IEnumerator GetEnumerator() { return _arrayInternal.GetEnumerator(); }
		public void Add(DataMainCaseSet pDataMainCaseSet) { _arrayInternal.Add(pDataMainCaseSet); }
		public void Clear() { _arrayInternal.Clear(); }
		public IList<DataMainCaseSet> GetList() { return _arrayInternal; }
	 }
	
	#endregion
}
