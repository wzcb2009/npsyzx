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
	/// IPlan interface for NHibernate mapped table 'Plan'.
	/// </summary>
	public interface IPlan
	{
		#region Public Properties
		
		int Pid
		{
			get ;
			set ;
			  
		}
		
		int Termid
		{
			get ;
			set ;
			  
		}
		
		int Typeid
		{
			get ;
			set ;
			  
		}
		
		DateTime PDate
		{
			get ;
			set ;
			  
		}
		
		string Title
		{
			get ;
			set ;
			  
		}
		
		int Groupid
		{
			get ;
			set ;
			  
		}
		
		int Userid
		{
			get ;
			set ;
			  
		}
		
		string DutyUseriDlist
		{
			get ;
			set ;
			  
		}
		
		bool IsDeleted { get; set; }
		bool IsChanged { get; set; }
		
		#endregion 
	}

	/// <summary>
	/// Plan object for NHibernate mapped table 'Plan'.
	/// </summary>
	[Serializable]
	public class Plan : IPlan
	{
		#region Member Variables

		protected int pid;
		protected int termid;
		protected int typeid;
		protected DateTime pdate;
		protected string title;
		protected int groupid;
		protected int userid;
		protected string dutyuseridlist;
		protected bool _bIsDeleted;
		protected bool _bIsChanged;
		#endregion
		
		#region Constructors
		public Plan() {}
		
		public Plan(int pTermid, int pTypeid, DateTime pPdate, string pTitle, int pGroupid, int pUserid, string pDutyUseriDlist)
		{
			this.termid = pTermid; 
			this.typeid = pTypeid; 
			this.pdate = pPdate; 
			this.title = pTitle; 
			this.groupid = pGroupid; 
			this.userid = pUserid; 
			this.dutyuseridlist = pDutyUseriDlist; 
		}
		
		public Plan(int pPid)
		{
			this.pid = pPid; 
		}
		
		#endregion
		
		#region Public Properties
		
		public int Pid
		{
			get { return pid; }
			set { _bIsChanged |= (pid != value); pid = value; }
			
		}
		
		public int Termid
		{
			get { return termid; }
			set { _bIsChanged |= (termid != value); termid = value; }
			
		}
		
		public int Typeid
		{
			get { return typeid; }
			set { _bIsChanged |= (typeid != value); typeid = value; }
			
		}
		
		public DateTime PDate
		{
			get { return pdate; }
			set { _bIsChanged |= (pdate != value); pdate = value; }
			
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
		
		public int Groupid
		{
			get { return groupid; }
			set { _bIsChanged |= (groupid != value); groupid = value; }
			
		}
		
		public int Userid
		{
			get { return userid; }
			set { _bIsChanged |= (userid != value); userid = value; }
			
		}
		
		public string DutyUseriDlist
		{
			get { return dutyuseridlist; }
			set 
			{
			  if (value != null && value.Length > 50)
			    throw new ArgumentOutOfRangeException("DutyUseriDlist", "DutyUseriDlist value, cannot contain more than 50 characters");
			  _bIsChanged |= (dutyuseridlist != value); 
			  dutyuseridlist = value; 
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
	
	#region Custom ICollection interface for Plan 

	
	public interface IPlanCollection : ICollection
	{
		Plan this[int index]{	get; set; }
		void Add(Plan pPlan);
		void Clear();
	}
	
	[Serializable]
	public class PlanCollection : IPlanCollection
	{
		private IList<Plan> _arrayInternal;

		public PlanCollection()
		{
			_arrayInternal = new List<Plan>();
		}
		
		public PlanCollection( IList<Plan> pSource )
		{
			_arrayInternal = pSource;
			if(_arrayInternal == null)
			{
				_arrayInternal = new List<Plan>();
			}
		}

		public Plan this[int index]
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
		public void CopyTo(Array array, int index){ _arrayInternal.CopyTo((Plan[])array, index); }
		public IEnumerator GetEnumerator() { return _arrayInternal.GetEnumerator(); }
		public void Add(Plan pPlan) { _arrayInternal.Add(pPlan); }
		public void Clear() { _arrayInternal.Clear(); }
		public IList<Plan> GetList() { return _arrayInternal; }
	 }
	
	#endregion
}
