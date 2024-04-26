/*
 * Created by SharpDevelop.
 * User: fallt
 * Date: 18/08/2023
 * Time: 21:35
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Gestion_restaurant
{
	/// <summary>
	/// Description of Administrateur.
	/// </summary>
	public class Administrateur : Utilisateur
	{
		public Administrateur()
		{			
		}
		
		public Administrateur(int id, string nom, string prenom, string role, string login, string password) : 
							base(id, nom, prenom, role, login, password)
		{			
		}
	}
}




