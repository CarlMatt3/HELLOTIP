using UnityEngine;
using UnityEngine.UI;

public class ScrollToTop : MonoBehaviour
{
    public ScrollRect scrollRect;

    public void OnButtonClick()
    {
        // Set the normalized position of the scroll rect to the top
        scrollRect.normalizedPosition = new Vector2(0, 1);
    }
}