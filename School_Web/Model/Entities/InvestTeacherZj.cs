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
	/// IInvestTeacherZj interface for NHibernate mapped table 'Invest_TeacherZj'.
	/// </summary>
	public interface IInvestTeacherZj
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
		
		int InvestId
		{
			get ;
			set ;
			  
		}
		
		int TeacherId
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
		
		int Clicks
		{
			get ;
			set ;
			  
		}
		
		bool IsDeleted { get; set; }
		bool IsChanged { get; set; }
		
		#endregion 
	}

	/// <summary>
	/// InvestTeacherZj object for NHibernate mapped table 'Invest_TeacherZj'.
	/// </summary>
	[Serializable]
	public class InvestTeacherZj : IInvestTeacherZj
	{
		#region Member Variables

		protected int id;
		protected string title;
		protected int investid;
		protected int teacherid;
		protected string content;
		protected DateTime pubdate;
		protected int clicks;
		protected bool _bIsDeleted;
		protected bool _bIsChanged;
		#endregion
		
		#region Constructors
		public InvestTeacherZj() {}
		
		public InvestTeacherZj(int pId, string pTitle, int pInvestId, int pTeacherId, string pContent, DateTime pPubdate, int pClicks)
		{
			this.id = pId; 
			this.title = pTitle; 
			this.investid = pInvestId; 
			this.teacherid = pTeacherId; 
			this.content = pContent; 
			this.pubdate = pPubdate; 
			this.clicks = pClicks; 
		}
		
		public InvestTeacherZj(int pId)
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
		
		public int InvestId
		{
			get { return investid; }
			set { _bIsChanged |= (investid != value); investid = value; }
			
		}
		
		public int TeacherId
		{
			get { return teacherid; }
			set { _bIsChanged |= (teacherid != value); teacherid = value; }
			
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
		
		public int Clicks
		{
			get { return clicks; }
			set { _bIsChanged |= (clicks != value); clicks = value; }
			
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
	
	#region Custom ICollection interface for InvestTeacherZj 

	
	public interface IInvestTeacherZjCollection : ICollection
	{
		InvestTeacherZj this[int index]{	get; set; }
		void Add(InvestTeacherZj pInvestTeacherZj);
		void Clear();
	}
	
	[Serializable]
	public class InvestTeacherZjCollection : IInvestTeacherZjCollection
	{
		private IList<InvestTeacherZj> _arrayInternal;

		public InvestTeacherZjCollection()
		{
			_arrayInternal = new List<InvestTeacherZj>();
		}
		
		public InvestTeacherZjCollection( IList<InvestTeacherZj> pSource )
		{
			_arrayInternal = pSource;
			if(_arrayInternal == null)
			{
				_arrayInternal = new List<InvestTeacherZj>();
			}
		}

		public InvestTeacherZj this[int index]
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
		public void CopyTo(Array array, int index){ _arrayInternal.CopyTo((InvestTeacherZj[])array, index); }
		public IEnumerator GetEnumerator() { return _arrayInternal.GetEnumerator(); }
		public void Add(InvestTeacherZj pInvestTeacherZj) { _arrayInternal.Add(pInvestTeacherZj); }
		public void Clear() { _arrayInternal.Clear(); }
		public IList<InvestTeacherZj> GetList() { return _arrayInternal; }
	 }
	
	#endregion
}
