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
	/// IAsstsApplyManager interface for NHibernate mapped table 'Assts_Apply_manager'.
	/// </summary>
	public interface IAsstsApplyManager
	{
		#region Public Properties
		
		int Id
		{
			get ;
			set ;
			  
		}
		
		int Teacherid
		{
			get ;
			set ;
			  
		}
		
		int LevelId
		{
			get ;
			set ;
			  
		}
		
		string Title
		{
			get ;
			set ;
			  
		}
		
		bool IsDeleted { get; set; }
		bool IsChanged { get; set; }
		
		#endregion 
	}

	/// <summary>
	/// AsstsApplyManager object for NHibernate mapped table 'Assts_Apply_manager'.
	/// </summary>
	[Serializable]
	public class AsstsApplyManager : IAsstsApplyManager
	{
		#region Member Variables

		protected int id;
		protected int teacherid;
		protected int levelid;
		protected string title;
		protected bool _bIsDeleted;
		protected bool _bIsChanged;
		#endregion
		
		#region Constructors
		public AsstsApplyManager() {}
		
		public AsstsApplyManager(int pId, int pTeacherid, int pLevelId, string pTitle)
		{
			this.id = pId; 
			this.teacherid = pTeacherid; 
			this.levelid = pLevelId; 
			this.title = pTitle; 
		}
		
		public AsstsApplyManager(int pId)
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
		
		public int Teacherid
		{
			get { return teacherid; }
			set { _bIsChanged |= (teacherid != value); teacherid = value; }
			
		}
		
		public int LevelId
		{
			get { return levelid; }
			set { _bIsChanged |= (levelid != value); levelid = value; }
			
		}
		
		public string Title
		{
			get { return title; }
			set 
			{
			  if (value != null && value.Length > 50)
			    throw new ArgumentOutOfRangeException("Title", "Title value, cannot contain more than 50 characters");
			  _bIsChanged |= (title != value); 
			  title = value; 
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
	
	#region Custom ICollection interface for AsstsApplyManager 

	
	public interface IAsstsApplyManagerCollection : ICollection
	{
		AsstsApplyManager this[int index]{	get; set; }
		void Add(AsstsApplyManager pAsstsApplyManager);
		void Clear();
	}
	
	[Serializable]
	public class AsstsApplyManagerCollection : IAsstsApplyManagerCollection
	{
		private IList<AsstsApplyManager> _arrayInternal;

		public AsstsApplyManagerCollection()
		{
			_arrayInternal = new List<AsstsApplyManager>();
		}
		
		public AsstsApplyManagerCollection( IList<AsstsApplyManager> pSource )
		{
			_arrayInternal = pSource;
			if(_arrayInternal == null)
			{
				_arrayInternal = new List<AsstsApplyManager>();
			}
		}

		public AsstsApplyManager this[int index]
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
		public void CopyTo(Array array, int index){ _arrayInternal.CopyTo((AsstsApplyManager[])array, index); }
		public IEnumerator GetEnumerator() { return _arrayInternal.GetEnumerator(); }
		public void Add(AsstsApplyManager pAsstsApplyManager) { _arrayInternal.Add(pAsstsApplyManager); }
		public void Clear() { _arrayInternal.Clear(); }
		public IList<AsstsApplyManager> GetList() { return _arrayInternal; }
	 }
	
	#endregion
}
