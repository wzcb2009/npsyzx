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
	/// ISystemModule interface for NHibernate mapped table 'System_Module'.
	/// </summary>
	public interface ISystemModule
	{
		#region Public Properties
		
		int Id
		{
			get ;
			set ;
			  
		}
		
		string ModuleName
		{
			get ;
			set ;
			  
		}
		
		string Content
		{
			get ;
			set ;
			  
		}
		
		string Url
		{
			get ;
			set ;
			  
		}
		
		DateTime Pubdate
		{
			get ;
			set ;
			  
		}
		
		bool State
		{
			get ;
			set ;
			  
		}
		
		bool PublicFlag
		{
			get ;
			set ;
			  
		}
		
		bool IsDeleted { get; set; }
		bool IsChanged { get; set; }
		
		#endregion 
	}

	/// <summary>
	/// SystemModule object for NHibernate mapped table 'System_Module'.
	/// </summary>
	[Serializable]
	public class SystemModule : ISystemModule
	{
		#region Member Variables

		protected int id;
		protected string modulename;
		protected string content;
		protected string url;
		protected DateTime pubdate;
		protected bool state;
		protected bool publicflag;
		protected bool _bIsDeleted;
		protected bool _bIsChanged;
		#endregion
		
		#region Constructors
		public SystemModule() {}
		
		public SystemModule(int pId, string pModuleName, string pContent, string pUrl, DateTime pPubdate, bool pState, bool pPublicFlag)
		{
			this.id = pId; 
			this.modulename = pModuleName; 
			this.content = pContent; 
			this.url = pUrl; 
			this.pubdate = pPubdate; 
			this.state = pState; 
			this.publicflag = pPublicFlag; 
		}
		
		public SystemModule(int pId)
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
		
		public string ModuleName
		{
			get { return modulename; }
			set 
			{
			  if (value != null && value.Length > 50)
			    throw new ArgumentOutOfRangeException("ModuleName", "ModuleName value, cannot contain more than 50 characters");
			  _bIsChanged |= (modulename != value); 
			  modulename = value; 
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
		
		public string Url
		{
			get { return url; }
			set 
			{
			  if (value != null && value.Length > 250)
			    throw new ArgumentOutOfRangeException("Url", "Url value, cannot contain more than 250 characters");
			  _bIsChanged |= (url != value); 
			  url = value; 
			}
			
		}
		
		public DateTime Pubdate
		{
			get { return pubdate; }
			set { _bIsChanged |= (pubdate != value); pubdate = value; }
			
		}
		
		public bool State
		{
			get { return state; }
			set { _bIsChanged |= (state != value); state = value; }
			
		}
		
		public bool PublicFlag
		{
			get { return publicflag; }
			set { _bIsChanged |= (publicflag != value); publicflag = value; }
			
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
	
	#region Custom ICollection interface for SystemModule 

	
	public interface ISystemModuleCollection : ICollection
	{
		SystemModule this[int index]{	get; set; }
		void Add(SystemModule pSystemModule);
		void Clear();
	}
	
	[Serializable]
	public class SystemModuleCollection : ISystemModuleCollection
	{
		private IList<SystemModule> _arrayInternal;

		public SystemModuleCollection()
		{
			_arrayInternal = new List<SystemModule>();
		}
		
		public SystemModuleCollection( IList<SystemModule> pSource )
		{
			_arrayInternal = pSource;
			if(_arrayInternal == null)
			{
				_arrayInternal = new List<SystemModule>();
			}
		}

		public SystemModule this[int index]
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
		public void CopyTo(Array array, int index){ _arrayInternal.CopyTo((SystemModule[])array, index); }
		public IEnumerator GetEnumerator() { return _arrayInternal.GetEnumerator(); }
		public void Add(SystemModule pSystemModule) { _arrayInternal.Add(pSystemModule); }
		public void Clear() { _arrayInternal.Clear(); }
		public IList<SystemModule> GetList() { return _arrayInternal; }
	 }
	
	#endregion
}
