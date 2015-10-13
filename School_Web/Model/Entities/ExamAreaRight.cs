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
	/// IExamAreaRight interface for NHibernate mapped table 'Exam_area_right'.
	/// </summary>
	public interface IExamAreaRight
	{
		#region Public Properties
		
		int Id
		{
			get ;
			set ;
			  
		}
		
		int Areaid
		{
			get ;
			set ;
			  
		}
		
		int ByteacherId
		{
			get ;
			set ;
			  
		}
		
		bool IsDeleted { get; set; }
		bool IsChanged { get; set; }
		
		#endregion 
	}

	/// <summary>
	/// ExamAreaRight object for NHibernate mapped table 'Exam_area_right'.
	/// </summary>
	[Serializable]
	public class ExamAreaRight : IExamAreaRight
	{
		#region Member Variables

		protected int id;
		protected int areaid;
		protected int byteacherid;
		protected bool _bIsDeleted;
		protected bool _bIsChanged;
		#endregion
		
		#region Constructors
		public ExamAreaRight() {}
		
		public ExamAreaRight(int pAreaid, int pByteacherId)
		{
			this.areaid = pAreaid; 
			this.byteacherid = pByteacherId; 
		}
		
		#endregion
		
		#region Public Properties
		
		public int Id
		{
			get { return id; }
			set { _bIsChanged |= (id != value); id = value; }
			
		}
		
		public int Areaid
		{
			get { return areaid; }
			set { _bIsChanged |= (areaid != value); areaid = value; }
			
		}
		
		public int ByteacherId
		{
			get { return byteacherid; }
			set { _bIsChanged |= (byteacherid != value); byteacherid = value; }
			
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
	
	#region Custom ICollection interface for ExamAreaRight 

	
	public interface IExamAreaRightCollection : ICollection
	{
		ExamAreaRight this[int index]{	get; set; }
		void Add(ExamAreaRight pExamAreaRight);
		void Clear();
	}
	
	[Serializable]
	public class ExamAreaRightCollection : IExamAreaRightCollection
	{
		private IList<ExamAreaRight> _arrayInternal;

		public ExamAreaRightCollection()
		{
			_arrayInternal = new List<ExamAreaRight>();
		}
		
		public ExamAreaRightCollection( IList<ExamAreaRight> pSource )
		{
			_arrayInternal = pSource;
			if(_arrayInternal == null)
			{
				_arrayInternal = new List<ExamAreaRight>();
			}
		}

		public ExamAreaRight this[int index]
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
		public void CopyTo(Array array, int index){ _arrayInternal.CopyTo((ExamAreaRight[])array, index); }
		public IEnumerator GetEnumerator() { return _arrayInternal.GetEnumerator(); }
		public void Add(ExamAreaRight pExamAreaRight) { _arrayInternal.Add(pExamAreaRight); }
		public void Clear() { _arrayInternal.Clear(); }
		public IList<ExamAreaRight> GetList() { return _arrayInternal; }
	 }
	
	#endregion
}
