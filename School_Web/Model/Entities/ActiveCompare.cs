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
	/// IActiveCompare interface for NHibernate mapped table 'ActiveCompare'.
	/// </summary>
	public interface IActiveCompare
	{
		#region Public Properties
		
		int Id
		{
			get ;
			set ;
			  
		}
		
		int ActiveId
		{
			get ;
			set ;
			  
		}
		
		int GradeId
		{
			get ;
			set ;
			  
		}
		
		int ClassId
		{
			get ;
			set ;
			  
		}
		
		int PrevActiveId
		{
			get ;
			set ;
			  
		}
		
		bool IsDeleted { get; set; }
		bool IsChanged { get; set; }
		
		#endregion 
	}

	/// <summary>
	/// ActiveCompare object for NHibernate mapped table 'ActiveCompare'.
	/// </summary>
	[Serializable]
	public class ActiveCompare : IActiveCompare
	{
		#region Member Variables

		protected int id;
		protected int activeid;
		protected int gradeid;
		protected int classid;
		protected int prevactiveid;
		protected bool _bIsDeleted;
		protected bool _bIsChanged;
		#endregion
		
		#region Constructors
		public ActiveCompare() {}
		
		public ActiveCompare(int pActiveId, int pGradeId, int pClassId, int pPrevActiveId)
		{
			this.activeid = pActiveId; 
			this.gradeid = pGradeId; 
			this.classid = pClassId; 
			this.prevactiveid = pPrevActiveId; 
		}
		
		public ActiveCompare(int pId)
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
		
		public int ActiveId
		{
			get { return activeid; }
			set { _bIsChanged |= (activeid != value); activeid = value; }
			
		}
		
		public int GradeId
		{
			get { return gradeid; }
			set { _bIsChanged |= (gradeid != value); gradeid = value; }
			
		}
		
		public int ClassId
		{
			get { return classid; }
			set { _bIsChanged |= (classid != value); classid = value; }
			
		}
		
		public int PrevActiveId
		{
			get { return prevactiveid; }
			set { _bIsChanged |= (prevactiveid != value); prevactiveid = value; }
			
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
	
	#region Custom ICollection interface for ActiveCompare 

	
	public interface IActiveCompareCollection : ICollection
	{
		ActiveCompare this[int index]{	get; set; }
		void Add(ActiveCompare pActiveCompare);
		void Clear();
	}
	
	[Serializable]
	public class ActiveCompareCollection : IActiveCompareCollection
	{
		private IList<ActiveCompare> _arrayInternal;

		public ActiveCompareCollection()
		{
			_arrayInternal = new List<ActiveCompare>();
		}
		
		public ActiveCompareCollection( IList<ActiveCompare> pSource )
		{
			_arrayInternal = pSource;
			if(_arrayInternal == null)
			{
				_arrayInternal = new List<ActiveCompare>();
			}
		}

		public ActiveCompare this[int index]
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
		public void CopyTo(Array array, int index){ _arrayInternal.CopyTo((ActiveCompare[])array, index); }
		public IEnumerator GetEnumerator() { return _arrayInternal.GetEnumerator(); }
		public void Add(ActiveCompare pActiveCompare) { _arrayInternal.Add(pActiveCompare); }
		public void Clear() { _arrayInternal.Clear(); }
		public IList<ActiveCompare> GetList() { return _arrayInternal; }
	 }
	
	#endregion
}
