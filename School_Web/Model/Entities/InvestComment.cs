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
	/// IInvestComment interface for NHibernate mapped table 'Invest_comment'.
	/// </summary>
	public interface IInvestComment
	{
		#region Public Properties
		
		int Id
		{
			get ;
			set ;
			  
		}
		
		int InvestClassSubjectId
		{
			get ;
			set ;
			  
		}
		
		int ObjUserId
		{
			get ;
			set ;
			  
		}
		
		int ByUserId
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
		
		bool IsDeleted { get; set; }
		bool IsChanged { get; set; }
		
		#endregion 
	}

	/// <summary>
	/// InvestComment object for NHibernate mapped table 'Invest_comment'.
	/// </summary>
	[Serializable]
	public class InvestComment : IInvestComment
	{
		#region Member Variables

		protected int id;
		protected int investclasssubjectid;
		protected int objuserid;
		protected int byuserid;
		protected string content;
		protected DateTime pubdate;
		protected bool _bIsDeleted;
		protected bool _bIsChanged;
		#endregion
		
		#region Constructors
		public InvestComment() {}
		
		public InvestComment(int pInvestClassSubjectId, int pObjUserId, int pByUserId, string pContent, DateTime pPubdate)
		{
			this.investclasssubjectid = pInvestClassSubjectId; 
			this.objuserid = pObjUserId; 
			this.byuserid = pByUserId; 
			this.content = pContent; 
			this.pubdate = pPubdate; 
		}
		
		public InvestComment(int pId)
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
		
		public int InvestClassSubjectId
		{
			get { return investclasssubjectid; }
			set { _bIsChanged |= (investclasssubjectid != value); investclasssubjectid = value; }
			
		}
		
		public int ObjUserId
		{
			get { return objuserid; }
			set { _bIsChanged |= (objuserid != value); objuserid = value; }
			
		}
		
		public int ByUserId
		{
			get { return byuserid; }
			set { _bIsChanged |= (byuserid != value); byuserid = value; }
			
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
	
	#region Custom ICollection interface for InvestComment 

	
	public interface IInvestCommentCollection : ICollection
	{
		InvestComment this[int index]{	get; set; }
		void Add(InvestComment pInvestComment);
		void Clear();
	}
	
	[Serializable]
	public class InvestCommentCollection : IInvestCommentCollection
	{
		private IList<InvestComment> _arrayInternal;

		public InvestCommentCollection()
		{
			_arrayInternal = new List<InvestComment>();
		}
		
		public InvestCommentCollection( IList<InvestComment> pSource )
		{
			_arrayInternal = pSource;
			if(_arrayInternal == null)
			{
				_arrayInternal = new List<InvestComment>();
			}
		}

		public InvestComment this[int index]
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
		public void CopyTo(Array array, int index){ _arrayInternal.CopyTo((InvestComment[])array, index); }
		public IEnumerator GetEnumerator() { return _arrayInternal.GetEnumerator(); }
		public void Add(InvestComment pInvestComment) { _arrayInternal.Add(pInvestComment); }
		public void Clear() { _arrayInternal.Clear(); }
		public IList<InvestComment> GetList() { return _arrayInternal; }
	 }
	
	#endregion
}
