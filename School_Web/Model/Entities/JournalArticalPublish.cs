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
	/// IJournalArticalPublish interface for NHibernate mapped table 'Journal_Artical_publish'.
	/// </summary>
	public interface IJournalArticalPublish
	{
		#region Public Properties
		
		int Id
		{
			get ;
			set ;
			  
		}
		
		int Articalid
		{
			get ;
			set ;
			  
		}
		
		int Qkid
		{
			get ;
			set ;
			  
		}
		
		bool IsDeleted { get; set; }
		bool IsChanged { get; set; }
		
		#endregion 
	}

	/// <summary>
	/// JournalArticalPublish object for NHibernate mapped table 'Journal_Artical_publish'.
	/// </summary>
	[Serializable]
	public class JournalArticalPublish : IJournalArticalPublish
	{
		#region Member Variables

		protected int id;
		protected int articalid;
		protected int qkid;
		protected bool _bIsDeleted;
		protected bool _bIsChanged;
		#endregion
		
		#region Constructors
		public JournalArticalPublish() {}
		
		public JournalArticalPublish(int pArticalid, int pQkid)
		{
			this.articalid = pArticalid; 
			this.qkid = pQkid; 
		}
		
		public JournalArticalPublish(int pId)
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
		
		public int Articalid
		{
			get { return articalid; }
			set { _bIsChanged |= (articalid != value); articalid = value; }
			
		}
		
		public int Qkid
		{
			get { return qkid; }
			set { _bIsChanged |= (qkid != value); qkid = value; }
			
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
	
	#region Custom ICollection interface for JournalArticalPublish 

	
	public interface IJournalArticalPublishCollection : ICollection
	{
		JournalArticalPublish this[int index]{	get; set; }
		void Add(JournalArticalPublish pJournalArticalPublish);
		void Clear();
	}
	
	[Serializable]
	public class JournalArticalPublishCollection : IJournalArticalPublishCollection
	{
		private IList<JournalArticalPublish> _arrayInternal;

		public JournalArticalPublishCollection()
		{
			_arrayInternal = new List<JournalArticalPublish>();
		}
		
		public JournalArticalPublishCollection( IList<JournalArticalPublish> pSource )
		{
			_arrayInternal = pSource;
			if(_arrayInternal == null)
			{
				_arrayInternal = new List<JournalArticalPublish>();
			}
		}

		public JournalArticalPublish this[int index]
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
		public void CopyTo(Array array, int index){ _arrayInternal.CopyTo((JournalArticalPublish[])array, index); }
		public IEnumerator GetEnumerator() { return _arrayInternal.GetEnumerator(); }
		public void Add(JournalArticalPublish pJournalArticalPublish) { _arrayInternal.Add(pJournalArticalPublish); }
		public void Clear() { _arrayInternal.Clear(); }
		public IList<JournalArticalPublish> GetList() { return _arrayInternal; }
	 }
	
	#endregion
}
