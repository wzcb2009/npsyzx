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
	/// IJournalSystemLmList interface for NHibernate mapped table 'Journal_system_LmList'.
	/// </summary>
	public interface IJournalSystemLmList
	{
		#region Public Properties
		
		int Lmid
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
		
		int Roleid
		{
			get ;
			set ;
			  
		}
		
		string Syslmid
		{
			get ;
			set ;
			  
		}
		
		bool IsDeleted { get; set; }
		bool IsChanged { get; set; }
		
		#endregion 
	}

	/// <summary>
	/// JournalSystemLmList object for NHibernate mapped table 'Journal_system_LmList'.
	/// </summary>
	[Serializable]
	public class JournalSystemLmList : IJournalSystemLmList
	{
		#region Member Variables

		protected int lmid;
		protected string classname;
		protected string url;
		protected int parentid;
		protected int depth;
		protected int pindex;
		protected int roleid;
		protected string syslmid;
		protected bool _bIsDeleted;
		protected bool _bIsChanged;
		#endregion
		
		#region Constructors
		public JournalSystemLmList() {}
		
		public JournalSystemLmList(int pLmid, string pClassName, string pUrl, int pParentid, int pDepth, int pPindex, int pRoleid, string pSyslmid)
		{
			this.lmid = pLmid; 
			this.classname = pClassName; 
			this.url = pUrl; 
			this.parentid = pParentid; 
			this.depth = pDepth; 
			this.pindex = pPindex; 
			this.roleid = pRoleid; 
			this.syslmid = pSyslmid; 
		}
		
		public JournalSystemLmList(int pLmid)
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
		
		public int Roleid
		{
			get { return roleid; }
			set { _bIsChanged |= (roleid != value); roleid = value; }
			
		}
		
		public string Syslmid
		{
			get { return syslmid; }
			set 
			{
			  if (value != null && value.Length > 250)
			    throw new ArgumentOutOfRangeException("Syslmid", "Syslmid value, cannot contain more than 250 characters");
			  _bIsChanged |= (syslmid != value); 
			  syslmid = value; 
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
	
	#region Custom ICollection interface for JournalSystemLmList 

	
	public interface IJournalSystemLmListCollection : ICollection
	{
		JournalSystemLmList this[int index]{	get; set; }
		void Add(JournalSystemLmList pJournalSystemLmList);
		void Clear();
	}
	
	[Serializable]
	public class JournalSystemLmListCollection : IJournalSystemLmListCollection
	{
		private IList<JournalSystemLmList> _arrayInternal;

		public JournalSystemLmListCollection()
		{
			_arrayInternal = new List<JournalSystemLmList>();
		}
		
		public JournalSystemLmListCollection( IList<JournalSystemLmList> pSource )
		{
			_arrayInternal = pSource;
			if(_arrayInternal == null)
			{
				_arrayInternal = new List<JournalSystemLmList>();
			}
		}

		public JournalSystemLmList this[int index]
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
		public void CopyTo(Array array, int index){ _arrayInternal.CopyTo((JournalSystemLmList[])array, index); }
		public IEnumerator GetEnumerator() { return _arrayInternal.GetEnumerator(); }
		public void Add(JournalSystemLmList pJournalSystemLmList) { _arrayInternal.Add(pJournalSystemLmList); }
		public void Clear() { _arrayInternal.Clear(); }
		public IList<JournalSystemLmList> GetList() { return _arrayInternal; }
	 }
	
	#endregion
}
