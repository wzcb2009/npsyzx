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
	/// IActiveUserList interface for NHibernate mapped table 'Active_UserList'.
	/// </summary>
	public interface IActiveUserList
	{
		#region Public Properties
		
		int Id
		{
			get ;
			set ;
			  
		}
		
		int Activeid
		{
			get ;
			set ;
			  
		}
		
		int Caseid
		{
			get ;
			set ;
			  
		}
		
		int Userid
		{
			get ;
			set ;
			  
		}
		
		DateTime Pubdate
		{
			get ;
			set ;
			  
		}
		
		bool Checked
		{
			get ;
			set ;
			  
		}
		
		string Bz
		{
			get ;
			set ;
			  
		}
		
		double Cent
		{
			get ;
			set ;
			  
		}
		
		string Dj
		{
			get ;
			set ;
			  
		}
		
		double Cent2
		{
			get ;
			set ;
			  
		}
		
		double Szcent
		{
			get ;
			set ;
			  
		}
		
		int Maguserid
		{
			get ;
			set ;
			  
		}
		
		int Pindex
		{
			get ;
			set ;
			  
		}
		
		bool State
		{
			get ;
			set ;
			  
		}
		
		string ZsSrc
		{
			get ;
			set ;
			  
		}
		
		string Content
		{
			get ;
			set ;
			  
		}
		
		bool IsDeleted { get; set; }
		bool IsChanged { get; set; }
		
		#endregion 
	}

	/// <summary>
	/// ActiveUserList object for NHibernate mapped table 'Active_UserList'.
	/// </summary>
	[Serializable]
	public class ActiveUserList : IActiveUserList
	{
		#region Member Variables

		protected int id;
		protected int activeid;
		protected int caseid;
		protected int userid;
		protected DateTime pubdate;
		protected bool checked;
		protected string bz;
		protected double cent;
		protected string dj;
		protected double cent2;
		protected double szcent;
		protected int maguserid;
		protected int pindex;
		protected bool state;
		protected string zssrc;
		protected string content;
		protected bool _bIsDeleted;
		protected bool _bIsChanged;
		#endregion
		
		#region Constructors
		public ActiveUserList() {}
		
		public ActiveUserList(int pId, int pActiveid, int pCaseid, int pUserid, DateTime pPubdate, bool pChecked, string pBz, double pCent, string pDj, double pCent2, double pSzcent, int pMaguserid, int pPindex, bool pState, string pZsSrc, string pContent)
		{
			this.id = pId; 
			this.activeid = pActiveid; 
			this.caseid = pCaseid; 
			this.userid = pUserid; 
			this.pubdate = pPubdate; 
			this.checked = pChecked; 
			this.bz = pBz; 
			this.cent = pCent; 
			this.dj = pDj; 
			this.cent2 = pCent2; 
			this.szcent = pSzcent; 
			this.maguserid = pMaguserid; 
			this.pindex = pPindex; 
			this.state = pState; 
			this.zssrc = pZsSrc; 
			this.content = pContent; 
		}
		
		public ActiveUserList(int pId)
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
		
		public int Activeid
		{
			get { return activeid; }
			set { _bIsChanged |= (activeid != value); activeid = value; }
			
		}
		
		public int Caseid
		{
			get { return caseid; }
			set { _bIsChanged |= (caseid != value); caseid = value; }
			
		}
		
		public int Userid
		{
			get { return userid; }
			set { _bIsChanged |= (userid != value); userid = value; }
			
		}
		
		public DateTime Pubdate
		{
			get { return pubdate; }
			set { _bIsChanged |= (pubdate != value); pubdate = value; }
			
		}
		
		public bool Checked
		{
			get { return checked; }
			set { _bIsChanged |= (checked != value); checked = value; }
			
		}
		
		public string Bz
		{
			get { return bz; }
			set 
			{
			  if (value != null && value.Length > 250)
			    throw new ArgumentOutOfRangeException("Bz", "Bz value, cannot contain more than 250 characters");
			  _bIsChanged |= (bz != value); 
			  bz = value; 
			}
			
		}
		
		public double Cent
		{
			get { return cent; }
			set { _bIsChanged |= (cent != value); cent = value; }
			
		}
		
		public string Dj
		{
			get { return dj; }
			set 
			{
			  if (value != null && value.Length > 50)
			    throw new ArgumentOutOfRangeException("Dj", "Dj value, cannot contain more than 50 characters");
			  _bIsChanged |= (dj != value); 
			  dj = value; 
			}
			
		}
		
		public double Cent2
		{
			get { return cent2; }
			set { _bIsChanged |= (cent2 != value); cent2 = value; }
			
		}
		
		public double Szcent
		{
			get { return szcent; }
			set { _bIsChanged |= (szcent != value); szcent = value; }
			
		}
		
		public int Maguserid
		{
			get { return maguserid; }
			set { _bIsChanged |= (maguserid != value); maguserid = value; }
			
		}
		
		public int Pindex
		{
			get { return pindex; }
			set { _bIsChanged |= (pindex != value); pindex = value; }
			
		}
		
		public bool State
		{
			get { return state; }
			set { _bIsChanged |= (state != value); state = value; }
			
		}
		
		public string ZsSrc
		{
			get { return zssrc; }
			set 
			{
			  if (value != null && value.Length > 250)
			    throw new ArgumentOutOfRangeException("ZsSrc", "ZsSrc value, cannot contain more than 250 characters");
			  _bIsChanged |= (zssrc != value); 
			  zssrc = value; 
			}
			
		}
		
		public string Content
		{
			get { return content; }
			set 
			{
			  if (value != null && value.Length > 1073741823)
			    throw new ArgumentOutOfRangeException("Content", "Content value, cannot contain more than 1073741823 characters");
			  _bIsChanged |= (content != value); 
			  content = value; 
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
	
	#region Custom ICollection interface for ActiveUserList 

	
	public interface IActiveUserListCollection : ICollection
	{
		ActiveUserList this[int index]{	get; set; }
		void Add(ActiveUserList pActiveUserList);
		void Clear();
	}
	
	[Serializable]
	public class ActiveUserListCollection : IActiveUserListCollection
	{
		private IList<ActiveUserList> _arrayInternal;

		public ActiveUserListCollection()
		{
			_arrayInternal = new List<ActiveUserList>();
		}
		
		public ActiveUserListCollection( IList<ActiveUserList> pSource )
		{
			_arrayInternal = pSource;
			if(_arrayInternal == null)
			{
				_arrayInternal = new List<ActiveUserList>();
			}
		}

		public ActiveUserList this[int index]
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
		public void CopyTo(Array array, int index){ _arrayInternal.CopyTo((ActiveUserList[])array, index); }
		public IEnumerator GetEnumerator() { return _arrayInternal.GetEnumerator(); }
		public void Add(ActiveUserList pActiveUserList) { _arrayInternal.Add(pActiveUserList); }
		public void Clear() { _arrayInternal.Clear(); }
		public IList<ActiveUserList> GetList() { return _arrayInternal; }
	 }
	
	#endregion
}
