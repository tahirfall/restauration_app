/*
 * Created by SharpDevelop.
 * User: fallt
 * Date: 18/08/2023
 * Time: 21:25
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Gestion_restaurant
{
	/// <summary>
	/// Description of Utilisateur.
	/// </summary>
	public class Utilisateur
	{
		
		protected int id;
		protected string nom, prenom, role, login, password;
			
		
		public Utilisateur()
		{	
		}
		
		public Utilisateur(int id, string nom, string prenom, string role, string login, string password)
		{
			this.id = id;
			this.nom = nom;
			this.prenom = prenom;
			this.role = role;	
			this.login = login;
			this.password = password;	
		}
		
		public int Id
		{
			get{return id;}
			set{id = value;}
		}
		public string Prenom
		{
			get{return prenom;}
			set{prenom = value;}
		}
		
		public string Nom
		{
			get{return nom;}
			set{nom = value;}
		}
		
		public string Role
		{
			get{return role;}
			set{role = value;}
		}
		
		public string Login
		{
			get{return login;}
			set{login = value;}
		}
		
		public string Password
		{
			get{return password;}
			set{password = value;}
		}
	}
}
