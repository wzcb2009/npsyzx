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
	/// IUserBaseInfo interface for NHibernate mapped table 'UserBaseInfo'.
	/// </summary>
	public interface IUserBaseInfo
	{
		#region Public Properties
		
		int BaseInfoId
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
		
		string Truename2
		{
			get ;
			set ;
			  
		}
		
		string PicUrl
		{
			get ;
			set ;
			  
		}
		
		string Sex
		{
			get ;
			set ;
			  
		}
		
		DateTime BirthDay
		{
			get ;
			set ;
			  
		}
		
		string Cardid
		{
			get ;
			set ;
			  
		}
		
		string Party
		{
			get ;
			set ;
			  
		}
		
		string Profession
		{
			get ;
			set ;
			  
		}
		
		string HomeTown
		{
			get ;
			set ;
			  
		}
		
		string BirthPlace
		{
			get ;
			set ;
			  
		}
		
		string Religion
		{
			get ;
			set ;
			  
		}
		
		string Nation
		{
			get ;
			set ;
			  
		}
		
		string Marriage
		{
			get ;
			set ;
			  
		}
		
		string Address
		{
			get ;
			set ;
			  
		}
		
		string Tel
		{
			get ;
			set ;
			  
		}
		
		string Healthy
		{
			get ;
			set ;
			  
		}
		
		string Educational
		{
			get ;
			set ;
			  
		}
		
		string Specialty
		{
			get ;
			set ;
			  
		}
		
		string GraduateSchool
		{
			get ;
			set ;
			  
		}
		
		DateTime Pubdate
		{
			get ;
			set ;
			  
		}
		
		int MagUserId
		{
			get ;
			set ;
			  
		}
		
		bool State
		{
			get ;
			set ;
			  
		}
		
		DateTime CheckedDate
		{
			get ;
			set ;
			  
		}
		
		string JoinDate
		{
			get ;
			set ;
			  
		}
		
		string OutDate
		{
			get ;
			set ;
			  
		}
		
		bool IsDeleted { get; set; }
		bool IsChanged { get; set; }
		
		#endregion 
	}

	/// <summary>
	/// UserBaseInfo object for NHibernate mapped table 'UserBaseInfo'.
	/// </summary>
	[Serializable]
	public class UserBaseInfo : IUserBaseInfo
	{
		#region Member Variables

		protected int baseinfoid;
		protected int userid;
		protected string truename;
		protected string truename2;
		protected string picurl;
		protected string sex;
		protected DateTime birthday;
		protected string cardid;
		protected string party;
		protected string profession;
		protected string hometown;
		protected string birthplace;
		protected string religion;
		protected string nation;
		protected string marriage;
		protected string address;
		protected string tel;
		protected string healthy;
		protected string educational;
		protected string specialty;
		protected string graduateschool;
		protected DateTime pubdate;
		protected int maguserid;
		protected bool state;
		protected DateTime checkeddate;
		protected string joindate;
		protected string outdate;
		protected bool _bIsDeleted;
		protected bool _bIsChanged;
		#endregion
		
		#region Constructors
		public UserBaseInfo() {}
		
		public UserBaseInfo(int pUserId, string pTruename, string pTruename2, string pPicUrl, string pSex, DateTime pBirthDay, string pCardid, string pParty, string pProfession, string pHomeTown, string pBirthPlace, string pReligion, string pNation, string pMarriage, string pAddress, string pTel, string pHealthy, string pEducational, string pSpecialty, string pGraduateSchool, DateTime pPubdate, int pMagUserId, bool pState, DateTime pCheckedDate, string pJoinDate, string pOutDate)
		{
			this.userid = pUserId; 
			this.truename = pTruename; 
			this.truename2 = pTruename2; 
			this.picurl = pPicUrl; 
			this.sex = pSex; 
			this.birthday = pBirthDay; 
			this.cardid = pCardid; 
			this.party = pParty; 
			this.profession = pProfession; 
			this.hometown = pHomeTown; 
			this.birthplace = pBirthPlace; 
			this.religion = pReligion; 
			this.nation = pNation; 
			this.marriage = pMarriage; 
			this.address = pAddress; 
			this.tel = pTel; 
			this.healthy = pHealthy; 
			this.educational = pEducational; 
			this.specialty = pSpecialty; 
			this.graduateschool = pGraduateSchool; 
			this.pubdate = pPubdate; 
			this.maguserid = pMagUserId; 
			this.state = pState; 
			this.checkeddate = pCheckedDate; 
			this.joindate = pJoinDate; 
			this.outdate = pOutDate; 
		}
		
		public UserBaseInfo(int pBaseInfoId)
		{
			this.baseinfoid = pBaseInfoId; 
		}
		
		#endregion
		
		#region Public Properties
		
		public int BaseInfoId
		{
			get { return baseinfoid; }
			set { _bIsChanged |= (baseinfoid != value); baseinfoid = value; }
			
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
		
		public string Truename2
		{
			get { return truename2; }
			set 
			{
			  if (value != null && value.Length > 50)
			    throw new ArgumentOutOfRangeException("Truename2", "Truename2 value, cannot contain more than 50 characters");
			  _bIsChanged |= (truename2 != value); 
			  truename2 = value; 
			}
			
		}
		
		public string PicUrl
		{
			get { return picurl; }
			set 
			{
			  if (value != null && value.Length > 50)
			    throw new ArgumentOutOfRangeException("PicUrl", "PicUrl value, cannot contain more than 50 characters");
			  _bIsChanged |= (picurl != value); 
			  picurl = value; 
			}
			
		}
		
		public string Sex
		{
			get { return sex; }
			set 
			{
			  if (value != null && value.Length > 50)
			    throw new ArgumentOutOfRangeException("Sex", "Sex value, cannot contain more than 50 characters");
			  _bIsChanged |= (sex != value); 
			  sex = value; 
			}
			
		}
		
		public DateTime BirthDay
		{
			get { return birthday; }
			set { _bIsChanged |= (birthday != value); birthday = value; }
			
		}
		
		public string Cardid
		{
			get { return cardid; }
			set 
			{
			  if (value != null && value.Length > 50)
			    throw new ArgumentOutOfRangeException("Cardid", "Cardid value, cannot contain more than 50 characters");
			  _bIsChanged |= (cardid != value); 
			  cardid = value; 
			}
			
		}
		
		public string Party
		{
			get { return party; }
			set 
			{
			  if (value != null && value.Length > 50)
			    throw new ArgumentOutOfRangeException("Party", "Party value, cannot contain more than 50 characters");
			  _bIsChanged |= (party != value); 
			  party = value; 
			}
			
		}
		
		public string Profession
		{
			get { return profession; }
			set 
			{
			  if (value != null && value.Length > 50)
			    throw new ArgumentOutOfRangeException("Profession", "Profession value, cannot contain more than 50 characters");
			  _bIsChanged |= (profession != value); 
			  profession = value; 
			}
			
		}
		
		public string HomeTown
		{
			get { return hometown; }
			set 
			{
			  if (value != null && value.Length > 50)
			    throw new ArgumentOutOfRangeException("HomeTown", "HomeTown value, cannot contain more than 50 characters");
			  _bIsChanged |= (hometown != value); 
			  hometown = value; 
			}
			
		}
		
		public string BirthPlace
		{
			get { return birthplace; }
			set 
			{
			  if (value != null && value.Length > 50)
			    throw new ArgumentOutOfRangeException("BirthPlace", "BirthPlace value, cannot contain more than 50 characters");
			  _bIsChanged |= (birthplace != value); 
			  birthplace = value; 
			}
			
		}
		
		public string Religion
		{
			get { return religion; }
			set 
			{
			  if (value != null && value.Length > 50)
			    throw new ArgumentOutOfRangeException("Religion", "Religion value, cannot contain more than 50 characters");
			  _bIsChanged |= (religion != value); 
			  religion = value; 
			}
			
		}
		
		public string Nation
		{
			get { return nation; }
			set 
			{
			  if (value != null && value.Length > 50)
			    throw new ArgumentOutOfRangeException("Nation", "Nation value, cannot contain more than 50 characters");
			  _bIsChanged |= (nation != value); 
			  nation = value; 
			}
			
		}
		
		public string Marriage
		{
			get { return marriage; }
			set 
			{
			  if (value != null && value.Length > 50)
			    throw new ArgumentOutOfRangeException("Marriage", "Marriage value, cannot contain more than 50 characters");
			  _bIsChanged |= (marriage != value); 
			  marriage = value; 
			}
			
		}
		
		public string Address
		{
			get { return address; }
			set 
			{
			  if (value != null && value.Length > 50)
			    throw new ArgumentOutOfRangeException("Address", "Address value, cannot contain more than 50 characters");
			  _bIsChanged |= (address != value); 
			  address = value; 
			}
			
		}
		
		public string Tel
		{
			get { return tel; }
			set 
			{
			  if (value != null && value.Length > 50)
			    throw new ArgumentOutOfRangeException("Tel", "Tel value, cannot contain more than 50 characters");
			  _bIsChanged |= (tel != value); 
			  tel = value; 
			}
			
		}
		
		public string Healthy
		{
			get { return healthy; }
			set 
			{
			  if (value != null && value.Length > 50)
			    throw new ArgumentOutOfRangeException("Healthy", "Healthy value, cannot contain more than 50 characters");
			  _bIsChanged |= (healthy != value); 
			  healthy = value; 
			}
			
		}
		
		public string Educational
		{
			get { return educational; }
			set 
			{
			  if (value != null && value.Length > 50)
			    throw new ArgumentOutOfRangeException("Educational", "Educational value, cannot contain more than 50 characters");
			  _bIsChanged |= (educational != value); 
			  educational = value; 
			}
			
		}
		
		public string Specialty
		{
			get { return specialty; }
			set 
			{
			  if (value != null && value.Length > 50)
			    throw new ArgumentOutOfRangeException("Specialty", "Specialty value, cannot contain more than 50 characters");
			  _bIsChanged |= (specialty != value); 
			  specialty = value; 
			}
			
		}
		
		public string GraduateSchool
		{
			get { return graduateschool; }
			set 
			{
			  if (value != null && value.Length > 50)
			    throw new ArgumentOutOfRangeException("GraduateSchool", "GraduateSchool value, cannot contain more than 50 characters");
			  _bIsChanged |= (graduateschool != value); 
			  graduateschool = value; 
			}
			
		}
		
		public DateTime Pubdate
		{
			get { return pubdate; }
			set { _bIsChanged |= (pubdate != value); pubdate = value; }
			
		}
		
		public int MagUserId
		{
			get { return maguserid; }
			set { _bIsChanged |= (maguserid != value); maguserid = value; }
			
		}
		
		public bool State
		{
			get { return state; }
			set { _bIsChanged |= (state != value); state = value; }
			
		}
		
		public DateTime CheckedDate
		{
			get { return checkeddate; }
			set { _bIsChanged |= (checkeddate != value); checkeddate = value; }
			
		}
		
		public string JoinDate
		{
			get { return joindate; }
			set 
			{
			  if (value != null && value.Length > 50)
			    throw new ArgumentOutOfRangeException("JoinDate", "JoinDate value, cannot contain more than 50 characters");
			  _bIsChanged |= (joindate != value); 
			  joindate = value; 
			}
			
		}
		
		public string OutDate
		{
			get { return outdate; }
			set 
			{
			  if (value != null && value.Length > 50)
			    throw new ArgumentOutOfRangeException("OutDate", "OutDate value, cannot contain more than 50 characters");
			  _bIsChanged |= (outdate != value); 
			  outdate = value; 
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
	
	#region Custom ICollection interface for UserBaseInfo 

	
	public interface IUserBaseInfoCollection : ICollection
	{
		UserBaseInfo this[int index]{	get; set; }
		void Add(UserBaseInfo pUserBaseInfo);
		void Clear();
	}
	
	[Serializable]
	public class UserBaseInfoCollection : IUserBaseInfoCollection
	{
		private IList<UserBaseInfo> _arrayInternal;

		public UserBaseInfoCollection()
		{
			_arrayInternal = new List<UserBaseInfo>();
		}
		
		public UserBaseInfoCollection( IList<UserBaseInfo> pSource )
		{
			_arrayInternal = pSource;
			if(_arrayInternal == null)
			{
				_arrayInternal = new List<UserBaseInfo>();
			}
		}

		public UserBaseInfo this[int index]
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
		public void CopyTo(Array array, int index){ _arrayInternal.CopyTo((UserBaseInfo[])array, index); }
		public IEnumerator GetEnumerator() { return _arrayInternal.GetEnumerator(); }
		public void Add(UserBaseInfo pUserBaseInfo) { _arrayInternal.Add(pUserBaseInfo); }
		public void Clear() { _arrayInternal.Clear(); }
		public IList<UserBaseInfo> GetList() { return _arrayInternal; }
	 }
	
	#endregion
}
