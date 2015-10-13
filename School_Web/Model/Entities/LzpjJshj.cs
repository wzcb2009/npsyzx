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
	/// ILzpjJshj interface for NHibernate mapped table 'lzpj_jshj'.
	/// </summary>
	public interface ILzpjJshj
	{
		#region Public Properties
		
		int Id
		{
			get ;
			set ;
			  
		}
		
		string Title
		{
			get ;
			set ;
			  
		}
		
		int Year
		{
			get ;
			set ;
			  
		}
		
		string Dj
		{
			get ;
			set ;
			  
		}
		
		string Jb
		{
			get ;
			set ;
			  
		}
		
		string Casename
		{
			get ;
			set ;
			  
		}
		
		string Typename
		{
			get ;
			set ;
			  
		}
		
		int Userid
		{
			get ;
			set ;
			  
		}
		
		bool IsDeleted { get; set; }
		bool IsChanged { get; set; }
		
		#endregion 
	}

	/// <summary>
	/// LzpjJshj object for NHibernate mapped table 'lzpj_jshj'.
	/// </summary>
	[Serializable]
	public class LzpjJshj : ILzpjJshj
	{
		#region Member Variables

		protected int id;
		protected string title;
		protected int year;
		protected string dj;
		protected string jb;
		protected string casename;
		protected string typename;
		protected int userid;
		protected bool _bIsDeleted;
		protected bool _bIsChanged;
		#endregion
		
		#region Constructors
		public LzpjJshj() {}
		
		public LzpjJshj(string pTitle, int pYear, string pDj, string pJb, string pCasename, string pTypename, int pUserid)
		{
			this.title = pTitle; 
			this.year = pYear; 
			this.dj = pDj; 
			this.jb = pJb; 
			this.casename = pCasename; 
			this.typename = pTypename; 
			this.userid = pUserid; 
		}
		
		public LzpjJshj(int pId)
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
		
		public int Year
		{
			get { return year; }
			set { _bIsChanged |= (year != value); year = value; }
			
		}
		
		public string Dj
		{
			get { return dj; }
			set 
			{
			  if (value != null && value.Length > 50)
			    throw new ArgumentOutOfRangeException("Dj", "Dj value, cannot contain more than 50 characters");
			  _bIsChanged |= (dj != value); 
			  dj = value; 
			}
			
		}
		
		public string Jb
		{
			get { return jb; }
			set 
			{
			  if (value != null && value.Length > 50)
			    throw new ArgumentOutOfRangeException("Jb", "Jb value, cannot contain more than 50 characters");
			  _bIsChanged |= (jb != value); 
			  jb = value; 
			}
			
		}
		
		public string Casename
		{
			get { return casename; }
			set 
			{
			  if (value != null && value.Length > 50)
			    throw new ArgumentOutOfRangeException("Casename", "Casename value, cannot contain more than 50 characters");
			  _bIsChanged |= (casename != value); 
			  casename = value; 
			}
			
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
		
		public int Userid
		{
			get { return userid; }
			set { _bIsChanged |= (userid != value); userid = value; }
			
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
	
	#region Custom ICollection interface for LzpjJshj 

	
	public interface ILzpjJshjCollection : ICollection
	{
		LzpjJshj this[int index]{	get; set; }
		void Add(LzpjJshj pLzpjJshj);
		void Clear();
	}
	
	[Serializable]
	public class LzpjJshjCollection : ILzpjJshjCollection
	{
		private IList<LzpjJshj> _arrayInternal;

		public LzpjJshjCollection()
		{
			_arrayInternal = new List<LzpjJshj>();
		}
		
		public LzpjJshjCollection( IList<LzpjJshj> pSource )
		{
			_arrayInternal = pSource;
			if(_arrayInternal == null)
			{
				_arrayInternal = new List<LzpjJshj>();
			}
		}

		public LzpjJshj this[int index]
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
		public void CopyTo(Array array, int index){ _arrayInternal.CopyTo((LzpjJshj[])array, index); }
		public IEnumerator GetEnumerator() { return _arrayInternal.GetEnumerator(); }
		public void Add(LzpjJshj pLzpjJshj) { _arrayInternal.Add(pLzpjJshj); }
		public void Clear() { _arrayInternal.Clear(); }
		public IList<LzpjJshj> GetList() { return _arrayInternal; }
	 }
	
	#endregion
}
