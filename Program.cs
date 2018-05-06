/*
 * Created by SharpDevelop.
 * User: William
 * Date: 11/03/2018
 * Time: 16:46
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace ConversionBinaire
{
	class Program
	{
		public static void Main(string[] args)
		{
			
			string chaineBinaire ="";
			
			//La variable chaine binaire servira à enregistrer les bit, une fois réalisée a 100%
			
			// Pour convertir un nombre en binaire il faut le décomposer aux nombre uniquement qui se suivent
			// en multipliant successivement par deux le chiffre 1.
			
			//On enregistre le nombre dans une variable
			Console.Write("Taper un nombre: ");
			int nombreAconvertir = Convert.ToInt16(Console.ReadLine());
			
			//on retire le plus haut nombre successif de 1 inferieur au égal au nombre à convertir
			//avec une autre variable nbSoustrait
			
			int nbSoustrait = 1; bool ok = true;// boolean pour sortir de la condition si le travail est fini
			
			
			int sauvegarde = nombreAconvertir; // on sauvergarde la valeur
			do{
				
				
				
				if(nombreAconvertir==1)// si le nombre binaire est 1
				{
					
					chaineBinaire+="1";
					break;
					
				}
				
				nbSoustrait*=2;
				if(nbSoustrait>nombreAconvertir)// une fois dépassé on divise par deux pour avoir le bon nombre
					// et on l'enlève au nombre a convertir
				{
					//On commence à incrémenter la chaune avec 1 bit
					
					
					
					
					chaineBinaire+="1";
					nbSoustrait/=2;
					nombreAconvertir -= nbSoustrait;
					
					
					
					
					
					
					//Pour ajouter un zero, le nombre doit être égal un a nombre successif et supérieur au nombre a convertir
					// on prend une variable qui prend la valeur du nombre soustrait et le divise par deux en respectant la condition
					int CopieNbSoutrait = nbSoustrait;
					do
					{
						CopieNbSoutrait/=2;
						
						if(CopieNbSoutrait>nombreAconvertir)
						{
							chaineBinaire+="0";
						}
						
					}while(CopieNbSoutrait>nombreAconvertir);
					
					//la condition devant fausse par nécessité incrémente un zéro de trop
					// il faut toujours en enlever un
					
					
					// maintenant on réinitialise la variable nbSoustrait pour effectuer un autre tour  si nécessaire
					// et une autre soustraction
					nbSoustrait=1;
					
					
					
					
				}
				
				
				
				if(nbSoustrait==nombreAconvertir)// Si le nombre à convertir est égale a un nombre successif
					// dès le premier tour ou si le reste après la soustraction du premier if est aussi égale
					// alors on incrémente la chaine et le travail est terminé
				{
					chaineBinaire+="1"; 
					
					//il faut ajouter des zero à la fin si le nombre a convertir restant et successif à la fois est au minimum 2
					//Il faut diviser une variable = au nombre succesif jusqu'a un
					
					int Copie= nombreAconvertir; bool petitOk= false;
					
					do// tant qu'on a pas atteint le nombre un on ajoute un zero jusqu'a l'atteindre
					{
						Copie/=2;
						if(Copie>0)
						{
							chaineBinaire+="0";
						}
						
						else
						{
							petitOk=true;
						}
						
					}while(!petitOk);
					
					ok = false;
				}
				
				
				
				
				
			}while(ok);
			
			
				
			
			Console.WriteLine(sauvegarde+" vaut "+chaineBinaire+" en binaire");
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
		
	}
}