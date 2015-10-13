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
	/// IUserlist interface for NHibernate mapped table 'Userlist'.
	/// </summary>
	public interface IUserlist
	{
		#region Public Properties
		
		int UserId
		{
			get ;
			set ;
			  
		}
		
		int RoleId
		{
			get ;
			set ;
			  
		}
		
		int Gradeid
		{
			get ;
			set ;
			  
		}
		
		int Classid
		{
			get ;
			set ;
			  
		}
		
		string UserName
		{
			get ;
			set ;
			  
		}
		
		string Truename
		{
			get ;
			set ;
			  
		}
		
		string TruenameEn
		{
			get ;
			set ;
			  
		}
		
		string Pwd
		{
			get ;
			set ;
			  
		}
		
		DateTime LastLogin
		{
			get ;
			set ;
			  
		}
		
		DateTime PubDate
		{
			get ;
			set ;
			  
		}
		
		string LocalIp
		{
			get ;
			set ;
			  
		}
		
		int LoginTimes
		{
			get ;
			set ;
			  
		}
		
		string OtherGuid
		{
			get ;
			set ;
			  
		}
		
		bool State
		{
			get ;
			set ;
			  
		}
		
		string Sex
		{
			get ;
			set ;
			  
		}
		
		string FaceUrl
		{
			get ;
			set ;
			  
		}
		
		string Tel
		{
			get ;
			set ;
			  
		}
		
		string Qq
		{
			get ;
			set ;
			  
		}
		
		string Qqwx
		{
			get ;
			set ;
			  
		}
		
		bool IsDeleted { get; set; }
		bool IsChanged { get; set; }
		
		#endregion 
	}

	/// <summary>
	/// Userlist object for NHibernate mapped table 'Userlist'.
	/// </summary>
	[Serializable]
	public class Userlist : IUserlist
	{
		#region Member Variables

		protected int userid;
		protected int roleid;
		protected int gradeid;
		protected int classid;
		protected string username;
		protected string truename;
		protected string truenameen;
		protected string pwd;
		protected DateTime lastlogin;
		protected DateTime pubdate;
		protected string localip;
		protected int logintimes;
		protected string otherguid;
		protected bool state;
		protected string sex;
		protected string faceurl;
		protected string tel;
		protected string qq;
		protected string qqwx;
		protected bool _bIsDeleted;
		protected bool _bIsChanged;
		#endregion
		
		#region Constructors
		public Userlist() {}
		
		public Userlist(int pRoleId, int pGradeid, int pClassid, string pUserName, string pTruename, string pTruenameEn, string pPwd, DateTime pLastLogin, DateTime pPubDate, string pLocalIp, int pLoginTimes, string pOtherGuid, bool pState, string pSex, string pFaceUrl, string pTel, string pQq, string pQqwx)
		{
			this.roleid = pRoleId; 
			this.gradeid = pGradeid; 
			this.classid = pClassid; 
			this.username = pUserName; 
			this.truename = pTruename; 
			this.truenameen = pTruenameEn; 
			this.pwd = pPwd; 
			this.lastlogin = pLastLogin; 
			this.pubdate = pPubDate; 
			this.localip = pLocalIp; 
			this.logintimes = pLoginTimes; 
			this.otherguid = pOtherGuid; 
			this.state = pState; 
			this.sex = pSex; 
			this.faceurl = pFaceUrl; 
			this.tel = pTel; 
			this.qq = pQq; 
			this.qqwx = pQqwx; 
		}
		
		public Userlist(int pUserId)
		{
			this.userid = pUserId; 
		}
		
		#endregion
		
		#region Public Properties
		
		public int UserId
		{
			get { return userid; }
			set { _bIsChanged |= (userid != value); userid = value; }
			
		}
		
		public int RoleId
		{
			get { return roleid; }
			set { _bIsChanged |= (roleid != value); roleid = value; }
			
		}
		
		public int Gradeid
		{
			get { return gradeid; }
			set { _bIsChanged |= (gradeid != value); gradeid = value; }
			
		}
		
		public int Classid
		{
			get { return classid; }
			set { _bIsChanged |= (classid != value); classid = value; }
			
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
		
		public string TruenameEn
		{
			get { return truenameen; }
			set 
			{
			  if (value != null && value.Length > 50)
			    throw new ArgumentOutOfRangeException("TruenameEn", "TruenameEn value, cannot contain more than 50 characters");
			  _bIsChanged |= (truenameen != value); 
			  truenameen = value; 
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
		
		public DateTime LastLogin
		{
			get { return lastlogin; }
			set { _bIsChanged |= (lastlogin != value); lastlogin = value; }
			
		}
		
		public DateTime PubDate
		{
			get { return pubdate; }
			set { _bIsChanged |= (pubdate != value); pubdate = value; }
			
		}
		
		public string LocalIp
		{
			get { return localip; }
			set 
			{
			  if (value != null && value.Length > 50)
			    throw new ArgumentOutOfRangeException("LocalIp", "LocalIp value, cannot contain more than 50 characters");
			  _bIsChanged |= (localip != value); 
			  localip = value; 
			}
			
		}
		
		public int LoginTimes
		{
			get { return logintimes; }
			set { _bIsChanged |= (logintimes != value); logintimes = value; }
			
		}
		
		public string OtherGuid
		{
			get { return otherguid; }
			set 
			{
			  if (value != null && value.Length > 50)
			    throw new ArgumentOutOfRangeException("OtherGuid", "OtherGuid value, cannot contain more than 50 characters");
			  _bIsChanged |= (otherguid != value); 
			  otherguid = value; 
			}
			
		}
		
		public bool State
		{
			get { return state; }
			set { _bIsChanged |= (state != value); state = value; }
			
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
		
		public string FaceUrl
		{
			get { return faceurl; }
			set 
			{
			  if (value != null && value.Length > 250)
			    throw new ArgumentOutOfRangeException("FaceUrl", "FaceUrl value, cannot contain more than 250 characters");
			  _bIsChanged |= (faceurl != value); 
			  faceurl = value; 
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
		
		public string Qq
		{
			get { return qq; }
			set 
			{
			  if (value != null && value.Length > 50)
			    throw new ArgumentOutOfRangeException("Qq", "Qq value, cannot contain more than 50 characters");
			  _bIsChanged |= (qq != value); 
			  qq = value; 
			}
			
		}
		
		public string Qqwx
		{
			get { return qqwx; }
			set 
			{
			  if (value != null && value.Length > 50)
			    throw new ArgumentOutOfRangeException("Qqwx", "Qqwx value, cannot contain more than 50 characters");
			  _bIsChanged |= (qqwx != value); 
			  qqwx = value; 
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
	
	#region Custom ICollection interface for Userlist 

	
	public interface IUserlistCollection : ICollection
	{
		Userlist this[int index]{	get; set; }
		void Add(Userlist pUserlist);
		void Clear();
	}
	
	[Serializable]
	public class UserlistCollection : IUserlistCollection
	{
		private IList<Userlist> _arrayInternal;

		public UserlistCollection()
		{
			_arrayInternal = new List<Userlist>();
		}
		
		public UserlistCollection( IList<Userlist> pSource )
		{
			_arrayInternal = pSource;
			if(_arrayInternal == null)
			{
				_arrayInternal = new List<Userlist>();
			}
		}

		public Userlist this[int index]
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
		public void CopyTo(Array array, int index){ _arrayInternal.CopyTo((Userlist[])array, index); }
		public IEnumerator GetEnumerator() { return _arrayInternal.GetEnumerator(); }
		public void Add(Userlist pUserlist) { _arrayInternal.Add(pUserlist); }
		public void Clear() { _arrayInternal.Clear(); }
		public IList<Userlist> GetList() { return _arrayInternal; }
	 }
	
	#endregion
}
