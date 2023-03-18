using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class MapHotspot : MonoBehaviour, IPointerClickHandler
{
    public Image youAreHereImage;
    public Canvas mapCanvas;
    public RectTransform hotspotButtonRect;

    private void Start()
    {
        // Hide the "YouAreHere" image when the game starts
        Hide();
    }

    public void Show(Vector2 position)
    {
        // Set the position of the "YouAreHere" image to the position of the hotspot button on the map
        youAreHereImage.rectTransform.anchoredPosition = position;

        // Set the "YouAreHere" image to be the last sibling of the map canvas to ensure it is on top of other UI elements
        youAreHereImage.transform.SetAsLastSibling();

        // Show the "YouAreHere" image
        SetActive(true);
    }

    public void Hide()
    {
        // Hide the "YouAreHere" image
        SetActive(false);
    }

    public void SetImage(Sprite sprite)
    {
        // Set the image of the "YouAreHere" image
        youAreHereImage.sprite = sprite;
    }

    public void SetActive(bool active)
    {
        // Enable or disable the "YouAreHere" image
        youAreHereImage.gameObject.SetActive(active);
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        if (mapCanvas == null) {
            Debug.LogWarning("Map canvas not assigned in MapHotspot script");
            return;
        }

        // Get the position of the hotspot button on the map
        Vector2 position;
        RectTransformUtility.ScreenPointToLocalPointInRectangle(mapCanvas.transform as RectTransform, eventData.position, mapCanvas.worldCamera, out position);
        position += hotspotButtonRect.anchoredPosition;

        // Show the "YouAreHere" image at the position of the hotspot button on the map
        Show(position);
    }
}
