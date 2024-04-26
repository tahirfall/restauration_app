/*
 * Created by SharpDevelop.
 * User: fallt
 * Date: 18/08/2023
 * Time: 21:40
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Gestion_restaurant
{
	/// <summary>
	/// Description of Restaurateur.
	/// </summary>
	public class Restaurateur : Utilisateur
	{
		public Restaurateur() 
		{
		}
		
		public Restaurateur(int id, string nom, string prenom, string role, string login, string password) : 
							base(id, nom, prenom, role, login, password)
		{
		}
	}
}




