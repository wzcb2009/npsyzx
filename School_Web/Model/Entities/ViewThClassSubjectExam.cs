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
	/// IViewThClassSubjectExam interface for NHibernate mapped table 'View_THClassSubjectExam'.
	/// </summary>
	public interface IViewThClassSubjectExam
	{
		#region Public Properties
		
		int ClassId
		{
			get ;
		}
		
		int ActiveCaseId
		{
			get ;
		}
		
		int Activeid
		{
			get ;
		}
		
		int Id
		{
			get ;
		}
		
		int GradeId
		{
			get ;
		}
		
		int CaseId
		{
			get ;
		}
		
		int Cent
		{
			get ;
		}
		
		int PercentNum
		{
			get ;
		}
		
		bool TotalFlag
		{
			get ;
		}
		
		string Title
		{
			get ;
		}
		
		string Remark
		{
			get ;
		}
		
		int Termid
		{
			get ;
		}
		
		int UserId
		{
			get ;
		}
		
		bool Status
		{
			get ;
		}
		
		bool IsAdmin
		{
			get ;
		}
		
		bool IsDeleted { get; set; }
		bool IsChanged { get; set; }
		
		#endregion 
	}

	/// <summary>
	/// ViewThClassSubjectExam object for NHibernate mapped table 'View_THClassSubjectExam'.
	/// </summary>
	[Serializable]
	public class ViewThClassSubjectExam : IViewThClassSubjectExam
	{
		#region Member Variables

		protected int classid;
		protected int activecaseid;
		protected int activeid;
		protected int id;
		protected int gradeid;
		protected int caseid;
		protected int cent;
		protected int percentnum;
		protected bool totalflag;
		protected string title;
		protected string remark;
		protected int termid;
		protected int userid;
		protected bool status;
		protected bool isadmin;
		protected bool _bIsDeleted;
		protected bool _bIsChanged;
		#endregion
		
		#region Constructors
		public ViewThClassSubjectExam() {}
		
		#endregion
		
		#region Public Properties
		
		public int ClassId
		{
			get { return classid; }
		}
		
		public int ActiveCaseId
		{
			get { return activecaseid; }
		}
		
		public int Activeid
		{
			get { return activeid; }
		}
		
		public int Id
		{
			get { return id; }
		}
		
		public int GradeId
		{
			get { return gradeid; }
		}
		
		public int CaseId
		{
			get { return caseid; }
		}
		
		public int Cent
		{
			get { return cent; }
		}
		
		public int PercentNum
		{
			get { return percentnum; }
		}
		
		public bool TotalFlag
		{
			get { return totalflag; }
		}
		
		public string Title
		{
			get { return title; }
		}
		
		public string Remark
		{
			get { return remark; }
		}
		
		public int Termid
		{
			get { return termid; }
		}
		
		public int UserId
		{
			get { return userid; }
		}
		
		public bool Status
		{
			get { return status; }
		}
		
		public bool IsAdmin
		{
			get { return isadmin; }
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
	
	#region Custom ICollection interface for ViewThClassSubjectExam 

	
	public interface IViewThClassSubjectExamCollection : ICollection
	{
		ViewThClassSubjectExam this[int index]{	get; set; }
		void Add(ViewThClassSubjectExam pViewThClassSubjectExam);
		void Clear();
	}
	
	[Serializable]
	public class ViewThClassSubjectExamCollection : IViewThClassSubjectExamCollection
	{
		private IList<ViewThClassSubjectExam> _arrayInternal;

		public ViewThClassSubjectExamCollection()
		{
			_arrayInternal = new List<ViewThClassSubjectExam>();
		}
		
		public ViewThClassSubjectExamCollection( IList<ViewThClassSubjectExam> pSource )
		{
			_arrayInternal = pSource;
			if(_arrayInternal == null)
			{
				_arrayInternal = new List<ViewThClassSubjectExam>();
			}
		}

		public ViewThClassSubjectExam this[int index]
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
		public void CopyTo(Array array, int index){ _arrayInternal.CopyTo((ViewThClassSubjectExam[])array, index); }
		public IEnumerator GetEnumerator() { return _arrayInternal.GetEnumerator(); }
		public void Add(ViewThClassSubjectExam pViewThClassSubjectExam) { _arrayInternal.Add(pViewThClassSubjectExam); }
		public void Clear() { _arrayInternal.Clear(); }
		public IList<ViewThClassSubjectExam> GetList() { return _arrayInternal; }
	 }
	
	#endregion
}
