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
	/// IGradeList interface for NHibernate mapped table 'GradeList'.
	/// </summary>
	public interface IGradeList
	{
		#region Public Properties
		
		int GradeId
		{
			get ;
			set ;
			  
		}
		
		int GradeName
		{
			get ;
			set ;
			  
		}
		
		DateTime Pubdate
		{
			get ;
			set ;
			  
		}
		
		bool GState
		{
			get ;
			set ;
			  
		}
		
		bool IsDeleted { get; set; }
		bool IsChanged { get; set; }
		
		#endregion 
	}

	/// <summary>
	/// GradeList object for NHibernate mapped table 'GradeList'.
	/// </summary>
	[Serializable]
	public class GradeList : IGradeList
	{
		#region Member Variables

		protected int gradeid;
		protected int gradename;
		protected DateTime pubdate;
		protected bool gstate;
		protected bool _bIsDeleted;
		protected bool _bIsChanged;
		#endregion
		
		#region Constructors
		public GradeList() {}
		
		public GradeList(int pGradeName, DateTime pPubdate, bool pGstate)
		{
			this.gradename = pGradeName; 
			this.pubdate = pPubdate; 
			this.gstate = pGstate; 
		}
		
		public GradeList(int pGradeName)
		{
			this.gradename = pGradeName; 
		}
		
		public GradeList(int pGradeId)
		{
			this.gradeid = pGradeId; 
		}
		
		#endregion
		
		#region Public Properties
		
		public int GradeId
		{
			get { return gradeid; }
			set { _bIsChanged |= (gradeid != value); gradeid = value; }
			
		}
		
		public int GradeName
		{
			get { return gradename; }
			set { _bIsChanged |= (gradename != value); gradename = value; }
			
		}
		
		public DateTime Pubdate
		{
			get { return pubdate; }
			set { _bIsChanged |= (pubdate != value); pubdate = value; }
			
		}
		
		public bool GState
		{
			get { return gstate; }
			set { _bIsChanged |= (gstate != value); gstate = value; }
			
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
	
	#region Custom ICollection interface for GradeList 

	
	public interface IGradeListCollection : ICollection
	{
		GradeList this[int index]{	get; set; }
		void Add(GradeList pGradeList);
		void Clear();
	}
	
	[Serializable]
	public class GradeListCollection : IGradeListCollection
	{
		private IList<GradeList> _arrayInternal;

		public GradeListCollection()
		{
			_arrayInternal = new List<GradeList>();
		}
		
		public GradeListCollection( IList<GradeList> pSource )
		{
			_arrayInternal = pSource;
			if(_arrayInternal == null)
			{
				_arrayInternal = new List<GradeList>();
			}
		}

		public GradeList this[int index]
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
		public void CopyTo(Array array, int index){ _arrayInternal.CopyTo((GradeList[])array, index); }
		public IEnumerator GetEnumerator() { return _arrayInternal.GetEnumerator(); }
		public void Add(GradeList pGradeList) { _arrayInternal.Add(pGradeList); }
		public void Clear() { _arrayInternal.Clear(); }
		public IList<GradeList> GetList() { return _arrayInternal; }
	 }
	
	#endregion
}
