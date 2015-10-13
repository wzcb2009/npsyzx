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
	/// IActivityCheckData interface for NHibernate mapped table 'Activity_Check_Data'.
	/// </summary>
	public interface IActivityCheckData
	{
		#region Public Properties
		
		int Id
		{
			get ;
			set ;
			  
		}
		
		int ActId
		{
			get ;
			set ;
			  
		}
		
		int CheckUserid
		{
			get ;
			set ;
			  
		}
		
		string Bz
		{
			get ;
			set ;
			  
		}
		
		int CheckResult
		{
			get ;
			set ;
			  
		}
		
		DateTime Pubdate
		{
			get ;
			set ;
			  
		}
		
		bool IsDeleted { get; set; }
		bool IsChanged { get; set; }
		
		#endregion 
	}

	/// <summary>
	/// ActivityCheckData object for NHibernate mapped table 'Activity_Check_Data'.
	/// </summary>
	[Serializable]
	public class ActivityCheckData : IActivityCheckData
	{
		#region Member Variables

		protected int id;
		protected int actid;
		protected int checkuserid;
		protected string bz;
		protected int checkresult;
		protected DateTime pubdate;
		protected bool _bIsDeleted;
		protected bool _bIsChanged;
		#endregion
		
		#region Constructors
		public ActivityCheckData() {}
		
		public ActivityCheckData(int pId, int pActId, int pCheckUserid, string pBz, int pCheckResult, DateTime pPubdate)
		{
			this.id = pId; 
			this.actid = pActId; 
			this.checkuserid = pCheckUserid; 
			this.bz = pBz; 
			this.checkresult = pCheckResult; 
			this.pubdate = pPubdate; 
		}
		
		public ActivityCheckData(int pId)
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
		
		public int ActId
		{
			get { return actid; }
			set { _bIsChanged |= (actid != value); actid = value; }
			
		}
		
		public int CheckUserid
		{
			get { return checkuserid; }
			set { _bIsChanged |= (checkuserid != value); checkuserid = value; }
			
		}
		
		public string Bz
		{
			get { return bz; }
			set 
			{
			  if (value != null && value.Length > 50)
			    throw new ArgumentOutOfRangeException("Bz", "Bz value, cannot contain more than 50 characters");
			  _bIsChanged |= (bz != value); 
			  bz = value; 
			}
			
		}
		
		public int CheckResult
		{
			get { return checkresult; }
			set { _bIsChanged |= (checkresult != value); checkresult = value; }
			
		}
		
		public DateTime Pubdate
		{
			get { return pubdate; }
			set { _bIsChanged |= (pubdate != value); pubdate = value; }
			
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
	
	#region Custom ICollection interface for ActivityCheckData 

	
	public interface IActivityCheckDataCollection : ICollection
	{
		ActivityCheckData this[int index]{	get; set; }
		void Add(ActivityCheckData pActivityCheckData);
		void Clear();
	}
	
	[Serializable]
	public class ActivityCheckDataCollection : IActivityCheckDataCollection
	{
		private IList<ActivityCheckData> _arrayInternal;

		public ActivityCheckDataCollection()
		{
			_arrayInternal = new List<ActivityCheckData>();
		}
		
		public ActivityCheckDataCollection( IList<ActivityCheckData> pSource )
		{
			_arrayInternal = pSource;
			if(_arrayInternal == null)
			{
				_arrayInternal = new List<ActivityCheckData>();
			}
		}

		public ActivityCheckData this[int index]
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
		public void CopyTo(Array array, int index){ _arrayInternal.CopyTo((ActivityCheckData[])array, index); }
		public IEnumerator GetEnumerator() { return _arrayInternal.GetEnumerator(); }
		public void Add(ActivityCheckData pActivityCheckData) { _arrayInternal.Add(pActivityCheckData); }
		public void Clear() { _arrayInternal.Clear(); }
		public IList<ActivityCheckData> GetList() { return _arrayInternal; }
	 }
	
	#endregion
}
