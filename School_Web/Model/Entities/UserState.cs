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
	/// IUserState interface for NHibernate mapped table 'User_State'.
	/// </summary>
	public interface IUserState
	{
		#region Public Properties
		
		int UserStateId
		{
			get ;
			set ;
			  
		}
		
		int Roleid
		{
			get ;
			set ;
			  
		}
		
		string StateName
		{
			get ;
			set ;
			  
		}
		
		bool IsDeleted { get; set; }
		bool IsChanged { get; set; }
		
		#endregion 
	}

	/// <summary>
	/// UserState object for NHibernate mapped table 'User_State'.
	/// </summary>
	[Serializable]
	public class UserState : IUserState
	{
		#region Member Variables

		protected int userstateid;
		protected int roleid;
		protected string statename;
		protected bool _bIsDeleted;
		protected bool _bIsChanged;
		#endregion
		
		#region Constructors
		public UserState() {}
		
		public UserState(int pUserStateId, int pRoleid, string pStateName)
		{
			this.userstateid = pUserStateId; 
			this.roleid = pRoleid; 
			this.statename = pStateName; 
		}
		
		public UserState(int pUserStateId)
		{
			this.userstateid = pUserStateId; 
		}
		
		#endregion
		
		#region Public Properties
		
		public int UserStateId
		{
			get { return userstateid; }
			set { _bIsChanged |= (userstateid != value); userstateid = value; }
			
		}
		
		public int Roleid
		{
			get { return roleid; }
			set { _bIsChanged |= (roleid != value); roleid = value; }
			
		}
		
		public string StateName
		{
			get { return statename; }
			set 
			{
			  if (value != null && value.Length > 50)
			    throw new ArgumentOutOfRangeException("StateName", "StateName value, cannot contain more than 50 characters");
			  _bIsChanged |= (statename != value); 
			  statename = value; 
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
	
	#region Custom ICollection interface for UserState 

	
	public interface IUserStateCollection : ICollection
	{
		UserState this[int index]{	get; set; }
		void Add(UserState pUserState);
		void Clear();
	}
	
	[Serializable]
	public class UserStateCollection : IUserStateCollection
	{
		private IList<UserState> _arrayInternal;

		public UserStateCollection()
		{
			_arrayInternal = new List<UserState>();
		}
		
		public UserStateCollection( IList<UserState> pSource )
		{
			_arrayInternal = pSource;
			if(_arrayInternal == null)
			{
				_arrayInternal = new List<UserState>();
			}
		}

		public UserState this[int index]
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
		public void CopyTo(Array array, int index){ _arrayInternal.CopyTo((UserState[])array, index); }
		public IEnumerator GetEnumerator() { return _arrayInternal.GetEnumerator(); }
		public void Add(UserState pUserState) { _arrayInternal.Add(pUserState); }
		public void Clear() { _arrayInternal.Clear(); }
		public IList<UserState> GetList() { return _arrayInternal; }
	 }
	
	#endregion
}
