using System;



namespace KensLibDll
{
	/// <summary>
	/// KensLib is a library developed by Ken Shaw to contain various cross platform logic.
	/// It contains various sub classes.
	/// </summary>

	public class MainUtilityObject
	{   
		#region Constructors
		// constructor
		public MainUtilityObject ()
		{
			this._name = "Ken Shaw's Awsome Lib";
			this._nl = System.Environment.NewLine;

		}
		#endregion

		#region Properties
		// properties
		// mutable properties
		private string _name;
		private string _nl;


		// immutable propertiers
		private readonly string _author = "Ken Shaw";
		private readonly DateTime _creationDate = DateTime.Parse("25 Nov 2014");

		// API methods
		#endregion

		#region Methods
		/// <summary>
		/// Gets the library info.  And returns it as a string.
		/// </summary>
		/// <returns>The library info.</returns>
		public string GetLibraryInfo(){
			System.Text.StringBuilder s = new System.Text.StringBuilder ();
			s.Append ("-------------------------" + _nl);
			s.Append ("About this Library:" + _nl);
			s.Append ("Library Name: " + _name + _nl);
			s.Append ("Author: " + _author + _nl);
			s.Append ("Original publication date: " + _creationDate + _nl);
			s.Append ("Contact Email: ken@infrascale.com" + _nl);
			s.Append ("-------------------------" + _nl);




			return s.ToString ();
		}
		#endregion
	}



	 
}

