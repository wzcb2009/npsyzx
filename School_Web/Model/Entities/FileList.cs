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
	/// IFileList interface for NHibernate mapped table 'FileList'.
	/// </summary>
	public interface IFileList
	{
		#region Public Properties
		
		int FileId
		{
			get ;
			set ;
			  
		}
		
		int UserId
		{
			get ;
			set ;
			  
		}
		
		int GradeId
		{
			get ;
			set ;
			  
		}
		
		int ZyId
		{
			get ;
			set ;
			  
		}
		
		int CaseId
		{
			get ;
			set ;
			  
		}
		
		int Parentid
		{
			get ;
			set ;
			  
		}
		
		int Pindex
		{
			get ;
			set ;
			  
		}
		
		int ProjectId
		{
			get ;
			set ;
			  
		}
		
		string Path
		{
			get ;
			set ;
			  
		}
		
		string Title
		{
			get ;
			set ;
			  
		}
		
		string Ext
		{
			get ;
			set ;
			  
		}
		
		double Filesize
		{
			get ;
			set ;
			  
		}
		
		string Content
		{
			get ;
			set ;
			  
		}
		
		string IndexImagePath
		{
			get ;
			set ;
			  
		}
		
		DateTime Pubdate
		{
			get ;
			set ;
			  
		}
		
		int Clicks
		{
			get ;
			set ;
			  
		}
		
		bool IsDeleted { get; set; }
		bool IsChanged { get; set; }
		
		#endregion 
	}

	/// <summary>
	/// FileList object for NHibernate mapped table 'FileList'.
	/// </summary>
	[Serializable]
	public class FileList : IFileList
	{
		#region Member Variables

		protected int fileid;
		protected int userid;
		protected int gradeid;
		protected int zyid;
		protected int caseid;
		protected int parentid;
		protected int pindex;
		protected int projectid;
		protected string path;
		protected string title;
		protected string ext;
		protected double filesize;
		protected string content;
		protected string indeximagepath;
		protected DateTime pubdate;
		protected int clicks;
		protected bool _bIsDeleted;
		protected bool _bIsChanged;
		#endregion
		
		#region Constructors
		public FileList() {}
		
		public FileList(int pUserId, int pGradeId, int pZyId, int pCaseId, int pParentid, int pPindex, int pProjectId, string pPath, string pTitle, string pExt, double pFilesize, string pContent, string pIndexImagePath, DateTime pPubdate, int pClicks)
		{
			this.userid = pUserId; 
			this.gradeid = pGradeId; 
			this.zyid = pZyId; 
			this.caseid = pCaseId; 
			this.parentid = pParentid; 
			this.pindex = pPindex; 
			this.projectid = pProjectId; 
			this.path = pPath; 
			this.title = pTitle; 
			this.ext = pExt; 
			this.filesize = pFilesize; 
			this.content = pContent; 
			this.indeximagepath = pIndexImagePath; 
			this.pubdate = pPubdate; 
			this.clicks = pClicks; 
		}
		
		public FileList(int pFileId)
		{
			this.fileid = pFileId; 
		}
		
		#endregion
		
		#region Public Properties
		
		public int FileId
		{
			get { return fileid; }
			set { _bIsChanged |= (fileid != value); fileid = value; }
			
		}
		
		public int UserId
		{
			get { return userid; }
			set { _bIsChanged |= (userid != value); userid = value; }
			
		}
		
		public int GradeId
		{
			get { return gradeid; }
			set { _bIsChanged |= (gradeid != value); gradeid = value; }
			
		}
		
		public int ZyId
		{
			get { return zyid; }
			set { _bIsChanged |= (zyid != value); zyid = value; }
			
		}
		
		public int CaseId
		{
			get { return caseid; }
			set { _bIsChanged |= (caseid != value); caseid = value; }
			
		}
		
		public int Parentid
		{
			get { return parentid; }
			set { _bIsChanged |= (parentid != value); parentid = value; }
			
		}
		
		public int Pindex
		{
			get { return pindex; }
			set { _bIsChanged |= (pindex != value); pindex = value; }
			
		}
		
		public int ProjectId
		{
			get { return projectid; }
			set { _bIsChanged |= (projectid != value); projectid = value; }
			
		}
		
		public string Path
		{
			get { return path; }
			set 
			{
			  if (value != null && value.Length > 250)
			    throw new ArgumentOutOfRangeException("Path", "Path value, cannot contain more than 250 characters");
			  _bIsChanged |= (path != value); 
			  path = value; 
			}
			
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
		
		public string Ext
		{
			get { return ext; }
			set 
			{
			  if (value != null && value.Length > 10)
			    throw new ArgumentOutOfRangeException("Ext", "Ext value, cannot contain more than 10 characters");
			  _bIsChanged |= (ext != value); 
			  ext = value; 
			}
			
		}
		
		public double Filesize
		{
			get { return filesize; }
			set { _bIsChanged |= (filesize != value); filesize = value; }
			
		}
		
		public string Content
		{
			get { return content; }
			set 
			{
			  if (value != null && value.Length > 250)
			    throw new ArgumentOutOfRangeException("Content", "Content value, cannot contain more than 250 characters");
			  _bIsChanged |= (content != value); 
			  content = value; 
			}
			
		}
		
		public string IndexImagePath
		{
			get { return indeximagepath; }
			set 
			{
			  if (value != null && value.Length > 250)
			    throw new ArgumentOutOfRangeException("IndexImagePath", "IndexImagePath value, cannot contain more than 250 characters");
			  _bIsChanged |= (indeximagepath != value); 
			  indeximagepath = value; 
			}
			
		}
		
		public DateTime Pubdate
		{
			get { return pubdate; }
			set { _bIsChanged |= (pubdate != value); pubdate = value; }
			
		}
		
		public int Clicks
		{
			get { return clicks; }
			set { _bIsChanged |= (clicks != value); clicks = value; }
			
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
	
	#region Custom ICollection interface for FileList 

	
	public interface IFileListCollection : ICollection
	{
		FileList this[int index]{	get; set; }
		void Add(FileList pFileList);
		void Clear();
	}
	
	[Serializable]
	public class FileListCollection : IFileListCollection
	{
		private IList<FileList> _arrayInternal;

		public FileListCollection()
		{
			_arrayInternal = new List<FileList>();
		}
		
		public FileListCollection( IList<FileList> pSource )
		{
			_arrayInternal = pSource;
			if(_arrayInternal == null)
			{
				_arrayInternal = new List<FileList>();
			}
		}

		public FileList this[int index]
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
		public void CopyTo(Array array, int index){ _arrayInternal.CopyTo((FileList[])array, index); }
		public IEnumerator GetEnumerator() { return _arrayInternal.GetEnumerator(); }
		public void Add(FileList pFileList) { _arrayInternal.Add(pFileList); }
		public void Clear() { _arrayInternal.Clear(); }
		public IList<FileList> GetList() { return _arrayInternal; }
	 }
	
	#endregion
}
