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
	/// IKgradeList interface for NHibernate mapped table 'KGradeList'.
	/// </summary>
	public interface IKgradeList
	{
		#region Public Properties
		
		int Id
		{
			get ;
			set ;
			  
		}
		
		string Kgradename
		{
			get ;
			set ;
			  
		}
		
		bool IsDeleted { get; set; }
		bool IsChanged { get; set; }
		
		#endregion 
	}

	/// <summary>
	/// KgradeList object for NHibernate mapped table 'KGradeList'.
	/// </summary>
	[Serializable]
	public class KgradeList : IKgradeList
	{
		#region Member Variables

		protected int id;
		protected string kgradename;
		protected bool _bIsDeleted;
		protected bool _bIsChanged;
		#endregion
		
		#region Constructors
		public KgradeList() {}
		
		public KgradeList(int pId, string pKgradename)
		{
			this.id = pId; 
			this.kgradename = pKgradename; 
		}
		
		public KgradeList(int pId)
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
		
		public string Kgradename
		{
			get { return kgradename; }
			set 
			{
			  if (value != null && value.Length > 50)
			    throw new ArgumentOutOfRangeException("Kgradename", "Kgradename value, cannot contain more than 50 characters");
			  _bIsChanged |= (kgradename != value); 
			  kgradename = value; 
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
	
	#region Custom ICollection interface for KgradeList 

	
	public interface IKgradeListCollection : ICollection
	{
		KgradeList this[int index]{	get; set; }
		void Add(KgradeList pKgradeList);
		void Clear();
	}
	
	[Serializable]
	public class KgradeListCollection : IKgradeListCollection
	{
		private IList<KgradeList> _arrayInternal;

		public KgradeListCollection()
		{
			_arrayInternal = new List<KgradeList>();
		}
		
		public KgradeListCollection( IList<KgradeList> pSource )
		{
			_arrayInternal = pSource;
			if(_arrayInternal == null)
			{
				_arrayInternal = new List<KgradeList>();
			}
		}

		public KgradeList this[int index]
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
		public void CopyTo(Array array, int index){ _arrayInternal.CopyTo((KgradeList[])array, index); }
		public IEnumerator GetEnumerator() { return _arrayInternal.GetEnumerator(); }
		public void Add(KgradeList pKgradeList) { _arrayInternal.Add(pKgradeList); }
		public void Clear() { _arrayInternal.Clear(); }
		public IList<KgradeList> GetList() { return _arrayInternal; }
	 }
	
	#endregion
}
