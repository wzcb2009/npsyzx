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
	/// IExamType interface for NHibernate mapped table 'Exam_Type'.
	/// </summary>
	public interface IExamType
	{
		#region Public Properties
		
		int ExamTypeId
		{
			get ;
			set ;
			  
		}
		
		string TypeName
		{
			get ;
			set ;
			  
		}
		
		bool IsDeleted { get; set; }
		bool IsChanged { get; set; }
		
		#endregion 
	}

	/// <summary>
	/// ExamType object for NHibernate mapped table 'Exam_Type'.
	/// </summary>
	[Serializable]
	public class ExamType : IExamType
	{
		#region Member Variables

		protected int examtypeid;
		protected string typename;
		protected bool _bIsDeleted;
		protected bool _bIsChanged;
		#endregion
		
		#region Constructors
		public ExamType() {}
		
		public ExamType(int pExamTypeId, string pTypeName)
		{
			this.examtypeid = pExamTypeId; 
			this.typename = pTypeName; 
		}
		
		public ExamType(int pExamTypeId)
		{
			this.examtypeid = pExamTypeId; 
		}
		
		#endregion
		
		#region Public Properties
		
		public int ExamTypeId
		{
			get { return examtypeid; }
			set { _bIsChanged |= (examtypeid != value); examtypeid = value; }
			
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
	
	#region Custom ICollection interface for ExamType 

	
	public interface IExamTypeCollection : ICollection
	{
		ExamType this[int index]{	get; set; }
		void Add(ExamType pExamType);
		void Clear();
	}
	
	[Serializable]
	public class ExamTypeCollection : IExamTypeCollection
	{
		private IList<ExamType> _arrayInternal;

		public ExamTypeCollection()
		{
			_arrayInternal = new List<ExamType>();
		}
		
		public ExamTypeCollection( IList<ExamType> pSource )
		{
			_arrayInternal = pSource;
			if(_arrayInternal == null)
			{
				_arrayInternal = new List<ExamType>();
			}
		}

		public ExamType this[int index]
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
		public void CopyTo(Array array, int index){ _arrayInternal.CopyTo((ExamType[])array, index); }
		public IEnumerator GetEnumerator() { return _arrayInternal.GetEnumerator(); }
		public void Add(ExamType pExamType) { _arrayInternal.Add(pExamType); }
		public void Clear() { _arrayInternal.Clear(); }
		public IList<ExamType> GetList() { return _arrayInternal; }
	 }
	
	#endregion
}
