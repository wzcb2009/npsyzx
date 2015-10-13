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
	/// IUserGroup interface for NHibernate mapped table 'User_Group'.
	/// </summary>
	public interface IUserGroup
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
		
		int Groupid
		{
			get ;
			set ;
			  
		}
		
		bool IsDeleted { get; set; }
		bool IsChanged { get; set; }
		
		#endregion 
	}

	/// <summary>
	/// UserGroup object for NHibernate mapped table 'User_Group'.
	/// </summary>
	[Serializable]
	public class UserGroup : IUserGroup
	{
		#region Member Variables

		protected int id;
		protected int userid;
		protected int groupid;
		protected bool _bIsDeleted;
		protected bool _bIsChanged;
		#endregion
		
		#region Constructors
		public UserGroup() {}
		
		public UserGroup(int pUserid, int pGroupid)
		{
			this.userid = pUserid; 
			this.groupid = pGroupid; 
		}
		
		public UserGroup(int pId)
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
		
		public int Groupid
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
	
	#region Custom ICollection interface for UserGroup 

	
	public interface IUserGroupCollection : ICollection
	{
		UserGroup this[int index]{	get; set; }
		void Add(UserGroup pUserGroup);
		void Clear();
	}
	
	[Serializable]
	public class UserGroupCollection : IUserGroupCollection
	{
		private IList<UserGroup> _arrayInternal;

		public UserGroupCollection()
		{
			_arrayInternal = new List<UserGroup>();
		}
		
		public UserGroupCollection( IList<UserGroup> pSource )
		{
			_arrayInternal = pSource;
			if(_arrayInternal == null)
			{
				_arrayInternal = new List<UserGroup>();
			}
		}

		public UserGroup this[int index]
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
		public void CopyTo(Array array, int index){ _arrayInternal.CopyTo((UserGroup[])array, index); }
		public IEnumerator GetEnumerator() { return _arrayInternal.GetEnumerator(); }
		public void Add(UserGroup pUserGroup) { _arrayInternal.Add(pUserGroup); }
		public void Clear() { _arrayInternal.Clear(); }
		public IList<UserGroup> GetList() { return _arrayInternal; }
	 }
	
	#endregion
}
