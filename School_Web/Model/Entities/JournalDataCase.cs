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
	/// IJournalDataCase interface for NHibernate mapped table 'Journal_data_case'.
	/// </summary>
	public interface IJournalDataCase
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
		
		int Id
		{
			get ;
			set ;
			  
		}
		
		bool IsDeleted { get; set; }
		bool IsChanged { get; set; }
		
		#endregion 
	}

	/// <summary>
	/// JournalDataCase object for NHibernate mapped table 'Journal_data_case'.
	/// </summary>
	[Serializable]
	public class JournalDataCase : IJournalDataCase
	{
		#region Member Variables

		protected int caseid;
		protected string casename;
		protected int id;
		protected bool _bIsDeleted;
		protected bool _bIsChanged;
		#endregion
		
		#region Constructors
		public JournalDataCase() {}
		
		public JournalDataCase(string pCasename, int pId)
		{
			this.casename = pCasename; 
			this.id = pId; 
		}
		
		public JournalDataCase(int pId)
		{
			this.id = pId; 
		}
		
		public JournalDataCase(int pCaseid)
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
		
		public int Id
		{
			get { return id; }
			set { _bIsChanged |= (id != value); id = value; }
			
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
	
	#region Custom ICollection interface for JournalDataCase 

	
	public interface IJournalDataCaseCollection : ICollection
	{
		JournalDataCase this[int index]{	get; set; }
		void Add(JournalDataCase pJournalDataCase);
		void Clear();
	}
	
	[Serializable]
	public class JournalDataCaseCollection : IJournalDataCaseCollection
	{
		private IList<JournalDataCase> _arrayInternal;

		public JournalDataCaseCollection()
		{
			_arrayInternal = new List<JournalDataCase>();
		}
		
		public JournalDataCaseCollection( IList<JournalDataCase> pSource )
		{
			_arrayInternal = pSource;
			if(_arrayInternal == null)
			{
				_arrayInternal = new List<JournalDataCase>();
			}
		}

		public JournalDataCase this[int index]
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
		public void CopyTo(Array array, int index){ _arrayInternal.CopyTo((JournalDataCase[])array, index); }
		public IEnumerator GetEnumerator() { return _arrayInternal.GetEnumerator(); }
		public void Add(JournalDataCase pJournalDataCase) { _arrayInternal.Add(pJournalDataCase); }
		public void Clear() { _arrayInternal.Clear(); }
		public IList<JournalDataCase> GetList() { return _arrayInternal; }
	 }
	
	#endregion
}
