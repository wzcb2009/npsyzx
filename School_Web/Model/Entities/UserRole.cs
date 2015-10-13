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
	/// IUserRole interface for NHibernate mapped table 'User_role'.
	/// </summary>
	public interface IUserRole
	{
		#region Public Properties
		
		int Roleid
		{
			get ;
			set ;
			  
		}
		
		string RoleName
		{
			get ;
			set ;
			  
		}
		
		bool IsDeleted { get; set; }
		bool IsChanged { get; set; }
		
		#endregion 
	}

	/// <summary>
	/// UserRole object for NHibernate mapped table 'User_role'.
	/// </summary>
	[Serializable]
	public class UserRole : IUserRole
	{
		#region Member Variables

		protected int roleid;
		protected string rolename;
		protected bool _bIsDeleted;
		protected bool _bIsChanged;
		#endregion
		
		#region Constructors
		public UserRole() {}
		
		public UserRole(int pRoleid, string pRoleName)
		{
			this.roleid = pRoleid; 
			this.rolename = pRoleName; 
		}
		
		#endregion
		
		#region Public Properties
		
		public int Roleid
		{
			get { return roleid; }
			set { _bIsChanged |= (roleid != value); roleid = value; }
			
		}
		
		public string RoleName
		{
			get { return rolename; }
			set 
			{
			  if (value != null && value.Length > 50)
			    throw new ArgumentOutOfRangeException("RoleName", "RoleName value, cannot contain more than 50 characters");
			  _bIsChanged |= (rolename != value); 
			  rolename = value; 
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
	
	#region Custom ICollection interface for UserRole 

	
	public interface IUserRoleCollection : ICollection
	{
		UserRole this[int index]{	get; set; }
		void Add(UserRole pUserRole);
		void Clear();
	}
	
	[Serializable]
	public class UserRoleCollection : IUserRoleCollection
	{
		private IList<UserRole> _arrayInternal;

		public UserRoleCollection()
		{
			_arrayInternal = new List<UserRole>();
		}
		
		public UserRoleCollection( IList<UserRole> pSource )
		{
			_arrayInternal = pSource;
			if(_arrayInternal == null)
			{
				_arrayInternal = new List<UserRole>();
			}
		}

		public UserRole this[int index]
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
		public void CopyTo(Array array, int index){ _arrayInternal.CopyTo((UserRole[])array, index); }
		public IEnumerator GetEnumerator() { return _arrayInternal.GetEnumerator(); }
		public void Add(UserRole pUserRole) { _arrayInternal.Add(pUserRole); }
		public void Clear() { _arrayInternal.Clear(); }
		public IList<UserRole> GetList() { return _arrayInternal; }
	 }
	
	#endregion
}
