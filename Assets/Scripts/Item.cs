using UnityEngine;
using System.Collections;

[System.Serializable]
public class Item
{

	public string itemName;

	public int itemID;
	public string itemDesc;
	public Sprite itemIcon;
	public ItemType itemType;
	public int itemWeight;

	public enum ItemType
	{
		Weapon,
		Consumable,
		Quest,
		Armor,
		Resource
	}

	public Item(string name, int id, string desc, int weight, ItemType type)
	{
		itemName = name;
		itemDesc = desc;
		itemID = id;
		itemWeight = weight;
		itemType = type;
		itemIcon = Resources.Load<Sprite>("ItemIcons/" + name);
	}
	public Item()
	{
		itemID = -1;
	}
}
