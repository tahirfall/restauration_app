/*
 * Created by SharpDevelop.
 * User: fallt
 * Date: 21/08/2023
 * Time: 11:37
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Gestion_restaurant
{
	/// <summary>
	/// Description of Date.
	/// </summary>
	public class Date
	{
		
		private int jour;
	    private int mois;
	    private int annee;
	
	    public int Jour
	    {
	        get { return jour; }
	        set { jour = value; }
	    }
	
	    public int Mois
	    {
	        get { return mois; }
	        set { mois = value; }
	    }
	
	    public int Annee
	    {
	        get { return annee; }
	        set { annee = value; }
	    }
	
	    public Date(int jour, int mois, int annee)
	    {
	        this.jour = jour;
	        this.mois = mois;
	        this.annee = annee;
	    }
	
	    public override string ToString()
	    {
	        return jour + "/" + mois + "/" + annee;
	    }
	}
}





