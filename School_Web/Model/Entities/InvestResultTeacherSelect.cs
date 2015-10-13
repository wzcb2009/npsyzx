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
	/// IInvestResultTeacherSelect interface for NHibernate mapped table 'Invest_Result_TeacherSelect'.
	/// </summary>
	public interface IInvestResultTeacherSelect
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
		
		int Subjectid
		{
			get ;
			set ;
			  
		}
		
		int ObjUserId
		{
			get ;
			set ;
			  
		}
		
		int Pindex
		{
			get ;
			set ;
			  
		}
		
		DateTime Pubdate
		{
			get ;
			set ;
			  
		}
		
		string Ip
		{
			get ;
			set ;
			  
		}
		
		int Cent
		{
			get ;
			set ;
			  
		}
		
		bool IsDeleted { get; set; }
		bool IsChanged { get; set; }
		
		#endregion 
	}

	/// <summary>
	/// InvestResultTeacherSelect object for NHibernate mapped table 'Invest_Result_TeacherSelect'.
	/// </summary>
	[Serializable]
	public class InvestResultTeacherSelect : IInvestResultTeacherSelect
	{
		#region Member Variables

		protected int id;
		protected int userid;
		protected int subjectid;
		protected int objuserid;
		protected int pindex;
		protected DateTime pubdate;
		protected string ip;
		protected int cent;
		protected bool _bIsDeleted;
		protected bool _bIsChanged;
		#endregion
		
		#region Constructors
		public InvestResultTeacherSelect() {}
		
		public InvestResultTeacherSelect(int pId, int pUserid, int pSubjectid, int pObjUserId, int pPindex, DateTime pPubdate, string pIp, int pCent)
		{
			this.id = pId; 
			this.userid = pUserid; 
			this.subjectid = pSubjectid; 
			this.objuserid = pObjUserId; 
			this.pindex = pPindex; 
			this.pubdate = pPubdate; 
			this.ip = pIp; 
			this.cent = pCent; 
		}
		
		public InvestResultTeacherSelect(int pId)
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
		
		public int Subjectid
		{
			get { return subjectid; }
			set { _bIsChanged |= (subjectid != value); subjectid = value; }
			
		}
		
		public int ObjUserId
		{
			get { return objuserid; }
			set { _bIsChanged |= (objuserid != value); objuserid = value; }
			
		}
		
		public int Pindex
		{
			get { return pindex; }
			set { _bIsChanged |= (pindex != value); pindex = value; }
			
		}
		
		public DateTime Pubdate
		{
			get { return pubdate; }
			set { _bIsChanged |= (pubdate != value); pubdate = value; }
			
		}
		
		public string Ip
		{
			get { return ip; }
			set 
			{
			  if (value != null && value.Length > 50)
			    throw new ArgumentOutOfRangeException("Ip", "Ip value, cannot contain more than 50 characters");
			  _bIsChanged |= (ip != value); 
			  ip = value; 
			}
			
		}
		
		public int Cent
		{
			get { return cent; }
			set { _bIsChanged |= (cent != value); cent = value; }
			
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
	
	#region Custom ICollection interface for InvestResultTeacherSelect 

	
	public interface IInvestResultTeacherSelectCollection : ICollection
	{
		InvestResultTeacherSelect this[int index]{	get; set; }
		void Add(InvestResultTeacherSelect pInvestResultTeacherSelect);
		void Clear();
	}
	
	[Serializable]
	public class InvestResultTeacherSelectCollection : IInvestResultTeacherSelectCollection
	{
		private IList<InvestResultTeacherSelect> _arrayInternal;

		public InvestResultTeacherSelectCollection()
		{
			_arrayInternal = new List<InvestResultTeacherSelect>();
		}
		
		public InvestResultTeacherSelectCollection( IList<InvestResultTeacherSelect> pSource )
		{
			_arrayInternal = pSource;
			if(_arrayInternal == null)
			{
				_arrayInternal = new List<InvestResultTeacherSelect>();
			}
		}

		public InvestResultTeacherSelect this[int index]
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
		public void CopyTo(Array array, int index){ _arrayInternal.CopyTo((InvestResultTeacherSelect[])array, index); }
		public IEnumerator GetEnumerator() { return _arrayInternal.GetEnumerator(); }
		public void Add(InvestResultTeacherSelect pInvestResultTeacherSelect) { _arrayInternal.Add(pInvestResultTeacherSelect); }
		public void Clear() { _arrayInternal.Clear(); }
		public IList<InvestResultTeacherSelect> GetList() { return _arrayInternal; }
	 }
	
	#endregion
}
