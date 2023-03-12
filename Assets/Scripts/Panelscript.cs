using UnityEngine;
using UnityEngine.UI;
using System;

public static class ButtonExtension
{
	public static void AddEventListener<T> (this Button button, T param, Action<T> OnClick)
	{
		button.onClick.AddListener (delegate() {
			OnClick (param);
		});
	}
}

public class Panelscript : MonoBehaviour
{
	[Serializable]
	public struct Game
	{
		public string Name;
		public string Description;
		public Sprite Icon;
	}

	[SerializeField] Game[] allGames;

void Start ()
{
    // Find the "Button Template" game object by name
    GameObject buttonTemplate = transform.Find("Button_template").gameObject;
    GameObject g;

    int N = allGames.Length;

    for (int i = 0; i < 5; i++) {
        g = Instantiate(buttonTemplate, transform);
        // Use the correct child indices to access the questionNumber and questionDescription
        g.transform.GetChild(0).GetComponent<Text>().text = (i + 1).ToString();
        g.transform.GetChild(1).GetComponent<Text>().text = allGames[i].Name;
        g.transform.GetChild(2).GetComponent<Text>().text = allGames[i].Description;

        g.GetComponent<Button>().AddEventListener(i, ItemClicked);
    }

    Destroy(buttonTemplate);
}

	void ItemClicked (int itemIndex)
	{
		Debug.Log ("------------item " + itemIndex + " clicked---------------");
		Debug.Log ("name " + allGames [itemIndex].Name);
		Debug.Log ("desc " + allGames [itemIndex].Description);
	}
}
