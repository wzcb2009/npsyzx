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
	/// ILabManager interface for NHibernate mapped table 'Lab_Manager'.
	/// </summary>
	public interface ILabManager
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
		
		bool IsDeleted { get; set; }
		bool IsChanged { get; set; }
		
		#endregion 
	}

	/// <summary>
	/// LabManager object for NHibernate mapped table 'Lab_Manager'.
	/// </summary>
	[Serializable]
	public class LabManager : ILabManager
	{
		#region Member Variables

		protected int id;
		protected int userid;
		protected bool _bIsDeleted;
		protected bool _bIsChanged;
		#endregion
		
		#region Constructors
		public LabManager() {}
		
		public LabManager(int pId, int pUserid)
		{
			this.id = pId; 
			this.userid = pUserid; 
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
	
	#region Custom ICollection interface for LabManager 

	
	public interface ILabManagerCollection : ICollection
	{
		LabManager this[int index]{	get; set; }
		void Add(LabManager pLabManager);
		void Clear();
	}
	
	[Serializable]
	public class LabManagerCollection : ILabManagerCollection
	{
		private IList<LabManager> _arrayInternal;

		public LabManagerCollection()
		{
			_arrayInternal = new List<LabManager>();
		}
		
		public LabManagerCollection( IList<LabManager> pSource )
		{
			_arrayInternal = pSource;
			if(_arrayInternal == null)
			{
				_arrayInternal = new List<LabManager>();
			}
		}

		public LabManager this[int index]
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
		public void CopyTo(Array array, int index){ _arrayInternal.CopyTo((LabManager[])array, index); }
		public IEnumerator GetEnumerator() { return _arrayInternal.GetEnumerator(); }
		public void Add(LabManager pLabManager) { _arrayInternal.Add(pLabManager); }
		public void Clear() { _arrayInternal.Clear(); }
		public IList<LabManager> GetList() { return _arrayInternal; }
	 }
	
	#endregion
}
