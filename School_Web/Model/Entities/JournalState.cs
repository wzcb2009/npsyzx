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
	/// IJournalState interface for NHibernate mapped table 'Journal_state'.
	/// </summary>
	public interface IJournalState
	{
		#region Public Properties
		
		int Id
		{
			get ;
			set ;
			  
		}
		
		string StateName
		{
			get ;
			set ;
			  
		}
		
		int Parentid
		{
			get ;
			set ;
			  
		}
		
		string Subidlist
		{
			get ;
			set ;
			  
		}
		
		bool IsDeleted { get; set; }
		bool IsChanged { get; set; }
		
		#endregion 
	}

	/// <summary>
	/// JournalState object for NHibernate mapped table 'Journal_state'.
	/// </summary>
	[Serializable]
	public class JournalState : IJournalState
	{
		#region Member Variables

		protected int id;
		protected string statename;
		protected int parentid;
		protected string subidlist;
		protected bool _bIsDeleted;
		protected bool _bIsChanged;
		#endregion
		
		#region Constructors
		public JournalState() {}
		
		public JournalState(string pStateName, int pParentid, string pSubidlist)
		{
			this.statename = pStateName; 
			this.parentid = pParentid; 
			this.subidlist = pSubidlist; 
		}
		
		public JournalState(int pId)
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
		
		public string StateName
		{
			get { return statename; }
			set 
			{
			  if (value != null && value.Length > 50)
			    throw new ArgumentOutOfRangeException("StateName", "StateName value, cannot contain more than 50 characters");
			  _bIsChanged |= (statename != value); 
			  statename = value; 
			}
			
		}
		
		public int Parentid
		{
			get { return parentid; }
			set { _bIsChanged |= (parentid != value); parentid = value; }
			
		}
		
		public string Subidlist
		{
			get { return subidlist; }
			set 
			{
			  if (value != null && value.Length > 50)
			    throw new ArgumentOutOfRangeException("Subidlist", "Subidlist value, cannot contain more than 50 characters");
			  _bIsChanged |= (subidlist != value); 
			  subidlist = value; 
			}
			
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
	
	#region Custom ICollection interface for JournalState 

	
	public interface IJournalStateCollection : ICollection
	{
		JournalState this[int index]{	get; set; }
		void Add(JournalState pJournalState);
		void Clear();
	}
	
	[Serializable]
	public class JournalStateCollection : IJournalStateCollection
	{
		private IList<JournalState> _arrayInternal;

		public JournalStateCollection()
		{
			_arrayInternal = new List<JournalState>();
		}
		
		public JournalStateCollection( IList<JournalState> pSource )
		{
			_arrayInternal = pSource;
			if(_arrayInternal == null)
			{
				_arrayInternal = new List<JournalState>();
			}
		}

		public JournalState this[int index]
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
		public void CopyTo(Array array, int index){ _arrayInternal.CopyTo((JournalState[])array, index); }
		public IEnumerator GetEnumerator() { return _arrayInternal.GetEnumerator(); }
		public void Add(JournalState pJournalState) { _arrayInternal.Add(pJournalState); }
		public void Clear() { _arrayInternal.Clear(); }
		public IList<JournalState> GetList() { return _arrayInternal; }
	 }
	
	#endregion
}
