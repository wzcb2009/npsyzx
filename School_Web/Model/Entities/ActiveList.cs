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
	/// IActiveList interface for NHibernate mapped table 'ActiveList'.
	/// </summary>
	public interface IActiveList
	{
		#region Public Properties
		
		int Aid
		{
			get ;
			set ;
			  
		}
		
		int Termid
		{
			get ;
			set ;
			  
		}
		
		int Groupid
		{
			get ;
			set ;
			  
		}
		
		string Caseidlist
		{
			get ;
			set ;
			  
		}
		
		string Title
		{
			get ;
			set ;
			  
		}
		
		DateTime SDate
		{
			get ;
			set ;
			  
		}
		
		DateTime EDate
		{
			get ;
			set ;
			  
		}
		
		bool Checked
		{
			get ;
			set ;
			  
		}
		
		int Userid
		{
			get ;
			set ;
			  
		}
		
		int BActiveid
		{
			get ;
			set ;
			  
		}
		
		bool IsDeleted { get; set; }
		bool IsChanged { get; set; }
		
		#endregion 
	}

	/// <summary>
	/// ActiveList object for NHibernate mapped table 'ActiveList'.
	/// </summary>
	[Serializable]
	public class ActiveList : IActiveList
	{
		#region Member Variables

		protected int aid;
		protected int termid;
		protected int groupid;
		protected string caseidlist;
		protected string title;
		protected DateTime sdate;
		protected DateTime edate;
		protected bool checked;
		protected int userid;
		protected int bactiveid;
		protected bool _bIsDeleted;
		protected bool _bIsChanged;
		#endregion
		
		#region Constructors
		public ActiveList() {}
		
		public ActiveList(int pAid, int pTermid, int pGroupid, string pCaseidlist, string pTitle, DateTime pSdate, DateTime pEdate, bool pChecked, int pUserid, int pBactiveid)
		{
			this.aid = pAid; 
			this.termid = pTermid; 
			this.groupid = pGroupid; 
			this.caseidlist = pCaseidlist; 
			this.title = pTitle; 
			this.sdate = pSdate; 
			this.edate = pEdate; 
			this.checked = pChecked; 
			this.userid = pUserid; 
			this.bactiveid = pBactiveid; 
		}
		
		public ActiveList(int pAid)
		{
			this.aid = pAid; 
		}
		
		#endregion
		
		#region Public Properties
		
		public int Aid
		{
			get { return aid; }
			set { _bIsChanged |= (aid != value); aid = value; }
			
		}
		
		public int Termid
		{
			get { return termid; }
			set { _bIsChanged |= (termid != value); termid = value; }
			
		}
		
		public int Groupid
		{
			get { return groupid; }
			set { _bIsChanged |= (groupid != value); groupid = value; }
			
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
		
		public string Title
		{
			get { return title; }
			set 
			{
			  if (value != null && value.Length > 250)
			    throw new ArgumentOutOfRangeException("Title", "Title value, cannot contain more than 250 characters");
			  _bIsChanged |= (title != value); 
			  title = value; 
			}
			
		}
		
		public DateTime SDate
		{
			get { return sdate; }
			set { _bIsChanged |= (sdate != value); sdate = value; }
			
		}
		
		public DateTime EDate
		{
			get { return edate; }
			set { _bIsChanged |= (edate != value); edate = value; }
			
		}
		
		public bool Checked
		{
			get { return checked; }
			set { _bIsChanged |= (checked != value); checked = value; }
			
		}
		
		public int Userid
		{
			get { return userid; }
			set { _bIsChanged |= (userid != value); userid = value; }
			
		}
		
		public int BActiveid
		{
			get { return bactiveid; }
			set { _bIsChanged |= (bactiveid != value); bactiveid = value; }
			
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
	
	#region Custom ICollection interface for ActiveList 

	
	public interface IActiveListCollection : ICollection
	{
		ActiveList this[int index]{	get; set; }
		void Add(ActiveList pActiveList);
		void Clear();
	}
	
	[Serializable]
	public class ActiveListCollection : IActiveListCollection
	{
		private IList<ActiveList> _arrayInternal;

		public ActiveListCollection()
		{
			_arrayInternal = new List<ActiveList>();
		}
		
		public ActiveListCollection( IList<ActiveList> pSource )
		{
			_arrayInternal = pSource;
			if(_arrayInternal == null)
			{
				_arrayInternal = new List<ActiveList>();
			}
		}

		public ActiveList this[int index]
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
		public void CopyTo(Array array, int index){ _arrayInternal.CopyTo((ActiveList[])array, index); }
		public IEnumerator GetEnumerator() { return _arrayInternal.GetEnumerator(); }
		public void Add(ActiveList pActiveList) { _arrayInternal.Add(pActiveList); }
		public void Clear() { _arrayInternal.Clear(); }
		public IList<ActiveList> GetList() { return _arrayInternal; }
	 }
	
	#endregion
}
