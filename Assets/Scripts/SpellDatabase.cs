using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class SpellDatabase : MonoBehaviour {

	public List<Spell> spells = new List<Spell>();

	void Awake()
	{
		spells.Add(new Spell("positive rush", 0, "emits a weak positive energy pulse", Spell.SpellType.Shot, Spell.SpellFamily.Positive, Spell.SpellFamily.Arcane));
	}

	Spell getId(int id)
	{
		for(int i = 0; i < spells.Count; i++)
		{
			if(spells[i].spellID == id)
			{
				return spells[i];
			}
		}
		return new Spell();
	}
}
