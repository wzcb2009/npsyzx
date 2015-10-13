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
	/// Ilzpj_jshj interface for NHibernate mapped table 'lzpj_jshj'.
	/// </summary>
	public interface Ilzpj_jshj
	{
		#region Public Properties
		
		int id
		{
			get ;
			set ;
			  
		}
		
		string title
		{
			get ;
			set ;
			  
		}
		
		int year
		{
			get ;
			set ;
			  
		}
		
		string dj
		{
			get ;
			set ;
			  
		}
		
		string jb
		{
			get ;
			set ;
			  
		}
		
		string casename
		{
			get ;
			set ;
			  
		}
		
		string typename
		{
			get ;
			set ;
			  
		}
		
		int userid
		{
			get ;
			set ;
			  
		}
		
		bool IsDeleted { get; set; }
		bool IsChanged { get; set; }
		
		#endregion 
	}

	/// <summary>
	/// lzpj_jshj object for NHibernate mapped table 'lzpj_jshj'.
	/// </summary>
	[Serializable]
	public class lzpj_jshj : Ilzpj_jshj
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
		public lzpj_jshj() {}
		
		public lzpj_jshj(string pTitle, int pYear, string pDj, string pJb, string pCasename, string pTypename, int pUserid)
		{
			this.title = pTitle; 
			this.year = pYear; 
			this.dj = pDj; 
			this.jb = pJb; 
			this.casename = pCasename; 
			this.typename = pTypename; 
			this.userid = pUserid; 
		}
		
		public lzpj_jshj(int pId)
		{
			this.id = pId; 
		}
		
		#endregion
		
		#region Public Properties
		
		public virtual int id
		{
			get { return id; }
			set { _bIsChanged |= (id != value); id = value; }
			
		}
		
		public virtual string title
		{
			get { return title; }
			set 
			{
			  if (value != null && value.Length > 50)
			    throw new ArgumentOutOfRangeException("title", "title value, cannot contain more than 50 characters");
			  _bIsChanged |= (title != value); 
			  title = value; 
			}
			
		}
		
		public virtual int year
		{
			get { return year; }
			set { _bIsChanged |= (year != value); year = value; }
			
		}
		
		public virtual string dj
		{
			get { return dj; }
			set 
			{
			  if (value != null && value.Length > 50)
			    throw new ArgumentOutOfRangeException("dj", "dj value, cannot contain more than 50 characters");
			  _bIsChanged |= (dj != value); 
			  dj = value; 
			}
			
		}
		
		public virtual string jb
		{
			get { return jb; }
			set 
			{
			  if (value != null && value.Length > 50)
			    throw new ArgumentOutOfRangeException("jb", "jb value, cannot contain more than 50 characters");
			  _bIsChanged |= (jb != value); 
			  jb = value; 
			}
			
		}
		
		public virtual string casename
		{
			get { return casename; }
			set 
			{
			  if (value != null && value.Length > 50)
			    throw new ArgumentOutOfRangeException("casename", "casename value, cannot contain more than 50 characters");
			  _bIsChanged |= (casename != value); 
			  casename = value; 
			}
			
		}
		
		public virtual string typename
		{
			get { return typename; }
			set 
			{
			  if (value != null && value.Length > 50)
			    throw new ArgumentOutOfRangeException("typename", "typename value, cannot contain more than 50 characters");
			  _bIsChanged |= (typename != value); 
			  typename = value; 
			}
			
		}
		
		public virtual int userid
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
	
	#region Custom ICollection interface for lzpj_jshj 

	
	public interface Ilzpj_jshjCollection : ICollection
	{
		lzpj_jshj this[int index]{	get; set; }
		void Add(lzpj_jshj plzpj_jshj);
		void Clear();
	}
	
	[Serializable]
	public class lzpj_jshjCollection : Ilzpj_jshjCollection
	{
		private IList<lzpj_jshj> _arrayInternal;

		public lzpj_jshjCollection()
		{
			_arrayInternal = new List<lzpj_jshj>();
		}
		
		public lzpj_jshjCollection( IList<lzpj_jshj> pSource )
		{
			_arrayInternal = pSource;
			if(_arrayInternal == null)
			{
				_arrayInternal = new List<lzpj_jshj>();
			}
		}

		public lzpj_jshj this[int index]
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
		public void CopyTo(Array array, int index){ _arrayInternal.CopyTo((lzpj_jshj[])array, index); }
		public IEnumerator GetEnumerator() { return _arrayInternal.GetEnumerator(); }
		public void Add(lzpj_jshj plzpj_jshj) { _arrayInternal.Add(plzpj_jshj); }
		public void Clear() { _arrayInternal.Clear(); }
		public IList<lzpj_jshj> GetList() { return _arrayInternal; }
	 }
	
	#endregion
}
