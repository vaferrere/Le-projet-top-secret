using UnityEngine;
using System.Collections;

public enum Classe { Guerrier,Archer,Catapulte};
public enum Capacite { Rien , Entraide , Medecin , Ralliement , Espion , Charge , Moral  };
public enum Faction { Neutre , RoyaumeDuNord , Monstre , Nilfgaard , Scoiateal };
public class CarteSoldat : Carte {

    public int valeur;

    public Classe classe;

    public Capacite capacite;

    
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
