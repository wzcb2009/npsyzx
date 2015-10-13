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
	/// IPeClass interface for NHibernate mapped table 'PE_Class'.
	/// </summary>
	public interface IPeClass
	{
		#region Public Properties
		
		int Classid
		{
			get ;
			set ;
			  
		}
		
		int Channelid
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
		
		int OpenType
		{
			get ;
			set ;
			  
		}
		
		int Parentid
		{
			get ;
			set ;
			  
		}
		
		string ParentPath
		{
			get ;
			set ;
			  
		}
		
		int Depth
		{
			get ;
			set ;
			  
		}
		
		int Rootid
		{
			get ;
			set ;
			  
		}
		
		int Child
		{
			get ;
			set ;
			  
		}
		
		string ArrChildid
		{
			get ;
			set ;
			  
		}
		
		int Previd
		{
			get ;
			set ;
			  
		}
		
		int Nextid
		{
			get ;
			set ;
			  
		}
		
		int Orderid
		{
			get ;
			set ;
			  
		}
		
		string Tips
		{
			get ;
			set ;
			  
		}
		
		string Readme
		{
			get ;
			set ;
			  
		}
		
		string MetaKeywords
		{
			get ;
			set ;
			  
		}
		
		string MetaDescription
		{
			get ;
			set ;
			  
		}
		
		string LinkUrl
		{
			get ;
			set ;
			  
		}
		
		string ClassPicUrl
		{
			get ;
			set ;
			  
		}
		
		string ClassDir
		{
			get ;
			set ;
			  
		}
		
		string ParentDir
		{
			get ;
			set ;
			  
		}
		
		int Skinid
		{
			get ;
			set ;
			  
		}
		
		int Templateid
		{
			get ;
			set ;
			  
		}
		
		bool ShowOnTop
		{
			get ;
			set ;
			  
		}
		
		bool ShowOnIndex
		{
			get ;
			set ;
			  
		}
		
		bool IsElite
		{
			get ;
			set ;
			  
		}
		
		bool EnableAdd
		{
			get ;
			set ;
			  
		}
		
		bool EnableProtect
		{
			get ;
			set ;
			  
		}
		
		int MaxPerPage
		{
			get ;
			set ;
			  
		}
		
		int DefaultItemTemplate
		{
			get ;
			set ;
			  
		}
		
		int DefaultItemSkin
		{
			get ;
			set ;
			  
		}
		
		int ItemListOrderType
		{
			get ;
			set ;
			  
		}
		
		int ItemOpenType
		{
			get ;
			set ;
			  
		}
		
		int ItemCount
		{
			get ;
			set ;
			  
		}
		
		byte ClassPurview
		{
			get ;
			set ;
			  
		}
		
		bool EnableComment
		{
			get ;
			set ;
			  
		}
		
		bool CheckComment
		{
			get ;
			set ;
			  
		}
		
		double PresentExp
		{
			get ;
			set ;
			  
		}
		
		double DefaultItemPoint
		{
			get ;
			set ;
			  
		}
		
		int DefaultItemChargeType
		{
			get ;
			set ;
			  
		}
		
		int DefaultItemPitchTime
		{
			get ;
			set ;
			  
		}
		
		int DefaultItemReadTimes
		{
			get ;
			set ;
			  
		}
		
		int DefaultItemDividePercent
		{
			get ;
			set ;
			  
		}
		
		string CustomContent
		{
			get ;
			set ;
			  
		}
		
		int CommandClassPoint
		{
			get ;
			set ;
			  
		}
		
		int ReleaseClassPoint
		{
			get ;
			set ;
			  
		}
		
		bool ClassPage
		{
			get ;
			set ;
			  
		}
		
		bool IsDeleted { get; set; }
		bool IsChanged { get; set; }
		
		#endregion 
	}

	/// <summary>
	/// PeClass object for NHibernate mapped table 'PE_Class'.
	/// </summary>
	[Serializable]
	public class PeClass : IPeClass
	{
		#region Member Variables

		protected int classid;
		protected int channelid;
		protected string classname;
		protected int classtype;
		protected int opentype;
		protected int parentid;
		protected string parentpath;
		protected int depth;
		protected int rootid;
		protected int child;
		protected string arrchildid;
		protected int previd;
		protected int nextid;
		protected int orderid;
		protected string tips;
		protected string readme;
		protected string metakeywords;
		protected string metadescription;
		protected string linkurl;
		protected string classpicurl;
		protected string classdir;
		protected string parentdir;
		protected int skinid;
		protected int templateid;
		protected bool showontop;
		protected bool showonindex;
		protected bool iselite;
		protected bool enableadd;
		protected bool enableprotect;
		protected int maxperpage;
		protected int defaultitemtemplate;
		protected int defaultitemskin;
		protected int itemlistordertype;
		protected int itemopentype;
		protected int itemcount;
		protected byte classpurview;
		protected bool enablecomment;
		protected bool checkcomment;
		protected double presentexp;
		protected double defaultitempoint;
		protected int defaultitemchargetype;
		protected int defaultitempitchtime;
		protected int defaultitemreadtimes;
		protected int defaultitemdividepercent;
		protected string customcontent;
		protected int commandclasspoint;
		protected int releaseclasspoint;
		protected bool classpage;
		protected bool _bIsDeleted;
		protected bool _bIsChanged;
		#endregion
		
		#region Constructors
		public PeClass() {}
		
		public PeClass(int pClassid, int pChannelid, string pClassName, int pClassType, int pOpenType, int pParentid, string pParentPath, int pDepth, int pRootid, int pChild, string pArrChildid, int pPrevid, int pNextid, int pOrderid, string pTips, string pReadme, string pMetaKeywords, string pMetaDescription, string pLinkUrl, string pClassPicUrl, string pClassDir, string pParentDir, int pSkinid, int pTemplateid, bool pShowOnTop, bool pShowOnIndex, bool pIsElite, bool pEnableAdd, bool pEnableProtect, int pMaxPerPage, int pDefaultItemTemplate, int pDefaultItemSkin, int pItemListOrderType, int pItemOpenType, int pItemCount, byte pClassPurview, bool pEnableComment, bool pCheckComment, double pPresentExp, double pDefaultItemPoint, int pDefaultItemChargeType, int pDefaultItemPitchTime, int pDefaultItemReadTimes, int pDefaultItemDividePercent, string pCustomContent, int pCommandClassPoint, int pReleaseClassPoint, bool pClassPage)
		{
			this.classid = pClassid; 
			this.channelid = pChannelid; 
			this.classname = pClassName; 
			this.classtype = pClassType; 
			this.opentype = pOpenType; 
			this.parentid = pParentid; 
			this.parentpath = pParentPath; 
			this.depth = pDepth; 
			this.rootid = pRootid; 
			this.child = pChild; 
			this.arrchildid = pArrChildid; 
			this.previd = pPrevid; 
			this.nextid = pNextid; 
			this.orderid = pOrderid; 
			this.tips = pTips; 
			this.readme = pReadme; 
			this.metakeywords = pMetaKeywords; 
			this.metadescription = pMetaDescription; 
			this.linkurl = pLinkUrl; 
			this.classpicurl = pClassPicUrl; 
			this.classdir = pClassDir; 
			this.parentdir = pParentDir; 
			this.skinid = pSkinid; 
			this.templateid = pTemplateid; 
			this.showontop = pShowOnTop; 
			this.showonindex = pShowOnIndex; 
			this.iselite = pIsElite; 
			this.enableadd = pEnableAdd; 
			this.enableprotect = pEnableProtect; 
			this.maxperpage = pMaxPerPage; 
			this.defaultitemtemplate = pDefaultItemTemplate; 
			this.defaultitemskin = pDefaultItemSkin; 
			this.itemlistordertype = pItemListOrderType; 
			this.itemopentype = pItemOpenType; 
			this.itemcount = pItemCount; 
			this.classpurview = pClassPurview; 
			this.enablecomment = pEnableComment; 
			this.checkcomment = pCheckComment; 
			this.presentexp = pPresentExp; 
			this.defaultitempoint = pDefaultItemPoint; 
			this.defaultitemchargetype = pDefaultItemChargeType; 
			this.defaultitempitchtime = pDefaultItemPitchTime; 
			this.defaultitemreadtimes = pDefaultItemReadTimes; 
			this.defaultitemdividepercent = pDefaultItemDividePercent; 
			this.customcontent = pCustomContent; 
			this.commandclasspoint = pCommandClassPoint; 
			this.releaseclasspoint = pReleaseClassPoint; 
			this.classpage = pClassPage; 
		}
		
		public PeClass(int pClassid, int pChannelid, string pClassName, int pClassType, int pOpenType, int pParentid, string pParentPath, int pDepth, int pRootid, int pChild, int pPrevid, int pNextid, int pOrderid, bool pShowOnTop, bool pShowOnIndex, bool pIsElite, bool pEnableAdd, bool pEnableProtect, bool pEnableComment, bool pCheckComment, bool pClassPage)
		{
			this.classid = pClassid; 
			this.channelid = pChannelid; 
			this.classname = pClassName; 
			this.classtype = pClassType; 
			this.opentype = pOpenType; 
			this.parentid = pParentid; 
			this.parentpath = pParentPath; 
			this.depth = pDepth; 
			this.rootid = pRootid; 
			this.child = pChild; 
			this.previd = pPrevid; 
			this.nextid = pNextid; 
			this.orderid = pOrderid; 
			this.showontop = pShowOnTop; 
			this.showonindex = pShowOnIndex; 
			this.iselite = pIsElite; 
			this.enableadd = pEnableAdd; 
			this.enableprotect = pEnableProtect; 
			this.enablecomment = pEnableComment; 
			this.checkcomment = pCheckComment; 
			this.classpage = pClassPage; 
		}
		
		#endregion
		
		#region Public Properties
		
		public int Classid
		{
			get { return classid; }
			set { _bIsChanged |= (classid != value); classid = value; }
			
		}
		
		public int Channelid
		{
			get { return channelid; }
			set { _bIsChanged |= (channelid != value); channelid = value; }
			
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
		
		public int OpenType
		{
			get { return opentype; }
			set { _bIsChanged |= (opentype != value); opentype = value; }
			
		}
		
		public int Parentid
		{
			get { return parentid; }
			set { _bIsChanged |= (parentid != value); parentid = value; }
			
		}
		
		public string ParentPath
		{
			get { return parentpath; }
			set 
			{
			  if (value != null && value.Length > 50)
			    throw new ArgumentOutOfRangeException("ParentPath", "ParentPath value, cannot contain more than 50 characters");
			  _bIsChanged |= (parentpath != value); 
			  parentpath = value; 
			}
			
		}
		
		public int Depth
		{
			get { return depth; }
			set { _bIsChanged |= (depth != value); depth = value; }
			
		}
		
		public int Rootid
		{
			get { return rootid; }
			set { _bIsChanged |= (rootid != value); rootid = value; }
			
		}
		
		public int Child
		{
			get { return child; }
			set { _bIsChanged |= (child != value); child = value; }
			
		}
		
		public string ArrChildid
		{
			get { return arrchildid; }
			set 
			{
			  if (value != null && value.Length > 1073741823)
			    throw new ArgumentOutOfRangeException("ArrChildid", "ArrChildid value, cannot contain more than 1073741823 characters");
			  _bIsChanged |= (arrchildid != value); 
			  arrchildid = value; 
			}
			
		}
		
		public int Previd
		{
			get { return previd; }
			set { _bIsChanged |= (previd != value); previd = value; }
			
		}
		
		public int Nextid
		{
			get { return nextid; }
			set { _bIsChanged |= (nextid != value); nextid = value; }
			
		}
		
		public int Orderid
		{
			get { return orderid; }
			set { _bIsChanged |= (orderid != value); orderid = value; }
			
		}
		
		public string Tips
		{
			get { return tips; }
			set 
			{
			  if (value != null && value.Length > 255)
			    throw new ArgumentOutOfRangeException("Tips", "Tips value, cannot contain more than 255 characters");
			  _bIsChanged |= (tips != value); 
			  tips = value; 
			}
			
		}
		
		public string Readme
		{
			get { return readme; }
			set 
			{
			  if (value != null && value.Length > 1073741823)
			    throw new ArgumentOutOfRangeException("Readme", "Readme value, cannot contain more than 1073741823 characters");
			  _bIsChanged |= (readme != value); 
			  readme = value; 
			}
			
		}
		
		public string MetaKeywords
		{
			get { return metakeywords; }
			set 
			{
			  if (value != null && value.Length > 255)
			    throw new ArgumentOutOfRangeException("MetaKeywords", "MetaKeywords value, cannot contain more than 255 characters");
			  _bIsChanged |= (metakeywords != value); 
			  metakeywords = value; 
			}
			
		}
		
		public string MetaDescription
		{
			get { return metadescription; }
			set 
			{
			  if (value != null && value.Length > 255)
			    throw new ArgumentOutOfRangeException("MetaDescription", "MetaDescription value, cannot contain more than 255 characters");
			  _bIsChanged |= (metadescription != value); 
			  metadescription = value; 
			}
			
		}
		
		public string LinkUrl
		{
			get { return linkurl; }
			set 
			{
			  if (value != null && value.Length > 255)
			    throw new ArgumentOutOfRangeException("LinkUrl", "LinkUrl value, cannot contain more than 255 characters");
			  _bIsChanged |= (linkurl != value); 
			  linkurl = value; 
			}
			
		}
		
		public string ClassPicUrl
		{
			get { return classpicurl; }
			set 
			{
			  if (value != null && value.Length > 255)
			    throw new ArgumentOutOfRangeException("ClassPicUrl", "ClassPicUrl value, cannot contain more than 255 characters");
			  _bIsChanged |= (classpicurl != value); 
			  classpicurl = value; 
			}
			
		}
		
		public string ClassDir
		{
			get { return classdir; }
			set 
			{
			  if (value != null && value.Length > 50)
			    throw new ArgumentOutOfRangeException("ClassDir", "ClassDir value, cannot contain more than 50 characters");
			  _bIsChanged |= (classdir != value); 
			  classdir = value; 
			}
			
		}
		
		public string ParentDir
		{
			get { return parentdir; }
			set 
			{
			  if (value != null && value.Length > 1073741823)
			    throw new ArgumentOutOfRangeException("ParentDir", "ParentDir value, cannot contain more than 1073741823 characters");
			  _bIsChanged |= (parentdir != value); 
			  parentdir = value; 
			}
			
		}
		
		public int Skinid
		{
			get { return skinid; }
			set { _bIsChanged |= (skinid != value); skinid = value; }
			
		}
		
		public int Templateid
		{
			get { return templateid; }
			set { _bIsChanged |= (templateid != value); templateid = value; }
			
		}
		
		public bool ShowOnTop
		{
			get { return showontop; }
			set { _bIsChanged |= (showontop != value); showontop = value; }
			
		}
		
		public bool ShowOnIndex
		{
			get { return showonindex; }
			set { _bIsChanged |= (showonindex != value); showonindex = value; }
			
		}
		
		public bool IsElite
		{
			get { return iselite; }
			set { _bIsChanged |= (iselite != value); iselite = value; }
			
		}
		
		public bool EnableAdd
		{
			get { return enableadd; }
			set { _bIsChanged |= (enableadd != value); enableadd = value; }
			
		}
		
		public bool EnableProtect
		{
			get { return enableprotect; }
			set { _bIsChanged |= (enableprotect != value); enableprotect = value; }
			
		}
		
		public int MaxPerPage
		{
			get { return maxperpage; }
			set { _bIsChanged |= (maxperpage != value); maxperpage = value; }
			
		}
		
		public int DefaultItemTemplate
		{
			get { return defaultitemtemplate; }
			set { _bIsChanged |= (defaultitemtemplate != value); defaultitemtemplate = value; }
			
		}
		
		public int DefaultItemSkin
		{
			get { return defaultitemskin; }
			set { _bIsChanged |= (defaultitemskin != value); defaultitemskin = value; }
			
		}
		
		public int ItemListOrderType
		{
			get { return itemlistordertype; }
			set { _bIsChanged |= (itemlistordertype != value); itemlistordertype = value; }
			
		}
		
		public int ItemOpenType
		{
			get { return itemopentype; }
			set { _bIsChanged |= (itemopentype != value); itemopentype = value; }
			
		}
		
		public int ItemCount
		{
			get { return itemcount; }
			set { _bIsChanged |= (itemcount != value); itemcount = value; }
			
		}
		
		public byte ClassPurview
		{
			get { return classpurview; }
			set { _bIsChanged |= (classpurview != value); classpurview = value; }
			
		}
		
		public bool EnableComment
		{
			get { return enablecomment; }
			set { _bIsChanged |= (enablecomment != value); enablecomment = value; }
			
		}
		
		public bool CheckComment
		{
			get { return checkcomment; }
			set { _bIsChanged |= (checkcomment != value); checkcomment = value; }
			
		}
		
		public double PresentExp
		{
			get { return presentexp; }
			set { _bIsChanged |= (presentexp != value); presentexp = value; }
			
		}
		
		public double DefaultItemPoint
		{
			get { return defaultitempoint; }
			set { _bIsChanged |= (defaultitempoint != value); defaultitempoint = value; }
			
		}
		
		public int DefaultItemChargeType
		{
			get { return defaultitemchargetype; }
			set { _bIsChanged |= (defaultitemchargetype != value); defaultitemchargetype = value; }
			
		}
		
		public int DefaultItemPitchTime
		{
			get { return defaultitempitchtime; }
			set { _bIsChanged |= (defaultitempitchtime != value); defaultitempitchtime = value; }
			
		}
		
		public int DefaultItemReadTimes
		{
			get { return defaultitemreadtimes; }
			set { _bIsChanged |= (defaultitemreadtimes != value); defaultitemreadtimes = value; }
			
		}
		
		public int DefaultItemDividePercent
		{
			get { return defaultitemdividepercent; }
			set { _bIsChanged |= (defaultitemdividepercent != value); defaultitemdividepercent = value; }
			
		}
		
		public string CustomContent
		{
			get { return customcontent; }
			set 
			{
			  if (value != null && value.Length > 1073741823)
			    throw new ArgumentOutOfRangeException("CustomContent", "CustomContent value, cannot contain more than 1073741823 characters");
			  _bIsChanged |= (customcontent != value); 
			  customcontent = value; 
			}
			
		}
		
		public int CommandClassPoint
		{
			get { return commandclasspoint; }
			set { _bIsChanged |= (commandclasspoint != value); commandclasspoint = value; }
			
		}
		
		public int ReleaseClassPoint
		{
			get { return releaseclasspoint; }
			set { _bIsChanged |= (releaseclasspoint != value); releaseclasspoint = value; }
			
		}
		
		public bool ClassPage
		{
			get { return classpage; }
			set { _bIsChanged |= (classpage != value); classpage = value; }
			
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
	
	#region Custom ICollection interface for PeClass 

	
	public interface IPeClassCollection : ICollection
	{
		PeClass this[int index]{	get; set; }
		void Add(PeClass pPeClass);
		void Clear();
	}
	
	[Serializable]
	public class PeClassCollection : IPeClassCollection
	{
		private IList<PeClass> _arrayInternal;

		public PeClassCollection()
		{
			_arrayInternal = new List<PeClass>();
		}
		
		public PeClassCollection( IList<PeClass> pSource )
		{
			_arrayInternal = pSource;
			if(_arrayInternal == null)
			{
				_arrayInternal = new List<PeClass>();
			}
		}

		public PeClass this[int index]
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
		public void CopyTo(Array array, int index){ _arrayInternal.CopyTo((PeClass[])array, index); }
		public IEnumerator GetEnumerator() { return _arrayInternal.GetEnumerator(); }
		public void Add(PeClass pPeClass) { _arrayInternal.Add(pPeClass); }
		public void Clear() { _arrayInternal.Clear(); }
		public IList<PeClass> GetList() { return _arrayInternal; }
	 }
	
	#endregion
}
