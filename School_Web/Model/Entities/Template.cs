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
	/// ITemplate interface for NHibernate mapped table 'Template'.
	/// </summary>
	public interface ITemplate
	{
		#region Public Properties
		
		int Id
		{
			get ;
			set ;
			  
		}
		
		string Title
		{
			get ;
			set ;
			  
		}
		
		int CaseId
		{
			get ;
			set ;
			  
		}
		
		string Remark
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
		
		int UserId
		{
			get ;
			set ;
			  
		}
		
		bool IsDeleted { get; set; }
		bool IsChanged { get; set; }
		
		#endregion 
	}

	/// <summary>
	/// Template object for NHibernate mapped table 'Template'.
	/// </summary>
	[Serializable]
	public class Template : ITemplate
	{
		#region Member Variables

		protected int id;
		protected string title;
		protected int caseid;
		protected string remark;
		protected DateTime pubdate;
		protected bool state;
		protected int userid;
		protected bool _bIsDeleted;
		protected bool _bIsChanged;
		#endregion
		
		#region Constructors
		public Template() {}
		
		public Template(string pTitle, int pCaseId, string pRemark, DateTime pPubdate, bool pState, int pUserId)
		{
			this.title = pTitle; 
			this.caseid = pCaseId; 
			this.remark = pRemark; 
			this.pubdate = pPubdate; 
			this.state = pState; 
			this.userid = pUserId; 
		}
		
		public Template(int pId)
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
		
		public string Title
		{
			get { return title; }
			set 
			{
			  if (value != null && value.Length > 50)
			    throw new ArgumentOutOfRangeException("Title", "Title value, cannot contain more than 50 characters");
			  _bIsChanged |= (title != value); 
			  title = value; 
			}
			
		}
		
		public int CaseId
		{
			get { return caseid; }
			set { _bIsChanged |= (caseid != value); caseid = value; }
			
		}
		
		public string Remark
		{
			get { return remark; }
			set 
			{
			  if (value != null && value.Length > 1073741823)
			    throw new ArgumentOutOfRangeException("Remark", "Remark value, cannot contain more than 1073741823 characters");
			  _bIsChanged |= (remark != value); 
			  remark = value; 
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
		
		public int UserId
		{
			get { return userid; }
			set { _bIsChanged |= (userid != value); userid = value; }
			
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
	
	#region Custom ICollection interface for Template 

	
	public interface ITemplateCollection : ICollection
	{
		Template this[int index]{	get; set; }
		void Add(Template pTemplate);
		void Clear();
	}
	
	[Serializable]
	public class TemplateCollection : ITemplateCollection
	{
		private IList<Template> _arrayInternal;

		public TemplateCollection()
		{
			_arrayInternal = new List<Template>();
		}
		
		public TemplateCollection( IList<Template> pSource )
		{
			_arrayInternal = pSource;
			if(_arrayInternal == null)
			{
				_arrayInternal = new List<Template>();
			}
		}

		public Template this[int index]
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
		public void CopyTo(Array array, int index){ _arrayInternal.CopyTo((Template[])array, index); }
		public IEnumerator GetEnumerator() { return _arrayInternal.GetEnumerator(); }
		public void Add(Template pTemplate) { _arrayInternal.Add(pTemplate); }
		public void Clear() { _arrayInternal.Clear(); }
		public IList<Template> GetList() { return _arrayInternal; }
	 }
	
	#endregion
}
