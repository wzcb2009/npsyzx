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
	/// IActiveUserlistMarks interface for NHibernate mapped table 'Active_Userlist_marks'.
	/// </summary>
	public interface IActiveUserlistMarks
	{
		#region Public Properties
		
		int Id
		{
			get ;
			set ;
			  
		}
		
		int ActiveUserId
		{
			get ;
			set ;
			  
		}
		
		string Username
		{
			get ;
			set ;
			  
		}
		
		double Cent
		{
			get ;
			set ;
			  
		}
		
		bool IsDeleted { get; set; }
		bool IsChanged { get; set; }
		
		#endregion 
	}

	/// <summary>
	/// ActiveUserlistMarks object for NHibernate mapped table 'Active_Userlist_marks'.
	/// </summary>
	[Serializable]
	public class ActiveUserlistMarks : IActiveUserlistMarks
	{
		#region Member Variables

		protected int id;
		protected int activeuserid;
		protected string username;
		protected double cent;
		protected bool _bIsDeleted;
		protected bool _bIsChanged;
		#endregion
		
		#region Constructors
		public ActiveUserlistMarks() {}
		
		public ActiveUserlistMarks(int pId, int pActiveUserId, string pUsername, double pCent)
		{
			this.id = pId; 
			this.activeuserid = pActiveUserId; 
			this.username = pUsername; 
			this.cent = pCent; 
		}
		
		public ActiveUserlistMarks(int pId)
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
		
		public int ActiveUserId
		{
			get { return activeuserid; }
			set { _bIsChanged |= (activeuserid != value); activeuserid = value; }
			
		}
		
		public string Username
		{
			get { return username; }
			set 
			{
			  if (value != null && value.Length > 50)
			    throw new ArgumentOutOfRangeException("Username", "Username value, cannot contain more than 50 characters");
			  _bIsChanged |= (username != value); 
			  username = value; 
			}
			
		}
		
		public double Cent
		{
			get { return cent; }
			set { _bIsChanged |= (cent != value); cent = value; }
			
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
	
	#region Custom ICollection interface for ActiveUserlistMarks 

	
	public interface IActiveUserlistMarksCollection : ICollection
	{
		ActiveUserlistMarks this[int index]{	get; set; }
		void Add(ActiveUserlistMarks pActiveUserlistMarks);
		void Clear();
	}
	
	[Serializable]
	public class ActiveUserlistMarksCollection : IActiveUserlistMarksCollection
	{
		private IList<ActiveUserlistMarks> _arrayInternal;

		public ActiveUserlistMarksCollection()
		{
			_arrayInternal = new List<ActiveUserlistMarks>();
		}
		
		public ActiveUserlistMarksCollection( IList<ActiveUserlistMarks> pSource )
		{
			_arrayInternal = pSource;
			if(_arrayInternal == null)
			{
				_arrayInternal = new List<ActiveUserlistMarks>();
			}
		}

		public ActiveUserlistMarks this[int index]
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
		public void CopyTo(Array array, int index){ _arrayInternal.CopyTo((ActiveUserlistMarks[])array, index); }
		public IEnumerator GetEnumerator() { return _arrayInternal.GetEnumerator(); }
		public void Add(ActiveUserlistMarks pActiveUserlistMarks) { _arrayInternal.Add(pActiveUserlistMarks); }
		public void Clear() { _arrayInternal.Clear(); }
		public IList<ActiveUserlistMarks> GetList() { return _arrayInternal; }
	 }
	
	#endregion
}
