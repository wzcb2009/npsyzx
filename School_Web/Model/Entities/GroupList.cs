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
	/// IGroupList interface for NHibernate mapped table 'GroupList'.
	/// </summary>
	public interface IGroupList
	{
		#region Public Properties
		
		int Id
		{
			get ;
			set ;
			  
		}
		
		bool System
		{
			get ;
			set ;
			  
		}
		
		int Parentid
		{
			get ;
			set ;
			  
		}
		
		string GroupName
		{
			get ;
			set ;
			  
		}
		
		int Depth
		{
			get ;
			set ;
			  
		}
		
		bool IsDeleted { get; set; }
		bool IsChanged { get; set; }
		
		#endregion 
	}

	/// <summary>
	/// GroupList object for NHibernate mapped table 'GroupList'.
	/// </summary>
	[Serializable]
	public class GroupList : IGroupList
	{
		#region Member Variables

		protected int id;
		protected bool system;
		protected int parentid;
		protected string groupname;
		protected int depth;
		protected bool _bIsDeleted;
		protected bool _bIsChanged;
		#endregion
		
		#region Constructors
		public GroupList() {}
		
		public GroupList(bool pSystem, int pParentid, string pGroupName, int pDepth)
		{
			this.system = pSystem; 
			this.parentid = pParentid; 
			this.groupname = pGroupName; 
			this.depth = pDepth; 
		}
		
		public GroupList(int pId)
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
		
		public bool System
		{
			get { return system; }
			set { _bIsChanged |= (system != value); system = value; }
			
		}
		
		public int Parentid
		{
			get { return parentid; }
			set { _bIsChanged |= (parentid != value); parentid = value; }
			
		}
		
		public string GroupName
		{
			get { return groupname; }
			set 
			{
			  if (value != null && value.Length > 50)
			    throw new ArgumentOutOfRangeException("GroupName", "GroupName value, cannot contain more than 50 characters");
			  _bIsChanged |= (groupname != value); 
			  groupname = value; 
			}
			
		}
		
		public int Depth
		{
			get { return depth; }
			set { _bIsChanged |= (depth != value); depth = value; }
			
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
	
	#region Custom ICollection interface for GroupList 

	
	public interface IGroupListCollection : ICollection
	{
		GroupList this[int index]{	get; set; }
		void Add(GroupList pGroupList);
		void Clear();
	}
	
	[Serializable]
	public class GroupListCollection : IGroupListCollection
	{
		private IList<GroupList> _arrayInternal;

		public GroupListCollection()
		{
			_arrayInternal = new List<GroupList>();
		}
		
		public GroupListCollection( IList<GroupList> pSource )
		{
			_arrayInternal = pSource;
			if(_arrayInternal == null)
			{
				_arrayInternal = new List<GroupList>();
			}
		}

		public GroupList this[int index]
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
		public void CopyTo(Array array, int index){ _arrayInternal.CopyTo((GroupList[])array, index); }
		public IEnumerator GetEnumerator() { return _arrayInternal.GetEnumerator(); }
		public void Add(GroupList pGroupList) { _arrayInternal.Add(pGroupList); }
		public void Clear() { _arrayInternal.Clear(); }
		public IList<GroupList> GetList() { return _arrayInternal; }
	 }
	
	#endregion
}
