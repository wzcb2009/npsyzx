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
	/// ILabApply interface for NHibernate mapped table 'LabApply'.
	/// </summary>
	public interface ILabApply
	{
		#region Public Properties
		
		int Id
		{
			get ;
			set ;
			  
		}
		
		int LabId
		{
			get ;
			set ;
			  
		}
		
		string Title
		{
			get ;
			set ;
			  
		}
		
		int UserId
		{
			get ;
			set ;
			  
		}
		
		bool UserChecked
		{
			get ;
			set ;
			  
		}
		
		string Type
		{
			get ;
			set ;
			  
		}
		
		DateTime Pubdate
		{
			get ;
			set ;
			  
		}
		
		DateTime LabDoDate
		{
			get ;
			set ;
			  
		}
		
		int Pindex
		{
			get ;
			set ;
			  
		}
		
		string Remark
		{
			get ;
			set ;
			  
		}
		
		int Cent
		{
			get ;
			set ;
			  
		}
		
		bool AssetsChecked
		{
			get ;
			set ;
			  
		}
		
		DateTime AssetsCheckedDate
		{
			get ;
			set ;
			  
		}
		
		int StudentCount
		{
			get ;
			set ;
			  
		}
		
		int GroupId
		{
			get ;
			set ;
			  
		}
		
		bool IsDeleted { get; set; }
		bool IsChanged { get; set; }
		
		#endregion 
	}

	/// <summary>
	/// LabApply object for NHibernate mapped table 'LabApply'.
	/// </summary>
	[Serializable]
	public class LabApply : ILabApply
	{
		#region Member Variables

		protected int id;
		protected int labid;
		protected string title;
		protected int userid;
		protected bool userchecked;
		protected string type;
		protected DateTime pubdate;
		protected DateTime labdodate;
		protected int pindex;
		protected string remark;
		protected int cent;
		protected bool assetschecked;
		protected DateTime assetscheckeddate;
		protected int studentcount;
		protected int groupid;
		protected bool _bIsDeleted;
		protected bool _bIsChanged;
		#endregion
		
		#region Constructors
		public LabApply() {}
		
		public LabApply(int pLabId, string pTitle, int pUserId, bool pUserChecked, string pType, DateTime pPubdate, DateTime pLabDoDate, int pPindex, string pRemark, int pCent, bool pAssetsChecked, DateTime pAssetsCheckedDate, int pStudentCount, int pGroupId)
		{
			this.labid = pLabId; 
			this.title = pTitle; 
			this.userid = pUserId; 
			this.userchecked = pUserChecked; 
			this.type = pType; 
			this.pubdate = pPubdate; 
			this.labdodate = pLabDoDate; 
			this.pindex = pPindex; 
			this.remark = pRemark; 
			this.cent = pCent; 
			this.assetschecked = pAssetsChecked; 
			this.assetscheckeddate = pAssetsCheckedDate; 
			this.studentcount = pStudentCount; 
			this.groupid = pGroupId; 
		}
		
		public LabApply(int pId)
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
		
		public int LabId
		{
			get { return labid; }
			set { _bIsChanged |= (labid != value); labid = value; }
			
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
		
		public int UserId
		{
			get { return userid; }
			set { _bIsChanged |= (userid != value); userid = value; }
			
		}
		
		public bool UserChecked
		{
			get { return userchecked; }
			set { _bIsChanged |= (userchecked != value); userchecked = value; }
			
		}
		
		public string Type
		{
			get { return type; }
			set 
			{
			  if (value != null && value.Length > 50)
			    throw new ArgumentOutOfRangeException("Type", "Type value, cannot contain more than 50 characters");
			  _bIsChanged |= (type != value); 
			  type = value; 
			}
			
		}
		
		public DateTime Pubdate
		{
			get { return pubdate; }
			set { _bIsChanged |= (pubdate != value); pubdate = value; }
			
		}
		
		public DateTime LabDoDate
		{
			get { return labdodate; }
			set { _bIsChanged |= (labdodate != value); labdodate = value; }
			
		}
		
		public int Pindex
		{
			get { return pindex; }
			set { _bIsChanged |= (pindex != value); pindex = value; }
			
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
		
		public int Cent
		{
			get { return cent; }
			set { _bIsChanged |= (cent != value); cent = value; }
			
		}
		
		public bool AssetsChecked
		{
			get { return assetschecked; }
			set { _bIsChanged |= (assetschecked != value); assetschecked = value; }
			
		}
		
		public DateTime AssetsCheckedDate
		{
			get { return assetscheckeddate; }
			set { _bIsChanged |= (assetscheckeddate != value); assetscheckeddate = value; }
			
		}
		
		public int StudentCount
		{
			get { return studentcount; }
			set { _bIsChanged |= (studentcount != value); studentcount = value; }
			
		}
		
		public int GroupId
		{
			get { return groupid; }
			set { _bIsChanged |= (groupid != value); groupid = value; }
			
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
	
	#region Custom ICollection interface for LabApply 

	
	public interface ILabApplyCollection : ICollection
	{
		LabApply this[int index]{	get; set; }
		void Add(LabApply pLabApply);
		void Clear();
	}
	
	[Serializable]
	public class LabApplyCollection : ILabApplyCollection
	{
		private IList<LabApply> _arrayInternal;

		public LabApplyCollection()
		{
			_arrayInternal = new List<LabApply>();
		}
		
		public LabApplyCollection( IList<LabApply> pSource )
		{
			_arrayInternal = pSource;
			if(_arrayInternal == null)
			{
				_arrayInternal = new List<LabApply>();
			}
		}

		public LabApply this[int index]
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
		public void CopyTo(Array array, int index){ _arrayInternal.CopyTo((LabApply[])array, index); }
		public IEnumerator GetEnumerator() { return _arrayInternal.GetEnumerator(); }
		public void Add(LabApply pLabApply) { _arrayInternal.Add(pLabApply); }
		public void Clear() { _arrayInternal.Clear(); }
		public IList<LabApply> GetList() { return _arrayInternal; }
	 }
	
	#endregion
}
