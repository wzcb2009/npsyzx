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
	/// IJournalEvalResult interface for NHibernate mapped table 'Journal_Eval_Result'.
	/// </summary>
	public interface IJournalEvalResult
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
		
		int Articalid
		{
			get ;
			set ;
			  
		}
		
		int Itemid
		{
			get ;
			set ;
			  
		}
		
		int Selectid
		{
			get ;
			set ;
			  
		}
		
		bool IsDeleted { get; set; }
		bool IsChanged { get; set; }
		
		#endregion 
	}

	/// <summary>
	/// JournalEvalResult object for NHibernate mapped table 'Journal_Eval_Result'.
	/// </summary>
	[Serializable]
	public class JournalEvalResult : IJournalEvalResult
	{
		#region Member Variables

		protected int id;
		protected int userid;
		protected int articalid;
		protected int itemid;
		protected int selectid;
		protected bool _bIsDeleted;
		protected bool _bIsChanged;
		#endregion
		
		#region Constructors
		public JournalEvalResult() {}
		
		public JournalEvalResult(int pUserid, int pArticalid, int pItemid, int pSelectid)
		{
			this.userid = pUserid; 
			this.articalid = pArticalid; 
			this.itemid = pItemid; 
			this.selectid = pSelectid; 
		}
		
		public JournalEvalResult(int pId)
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
		
		public int Articalid
		{
			get { return articalid; }
			set { _bIsChanged |= (articalid != value); articalid = value; }
			
		}
		
		public int Itemid
		{
			get { return itemid; }
			set { _bIsChanged |= (itemid != value); itemid = value; }
			
		}
		
		public int Selectid
		{
			get { return selectid; }
			set { _bIsChanged |= (selectid != value); selectid = value; }
			
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
	
	#region Custom ICollection interface for JournalEvalResult 

	
	public interface IJournalEvalResultCollection : ICollection
	{
		JournalEvalResult this[int index]{	get; set; }
		void Add(JournalEvalResult pJournalEvalResult);
		void Clear();
	}
	
	[Serializable]
	public class JournalEvalResultCollection : IJournalEvalResultCollection
	{
		private IList<JournalEvalResult> _arrayInternal;

		public JournalEvalResultCollection()
		{
			_arrayInternal = new List<JournalEvalResult>();
		}
		
		public JournalEvalResultCollection( IList<JournalEvalResult> pSource )
		{
			_arrayInternal = pSource;
			if(_arrayInternal == null)
			{
				_arrayInternal = new List<JournalEvalResult>();
			}
		}

		public JournalEvalResult this[int index]
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
		public void CopyTo(Array array, int index){ _arrayInternal.CopyTo((JournalEvalResult[])array, index); }
		public IEnumerator GetEnumerator() { return _arrayInternal.GetEnumerator(); }
		public void Add(JournalEvalResult pJournalEvalResult) { _arrayInternal.Add(pJournalEvalResult); }
		public void Clear() { _arrayInternal.Clear(); }
		public IList<JournalEvalResult> GetList() { return _arrayInternal; }
	 }
	
	#endregion
}
