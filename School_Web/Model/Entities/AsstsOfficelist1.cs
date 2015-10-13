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
	/// IAsstsOfficelist1 interface for NHibernate mapped table 'assts_officelist1'.
	/// </summary>
	public interface IAsstsOfficelist1
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
		
		bool IsDeleted { get; set; }
		bool IsChanged { get; set; }
		
		#endregion 
	}

	/// <summary>
	/// AsstsOfficelist1 object for NHibernate mapped table 'assts_officelist1'.
	/// </summary>
	[Serializable]
	public class AsstsOfficelist1 : IAsstsOfficelist1
	{
		#region Member Variables

		protected double id;
		protected double address;
		protected string title;
		protected double num;
		protected string menber;
		protected bool _bIsDeleted;
		protected bool _bIsChanged;
		#endregion
		
		#region Constructors
		public AsstsOfficelist1() {}
		
		public AsstsOfficelist1(double pId, double pAddress, string pTitle, double pNum, string pMenber)
		{
			this.id = pId; 
			this.address = pAddress; 
			this.title = pTitle; 
			this.num = pNum; 
			this.menber = pMenber; 
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
	
	#region Custom ICollection interface for AsstsOfficelist1 

	
	public interface IAsstsOfficelist1Collection : ICollection
	{
		AsstsOfficelist1 this[int index]{	get; set; }
		void Add(AsstsOfficelist1 pAsstsOfficelist1);
		void Clear();
	}
	
	[Serializable]
	public class AsstsOfficelist1Collection : IAsstsOfficelist1Collection
	{
		private IList<AsstsOfficelist1> _arrayInternal;

		public AsstsOfficelist1Collection()
		{
			_arrayInternal = new List<AsstsOfficelist1>();
		}
		
		public AsstsOfficelist1Collection( IList<AsstsOfficelist1> pSource )
		{
			_arrayInternal = pSource;
			if(_arrayInternal == null)
			{
				_arrayInternal = new List<AsstsOfficelist1>();
			}
		}

		public AsstsOfficelist1 this[int index]
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
		public void CopyTo(Array array, int index){ _arrayInternal.CopyTo((AsstsOfficelist1[])array, index); }
		public IEnumerator GetEnumerator() { return _arrayInternal.GetEnumerator(); }
		public void Add(AsstsOfficelist1 pAsstsOfficelist1) { _arrayInternal.Add(pAsstsOfficelist1); }
		public void Clear() { _arrayInternal.Clear(); }
		public IList<AsstsOfficelist1> GetList() { return _arrayInternal; }
	 }
	
	#endregion
}
