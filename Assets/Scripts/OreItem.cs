using UnityEngine;
using System.Collections;

[System.Serializable]
public class OreItem : Item {

	public oreType type;
	public float quantity;
	
	public enum oreType : byte
	{
		Aura = 0,
		Argenta = 1,
		Plumbu = 2,
		Jula = 3,
		Una = 4,							//5

		Du = 5,
		Tripa = 6,
		Qua = 7,
		Penta = 8,
		Hexra = 9,							//10

		Spetu = 10,
		Ortco = 11,
		Critla = 12,
		Lorpo = 13,
		Genta = 14,							//15

		Flouru = 15,
		Ferra = 16,
		Ida = 17,
		Ventila = 18,
		Judica = 19,						//20

		Yossa = 20,
		Nerra = 21,
		Hropo = 22,
		Zepha = 23,
		Noma = 24,							//25

		Ollo = 25,
		Retra = 26

	}

	float density, 								//This is multiplied by the volume to get weight (g/cm^3)
	meltPoint, 									//degrees K for the melting point of the material
	boilPoint, 									//degrees K for the boiling point of the material
	//-+-All values below are on a 0.0 to 3.0 scale!-+-
	hardness, 									//how well the material can take a hit (multiplied by tensile)
	tensile, 									//how well the material absorbs a hit
	rigidity, 									//how well the material holds a shape/point (avoids deformation)
	conductance, 								//how well the material conducts electricity
	attunement, 								//how well the material holds a magic charge
	resistance;									//how well the material repels magical energy (this is not just a defensive stat)
	
	/// <summary>
	/// Creates an entry of the <see cref="OreData"/> class.
	/// </summary>
	/// <param name="dens">The density of the material (g/m^3).</param>
	/// <param name="melt">Melting point in degrees K</param>
	/// <param name="boil">Boiling point in degrees K</param>
	/// <param name="hard">How well the material can take a hit</param>
	/// <param name="tens">How well the material absorbs a hit</param>
	/// <param name="rigi">How well the material holds a shape/point</param>
	/// <param name="cond">How well the material conducts electricity</param>
	/// <param name="attu">How well the material holds a magic charge</param>
	/// <param name="resi">How well the material repels magical energy</param>
	public OreItem(oreType o, float dens, float melt, float boil, float hard, float tens, float rigi, float cond, float attu, float resi)
	{
		itemID = o.GetHashCode() + 300;
		type = o;
		itemName = o.ToString();
		itemType = ItemType.Resource;
		quantity = 0;
		density = dens;
		meltPoint = melt;
		boilPoint = boil;
		hardness = hard;
		tensile = tens;
		rigidity = rigi;
		conductance = cond;
		attunement = attu;
		resistance = resi;
		itemDesc = "";
		quantity = 0;
		itemIcon = Resources.Load<Sprite>("ItemIcons/" + itemName);
	}
	
	public float getDensity()
	{
		return density;
	}
	public float getMelt()
	{
		return meltPoint;
	}
	public float getBoil()
	{
		return boilPoint;
	}
	public float getHardness()
	{
		return hardness;
	}
	public float getTesile()
	{
		return tensile;
	}
	public float getRigidity()
	{
		return rigidity;
	}
	public float getConductance()
	{
		return conductance;
	}
	public float getAttunement()
	{
		return attunement;
	}
	public float getResistance()
	{
		return resistance;
	}
	
	public OreItem(oreType oType, float ammount)
	{
		itemName = oType.ToString();
		type = oType;
	}

	public void addOre(float f)
	{
		quantity += f;
	}

	public static OreItem operator + (OreItem o1, OreItem o2)
	{
		o1.quantity += o2.quantity;
		return o1;
	}

	public float getQuantity()
	{
		return quantity;
	}
	public float removeQuantity(float f)
	{
		if(f > quantity)
		{
			quantity = 0;
			return f;
		}
		else
		{
			quantity -= f;
			return f;
		}
	}
}
