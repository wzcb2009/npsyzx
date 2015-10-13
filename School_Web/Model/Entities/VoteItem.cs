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
	/// IVoteItem interface for NHibernate mapped table 'Vote_item'.
	/// </summary>
	public interface IVoteItem
	{
		#region Public Properties
		
		int Itemid
		{
			get ;
			set ;
			  
		}
		
		string Title
		{
			get ;
			set ;
			  
		}
		
		int Voteid
		{
			get ;
			set ;
			  
		}
		
		int Parentid
		{
			get ;
			set ;
			  
		}
		
		bool IsDeleted { get; set; }
		bool IsChanged { get; set; }
		
		#endregion 
	}

	/// <summary>
	/// VoteItem object for NHibernate mapped table 'Vote_item'.
	/// </summary>
	[Serializable]
	public class VoteItem : IVoteItem
	{
		#region Member Variables

		protected int itemid;
		protected string title;
		protected int voteid;
		protected int parentid;
		protected bool _bIsDeleted;
		protected bool _bIsChanged;
		#endregion
		
		#region Constructors
		public VoteItem() {}
		
		public VoteItem(string pTitle, int pVoteid, int pParentid)
		{
			this.title = pTitle; 
			this.voteid = pVoteid; 
			this.parentid = pParentid; 
		}
		
		public VoteItem(int pItemid)
		{
			this.itemid = pItemid; 
		}
		
		#endregion
		
		#region Public Properties
		
		public int Itemid
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
		
		public int Voteid
		{
			get { return voteid; }
			set { _bIsChanged |= (voteid != value); voteid = value; }
			
		}
		
		public int Parentid
		{
			get { return parentid; }
			set { _bIsChanged |= (parentid != value); parentid = value; }
			
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
	
	#region Custom ICollection interface for VoteItem 

	
	public interface IVoteItemCollection : ICollection
	{
		VoteItem this[int index]{	get; set; }
		void Add(VoteItem pVoteItem);
		void Clear();
	}
	
	[Serializable]
	public class VoteItemCollection : IVoteItemCollection
	{
		private IList<VoteItem> _arrayInternal;

		public VoteItemCollection()
		{
			_arrayInternal = new List<VoteItem>();
		}
		
		public VoteItemCollection( IList<VoteItem> pSource )
		{
			_arrayInternal = pSource;
			if(_arrayInternal == null)
			{
				_arrayInternal = new List<VoteItem>();
			}
		}

		public VoteItem this[int index]
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
		public void CopyTo(Array array, int index){ _arrayInternal.CopyTo((VoteItem[])array, index); }
		public IEnumerator GetEnumerator() { return _arrayInternal.GetEnumerator(); }
		public void Add(VoteItem pVoteItem) { _arrayInternal.Add(pVoteItem); }
		public void Clear() { _arrayInternal.Clear(); }
		public IList<VoteItem> GetList() { return _arrayInternal; }
	 }
	
	#endregion
}
