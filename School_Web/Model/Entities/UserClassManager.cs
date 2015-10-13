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
	/// IUserClassManager interface for NHibernate mapped table 'User_Class_Manager'.
	/// </summary>
	public interface IUserClassManager
	{
		#region Public Properties
		
		int Id
		{
			get ;
			set ;
			  
		}
		
		int Termid
		{
			get ;
			set ;
			  
		}
		
		int UserId
		{
			get ;
			set ;
			  
		}
		
		int ClassId
		{
			get ;
			set ;
			  
		}
		
		int Typeid
		{
			get ;
			set ;
			  
		}
		
		bool IsDeleted { get; set; }
		bool IsChanged { get; set; }
		
		#endregion 
	}

	/// <summary>
	/// UserClassManager object for NHibernate mapped table 'User_Class_Manager'.
	/// </summary>
	[Serializable]
	public class UserClassManager : IUserClassManager
	{
		#region Member Variables

		protected int id;
		protected int termid;
		protected int userid;
		protected int classid;
		protected int typeid;
		protected bool _bIsDeleted;
		protected bool _bIsChanged;
		#endregion
		
		#region Constructors
		public UserClassManager() {}
		
		public UserClassManager(int pTermid, int pUserId, int pClassId, int pTypeid)
		{
			this.termid = pTermid; 
			this.userid = pUserId; 
			this.classid = pClassId; 
			this.typeid = pTypeid; 
		}
		
		public UserClassManager(int pTermid, int pUserId, int pClassId)
		{
			this.termid = pTermid; 
			this.userid = pUserId; 
			this.classid = pClassId; 
		}
		
		public UserClassManager(int pId)
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
		
		public int Termid
		{
			get { return termid; }
			set { _bIsChanged |= (termid != value); termid = value; }
			
		}
		
		public int UserId
		{
			get { return userid; }
			set { _bIsChanged |= (userid != value); userid = value; }
			
		}
		
		public int ClassId
		{
			get { return classid; }
			set { _bIsChanged |= (classid != value); classid = value; }
			
		}
		
		public int Typeid
		{
			get { return typeid; }
			set { _bIsChanged |= (typeid != value); typeid = value; }
			
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
	
	#region Custom ICollection interface for UserClassManager 

	
	public interface IUserClassManagerCollection : ICollection
	{
		UserClassManager this[int index]{	get; set; }
		void Add(UserClassManager pUserClassManager);
		void Clear();
	}
	
	[Serializable]
	public class UserClassManagerCollection : IUserClassManagerCollection
	{
		private IList<UserClassManager> _arrayInternal;

		public UserClassManagerCollection()
		{
			_arrayInternal = new List<UserClassManager>();
		}
		
		public UserClassManagerCollection( IList<UserClassManager> pSource )
		{
			_arrayInternal = pSource;
			if(_arrayInternal == null)
			{
				_arrayInternal = new List<UserClassManager>();
			}
		}

		public UserClassManager this[int index]
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
		public void CopyTo(Array array, int index){ _arrayInternal.CopyTo((UserClassManager[])array, index); }
		public IEnumerator GetEnumerator() { return _arrayInternal.GetEnumerator(); }
		public void Add(UserClassManager pUserClassManager) { _arrayInternal.Add(pUserClassManager); }
		public void Clear() { _arrayInternal.Clear(); }
		public IList<UserClassManager> GetList() { return _arrayInternal; }
	 }
	
	#endregion
}
