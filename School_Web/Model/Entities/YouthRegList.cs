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
	/// IYouthRegList interface for NHibernate mapped table 'Youth_reg_list'.
	/// </summary>
	public interface IYouthRegList
	{
		#region Public Properties
		
		int Id
		{
			get ;
			set ;
			  
		}
		
		int YouthId
		{
			get ;
			set ;
			  
		}
		
		int YouthStid
		{
			get ;
			set ;
			  
		}
		
		bool IsDeleted { get; set; }
		bool IsChanged { get; set; }
		
		#endregion 
	}

	/// <summary>
	/// YouthRegList object for NHibernate mapped table 'Youth_reg_list'.
	/// </summary>
	[Serializable]
	public class YouthRegList : IYouthRegList
	{
		#region Member Variables

		protected int id;
		protected int youthid;
		protected int youthstid;
		protected bool _bIsDeleted;
		protected bool _bIsChanged;
		#endregion
		
		#region Constructors
		public YouthRegList() {}
		
		public YouthRegList(int pYouthId, int pYouthStid)
		{
			this.youthid = pYouthId; 
			this.youthstid = pYouthStid; 
		}
		
		public YouthRegList(int pId)
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
		
		public int YouthId
		{
			get { return youthid; }
			set { _bIsChanged |= (youthid != value); youthid = value; }
			
		}
		
		public int YouthStid
		{
			get { return youthstid; }
			set { _bIsChanged |= (youthstid != value); youthstid = value; }
			
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
	
	#region Custom ICollection interface for YouthRegList 

	
	public interface IYouthRegListCollection : ICollection
	{
		YouthRegList this[int index]{	get; set; }
		void Add(YouthRegList pYouthRegList);
		void Clear();
	}
	
	[Serializable]
	public class YouthRegListCollection : IYouthRegListCollection
	{
		private IList<YouthRegList> _arrayInternal;

		public YouthRegListCollection()
		{
			_arrayInternal = new List<YouthRegList>();
		}
		
		public YouthRegListCollection( IList<YouthRegList> pSource )
		{
			_arrayInternal = pSource;
			if(_arrayInternal == null)
			{
				_arrayInternal = new List<YouthRegList>();
			}
		}

		public YouthRegList this[int index]
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
		public void CopyTo(Array array, int index){ _arrayInternal.CopyTo((YouthRegList[])array, index); }
		public IEnumerator GetEnumerator() { return _arrayInternal.GetEnumerator(); }
		public void Add(YouthRegList pYouthRegList) { _arrayInternal.Add(pYouthRegList); }
		public void Clear() { _arrayInternal.Clear(); }
		public IList<YouthRegList> GetList() { return _arrayInternal; }
	 }
	
	#endregion
}
