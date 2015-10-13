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
	/// IRoomOrder interface for NHibernate mapped table 'RoomOrder'.
	/// </summary>
	public interface IRoomOrder
	{
		#region Public Properties
		
		int Id
		{
			get ;
			set ;
			  
		}
		
		int RoomId
		{
			get ;
			set ;
			  
		}
		
		int UserId
		{
			get ;
			set ;
			  
		}
		
		string Author
		{
			get ;
			set ;
			  
		}
		
		string Tel
		{
			get ;
			set ;
			  
		}
		
		string Remark
		{
			get ;
			set ;
			  
		}
		
		DateTime Sd
		{
			get ;
			set ;
			  
		}
		
		DateTime Ed
		{
			get ;
			set ;
			  
		}
		
		int UserCount
		{
			get ;
			set ;
			  
		}
		
		DateTime Pubdate
		{
			get ;
			set ;
			  
		}
		
		bool Status
		{
			get ;
			set ;
			  
		}
		
		string FeedBack
		{
			get ;
			set ;
			  
		}
		
		DateTime FeedBackPudate
		{
			get ;
			set ;
			  
		}
		
		bool IsDeleted { get; set; }
		bool IsChanged { get; set; }
		
		#endregion 
	}

	/// <summary>
	/// RoomOrder object for NHibernate mapped table 'RoomOrder'.
	/// </summary>
	[Serializable]
	public class RoomOrder : IRoomOrder
	{
		#region Member Variables

		protected int id;
		protected int roomid;
		protected int userid;
		protected string author;
		protected string tel;
		protected string remark;
		protected DateTime sd;
		protected DateTime ed;
		protected int usercount;
		protected DateTime pubdate;
		protected bool status;
		protected string feedback;
		protected DateTime feedbackpudate;
		protected bool _bIsDeleted;
		protected bool _bIsChanged;
		#endregion
		
		#region Constructors
		public RoomOrder() {}
		
		public RoomOrder(int pRoomId, int pUserId, string pAuthor, string pTel, string pRemark, DateTime pSd, DateTime pEd, int pUserCount, DateTime pPubdate, bool pStatus, string pFeedBack, DateTime pFeedBackPudate)
		{
			this.roomid = pRoomId; 
			this.userid = pUserId; 
			this.author = pAuthor; 
			this.tel = pTel; 
			this.remark = pRemark; 
			this.sd = pSd; 
			this.ed = pEd; 
			this.usercount = pUserCount; 
			this.pubdate = pPubdate; 
			this.status = pStatus; 
			this.feedback = pFeedBack; 
			this.feedbackpudate = pFeedBackPudate; 
		}
		
		public RoomOrder(int pId)
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
		
		public int RoomId
		{
			get { return roomid; }
			set { _bIsChanged |= (roomid != value); roomid = value; }
			
		}
		
		public int UserId
		{
			get { return userid; }
			set { _bIsChanged |= (userid != value); userid = value; }
			
		}
		
		public string Author
		{
			get { return author; }
			set 
			{
			  if (value != null && value.Length > 50)
			    throw new ArgumentOutOfRangeException("Author", "Author value, cannot contain more than 50 characters");
			  _bIsChanged |= (author != value); 
			  author = value; 
			}
			
		}
		
		public string Tel
		{
			get { return tel; }
			set 
			{
			  if (value != null && value.Length > 50)
			    throw new ArgumentOutOfRangeException("Tel", "Tel value, cannot contain more than 50 characters");
			  _bIsChanged |= (tel != value); 
			  tel = value; 
			}
			
		}
		
		public string Remark
		{
			get { return remark; }
			set 
			{
			  if (value != null && value.Length > 250)
			    throw new ArgumentOutOfRangeException("Remark", "Remark value, cannot contain more than 250 characters");
			  _bIsChanged |= (remark != value); 
			  remark = value; 
			}
			
		}
		
		public DateTime Sd
		{
			get { return sd; }
			set { _bIsChanged |= (sd != value); sd = value; }
			
		}
		
		public DateTime Ed
		{
			get { return ed; }
			set { _bIsChanged |= (ed != value); ed = value; }
			
		}
		
		public int UserCount
		{
			get { return usercount; }
			set { _bIsChanged |= (usercount != value); usercount = value; }
			
		}
		
		public DateTime Pubdate
		{
			get { return pubdate; }
			set { _bIsChanged |= (pubdate != value); pubdate = value; }
			
		}
		
		public bool Status
		{
			get { return status; }
			set { _bIsChanged |= (status != value); status = value; }
			
		}
		
		public string FeedBack
		{
			get { return feedback; }
			set 
			{
			  if (value != null && value.Length > 250)
			    throw new ArgumentOutOfRangeException("FeedBack", "FeedBack value, cannot contain more than 250 characters");
			  _bIsChanged |= (feedback != value); 
			  feedback = value; 
			}
			
		}
		
		public DateTime FeedBackPudate
		{
			get { return feedbackpudate; }
			set { _bIsChanged |= (feedbackpudate != value); feedbackpudate = value; }
			
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
	
	#region Custom ICollection interface for RoomOrder 

	
	public interface IRoomOrderCollection : ICollection
	{
		RoomOrder this[int index]{	get; set; }
		void Add(RoomOrder pRoomOrder);
		void Clear();
	}
	
	[Serializable]
	public class RoomOrderCollection : IRoomOrderCollection
	{
		private IList<RoomOrder> _arrayInternal;

		public RoomOrderCollection()
		{
			_arrayInternal = new List<RoomOrder>();
		}
		
		public RoomOrderCollection( IList<RoomOrder> pSource )
		{
			_arrayInternal = pSource;
			if(_arrayInternal == null)
			{
				_arrayInternal = new List<RoomOrder>();
			}
		}

		public RoomOrder this[int index]
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
		public void CopyTo(Array array, int index){ _arrayInternal.CopyTo((RoomOrder[])array, index); }
		public IEnumerator GetEnumerator() { return _arrayInternal.GetEnumerator(); }
		public void Add(RoomOrder pRoomOrder) { _arrayInternal.Add(pRoomOrder); }
		public void Clear() { _arrayInternal.Clear(); }
		public IList<RoomOrder> GetList() { return _arrayInternal; }
	 }
	
	#endregion
}
