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
	/// ISystemPointParam interface for NHibernate mapped table 'System_Point_Param'.
	/// </summary>
	public interface ISystemPointParam
	{
		#region Public Properties
		
		int Id
		{
			get ;
			set ;
			  
		}
		
		int Moduleid
		{
			get ;
			set ;
			  
		}
		
		int Caseid
		{
			get ;
			set ;
			  
		}
		
		int LoginPoint
		{
			get ;
			set ;
			  
		}
		
		int AddPoint
		{
			get ;
			set ;
			  
		}
		
		int ViewPoint
		{
			get ;
			set ;
			  
		}
		
		int DownPoint
		{
			get ;
			set ;
			  
		}
		
		int CommentPoint
		{
			get ;
			set ;
			  
		}
		
		bool IsDeleted { get; set; }
		bool IsChanged { get; set; }
		
		#endregion 
	}

	/// <summary>
	/// SystemPointParam object for NHibernate mapped table 'System_Point_Param'.
	/// </summary>
	[Serializable]
	public class SystemPointParam : ISystemPointParam
	{
		#region Member Variables

		protected int id;
		protected int moduleid;
		protected int caseid;
		protected int loginpoint;
		protected int addpoint;
		protected int viewpoint;
		protected int downpoint;
		protected int commentpoint;
		protected bool _bIsDeleted;
		protected bool _bIsChanged;
		#endregion
		
		#region Constructors
		public SystemPointParam() {}
		
		public SystemPointParam(int pModuleid, int pCaseid, int pLoginPoint, int pAddPoint, int pViewPoint, int pDownPoint, int pCommentPoint)
		{
			this.moduleid = pModuleid; 
			this.caseid = pCaseid; 
			this.loginpoint = pLoginPoint; 
			this.addpoint = pAddPoint; 
			this.viewpoint = pViewPoint; 
			this.downpoint = pDownPoint; 
			this.commentpoint = pCommentPoint; 
		}
		
		public SystemPointParam(int pId)
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
		
		public int Moduleid
		{
			get { return moduleid; }
			set { _bIsChanged |= (moduleid != value); moduleid = value; }
			
		}
		
		public int Caseid
		{
			get { return caseid; }
			set { _bIsChanged |= (caseid != value); caseid = value; }
			
		}
		
		public int LoginPoint
		{
			get { return loginpoint; }
			set { _bIsChanged |= (loginpoint != value); loginpoint = value; }
			
		}
		
		public int AddPoint
		{
			get { return addpoint; }
			set { _bIsChanged |= (addpoint != value); addpoint = value; }
			
		}
		
		public int ViewPoint
		{
			get { return viewpoint; }
			set { _bIsChanged |= (viewpoint != value); viewpoint = value; }
			
		}
		
		public int DownPoint
		{
			get { return downpoint; }
			set { _bIsChanged |= (downpoint != value); downpoint = value; }
			
		}
		
		public int CommentPoint
		{
			get { return commentpoint; }
			set { _bIsChanged |= (commentpoint != value); commentpoint = value; }
			
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
	
	#region Custom ICollection interface for SystemPointParam 

	
	public interface ISystemPointParamCollection : ICollection
	{
		SystemPointParam this[int index]{	get; set; }
		void Add(SystemPointParam pSystemPointParam);
		void Clear();
	}
	
	[Serializable]
	public class SystemPointParamCollection : ISystemPointParamCollection
	{
		private IList<SystemPointParam> _arrayInternal;

		public SystemPointParamCollection()
		{
			_arrayInternal = new List<SystemPointParam>();
		}
		
		public SystemPointParamCollection( IList<SystemPointParam> pSource )
		{
			_arrayInternal = pSource;
			if(_arrayInternal == null)
			{
				_arrayInternal = new List<SystemPointParam>();
			}
		}

		public SystemPointParam this[int index]
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
		public void CopyTo(Array array, int index){ _arrayInternal.CopyTo((SystemPointParam[])array, index); }
		public IEnumerator GetEnumerator() { return _arrayInternal.GetEnumerator(); }
		public void Add(SystemPointParam pSystemPointParam) { _arrayInternal.Add(pSystemPointParam); }
		public void Clear() { _arrayInternal.Clear(); }
		public IList<SystemPointParam> GetList() { return _arrayInternal; }
	 }
	
	#endregion
}
