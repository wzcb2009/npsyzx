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
	/// ISystemLmUserRight interface for NHibernate mapped table 'System_Lm_User_Right'.
	/// </summary>
	public interface ISystemLmUserRight
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
		
		string LmidList
		{
			get ;
			set ;
			  
		}
		
		bool IsDeleted { get; set; }
		bool IsChanged { get; set; }
		
		#endregion 
	}

	/// <summary>
	/// SystemLmUserRight object for NHibernate mapped table 'System_Lm_User_Right'.
	/// </summary>
	[Serializable]
	public class SystemLmUserRight : ISystemLmUserRight
	{
		#region Member Variables

		protected int id;
		protected int userid;
		protected string lmidlist;
		protected bool _bIsDeleted;
		protected bool _bIsChanged;
		#endregion
		
		#region Constructors
		public SystemLmUserRight() {}
		
		public SystemLmUserRight(int pUserid, string pLmidList)
		{
			this.userid = pUserid; 
			this.lmidlist = pLmidList; 
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
		
		public string LmidList
		{
			get { return lmidlist; }
			set 
			{
			  if (value != null && value.Length > 2147483647)
			    throw new ArgumentOutOfRangeException("LmidList", "LmidList value, cannot contain more than 2147483647 characters");
			  _bIsChanged |= (lmidlist != value); 
			  lmidlist = value; 
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
	
	#region Custom ICollection interface for SystemLmUserRight 

	
	public interface ISystemLmUserRightCollection : ICollection
	{
		SystemLmUserRight this[int index]{	get; set; }
		void Add(SystemLmUserRight pSystemLmUserRight);
		void Clear();
	}
	
	[Serializable]
	public class SystemLmUserRightCollection : ISystemLmUserRightCollection
	{
		private IList<SystemLmUserRight> _arrayInternal;

		public SystemLmUserRightCollection()
		{
			_arrayInternal = new List<SystemLmUserRight>();
		}
		
		public SystemLmUserRightCollection( IList<SystemLmUserRight> pSource )
		{
			_arrayInternal = pSource;
			if(_arrayInternal == null)
			{
				_arrayInternal = new List<SystemLmUserRight>();
			}
		}

		public SystemLmUserRight this[int index]
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
		public void CopyTo(Array array, int index){ _arrayInternal.CopyTo((SystemLmUserRight[])array, index); }
		public IEnumerator GetEnumerator() { return _arrayInternal.GetEnumerator(); }
		public void Add(SystemLmUserRight pSystemLmUserRight) { _arrayInternal.Add(pSystemLmUserRight); }
		public void Clear() { _arrayInternal.Clear(); }
		public IList<SystemLmUserRight> GetList() { return _arrayInternal; }
	 }
	
	#endregion
}
