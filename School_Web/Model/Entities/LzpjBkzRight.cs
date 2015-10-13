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
	/// ILzpjBkzRight interface for NHibernate mapped table 'lzpj_bkz_right'.
	/// </summary>
	public interface ILzpjBkzRight
	{
		#region Public Properties
		
		int Id
		{
			get ;
			set ;
			  
		}
		
		int Termid
		{
			get ;
			set ;
			  
		}
		
		int Gradeid
		{
			get ;
			set ;
			  
		}
		
		int Subjectid
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
	/// LzpjBkzRight object for NHibernate mapped table 'lzpj_bkz_right'.
	/// </summary>
	[Serializable]
	public class LzpjBkzRight : ILzpjBkzRight
	{
		#region Member Variables

		protected int id;
		protected int termid;
		protected int gradeid;
		protected int subjectid;
		protected int userid;
		protected bool _bIsDeleted;
		protected bool _bIsChanged;
		#endregion
		
		#region Constructors
		public LzpjBkzRight() {}
		
		public LzpjBkzRight(int pTermid, int pGradeid, int pSubjectid, int pUserid)
		{
			this.termid = pTermid; 
			this.gradeid = pGradeid; 
			this.subjectid = pSubjectid; 
			this.userid = pUserid; 
		}
		
		public LzpjBkzRight(int pId)
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
		
		public int Termid
		{
			get { return termid; }
			set { _bIsChanged |= (termid != value); termid = value; }
			
		}
		
		public int Gradeid
		{
			get { return gradeid; }
			set { _bIsChanged |= (gradeid != value); gradeid = value; }
			
		}
		
		public int Subjectid
		{
			get { return subjectid; }
			set { _bIsChanged |= (subjectid != value); subjectid = value; }
			
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
	
	#region Custom ICollection interface for LzpjBkzRight 

	
	public interface ILzpjBkzRightCollection : ICollection
	{
		LzpjBkzRight this[int index]{	get; set; }
		void Add(LzpjBkzRight pLzpjBkzRight);
		void Clear();
	}
	
	[Serializable]
	public class LzpjBkzRightCollection : ILzpjBkzRightCollection
	{
		private IList<LzpjBkzRight> _arrayInternal;

		public LzpjBkzRightCollection()
		{
			_arrayInternal = new List<LzpjBkzRight>();
		}
		
		public LzpjBkzRightCollection( IList<LzpjBkzRight> pSource )
		{
			_arrayInternal = pSource;
			if(_arrayInternal == null)
			{
				_arrayInternal = new List<LzpjBkzRight>();
			}
		}

		public LzpjBkzRight this[int index]
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
		public void CopyTo(Array array, int index){ _arrayInternal.CopyTo((LzpjBkzRight[])array, index); }
		public IEnumerator GetEnumerator() { return _arrayInternal.GetEnumerator(); }
		public void Add(LzpjBkzRight pLzpjBkzRight) { _arrayInternal.Add(pLzpjBkzRight); }
		public void Clear() { _arrayInternal.Clear(); }
		public IList<LzpjBkzRight> GetList() { return _arrayInternal; }
	 }
	
	#endregion
}
