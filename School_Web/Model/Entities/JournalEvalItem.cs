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
	/// IJournalEvalItem interface for NHibernate mapped table 'Journal_Eval_Item'.
	/// </summary>
	public interface IJournalEvalItem
	{
		#region Public Properties
		
		int ItemId
		{
			get ;
			set ;
			  
		}
		
		string Title
		{
			get ;
			set ;
			  
		}
		
		int Parentid
		{
			get ;
			set ;
			  
		}
		
		int Pindex
		{
			get ;
			set ;
			  
		}
		
		int Cent
		{
			get ;
			set ;
			  
		}
		
		int Depth
		{
			get ;
			set ;
			  
		}
		
		int Stype
		{
			get ;
			set ;
			  
		}
		
		bool IsDeleted { get; set; }
		bool IsChanged { get; set; }
		
		#endregion 
	}

	/// <summary>
	/// JournalEvalItem object for NHibernate mapped table 'Journal_Eval_Item'.
	/// </summary>
	[Serializable]
	public class JournalEvalItem : IJournalEvalItem
	{
		#region Member Variables

		protected int itemid;
		protected string title;
		protected int parentid;
		protected int pindex;
		protected int cent;
		protected int depth;
		protected int stype;
		protected bool _bIsDeleted;
		protected bool _bIsChanged;
		#endregion
		
		#region Constructors
		public JournalEvalItem() {}
		
		public JournalEvalItem(string pTitle, int pParentid, int pPindex, int pCent, int pDepth, int pStype)
		{
			this.title = pTitle; 
			this.parentid = pParentid; 
			this.pindex = pPindex; 
			this.cent = pCent; 
			this.depth = pDepth; 
			this.stype = pStype; 
		}
		
		public JournalEvalItem(int pItemId)
		{
			this.itemid = pItemId; 
		}
		
		#endregion
		
		#region Public Properties
		
		public int ItemId
		{
			get { return itemid; }
			set { _bIsChanged |= (itemid != value); itemid = value; }
			
		}
		
		public string Title
		{
			get { return title; }
			set 
			{
			  if (value != null && value.Length > 50)
			    throw new ArgumentOutOfRangeException("Title", "Title value, cannot contain more than 50 characters");
			  _bIsChanged |= (title != value); 
			  title = value; 
			}
			
		}
		
		public int Parentid
		{
			get { return parentid; }
			set { _bIsChanged |= (parentid != value); parentid = value; }
			
		}
		
		public int Pindex
		{
			get { return pindex; }
			set { _bIsChanged |= (pindex != value); pindex = value; }
			
		}
		
		public int Cent
		{
			get { return cent; }
			set { _bIsChanged |= (cent != value); cent = value; }
			
		}
		
		public int Depth
		{
			get { return depth; }
			set { _bIsChanged |= (depth != value); depth = value; }
			
		}
		
		public int Stype
		{
			get { return stype; }
			set { _bIsChanged |= (stype != value); stype = value; }
			
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
	
	#region Custom ICollection interface for JournalEvalItem 

	
	public interface IJournalEvalItemCollection : ICollection
	{
		JournalEvalItem this[int index]{	get; set; }
		void Add(JournalEvalItem pJournalEvalItem);
		void Clear();
	}
	
	[Serializable]
	public class JournalEvalItemCollection : IJournalEvalItemCollection
	{
		private IList<JournalEvalItem> _arrayInternal;

		public JournalEvalItemCollection()
		{
			_arrayInternal = new List<JournalEvalItem>();
		}
		
		public JournalEvalItemCollection( IList<JournalEvalItem> pSource )
		{
			_arrayInternal = pSource;
			if(_arrayInternal == null)
			{
				_arrayInternal = new List<JournalEvalItem>();
			}
		}

		public JournalEvalItem this[int index]
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
		public void CopyTo(Array array, int index){ _arrayInternal.CopyTo((JournalEvalItem[])array, index); }
		public IEnumerator GetEnumerator() { return _arrayInternal.GetEnumerator(); }
		public void Add(JournalEvalItem pJournalEvalItem) { _arrayInternal.Add(pJournalEvalItem); }
		public void Clear() { _arrayInternal.Clear(); }
		public IList<JournalEvalItem> GetList() { return _arrayInternal; }
	 }
	
	#endregion
}
