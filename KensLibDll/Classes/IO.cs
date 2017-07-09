using System;
using System.Runtime.CompilerServices;

namespace KensLibDll
{
	public class IO
	{
		// PROPERTIES
		private string _className;

		// CONSTRUCTOR
		public IO ()
		{
			this._className = this.GetType ().Name;
			p ("Class instantiated: " + this._className);
		}

		// METHODS
		/// <summary>
		/// this method is for printing to teh command line
		/// </summary>
		/// <param name="s">S.</param>
		public void p (string s)
		{
			Console.WriteLine (s);
		}

		/// <summary>
		/// this method is for logging to whatever the app is using for logging defaults
		/// </summary>
		/// <param name="s">S.</param>
		public void l (string s){
			p (s);
		}
	}
}
