using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PopupCanvas : MonoBehaviour
{
    public Button button;
    public Canvas popupCanvas;
    public Image popupImage;
    public TMP_Text popupText;
    public float fadeInTime = 1.0f;
    public float fadeOutTime = 1.0f;

    private Coroutine popupCoroutine;


    void Start()
    {
        Debug.Log("Popup method called");
        // Hide the popup canvas at start
        popupCanvas.enabled = false;

        // Attach the button click event to the ShowPopup method
        button.onClick.AddListener(ShowPopup);
    }

    void ShowPopup()
    {
        // If the popup is already being shown, stop the coroutine and start a new one
        if (popupCoroutine != null)
        {
            StopCoroutine(popupCoroutine);
        }
        popupCoroutine = StartCoroutine(ShowPopupCoroutine());
    }

    IEnumerator ShowPopupCoroutine()
    {
        // Fade in the popup canvas
        float t = 0;
        while (t < fadeInTime)
        {
            t += Time.deltaTime;
            float a = Mathf.Lerp(0, 1, t / fadeInTime);
            popupCanvas.enabled = true;
            popupImage.color = new Color(popupImage.color.r, popupImage.color.g, popupImage.color.b, a);
            popupText.color = new Color(popupText.color.r, popupText.color.g, popupText.color.b, a);
            yield return null;
        }

        // Wait for 2 seconds
        yield return new WaitForSeconds(2.0f);

        // Fade out the popup canvas
        t = 0;
        while (t < fadeOutTime)
        {
            t += Time.deltaTime;
            float a = Mathf.Lerp(1, 0, t / fadeOutTime);
            popupImage.color = new Color(popupImage.color.r, popupImage.color.g, popupImage.color.b, a);
            popupText.color = new Color(popupText.color.r, popupText.color.g, popupText.color.b, a);
            yield return null;
        }

        // Hide the popup canvas
        popupCanvas.enabled = false;
        popupCoroutine = null;
    }
}
