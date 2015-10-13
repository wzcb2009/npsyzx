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
	/// IInvestUserList interface for NHibernate mapped table 'Invest_UserList'.
	/// </summary>
	public interface IInvestUserList
	{
		#region Public Properties
		
		int Id
		{
			get ;
			set ;
			  
		}
		
		int InvestRoleId
		{
			get ;
			set ;
			  
		}
		
		int Userid
		{
			get ;
			set ;
			  
		}
		
		int InvestId
		{
			get ;
			set ;
			  
		}
		
		bool IsDeleted { get; set; }
		bool IsChanged { get; set; }
		
		#endregion 
	}

	/// <summary>
	/// InvestUserList object for NHibernate mapped table 'Invest_UserList'.
	/// </summary>
	[Serializable]
	public class InvestUserList : IInvestUserList
	{
		#region Member Variables

		protected int id;
		protected int investroleid;
		protected int userid;
		protected int investid;
		protected bool _bIsDeleted;
		protected bool _bIsChanged;
		#endregion
		
		#region Constructors
		public InvestUserList() {}
		
		public InvestUserList(int pInvestRoleId, int pUserid, int pInvestId)
		{
			this.investroleid = pInvestRoleId; 
			this.userid = pUserid; 
			this.investid = pInvestId; 
		}
		
		public InvestUserList(int pId)
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
		
		public int InvestRoleId
		{
			get { return investroleid; }
			set { _bIsChanged |= (investroleid != value); investroleid = value; }
			
		}
		
		public int Userid
		{
			get { return userid; }
			set { _bIsChanged |= (userid != value); userid = value; }
			
		}
		
		public int InvestId
		{
			get { return investid; }
			set { _bIsChanged |= (investid != value); investid = value; }
			
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
	
	#region Custom ICollection interface for InvestUserList 

	
	public interface IInvestUserListCollection : ICollection
	{
		InvestUserList this[int index]{	get; set; }
		void Add(InvestUserList pInvestUserList);
		void Clear();
	}
	
	[Serializable]
	public class InvestUserListCollection : IInvestUserListCollection
	{
		private IList<InvestUserList> _arrayInternal;

		public InvestUserListCollection()
		{
			_arrayInternal = new List<InvestUserList>();
		}
		
		public InvestUserListCollection( IList<InvestUserList> pSource )
		{
			_arrayInternal = pSource;
			if(_arrayInternal == null)
			{
				_arrayInternal = new List<InvestUserList>();
			}
		}

		public InvestUserList this[int index]
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
		public void CopyTo(Array array, int index){ _arrayInternal.CopyTo((InvestUserList[])array, index); }
		public IEnumerator GetEnumerator() { return _arrayInternal.GetEnumerator(); }
		public void Add(InvestUserList pInvestUserList) { _arrayInternal.Add(pInvestUserList); }
		public void Clear() { _arrayInternal.Clear(); }
		public IList<InvestUserList> GetList() { return _arrayInternal; }
	 }
	
	#endregion
}
