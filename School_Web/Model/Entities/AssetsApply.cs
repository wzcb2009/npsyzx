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
	/// IAssetsApply interface for NHibernate mapped table 'AssetsApply'.
	/// </summary>
	public interface IAssetsApply
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
		
		int Num
		{
			get ;
			set ;
			  
		}
		
		string Remark
		{
			get ;
			set ;
			  
		}
		
		decimal Price
		{
			get ;
			set ;
			  
		}
		
		DateTime Pubdate
		{
			get ;
			set ;
			  
		}
		
		bool UserChecked1
		{
			get ;
			set ;
			  
		}
		
		DateTime CheckedPubdate1
		{
			get ;
			set ;
			  
		}
		
		string Remark1
		{
			get ;
			set ;
			  
		}
		
		bool UserChecked2
		{
			get ;
			set ;
			  
		}
		
		DateTime CheckedPubdate2
		{
			get ;
			set ;
			  
		}
		
		string Remark2
		{
			get ;
			set ;
			  
		}
		
		bool IsDeleted { get; set; }
		bool IsChanged { get; set; }
		
		#endregion 
	}

	/// <summary>
	/// AssetsApply object for NHibernate mapped table 'AssetsApply'.
	/// </summary>
	[Serializable]
	public class AssetsApply : IAssetsApply
	{
		#region Member Variables

		protected int id;
		protected string title;
		protected int num;
		protected string remark;
		protected decimal price;
		protected DateTime pubdate;
		protected bool userchecked1;
		protected DateTime checkedpubdate1;
		protected string remark1;
		protected bool userchecked2;
		protected DateTime checkedpubdate2;
		protected string remark2;
		protected bool _bIsDeleted;
		protected bool _bIsChanged;
		#endregion
		
		#region Constructors
		public AssetsApply() {}
		
		public AssetsApply(string pTitle, int pNum, string pRemark, decimal pPrice, DateTime pPubdate, bool pUserChecked1, DateTime pCheckedPubdate1, string pRemark1, bool pUserChecked2, DateTime pCheckedPubdate2, string pRemark2)
		{
			this.title = pTitle; 
			this.num = pNum; 
			this.remark = pRemark; 
			this.price = pPrice; 
			this.pubdate = pPubdate; 
			this.userchecked1 = pUserChecked1; 
			this.checkedpubdate1 = pCheckedPubdate1; 
			this.remark1 = pRemark1; 
			this.userchecked2 = pUserChecked2; 
			this.checkedpubdate2 = pCheckedPubdate2; 
			this.remark2 = pRemark2; 
		}
		
		public AssetsApply(int pId)
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
		
		public int Num
		{
			get { return num; }
			set { _bIsChanged |= (num != value); num = value; }
			
		}
		
		public string Remark
		{
			get { return remark; }
			set 
			{
			  if (value != null && value.Length > 250)
			    throw new ArgumentOutOfRangeException("Remark", "Remark value, cannot contain more than 250 characters");
			  _bIsChanged |= (remark != value); 
			  remark = value; 
			}
			
		}
		
		public decimal Price
		{
			get { return price; }
			set { _bIsChanged |= (price != value); price = value; }
			
		}
		
		public DateTime Pubdate
		{
			get { return pubdate; }
			set { _bIsChanged |= (pubdate != value); pubdate = value; }
			
		}
		
		public bool UserChecked1
		{
			get { return userchecked1; }
			set { _bIsChanged |= (userchecked1 != value); userchecked1 = value; }
			
		}
		
		public DateTime CheckedPubdate1
		{
			get { return checkedpubdate1; }
			set { _bIsChanged |= (checkedpubdate1 != value); checkedpubdate1 = value; }
			
		}
		
		public string Remark1
		{
			get { return remark1; }
			set 
			{
			  if (value != null && value.Length > 250)
			    throw new ArgumentOutOfRangeException("Remark1", "Remark1 value, cannot contain more than 250 characters");
			  _bIsChanged |= (remark1 != value); 
			  remark1 = value; 
			}
			
		}
		
		public bool UserChecked2
		{
			get { return userchecked2; }
			set { _bIsChanged |= (userchecked2 != value); userchecked2 = value; }
			
		}
		
		public DateTime CheckedPubdate2
		{
			get { return checkedpubdate2; }
			set { _bIsChanged |= (checkedpubdate2 != value); checkedpubdate2 = value; }
			
		}
		
		public string Remark2
		{
			get { return remark2; }
			set 
			{
			  if (value != null && value.Length > 250)
			    throw new ArgumentOutOfRangeException("Remark2", "Remark2 value, cannot contain more than 250 characters");
			  _bIsChanged |= (remark2 != value); 
			  remark2 = value; 
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
	
	#region Custom ICollection interface for AssetsApply 

	
	public interface IAssetsApplyCollection : ICollection
	{
		AssetsApply this[int index]{	get; set; }
		void Add(AssetsApply pAssetsApply);
		void Clear();
	}
	
	[Serializable]
	public class AssetsApplyCollection : IAssetsApplyCollection
	{
		private IList<AssetsApply> _arrayInternal;

		public AssetsApplyCollection()
		{
			_arrayInternal = new List<AssetsApply>();
		}
		
		public AssetsApplyCollection( IList<AssetsApply> pSource )
		{
			_arrayInternal = pSource;
			if(_arrayInternal == null)
			{
				_arrayInternal = new List<AssetsApply>();
			}
		}

		public AssetsApply this[int index]
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
		public void CopyTo(Array array, int index){ _arrayInternal.CopyTo((AssetsApply[])array, index); }
		public IEnumerator GetEnumerator() { return _arrayInternal.GetEnumerator(); }
		public void Add(AssetsApply pAssetsApply) { _arrayInternal.Add(pAssetsApply); }
		public void Clear() { _arrayInternal.Clear(); }
		public IList<AssetsApply> GetList() { return _arrayInternal; }
	 }
	
	#endregion
}
