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
	/// IRoomInfo interface for NHibernate mapped table 'RoomInfo'.
	/// </summary>
	public interface IRoomInfo
	{
		#region Public Properties
		
		int Id
		{
			get ;
			set ;
			  
		}
		
		int CaseId
		{
			get ;
			set ;
			  
		}
		
		int Pindex
		{
			get ;
			set ;
			  
		}
		
		string RoomName
		{
			get ;
			set ;
			  
		}
		
		string Address
		{
			get ;
			set ;
			  
		}
		
		int LimitCount
		{
			get ;
			set ;
			  
		}
		
		bool Status
		{
			get ;
			set ;
			  
		}
		
		bool IsDeleted { get; set; }
		bool IsChanged { get; set; }
		
		#endregion 
	}

	/// <summary>
	/// RoomInfo object for NHibernate mapped table 'RoomInfo'.
	/// </summary>
	[Serializable]
	public class RoomInfo : IRoomInfo
	{
		#region Member Variables

		protected int id;
		protected int caseid;
		protected int pindex;
		protected string roomname;
		protected string address;
		protected int limitcount;
		protected bool status;
		protected bool _bIsDeleted;
		protected bool _bIsChanged;
		#endregion
		
		#region Constructors
		public RoomInfo() {}
		
		public RoomInfo(int pCaseId, int pPindex, string pRoomName, string pAddress, int pLimitCount, bool pStatus)
		{
			this.caseid = pCaseId; 
			this.pindex = pPindex; 
			this.roomname = pRoomName; 
			this.address = pAddress; 
			this.limitcount = pLimitCount; 
			this.status = pStatus; 
		}
		
		public RoomInfo(int pId)
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
		
		public int CaseId
		{
			get { return caseid; }
			set { _bIsChanged |= (caseid != value); caseid = value; }
			
		}
		
		public int Pindex
		{
			get { return pindex; }
			set { _bIsChanged |= (pindex != value); pindex = value; }
			
		}
		
		public string RoomName
		{
			get { return roomname; }
			set 
			{
			  if (value != null && value.Length > 50)
			    throw new ArgumentOutOfRangeException("RoomName", "RoomName value, cannot contain more than 50 characters");
			  _bIsChanged |= (roomname != value); 
			  roomname = value; 
			}
			
		}
		
		public string Address
		{
			get { return address; }
			set 
			{
			  if (value != null && value.Length > 50)
			    throw new ArgumentOutOfRangeException("Address", "Address value, cannot contain more than 50 characters");
			  _bIsChanged |= (address != value); 
			  address = value; 
			}
			
		}
		
		public int LimitCount
		{
			get { return limitcount; }
			set { _bIsChanged |= (limitcount != value); limitcount = value; }
			
		}
		
		public bool Status
		{
			get { return status; }
			set { _bIsChanged |= (status != value); status = value; }
			
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
	
	#region Custom ICollection interface for RoomInfo 

	
	public interface IRoomInfoCollection : ICollection
	{
		RoomInfo this[int index]{	get; set; }
		void Add(RoomInfo pRoomInfo);
		void Clear();
	}
	
	[Serializable]
	public class RoomInfoCollection : IRoomInfoCollection
	{
		private IList<RoomInfo> _arrayInternal;

		public RoomInfoCollection()
		{
			_arrayInternal = new List<RoomInfo>();
		}
		
		public RoomInfoCollection( IList<RoomInfo> pSource )
		{
			_arrayInternal = pSource;
			if(_arrayInternal == null)
			{
				_arrayInternal = new List<RoomInfo>();
			}
		}

		public RoomInfo this[int index]
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
		public void CopyTo(Array array, int index){ _arrayInternal.CopyTo((RoomInfo[])array, index); }
		public IEnumerator GetEnumerator() { return _arrayInternal.GetEnumerator(); }
		public void Add(RoomInfo pRoomInfo) { _arrayInternal.Add(pRoomInfo); }
		public void Clear() { _arrayInternal.Clear(); }
		public IList<RoomInfo> GetList() { return _arrayInternal; }
	 }
	
	#endregion
}
