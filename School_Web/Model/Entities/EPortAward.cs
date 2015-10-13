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
	/// IEPortAward interface for NHibernate mapped table 'ePortAward'.
	/// </summary>
	public interface IEPortAward
	{
		#region Public Properties
		
		int Id
		{
			get ;
			set ;
			  
		}
		
		int ActiveId
		{
			get ;
			set ;
			  
		}
		
		int UserId
		{
			get ;
			set ;
			  
		}
		
		string Truename
		{
			get ;
			set ;
			  
		}
		
		string Title
		{
			get ;
			set ;
			  
		}
		
		int YearNum
		{
			get ;
			set ;
			  
		}
		
		int TermId
		{
			get ;
			set ;
			  
		}
		
		int GradeCaseId
		{
			get ;
			set ;
			  
		}
		
		int LevelCaseId
		{
			get ;
			set ;
			  
		}
		
		int Caseid
		{
			get ;
			set ;
			  
		}
		
		int ParentCaseid
		{
			get ;
			set ;
			  
		}
		
		string FilePath
		{
			get ;
			set ;
			  
		}
		
		DateTime Pubdate
		{
			get ;
			set ;
			  
		}
		
		int UserChecked
		{
			get ;
			set ;
			  
		}
		
		double Cent
		{
			get ;
			set ;
			  
		}
		
		double Credit
		{
			get ;
			set ;
			  
		}
		
		string Remark
		{
			get ;
			set ;
			  
		}
		
		decimal MoneyNum
		{
			get ;
			set ;
			  
		}
		
		bool AdminChecked
		{
			get ;
			set ;
			  
		}
		
		int SortIndex
		{
			get ;
			set ;
			  
		}
		
		int Pindex
		{
			get ;
			set ;
			  
		}
		
		int DepartmentId
		{
			get ;
			set ;
			  
		}
		
		int GradeId
		{
			get ;
			set ;
			  
		}
		
		int GroupId
		{
			get ;
			set ;
			  
		}
		
		int AreaId
		{
			get ;
			set ;
			  
		}
		
		bool ObjectFlag
		{
			get ;
			set ;
			  
		}
		
		bool IsDeleted { get; set; }
		bool IsChanged { get; set; }
		
		#endregion 
	}

	/// <summary>
	/// EPortAward object for NHibernate mapped table 'ePortAward'.
	/// </summary>
	[Serializable]
	public class EPortAward : IEPortAward
	{
		#region Member Variables

		protected int id;
		protected int activeid;
		protected int userid;
		protected string truename;
		protected string title;
		protected int yearnum;
		protected int termid;
		protected int gradecaseid;
		protected int levelcaseid;
		protected int caseid;
		protected int parentcaseid;
		protected string filepath;
		protected DateTime pubdate;
		protected int userchecked;
		protected double cent;
		protected double credit;
		protected string remark;
		protected decimal moneynum;
		protected bool adminchecked;
		protected int sortindex;
		protected int pindex;
		protected int departmentid;
		protected int gradeid;
		protected int groupid;
		protected int areaid;
		protected bool objectflag;
		protected bool _bIsDeleted;
		protected bool _bIsChanged;
		#endregion
		
		#region Constructors
		public EPortAward() {}
		
		public EPortAward(int pActiveId, int pUserId, string pTruename, string pTitle, int pYearNum, int pTermId, int pGradeCaseId, int pLevelCaseId, int pCaseid, int pParentCaseid, string pFilePath, DateTime pPubdate, int pUserChecked, double pCent, double pCredit, string pRemark, decimal pMoneyNum, bool pAdminChecked, int pSortIndex, int pPindex, int pDepartmentId, int pGradeId, int pGroupId, int pAreaId, bool pObjectFlag)
		{
			this.activeid = pActiveId; 
			this.userid = pUserId; 
			this.truename = pTruename; 
			this.title = pTitle; 
			this.yearnum = pYearNum; 
			this.termid = pTermId; 
			this.gradecaseid = pGradeCaseId; 
			this.levelcaseid = pLevelCaseId; 
			this.caseid = pCaseid; 
			this.parentcaseid = pParentCaseid; 
			this.filepath = pFilePath; 
			this.pubdate = pPubdate; 
			this.userchecked = pUserChecked; 
			this.cent = pCent; 
			this.credit = pCredit; 
			this.remark = pRemark; 
			this.moneynum = pMoneyNum; 
			this.adminchecked = pAdminChecked; 
			this.sortindex = pSortIndex; 
			this.pindex = pPindex; 
			this.departmentid = pDepartmentId; 
			this.gradeid = pGradeId; 
			this.groupid = pGroupId; 
			this.areaid = pAreaId; 
			this.objectflag = pObjectFlag; 
		}
		
		public EPortAward(int pId)
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
		
		public int ActiveId
		{
			get { return activeid; }
			set { _bIsChanged |= (activeid != value); activeid = value; }
			
		}
		
		public int UserId
		{
			get { return userid; }
			set { _bIsChanged |= (userid != value); userid = value; }
			
		}
		
		public string Truename
		{
			get { return truename; }
			set 
			{
			  if (value != null && value.Length > 50)
			    throw new ArgumentOutOfRangeException("Truename", "Truename value, cannot contain more than 50 characters");
			  _bIsChanged |= (truename != value); 
			  truename = value; 
			}
			
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
		
		public int YearNum
		{
			get { return yearnum; }
			set { _bIsChanged |= (yearnum != value); yearnum = value; }
			
		}
		
		public int TermId
		{
			get { return termid; }
			set { _bIsChanged |= (termid != value); termid = value; }
			
		}
		
		public int GradeCaseId
		{
			get { return gradecaseid; }
			set { _bIsChanged |= (gradecaseid != value); gradecaseid = value; }
			
		}
		
		public int LevelCaseId
		{
			get { return levelcaseid; }
			set { _bIsChanged |= (levelcaseid != value); levelcaseid = value; }
			
		}
		
		public int Caseid
		{
			get { return caseid; }
			set { _bIsChanged |= (caseid != value); caseid = value; }
			
		}
		
		public int ParentCaseid
		{
			get { return parentcaseid; }
			set { _bIsChanged |= (parentcaseid != value); parentcaseid = value; }
			
		}
		
		public string FilePath
		{
			get { return filepath; }
			set 
			{
			  if (value != null && value.Length > 250)
			    throw new ArgumentOutOfRangeException("FilePath", "FilePath value, cannot contain more than 250 characters");
			  _bIsChanged |= (filepath != value); 
			  filepath = value; 
			}
			
		}
		
		public DateTime Pubdate
		{
			get { return pubdate; }
			set { _bIsChanged |= (pubdate != value); pubdate = value; }
			
		}
		
		public int UserChecked
		{
			get { return userchecked; }
			set { _bIsChanged |= (userchecked != value); userchecked = value; }
			
		}
		
		public double Cent
		{
			get { return cent; }
			set { _bIsChanged |= (cent != value); cent = value; }
			
		}
		
		public double Credit
		{
			get { return credit; }
			set { _bIsChanged |= (credit != value); credit = value; }
			
		}
		
		public string Remark
		{
			get { return remark; }
			set 
			{
			  if (value != null && value.Length > 250)
			    throw new ArgumentOutOfRangeException("Remark", "Remark value, cannot contain more than 250 characters");
			  _bIsChanged |= (remark != value); 
			  remark = value; 
			}
			
		}
		
		public decimal MoneyNum
		{
			get { return moneynum; }
			set { _bIsChanged |= (moneynum != value); moneynum = value; }
			
		}
		
		public bool AdminChecked
		{
			get { return adminchecked; }
			set { _bIsChanged |= (adminchecked != value); adminchecked = value; }
			
		}
		
		public int SortIndex
		{
			get { return sortindex; }
			set { _bIsChanged |= (sortindex != value); sortindex = value; }
			
		}
		
		public int Pindex
		{
			get { return pindex; }
			set { _bIsChanged |= (pindex != value); pindex = value; }
			
		}
		
		public int DepartmentId
		{
			get { return departmentid; }
			set { _bIsChanged |= (departmentid != value); departmentid = value; }
			
		}
		
		public int GradeId
		{
			get { return gradeid; }
			set { _bIsChanged |= (gradeid != value); gradeid = value; }
			
		}
		
		public int GroupId
		{
			get { return groupid; }
			set { _bIsChanged |= (groupid != value); groupid = value; }
			
		}
		
		public int AreaId
		{
			get { return areaid; }
			set { _bIsChanged |= (areaid != value); areaid = value; }
			
		}
		
		public bool ObjectFlag
		{
			get { return objectflag; }
			set { _bIsChanged |= (objectflag != value); objectflag = value; }
			
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
	
	#region Custom ICollection interface for EPortAward 

	
	public interface IEPortAwardCollection : ICollection
	{
		EPortAward this[int index]{	get; set; }
		void Add(EPortAward pEPortAward);
		void Clear();
	}
	
	[Serializable]
	public class EPortAwardCollection : IEPortAwardCollection
	{
		private IList<EPortAward> _arrayInternal;

		public EPortAwardCollection()
		{
			_arrayInternal = new List<EPortAward>();
		}
		
		public EPortAwardCollection( IList<EPortAward> pSource )
		{
			_arrayInternal = pSource;
			if(_arrayInternal == null)
			{
				_arrayInternal = new List<EPortAward>();
			}
		}

		public EPortAward this[int index]
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
		public void CopyTo(Array array, int index){ _arrayInternal.CopyTo((EPortAward[])array, index); }
		public IEnumerator GetEnumerator() { return _arrayInternal.GetEnumerator(); }
		public void Add(EPortAward pEPortAward) { _arrayInternal.Add(pEPortAward); }
		public void Clear() { _arrayInternal.Clear(); }
		public IList<EPortAward> GetList() { return _arrayInternal; }
	 }
	
	#endregion
}
