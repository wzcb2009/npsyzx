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
	/// ILabExperiment interface for NHibernate mapped table 'LabExperiment'.
	/// </summary>
	public interface ILabExperiment
	{
		#region Public Properties
		
		int Id
		{
			get ;
			set ;
			  
		}
		
		int CaseId
		{
			get ;
			set ;
			  
		}
		
		int SubjectId
		{
			get ;
			set ;
			  
		}
		
		int GradeId
		{
			get ;
			set ;
			  
		}
		
		DateTime Pubdate
		{
			get ;
			set ;
			  
		}
		
		bool Status
		{
			get ;
			set ;
			  
		}
		
		int Pindex
		{
			get ;
			set ;
			  
		}
		
		string Title
		{
			get ;
			set ;
			  
		}
		
		string Remark
		{
			get ;
			set ;
			  
		}
		
		string PicUrl
		{
			get ;
			set ;
			  
		}
		
		bool IsDeleted { get; set; }
		bool IsChanged { get; set; }
		
		#endregion 
	}

	/// <summary>
	/// LabExperiment object for NHibernate mapped table 'LabExperiment'.
	/// </summary>
	[Serializable]
	public class LabExperiment : ILabExperiment
	{
		#region Member Variables

		protected int id;
		protected int caseid;
		protected int subjectid;
		protected int gradeid;
		protected DateTime pubdate;
		protected bool status;
		protected int pindex;
		protected string title;
		protected string remark;
		protected string picurl;
		protected bool _bIsDeleted;
		protected bool _bIsChanged;
		#endregion
		
		#region Constructors
		public LabExperiment() {}
		
		public LabExperiment(int pCaseId, int pSubjectId, int pGradeId, DateTime pPubdate, bool pStatus, int pPindex, string pTitle, string pRemark, string pPicUrl)
		{
			this.caseid = pCaseId; 
			this.subjectid = pSubjectId; 
			this.gradeid = pGradeId; 
			this.pubdate = pPubdate; 
			this.status = pStatus; 
			this.pindex = pPindex; 
			this.title = pTitle; 
			this.remark = pRemark; 
			this.picurl = pPicUrl; 
		}
		
		public LabExperiment(int pId)
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
		
		public int CaseId
		{
			get { return caseid; }
			set { _bIsChanged |= (caseid != value); caseid = value; }
			
		}
		
		public int SubjectId
		{
			get { return subjectid; }
			set { _bIsChanged |= (subjectid != value); subjectid = value; }
			
		}
		
		public int GradeId
		{
			get { return gradeid; }
			set { _bIsChanged |= (gradeid != value); gradeid = value; }
			
		}
		
		public DateTime Pubdate
		{
			get { return pubdate; }
			set { _bIsChanged |= (pubdate != value); pubdate = value; }
			
		}
		
		public bool Status
		{
			get { return status; }
			set { _bIsChanged |= (status != value); status = value; }
			
		}
		
		public int Pindex
		{
			get { return pindex; }
			set { _bIsChanged |= (pindex != value); pindex = value; }
			
		}
		
		public string Title
		{
			get { return title; }
			set 
			{
			  if (value != null && value.Length > 250)
			    throw new ArgumentOutOfRangeException("Title", "Title value, cannot contain more than 250 characters");
			  _bIsChanged |= (title != value); 
			  title = value; 
			}
			
		}
		
		public string Remark
		{
			get { return remark; }
			set 
			{
			  if (value != null && value.Length > 1073741823)
			    throw new ArgumentOutOfRangeException("Remark", "Remark value, cannot contain more than 1073741823 characters");
			  _bIsChanged |= (remark != value); 
			  remark = value; 
			}
			
		}
		
		public string PicUrl
		{
			get { return picurl; }
			set 
			{
			  if (value != null && value.Length > 250)
			    throw new ArgumentOutOfRangeException("PicUrl", "PicUrl value, cannot contain more than 250 characters");
			  _bIsChanged |= (picurl != value); 
			  picurl = value; 
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
	
	#region Custom ICollection interface for LabExperiment 

	
	public interface ILabExperimentCollection : ICollection
	{
		LabExperiment this[int index]{	get; set; }
		void Add(LabExperiment pLabExperiment);
		void Clear();
	}
	
	[Serializable]
	public class LabExperimentCollection : ILabExperimentCollection
	{
		private IList<LabExperiment> _arrayInternal;

		public LabExperimentCollection()
		{
			_arrayInternal = new List<LabExperiment>();
		}
		
		public LabExperimentCollection( IList<LabExperiment> pSource )
		{
			_arrayInternal = pSource;
			if(_arrayInternal == null)
			{
				_arrayInternal = new List<LabExperiment>();
			}
		}

		public LabExperiment this[int index]
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
		public void CopyTo(Array array, int index){ _arrayInternal.CopyTo((LabExperiment[])array, index); }
		public IEnumerator GetEnumerator() { return _arrayInternal.GetEnumerator(); }
		public void Add(LabExperiment pLabExperiment) { _arrayInternal.Add(pLabExperiment); }
		public void Clear() { _arrayInternal.Clear(); }
		public IList<LabExperiment> GetList() { return _arrayInternal; }
	 }
	
	#endregion
}
