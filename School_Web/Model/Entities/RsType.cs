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
	/// IRsType interface for NHibernate mapped table 'RS_Type'.
	/// </summary>
	public interface IRsType
	{
		#region Public Properties
		
		int Id
		{
			get ;
			set ;
			  
		}
		
		string Typename
		{
			get ;
			set ;
			  
		}
		
		int Parentid
		{
			get ;
			set ;
			  
		}
		
		int Depth
		{
			get ;
			set ;
			  
		}
		
		bool IsDeleted { get; set; }
		bool IsChanged { get; set; }
		
		#endregion 
	}

	/// <summary>
	/// RsType object for NHibernate mapped table 'RS_Type'.
	/// </summary>
	[Serializable]
	public class RsType : IRsType
	{
		#region Member Variables

		protected int id;
		protected string typename;
		protected int parentid;
		protected int depth;
		protected bool _bIsDeleted;
		protected bool _bIsChanged;
		#endregion
		
		#region Constructors
		public RsType() {}
		
		public RsType(string pTypename, int pParentid, int pDepth)
		{
			this.typename = pTypename; 
			this.parentid = pParentid; 
			this.depth = pDepth; 
		}
		
		#endregion
		
		#region Public Properties
		
		public int Id
		{
			get { return id; }
			set { _bIsChanged |= (id != value); id = value; }
			
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
		
		public int Parentid
		{
			get { return parentid; }
			set { _bIsChanged |= (parentid != value); parentid = value; }
			
		}
		
		public int Depth
		{
			get { return depth; }
			set { _bIsChanged |= (depth != value); depth = value; }
			
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
	
	#region Custom ICollection interface for RsType 

	
	public interface IRsTypeCollection : ICollection
	{
		RsType this[int index]{	get; set; }
		void Add(RsType pRsType);
		void Clear();
	}
	
	[Serializable]
	public class RsTypeCollection : IRsTypeCollection
	{
		private IList<RsType> _arrayInternal;

		public RsTypeCollection()
		{
			_arrayInternal = new List<RsType>();
		}
		
		public RsTypeCollection( IList<RsType> pSource )
		{
			_arrayInternal = pSource;
			if(_arrayInternal == null)
			{
				_arrayInternal = new List<RsType>();
			}
		}

		public RsType this[int index]
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
		public void CopyTo(Array array, int index){ _arrayInternal.CopyTo((RsType[])array, index); }
		public IEnumerator GetEnumerator() { return _arrayInternal.GetEnumerator(); }
		public void Add(RsType pRsType) { _arrayInternal.Add(pRsType); }
		public void Clear() { _arrayInternal.Clear(); }
		public IList<RsType> GetList() { return _arrayInternal; }
	 }
	
	#endregion
}
