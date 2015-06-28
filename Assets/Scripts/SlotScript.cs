using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class SlotScript : MonoBehaviour, IPointerDownHandler, IPointerEnterHandler, IPointerExitHandler {

	public Item item;
	Inventory inventory;
	Image itemImage;
	Image background;
	public int slotNumber;
	bool show = true;
	// Use this for initialization
	void Start () {

		background = gameObject.GetComponent<Image>();
		inventory = GameObject.FindGameObjectWithTag("Inventory").GetComponent<Inventory>();
		itemImage = gameObject.transform.GetChild(0).GetComponent<Image>();

	}

	public void setShow(bool b)
	{
		show = b;
	}

	// Update is called once per frame
	void Update () 
	{
		//Debug.Log(slotNumber);
		if(show && inventory.items[slotNumber].itemID != -1)
		{
			background.enabled = true;
			itemImage.enabled = true;
			itemImage.sprite = inventory.items[slotNumber].itemIcon;
		}
		else
		{
			itemImage.enabled = false;
			if(!show)
			{
				background.enabled = false;
			}
			else
			{
				background.enabled = true;
			}
		}

	}

	public void OnPointerDown(PointerEventData data)
	{
		Debug.Log(inventory.items[slotNumber].itemName);
	}

	public void OnPointerEnter(PointerEventData data)
	{
		if(inventory.items[slotNumber].itemID != -1)
		{
			inventory.createToolTip(inventory.slots[slotNumber].GetComponent<RectTransform>().localPosition, inventory.items[slotNumber]);
		}
	}

	public void OnPointerExit(PointerEventData data)
	{
		if(inventory.items[slotNumber].itemID != -1)
		{
			inventory.closeToolTip();
		}
	}
}

