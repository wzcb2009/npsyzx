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
	/// IYouthUnit interface for NHibernate mapped table 'Youth_Unit'.
	/// </summary>
	public interface IYouthUnit
	{
		#region Public Properties
		
		int YouthUnitId
		{
			get ;
			set ;
			  
		}
		
		string UnitName
		{
			get ;
			set ;
			  
		}
		
		bool IsDeleted { get; set; }
		bool IsChanged { get; set; }
		
		#endregion 
	}

	/// <summary>
	/// YouthUnit object for NHibernate mapped table 'Youth_Unit'.
	/// </summary>
	[Serializable]
	public class YouthUnit : IYouthUnit
	{
		#region Member Variables

		protected int youthunitid;
		protected string unitname;
		protected bool _bIsDeleted;
		protected bool _bIsChanged;
		#endregion
		
		#region Constructors
		public YouthUnit() {}
		
		public YouthUnit(int pYouthUnitId, string pUnitName)
		{
			this.youthunitid = pYouthUnitId; 
			this.unitname = pUnitName; 
		}
		
		#endregion
		
		#region Public Properties
		
		public int YouthUnitId
		{
			get { return youthunitid; }
			set { _bIsChanged |= (youthunitid != value); youthunitid = value; }
			
		}
		
		public string UnitName
		{
			get { return unitname; }
			set 
			{
			  if (value != null && value.Length > 50)
			    throw new ArgumentOutOfRangeException("UnitName", "UnitName value, cannot contain more than 50 characters");
			  _bIsChanged |= (unitname != value); 
			  unitname = value; 
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
	
	#region Custom ICollection interface for YouthUnit 

	
	public interface IYouthUnitCollection : ICollection
	{
		YouthUnit this[int index]{	get; set; }
		void Add(YouthUnit pYouthUnit);
		void Clear();
	}
	
	[Serializable]
	public class YouthUnitCollection : IYouthUnitCollection
	{
		private IList<YouthUnit> _arrayInternal;

		public YouthUnitCollection()
		{
			_arrayInternal = new List<YouthUnit>();
		}
		
		public YouthUnitCollection( IList<YouthUnit> pSource )
		{
			_arrayInternal = pSource;
			if(_arrayInternal == null)
			{
				_arrayInternal = new List<YouthUnit>();
			}
		}

		public YouthUnit this[int index]
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
		public void CopyTo(Array array, int index){ _arrayInternal.CopyTo((YouthUnit[])array, index); }
		public IEnumerator GetEnumerator() { return _arrayInternal.GetEnumerator(); }
		public void Add(YouthUnit pYouthUnit) { _arrayInternal.Add(pYouthUnit); }
		public void Clear() { _arrayInternal.Clear(); }
		public IList<YouthUnit> GetList() { return _arrayInternal; }
	 }
	
	#endregion
}
