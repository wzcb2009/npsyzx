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
	/// IJournalUserlist interface for NHibernate mapped table 'Journal_userlist'.
	/// </summary>
	public interface IJournalUserlist
	{
		#region Public Properties
		
		int Userid
		{
			get ;
			set ;
			  
		}
		
		int Roleid
		{
			get ;
			set ;
			  
		}
		
		string Username
		{
			get ;
			set ;
			  
		}
		
		string Pwd
		{
			get ;
			set ;
			  
		}
		
		string Truename
		{
			get ;
			set ;
			  
		}
		
		string Sex
		{
			get ;
			set ;
			  
		}
		
		string Birthday
		{
			get ;
			set ;
			  
		}
		
		string Zyfx
		{
			get ;
			set ;
			  
		}
		
		string Zy
		{
			get ;
			set ;
			  
		}
		
		string Zc
		{
			get ;
			set ;
			  
		}
		
		string Unit
		{
			get ;
			set ;
			  
		}
		
		string Email
		{
			get ;
			set ;
			  
		}
		
		string Code
		{
			get ;
			set ;
			  
		}
		
		string Address
		{
			get ;
			set ;
			  
		}
		
		bool CheckState
		{
			get ;
			set ;
			  
		}
		
		DateTime Pubdate
		{
			get ;
			set ;
			  
		}
		
		string Post
		{
			get ;
			set ;
			  
		}
		
		string Tel
		{
			get ;
			set ;
			  
		}
		
		string Mtel
		{
			get ;
			set ;
			  
		}
		
		bool IsDeleted { get; set; }
		bool IsChanged { get; set; }
		
		#endregion 
	}

	/// <summary>
	/// JournalUserlist object for NHibernate mapped table 'Journal_userlist'.
	/// </summary>
	[Serializable]
	public class JournalUserlist : IJournalUserlist
	{
		#region Member Variables

		protected int userid;
		protected int roleid;
		protected string username;
		protected string pwd;
		protected string truename;
		protected string sex;
		protected string birthday;
		protected string zyfx;
		protected string zy;
		protected string zc;
		protected string unit;
		protected string email;
		protected string code;
		protected string address;
		protected bool checkstate;
		protected DateTime pubdate;
		protected string post;
		protected string tel;
		protected string mtel;
		protected bool _bIsDeleted;
		protected bool _bIsChanged;
		#endregion
		
		#region Constructors
		public JournalUserlist() {}
		
		public JournalUserlist(int pUserid, int pRoleid, string pUsername, string pPwd, string pTruename, string pSex, string pBirthday, string pZyfx, string pZy, string pZc, string pUnit, string pEmail, string pCode, string pAddress, bool pCheckState, DateTime pPubdate, string pPost, string pTel, string pMtel)
		{
			this.userid = pUserid; 
			this.roleid = pRoleid; 
			this.username = pUsername; 
			this.pwd = pPwd; 
			this.truename = pTruename; 
			this.sex = pSex; 
			this.birthday = pBirthday; 
			this.zyfx = pZyfx; 
			this.zy = pZy; 
			this.zc = pZc; 
			this.unit = pUnit; 
			this.email = pEmail; 
			this.code = pCode; 
			this.address = pAddress; 
			this.checkstate = pCheckState; 
			this.pubdate = pPubdate; 
			this.post = pPost; 
			this.tel = pTel; 
			this.mtel = pMtel; 
		}
		
		public JournalUserlist(int pUserid)
		{
			this.userid = pUserid; 
		}
		
		#endregion
		
		#region Public Properties
		
		public int Userid
		{
			get { return userid; }
			set { _bIsChanged |= (userid != value); userid = value; }
			
		}
		
		public int Roleid
		{
			get { return roleid; }
			set { _bIsChanged |= (roleid != value); roleid = value; }
			
		}
		
		public string Username
		{
			get { return username; }
			set 
			{
			  if (value != null && value.Length > 50)
			    throw new ArgumentOutOfRangeException("Username", "Username value, cannot contain more than 50 characters");
			  _bIsChanged |= (username != value); 
			  username = value; 
			}
			
		}
		
		public string Pwd
		{
			get { return pwd; }
			set 
			{
			  if (value != null && value.Length > 50)
			    throw new ArgumentOutOfRangeException("Pwd", "Pwd value, cannot contain more than 50 characters");
			  _bIsChanged |= (pwd != value); 
			  pwd = value; 
			}
			
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
		
		public string Birthday
		{
			get { return birthday; }
			set 
			{
			  if (value != null && value.Length > 50)
			    throw new ArgumentOutOfRangeException("Birthday", "Birthday value, cannot contain more than 50 characters");
			  _bIsChanged |= (birthday != value); 
			  birthday = value; 
			}
			
		}
		
		public string Zyfx
		{
			get { return zyfx; }
			set 
			{
			  if (value != null && value.Length > 50)
			    throw new ArgumentOutOfRangeException("Zyfx", "Zyfx value, cannot contain more than 50 characters");
			  _bIsChanged |= (zyfx != value); 
			  zyfx = value; 
			}
			
		}
		
		public string Zy
		{
			get { return zy; }
			set 
			{
			  if (value != null && value.Length > 50)
			    throw new ArgumentOutOfRangeException("Zy", "Zy value, cannot contain more than 50 characters");
			  _bIsChanged |= (zy != value); 
			  zy = value; 
			}
			
		}
		
		public string Zc
		{
			get { return zc; }
			set 
			{
			  if (value != null && value.Length > 50)
			    throw new ArgumentOutOfRangeException("Zc", "Zc value, cannot contain more than 50 characters");
			  _bIsChanged |= (zc != value); 
			  zc = value; 
			}
			
		}
		
		public string Unit
		{
			get { return unit; }
			set 
			{
			  if (value != null && value.Length > 50)
			    throw new ArgumentOutOfRangeException("Unit", "Unit value, cannot contain more than 50 characters");
			  _bIsChanged |= (unit != value); 
			  unit = value; 
			}
			
		}
		
		public string Email
		{
			get { return email; }
			set 
			{
			  if (value != null && value.Length > 50)
			    throw new ArgumentOutOfRangeException("Email", "Email value, cannot contain more than 50 characters");
			  _bIsChanged |= (email != value); 
			  email = value; 
			}
			
		}
		
		public string Code
		{
			get { return code; }
			set 
			{
			  if (value != null && value.Length > 50)
			    throw new ArgumentOutOfRangeException("Code", "Code value, cannot contain more than 50 characters");
			  _bIsChanged |= (code != value); 
			  code = value; 
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
		
		public bool CheckState
		{
			get { return checkstate; }
			set { _bIsChanged |= (checkstate != value); checkstate = value; }
			
		}
		
		public DateTime Pubdate
		{
			get { return pubdate; }
			set { _bIsChanged |= (pubdate != value); pubdate = value; }
			
		}
		
		public string Post
		{
			get { return post; }
			set 
			{
			  if (value != null && value.Length > 20)
			    throw new ArgumentOutOfRangeException("Post", "Post value, cannot contain more than 20 characters");
			  _bIsChanged |= (post != value); 
			  post = value; 
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
		
		public string Mtel
		{
			get { return mtel; }
			set 
			{
			  if (value != null && value.Length > 50)
			    throw new ArgumentOutOfRangeException("Mtel", "Mtel value, cannot contain more than 50 characters");
			  _bIsChanged |= (mtel != value); 
			  mtel = value; 
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
	
	#region Custom ICollection interface for JournalUserlist 

	
	public interface IJournalUserlistCollection : ICollection
	{
		JournalUserlist this[int index]{	get; set; }
		void Add(JournalUserlist pJournalUserlist);
		void Clear();
	}
	
	[Serializable]
	public class JournalUserlistCollection : IJournalUserlistCollection
	{
		private IList<JournalUserlist> _arrayInternal;

		public JournalUserlistCollection()
		{
			_arrayInternal = new List<JournalUserlist>();
		}
		
		public JournalUserlistCollection( IList<JournalUserlist> pSource )
		{
			_arrayInternal = pSource;
			if(_arrayInternal == null)
			{
				_arrayInternal = new List<JournalUserlist>();
			}
		}

		public JournalUserlist this[int index]
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
		public void CopyTo(Array array, int index){ _arrayInternal.CopyTo((JournalUserlist[])array, index); }
		public IEnumerator GetEnumerator() { return _arrayInternal.GetEnumerator(); }
		public void Add(JournalUserlist pJournalUserlist) { _arrayInternal.Add(pJournalUserlist); }
		public void Clear() { _arrayInternal.Clear(); }
		public IList<JournalUserlist> GetList() { return _arrayInternal; }
	 }
	
	#endregion
}
