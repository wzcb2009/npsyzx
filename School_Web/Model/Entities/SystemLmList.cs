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
	/// ISystemLmList interface for NHibernate mapped table 'System_LmList'.
	/// </summary>
	public interface ISystemLmList
	{
		#region Public Properties
		
		int Lmid
		{
			get ;
			set ;
			  
		}
		
		int ModuleId
		{
			get ;
			set ;
			  
		}
		
		string ClassName
		{
			get ;
			set ;
			  
		}
		
		string Url
		{
			get ;
			set ;
			  
		}
		
		int Parentid
		{
			get ;
			set ;
			  
		}
		
		int Depth
		{
			get ;
			set ;
			  
		}
		
		int Pindex
		{
			get ;
			set ;
			  
		}
		
		bool Isshow
		{
			get ;
			set ;
			  
		}
		
		bool IsDeleted { get; set; }
		bool IsChanged { get; set; }
		
		#endregion 
	}

	/// <summary>
	/// SystemLmList object for NHibernate mapped table 'System_LmList'.
	/// </summary>
	[Serializable]
	public class SystemLmList : ISystemLmList
	{
		#region Member Variables

		protected int lmid;
		protected int moduleid;
		protected string classname;
		protected string url;
		protected int parentid;
		protected int depth;
		protected int pindex;
		protected bool isshow;
		protected bool _bIsDeleted;
		protected bool _bIsChanged;
		#endregion
		
		#region Constructors
		public SystemLmList() {}
		
		public SystemLmList(int pModuleId, string pClassName, string pUrl, int pParentid, int pDepth, int pPindex, bool pIsshow)
		{
			this.moduleid = pModuleId; 
			this.classname = pClassName; 
			this.url = pUrl; 
			this.parentid = pParentid; 
			this.depth = pDepth; 
			this.pindex = pPindex; 
			this.isshow = pIsshow; 
		}
		
		public SystemLmList(int pLmid)
		{
			this.lmid = pLmid; 
		}
		
		#endregion
		
		#region Public Properties
		
		public int Lmid
		{
			get { return lmid; }
			set { _bIsChanged |= (lmid != value); lmid = value; }
			
		}
		
		public int ModuleId
		{
			get { return moduleid; }
			set { _bIsChanged |= (moduleid != value); moduleid = value; }
			
		}
		
		public string ClassName
		{
			get { return classname; }
			set 
			{
			  if (value != null && value.Length > 50)
			    throw new ArgumentOutOfRangeException("ClassName", "ClassName value, cannot contain more than 50 characters");
			  _bIsChanged |= (classname != value); 
			  classname = value; 
			}
			
		}
		
		public string Url
		{
			get { return url; }
			set 
			{
			  if (value != null && value.Length > 50)
			    throw new ArgumentOutOfRangeException("Url", "Url value, cannot contain more than 50 characters");
			  _bIsChanged |= (url != value); 
			  url = value; 
			}
			
		}
		
		public int Parentid
		{
			get { return parentid; }
			set { _bIsChanged |= (parentid != value); parentid = value; }
			
		}
		
		public int Depth
		{
			get { return depth; }
			set { _bIsChanged |= (depth != value); depth = value; }
			
		}
		
		public int Pindex
		{
			get { return pindex; }
			set { _bIsChanged |= (pindex != value); pindex = value; }
			
		}
		
		public bool Isshow
		{
			get { return isshow; }
			set { _bIsChanged |= (isshow != value); isshow = value; }
			
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
	
	#region Custom ICollection interface for SystemLmList 

	
	public interface ISystemLmListCollection : ICollection
	{
		SystemLmList this[int index]{	get; set; }
		void Add(SystemLmList pSystemLmList);
		void Clear();
	}
	
	[Serializable]
	public class SystemLmListCollection : ISystemLmListCollection
	{
		private IList<SystemLmList> _arrayInternal;

		public SystemLmListCollection()
		{
			_arrayInternal = new List<SystemLmList>();
		}
		
		public SystemLmListCollection( IList<SystemLmList> pSource )
		{
			_arrayInternal = pSource;
			if(_arrayInternal == null)
			{
				_arrayInternal = new List<SystemLmList>();
			}
		}

		public SystemLmList this[int index]
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
		public void CopyTo(Array array, int index){ _arrayInternal.CopyTo((SystemLmList[])array, index); }
		public IEnumerator GetEnumerator() { return _arrayInternal.GetEnumerator(); }
		public void Add(SystemLmList pSystemLmList) { _arrayInternal.Add(pSystemLmList); }
		public void Clear() { _arrayInternal.Clear(); }
		public IList<SystemLmList> GetList() { return _arrayInternal; }
	 }
	
	#endregion
}
