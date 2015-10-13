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
	/// IVoteResult interface for NHibernate mapped table 'vote_Result'.
	/// </summary>
	public interface IVoteResult
	{
		#region Public Properties
		
		int Id
		{
			get ;
			set ;
			  
		}
		
		int Investid
		{
			get ;
			set ;
			  
		}
		
		int Userid
		{
			get ;
			set ;
			  
		}
		
		int Result
		{
			get ;
			set ;
			  
		}
		
		string Sugestion
		{
			get ;
			set ;
			  
		}
		
		DateTime Pubdate
		{
			get ;
			set ;
			  
		}
		
		string Ip
		{
			get ;
			set ;
			  
		}
		
		int ByUserid
		{
			get ;
			set ;
			  
		}
		
		bool IsDeleted { get; set; }
		bool IsChanged { get; set; }
		
		#endregion 
	}

	/// <summary>
	/// VoteResult object for NHibernate mapped table 'vote_Result'.
	/// </summary>
	[Serializable]
	public class VoteResult : IVoteResult
	{
		#region Member Variables

		protected int id;
		protected int investid;
		protected int userid;
		protected int result;
		protected string sugestion;
		protected DateTime pubdate;
		protected string ip;
		protected int byuserid;
		protected bool _bIsDeleted;
		protected bool _bIsChanged;
		#endregion
		
		#region Constructors
		public VoteResult() {}
		
		public VoteResult(int pInvestid, int pUserid, int pResult, string pSugestion, DateTime pPubdate, string pIp, int pByUserid)
		{
			this.investid = pInvestid; 
			this.userid = pUserid; 
			this.result = pResult; 
			this.sugestion = pSugestion; 
			this.pubdate = pPubdate; 
			this.ip = pIp; 
			this.byuserid = pByUserid; 
		}
		
		#endregion
		
		#region Public Properties
		
		public int Id
		{
			get { return id; }
			set { _bIsChanged |= (id != value); id = value; }
			
		}
		
		public int Investid
		{
			get { return investid; }
			set { _bIsChanged |= (investid != value); investid = value; }
			
		}
		
		public int Userid
		{
			get { return userid; }
			set { _bIsChanged |= (userid != value); userid = value; }
			
		}
		
		public int Result
		{
			get { return result; }
			set { _bIsChanged |= (result != value); result = value; }
			
		}
		
		public string Sugestion
		{
			get { return sugestion; }
			set 
			{
			  if (value != null && value.Length > 250)
			    throw new ArgumentOutOfRangeException("Sugestion", "Sugestion value, cannot contain more than 250 characters");
			  _bIsChanged |= (sugestion != value); 
			  sugestion = value; 
			}
			
		}
		
		public DateTime Pubdate
		{
			get { return pubdate; }
			set { _bIsChanged |= (pubdate != value); pubdate = value; }
			
		}
		
		public string Ip
		{
			get { return ip; }
			set 
			{
			  if (value != null && value.Length > 50)
			    throw new ArgumentOutOfRangeException("Ip", "Ip value, cannot contain more than 50 characters");
			  _bIsChanged |= (ip != value); 
			  ip = value; 
			}
			
		}
		
		public int ByUserid
		{
			get { return byuserid; }
			set { _bIsChanged |= (byuserid != value); byuserid = value; }
			
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
	
	#region Custom ICollection interface for VoteResult 

	
	public interface IVoteResultCollection : ICollection
	{
		VoteResult this[int index]{	get; set; }
		void Add(VoteResult pVoteResult);
		void Clear();
	}
	
	[Serializable]
	public class VoteResultCollection : IVoteResultCollection
	{
		private IList<VoteResult> _arrayInternal;

		public VoteResultCollection()
		{
			_arrayInternal = new List<VoteResult>();
		}
		
		public VoteResultCollection( IList<VoteResult> pSource )
		{
			_arrayInternal = pSource;
			if(_arrayInternal == null)
			{
				_arrayInternal = new List<VoteResult>();
			}
		}

		public VoteResult this[int index]
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
		public void CopyTo(Array array, int index){ _arrayInternal.CopyTo((VoteResult[])array, index); }
		public IEnumerator GetEnumerator() { return _arrayInternal.GetEnumerator(); }
		public void Add(VoteResult pVoteResult) { _arrayInternal.Add(pVoteResult); }
		public void Clear() { _arrayInternal.Clear(); }
		public IList<VoteResult> GetList() { return _arrayInternal; }
	 }
	
	#endregion
}
