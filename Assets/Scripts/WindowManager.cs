using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Collections;

public class WindowManager : MonoBehaviour {

	public GameObject Panel;
	private GenericWindow gWindow;
	private Image background;
	public GameObject Button;
	public GameObject Text;
	private bool show = true;

	void Awake()
	{
		background = gameObject.GetComponent<Image>();
		gWindow = Panel.GetComponent<GenericWindow>();
	}

	void Update()
	{
		if(Input.GetButtonDown("Inventory"))
		{
			SetVisuals(!show);
		}
	}

	public void Panelset(bool b)
	{
		gWindow.SetShowing(b);
	}

	public void SetVisuals(bool b)
	{
		show = b;
		Panelset(b);
		Button.SetActive(b);
		Text.SetActive(b);
		background.enabled = b;
	}
}
