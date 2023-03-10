using UnityEngine;
using UnityEngine.EventSystems;

public class MapZoom : MonoBehaviour, IScrollHandler
{
    private Vector3 initialScale;

    [SerializeField]
    private float zoomSpeed = 0.01f;
    [SerializeField]
    private float maxZoom = 10f;

    private void Awake()
    {
        initialScale = transform.localScale;
    }

    public void OnScroll(PointerEventData eventData)
    {
        if (Input.touchCount == 2) // Check if there are two touches for pinch-to-zoom
        {
            var touchZero = Input.GetTouch(0);
            var touchOne = Input.GetTouch(1);

            // Get the distance between the two touches in the previous frame
            var prevTouchDeltaMag = (touchZero.position - touchOne.position - touchZero.deltaPosition + touchOne.deltaPosition).magnitude;
            // Get the distance between the two touches in the current frame
            var touchDeltaMag = (touchZero.position - touchOne.position).magnitude;

            // Calculate the change in distance between the two touches
            var deltaMagnitudeDiff = prevTouchDeltaMag - touchDeltaMag;

            // Scale the map by the change in distance between the two touches
            var deltaScale = deltaMagnitudeDiff * zoomSpeed;
            var desiredScale = transform.localScale + Vector3.one * deltaScale;

            desiredScale = ClampDesiredScale(desiredScale);

            transform.localScale = desiredScale;
        }
    }

    private Vector3 ClampDesiredScale(Vector3 desiredScale)
    {
        desiredScale = Vector3.Max(initialScale, desiredScale);
        desiredScale = Vector3.Min(initialScale * maxZoom, desiredScale);
        return desiredScale;
    }
}
