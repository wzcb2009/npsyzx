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
	/// IVoteLy interface for NHibernate mapped table 'vote_ly'.
	/// </summary>
	public interface IVoteLy
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
		
		string Title
		{
			get ;
			set ;
			  
		}
		
		bool IsDeleted { get; set; }
		bool IsChanged { get; set; }
		
		#endregion 
	}

	/// <summary>
	/// VoteLy object for NHibernate mapped table 'vote_ly'.
	/// </summary>
	[Serializable]
	public class VoteLy : IVoteLy
	{
		#region Member Variables

		protected int id;
		protected int userid;
		protected string title;
		protected bool _bIsDeleted;
		protected bool _bIsChanged;
		#endregion
		
		#region Constructors
		public VoteLy() {}
		
		public VoteLy(int pUserid, string pTitle)
		{
			this.userid = pUserid; 
			this.title = pTitle; 
		}
		
		public VoteLy(int pId)
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
	
	#region Custom ICollection interface for VoteLy 

	
	public interface IVoteLyCollection : ICollection
	{
		VoteLy this[int index]{	get; set; }
		void Add(VoteLy pVoteLy);
		void Clear();
	}
	
	[Serializable]
	public class VoteLyCollection : IVoteLyCollection
	{
		private IList<VoteLy> _arrayInternal;

		public VoteLyCollection()
		{
			_arrayInternal = new List<VoteLy>();
		}
		
		public VoteLyCollection( IList<VoteLy> pSource )
		{
			_arrayInternal = pSource;
			if(_arrayInternal == null)
			{
				_arrayInternal = new List<VoteLy>();
			}
		}

		public VoteLy this[int index]
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
		public void CopyTo(Array array, int index){ _arrayInternal.CopyTo((VoteLy[])array, index); }
		public IEnumerator GetEnumerator() { return _arrayInternal.GetEnumerator(); }
		public void Add(VoteLy pVoteLy) { _arrayInternal.Add(pVoteLy); }
		public void Clear() { _arrayInternal.Clear(); }
		public IList<VoteLy> GetList() { return _arrayInternal; }
	 }
	
	#endregion
}
