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
	/// IAsstsOfficelist interface for NHibernate mapped table 'assts_officelist'.
	/// </summary>
	public interface IAsstsOfficelist
	{
		#region Public Properties
		
		double Id
		{
			get ;
			set ;
			  
		}
		
		double Address
		{
			get ;
			set ;
			  
		}
		
		string Title
		{
			get ;
			set ;
			  
		}
		
		double Num
		{
			get ;
			set ;
			  
		}
		
		string Menber
		{
			get ;
			set ;
			  
		}
		
		string F6
		{
			get ;
			set ;
			  
		}
		
		string F7
		{
			get ;
			set ;
			  
		}
		
		bool IsDeleted { get; set; }
		bool IsChanged { get; set; }
		
		#endregion 
	}

	/// <summary>
	/// AsstsOfficelist object for NHibernate mapped table 'assts_officelist'.
	/// </summary>
	[Serializable]
	public class AsstsOfficelist : IAsstsOfficelist
	{
		#region Member Variables

		protected double id;
		protected double address;
		protected string title;
		protected double num;
		protected string menber;
		protected string f6;
		protected string f7;
		protected bool _bIsDeleted;
		protected bool _bIsChanged;
		#endregion
		
		#region Constructors
		public AsstsOfficelist() {}
		
		public AsstsOfficelist(double pId, double pAddress, string pTitle, double pNum, string pMenber, string pF6, string pF7)
		{
			this.id = pId; 
			this.address = pAddress; 
			this.title = pTitle; 
			this.num = pNum; 
			this.menber = pMenber; 
			this.f6 = pF6; 
			this.f7 = pF7; 
		}
		
		#endregion
		
		#region Public Properties
		
		public double Id
		{
			get { return id; }
			set { _bIsChanged |= (id != value); id = value; }
			
		}
		
		public double Address
		{
			get { return address; }
			set { _bIsChanged |= (address != value); address = value; }
			
		}
		
		public string Title
		{
			get { return title; }
			set 
			{
			  if (value != null && value.Length > 255)
			    throw new ArgumentOutOfRangeException("Title", "Title value, cannot contain more than 255 characters");
			  _bIsChanged |= (title != value); 
			  title = value; 
			}
			
		}
		
		public double Num
		{
			get { return num; }
			set { _bIsChanged |= (num != value); num = value; }
			
		}
		
		public string Menber
		{
			get { return menber; }
			set 
			{
			  if (value != null && value.Length > 255)
			    throw new ArgumentOutOfRangeException("Menber", "Menber value, cannot contain more than 255 characters");
			  _bIsChanged |= (menber != value); 
			  menber = value; 
			}
			
		}
		
		public string F6
		{
			get { return f6; }
			set 
			{
			  if (value != null && value.Length > 255)
			    throw new ArgumentOutOfRangeException("F6", "F6 value, cannot contain more than 255 characters");
			  _bIsChanged |= (f6 != value); 
			  f6 = value; 
			}
			
		}
		
		public string F7
		{
			get { return f7; }
			set 
			{
			  if (value != null && value.Length > 255)
			    throw new ArgumentOutOfRangeException("F7", "F7 value, cannot contain more than 255 characters");
			  _bIsChanged |= (f7 != value); 
			  f7 = value; 
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
	
	#region Custom ICollection interface for AsstsOfficelist 

	
	public interface IAsstsOfficelistCollection : ICollection
	{
		AsstsOfficelist this[int index]{	get; set; }
		void Add(AsstsOfficelist pAsstsOfficelist);
		void Clear();
	}
	
	[Serializable]
	public class AsstsOfficelistCollection : IAsstsOfficelistCollection
	{
		private IList<AsstsOfficelist> _arrayInternal;

		public AsstsOfficelistCollection()
		{
			_arrayInternal = new List<AsstsOfficelist>();
		}
		
		public AsstsOfficelistCollection( IList<AsstsOfficelist> pSource )
		{
			_arrayInternal = pSource;
			if(_arrayInternal == null)
			{
				_arrayInternal = new List<AsstsOfficelist>();
			}
		}

		public AsstsOfficelist this[int index]
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
		public void CopyTo(Array array, int index){ _arrayInternal.CopyTo((AsstsOfficelist[])array, index); }
		public IEnumerator GetEnumerator() { return _arrayInternal.GetEnumerator(); }
		public void Add(AsstsOfficelist pAsstsOfficelist) { _arrayInternal.Add(pAsstsOfficelist); }
		public void Clear() { _arrayInternal.Clear(); }
		public IList<AsstsOfficelist> GetList() { return _arrayInternal; }
	 }
	
	#endregion
}
