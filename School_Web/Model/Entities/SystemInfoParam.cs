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
	/// ISystemInfoParam interface for NHibernate mapped table 'System_Info_Param'.
	/// </summary>
	public interface ISystemInfoParam
	{
		#region Public Properties
		
		int Id
		{
			get ;
			set ;
			  
		}
		
		string Schoolname
		{
			get ;
			set ;
			  
		}
		
		string Address
		{
			get ;
			set ;
			  
		}
		
		string Contact
		{
			get ;
			set ;
			  
		}
		
		string Icp
		{
			get ;
			set ;
			  
		}
		
		string Content
		{
			get ;
			set ;
			  
		}
		
		DateTime Pubdate
		{
			get ;
			set ;
			  
		}
		
		string Uploadpath
		{
			get ;
			set ;
			  
		}
		
		bool IsDeleted { get; set; }
		bool IsChanged { get; set; }
		
		#endregion 
	}

	/// <summary>
	/// SystemInfoParam object for NHibernate mapped table 'System_Info_Param'.
	/// </summary>
	[Serializable]
	public class SystemInfoParam : ISystemInfoParam
	{
		#region Member Variables

		protected int id;
		protected string schoolname;
		protected string address;
		protected string contact;
		protected string icp;
		protected string content;
		protected DateTime pubdate;
		protected string uploadpath;
		protected bool _bIsDeleted;
		protected bool _bIsChanged;
		#endregion
		
		#region Constructors
		public SystemInfoParam() {}
		
		public SystemInfoParam(string pSchoolname, string pAddress, string pContact, string pIcp, string pContent, DateTime pPubdate, string pUploadpath)
		{
			this.schoolname = pSchoolname; 
			this.address = pAddress; 
			this.contact = pContact; 
			this.icp = pIcp; 
			this.content = pContent; 
			this.pubdate = pPubdate; 
			this.uploadpath = pUploadpath; 
		}
		
		public SystemInfoParam(int pId)
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
		
		public string Schoolname
		{
			get { return schoolname; }
			set 
			{
			  if (value != null && value.Length > 200)
			    throw new ArgumentOutOfRangeException("Schoolname", "Schoolname value, cannot contain more than 200 characters");
			  _bIsChanged |= (schoolname != value); 
			  schoolname = value; 
			}
			
		}
		
		public string Address
		{
			get { return address; }
			set 
			{
			  if (value != null && value.Length > 200)
			    throw new ArgumentOutOfRangeException("Address", "Address value, cannot contain more than 200 characters");
			  _bIsChanged |= (address != value); 
			  address = value; 
			}
			
		}
		
		public string Contact
		{
			get { return contact; }
			set 
			{
			  if (value != null && value.Length > 50)
			    throw new ArgumentOutOfRangeException("Contact", "Contact value, cannot contain more than 50 characters");
			  _bIsChanged |= (contact != value); 
			  contact = value; 
			}
			
		}
		
		public string Icp
		{
			get { return icp; }
			set 
			{
			  if (value != null && value.Length > 50)
			    throw new ArgumentOutOfRangeException("Icp", "Icp value, cannot contain more than 50 characters");
			  _bIsChanged |= (icp != value); 
			  icp = value; 
			}
			
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
		
		public DateTime Pubdate
		{
			get { return pubdate; }
			set { _bIsChanged |= (pubdate != value); pubdate = value; }
			
		}
		
		public string Uploadpath
		{
			get { return uploadpath; }
			set 
			{
			  if (value != null && value.Length > 50)
			    throw new ArgumentOutOfRangeException("Uploadpath", "Uploadpath value, cannot contain more than 50 characters");
			  _bIsChanged |= (uploadpath != value); 
			  uploadpath = value; 
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
	
	#region Custom ICollection interface for SystemInfoParam 

	
	public interface ISystemInfoParamCollection : ICollection
	{
		SystemInfoParam this[int index]{	get; set; }
		void Add(SystemInfoParam pSystemInfoParam);
		void Clear();
	}
	
	[Serializable]
	public class SystemInfoParamCollection : ISystemInfoParamCollection
	{
		private IList<SystemInfoParam> _arrayInternal;

		public SystemInfoParamCollection()
		{
			_arrayInternal = new List<SystemInfoParam>();
		}
		
		public SystemInfoParamCollection( IList<SystemInfoParam> pSource )
		{
			_arrayInternal = pSource;
			if(_arrayInternal == null)
			{
				_arrayInternal = new List<SystemInfoParam>();
			}
		}

		public SystemInfoParam this[int index]
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
		public void CopyTo(Array array, int index){ _arrayInternal.CopyTo((SystemInfoParam[])array, index); }
		public IEnumerator GetEnumerator() { return _arrayInternal.GetEnumerator(); }
		public void Add(SystemInfoParam pSystemInfoParam) { _arrayInternal.Add(pSystemInfoParam); }
		public void Clear() { _arrayInternal.Clear(); }
		public IList<SystemInfoParam> GetList() { return _arrayInternal; }
	 }
	
	#endregion
}
