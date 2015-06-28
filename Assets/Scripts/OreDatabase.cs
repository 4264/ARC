using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class OreDatabase : MonoBehaviour {

	public List<OreItem> oreData = new List<OreItem>();

	// Use this for initialization
	void Awake () 
	{
		oreData.Add (new OreItem(OreItem.oreType.Aura, 6.03f, 1152.32f, 2251.03f, 0.24f, 0.71f, 0.12f, 0.34f, 0.61f, 0.12f));
		oreData.Add (new OreItem(OreItem.oreType.Argenta, 7.32f, 1879.45f, 2637.54f, 0.45f, 0.34f, 0.89f, 0.7f, 0.78f, 0.45f));
		oreData.Add (new OreItem(OreItem.oreType.Critla, 5.87f, 1206.34f, 2698.15f, 0.33f, 0.65f, 0.14f, 0.5f, 0.13f, 0.21f));
		oreData.Add (new OreItem(OreItem.oreType.Du, 8.43f, 993.02f, 2492.87f, 0.21f, 0.76f, 0.53f, 0.15f, 0.87f, 0.79f));
		oreData.Add (new OreItem(OreItem.oreType.Ferra, 7.45f, 1892.74f, 3412.65f, 0.21f, 0.86f, 0.65f, 0.34f, 0.23f, 0.32f));
		oreData.Add (new OreItem(OreItem.oreType.Flouru, 6.23f, 1732.54f, 2861.92f, 0.23f, 0.17f, 0.87f, 0.43f, 0.23f, 0.76f));
		oreData.Add (new OreItem(OreItem.oreType.Genta, 6.87f, 1462.54f, 2434.87f, 0.93f, 0.14f, 0.34f, 0.89f, 0.65f, 0.65f));
		oreData.Add (new OreItem(OreItem.oreType.Hexra, 7.54f, 1745.93f, 2391.58f, 0.54f, 0.97f, 0.76f, 0.34f, 0.23f, 0.09f));
		oreData.Add (new OreItem(OreItem.oreType.Hropo, 9.93f, 1597.43f, 2563.52f, 0.14f, 0.66f, 0.84f, 0.32f, 0.47f, 0.52f));		//9
	}
}
