using UnityEngine;
using UnityEngine.UI;

public class ShowPanelOnClick : MonoBehaviour
{
    public Button faqButton;
    public Button exitButton;
    public GameObject panel;

    void Start()
    {
        faqButton.onClick.AddListener(ShowPanel);
        exitButton.onClick.AddListener(HidePanel);
        panel.SetActive(false);
    }

    void ShowPanel()
    {
        panel.SetActive(true);
    }

    void HidePanel()
    {
        panel.SetActive(false);
    }
}
