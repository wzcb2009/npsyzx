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
	/// IVote interface for NHibernate mapped table 'vote'.
	/// </summary>
	public interface IVote
	{
		#region Public Properties
		
		int Id
		{
			get ;
			set ;
			  
		}
		
		string Title
		{
			get ;
			set ;
			  
		}
		
		DateTime Pubdate
		{
			get ;
			set ;
			  
		}
		
		bool IndexState
		{
			get ;
			set ;
			  
		}
		
		bool PubState
		{
			get ;
			set ;
			  
		}
		
		bool IsDeleted { get; set; }
		bool IsChanged { get; set; }
		
		#endregion 
	}

	/// <summary>
	/// Vote object for NHibernate mapped table 'vote'.
	/// </summary>
	[Serializable]
	public class Vote : IVote
	{
		#region Member Variables

		protected int id;
		protected string title;
		protected DateTime pubdate;
		protected bool indexstate;
		protected bool pubstate;
		protected bool _bIsDeleted;
		protected bool _bIsChanged;
		#endregion
		
		#region Constructors
		public Vote() {}
		
		public Vote(string pTitle, DateTime pPubdate, bool pIndexState, bool pPubState)
		{
			this.title = pTitle; 
			this.pubdate = pPubdate; 
			this.indexstate = pIndexState; 
			this.pubstate = pPubState; 
		}
		
		public Vote(int pId)
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
		
		public string Title
		{
			get { return title; }
			set 
			{
			  if (value != null && value.Length > 250)
			    throw new ArgumentOutOfRangeException("Title", "Title value, cannot contain more than 250 characters");
			  _bIsChanged |= (title != value); 
			  title = value; 
			}
			
		}
		
		public DateTime Pubdate
		{
			get { return pubdate; }
			set { _bIsChanged |= (pubdate != value); pubdate = value; }
			
		}
		
		public bool IndexState
		{
			get { return indexstate; }
			set { _bIsChanged |= (indexstate != value); indexstate = value; }
			
		}
		
		public bool PubState
		{
			get { return pubstate; }
			set { _bIsChanged |= (pubstate != value); pubstate = value; }
			
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
	
	#region Custom ICollection interface for Vote 

	
	public interface IVoteCollection : ICollection
	{
		Vote this[int index]{	get; set; }
		void Add(Vote pVote);
		void Clear();
	}
	
	[Serializable]
	public class VoteCollection : IVoteCollection
	{
		private IList<Vote> _arrayInternal;

		public VoteCollection()
		{
			_arrayInternal = new List<Vote>();
		}
		
		public VoteCollection( IList<Vote> pSource )
		{
			_arrayInternal = pSource;
			if(_arrayInternal == null)
			{
				_arrayInternal = new List<Vote>();
			}
		}

		public Vote this[int index]
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
		public void CopyTo(Array array, int index){ _arrayInternal.CopyTo((Vote[])array, index); }
		public IEnumerator GetEnumerator() { return _arrayInternal.GetEnumerator(); }
		public void Add(Vote pVote) { _arrayInternal.Add(pVote); }
		public void Clear() { _arrayInternal.Clear(); }
		public IList<Vote> GetList() { return _arrayInternal; }
	 }
	
	#endregion
}
