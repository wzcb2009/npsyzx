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
	/// IJournalQk interface for NHibernate mapped table 'Journal_QK'.
	/// </summary>
	public interface IJournalQk
	{
		#region Public Properties
		
		int Id
		{
			get ;
			set ;
			  
		}
		
		string Qkh
		{
			get ;
			set ;
			  
		}
		
		DateTime PublishDate
		{
			get ;
			set ;
			  
		}
		
		bool IsDeleted { get; set; }
		bool IsChanged { get; set; }
		
		#endregion 
	}

	/// <summary>
	/// JournalQk object for NHibernate mapped table 'Journal_QK'.
	/// </summary>
	[Serializable]
	public class JournalQk : IJournalQk
	{
		#region Member Variables

		protected int id;
		protected string qkh;
		protected DateTime publishdate;
		protected bool _bIsDeleted;
		protected bool _bIsChanged;
		#endregion
		
		#region Constructors
		public JournalQk() {}
		
		public JournalQk(string pQkh, DateTime pPublishDate)
		{
			this.qkh = pQkh; 
			this.publishdate = pPublishDate; 
		}
		
		public JournalQk(int pId)
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
		
		public string Qkh
		{
			get { return qkh; }
			set 
			{
			  if (value != null && value.Length > 50)
			    throw new ArgumentOutOfRangeException("Qkh", "Qkh value, cannot contain more than 50 characters");
			  _bIsChanged |= (qkh != value); 
			  qkh = value; 
			}
			
		}
		
		public DateTime PublishDate
		{
			get { return publishdate; }
			set { _bIsChanged |= (publishdate != value); publishdate = value; }
			
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
	
	#region Custom ICollection interface for JournalQk 

	
	public interface IJournalQkCollection : ICollection
	{
		JournalQk this[int index]{	get; set; }
		void Add(JournalQk pJournalQk);
		void Clear();
	}
	
	[Serializable]
	public class JournalQkCollection : IJournalQkCollection
	{
		private IList<JournalQk> _arrayInternal;

		public JournalQkCollection()
		{
			_arrayInternal = new List<JournalQk>();
		}
		
		public JournalQkCollection( IList<JournalQk> pSource )
		{
			_arrayInternal = pSource;
			if(_arrayInternal == null)
			{
				_arrayInternal = new List<JournalQk>();
			}
		}

		public JournalQk this[int index]
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
		public void CopyTo(Array array, int index){ _arrayInternal.CopyTo((JournalQk[])array, index); }
		public IEnumerator GetEnumerator() { return _arrayInternal.GetEnumerator(); }
		public void Add(JournalQk pJournalQk) { _arrayInternal.Add(pJournalQk); }
		public void Clear() { _arrayInternal.Clear(); }
		public IList<JournalQk> GetList() { return _arrayInternal; }
	 }
	
	#endregion
}
