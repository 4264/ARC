using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ItemDatabase : MonoBehaviour 
{
	public List<Item> items = new List<Item>();


	void Awake ()
	{
		items.Add(new Item("Amulet of Prayer", 0, "An amulet enchanted by prayers to the gods", 1, Item.ItemType.Weapon));
		items.Add(new Item("Helm of Justice", 1, "A helmet that reveals the justice to be given to the person", 3, Item.ItemType.Armor));
		items.Add(new Item("Health Potion", 2, "heals the drinker", 1, Item.ItemType.Consumable));
	}

	public Item getId(int id)
	{
		for(int i = 0; i < items.Count; i++)
		{
			if(items[i].itemID == id)
			{
				return items[i];
			}
		}
		return new Item();
	}
}
