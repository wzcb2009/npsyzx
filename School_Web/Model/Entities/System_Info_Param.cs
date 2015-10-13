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
	/// ISystem_Info_Param interface for NHibernate mapped table 'System_Info_Param'.
	/// </summary>
	public interface ISystem_Info_Param
	{
		#region Public Properties
		
		int id
		{
			get ;
			set ;
			  
		}
		
		string schoolname
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
		
		DateTime pubdate
		{
			get ;
			set ;
			  
		}
		
		string uploadpath
		{
			get ;
			set ;
			  
		}
		
		bool IsDeleted { get; set; }
		bool IsChanged { get; set; }
		
		#endregion 
	}

	/// <summary>
	/// System_Info_Param object for NHibernate mapped table 'System_Info_Param'.
	/// </summary>
	[Serializable]
	public class System_Info_Param : ISystem_Info_Param
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
		public System_Info_Param() {}
		
		public System_Info_Param(string pSchoolname, string pAddress, string pContact, string pIcp, string pContent, DateTime pPubdate, string pUploadpath)
		{
			this.schoolname = pSchoolname; 
			this.address = pAddress; 
			this.contact = pContact; 
			this.icp = pIcp; 
			this.content = pContent; 
			this.pubdate = pPubdate; 
			this.uploadpath = pUploadpath; 
		}
		
		public System_Info_Param(int pId)
		{
			this.id = pId; 
		}
		
		#endregion
		
		#region Public Properties
		
		public virtual int id
		{
			get { return id; }
			set { _bIsChanged |= (id != value); id = value; }
			
		}
		
		public virtual string schoolname
		{
			get { return schoolname; }
			set 
			{
			  if (value != null && value.Length > 200)
			    throw new ArgumentOutOfRangeException("schoolname", "schoolname value, cannot contain more than 200 characters");
			  _bIsChanged |= (schoolname != value); 
			  schoolname = value; 
			}
			
		}
		
		public virtual string Address
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
		
		public virtual string Contact
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
		
		public virtual string Icp
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
		
		public virtual string Content
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
		
		public virtual DateTime pubdate
		{
			get { return pubdate; }
			set { _bIsChanged |= (pubdate != value); pubdate = value; }
			
		}
		
		public virtual string uploadpath
		{
			get { return uploadpath; }
			set 
			{
			  if (value != null && value.Length > 50)
			    throw new ArgumentOutOfRangeException("uploadpath", "uploadpath value, cannot contain more than 50 characters");
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
	
	#region Custom ICollection interface for System_Info_Param 

	
	public interface ISystem_Info_ParamCollection : ICollection
	{
		System_Info_Param this[int index]{	get; set; }
		void Add(System_Info_Param pSystem_Info_Param);
		void Clear();
	}
	
	[Serializable]
	public class System_Info_ParamCollection : ISystem_Info_ParamCollection
	{
		private IList<System_Info_Param> _arrayInternal;

		public System_Info_ParamCollection()
		{
			_arrayInternal = new List<System_Info_Param>();
		}
		
		public System_Info_ParamCollection( IList<System_Info_Param> pSource )
		{
			_arrayInternal = pSource;
			if(_arrayInternal == null)
			{
				_arrayInternal = new List<System_Info_Param>();
			}
		}

		public System_Info_Param this[int index]
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
		public void CopyTo(Array array, int index){ _arrayInternal.CopyTo((System_Info_Param[])array, index); }
		public IEnumerator GetEnumerator() { return _arrayInternal.GetEnumerator(); }
		public void Add(System_Info_Param pSystem_Info_Param) { _arrayInternal.Add(pSystem_Info_Param); }
		public void Clear() { _arrayInternal.Clear(); }
		public IList<System_Info_Param> GetList() { return _arrayInternal; }
	 }
	
	#endregion
}
