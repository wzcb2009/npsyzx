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
	/// IAssetsCaseUser interface for NHibernate mapped table 'Assets_CaseUser'.
	/// </summary>
	public interface IAssetsCaseUser
	{
		#region Public Properties
		
		int Id
		{
			get ;
			set ;
			  
		}
		
		int ParentId
		{
			get ;
			set ;
			  
		}
		
		int CaseId
		{
			get ;
			set ;
			  
		}
		
		int Assetsid
		{
			get ;
			set ;
			  
		}
		
		int UserId
		{
			get ;
			set ;
			  
		}
		
		int StateCaseId
		{
			get ;
			set ;
			  
		}
		
		bool State
		{
			get ;
			set ;
			  
		}
		
		int PlaceId
		{
			get ;
			set ;
			  
		}
		
		int Departmentid
		{
			get ;
			set ;
			  
		}
		
		int MagUserId
		{
			get ;
			set ;
			  
		}
		
		string Remark
		{
			get ;
			set ;
			  
		}
		
		string SerialNumber
		{
			get ;
			set ;
			  
		}
		
		DateTime Pubdate
		{
			get ;
			set ;
			  
		}
		
		int AssetsCount
		{
			get ;
			set ;
			  
		}
		
		bool CurrentState
		{
			get ;
			set ;
			  
		}
		
		int SourceCaseid
		{
			get ;
			set ;
			  
		}
		
		string Ordercode
		{
			get ;
			set ;
			  
		}
		
		bool IsDeleted { get; set; }
		bool IsChanged { get; set; }
		
		#endregion 
	}

	/// <summary>
	/// AssetsCaseUser object for NHibernate mapped table 'Assets_CaseUser'.
	/// </summary>
	[Serializable]
	public class AssetsCaseUser : IAssetsCaseUser
	{
		#region Member Variables

		protected int id;
		protected int parentid;
		protected int caseid;
		protected int assetsid;
		protected int userid;
		protected int statecaseid;
		protected bool state;
		protected int placeid;
		protected int departmentid;
		protected int maguserid;
		protected string remark;
		protected string serialnumber;
		protected DateTime pubdate;
		protected int assetscount;
		protected bool currentstate;
		protected int sourcecaseid;
		protected string ordercode;
		protected bool _bIsDeleted;
		protected bool _bIsChanged;
		#endregion
		
		#region Constructors
		public AssetsCaseUser() {}
		
		public AssetsCaseUser(int pParentId, int pCaseId, int pAssetsid, int pUserId, int pStateCaseId, bool pState, int pPlaceId, int pDepartmentid, int pMagUserId, string pRemark, string pSerialNumber, DateTime pPubdate, int pAssetsCount, bool pCurrentState, int pSourceCaseid, string pOrdercode)
		{
			this.parentid = pParentId; 
			this.caseid = pCaseId; 
			this.assetsid = pAssetsid; 
			this.userid = pUserId; 
			this.statecaseid = pStateCaseId; 
			this.state = pState; 
			this.placeid = pPlaceId; 
			this.departmentid = pDepartmentid; 
			this.maguserid = pMagUserId; 
			this.remark = pRemark; 
			this.serialnumber = pSerialNumber; 
			this.pubdate = pPubdate; 
			this.assetscount = pAssetsCount; 
			this.currentstate = pCurrentState; 
			this.sourcecaseid = pSourceCaseid; 
			this.ordercode = pOrdercode; 
		}
		
		public AssetsCaseUser(int pId)
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
		
		public int ParentId
		{
			get { return parentid; }
			set { _bIsChanged |= (parentid != value); parentid = value; }
			
		}
		
		public int CaseId
		{
			get { return caseid; }
			set { _bIsChanged |= (caseid != value); caseid = value; }
			
		}
		
		public int Assetsid
		{
			get { return assetsid; }
			set { _bIsChanged |= (assetsid != value); assetsid = value; }
			
		}
		
		public int UserId
		{
			get { return userid; }
			set { _bIsChanged |= (userid != value); userid = value; }
			
		}
		
		public int StateCaseId
		{
			get { return statecaseid; }
			set { _bIsChanged |= (statecaseid != value); statecaseid = value; }
			
		}
		
		public bool State
		{
			get { return state; }
			set { _bIsChanged |= (state != value); state = value; }
			
		}
		
		public int PlaceId
		{
			get { return placeid; }
			set { _bIsChanged |= (placeid != value); placeid = value; }
			
		}
		
		public int Departmentid
		{
			get { return departmentid; }
			set { _bIsChanged |= (departmentid != value); departmentid = value; }
			
		}
		
		public int MagUserId
		{
			get { return maguserid; }
			set { _bIsChanged |= (maguserid != value); maguserid = value; }
			
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
		
		public string SerialNumber
		{
			get { return serialnumber; }
			set 
			{
			  if (value != null && value.Length > 50)
			    throw new ArgumentOutOfRangeException("SerialNumber", "SerialNumber value, cannot contain more than 50 characters");
			  _bIsChanged |= (serialnumber != value); 
			  serialnumber = value; 
			}
			
		}
		
		public DateTime Pubdate
		{
			get { return pubdate; }
			set { _bIsChanged |= (pubdate != value); pubdate = value; }
			
		}
		
		public int AssetsCount
		{
			get { return assetscount; }
			set { _bIsChanged |= (assetscount != value); assetscount = value; }
			
		}
		
		public bool CurrentState
		{
			get { return currentstate; }
			set { _bIsChanged |= (currentstate != value); currentstate = value; }
			
		}
		
		public int SourceCaseid
		{
			get { return sourcecaseid; }
			set { _bIsChanged |= (sourcecaseid != value); sourcecaseid = value; }
			
		}
		
		public string Ordercode
		{
			get { return ordercode; }
			set 
			{
			  if (value != null && value.Length > 50)
			    throw new ArgumentOutOfRangeException("Ordercode", "Ordercode value, cannot contain more than 50 characters");
			  _bIsChanged |= (ordercode != value); 
			  ordercode = value; 
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
	
	#region Custom ICollection interface for AssetsCaseUser 

	
	public interface IAssetsCaseUserCollection : ICollection
	{
		AssetsCaseUser this[int index]{	get; set; }
		void Add(AssetsCaseUser pAssetsCaseUser);
		void Clear();
	}
	
	[Serializable]
	public class AssetsCaseUserCollection : IAssetsCaseUserCollection
	{
		private IList<AssetsCaseUser> _arrayInternal;

		public AssetsCaseUserCollection()
		{
			_arrayInternal = new List<AssetsCaseUser>();
		}
		
		public AssetsCaseUserCollection( IList<AssetsCaseUser> pSource )
		{
			_arrayInternal = pSource;
			if(_arrayInternal == null)
			{
				_arrayInternal = new List<AssetsCaseUser>();
			}
		}

		public AssetsCaseUser this[int index]
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
		public void CopyTo(Array array, int index){ _arrayInternal.CopyTo((AssetsCaseUser[])array, index); }
		public IEnumerator GetEnumerator() { return _arrayInternal.GetEnumerator(); }
		public void Add(AssetsCaseUser pAssetsCaseUser) { _arrayInternal.Add(pAssetsCaseUser); }
		public void Clear() { _arrayInternal.Clear(); }
		public IList<AssetsCaseUser> GetList() { return _arrayInternal; }
	 }
	
	#endregion
}
