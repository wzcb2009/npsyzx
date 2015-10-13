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
	/// ILzpjTermZyType interface for NHibernate mapped table 'lzpj_Term_zy_Type'.
	/// </summary>
	public interface ILzpjTermZyType
	{
		#region Public Properties
		
		int Id
		{
			get ;
			set ;
			  
		}
		
		string TypeName
		{
			get ;
			set ;
			  
		}
		
		string Menuurl
		{
			get ;
			set ;
			  
		}
		
		bool IsDeleted { get; set; }
		bool IsChanged { get; set; }
		
		#endregion 
	}

	/// <summary>
	/// LzpjTermZyType object for NHibernate mapped table 'lzpj_Term_zy_Type'.
	/// </summary>
	[Serializable]
	public class LzpjTermZyType : ILzpjTermZyType
	{
		#region Member Variables

		protected int id;
		protected string typename;
		protected string menuurl;
		protected bool _bIsDeleted;
		protected bool _bIsChanged;
		#endregion
		
		#region Constructors
		public LzpjTermZyType() {}
		
		public LzpjTermZyType(int pId, string pTypeName, string pMenuurl)
		{
			this.id = pId; 
			this.typename = pTypeName; 
			this.menuurl = pMenuurl; 
		}
		
		public LzpjTermZyType(int pId)
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
		
		public string TypeName
		{
			get { return typename; }
			set 
			{
			  if (value != null && value.Length > 50)
			    throw new ArgumentOutOfRangeException("TypeName", "TypeName value, cannot contain more than 50 characters");
			  _bIsChanged |= (typename != value); 
			  typename = value; 
			}
			
		}
		
		public string Menuurl
		{
			get { return menuurl; }
			set 
			{
			  if (value != null && value.Length > 50)
			    throw new ArgumentOutOfRangeException("Menuurl", "Menuurl value, cannot contain more than 50 characters");
			  _bIsChanged |= (menuurl != value); 
			  menuurl = value; 
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
	
	#region Custom ICollection interface for LzpjTermZyType 

	
	public interface ILzpjTermZyTypeCollection : ICollection
	{
		LzpjTermZyType this[int index]{	get; set; }
		void Add(LzpjTermZyType pLzpjTermZyType);
		void Clear();
	}
	
	[Serializable]
	public class LzpjTermZyTypeCollection : ILzpjTermZyTypeCollection
	{
		private IList<LzpjTermZyType> _arrayInternal;

		public LzpjTermZyTypeCollection()
		{
			_arrayInternal = new List<LzpjTermZyType>();
		}
		
		public LzpjTermZyTypeCollection( IList<LzpjTermZyType> pSource )
		{
			_arrayInternal = pSource;
			if(_arrayInternal == null)
			{
				_arrayInternal = new List<LzpjTermZyType>();
			}
		}

		public LzpjTermZyType this[int index]
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
		public void CopyTo(Array array, int index){ _arrayInternal.CopyTo((LzpjTermZyType[])array, index); }
		public IEnumerator GetEnumerator() { return _arrayInternal.GetEnumerator(); }
		public void Add(LzpjTermZyType pLzpjTermZyType) { _arrayInternal.Add(pLzpjTermZyType); }
		public void Clear() { _arrayInternal.Clear(); }
		public IList<LzpjTermZyType> GetList() { return _arrayInternal; }
	 }
	
	#endregion
}
