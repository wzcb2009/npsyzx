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
	/// IResourceType interface for NHibernate mapped table 'Resource_Type'.
	/// </summary>
	public interface IResourceType
	{
		#region Public Properties
		
		int RCaseId
		{
			get ;
			set ;
			  
		}
		
		string RCaseName
		{
			get ;
			set ;
			  
		}
		
		int Parentid
		{
			get ;
			set ;
			  
		}
		
		int Pindex
		{
			get ;
			set ;
			  
		}
		
		bool IsDeleted { get; set; }
		bool IsChanged { get; set; }
		
		#endregion 
	}

	/// <summary>
	/// ResourceType object for NHibernate mapped table 'Resource_Type'.
	/// </summary>
	[Serializable]
	public class ResourceType : IResourceType
	{
		#region Member Variables

		protected int rcaseid;
		protected string rcasename;
		protected int parentid;
		protected int pindex;
		protected bool _bIsDeleted;
		protected bool _bIsChanged;
		#endregion
		
		#region Constructors
		public ResourceType() {}
		
		public ResourceType(int pRcaseId, string pRcaseName, int pParentid, int pPindex)
		{
			this.rcaseid = pRcaseId; 
			this.rcasename = pRcaseName; 
			this.parentid = pParentid; 
			this.pindex = pPindex; 
		}
		
		public ResourceType(int pRcaseId)
		{
			this.rcaseid = pRcaseId; 
		}
		
		#endregion
		
		#region Public Properties
		
		public int RCaseId
		{
			get { return rcaseid; }
			set { _bIsChanged |= (rcaseid != value); rcaseid = value; }
			
		}
		
		public string RCaseName
		{
			get { return rcasename; }
			set 
			{
			  if (value != null && value.Length > 50)
			    throw new ArgumentOutOfRangeException("RCaseName", "RCaseName value, cannot contain more than 50 characters");
			  _bIsChanged |= (rcasename != value); 
			  rcasename = value; 
			}
			
		}
		
		public int Parentid
		{
			get { return parentid; }
			set { _bIsChanged |= (parentid != value); parentid = value; }
			
		}
		
		public int Pindex
		{
			get { return pindex; }
			set { _bIsChanged |= (pindex != value); pindex = value; }
			
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
	
	#region Custom ICollection interface for ResourceType 

	
	public interface IResourceTypeCollection : ICollection
	{
		ResourceType this[int index]{	get; set; }
		void Add(ResourceType pResourceType);
		void Clear();
	}
	
	[Serializable]
	public class ResourceTypeCollection : IResourceTypeCollection
	{
		private IList<ResourceType> _arrayInternal;

		public ResourceTypeCollection()
		{
			_arrayInternal = new List<ResourceType>();
		}
		
		public ResourceTypeCollection( IList<ResourceType> pSource )
		{
			_arrayInternal = pSource;
			if(_arrayInternal == null)
			{
				_arrayInternal = new List<ResourceType>();
			}
		}

		public ResourceType this[int index]
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
		public void CopyTo(Array array, int index){ _arrayInternal.CopyTo((ResourceType[])array, index); }
		public IEnumerator GetEnumerator() { return _arrayInternal.GetEnumerator(); }
		public void Add(ResourceType pResourceType) { _arrayInternal.Add(pResourceType); }
		public void Clear() { _arrayInternal.Clear(); }
		public IList<ResourceType> GetList() { return _arrayInternal; }
	 }
	
	#endregion
}
