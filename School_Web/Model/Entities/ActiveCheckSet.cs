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
	/// IActiveCheckSet interface for NHibernate mapped table 'Active_CheckSet'.
	/// </summary>
	public interface IActiveCheckSet
	{
		#region Public Properties
		
		int Id
		{
			get ;
			set ;
			  
		}
		
		int ActCaseId
		{
			get ;
			set ;
			  
		}
		
		int CheckIndex
		{
			get ;
			set ;
			  
		}
		
		int CheckUserId
		{
			get ;
			set ;
			  
		}
		
		bool IsDeleted { get; set; }
		bool IsChanged { get; set; }
		
		#endregion 
	}

	/// <summary>
	/// ActiveCheckSet object for NHibernate mapped table 'Active_CheckSet'.
	/// </summary>
	[Serializable]
	public class ActiveCheckSet : IActiveCheckSet
	{
		#region Member Variables

		protected int id;
		protected int actcaseid;
		protected int checkindex;
		protected int checkuserid;
		protected bool _bIsDeleted;
		protected bool _bIsChanged;
		#endregion
		
		#region Constructors
		public ActiveCheckSet() {}
		
		public ActiveCheckSet(int pId, int pActCaseId, int pCheckIndex, int pCheckUserId)
		{
			this.id = pId; 
			this.actcaseid = pActCaseId; 
			this.checkindex = pCheckIndex; 
			this.checkuserid = pCheckUserId; 
		}
		
		public ActiveCheckSet(int pId)
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
		
		public int ActCaseId
		{
			get { return actcaseid; }
			set { _bIsChanged |= (actcaseid != value); actcaseid = value; }
			
		}
		
		public int CheckIndex
		{
			get { return checkindex; }
			set { _bIsChanged |= (checkindex != value); checkindex = value; }
			
		}
		
		public int CheckUserId
		{
			get { return checkuserid; }
			set { _bIsChanged |= (checkuserid != value); checkuserid = value; }
			
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
	
	#region Custom ICollection interface for ActiveCheckSet 

	
	public interface IActiveCheckSetCollection : ICollection
	{
		ActiveCheckSet this[int index]{	get; set; }
		void Add(ActiveCheckSet pActiveCheckSet);
		void Clear();
	}
	
	[Serializable]
	public class ActiveCheckSetCollection : IActiveCheckSetCollection
	{
		private IList<ActiveCheckSet> _arrayInternal;

		public ActiveCheckSetCollection()
		{
			_arrayInternal = new List<ActiveCheckSet>();
		}
		
		public ActiveCheckSetCollection( IList<ActiveCheckSet> pSource )
		{
			_arrayInternal = pSource;
			if(_arrayInternal == null)
			{
				_arrayInternal = new List<ActiveCheckSet>();
			}
		}

		public ActiveCheckSet this[int index]
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
		public void CopyTo(Array array, int index){ _arrayInternal.CopyTo((ActiveCheckSet[])array, index); }
		public IEnumerator GetEnumerator() { return _arrayInternal.GetEnumerator(); }
		public void Add(ActiveCheckSet pActiveCheckSet) { _arrayInternal.Add(pActiveCheckSet); }
		public void Clear() { _arrayInternal.Clear(); }
		public IList<ActiveCheckSet> GetList() { return _arrayInternal; }
	 }
	
	#endregion
}
