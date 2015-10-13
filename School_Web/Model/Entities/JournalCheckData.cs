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
	/// IJournalCheckData interface for NHibernate mapped table 'Journal_check_data'.
	/// </summary>
	public interface IJournalCheckData
	{
		#region Public Properties
		
		int Id
		{
			get ;
			set ;
			  
		}
		
		int Roleid
		{
			get ;
			set ;
			  
		}
		
		int Articalid
		{
			get ;
			set ;
			  
		}
		
		int CheckStateIndex
		{
			get ;
			set ;
			  
		}
		
		int Userid
		{
			get ;
			set ;
			  
		}
		
		int Stateid
		{
			get ;
			set ;
			  
		}
		
		DateTime Pubdate
		{
			get ;
			set ;
			  
		}
		
		DateTime LimitDate
		{
			get ;
			set ;
			  
		}
		
		string Bz
		{
			get ;
			set ;
			  
		}
		
		string Filepath
		{
			get ;
			set ;
			  
		}
		
		bool IsDeleted { get; set; }
		bool IsChanged { get; set; }
		
		#endregion 
	}

	/// <summary>
	/// JournalCheckData object for NHibernate mapped table 'Journal_check_data'.
	/// </summary>
	[Serializable]
	public class JournalCheckData : IJournalCheckData
	{
		#region Member Variables

		protected int id;
		protected int roleid;
		protected int articalid;
		protected int checkstateindex;
		protected int userid;
		protected int stateid;
		protected DateTime pubdate;
		protected DateTime limitdate;
		protected string bz;
		protected string filepath;
		protected bool _bIsDeleted;
		protected bool _bIsChanged;
		#endregion
		
		#region Constructors
		public JournalCheckData() {}
		
		public JournalCheckData(int pRoleid, int pArticalid, int pCheckStateIndex, int pUserid, int pStateid, DateTime pPubdate, DateTime pLimitDate, string pBz, string pFilepath)
		{
			this.roleid = pRoleid; 
			this.articalid = pArticalid; 
			this.checkstateindex = pCheckStateIndex; 
			this.userid = pUserid; 
			this.stateid = pStateid; 
			this.pubdate = pPubdate; 
			this.limitdate = pLimitDate; 
			this.bz = pBz; 
			this.filepath = pFilepath; 
		}
		
		public JournalCheckData(int pId)
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
		
		public int Roleid
		{
			get { return roleid; }
			set { _bIsChanged |= (roleid != value); roleid = value; }
			
		}
		
		public int Articalid
		{
			get { return articalid; }
			set { _bIsChanged |= (articalid != value); articalid = value; }
			
		}
		
		public int CheckStateIndex
		{
			get { return checkstateindex; }
			set { _bIsChanged |= (checkstateindex != value); checkstateindex = value; }
			
		}
		
		public int Userid
		{
			get { return userid; }
			set { _bIsChanged |= (userid != value); userid = value; }
			
		}
		
		public int Stateid
		{
			get { return stateid; }
			set { _bIsChanged |= (stateid != value); stateid = value; }
			
		}
		
		public DateTime Pubdate
		{
			get { return pubdate; }
			set { _bIsChanged |= (pubdate != value); pubdate = value; }
			
		}
		
		public DateTime LimitDate
		{
			get { return limitdate; }
			set { _bIsChanged |= (limitdate != value); limitdate = value; }
			
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
		
		public string Filepath
		{
			get { return filepath; }
			set 
			{
			  if (value != null && value.Length > 250)
			    throw new ArgumentOutOfRangeException("Filepath", "Filepath value, cannot contain more than 250 characters");
			  _bIsChanged |= (filepath != value); 
			  filepath = value; 
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
	
	#region Custom ICollection interface for JournalCheckData 

	
	public interface IJournalCheckDataCollection : ICollection
	{
		JournalCheckData this[int index]{	get; set; }
		void Add(JournalCheckData pJournalCheckData);
		void Clear();
	}
	
	[Serializable]
	public class JournalCheckDataCollection : IJournalCheckDataCollection
	{
		private IList<JournalCheckData> _arrayInternal;

		public JournalCheckDataCollection()
		{
			_arrayInternal = new List<JournalCheckData>();
		}
		
		public JournalCheckDataCollection( IList<JournalCheckData> pSource )
		{
			_arrayInternal = pSource;
			if(_arrayInternal == null)
			{
				_arrayInternal = new List<JournalCheckData>();
			}
		}

		public JournalCheckData this[int index]
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
		public void CopyTo(Array array, int index){ _arrayInternal.CopyTo((JournalCheckData[])array, index); }
		public IEnumerator GetEnumerator() { return _arrayInternal.GetEnumerator(); }
		public void Add(JournalCheckData pJournalCheckData) { _arrayInternal.Add(pJournalCheckData); }
		public void Clear() { _arrayInternal.Clear(); }
		public IList<JournalCheckData> GetList() { return _arrayInternal; }
	 }
	
	#endregion
}
