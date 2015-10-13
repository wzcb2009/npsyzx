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
	/// IClassList interface for NHibernate mapped table 'ClassList'.
	/// </summary>
	public interface IClassList
	{
		#region Public Properties
		
		int ClassId
		{
			get ;
			set ;
			  
		}
		
		int GradeId
		{
			get ;
			set ;
			  
		}
		
		string ClassName
		{
			get ;
			set ;
			  
		}
		
		int ClassType
		{
			get ;
			set ;
			  
		}
		
		bool IsDeleted { get; set; }
		bool IsChanged { get; set; }
		
		#endregion 
	}

	/// <summary>
	/// ClassList object for NHibernate mapped table 'ClassList'.
	/// </summary>
	[Serializable]
	public class ClassList : IClassList
	{
		#region Member Variables

		protected int classid;
		protected int gradeid;
		protected string classname;
		protected int classtype;
		protected bool _bIsDeleted;
		protected bool _bIsChanged;
		#endregion
		
		#region Constructors
		public ClassList() {}
		
		public ClassList(int pGradeId, string pClassName, int pClassType)
		{
			this.gradeid = pGradeId; 
			this.classname = pClassName; 
			this.classtype = pClassType; 
		}
		
		public ClassList(int pGradeId, string pClassName)
		{
			this.gradeid = pGradeId; 
			this.classname = pClassName; 
		}
		
		public ClassList(int pClassId)
		{
			this.classid = pClassId; 
		}
		
		#endregion
		
		#region Public Properties
		
		public int ClassId
		{
			get { return classid; }
			set { _bIsChanged |= (classid != value); classid = value; }
			
		}
		
		public int GradeId
		{
			get { return gradeid; }
			set { _bIsChanged |= (gradeid != value); gradeid = value; }
			
		}
		
		public string ClassName
		{
			get { return classname; }
			set 
			{
			  if (value != null && value.Length > 50)
			    throw new ArgumentOutOfRangeException("ClassName", "ClassName value, cannot contain more than 50 characters");
			  _bIsChanged |= (classname != value); 
			  classname = value; 
			}
			
		}
		
		public int ClassType
		{
			get { return classtype; }
			set { _bIsChanged |= (classtype != value); classtype = value; }
			
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
	
	#region Custom ICollection interface for ClassList 

	
	public interface IClassListCollection : ICollection
	{
		ClassList this[int index]{	get; set; }
		void Add(ClassList pClassList);
		void Clear();
	}
	
	[Serializable]
	public class ClassListCollection : IClassListCollection
	{
		private IList<ClassList> _arrayInternal;

		public ClassListCollection()
		{
			_arrayInternal = new List<ClassList>();
		}
		
		public ClassListCollection( IList<ClassList> pSource )
		{
			_arrayInternal = pSource;
			if(_arrayInternal == null)
			{
				_arrayInternal = new List<ClassList>();
			}
		}

		public ClassList this[int index]
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
		public void CopyTo(Array array, int index){ _arrayInternal.CopyTo((ClassList[])array, index); }
		public IEnumerator GetEnumerator() { return _arrayInternal.GetEnumerator(); }
		public void Add(ClassList pClassList) { _arrayInternal.Add(pClassList); }
		public void Clear() { _arrayInternal.Clear(); }
		public IList<ClassList> GetList() { return _arrayInternal; }
	 }
	
	#endregion
}
