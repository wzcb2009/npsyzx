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
	/// IWebSysCaseType interface for NHibernate mapped table 'Web_Sys_CaseType'.
	/// </summary>
	public interface IWebSysCaseType
	{
		#region Public Properties
		
		int Id
		{
			get ;
			set ;
			  
		}
		
		int Typeid
		{
			get ;
			set ;
			  
		}
		
		string TypeName
		{
			get ;
			set ;
			  
		}
		
		string IndexUrl
		{
			get ;
			set ;
			  
		}
		
		string MagAdd
		{
			get ;
			set ;
			  
		}
		
		string MagEdit
		{
			get ;
			set ;
			  
		}
		
		string MagUrl
		{
			get ;
			set ;
			  
		}
		
		string Icon
		{
			get ;
			set ;
			  
		}
		
		int Fileextid
		{
			get ;
			set ;
			  
		}
		
		bool IsDeleted { get; set; }
		bool IsChanged { get; set; }
		
		#endregion 
	}

	/// <summary>
	/// WebSysCaseType object for NHibernate mapped table 'Web_Sys_CaseType'.
	/// </summary>
	[Serializable]
	public class WebSysCaseType : IWebSysCaseType
	{
		#region Member Variables

		protected int id;
		protected int typeid;
		protected string typename;
		protected string indexurl;
		protected string magadd;
		protected string magedit;
		protected string magurl;
		protected string icon;
		protected int fileextid;
		protected bool _bIsDeleted;
		protected bool _bIsChanged;
		#endregion
		
		#region Constructors
		public WebSysCaseType() {}
		
		public WebSysCaseType(int pId, int pTypeid, string pTypeName, string pIndexUrl, string pMagAdd, string pMagEdit, string pMagUrl, string pIcon, int pFileextid)
		{
			this.id = pId; 
			this.typeid = pTypeid; 
			this.typename = pTypeName; 
			this.indexurl = pIndexUrl; 
			this.magadd = pMagAdd; 
			this.magedit = pMagEdit; 
			this.magurl = pMagUrl; 
			this.icon = pIcon; 
			this.fileextid = pFileextid; 
		}
		
		public WebSysCaseType(int pId)
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
		
		public int Typeid
		{
			get { return typeid; }
			set { _bIsChanged |= (typeid != value); typeid = value; }
			
		}
		
		public string TypeName
		{
			get { return typename; }
			set 
			{
			  if (value != null && value.Length > 20)
			    throw new ArgumentOutOfRangeException("TypeName", "TypeName value, cannot contain more than 20 characters");
			  _bIsChanged |= (typename != value); 
			  typename = value; 
			}
			
		}
		
		public string IndexUrl
		{
			get { return indexurl; }
			set 
			{
			  if (value != null && value.Length > 50)
			    throw new ArgumentOutOfRangeException("IndexUrl", "IndexUrl value, cannot contain more than 50 characters");
			  _bIsChanged |= (indexurl != value); 
			  indexurl = value; 
			}
			
		}
		
		public string MagAdd
		{
			get { return magadd; }
			set 
			{
			  if (value != null && value.Length > 50)
			    throw new ArgumentOutOfRangeException("MagAdd", "MagAdd value, cannot contain more than 50 characters");
			  _bIsChanged |= (magadd != value); 
			  magadd = value; 
			}
			
		}
		
		public string MagEdit
		{
			get { return magedit; }
			set 
			{
			  if (value != null && value.Length > 50)
			    throw new ArgumentOutOfRangeException("MagEdit", "MagEdit value, cannot contain more than 50 characters");
			  _bIsChanged |= (magedit != value); 
			  magedit = value; 
			}
			
		}
		
		public string MagUrl
		{
			get { return magurl; }
			set 
			{
			  if (value != null && value.Length > 50)
			    throw new ArgumentOutOfRangeException("MagUrl", "MagUrl value, cannot contain more than 50 characters");
			  _bIsChanged |= (magurl != value); 
			  magurl = value; 
			}
			
		}
		
		public string Icon
		{
			get { return icon; }
			set 
			{
			  if (value != null && value.Length > 50)
			    throw new ArgumentOutOfRangeException("Icon", "Icon value, cannot contain more than 50 characters");
			  _bIsChanged |= (icon != value); 
			  icon = value; 
			}
			
		}
		
		public int Fileextid
		{
			get { return fileextid; }
			set { _bIsChanged |= (fileextid != value); fileextid = value; }
			
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
	
	#region Custom ICollection interface for WebSysCaseType 

	
	public interface IWebSysCaseTypeCollection : ICollection
	{
		WebSysCaseType this[int index]{	get; set; }
		void Add(WebSysCaseType pWebSysCaseType);
		void Clear();
	}
	
	[Serializable]
	public class WebSysCaseTypeCollection : IWebSysCaseTypeCollection
	{
		private IList<WebSysCaseType> _arrayInternal;

		public WebSysCaseTypeCollection()
		{
			_arrayInternal = new List<WebSysCaseType>();
		}
		
		public WebSysCaseTypeCollection( IList<WebSysCaseType> pSource )
		{
			_arrayInternal = pSource;
			if(_arrayInternal == null)
			{
				_arrayInternal = new List<WebSysCaseType>();
			}
		}

		public WebSysCaseType this[int index]
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
		public void CopyTo(Array array, int index){ _arrayInternal.CopyTo((WebSysCaseType[])array, index); }
		public IEnumerator GetEnumerator() { return _arrayInternal.GetEnumerator(); }
		public void Add(WebSysCaseType pWebSysCaseType) { _arrayInternal.Add(pWebSysCaseType); }
		public void Clear() { _arrayInternal.Clear(); }
		public IList<WebSysCaseType> GetList() { return _arrayInternal; }
	 }
	
	#endregion
}
