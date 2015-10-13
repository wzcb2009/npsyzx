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
	/// IViewDataMain interface for NHibernate mapped table 'View_Data_Main'.
	/// </summary>
	public interface IViewDataMain
	{
		#region Public Properties
		
		int Id
		{
			get ;
		}
		
		int ParentId
		{
			get ;
		}
		
		int Userid
		{
			get ;
		}
		
		int UnitId
		{
			get ;
		}
		
		int Caseid
		{
			get ;
		}
		
		int Pindex
		{
			get ;
		}
		
		int BrowCount
		{
			get ;
		}
		
		bool Status
		{
			get ;
		}
		
		bool Cmd
		{
			get ;
		}
		
		bool UserRight
		{
			get ;
		}
		
		string Author
		{
			get ;
		}
		
		DateTime PubDate
		{
			get ;
		}
		
		string Title
		{
			get ;
		}
		
		string Remark
		{
			get ;
		}
		
		string Content
		{
			get ;
		}
		
		double Cent
		{
			get ;
		}
		
		DateTime EndDate
		{
			get ;
		}
		
		string Caseids
		{
			get ;
		}
		
		bool IsDeleted { get; set; }
		bool IsChanged { get; set; }
		
		#endregion 
	}

	/// <summary>
	/// ViewDataMain object for NHibernate mapped table 'View_Data_Main'.
	/// </summary>
	[Serializable]
	public class ViewDataMain : IViewDataMain
	{
		#region Member Variables

		protected int id;
		protected int parentid;
		protected int userid;
		protected int unitid;
		protected int caseid;
		protected int pindex;
		protected int browcount;
		protected bool status;
		protected bool cmd;
		protected bool userright;
		protected string author;
		protected DateTime pubdate;
		protected string title;
		protected string remark;
		protected string content;
		protected double cent;
		protected DateTime enddate;
		protected string caseids;
		protected bool _bIsDeleted;
		protected bool _bIsChanged;
		#endregion
		
		#region Constructors
		public ViewDataMain() {}
		
		#endregion
		
		#region Public Properties
		
		public int Id
		{
			get { return id; }
		}
		
		public int ParentId
		{
			get { return parentid; }
		}
		
		public int Userid
		{
			get { return userid; }
		}
		
		public int UnitId
		{
			get { return unitid; }
		}
		
		public int Caseid
		{
			get { return caseid; }
		}
		
		public int Pindex
		{
			get { return pindex; }
		}
		
		public int BrowCount
		{
			get { return browcount; }
		}
		
		public bool Status
		{
			get { return status; }
		}
		
		public bool Cmd
		{
			get { return cmd; }
		}
		
		public bool UserRight
		{
			get { return userright; }
		}
		
		public string Author
		{
			get { return author; }
		}
		
		public DateTime PubDate
		{
			get { return pubdate; }
		}
		
		public string Title
		{
			get { return title; }
		}
		
		public string Remark
		{
			get { return remark; }
		}
		
		public string Content
		{
			get { return content; }
		}
		
		public double Cent
		{
			get { return cent; }
		}
		
		public DateTime EndDate
		{
			get { return enddate; }
		}
		
		public string Caseids
		{
			get { return caseids; }
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
	
	#region Custom ICollection interface for ViewDataMain 

	
	public interface IViewDataMainCollection : ICollection
	{
		ViewDataMain this[int index]{	get; set; }
		void Add(ViewDataMain pViewDataMain);
		void Clear();
	}
	
	[Serializable]
	public class ViewDataMainCollection : IViewDataMainCollection
	{
		private IList<ViewDataMain> _arrayInternal;

		public ViewDataMainCollection()
		{
			_arrayInternal = new List<ViewDataMain>();
		}
		
		public ViewDataMainCollection( IList<ViewDataMain> pSource )
		{
			_arrayInternal = pSource;
			if(_arrayInternal == null)
			{
				_arrayInternal = new List<ViewDataMain>();
			}
		}

		public ViewDataMain this[int index]
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
		public void CopyTo(Array array, int index){ _arrayInternal.CopyTo((ViewDataMain[])array, index); }
		public IEnumerator GetEnumerator() { return _arrayInternal.GetEnumerator(); }
		public void Add(ViewDataMain pViewDataMain) { _arrayInternal.Add(pViewDataMain); }
		public void Clear() { _arrayInternal.Clear(); }
		public IList<ViewDataMain> GetList() { return _arrayInternal; }
	 }
	
	#endregion
}
