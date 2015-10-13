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
	/// ILabLocation interface for NHibernate mapped table 'Lab_Location'.
	/// </summary>
	public interface ILabLocation
	{
		#region Public Properties
		
		int Id
		{
			get ;
			set ;
			  
		}
		
		string Address
		{
			get ;
			set ;
			  
		}
		
		int Parentid
		{
			get ;
			set ;
			  
		}
		
		string Codenum
		{
			get ;
			set ;
			  
		}
		
		bool IsDeleted { get; set; }
		bool IsChanged { get; set; }
		
		#endregion 
	}

	/// <summary>
	/// LabLocation object for NHibernate mapped table 'Lab_Location'.
	/// </summary>
	[Serializable]
	public class LabLocation : ILabLocation
	{
		#region Member Variables

		protected int id;
		protected string address;
		protected int parentid;
		protected string codenum;
		protected bool _bIsDeleted;
		protected bool _bIsChanged;
		#endregion
		
		#region Constructors
		public LabLocation() {}
		
		public LabLocation(int pId, string pAddress, int pParentid, string pCodenum)
		{
			this.id = pId; 
			this.address = pAddress; 
			this.parentid = pParentid; 
			this.codenum = pCodenum; 
		}
		
		public LabLocation(int pId)
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
		
		public string Address
		{
			get { return address; }
			set 
			{
			  if (value != null && value.Length > 50)
			    throw new ArgumentOutOfRangeException("Address", "Address value, cannot contain more than 50 characters");
			  _bIsChanged |= (address != value); 
			  address = value; 
			}
			
		}
		
		public int Parentid
		{
			get { return parentid; }
			set { _bIsChanged |= (parentid != value); parentid = value; }
			
		}
		
		public string Codenum
		{
			get { return codenum; }
			set 
			{
			  if (value != null && value.Length > 50)
			    throw new ArgumentOutOfRangeException("Codenum", "Codenum value, cannot contain more than 50 characters");
			  _bIsChanged |= (codenum != value); 
			  codenum = value; 
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
	
	#region Custom ICollection interface for LabLocation 

	
	public interface ILabLocationCollection : ICollection
	{
		LabLocation this[int index]{	get; set; }
		void Add(LabLocation pLabLocation);
		void Clear();
	}
	
	[Serializable]
	public class LabLocationCollection : ILabLocationCollection
	{
		private IList<LabLocation> _arrayInternal;

		public LabLocationCollection()
		{
			_arrayInternal = new List<LabLocation>();
		}
		
		public LabLocationCollection( IList<LabLocation> pSource )
		{
			_arrayInternal = pSource;
			if(_arrayInternal == null)
			{
				_arrayInternal = new List<LabLocation>();
			}
		}

		public LabLocation this[int index]
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
		public void CopyTo(Array array, int index){ _arrayInternal.CopyTo((LabLocation[])array, index); }
		public IEnumerator GetEnumerator() { return _arrayInternal.GetEnumerator(); }
		public void Add(LabLocation pLabLocation) { _arrayInternal.Add(pLabLocation); }
		public void Clear() { _arrayInternal.Clear(); }
		public IList<LabLocation> GetList() { return _arrayInternal; }
	 }
	
	#endregion
}
