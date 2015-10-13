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
	/// IInvsetResult interface for NHibernate mapped table 'InvsetResult'.
	/// </summary>
	public interface IInvsetResult
	{
		#region Public Properties
		
		int Id
		{
			get ;
			set ;
			  
		}
		
		int ActiveId
		{
			get ;
			set ;
			  
		}
		
		int ClassId
		{
			get ;
			set ;
			  
		}
		
		int SubjectId
		{
			get ;
			set ;
			  
		}
		
		int UserId
		{
			get ;
			set ;
			  
		}
		
		int ItemId
		{
			get ;
			set ;
			  
		}
		
		int WeigthId
		{
			get ;
			set ;
			  
		}
		
		double Cent
		{
			get ;
			set ;
			  
		}
		
		int ByUserId
		{
			get ;
			set ;
			  
		}
		
		bool IsDeleted { get; set; }
		bool IsChanged { get; set; }
		
		#endregion 
	}

	/// <summary>
	/// InvsetResult object for NHibernate mapped table 'InvsetResult'.
	/// </summary>
	[Serializable]
	public class InvsetResult : IInvsetResult
	{
		#region Member Variables

		protected int id;
		protected int activeid;
		protected int classid;
		protected int subjectid;
		protected int userid;
		protected int itemid;
		protected int weigthid;
		protected double cent;
		protected int byuserid;
		protected bool _bIsDeleted;
		protected bool _bIsChanged;
		#endregion
		
		#region Constructors
		public InvsetResult() {}
		
		public InvsetResult(int pActiveId, int pClassId, int pSubjectId, int pUserId, int pItemId, int pWeigthId, double pCent, int pByUserId)
		{
			this.activeid = pActiveId; 
			this.classid = pClassId; 
			this.subjectid = pSubjectId; 
			this.userid = pUserId; 
			this.itemid = pItemId; 
			this.weigthid = pWeigthId; 
			this.cent = pCent; 
			this.byuserid = pByUserId; 
		}
		
		public InvsetResult(int pId)
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
		
		public int ActiveId
		{
			get { return activeid; }
			set { _bIsChanged |= (activeid != value); activeid = value; }
			
		}
		
		public int ClassId
		{
			get { return classid; }
			set { _bIsChanged |= (classid != value); classid = value; }
			
		}
		
		public int SubjectId
		{
			get { return subjectid; }
			set { _bIsChanged |= (subjectid != value); subjectid = value; }
			
		}
		
		public int UserId
		{
			get { return userid; }
			set { _bIsChanged |= (userid != value); userid = value; }
			
		}
		
		public int ItemId
		{
			get { return itemid; }
			set { _bIsChanged |= (itemid != value); itemid = value; }
			
		}
		
		public int WeigthId
		{
			get { return weigthid; }
			set { _bIsChanged |= (weigthid != value); weigthid = value; }
			
		}
		
		public double Cent
		{
			get { return cent; }
			set { _bIsChanged |= (cent != value); cent = value; }
			
		}
		
		public int ByUserId
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
	
	#region Custom ICollection interface for InvsetResult 

	
	public interface IInvsetResultCollection : ICollection
	{
		InvsetResult this[int index]{	get; set; }
		void Add(InvsetResult pInvsetResult);
		void Clear();
	}
	
	[Serializable]
	public class InvsetResultCollection : IInvsetResultCollection
	{
		private IList<InvsetResult> _arrayInternal;

		public InvsetResultCollection()
		{
			_arrayInternal = new List<InvsetResult>();
		}
		
		public InvsetResultCollection( IList<InvsetResult> pSource )
		{
			_arrayInternal = pSource;
			if(_arrayInternal == null)
			{
				_arrayInternal = new List<InvsetResult>();
			}
		}

		public InvsetResult this[int index]
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
		public void CopyTo(Array array, int index){ _arrayInternal.CopyTo((InvsetResult[])array, index); }
		public IEnumerator GetEnumerator() { return _arrayInternal.GetEnumerator(); }
		public void Add(InvsetResult pInvsetResult) { _arrayInternal.Add(pInvsetResult); }
		public void Clear() { _arrayInternal.Clear(); }
		public IList<InvsetResult> GetList() { return _arrayInternal; }
	 }
	
	#endregion
}
