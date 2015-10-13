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
	/// ILabActiveList interface for NHibernate mapped table 'Lab_ActiveList'.
	/// </summary>
	public interface ILabActiveList
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
		
		int Caseid
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
		
		bool IsDeleted { get; set; }
		bool IsChanged { get; set; }
		
		#endregion 
	}

	/// <summary>
	/// LabActiveList object for NHibernate mapped table 'Lab_ActiveList'.
	/// </summary>
	[Serializable]
	public class LabActiveList : ILabActiveList
	{
		#region Member Variables

		protected int aid;
		protected int termid;
		protected int groupid;
		protected int caseid;
		protected string title;
		protected DateTime sdate;
		protected DateTime edate;
		protected bool checked;
		protected int userid;
		protected bool _bIsDeleted;
		protected bool _bIsChanged;
		#endregion
		
		#region Constructors
		public LabActiveList() {}
		
		public LabActiveList(int pAid, int pTermid, int pGroupid, int pCaseid, string pTitle, DateTime pSdate, DateTime pEdate, bool pChecked, int pUserid)
		{
			this.aid = pAid; 
			this.termid = pTermid; 
			this.groupid = pGroupid; 
			this.caseid = pCaseid; 
			this.title = pTitle; 
			this.sdate = pSdate; 
			this.edate = pEdate; 
			this.checked = pChecked; 
			this.userid = pUserid; 
		}
		
		public LabActiveList(int pAid)
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
		
		public int Caseid
		{
			get { return caseid; }
			set { _bIsChanged |= (caseid != value); caseid = value; }
			
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
	
	#region Custom ICollection interface for LabActiveList 

	
	public interface ILabActiveListCollection : ICollection
	{
		LabActiveList this[int index]{	get; set; }
		void Add(LabActiveList pLabActiveList);
		void Clear();
	}
	
	[Serializable]
	public class LabActiveListCollection : ILabActiveListCollection
	{
		private IList<LabActiveList> _arrayInternal;

		public LabActiveListCollection()
		{
			_arrayInternal = new List<LabActiveList>();
		}
		
		public LabActiveListCollection( IList<LabActiveList> pSource )
		{
			_arrayInternal = pSource;
			if(_arrayInternal == null)
			{
				_arrayInternal = new List<LabActiveList>();
			}
		}

		public LabActiveList this[int index]
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
		public void CopyTo(Array array, int index){ _arrayInternal.CopyTo((LabActiveList[])array, index); }
		public IEnumerator GetEnumerator() { return _arrayInternal.GetEnumerator(); }
		public void Add(LabActiveList pLabActiveList) { _arrayInternal.Add(pLabActiveList); }
		public void Clear() { _arrayInternal.Clear(); }
		public IList<LabActiveList> GetList() { return _arrayInternal; }
	 }
	
	#endregion
}
