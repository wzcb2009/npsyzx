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
	/// IAsstsApplyState interface for NHibernate mapped table 'Assts_Apply_state'.
	/// </summary>
	public interface IAsstsApplyState
	{
		#region Public Properties
		
		int Id
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
		
		int Dj
		{
			get ;
			set ;
			  
		}
		
		bool IsDeleted { get; set; }
		bool IsChanged { get; set; }
		
		#endregion 
	}

	/// <summary>
	/// AsstsApplyState object for NHibernate mapped table 'Assts_Apply_state'.
	/// </summary>
	[Serializable]
	public class AsstsApplyState : IAsstsApplyState
	{
		#region Member Variables

		protected int id;
		protected string statename;
		protected string color;
		protected int dj;
		protected bool _bIsDeleted;
		protected bool _bIsChanged;
		#endregion
		
		#region Constructors
		public AsstsApplyState() {}
		
		public AsstsApplyState(int pId, string pStatename, string pColor, int pDj)
		{
			this.id = pId; 
			this.statename = pStatename; 
			this.color = pColor; 
			this.dj = pDj; 
		}
		
		public AsstsApplyState(int pId)
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
		
		public int Dj
		{
			get { return dj; }
			set { _bIsChanged |= (dj != value); dj = value; }
			
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
	
	#region Custom ICollection interface for AsstsApplyState 

	
	public interface IAsstsApplyStateCollection : ICollection
	{
		AsstsApplyState this[int index]{	get; set; }
		void Add(AsstsApplyState pAsstsApplyState);
		void Clear();
	}
	
	[Serializable]
	public class AsstsApplyStateCollection : IAsstsApplyStateCollection
	{
		private IList<AsstsApplyState> _arrayInternal;

		public AsstsApplyStateCollection()
		{
			_arrayInternal = new List<AsstsApplyState>();
		}
		
		public AsstsApplyStateCollection( IList<AsstsApplyState> pSource )
		{
			_arrayInternal = pSource;
			if(_arrayInternal == null)
			{
				_arrayInternal = new List<AsstsApplyState>();
			}
		}

		public AsstsApplyState this[int index]
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
		public void CopyTo(Array array, int index){ _arrayInternal.CopyTo((AsstsApplyState[])array, index); }
		public IEnumerator GetEnumerator() { return _arrayInternal.GetEnumerator(); }
		public void Add(AsstsApplyState pAsstsApplyState) { _arrayInternal.Add(pAsstsApplyState); }
		public void Clear() { _arrayInternal.Clear(); }
		public IList<AsstsApplyState> GetList() { return _arrayInternal; }
	 }
	
	#endregion
}
