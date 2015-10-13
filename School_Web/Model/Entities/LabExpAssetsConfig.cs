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
	/// ILabExpAssetsConfig interface for NHibernate mapped table 'LabExpAssetsConfig'.
	/// </summary>
	public interface ILabExpAssetsConfig
	{
		#region Public Properties
		
		int Id
		{
			get ;
			set ;
			  
		}
		
		int LabId
		{
			get ;
			set ;
			  
		}
		
		int AssetCaseId
		{
			get ;
			set ;
			  
		}
		
		string Title
		{
			get ;
			set ;
			  
		}
		
		int Pindex
		{
			get ;
			set ;
			  
		}
		
		int Num
		{
			get ;
			set ;
			  
		}
		
		string UnitName
		{
			get ;
			set ;
			  
		}
		
		string Manager
		{
			get ;
			set ;
			  
		}
		
		int Location
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
	/// LabExpAssetsConfig object for NHibernate mapped table 'LabExpAssetsConfig'.
	/// </summary>
	[Serializable]
	public class LabExpAssetsConfig : ILabExpAssetsConfig
	{
		#region Member Variables

		protected int id;
		protected int labid;
		protected int assetcaseid;
		protected string title;
		protected int pindex;
		protected int num;
		protected string unitname;
		protected string manager;
		protected int location;
		protected DateTime pubdate;
		protected bool _bIsDeleted;
		protected bool _bIsChanged;
		#endregion
		
		#region Constructors
		public LabExpAssetsConfig() {}
		
		public LabExpAssetsConfig(int pLabId, int pAssetCaseId, string pTitle, int pPindex, int pNum, string pUnitName, string pManager, int pLocation, DateTime pPubdate)
		{
			this.labid = pLabId; 
			this.assetcaseid = pAssetCaseId; 
			this.title = pTitle; 
			this.pindex = pPindex; 
			this.num = pNum; 
			this.unitname = pUnitName; 
			this.manager = pManager; 
			this.location = pLocation; 
			this.pubdate = pPubdate; 
		}
		
		public LabExpAssetsConfig(int pId)
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
		
		public int LabId
		{
			get { return labid; }
			set { _bIsChanged |= (labid != value); labid = value; }
			
		}
		
		public int AssetCaseId
		{
			get { return assetcaseid; }
			set { _bIsChanged |= (assetcaseid != value); assetcaseid = value; }
			
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
		
		public int Pindex
		{
			get { return pindex; }
			set { _bIsChanged |= (pindex != value); pindex = value; }
			
		}
		
		public int Num
		{
			get { return num; }
			set { _bIsChanged |= (num != value); num = value; }
			
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
		
		public string Manager
		{
			get { return manager; }
			set 
			{
			  if (value != null && value.Length > 50)
			    throw new ArgumentOutOfRangeException("Manager", "Manager value, cannot contain more than 50 characters");
			  _bIsChanged |= (manager != value); 
			  manager = value; 
			}
			
		}
		
		public int Location
		{
			get { return location; }
			set { _bIsChanged |= (location != value); location = value; }
			
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
	
	#region Custom ICollection interface for LabExpAssetsConfig 

	
	public interface ILabExpAssetsConfigCollection : ICollection
	{
		LabExpAssetsConfig this[int index]{	get; set; }
		void Add(LabExpAssetsConfig pLabExpAssetsConfig);
		void Clear();
	}
	
	[Serializable]
	public class LabExpAssetsConfigCollection : ILabExpAssetsConfigCollection
	{
		private IList<LabExpAssetsConfig> _arrayInternal;

		public LabExpAssetsConfigCollection()
		{
			_arrayInternal = new List<LabExpAssetsConfig>();
		}
		
		public LabExpAssetsConfigCollection( IList<LabExpAssetsConfig> pSource )
		{
			_arrayInternal = pSource;
			if(_arrayInternal == null)
			{
				_arrayInternal = new List<LabExpAssetsConfig>();
			}
		}

		public LabExpAssetsConfig this[int index]
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
		public void CopyTo(Array array, int index){ _arrayInternal.CopyTo((LabExpAssetsConfig[])array, index); }
		public IEnumerator GetEnumerator() { return _arrayInternal.GetEnumerator(); }
		public void Add(LabExpAssetsConfig pLabExpAssetsConfig) { _arrayInternal.Add(pLabExpAssetsConfig); }
		public void Clear() { _arrayInternal.Clear(); }
		public IList<LabExpAssetsConfig> GetList() { return _arrayInternal; }
	 }
	
	#endregion
}
