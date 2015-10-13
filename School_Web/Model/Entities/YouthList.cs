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
	/// IYouthList interface for NHibernate mapped table 'Youth_list'.
	/// </summary>
	public interface IYouthList
	{
		#region Public Properties
		
		int YouthStId
		{
			get ;
			set ;
			  
		}
		
		int StudentId
		{
			get ;
			set ;
			  
		}
		
		string Truename
		{
			get ;
			set ;
			  
		}
		
		bool Sex
		{
			get ;
			set ;
			  
		}
		
		string People
		{
			get ;
			set ;
			  
		}
		
		string Address
		{
			get ;
			set ;
			  
		}
		
		DateTime Birthday
		{
			get ;
			set ;
			  
		}
		
		int YouthId
		{
			get ;
			set ;
			  
		}
		
		string YouthSortnum
		{
			get ;
			set ;
			  
		}
		
		string SignDate
		{
			get ;
			set ;
			  
		}
		
		bool CheckState
		{
			get ;
			set ;
			  
		}
		
		string MagUsername
		{
			get ;
			set ;
			  
		}
		
		DateTime Pubdate
		{
			get ;
			set ;
			  
		}
		
		int YouthTypeId
		{
			get ;
			set ;
			  
		}
		
		string StuImagesrc
		{
			get ;
			set ;
			  
		}
		
		bool IsDeleted { get; set; }
		bool IsChanged { get; set; }
		
		#endregion 
	}

	/// <summary>
	/// YouthList object for NHibernate mapped table 'Youth_list'.
	/// </summary>
	[Serializable]
	public class YouthList : IYouthList
	{
		#region Member Variables

		protected int youthstid;
		protected int studentid;
		protected string truename;
		protected bool sex;
		protected string people;
		protected string address;
		protected DateTime birthday;
		protected int youthid;
		protected string youthsortnum;
		protected string signdate;
		protected bool checkstate;
		protected string magusername;
		protected DateTime pubdate;
		protected int youthtypeid;
		protected string stuimagesrc;
		protected bool _bIsDeleted;
		protected bool _bIsChanged;
		#endregion
		
		#region Constructors
		public YouthList() {}
		
		public YouthList(int pStudentId, string pTruename, bool pSex, string pPeople, string pAddress, DateTime pBirthday, int pYouthId, string pYouthSortnum, string pSignDate, bool pCheckState, string pMagUsername, DateTime pPubdate, int pYouthTypeId, string pStuImagesrc)
		{
			this.studentid = pStudentId; 
			this.truename = pTruename; 
			this.sex = pSex; 
			this.people = pPeople; 
			this.address = pAddress; 
			this.birthday = pBirthday; 
			this.youthid = pYouthId; 
			this.youthsortnum = pYouthSortnum; 
			this.signdate = pSignDate; 
			this.checkstate = pCheckState; 
			this.magusername = pMagUsername; 
			this.pubdate = pPubdate; 
			this.youthtypeid = pYouthTypeId; 
			this.stuimagesrc = pStuImagesrc; 
		}
		
		public YouthList(int pYouthStId)
		{
			this.youthstid = pYouthStId; 
		}
		
		#endregion
		
		#region Public Properties
		
		public int YouthStId
		{
			get { return youthstid; }
			set { _bIsChanged |= (youthstid != value); youthstid = value; }
			
		}
		
		public int StudentId
		{
			get { return studentid; }
			set { _bIsChanged |= (studentid != value); studentid = value; }
			
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
		
		public bool Sex
		{
			get { return sex; }
			set { _bIsChanged |= (sex != value); sex = value; }
			
		}
		
		public string People
		{
			get { return people; }
			set 
			{
			  if (value != null && value.Length > 50)
			    throw new ArgumentOutOfRangeException("People", "People value, cannot contain more than 50 characters");
			  _bIsChanged |= (people != value); 
			  people = value; 
			}
			
		}
		
		public string Address
		{
			get { return address; }
			set 
			{
			  if (value != null && value.Length > 255)
			    throw new ArgumentOutOfRangeException("Address", "Address value, cannot contain more than 255 characters");
			  _bIsChanged |= (address != value); 
			  address = value; 
			}
			
		}
		
		public DateTime Birthday
		{
			get { return birthday; }
			set { _bIsChanged |= (birthday != value); birthday = value; }
			
		}
		
		public int YouthId
		{
			get { return youthid; }
			set { _bIsChanged |= (youthid != value); youthid = value; }
			
		}
		
		public string YouthSortnum
		{
			get { return youthsortnum; }
			set 
			{
			  if (value != null && value.Length > 50)
			    throw new ArgumentOutOfRangeException("YouthSortnum", "YouthSortnum value, cannot contain more than 50 characters");
			  _bIsChanged |= (youthsortnum != value); 
			  youthsortnum = value; 
			}
			
		}
		
		public string SignDate
		{
			get { return signdate; }
			set 
			{
			  if (value != null && value.Length > 10)
			    throw new ArgumentOutOfRangeException("SignDate", "SignDate value, cannot contain more than 10 characters");
			  _bIsChanged |= (signdate != value); 
			  signdate = value; 
			}
			
		}
		
		public bool CheckState
		{
			get { return checkstate; }
			set { _bIsChanged |= (checkstate != value); checkstate = value; }
			
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
		
		public DateTime Pubdate
		{
			get { return pubdate; }
			set { _bIsChanged |= (pubdate != value); pubdate = value; }
			
		}
		
		public int YouthTypeId
		{
			get { return youthtypeid; }
			set { _bIsChanged |= (youthtypeid != value); youthtypeid = value; }
			
		}
		
		public string StuImagesrc
		{
			get { return stuimagesrc; }
			set 
			{
			  if (value != null && value.Length > 200)
			    throw new ArgumentOutOfRangeException("StuImagesrc", "StuImagesrc value, cannot contain more than 200 characters");
			  _bIsChanged |= (stuimagesrc != value); 
			  stuimagesrc = value; 
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
	
	#region Custom ICollection interface for YouthList 

	
	public interface IYouthListCollection : ICollection
	{
		YouthList this[int index]{	get; set; }
		void Add(YouthList pYouthList);
		void Clear();
	}
	
	[Serializable]
	public class YouthListCollection : IYouthListCollection
	{
		private IList<YouthList> _arrayInternal;

		public YouthListCollection()
		{
			_arrayInternal = new List<YouthList>();
		}
		
		public YouthListCollection( IList<YouthList> pSource )
		{
			_arrayInternal = pSource;
			if(_arrayInternal == null)
			{
				_arrayInternal = new List<YouthList>();
			}
		}

		public YouthList this[int index]
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
		public void CopyTo(Array array, int index){ _arrayInternal.CopyTo((YouthList[])array, index); }
		public IEnumerator GetEnumerator() { return _arrayInternal.GetEnumerator(); }
		public void Add(YouthList pYouthList) { _arrayInternal.Add(pYouthList); }
		public void Clear() { _arrayInternal.Clear(); }
		public IList<YouthList> GetList() { return _arrayInternal; }
	 }
	
	#endregion
}
