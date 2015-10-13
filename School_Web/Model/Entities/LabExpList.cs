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
	/// ILabExpList interface for NHibernate mapped table 'Lab_ExpList'.
	/// </summary>
	public interface ILabExpList
	{
		#region Public Properties
		
		int Id
		{
			get ;
			set ;
			  
		}
		
		int Pindex
		{
			get ;
			set ;
			  
		}
		
		int Gradeid
		{
			get ;
			set ;
			  
		}
		
		int Typeid
		{
			get ;
			set ;
			  
		}
		
		string Title
		{
			get ;
			set ;
			  
		}
		
		string Content
		{
			get ;
			set ;
			  
		}
		
		int Userid
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
		
		int Subjectid
		{
			get ;
			set ;
			  
		}
		
		bool IsDeleted { get; set; }
		bool IsChanged { get; set; }
		
		#endregion 
	}

	/// <summary>
	/// LabExpList object for NHibernate mapped table 'Lab_ExpList'.
	/// </summary>
	[Serializable]
	public class LabExpList : ILabExpList
	{
		#region Member Variables

		protected int id;
		protected int pindex;
		protected int gradeid;
		protected int typeid;
		protected string title;
		protected string content;
		protected int userid;
		protected DateTime pubdate;
		protected bool state;
		protected int subjectid;
		protected bool _bIsDeleted;
		protected bool _bIsChanged;
		#endregion
		
		#region Constructors
		public LabExpList() {}
		
		public LabExpList(int pId, int pPindex, int pGradeid, int pTypeid, string pTitle, string pContent, int pUserid, DateTime pPubdate, bool pState, int pSubjectid)
		{
			this.id = pId; 
			this.pindex = pPindex; 
			this.gradeid = pGradeid; 
			this.typeid = pTypeid; 
			this.title = pTitle; 
			this.content = pContent; 
			this.userid = pUserid; 
			this.pubdate = pPubdate; 
			this.state = pState; 
			this.subjectid = pSubjectid; 
		}
		
		public LabExpList(int pId)
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
		
		public int Pindex
		{
			get { return pindex; }
			set { _bIsChanged |= (pindex != value); pindex = value; }
			
		}
		
		public int Gradeid
		{
			get { return gradeid; }
			set { _bIsChanged |= (gradeid != value); gradeid = value; }
			
		}
		
		public int Typeid
		{
			get { return typeid; }
			set { _bIsChanged |= (typeid != value); typeid = value; }
			
		}
		
		public string Title
		{
			get { return title; }
			set 
			{
			  if (value != null && value.Length > 250)
			    throw new ArgumentOutOfRangeException("Title", "Title value, cannot contain more than 250 characters");
			  _bIsChanged |= (title != value); 
			  title = value; 
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
		
		public int Userid
		{
			get { return userid; }
			set { _bIsChanged |= (userid != value); userid = value; }
			
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
		
		public int Subjectid
		{
			get { return subjectid; }
			set { _bIsChanged |= (subjectid != value); subjectid = value; }
			
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
	
	#region Custom ICollection interface for LabExpList 

	
	public interface ILabExpListCollection : ICollection
	{
		LabExpList this[int index]{	get; set; }
		void Add(LabExpList pLabExpList);
		void Clear();
	}
	
	[Serializable]
	public class LabExpListCollection : ILabExpListCollection
	{
		private IList<LabExpList> _arrayInternal;

		public LabExpListCollection()
		{
			_arrayInternal = new List<LabExpList>();
		}
		
		public LabExpListCollection( IList<LabExpList> pSource )
		{
			_arrayInternal = pSource;
			if(_arrayInternal == null)
			{
				_arrayInternal = new List<LabExpList>();
			}
		}

		public LabExpList this[int index]
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
		public void CopyTo(Array array, int index){ _arrayInternal.CopyTo((LabExpList[])array, index); }
		public IEnumerator GetEnumerator() { return _arrayInternal.GetEnumerator(); }
		public void Add(LabExpList pLabExpList) { _arrayInternal.Add(pLabExpList); }
		public void Clear() { _arrayInternal.Clear(); }
		public IList<LabExpList> GetList() { return _arrayInternal; }
	 }
	
	#endregion
}
