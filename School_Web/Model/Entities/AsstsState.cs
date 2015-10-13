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
	/// IAsstsState interface for NHibernate mapped table 'assts_state'.
	/// </summary>
	public interface IAsstsState
	{
		#region Public Properties
		
		int Stateid
		{
			get ;
			set ;
			  
		}
		
		string Statename
		{
			get ;
			set ;
			  
		}
		
		string Color
		{
			get ;
			set ;
			  
		}
		
		bool IsDeleted { get; set; }
		bool IsChanged { get; set; }
		
		#endregion 
	}

	/// <summary>
	/// AsstsState object for NHibernate mapped table 'assts_state'.
	/// </summary>
	[Serializable]
	public class AsstsState : IAsstsState
	{
		#region Member Variables

		protected int stateid;
		protected string statename;
		protected string color;
		protected bool _bIsDeleted;
		protected bool _bIsChanged;
		#endregion
		
		#region Constructors
		public AsstsState() {}
		
		public AsstsState(int pStateid, string pStatename, string pColor)
		{
			this.stateid = pStateid; 
			this.statename = pStatename; 
			this.color = pColor; 
		}
		
		public AsstsState(int pStateid)
		{
			this.stateid = pStateid; 
		}
		
		#endregion
		
		#region Public Properties
		
		public int Stateid
		{
			get { return stateid; }
			set { _bIsChanged |= (stateid != value); stateid = value; }
			
		}
		
		public string Statename
		{
			get { return statename; }
			set 
			{
			  if (value != null && value.Length > 50)
			    throw new ArgumentOutOfRangeException("Statename", "Statename value, cannot contain more than 50 characters");
			  _bIsChanged |= (statename != value); 
			  statename = value; 
			}
			
		}
		
		public string Color
		{
			get { return color; }
			set 
			{
			  if (value != null && value.Length > 50)
			    throw new ArgumentOutOfRangeException("Color", "Color value, cannot contain more than 50 characters");
			  _bIsChanged |= (color != value); 
			  color = value; 
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
	
	#region Custom ICollection interface for AsstsState 

	
	public interface IAsstsStateCollection : ICollection
	{
		AsstsState this[int index]{	get; set; }
		void Add(AsstsState pAsstsState);
		void Clear();
	}
	
	[Serializable]
	public class AsstsStateCollection : IAsstsStateCollection
	{
		private IList<AsstsState> _arrayInternal;

		public AsstsStateCollection()
		{
			_arrayInternal = new List<AsstsState>();
		}
		
		public AsstsStateCollection( IList<AsstsState> pSource )
		{
			_arrayInternal = pSource;
			if(_arrayInternal == null)
			{
				_arrayInternal = new List<AsstsState>();
			}
		}

		public AsstsState this[int index]
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
		public void CopyTo(Array array, int index){ _arrayInternal.CopyTo((AsstsState[])array, index); }
		public IEnumerator GetEnumerator() { return _arrayInternal.GetEnumerator(); }
		public void Add(AsstsState pAsstsState) { _arrayInternal.Add(pAsstsState); }
		public void Clear() { _arrayInternal.Clear(); }
		public IList<AsstsState> GetList() { return _arrayInternal; }
	 }
	
	#endregion
}
