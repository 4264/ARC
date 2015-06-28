using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class SpellBook : MonoBehaviour {

	public List<Spell> spellBook = new List<Spell>();
	public int slots;


	public void Add(Spell spell)
	{
		spellBook.Add(spell);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
