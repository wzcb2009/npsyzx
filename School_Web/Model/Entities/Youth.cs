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
	/// IYouth interface for NHibernate mapped table 'Youth'.
	/// </summary>
	public interface IYouth
	{
		#region Public Properties
		
		int Id
		{
			get ;
			set ;
			  
		}
		
		int Termid
		{
			get ;
			set ;
			  
		}
		
		DateTime JoinDate
		{
			get ;
			set ;
			  
		}
		
		string TwTeacher
		{
			get ;
			set ;
			  
		}
		
		int UnitId
		{
			get ;
			set ;
			  
		}
		
		string MagUsername
		{
			get ;
			set ;
			  
		}
		
		decimal TfCount
		{
			get ;
			set ;
			  
		}
		
		DateTime Pubdate
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
	/// Youth object for NHibernate mapped table 'Youth'.
	/// </summary>
	[Serializable]
	public class Youth : IYouth
	{
		#region Member Variables

		protected int id;
		protected int termid;
		protected DateTime joindate;
		protected string twteacher;
		protected int unitid;
		protected string magusername;
		protected decimal tfcount;
		protected DateTime pubdate;
		protected string content;
		protected bool _bIsDeleted;
		protected bool _bIsChanged;
		#endregion
		
		#region Constructors
		public Youth() {}
		
		public Youth(int pTermid, DateTime pJoinDate, string pTwTeacher, int pUnitId, string pMagUsername, decimal pTfCount, DateTime pPubdate, string pContent)
		{
			this.termid = pTermid; 
			this.joindate = pJoinDate; 
			this.twteacher = pTwTeacher; 
			this.unitid = pUnitId; 
			this.magusername = pMagUsername; 
			this.tfcount = pTfCount; 
			this.pubdate = pPubdate; 
			this.content = pContent; 
		}
		
		public Youth(int pId)
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
		
		public int Termid
		{
			get { return termid; }
			set { _bIsChanged |= (termid != value); termid = value; }
			
		}
		
		public DateTime JoinDate
		{
			get { return joindate; }
			set { _bIsChanged |= (joindate != value); joindate = value; }
			
		}
		
		public string TwTeacher
		{
			get { return twteacher; }
			set 
			{
			  if (value != null && value.Length > 50)
			    throw new ArgumentOutOfRangeException("TwTeacher", "TwTeacher value, cannot contain more than 50 characters");
			  _bIsChanged |= (twteacher != value); 
			  twteacher = value; 
			}
			
		}
		
		public int UnitId
		{
			get { return unitid; }
			set { _bIsChanged |= (unitid != value); unitid = value; }
			
		}
		
		public string MagUsername
		{
			get { return magusername; }
			set 
			{
			  if (value != null && value.Length > 50)
			    throw new ArgumentOutOfRangeException("MagUsername", "MagUsername value, cannot contain more than 50 characters");
			  _bIsChanged |= (magusername != value); 
			  magusername = value; 
			}
			
		}
		
		public decimal TfCount
		{
			get { return tfcount; }
			set { _bIsChanged |= (tfcount != value); tfcount = value; }
			
		}
		
		public DateTime Pubdate
		{
			get { return pubdate; }
			set { _bIsChanged |= (pubdate != value); pubdate = value; }
			
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
	
	#region Custom ICollection interface for Youth 

	
	public interface IYouthCollection : ICollection
	{
		Youth this[int index]{	get; set; }
		void Add(Youth pYouth);
		void Clear();
	}
	
	[Serializable]
	public class YouthCollection : IYouthCollection
	{
		private IList<Youth> _arrayInternal;

		public YouthCollection()
		{
			_arrayInternal = new List<Youth>();
		}
		
		public YouthCollection( IList<Youth> pSource )
		{
			_arrayInternal = pSource;
			if(_arrayInternal == null)
			{
				_arrayInternal = new List<Youth>();
			}
		}

		public Youth this[int index]
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
		public void CopyTo(Array array, int index){ _arrayInternal.CopyTo((Youth[])array, index); }
		public IEnumerator GetEnumerator() { return _arrayInternal.GetEnumerator(); }
		public void Add(Youth pYouth) { _arrayInternal.Add(pYouth); }
		public void Clear() { _arrayInternal.Clear(); }
		public IList<Youth> GetList() { return _arrayInternal; }
	 }
	
	#endregion
}
