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
	/// ICourseInfo interface for NHibernate mapped table 'CourseInfo'.
	/// </summary>
	public interface ICourseInfo
	{
		#region Public Properties
		
		int Id
		{
			get ;
			set ;
			  
		}
		
		string Name
		{
			get ;
			set ;
			  
		}
		
		string SubjectParentName
		{
			get ;
			set ;
			  
		}
		
		string SubjectTypeName
		{
			get ;
			set ;
			  
		}
		
		string SubjectName
		{
			get ;
			set ;
			  
		}
		
		string SubjectObjects
		{
			get ;
			set ;
			  
		}
		
		int TypeId
		{
			get ;
			set ;
			  
		}
		
		string PropertyIds
		{
			get ;
			set ;
			  
		}
		
		int LessonCount
		{
			get ;
			set ;
			  
		}
		
		int UserId
		{
			get ;
			set ;
			  
		}
		
		string Remark
		{
			get ;
			set ;
			  
		}
		
		int Clicks
		{
			get ;
			set ;
			  
		}
		
		DateTime Pubdate
		{
			get ;
			set ;
			  
		}
		
		bool IsDeleted { get; set; }
		bool IsChanged { get; set; }
		
		#endregion 
	}

	/// <summary>
	/// CourseInfo object for NHibernate mapped table 'CourseInfo'.
	/// </summary>
	[Serializable]
	public class CourseInfo : ICourseInfo
	{
		#region Member Variables

		protected int id;
		protected string name;
		protected string subjectparentname;
		protected string subjecttypename;
		protected string subjectname;
		protected string subjectobjects;
		protected int typeid;
		protected string propertyids;
		protected int lessoncount;
		protected int userid;
		protected string remark;
		protected int clicks;
		protected DateTime pubdate;
		protected bool _bIsDeleted;
		protected bool _bIsChanged;
		#endregion
		
		#region Constructors
		public CourseInfo() {}
		
		public CourseInfo(string pName, string pSubjectParentName, string pSubjectTypeName, string pSubjectName, string pSubjectObjects, int pTypeId, string pPropertyIds, int pLessonCount, int pUserId, string pRemark, int pClicks, DateTime pPubdate)
		{
			this.name = pName; 
			this.subjectparentname = pSubjectParentName; 
			this.subjecttypename = pSubjectTypeName; 
			this.subjectname = pSubjectName; 
			this.subjectobjects = pSubjectObjects; 
			this.typeid = pTypeId; 
			this.propertyids = pPropertyIds; 
			this.lessoncount = pLessonCount; 
			this.userid = pUserId; 
			this.remark = pRemark; 
			this.clicks = pClicks; 
			this.pubdate = pPubdate; 
		}
		
		public CourseInfo(int pId)
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
		
		public string Name
		{
			get { return name; }
			set 
			{
			  if (value != null && value.Length > 50)
			    throw new ArgumentOutOfRangeException("Name", "Name value, cannot contain more than 50 characters");
			  _bIsChanged |= (name != value); 
			  name = value; 
			}
			
		}
		
		public string SubjectParentName
		{
			get { return subjectparentname; }
			set 
			{
			  if (value != null && value.Length > 50)
			    throw new ArgumentOutOfRangeException("SubjectParentName", "SubjectParentName value, cannot contain more than 50 characters");
			  _bIsChanged |= (subjectparentname != value); 
			  subjectparentname = value; 
			}
			
		}
		
		public string SubjectTypeName
		{
			get { return subjecttypename; }
			set 
			{
			  if (value != null && value.Length > 50)
			    throw new ArgumentOutOfRangeException("SubjectTypeName", "SubjectTypeName value, cannot contain more than 50 characters");
			  _bIsChanged |= (subjecttypename != value); 
			  subjecttypename = value; 
			}
			
		}
		
		public string SubjectName
		{
			get { return subjectname; }
			set 
			{
			  if (value != null && value.Length > 50)
			    throw new ArgumentOutOfRangeException("SubjectName", "SubjectName value, cannot contain more than 50 characters");
			  _bIsChanged |= (subjectname != value); 
			  subjectname = value; 
			}
			
		}
		
		public string SubjectObjects
		{
			get { return subjectobjects; }
			set 
			{
			  if (value != null && value.Length > 50)
			    throw new ArgumentOutOfRangeException("SubjectObjects", "SubjectObjects value, cannot contain more than 50 characters");
			  _bIsChanged |= (subjectobjects != value); 
			  subjectobjects = value; 
			}
			
		}
		
		public int TypeId
		{
			get { return typeid; }
			set { _bIsChanged |= (typeid != value); typeid = value; }
			
		}
		
		public string PropertyIds
		{
			get { return propertyids; }
			set 
			{
			  if (value != null && value.Length > 50)
			    throw new ArgumentOutOfRangeException("PropertyIds", "PropertyIds value, cannot contain more than 50 characters");
			  _bIsChanged |= (propertyids != value); 
			  propertyids = value; 
			}
			
		}
		
		public int LessonCount
		{
			get { return lessoncount; }
			set { _bIsChanged |= (lessoncount != value); lessoncount = value; }
			
		}
		
		public int UserId
		{
			get { return userid; }
			set { _bIsChanged |= (userid != value); userid = value; }
			
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
		
		public int Clicks
		{
			get { return clicks; }
			set { _bIsChanged |= (clicks != value); clicks = value; }
			
		}
		
		public DateTime Pubdate
		{
			get { return pubdate; }
			set { _bIsChanged |= (pubdate != value); pubdate = value; }
			
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
	
	#region Custom ICollection interface for CourseInfo 

	
	public interface ICourseInfoCollection : ICollection
	{
		CourseInfo this[int index]{	get; set; }
		void Add(CourseInfo pCourseInfo);
		void Clear();
	}
	
	[Serializable]
	public class CourseInfoCollection : ICourseInfoCollection
	{
		private IList<CourseInfo> _arrayInternal;

		public CourseInfoCollection()
		{
			_arrayInternal = new List<CourseInfo>();
		}
		
		public CourseInfoCollection( IList<CourseInfo> pSource )
		{
			_arrayInternal = pSource;
			if(_arrayInternal == null)
			{
				_arrayInternal = new List<CourseInfo>();
			}
		}

		public CourseInfo this[int index]
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
		public void CopyTo(Array array, int index){ _arrayInternal.CopyTo((CourseInfo[])array, index); }
		public IEnumerator GetEnumerator() { return _arrayInternal.GetEnumerator(); }
		public void Add(CourseInfo pCourseInfo) { _arrayInternal.Add(pCourseInfo); }
		public void Clear() { _arrayInternal.Clear(); }
		public IList<CourseInfo> GetList() { return _arrayInternal; }
	 }
	
	#endregion
}
