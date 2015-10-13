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
	/// IActiveUserRight interface for NHibernate mapped table 'Active_User_Right'.
	/// </summary>
	public interface IActiveUserRight
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
		
		string Caseidlist
		{
			get ;
			set ;
			  
		}
		
		bool IsDeleted { get; set; }
		bool IsChanged { get; set; }
		
		#endregion 
	}

	/// <summary>
	/// ActiveUserRight object for NHibernate mapped table 'Active_User_Right'.
	/// </summary>
	[Serializable]
	public class ActiveUserRight : IActiveUserRight
	{
		#region Member Variables

		protected int id;
		protected int userid;
		protected string caseidlist;
		protected bool _bIsDeleted;
		protected bool _bIsChanged;
		#endregion
		
		#region Constructors
		public ActiveUserRight() {}
		
		public ActiveUserRight(int pId, int pUserid, string pCaseidlist)
		{
			this.id = pId; 
			this.userid = pUserid; 
			this.caseidlist = pCaseidlist; 
		}
		
		public ActiveUserRight(int pId)
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
		
		public string Caseidlist
		{
			get { return caseidlist; }
			set 
			{
			  if (value != null && value.Length > 250)
			    throw new ArgumentOutOfRangeException("Caseidlist", "Caseidlist value, cannot contain more than 250 characters");
			  _bIsChanged |= (caseidlist != value); 
			  caseidlist = value; 
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
	
	#region Custom ICollection interface for ActiveUserRight 

	
	public interface IActiveUserRightCollection : ICollection
	{
		ActiveUserRight this[int index]{	get; set; }
		void Add(ActiveUserRight pActiveUserRight);
		void Clear();
	}
	
	[Serializable]
	public class ActiveUserRightCollection : IActiveUserRightCollection
	{
		private IList<ActiveUserRight> _arrayInternal;

		public ActiveUserRightCollection()
		{
			_arrayInternal = new List<ActiveUserRight>();
		}
		
		public ActiveUserRightCollection( IList<ActiveUserRight> pSource )
		{
			_arrayInternal = pSource;
			if(_arrayInternal == null)
			{
				_arrayInternal = new List<ActiveUserRight>();
			}
		}

		public ActiveUserRight this[int index]
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
		public void CopyTo(Array array, int index){ _arrayInternal.CopyTo((ActiveUserRight[])array, index); }
		public IEnumerator GetEnumerator() { return _arrayInternal.GetEnumerator(); }
		public void Add(ActiveUserRight pActiveUserRight) { _arrayInternal.Add(pActiveUserRight); }
		public void Clear() { _arrayInternal.Clear(); }
		public IList<ActiveUserRight> GetList() { return _arrayInternal; }
	 }
	
	#endregion
}
