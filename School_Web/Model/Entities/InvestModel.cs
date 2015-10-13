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
	/// IInvestModel interface for NHibernate mapped table 'Invest_model'.
	/// </summary>
	public interface IInvestModel
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
		
		string Content
		{
			get ;
			set ;
			  
		}
		
		int Roleid
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
	/// InvestModel object for NHibernate mapped table 'Invest_model'.
	/// </summary>
	[Serializable]
	public class InvestModel : IInvestModel
	{
		#region Member Variables

		protected int id;
		protected string title;
		protected string content;
		protected int roleid;
		protected DateTime pubdate;
		protected bool _bIsDeleted;
		protected bool _bIsChanged;
		#endregion
		
		#region Constructors
		public InvestModel() {}
		
		public InvestModel(string pTitle, string pContent, int pRoleid, DateTime pPubdate)
		{
			this.title = pTitle; 
			this.content = pContent; 
			this.roleid = pRoleid; 
			this.pubdate = pPubdate; 
		}
		
		public InvestModel(int pId)
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
		
		public int Roleid
		{
			get { return roleid; }
			set { _bIsChanged |= (roleid != value); roleid = value; }
			
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
	
	#region Custom ICollection interface for InvestModel 

	
	public interface IInvestModelCollection : ICollection
	{
		InvestModel this[int index]{	get; set; }
		void Add(InvestModel pInvestModel);
		void Clear();
	}
	
	[Serializable]
	public class InvestModelCollection : IInvestModelCollection
	{
		private IList<InvestModel> _arrayInternal;

		public InvestModelCollection()
		{
			_arrayInternal = new List<InvestModel>();
		}
		
		public InvestModelCollection( IList<InvestModel> pSource )
		{
			_arrayInternal = pSource;
			if(_arrayInternal == null)
			{
				_arrayInternal = new List<InvestModel>();
			}
		}

		public InvestModel this[int index]
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
		public void CopyTo(Array array, int index){ _arrayInternal.CopyTo((InvestModel[])array, index); }
		public IEnumerator GetEnumerator() { return _arrayInternal.GetEnumerator(); }
		public void Add(InvestModel pInvestModel) { _arrayInternal.Add(pInvestModel); }
		public void Clear() { _arrayInternal.Clear(); }
		public IList<InvestModel> GetList() { return _arrayInternal; }
	 }
	
	#endregion
}
