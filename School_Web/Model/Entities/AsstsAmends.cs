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
	/// IAsstsAmends interface for NHibernate mapped table 'Assts_amends'.
	/// </summary>
	public interface IAsstsAmends
	{
		#region Public Properties
		
		int Id
		{
			get ;
			set ;
			  
		}
		
		int Num
		{
			get ;
			set ;
			  
		}
		
		int AppTeacherid
		{
			get ;
			set ;
			  
		}
		
		string AppTruename
		{
			get ;
			set ;
			  
		}
		
		string AppUnit
		{
			get ;
			set ;
			  
		}
		
		string AppTel
		{
			get ;
			set ;
			  
		}
		
		string AppAddress
		{
			get ;
			set ;
			  
		}
		
		string AppWhy
		{
			get ;
			set ;
			  
		}
		
		string AppProblem
		{
			get ;
			set ;
			  
		}
		
		DateTime AppDate
		{
			get ;
			set ;
			  
		}
		
		string AppFeedback
		{
			get ;
			set ;
			  
		}
		
		DateTime AppFdDate
		{
			get ;
			set ;
			  
		}
		
		int DoTeacherId
		{
			get ;
			set ;
			  
		}
		
		string DoTrueName
		{
			get ;
			set ;
			  
		}
		
		DateTime DoDate
		{
			get ;
			set ;
			  
		}
		
		bool DoIscharge
		{
			get ;
			set ;
			  
		}
		
		string DoCharge
		{
			get ;
			set ;
			  
		}
		
		bool DoAmends
		{
			get ;
			set ;
			  
		}
		
		string DoAmendsMy
		{
			get ;
			set ;
			  
		}
		
		string DoFeedback
		{
			get ;
			set ;
			  
		}
		
		int State
		{
			get ;
			set ;
			  
		}
		
		string MendTruename
		{
			get ;
			set ;
			  
		}
		
		DateTime MendDate
		{
			get ;
			set ;
			  
		}
		
		string UserName
		{
			get ;
			set ;
			  
		}
		
		string Wq
		{
			get ;
			set ;
			  
		}
		
		bool IsDeleted { get; set; }
		bool IsChanged { get; set; }
		
		#endregion 
	}

	/// <summary>
	/// AsstsAmends object for NHibernate mapped table 'Assts_amends'.
	/// </summary>
	[Serializable]
	public class AsstsAmends : IAsstsAmends
	{
		#region Member Variables

		protected int id;
		protected int num;
		protected int appteacherid;
		protected string apptruename;
		protected string appunit;
		protected string apptel;
		protected string appaddress;
		protected string appwhy;
		protected string appproblem;
		protected DateTime appdate;
		protected string appfeedback;
		protected DateTime appfddate;
		protected int doteacherid;
		protected string dotruename;
		protected DateTime dodate;
		protected bool doischarge;
		protected string docharge;
		protected bool doamends;
		protected string doamendsmy;
		protected string dofeedback;
		protected int state;
		protected string mendtruename;
		protected DateTime menddate;
		protected string username;
		protected string wq;
		protected bool _bIsDeleted;
		protected bool _bIsChanged;
		#endregion
		
		#region Constructors
		public AsstsAmends() {}
		
		public AsstsAmends(int pNum, int pAppTeacherid, string pAppTruename, string pAppUnit, string pAppTel, string pAppAddress, string pAppWhy, string pAppProblem, DateTime pAppDate, string pAppFeedback, DateTime pAppFdDate, int pDoTeacherId, string pDoTrueName, DateTime pDoDate, bool pDoIscharge, string pDoCharge, bool pDoAmends, string pDoAmendsMy, string pDoFeedback, int pState, string pMendTruename, DateTime pMendDate, string pUserName, string pWq)
		{
			this.num = pNum; 
			this.appteacherid = pAppTeacherid; 
			this.apptruename = pAppTruename; 
			this.appunit = pAppUnit; 
			this.apptel = pAppTel; 
			this.appaddress = pAppAddress; 
			this.appwhy = pAppWhy; 
			this.appproblem = pAppProblem; 
			this.appdate = pAppDate; 
			this.appfeedback = pAppFeedback; 
			this.appfddate = pAppFdDate; 
			this.doteacherid = pDoTeacherId; 
			this.dotruename = pDoTrueName; 
			this.dodate = pDoDate; 
			this.doischarge = pDoIscharge; 
			this.docharge = pDoCharge; 
			this.doamends = pDoAmends; 
			this.doamendsmy = pDoAmendsMy; 
			this.dofeedback = pDoFeedback; 
			this.state = pState; 
			this.mendtruename = pMendTruename; 
			this.menddate = pMendDate; 
			this.username = pUserName; 
			this.wq = pWq; 
		}
		
		public AsstsAmends(int pId)
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
		
		public int Num
		{
			get { return num; }
			set { _bIsChanged |= (num != value); num = value; }
			
		}
		
		public int AppTeacherid
		{
			get { return appteacherid; }
			set { _bIsChanged |= (appteacherid != value); appteacherid = value; }
			
		}
		
		public string AppTruename
		{
			get { return apptruename; }
			set 
			{
			  if (value != null && value.Length > 50)
			    throw new ArgumentOutOfRangeException("AppTruename", "AppTruename value, cannot contain more than 50 characters");
			  _bIsChanged |= (apptruename != value); 
			  apptruename = value; 
			}
			
		}
		
		public string AppUnit
		{
			get { return appunit; }
			set 
			{
			  if (value != null && value.Length > 50)
			    throw new ArgumentOutOfRangeException("AppUnit", "AppUnit value, cannot contain more than 50 characters");
			  _bIsChanged |= (appunit != value); 
			  appunit = value; 
			}
			
		}
		
		public string AppTel
		{
			get { return apptel; }
			set 
			{
			  if (value != null && value.Length > 50)
			    throw new ArgumentOutOfRangeException("AppTel", "AppTel value, cannot contain more than 50 characters");
			  _bIsChanged |= (apptel != value); 
			  apptel = value; 
			}
			
		}
		
		public string AppAddress
		{
			get { return appaddress; }
			set 
			{
			  if (value != null && value.Length > 255)
			    throw new ArgumentOutOfRangeException("AppAddress", "AppAddress value, cannot contain more than 255 characters");
			  _bIsChanged |= (appaddress != value); 
			  appaddress = value; 
			}
			
		}
		
		public string AppWhy
		{
			get { return appwhy; }
			set 
			{
			  if (value != null && value.Length > 2000)
			    throw new ArgumentOutOfRangeException("AppWhy", "AppWhy value, cannot contain more than 2000 characters");
			  _bIsChanged |= (appwhy != value); 
			  appwhy = value; 
			}
			
		}
		
		public string AppProblem
		{
			get { return appproblem; }
			set 
			{
			  if (value != null && value.Length > 2000)
			    throw new ArgumentOutOfRangeException("AppProblem", "AppProblem value, cannot contain more than 2000 characters");
			  _bIsChanged |= (appproblem != value); 
			  appproblem = value; 
			}
			
		}
		
		public DateTime AppDate
		{
			get { return appdate; }
			set { _bIsChanged |= (appdate != value); appdate = value; }
			
		}
		
		public string AppFeedback
		{
			get { return appfeedback; }
			set 
			{
			  if (value != null && value.Length > 200)
			    throw new ArgumentOutOfRangeException("AppFeedback", "AppFeedback value, cannot contain more than 200 characters");
			  _bIsChanged |= (appfeedback != value); 
			  appfeedback = value; 
			}
			
		}
		
		public DateTime AppFdDate
		{
			get { return appfddate; }
			set { _bIsChanged |= (appfddate != value); appfddate = value; }
			
		}
		
		public int DoTeacherId
		{
			get { return doteacherid; }
			set { _bIsChanged |= (doteacherid != value); doteacherid = value; }
			
		}
		
		public string DoTrueName
		{
			get { return dotruename; }
			set 
			{
			  if (value != null && value.Length > 50)
			    throw new ArgumentOutOfRangeException("DoTrueName", "DoTrueName value, cannot contain more than 50 characters");
			  _bIsChanged |= (dotruename != value); 
			  dotruename = value; 
			}
			
		}
		
		public DateTime DoDate
		{
			get { return dodate; }
			set { _bIsChanged |= (dodate != value); dodate = value; }
			
		}
		
		public bool DoIscharge
		{
			get { return doischarge; }
			set { _bIsChanged |= (doischarge != value); doischarge = value; }
			
		}
		
		public string DoCharge
		{
			get { return docharge; }
			set 
			{
			  if (value != null && value.Length > 50)
			    throw new ArgumentOutOfRangeException("DoCharge", "DoCharge value, cannot contain more than 50 characters");
			  _bIsChanged |= (docharge != value); 
			  docharge = value; 
			}
			
		}
		
		public bool DoAmends
		{
			get { return doamends; }
			set { _bIsChanged |= (doamends != value); doamends = value; }
			
		}
		
		public string DoAmendsMy
		{
			get { return doamendsmy; }
			set 
			{
			  if (value != null && value.Length > 50)
			    throw new ArgumentOutOfRangeException("DoAmendsMy", "DoAmendsMy value, cannot contain more than 50 characters");
			  _bIsChanged |= (doamendsmy != value); 
			  doamendsmy = value; 
			}
			
		}
		
		public string DoFeedback
		{
			get { return dofeedback; }
			set 
			{
			  if (value != null && value.Length > 2000)
			    throw new ArgumentOutOfRangeException("DoFeedback", "DoFeedback value, cannot contain more than 2000 characters");
			  _bIsChanged |= (dofeedback != value); 
			  dofeedback = value; 
			}
			
		}
		
		public int State
		{
			get { return state; }
			set { _bIsChanged |= (state != value); state = value; }
			
		}
		
		public string MendTruename
		{
			get { return mendtruename; }
			set 
			{
			  if (value != null && value.Length > 50)
			    throw new ArgumentOutOfRangeException("MendTruename", "MendTruename value, cannot contain more than 50 characters");
			  _bIsChanged |= (mendtruename != value); 
			  mendtruename = value; 
			}
			
		}
		
		public DateTime MendDate
		{
			get { return menddate; }
			set { _bIsChanged |= (menddate != value); menddate = value; }
			
		}
		
		public string UserName
		{
			get { return username; }
			set 
			{
			  if (value != null && value.Length > 50)
			    throw new ArgumentOutOfRangeException("UserName", "UserName value, cannot contain more than 50 characters");
			  _bIsChanged |= (username != value); 
			  username = value; 
			}
			
		}
		
		public string Wq
		{
			get { return wq; }
			set 
			{
			  if (value != null && value.Length > 250)
			    throw new ArgumentOutOfRangeException("Wq", "Wq value, cannot contain more than 250 characters");
			  _bIsChanged |= (wq != value); 
			  wq = value; 
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
	
	#region Custom ICollection interface for AsstsAmends 

	
	public interface IAsstsAmendsCollection : ICollection
	{
		AsstsAmends this[int index]{	get; set; }
		void Add(AsstsAmends pAsstsAmends);
		void Clear();
	}
	
	[Serializable]
	public class AsstsAmendsCollection : IAsstsAmendsCollection
	{
		private IList<AsstsAmends> _arrayInternal;

		public AsstsAmendsCollection()
		{
			_arrayInternal = new List<AsstsAmends>();
		}
		
		public AsstsAmendsCollection( IList<AsstsAmends> pSource )
		{
			_arrayInternal = pSource;
			if(_arrayInternal == null)
			{
				_arrayInternal = new List<AsstsAmends>();
			}
		}

		public AsstsAmends this[int index]
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
		public void CopyTo(Array array, int index){ _arrayInternal.CopyTo((AsstsAmends[])array, index); }
		public IEnumerator GetEnumerator() { return _arrayInternal.GetEnumerator(); }
		public void Add(AsstsAmends pAsstsAmends) { _arrayInternal.Add(pAsstsAmends); }
		public void Clear() { _arrayInternal.Clear(); }
		public IList<AsstsAmends> GetList() { return _arrayInternal; }
	 }
	
	#endregion
}
