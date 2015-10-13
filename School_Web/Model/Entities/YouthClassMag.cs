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
	/// IYouthClassMag interface for NHibernate mapped table 'Youth_class_mag'.
	/// </summary>
	public interface IYouthClassMag
	{
		#region Public Properties
		
		int MagId
		{
			get ;
			set ;
			  
		}
		
		int YouthStid
		{
			get ;
			set ;
			  
		}
		
		int ClassId
		{
			get ;
			set ;
			  
		}
		
		string MagUsername
		{
			get ;
			set ;
			  
		}
		
		bool State
		{
			get ;
			set ;
			  
		}
		
		bool IsDeleted { get; set; }
		bool IsChanged { get; set; }
		
		#endregion 
	}

	/// <summary>
	/// YouthClassMag object for NHibernate mapped table 'Youth_class_mag'.
	/// </summary>
	[Serializable]
	public class YouthClassMag : IYouthClassMag
	{
		#region Member Variables

		protected int magid;
		protected int youthstid;
		protected int classid;
		protected string magusername;
		protected bool state;
		protected bool _bIsDeleted;
		protected bool _bIsChanged;
		#endregion
		
		#region Constructors
		public YouthClassMag() {}
		
		public YouthClassMag(int pYouthStid, int pClassId, string pMagUsername, bool pState)
		{
			this.youthstid = pYouthStid; 
			this.classid = pClassId; 
			this.magusername = pMagUsername; 
			this.state = pState; 
		}
		
		public YouthClassMag(int pMagId)
		{
			this.magid = pMagId; 
		}
		
		#endregion
		
		#region Public Properties
		
		public int MagId
		{
			get { return magid; }
			set { _bIsChanged |= (magid != value); magid = value; }
			
		}
		
		public int YouthStid
		{
			get { return youthstid; }
			set { _bIsChanged |= (youthstid != value); youthstid = value; }
			
		}
		
		public int ClassId
		{
			get { return classid; }
			set { _bIsChanged |= (classid != value); classid = value; }
			
		}
		
		public string MagUsername
		{
			get { return magusername; }
			set 
			{
			  if (value != null && value.Length > 50)
			    throw new ArgumentOutOfRangeException("MagUsername", "MagUsername value, cannot contain more than 50 characters");
			  _bIsChanged |= (magusername != value); 
			  magusername = value; 
			}
			
		}
		
		public bool State
		{
			get { return state; }
			set { _bIsChanged |= (state != value); state = value; }
			
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
	
	#region Custom ICollection interface for YouthClassMag 

	
	public interface IYouthClassMagCollection : ICollection
	{
		YouthClassMag this[int index]{	get; set; }
		void Add(YouthClassMag pYouthClassMag);
		void Clear();
	}
	
	[Serializable]
	public class YouthClassMagCollection : IYouthClassMagCollection
	{
		private IList<YouthClassMag> _arrayInternal;

		public YouthClassMagCollection()
		{
			_arrayInternal = new List<YouthClassMag>();
		}
		
		public YouthClassMagCollection( IList<YouthClassMag> pSource )
		{
			_arrayInternal = pSource;
			if(_arrayInternal == null)
			{
				_arrayInternal = new List<YouthClassMag>();
			}
		}

		public YouthClassMag this[int index]
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
		public void CopyTo(Array array, int index){ _arrayInternal.CopyTo((YouthClassMag[])array, index); }
		public IEnumerator GetEnumerator() { return _arrayInternal.GetEnumerator(); }
		public void Add(YouthClassMag pYouthClassMag) { _arrayInternal.Add(pYouthClassMag); }
		public void Clear() { _arrayInternal.Clear(); }
		public IList<YouthClassMag> GetList() { return _arrayInternal; }
	 }
	
	#endregion
}
