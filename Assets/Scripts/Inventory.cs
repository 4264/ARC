using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class Inventory : GenericWindow {
	public GameObject slot;
	public List<Item> inventory = new List<Item> ();
	public List<Item> items = new List<Item> ();
	public int slotsX, slotsY;
	public GUISkin skin;
	public List<GameObject> slots = new List<GameObject> ();
	private ItemDatabase database;
	private bool showInventory = true;
	private bool showToolTip;
	private bool draggingItem;
	private Item draggedItem;
	private int prevIndex;
	bool show = true;
	Image background;

	public GameObject tooltip;

	void Start ()
	{
		background = gameObject.GetComponent<Image>();
		database = GameObject.FindGameObjectWithTag ("Item Database").GetComponent<ItemDatabase> ();

		int slotInd = 0;

		float x = 5f;
		float y = -5f;


		for(int i = 0; i < slotsX; i++)
		{
			for(int j = 0; j < slotsY; j++)
			{

				GameObject g = Instantiate(slot) as GameObject;
				g.GetComponent<SlotScript>().slotNumber = slotInd;
				g.transform.parent = this.gameObject.transform;
				g.GetComponent<RectTransform>().localPosition = new Vector3(x,y,0f);
				g.name = "Slot" + i + "," + j;
				slots.Add (g);
				items.Add(new Item());
				x += 55;
				if(x > 55 * 2 + 5)
				{
					x = 5f;
					y -= 55f;
				}
				slotInd++;
			}
		}

		AddItem(0);
		AddItem(1);
	}

	public override void SetShowing(bool b)
	{
		Debug.Log("Setting Show" + b);
		show = b;
		for(int i = 0; i < slots.Count; i++)
		{
			slots[i].GetComponent<SlotScript>().setShow(show);
		}
		background.enabled = show;
	}

	public void createToolTip(Vector3 Toolpos, Item item)
	{
		tooltip.gameObject.SetActive(true);
	}

	public void closeToolTip()
	{
		tooltip.gameObject.SetActive (false);
	}

	/// <summary>
	/// Adds the item based on the ID.
	/// </summary>
	/// <param name="id">ID of the item to add</param>
	void AddItem (int id)
	{
		for(int i = 0; i < items.Count; i++)
		{
			if(items[i].itemID == -1)
			{
				items[i] = (database.getId(id));
				break;
			}
		}
	}

	/*void RemoveItem(int id)
	{
		for(int i = 0; i < inventory.Count; i++)
		{
			if(inventory[i].itemID == id)
			{
				inventory[i] = new Item();
				break;
			}
		}
	}
	bool InventoryContains(int id)
	{
		for(int i = 0; i < inventory.Count; i++)
		{
			if(inventory[i].itemID == id)
			{
				return true;
			}
		}
		return false;
	}



	void loadInventory()
	{
		for(int i = 0; i < inventory.Count; i++)
		{
			inventory[i] = PlayerPrefs.GetInt("Inventory " + i, -1) >= 0 ? database.items[PlayerPrefs.GetInt("Inventory " + i)] : new Item();
		}
	}

	void saveInventory()
	{
		for(int i = 0; i < inventory.Count; i++)
		{
			PlayerPrefs.SetInt ("Inventory " + i, inventory[i].itemID);
		}
	}*/
}
