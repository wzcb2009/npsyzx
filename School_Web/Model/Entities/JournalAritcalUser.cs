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
	/// IJournalAritcalUser interface for NHibernate mapped table 'Journal_Aritcal_User'.
	/// </summary>
	public interface IJournalAritcalUser
	{
		#region Public Properties
		
		int Id
		{
			get ;
			set ;
			  
		}
		
		int Userid
		{
			get ;
			set ;
			  
		}
		
		int ArticalId
		{
			get ;
			set ;
			  
		}
		
		int MagUserid
		{
			get ;
			set ;
			  
		}
		
		int State
		{
			get ;
			set ;
			  
		}
		
		DateTime LimitDate
		{
			get ;
			set ;
			  
		}
		
		int Typeid
		{
			get ;
			set ;
			  
		}
		
		bool IsDeleted { get; set; }
		bool IsChanged { get; set; }
		
		#endregion 
	}

	/// <summary>
	/// JournalAritcalUser object for NHibernate mapped table 'Journal_Aritcal_User'.
	/// </summary>
	[Serializable]
	public class JournalAritcalUser : IJournalAritcalUser
	{
		#region Member Variables

		protected int id;
		protected int userid;
		protected int articalid;
		protected int maguserid;
		protected int state;
		protected DateTime limitdate;
		protected int typeid;
		protected bool _bIsDeleted;
		protected bool _bIsChanged;
		#endregion
		
		#region Constructors
		public JournalAritcalUser() {}
		
		public JournalAritcalUser(int pUserid, int pArticalId, int pMagUserid, int pState, DateTime pLimitDate, int pTypeid)
		{
			this.userid = pUserid; 
			this.articalid = pArticalId; 
			this.maguserid = pMagUserid; 
			this.state = pState; 
			this.limitdate = pLimitDate; 
			this.typeid = pTypeid; 
		}
		
		public JournalAritcalUser(int pId)
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
		
		public int Userid
		{
			get { return userid; }
			set { _bIsChanged |= (userid != value); userid = value; }
			
		}
		
		public int ArticalId
		{
			get { return articalid; }
			set { _bIsChanged |= (articalid != value); articalid = value; }
			
		}
		
		public int MagUserid
		{
			get { return maguserid; }
			set { _bIsChanged |= (maguserid != value); maguserid = value; }
			
		}
		
		public int State
		{
			get { return state; }
			set { _bIsChanged |= (state != value); state = value; }
			
		}
		
		public DateTime LimitDate
		{
			get { return limitdate; }
			set { _bIsChanged |= (limitdate != value); limitdate = value; }
			
		}
		
		public int Typeid
		{
			get { return typeid; }
			set { _bIsChanged |= (typeid != value); typeid = value; }
			
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
	
	#region Custom ICollection interface for JournalAritcalUser 

	
	public interface IJournalAritcalUserCollection : ICollection
	{
		JournalAritcalUser this[int index]{	get; set; }
		void Add(JournalAritcalUser pJournalAritcalUser);
		void Clear();
	}
	
	[Serializable]
	public class JournalAritcalUserCollection : IJournalAritcalUserCollection
	{
		private IList<JournalAritcalUser> _arrayInternal;

		public JournalAritcalUserCollection()
		{
			_arrayInternal = new List<JournalAritcalUser>();
		}
		
		public JournalAritcalUserCollection( IList<JournalAritcalUser> pSource )
		{
			_arrayInternal = pSource;
			if(_arrayInternal == null)
			{
				_arrayInternal = new List<JournalAritcalUser>();
			}
		}

		public JournalAritcalUser this[int index]
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
		public void CopyTo(Array array, int index){ _arrayInternal.CopyTo((JournalAritcalUser[])array, index); }
		public IEnumerator GetEnumerator() { return _arrayInternal.GetEnumerator(); }
		public void Add(JournalAritcalUser pJournalAritcalUser) { _arrayInternal.Add(pJournalAritcalUser); }
		public void Clear() { _arrayInternal.Clear(); }
		public IList<JournalAritcalUser> GetList() { return _arrayInternal; }
	 }
	
	#endregion
}
