/*
 * Created by SharpDevelop.
 * User: fallt
 * Date: 20/08/2023
 * Time: 13:23
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Gestion_restaurant
{
	/// <summary>
	/// Description of Produit.
	/// </summary>
	public class Produit
	{
		private int id, quantite;
		private string intitule, description;
		private double prix;
		
		
		
		
		public Produit()
		{
		}
		
		public Produit(int id, string intitule, double prix, int quantite, string description)
		{
			this.id = id;
			this.intitule = intitule;
			this.prix = prix;
			this.prix = prix;
			this.description = description;
		}
		
		public Produit(string intitule, double prix, int quantite, string description)
		{
			this.intitule = intitule;
			this.prix = prix;
			this.quantite = quantite;
			this.description = description;
		}
		
		public int Id
		{
			get{return id;}
			set{id = value;}
		}
		
		public string Intitule
		{
			get{return intitule;}
			set{intitule = value;}
		}
		
		public double Prix
		{
			get{return prix;}
			set{prix = value;}
		}
		
		public int Quantite
		{
			get{return quantite;}
			set{quantite = value;}
		}
		
		public string Description
		{
			get{return description;}
			set{description = value;}
		}
	}
}




