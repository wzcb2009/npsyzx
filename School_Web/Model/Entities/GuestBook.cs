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
	/// IGuestBook interface for NHibernate mapped table 'GuestBook'.
	/// </summary>
	public interface IGuestBook
	{
		#region Public Properties
		
		int Id
		{
			get ;
			set ;
			  
		}
		
		int Caseid
		{
			get ;
			set ;
			  
		}
		
		string Name
		{
			get ;
			set ;
			  
		}
		
		string Tel
		{
			get ;
			set ;
			  
		}
		
		string EMail
		{
			get ;
			set ;
			  
		}
		
		string Qq
		{
			get ;
			set ;
			  
		}
		
		string CodeNum
		{
			get ;
			set ;
			  
		}
		
		string Address
		{
			get ;
			set ;
			  
		}
		
		string Title
		{
			get ;
			set ;
			  
		}
		
		string Remark
		{
			get ;
			set ;
			  
		}
		
		int Sequence
		{
			get ;
			set ;
			  
		}
		
		DateTime PostDate
		{
			get ;
			set ;
			  
		}
		
		string Postip
		{
			get ;
			set ;
			  
		}
		
		string Reply
		{
			get ;
			set ;
			  
		}
		
		DateTime ReplyDate
		{
			get ;
			set ;
			  
		}
		
		string Replyip
		{
			get ;
			set ;
			  
		}
		
		bool IsShow
		{
			get ;
			set ;
			  
		}
		
		bool IsDeleted { get; set; }
		bool IsChanged { get; set; }
		
		#endregion 
	}

	/// <summary>
	/// GuestBook object for NHibernate mapped table 'GuestBook'.
	/// </summary>
	[Serializable]
	public class GuestBook : IGuestBook
	{
		#region Member Variables

		protected int id;
		protected int caseid;
		protected string name;
		protected string tel;
		protected string email;
		protected string qq;
		protected string codenum;
		protected string address;
		protected string title;
		protected string remark;
		protected int sequence;
		protected DateTime postdate;
		protected string postip;
		protected string reply;
		protected DateTime replydate;
		protected string replyip;
		protected bool isshow;
		protected bool _bIsDeleted;
		protected bool _bIsChanged;
		#endregion
		
		#region Constructors
		public GuestBook() {}
		
		public GuestBook(int pCaseid, string pName, string pTel, string pEmail, string pQq, string pCodeNum, string pAddress, string pTitle, string pRemark, int pSequence, DateTime pPostDate, string pPostip, string pReply, DateTime pReplyDate, string pReplyip, bool pIsShow)
		{
			this.caseid = pCaseid; 
			this.name = pName; 
			this.tel = pTel; 
			this.email = pEmail; 
			this.qq = pQq; 
			this.codenum = pCodeNum; 
			this.address = pAddress; 
			this.title = pTitle; 
			this.remark = pRemark; 
			this.sequence = pSequence; 
			this.postdate = pPostDate; 
			this.postip = pPostip; 
			this.reply = pReply; 
			this.replydate = pReplyDate; 
			this.replyip = pReplyip; 
			this.isshow = pIsShow; 
		}
		
		public GuestBook(int pId)
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
		
		public int Caseid
		{
			get { return caseid; }
			set { _bIsChanged |= (caseid != value); caseid = value; }
			
		}
		
		public string Name
		{
			get { return name; }
			set 
			{
			  if (value != null && value.Length > 50)
			    throw new ArgumentOutOfRangeException("Name", "Name value, cannot contain more than 50 characters");
			  _bIsChanged |= (name != value); 
			  name = value; 
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
		
		public string EMail
		{
			get { return email; }
			set 
			{
			  if (value != null && value.Length > 100)
			    throw new ArgumentOutOfRangeException("EMail", "EMail value, cannot contain more than 100 characters");
			  _bIsChanged |= (email != value); 
			  email = value; 
			}
			
		}
		
		public string Qq
		{
			get { return qq; }
			set 
			{
			  if (value != null && value.Length > 50)
			    throw new ArgumentOutOfRangeException("Qq", "Qq value, cannot contain more than 50 characters");
			  _bIsChanged |= (qq != value); 
			  qq = value; 
			}
			
		}
		
		public string CodeNum
		{
			get { return codenum; }
			set 
			{
			  if (value != null && value.Length > 50)
			    throw new ArgumentOutOfRangeException("CodeNum", "CodeNum value, cannot contain more than 50 characters");
			  _bIsChanged |= (codenum != value); 
			  codenum = value; 
			}
			
		}
		
		public string Address
		{
			get { return address; }
			set 
			{
			  if (value != null && value.Length > 100)
			    throw new ArgumentOutOfRangeException("Address", "Address value, cannot contain more than 100 characters");
			  _bIsChanged |= (address != value); 
			  address = value; 
			}
			
		}
		
		public string Title
		{
			get { return title; }
			set 
			{
			  if (value != null && value.Length > 100)
			    throw new ArgumentOutOfRangeException("Title", "Title value, cannot contain more than 100 characters");
			  _bIsChanged |= (title != value); 
			  title = value; 
			}
			
		}
		
		public string Remark
		{
			get { return remark; }
			set 
			{
			  if (value != null && value.Length > 1000)
			    throw new ArgumentOutOfRangeException("Remark", "Remark value, cannot contain more than 1000 characters");
			  _bIsChanged |= (remark != value); 
			  remark = value; 
			}
			
		}
		
		public int Sequence
		{
			get { return sequence; }
			set { _bIsChanged |= (sequence != value); sequence = value; }
			
		}
		
		public DateTime PostDate
		{
			get { return postdate; }
			set { _bIsChanged |= (postdate != value); postdate = value; }
			
		}
		
		public string Postip
		{
			get { return postip; }
			set 
			{
			  if (value != null && value.Length > 50)
			    throw new ArgumentOutOfRangeException("Postip", "Postip value, cannot contain more than 50 characters");
			  _bIsChanged |= (postip != value); 
			  postip = value; 
			}
			
		}
		
		public string Reply
		{
			get { return reply; }
			set 
			{
			  if (value != null && value.Length > 1000)
			    throw new ArgumentOutOfRangeException("Reply", "Reply value, cannot contain more than 1000 characters");
			  _bIsChanged |= (reply != value); 
			  reply = value; 
			}
			
		}
		
		public DateTime ReplyDate
		{
			get { return replydate; }
			set { _bIsChanged |= (replydate != value); replydate = value; }
			
		}
		
		public string Replyip
		{
			get { return replyip; }
			set 
			{
			  if (value != null && value.Length > 50)
			    throw new ArgumentOutOfRangeException("Replyip", "Replyip value, cannot contain more than 50 characters");
			  _bIsChanged |= (replyip != value); 
			  replyip = value; 
			}
			
		}
		
		public bool IsShow
		{
			get { return isshow; }
			set { _bIsChanged |= (isshow != value); isshow = value; }
			
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
	
	#region Custom ICollection interface for GuestBook 

	
	public interface IGuestBookCollection : ICollection
	{
		GuestBook this[int index]{	get; set; }
		void Add(GuestBook pGuestBook);
		void Clear();
	}
	
	[Serializable]
	public class GuestBookCollection : IGuestBookCollection
	{
		private IList<GuestBook> _arrayInternal;

		public GuestBookCollection()
		{
			_arrayInternal = new List<GuestBook>();
		}
		
		public GuestBookCollection( IList<GuestBook> pSource )
		{
			_arrayInternal = pSource;
			if(_arrayInternal == null)
			{
				_arrayInternal = new List<GuestBook>();
			}
		}

		public GuestBook this[int index]
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
		public void CopyTo(Array array, int index){ _arrayInternal.CopyTo((GuestBook[])array, index); }
		public IEnumerator GetEnumerator() { return _arrayInternal.GetEnumerator(); }
		public void Add(GuestBook pGuestBook) { _arrayInternal.Add(pGuestBook); }
		public void Clear() { _arrayInternal.Clear(); }
		public IList<GuestBook> GetList() { return _arrayInternal; }
	 }
	
	#endregion
}
