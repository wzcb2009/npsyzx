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
	/// IAsstsType interface for NHibernate mapped table 'Assts_type'.
	/// </summary>
	public interface IAsstsType
	{
		#region Public Properties
		
		int Typeid
		{
			get ;
			set ;
			  
		}
		
		string Typename
		{
			get ;
			set ;
			  
		}
		
		string About
		{
			get ;
			set ;
			  
		}
		
		bool IsDeleted { get; set; }
		bool IsChanged { get; set; }
		
		#endregion 
	}

	/// <summary>
	/// AsstsType object for NHibernate mapped table 'Assts_type'.
	/// </summary>
	[Serializable]
	public class AsstsType : IAsstsType
	{
		#region Member Variables

		protected int typeid;
		protected string typename;
		protected string about;
		protected bool _bIsDeleted;
		protected bool _bIsChanged;
		#endregion
		
		#region Constructors
		public AsstsType() {}
		
		public AsstsType(int pTypeid, string pTypename, string pAbout)
		{
			this.typeid = pTypeid; 
			this.typename = pTypename; 
			this.about = pAbout; 
		}
		
		public AsstsType(int pTypeid)
		{
			this.typeid = pTypeid; 
		}
		
		#endregion
		
		#region Public Properties
		
		public int Typeid
		{
			get { return typeid; }
			set { _bIsChanged |= (typeid != value); typeid = value; }
			
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
		
		public string About
		{
			get { return about; }
			set 
			{
			  if (value != null && value.Length > 50)
			    throw new ArgumentOutOfRangeException("About", "About value, cannot contain more than 50 characters");
			  _bIsChanged |= (about != value); 
			  about = value; 
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
	
	#region Custom ICollection interface for AsstsType 

	
	public interface IAsstsTypeCollection : ICollection
	{
		AsstsType this[int index]{	get; set; }
		void Add(AsstsType pAsstsType);
		void Clear();
	}
	
	[Serializable]
	public class AsstsTypeCollection : IAsstsTypeCollection
	{
		private IList<AsstsType> _arrayInternal;

		public AsstsTypeCollection()
		{
			_arrayInternal = new List<AsstsType>();
		}
		
		public AsstsTypeCollection( IList<AsstsType> pSource )
		{
			_arrayInternal = pSource;
			if(_arrayInternal == null)
			{
				_arrayInternal = new List<AsstsType>();
			}
		}

		public AsstsType this[int index]
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
		public void CopyTo(Array array, int index){ _arrayInternal.CopyTo((AsstsType[])array, index); }
		public IEnumerator GetEnumerator() { return _arrayInternal.GetEnumerator(); }
		public void Add(AsstsType pAsstsType) { _arrayInternal.Add(pAsstsType); }
		public void Clear() { _arrayInternal.Clear(); }
		public IList<AsstsType> GetList() { return _arrayInternal; }
	 }
	
	#endregion
}
