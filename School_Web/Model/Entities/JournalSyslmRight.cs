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
	/// IJournalSyslmRight interface for NHibernate mapped table 'Journal_Syslm_Right'.
	/// </summary>
	public interface IJournalSyslmRight
	{
		#region Public Properties
		
		int Id
		{
			get ;
			set ;
			  
		}
		
		int Userid
		{
			get ;
			set ;
			  
		}
		
		string LmidList
		{
			get ;
			set ;
			  
		}
		
		bool IsDeleted { get; set; }
		bool IsChanged { get; set; }
		
		#endregion 
	}

	/// <summary>
	/// JournalSyslmRight object for NHibernate mapped table 'Journal_Syslm_Right'.
	/// </summary>
	[Serializable]
	public class JournalSyslmRight : IJournalSyslmRight
	{
		#region Member Variables

		protected int id;
		protected int userid;
		protected string lmidlist;
		protected bool _bIsDeleted;
		protected bool _bIsChanged;
		#endregion
		
		#region Constructors
		public JournalSyslmRight() {}
		
		public JournalSyslmRight(int pId, int pUserid, string pLmidList)
		{
			this.id = pId; 
			this.userid = pUserid; 
			this.lmidlist = pLmidList; 
		}
		
		public JournalSyslmRight(int pId)
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
		
		public int Userid
		{
			get { return userid; }
			set { _bIsChanged |= (userid != value); userid = value; }
			
		}
		
		public string LmidList
		{
			get { return lmidlist; }
			set 
			{
			  if (value != null && value.Length > 2147483647)
			    throw new ArgumentOutOfRangeException("LmidList", "LmidList value, cannot contain more than 2147483647 characters");
			  _bIsChanged |= (lmidlist != value); 
			  lmidlist = value; 
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
	
	#region Custom ICollection interface for JournalSyslmRight 

	
	public interface IJournalSyslmRightCollection : ICollection
	{
		JournalSyslmRight this[int index]{	get; set; }
		void Add(JournalSyslmRight pJournalSyslmRight);
		void Clear();
	}
	
	[Serializable]
	public class JournalSyslmRightCollection : IJournalSyslmRightCollection
	{
		private IList<JournalSyslmRight> _arrayInternal;

		public JournalSyslmRightCollection()
		{
			_arrayInternal = new List<JournalSyslmRight>();
		}
		
		public JournalSyslmRightCollection( IList<JournalSyslmRight> pSource )
		{
			_arrayInternal = pSource;
			if(_arrayInternal == null)
			{
				_arrayInternal = new List<JournalSyslmRight>();
			}
		}

		public JournalSyslmRight this[int index]
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
		public void CopyTo(Array array, int index){ _arrayInternal.CopyTo((JournalSyslmRight[])array, index); }
		public IEnumerator GetEnumerator() { return _arrayInternal.GetEnumerator(); }
		public void Add(JournalSyslmRight pJournalSyslmRight) { _arrayInternal.Add(pJournalSyslmRight); }
		public void Clear() { _arrayInternal.Clear(); }
		public IList<JournalSyslmRight> GetList() { return _arrayInternal; }
	 }
	
	#endregion
}
