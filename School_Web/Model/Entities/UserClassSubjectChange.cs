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
	/// IUserClassSubjectChange interface for NHibernate mapped table 'User_Class_Subject_Change'.
	/// </summary>
	public interface IUserClassSubjectChange
	{
		#region Public Properties
		
		int Id
		{
			get ;
			set ;
			  
		}
		
		int Parentid
		{
			get ;
			set ;
			  
		}
		
		int Windex
		{
			get ;
			set ;
			  
		}
		
		string Bz
		{
			get ;
			set ;
			  
		}
		
		bool IsDeleted { get; set; }
		bool IsChanged { get; set; }
		
		#endregion 
	}

	/// <summary>
	/// UserClassSubjectChange object for NHibernate mapped table 'User_Class_Subject_Change'.
	/// </summary>
	[Serializable]
	public class UserClassSubjectChange : IUserClassSubjectChange
	{
		#region Member Variables

		protected int id;
		protected int parentid;
		protected int windex;
		protected string bz;
		protected bool _bIsDeleted;
		protected bool _bIsChanged;
		#endregion
		
		#region Constructors
		public UserClassSubjectChange() {}
		
		public UserClassSubjectChange(int pParentid, int pWindex, string pBz)
		{
			this.parentid = pParentid; 
			this.windex = pWindex; 
			this.bz = pBz; 
		}
		
		public UserClassSubjectChange(int pId)
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
		
		public int Parentid
		{
			get { return parentid; }
			set { _bIsChanged |= (parentid != value); parentid = value; }
			
		}
		
		public int Windex
		{
			get { return windex; }
			set { _bIsChanged |= (windex != value); windex = value; }
			
		}
		
		public string Bz
		{
			get { return bz; }
			set 
			{
			  if (value != null && value.Length > 250)
			    throw new ArgumentOutOfRangeException("Bz", "Bz value, cannot contain more than 250 characters");
			  _bIsChanged |= (bz != value); 
			  bz = value; 
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
	
	#region Custom ICollection interface for UserClassSubjectChange 

	
	public interface IUserClassSubjectChangeCollection : ICollection
	{
		UserClassSubjectChange this[int index]{	get; set; }
		void Add(UserClassSubjectChange pUserClassSubjectChange);
		void Clear();
	}
	
	[Serializable]
	public class UserClassSubjectChangeCollection : IUserClassSubjectChangeCollection
	{
		private IList<UserClassSubjectChange> _arrayInternal;

		public UserClassSubjectChangeCollection()
		{
			_arrayInternal = new List<UserClassSubjectChange>();
		}
		
		public UserClassSubjectChangeCollection( IList<UserClassSubjectChange> pSource )
		{
			_arrayInternal = pSource;
			if(_arrayInternal == null)
			{
				_arrayInternal = new List<UserClassSubjectChange>();
			}
		}

		public UserClassSubjectChange this[int index]
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
		public void CopyTo(Array array, int index){ _arrayInternal.CopyTo((UserClassSubjectChange[])array, index); }
		public IEnumerator GetEnumerator() { return _arrayInternal.GetEnumerator(); }
		public void Add(UserClassSubjectChange pUserClassSubjectChange) { _arrayInternal.Add(pUserClassSubjectChange); }
		public void Clear() { _arrayInternal.Clear(); }
		public IList<UserClassSubjectChange> GetList() { return _arrayInternal; }
	 }
	
	#endregion
}
