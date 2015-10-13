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
	/// ILzpjUserRight interface for NHibernate mapped table 'lzpj_user_right'.
	/// </summary>
	public interface ILzpjUserRight
	{
		#region Public Properties
		
		int Id
		{
			get ;
			set ;
			  
		}
		
		int MagUserid
		{
			get ;
			set ;
			  
		}
		
		int Termid
		{
			get ;
			set ;
			  
		}
		
		int Subjectid
		{
			get ;
			set ;
			  
		}
		
		int Gradeid
		{
			get ;
			set ;
			  
		}
		
		bool IsDeleted { get; set; }
		bool IsChanged { get; set; }
		
		#endregion 
	}

	/// <summary>
	/// LzpjUserRight object for NHibernate mapped table 'lzpj_user_right'.
	/// </summary>
	[Serializable]
	public class LzpjUserRight : ILzpjUserRight
	{
		#region Member Variables

		protected int id;
		protected int maguserid;
		protected int termid;
		protected int subjectid;
		protected int gradeid;
		protected bool _bIsDeleted;
		protected bool _bIsChanged;
		#endregion
		
		#region Constructors
		public LzpjUserRight() {}
		
		public LzpjUserRight(int pMagUserid, int pTermid, int pSubjectid, int pGradeid)
		{
			this.maguserid = pMagUserid; 
			this.termid = pTermid; 
			this.subjectid = pSubjectid; 
			this.gradeid = pGradeid; 
		}
		
		#endregion
		
		#region Public Properties
		
		public int Id
		{
			get { return id; }
			set { _bIsChanged |= (id != value); id = value; }
			
		}
		
		public int MagUserid
		{
			get { return maguserid; }
			set { _bIsChanged |= (maguserid != value); maguserid = value; }
			
		}
		
		public int Termid
		{
			get { return termid; }
			set { _bIsChanged |= (termid != value); termid = value; }
			
		}
		
		public int Subjectid
		{
			get { return subjectid; }
			set { _bIsChanged |= (subjectid != value); subjectid = value; }
			
		}
		
		public int Gradeid
		{
			get { return gradeid; }
			set { _bIsChanged |= (gradeid != value); gradeid = value; }
			
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
	
	#region Custom ICollection interface for LzpjUserRight 

	
	public interface ILzpjUserRightCollection : ICollection
	{
		LzpjUserRight this[int index]{	get; set; }
		void Add(LzpjUserRight pLzpjUserRight);
		void Clear();
	}
	
	[Serializable]
	public class LzpjUserRightCollection : ILzpjUserRightCollection
	{
		private IList<LzpjUserRight> _arrayInternal;

		public LzpjUserRightCollection()
		{
			_arrayInternal = new List<LzpjUserRight>();
		}
		
		public LzpjUserRightCollection( IList<LzpjUserRight> pSource )
		{
			_arrayInternal = pSource;
			if(_arrayInternal == null)
			{
				_arrayInternal = new List<LzpjUserRight>();
			}
		}

		public LzpjUserRight this[int index]
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
		public void CopyTo(Array array, int index){ _arrayInternal.CopyTo((LzpjUserRight[])array, index); }
		public IEnumerator GetEnumerator() { return _arrayInternal.GetEnumerator(); }
		public void Add(LzpjUserRight pLzpjUserRight) { _arrayInternal.Add(pLzpjUserRight); }
		public void Clear() { _arrayInternal.Clear(); }
		public IList<LzpjUserRight> GetList() { return _arrayInternal; }
	 }
	
	#endregion
}
