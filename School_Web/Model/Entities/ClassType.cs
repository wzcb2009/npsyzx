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
	/// IClassType interface for NHibernate mapped table 'Class_type'.
	/// </summary>
	public interface IClassType
	{
		#region Public Properties
		
		int Schtypeid
		{
			get ;
			set ;
			  
		}
		
		string Typename
		{
			get ;
			set ;
			  
		}
		
		bool IsDeleted { get; set; }
		bool IsChanged { get; set; }
		
		#endregion 
	}

	/// <summary>
	/// ClassType object for NHibernate mapped table 'Class_type'.
	/// </summary>
	[Serializable]
	public class ClassType : IClassType
	{
		#region Member Variables

		protected int schtypeid;
		protected string typename;
		protected bool _bIsDeleted;
		protected bool _bIsChanged;
		#endregion
		
		#region Constructors
		public ClassType() {}
		
		public ClassType(string pTypename)
		{
			this.typename = pTypename; 
		}
		
		public ClassType(int pSchtypeid)
		{
			this.schtypeid = pSchtypeid; 
		}
		
		#endregion
		
		#region Public Properties
		
		public int Schtypeid
		{
			get { return schtypeid; }
			set { _bIsChanged |= (schtypeid != value); schtypeid = value; }
			
		}
		
		public string Typename
		{
			get { return typename; }
			set 
			{
			  if (value != null && value.Length > 50)
			    throw new ArgumentOutOfRangeException("Typename", "Typename value, cannot contain more than 50 characters");
			  _bIsChanged |= (typename != value); 
			  typename = value; 
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
	
	#region Custom ICollection interface for ClassType 

	
	public interface IClassTypeCollection : ICollection
	{
		ClassType this[int index]{	get; set; }
		void Add(ClassType pClassType);
		void Clear();
	}
	
	[Serializable]
	public class ClassTypeCollection : IClassTypeCollection
	{
		private IList<ClassType> _arrayInternal;

		public ClassTypeCollection()
		{
			_arrayInternal = new List<ClassType>();
		}
		
		public ClassTypeCollection( IList<ClassType> pSource )
		{
			_arrayInternal = pSource;
			if(_arrayInternal == null)
			{
				_arrayInternal = new List<ClassType>();
			}
		}

		public ClassType this[int index]
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
		public void CopyTo(Array array, int index){ _arrayInternal.CopyTo((ClassType[])array, index); }
		public IEnumerator GetEnumerator() { return _arrayInternal.GetEnumerator(); }
		public void Add(ClassType pClassType) { _arrayInternal.Add(pClassType); }
		public void Clear() { _arrayInternal.Clear(); }
		public IList<ClassType> GetList() { return _arrayInternal; }
	 }
	
	#endregion
}
