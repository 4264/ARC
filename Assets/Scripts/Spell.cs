using UnityEngine;
using System.Collections;

public class Spell : MonoBehaviour {

	public string spellName;

	public int spellID;
	public string spellDesc;
	public SpellType spellType;
	public SpellFamily spellFamily;
	public SpellFamily spellSubfamily;

	public enum SpellType
	{
		Shot,		//single sphere shot from the character
		AoE,		//a radius of effect from the character
		Self,		//targets the player (yeah, that's why it's named that)
		Wall,		//creates a circle of energy around the player
		Targeted	//seeks the nearest entity to attack (can be set to avoid friendlies)
	}
	public enum SpellFamily
	{
		Water,
		Fire,
		Earth,
		Air,
		Negative,
		Positive,
		Arcane
	}

	public Spell(string name, int id, string desc, SpellType type, SpellFamily fm, SpellFamily sm)
	{
		spellName = name;
		spellID = id;
		spellDesc = desc;
		spellType = type;
		spellFamily = fm;
		spellSubfamily = sm;
	}

	public Spell()
	{
		spellID = -1;
	}
}
