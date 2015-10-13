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
	/// ILabActiveData interface for NHibernate mapped table 'Lab_Active_Data'.
	/// </summary>
	public interface ILabActiveData
	{
		#region Public Properties
		
		int Id
		{
			get ;
			set ;
			  
		}
		
		int Activeid
		{
			get ;
			set ;
			  
		}
		
		int Caseid
		{
			get ;
			set ;
			  
		}
		
		int Num
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
	/// LabActiveData object for NHibernate mapped table 'Lab_Active_Data'.
	/// </summary>
	[Serializable]
	public class LabActiveData : ILabActiveData
	{
		#region Member Variables

		protected int id;
		protected int activeid;
		protected int caseid;
		protected int num;
		protected DateTime pubdate;
		protected bool _bIsDeleted;
		protected bool _bIsChanged;
		#endregion
		
		#region Constructors
		public LabActiveData() {}
		
		public LabActiveData(int pId, int pActiveid, int pCaseid, int pNum, DateTime pPubdate)
		{
			this.id = pId; 
			this.activeid = pActiveid; 
			this.caseid = pCaseid; 
			this.num = pNum; 
			this.pubdate = pPubdate; 
		}
		
		public LabActiveData(int pId)
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
		
		public int Activeid
		{
			get { return activeid; }
			set { _bIsChanged |= (activeid != value); activeid = value; }
			
		}
		
		public int Caseid
		{
			get { return caseid; }
			set { _bIsChanged |= (caseid != value); caseid = value; }
			
		}
		
		public int Num
		{
			get { return num; }
			set { _bIsChanged |= (num != value); num = value; }
			
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
	
	#region Custom ICollection interface for LabActiveData 

	
	public interface ILabActiveDataCollection : ICollection
	{
		LabActiveData this[int index]{	get; set; }
		void Add(LabActiveData pLabActiveData);
		void Clear();
	}
	
	[Serializable]
	public class LabActiveDataCollection : ILabActiveDataCollection
	{
		private IList<LabActiveData> _arrayInternal;

		public LabActiveDataCollection()
		{
			_arrayInternal = new List<LabActiveData>();
		}
		
		public LabActiveDataCollection( IList<LabActiveData> pSource )
		{
			_arrayInternal = pSource;
			if(_arrayInternal == null)
			{
				_arrayInternal = new List<LabActiveData>();
			}
		}

		public LabActiveData this[int index]
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
		public void CopyTo(Array array, int index){ _arrayInternal.CopyTo((LabActiveData[])array, index); }
		public IEnumerator GetEnumerator() { return _arrayInternal.GetEnumerator(); }
		public void Add(LabActiveData pLabActiveData) { _arrayInternal.Add(pLabActiveData); }
		public void Clear() { _arrayInternal.Clear(); }
		public IList<LabActiveData> GetList() { return _arrayInternal; }
	 }
	
	#endregion
}
