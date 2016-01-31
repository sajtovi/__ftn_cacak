/*
 * Created by SharpDevelop.
 * User: player
 * Date: 1/17/2016
 * Time: 10:32 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */

using System;
using System.Collections;
using System.String;

class Program
{
    static void Main()
    {
		string[] ime = {"Sanja", "Ana", "Nena", "Anita"};
	
	var rezultat = from n in ime
		where n.StartsWith("A") select n;
		
		Console.WriteLine(rezultat);
    }
}