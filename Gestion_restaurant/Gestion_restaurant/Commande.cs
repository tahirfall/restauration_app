/*
 * Created by SharpDevelop.
 * User: fallt
 * Date: 21/08/2023
 * Time: 12:24
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Gestion_restaurant
{
	/// <summary>
	/// Description of Commande.
	/// </summary>
	public class Commande
	{
		
        public int Id { get; set; }
        public string IntitulesProduits { get; set; }
        public int Quantite { get; set; }
        public double PrixTotal { get; set; }
        public string Etat { get; set; }
        public Date DateCommande { get; set; } // Supposons que vous ayez une classe Date comme dans votre exemple

        public Commande(int id, string intitulesProduits, int quantite, double prixTotal, string etat, Date dateCommande)
        {
            Id = id;
            IntitulesProduits = intitulesProduits;
            Quantite = quantite;
            PrixTotal = prixTotal;
            Etat = etat;
            DateCommande = dateCommande;
        }
	
        
        /*
        public override string ToString()
        {
            return "ID: {Id}, Produits: {IntitulesProduits}, Quantité: {Quantite}, Prix Total: {PrixTotal}, État: {Etat}, Date: {DateCommande}";
        }
        */
        
        

	}
}




