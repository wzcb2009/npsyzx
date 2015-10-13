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
	/// IPE_Article interface for NHibernate mapped table 'PE_Article'.
	/// </summary>
	public interface IPE_Article
	{
		#region Public Properties
		
		int ArticleID
		{
			get ;
			set ;
			  
		}
		
		int ChannelID
		{
			get ;
			set ;
			  
		}
		
		int ClassID
		{
			get ;
			set ;
			  
		}
		
		string Title
		{
			get ;
			set ;
			  
		}
		
		string TitleIntact
		{
			get ;
			set ;
			  
		}
		
		string Subheading
		{
			get ;
			set ;
			  
		}
		
		string Author
		{
			get ;
			set ;
			  
		}
		
		string CopyFrom
		{
			get ;
			set ;
			  
		}
		
		string Inputer
		{
			get ;
			set ;
			  
		}
		
		string LinkUrl
		{
			get ;
			set ;
			  
		}
		
		string Editor
		{
			get ;
			set ;
			  
		}
		
		string Keyword
		{
			get ;
			set ;
			  
		}
		
		int Hits
		{
			get ;
			set ;
			  
		}
		
		int CommentCount
		{
			get ;
			set ;
			  
		}
		
		DateTime UpdateTime
		{
			get ;
			set ;
			  
		}
		
		DateTime CreateTime
		{
			get ;
			set ;
			  
		}
		
		bool OnTop
		{
			get ;
			set ;
			  
		}
		
		bool Elite
		{
			get ;
			set ;
			  
		}
		
		int Status
		{
			get ;
			set ;
			  
		}
		
		string Content
		{
			get ;
			set ;
			  
		}
		
		int IncludePic
		{
			get ;
			set ;
			  
		}
		
		string DefaultPicUrl
		{
			get ;
			set ;
			  
		}
		
		string UploadFiles
		{
			get ;
			set ;
			  
		}
		
		int InfoPoint
		{
			get ;
			set ;
			  
		}
		
		int PaginationType
		{
			get ;
			set ;
			  
		}
		
		bool Deleted
		{
			get ;
			set ;
			  
		}
		
		int SkinID
		{
			get ;
			set ;
			  
		}
		
		int TemplateID
		{
			get ;
			set ;
			  
		}
		
		int Stars
		{
			get ;
			set ;
			  
		}
		
		string TitleFontColor
		{
			get ;
			set ;
			  
		}
		
		int TitleFontType
		{
			get ;
			set ;
			  
		}
		
		int MaxCharPerPage
		{
			get ;
			set ;
			  
		}
		
		bool ShowCommentLink
		{
			get ;
			set ;
			  
		}
		
		bool Receive
		{
			get ;
			set ;
			  
		}
		
		string ReceiveUser
		{
			get ;
			set ;
			  
		}
		
		string Received
		{
			get ;
			set ;
			  
		}
		
		int AutoReceiveTime
		{
			get ;
			set ;
			  
		}
		
		int ReceiveType
		{
			get ;
			set ;
			  
		}
		
		string Intro
		{
			get ;
			set ;
			  
		}
		
		double PresentExp
		{
			get ;
			set ;
			  
		}
		
		decimal Copymoney
		{
			get ;
			set ;
			  
		}
		
		bool IsPayed
		{
			get ;
			set ;
			  
		}
		
		string Beneficiary
		{
			get ;
			set ;
			  
		}
		
		DateTime PayDate
		{
			get ;
			set ;
			  
		}
		
		int VoteID
		{
			get ;
			set ;
			  
		}
		
		int InfoPurview
		{
			get ;
			set ;
			  
		}
		
		string arrGroupID
		{
			get ;
			set ;
			  
		}
		
		int ChargeType
		{
			get ;
			set ;
			  
		}
		
		int PitchTime
		{
			get ;
			set ;
			  
		}
		
		int ReadTimes
		{
			get ;
			set ;
			  
		}
		
		int DividePercent
		{
			get ;
			set ;
			  
		}
		
		int BlogID
		{
			get ;
			set ;
			  
		}
		
		bool IsDeleted { get; set; }
		bool IsChanged { get; set; }
		
		#endregion 
	}

	/// <summary>
	/// PE_Article object for NHibernate mapped table 'PE_Article'.
	/// </summary>
	[Serializable]
	public class PE_Article : IPE_Article
	{
		#region Member Variables

		protected int articleid;
		protected int channelid;
		protected int classid;
		protected string title;
		protected string titleintact;
		protected string subheading;
		protected string author;
		protected string copyfrom;
		protected string inputer;
		protected string linkurl;
		protected string editor;
		protected string keyword;
		protected int hits;
		protected int commentcount;
		protected DateTime updatetime;
		protected DateTime createtime;
		protected bool ontop;
		protected bool elite;
		protected int status;
		protected string content;
		protected int includepic;
		protected string defaultpicurl;
		protected string uploadfiles;
		protected int infopoint;
		protected int paginationtype;
		protected bool deleted;
		protected int skinid;
		protected int templateid;
		protected int stars;
		protected string titlefontcolor;
		protected int titlefonttype;
		protected int maxcharperpage;
		protected bool showcommentlink;
		protected bool receive;
		protected string receiveuser;
		protected string received;
		protected int autoreceivetime;
		protected int receivetype;
		protected string intro;
		protected double presentexp;
		protected decimal copymoney;
		protected bool ispayed;
		protected string beneficiary;
		protected DateTime paydate;
		protected int voteid;
		protected int infopurview;
		protected string arrgroupid;
		protected int chargetype;
		protected int pitchtime;
		protected int readtimes;
		protected int dividepercent;
		protected int blogid;
		protected bool _bIsDeleted;
		protected bool _bIsChanged;
		#endregion
		
		#region Constructors
		public PE_Article() {}
		
		public PE_Article(int pArticleid, int pChannelid, int pClassid, string pTitle, string pTitleIntact, string pSubheading, string pAuthor, string pCopyFrom, string pInputer, string pLinkUrl, string pEditor, string pKeyword, int pHits, int pCommentCount, DateTime pUpdateTime, DateTime pCreateTime, bool pOnTop, bool pElite, int pStatus, string pContent, int pIncludePic, string pDefaultPicUrl, string pUploadFiles, int pInfoPoint, int pPaginationType, bool pDeleted, int pSkinid, int pTemplateid, int pStars, string pTitleFontColor, int pTitleFontType, int pMaxCharPerPage, bool pShowCommentLink, bool pReceive, string pReceiveUser, string pReceived, int pAutoReceiveTime, int pReceiveType, string pIntro, double pPresentExp, decimal pCopymoney, bool pIsPayed, string pBeneficiary, DateTime pPayDate, int pVoteid, int pInfoPurview, string pArrGroupid, int pChargeType, int pPitchTime, int pReadTimes, int pDividePercent, int pBlogid)
		{
			this.articleid = pArticleid; 
			this.channelid = pChannelid; 
			this.classid = pClassid; 
			this.title = pTitle; 
			this.titleintact = pTitleIntact; 
			this.subheading = pSubheading; 
			this.author = pAuthor; 
			this.copyfrom = pCopyFrom; 
			this.inputer = pInputer; 
			this.linkurl = pLinkUrl; 
			this.editor = pEditor; 
			this.keyword = pKeyword; 
			this.hits = pHits; 
			this.commentcount = pCommentCount; 
			this.updatetime = pUpdateTime; 
			this.createtime = pCreateTime; 
			this.ontop = pOnTop; 
			this.elite = pElite; 
			this.status = pStatus; 
			this.content = pContent; 
			this.includepic = pIncludePic; 
			this.defaultpicurl = pDefaultPicUrl; 
			this.uploadfiles = pUploadFiles; 
			this.infopoint = pInfoPoint; 
			this.paginationtype = pPaginationType; 
			this.deleted = pDeleted; 
			this.skinid = pSkinid; 
			this.templateid = pTemplateid; 
			this.stars = pStars; 
			this.titlefontcolor = pTitleFontColor; 
			this.titlefonttype = pTitleFontType; 
			this.maxcharperpage = pMaxCharPerPage; 
			this.showcommentlink = pShowCommentLink; 
			this.receive = pReceive; 
			this.receiveuser = pReceiveUser; 
			this.received = pReceived; 
			this.autoreceivetime = pAutoReceiveTime; 
			this.receivetype = pReceiveType; 
			this.intro = pIntro; 
			this.presentexp = pPresentExp; 
			this.copymoney = pCopymoney; 
			this.ispayed = pIsPayed; 
			this.beneficiary = pBeneficiary; 
			this.paydate = pPayDate; 
			this.voteid = pVoteid; 
			this.infopurview = pInfoPurview; 
			this.arrgroupid = pArrGroupid; 
			this.chargetype = pChargeType; 
			this.pitchtime = pPitchTime; 
			this.readtimes = pReadTimes; 
			this.dividepercent = pDividePercent; 
			this.blogid = pBlogid; 
		}
		
		public PE_Article(int pArticleid, int pChannelid, int pClassid, string pTitle, string pEditor, string pKeyword, int pHits, DateTime pUpdateTime, bool pOnTop, bool pElite, int pStatus, string pContent, int pIncludePic, bool pDeleted, bool pShowCommentLink, bool pReceive, bool pIsPayed)
		{
			this.articleid = pArticleid; 
			this.channelid = pChannelid; 
			this.classid = pClassid; 
			this.title = pTitle; 
			this.editor = pEditor; 
			this.keyword = pKeyword; 
			this.hits = pHits; 
			this.updatetime = pUpdateTime; 
			this.ontop = pOnTop; 
			this.elite = pElite; 
			this.status = pStatus; 
			this.content = pContent; 
			this.includepic = pIncludePic; 
			this.deleted = pDeleted; 
			this.showcommentlink = pShowCommentLink; 
			this.receive = pReceive; 
			this.ispayed = pIsPayed; 
		}
		
		#endregion
		
		#region Public Properties
		
		public virtual int ArticleID
		{
			get { return articleid; }
			set { _bIsChanged |= (articleid != value); articleid = value; }
			
		}
		
		public virtual int ChannelID
		{
			get { return channelid; }
			set { _bIsChanged |= (channelid != value); channelid = value; }
			
		}
		
		public virtual int ClassID
		{
			get { return classid; }
			set { _bIsChanged |= (classid != value); classid = value; }
			
		}
		
		public virtual string Title
		{
			get { return title; }
			set 
			{
			  if (value != null && value.Length > 255)
			    throw new ArgumentOutOfRangeException("Title", "Title value, cannot contain more than 255 characters");
			  _bIsChanged |= (title != value); 
			  title = value; 
			}
			
		}
		
		public virtual string TitleIntact
		{
			get { return titleintact; }
			set 
			{
			  if (value != null && value.Length > 255)
			    throw new ArgumentOutOfRangeException("TitleIntact", "TitleIntact value, cannot contain more than 255 characters");
			  _bIsChanged |= (titleintact != value); 
			  titleintact = value; 
			}
			
		}
		
		public virtual string Subheading
		{
			get { return subheading; }
			set 
			{
			  if (value != null && value.Length > 255)
			    throw new ArgumentOutOfRangeException("Subheading", "Subheading value, cannot contain more than 255 characters");
			  _bIsChanged |= (subheading != value); 
			  subheading = value; 
			}
			
		}
		
		public virtual string Author
		{
			get { return author; }
			set 
			{
			  if (value != null && value.Length > 255)
			    throw new ArgumentOutOfRangeException("Author", "Author value, cannot contain more than 255 characters");
			  _bIsChanged |= (author != value); 
			  author = value; 
			}
			
		}
		
		public virtual string CopyFrom
		{
			get { return copyfrom; }
			set 
			{
			  if (value != null && value.Length > 255)
			    throw new ArgumentOutOfRangeException("CopyFrom", "CopyFrom value, cannot contain more than 255 characters");
			  _bIsChanged |= (copyfrom != value); 
			  copyfrom = value; 
			}
			
		}
		
		public virtual string Inputer
		{
			get { return inputer; }
			set 
			{
			  if (value != null && value.Length > 20)
			    throw new ArgumentOutOfRangeException("Inputer", "Inputer value, cannot contain more than 20 characters");
			  _bIsChanged |= (inputer != value); 
			  inputer = value; 
			}
			
		}
		
		public virtual string LinkUrl
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
		
		public virtual string Editor
		{
			get { return editor; }
			set 
			{
			  if (value != null && value.Length > 20)
			    throw new ArgumentOutOfRangeException("Editor", "Editor value, cannot contain more than 20 characters");
			  _bIsChanged |= (editor != value); 
			  editor = value; 
			}
			
		}
		
		public virtual string Keyword
		{
			get { return keyword; }
			set 
			{
			  if (value != null && value.Length > 255)
			    throw new ArgumentOutOfRangeException("Keyword", "Keyword value, cannot contain more than 255 characters");
			  _bIsChanged |= (keyword != value); 
			  keyword = value; 
			}
			
		}
		
		public virtual int Hits
		{
			get { return hits; }
			set { _bIsChanged |= (hits != value); hits = value; }
			
		}
		
		public virtual int CommentCount
		{
			get { return commentcount; }
			set { _bIsChanged |= (commentcount != value); commentcount = value; }
			
		}
		
		public virtual DateTime UpdateTime
		{
			get { return updatetime; }
			set { _bIsChanged |= (updatetime != value); updatetime = value; }
			
		}
		
		public virtual DateTime CreateTime
		{
			get { return createtime; }
			set { _bIsChanged |= (createtime != value); createtime = value; }
			
		}
		
		public virtual bool OnTop
		{
			get { return ontop; }
			set { _bIsChanged |= (ontop != value); ontop = value; }
			
		}
		
		public virtual bool Elite
		{
			get { return elite; }
			set { _bIsChanged |= (elite != value); elite = value; }
			
		}
		
		public virtual int Status
		{
			get { return status; }
			set { _bIsChanged |= (status != value); status = value; }
			
		}
		
		public virtual string Content
		{
			get { return content; }
			set 
			{
			  if (value != null && value.Length > 1073741823)
			    throw new ArgumentOutOfRangeException("Content", "Content value, cannot contain more than 1073741823 characters");
			  _bIsChanged |= (content != value); 
			  content = value; 
			}
			
		}
		
		public virtual int IncludePic
		{
			get { return includepic; }
			set { _bIsChanged |= (includepic != value); includepic = value; }
			
		}
		
		public virtual string DefaultPicUrl
		{
			get { return defaultpicurl; }
			set 
			{
			  if (value != null && value.Length > 255)
			    throw new ArgumentOutOfRangeException("DefaultPicUrl", "DefaultPicUrl value, cannot contain more than 255 characters");
			  _bIsChanged |= (defaultpicurl != value); 
			  defaultpicurl = value; 
			}
			
		}
		
		public virtual string UploadFiles
		{
			get { return uploadfiles; }
			set 
			{
			  if (value != null && value.Length > 1073741823)
			    throw new ArgumentOutOfRangeException("UploadFiles", "UploadFiles value, cannot contain more than 1073741823 characters");
			  _bIsChanged |= (uploadfiles != value); 
			  uploadfiles = value; 
			}
			
		}
		
		public virtual int InfoPoint
		{
			get { return infopoint; }
			set { _bIsChanged |= (infopoint != value); infopoint = value; }
			
		}
		
		public virtual int PaginationType
		{
			get { return paginationtype; }
			set { _bIsChanged |= (paginationtype != value); paginationtype = value; }
			
		}
		
		public virtual bool Deleted
		{
			get { return deleted; }
			set { _bIsChanged |= (deleted != value); deleted = value; }
			
		}
		
		public virtual int SkinID
		{
			get { return skinid; }
			set { _bIsChanged |= (skinid != value); skinid = value; }
			
		}
		
		public virtual int TemplateID
		{
			get { return templateid; }
			set { _bIsChanged |= (templateid != value); templateid = value; }
			
		}
		
		public virtual int Stars
		{
			get { return stars; }
			set { _bIsChanged |= (stars != value); stars = value; }
			
		}
		
		public virtual string TitleFontColor
		{
			get { return titlefontcolor; }
			set 
			{
			  if (value != null && value.Length > 7)
			    throw new ArgumentOutOfRangeException("TitleFontColor", "TitleFontColor value, cannot contain more than 7 characters");
			  _bIsChanged |= (titlefontcolor != value); 
			  titlefontcolor = value; 
			}
			
		}
		
		public virtual int TitleFontType
		{
			get { return titlefonttype; }
			set { _bIsChanged |= (titlefonttype != value); titlefonttype = value; }
			
		}
		
		public virtual int MaxCharPerPage
		{
			get { return maxcharperpage; }
			set { _bIsChanged |= (maxcharperpage != value); maxcharperpage = value; }
			
		}
		
		public virtual bool ShowCommentLink
		{
			get { return showcommentlink; }
			set { _bIsChanged |= (showcommentlink != value); showcommentlink = value; }
			
		}
		
		public virtual bool Receive
		{
			get { return receive; }
			set { _bIsChanged |= (receive != value); receive = value; }
			
		}
		
		public virtual string ReceiveUser
		{
			get { return receiveuser; }
			set 
			{
			  if (value != null && value.Length > 1073741823)
			    throw new ArgumentOutOfRangeException("ReceiveUser", "ReceiveUser value, cannot contain more than 1073741823 characters");
			  _bIsChanged |= (receiveuser != value); 
			  receiveuser = value; 
			}
			
		}
		
		public virtual string Received
		{
			get { return received; }
			set 
			{
			  if (value != null && value.Length > 1073741823)
			    throw new ArgumentOutOfRangeException("Received", "Received value, cannot contain more than 1073741823 characters");
			  _bIsChanged |= (received != value); 
			  received = value; 
			}
			
		}
		
		public virtual int AutoReceiveTime
		{
			get { return autoreceivetime; }
			set { _bIsChanged |= (autoreceivetime != value); autoreceivetime = value; }
			
		}
		
		public virtual int ReceiveType
		{
			get { return receivetype; }
			set { _bIsChanged |= (receivetype != value); receivetype = value; }
			
		}
		
		public virtual string Intro
		{
			get { return intro; }
			set 
			{
			  if (value != null && value.Length > 1073741823)
			    throw new ArgumentOutOfRangeException("Intro", "Intro value, cannot contain more than 1073741823 characters");
			  _bIsChanged |= (intro != value); 
			  intro = value; 
			}
			
		}
		
		public virtual double PresentExp
		{
			get { return presentexp; }
			set { _bIsChanged |= (presentexp != value); presentexp = value; }
			
		}
		
		public virtual decimal Copymoney
		{
			get { return copymoney; }
			set { _bIsChanged |= (copymoney != value); copymoney = value; }
			
		}
		
		public virtual bool IsPayed
		{
			get { return ispayed; }
			set { _bIsChanged |= (ispayed != value); ispayed = value; }
			
		}
		
		public virtual string Beneficiary
		{
			get { return beneficiary; }
			set 
			{
			  if (value != null && value.Length > 200)
			    throw new ArgumentOutOfRangeException("Beneficiary", "Beneficiary value, cannot contain more than 200 characters");
			  _bIsChanged |= (beneficiary != value); 
			  beneficiary = value; 
			}
			
		}
		
		public virtual DateTime PayDate
		{
			get { return paydate; }
			set { _bIsChanged |= (paydate != value); paydate = value; }
			
		}
		
		public virtual int VoteID
		{
			get { return voteid; }
			set { _bIsChanged |= (voteid != value); voteid = value; }
			
		}
		
		public virtual int InfoPurview
		{
			get { return infopurview; }
			set { _bIsChanged |= (infopurview != value); infopurview = value; }
			
		}
		
		public virtual string arrGroupID
		{
			get { return arrgroupid; }
			set 
			{
			  if (value != null && value.Length > 255)
			    throw new ArgumentOutOfRangeException("arrGroupID", "arrGroupID value, cannot contain more than 255 characters");
			  _bIsChanged |= (arrgroupid != value); 
			  arrgroupid = value; 
			}
			
		}
		
		public virtual int ChargeType
		{
			get { return chargetype; }
			set { _bIsChanged |= (chargetype != value); chargetype = value; }
			
		}
		
		public virtual int PitchTime
		{
			get { return pitchtime; }
			set { _bIsChanged |= (pitchtime != value); pitchtime = value; }
			
		}
		
		public virtual int ReadTimes
		{
			get { return readtimes; }
			set { _bIsChanged |= (readtimes != value); readtimes = value; }
			
		}
		
		public virtual int DividePercent
		{
			get { return dividepercent; }
			set { _bIsChanged |= (dividepercent != value); dividepercent = value; }
			
		}
		
		public virtual int BlogID
		{
			get { return blogid; }
			set { _bIsChanged |= (blogid != value); blogid = value; }
			
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
	
	#region Custom ICollection interface for PE_Article 

	
	public interface IPE_ArticleCollection : ICollection
	{
		PE_Article this[int index]{	get; set; }
		void Add(PE_Article pPE_Article);
		void Clear();
	}
	
	[Serializable]
	public class PE_ArticleCollection : IPE_ArticleCollection
	{
		private IList<PE_Article> _arrayInternal;

		public PE_ArticleCollection()
		{
			_arrayInternal = new List<PE_Article>();
		}
		
		public PE_ArticleCollection( IList<PE_Article> pSource )
		{
			_arrayInternal = pSource;
			if(_arrayInternal == null)
			{
				_arrayInternal = new List<PE_Article>();
			}
		}

		public PE_Article this[int index]
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
		public void CopyTo(Array array, int index){ _arrayInternal.CopyTo((PE_Article[])array, index); }
		public IEnumerator GetEnumerator() { return _arrayInternal.GetEnumerator(); }
		public void Add(PE_Article pPE_Article) { _arrayInternal.Add(pPE_Article); }
		public void Clear() { _arrayInternal.Clear(); }
		public IList<PE_Article> GetList() { return _arrayInternal; }
	 }
	
	#endregion
}
