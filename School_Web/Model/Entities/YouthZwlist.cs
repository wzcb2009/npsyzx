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
	/// IYouthZwlist interface for NHibernate mapped table 'Youth_zwlist'.
	/// </summary>
	public interface IYouthZwlist
	{
		#region Public Properties
		
		int TypeId
		{
			get ;
			set ;
			  
		}
		
		string ZwName
		{
			get ;
			set ;
			  
		}
		
		bool IsDeleted { get; set; }
		bool IsChanged { get; set; }
		
		#endregion 
	}

	/// <summary>
	/// YouthZwlist object for NHibernate mapped table 'Youth_zwlist'.
	/// </summary>
	[Serializable]
	public class YouthZwlist : IYouthZwlist
	{
		#region Member Variables

		protected int typeid;
		protected string zwname;
		protected bool _bIsDeleted;
		protected bool _bIsChanged;
		#endregion
		
		#region Constructors
		public YouthZwlist() {}
		
		public YouthZwlist(string pZwName)
		{
			this.zwname = pZwName; 
		}
		
		public YouthZwlist(int pTypeId)
		{
			this.typeid = pTypeId; 
		}
		
		#endregion
		
		#region Public Properties
		
		public int TypeId
		{
			get { return typeid; }
			set { _bIsChanged |= (typeid != value); typeid = value; }
			
		}
		
		public string ZwName
		{
			get { return zwname; }
			set 
			{
			  if (value != null && value.Length > 50)
			    throw new ArgumentOutOfRangeException("ZwName", "ZwName value, cannot contain more than 50 characters");
			  _bIsChanged |= (zwname != value); 
			  zwname = value; 
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
	
	#region Custom ICollection interface for YouthZwlist 

	
	public interface IYouthZwlistCollection : ICollection
	{
		YouthZwlist this[int index]{	get; set; }
		void Add(YouthZwlist pYouthZwlist);
		void Clear();
	}
	
	[Serializable]
	public class YouthZwlistCollection : IYouthZwlistCollection
	{
		private IList<YouthZwlist> _arrayInternal;

		public YouthZwlistCollection()
		{
			_arrayInternal = new List<YouthZwlist>();
		}
		
		public YouthZwlistCollection( IList<YouthZwlist> pSource )
		{
			_arrayInternal = pSource;
			if(_arrayInternal == null)
			{
				_arrayInternal = new List<YouthZwlist>();
			}
		}

		public YouthZwlist this[int index]
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
		public void CopyTo(Array array, int index){ _arrayInternal.CopyTo((YouthZwlist[])array, index); }
		public IEnumerator GetEnumerator() { return _arrayInternal.GetEnumerator(); }
		public void Add(YouthZwlist pYouthZwlist) { _arrayInternal.Add(pYouthZwlist); }
		public void Clear() { _arrayInternal.Clear(); }
		public IList<YouthZwlist> GetList() { return _arrayInternal; }
	 }
	
	#endregion
}
