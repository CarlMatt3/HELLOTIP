using UnityEngine;
using UnityEngine.EventSystems;

public class MapZoom : MonoBehaviour, IScrollHandler, IDragHandler
{
    private Vector3 initialScale;
    private float touchDelta;

    [SerializeField]
    private float zoomSpeed = 0.1f;
    [SerializeField]
    private float maxZoom = 10f;
    [SerializeField]
    private float touchSensitivity = 1f;

    private void Awake()
    {
        initialScale = transform.localScale;
    }

    public void OnScroll(PointerEventData eventData)
    {
        var delta = Vector3.one * (eventData.scrollDelta.y * zoomSpeed);
        var desiredScale = transform.localScale + delta;

        desiredScale = ClampDesiredScale(desiredScale);

        transform.localScale = desiredScale;
    }

    public void OnDrag(PointerEventData eventData)
    {
        touchDelta += eventData.delta.magnitude * touchSensitivity;
        var delta = Vector3.one * touchDelta * zoomSpeed;

        var desiredScale = transform.localScale + delta;
        desiredScale = ClampDesiredScale(desiredScale);

        transform.localScale = desiredScale;
    }

    private Vector3 ClampDesiredScale(Vector3 desiredScale)
    {
        desiredScale = Vector3.Max(initialScale, desiredScale);
        desiredScale = Vector3.Min(initialScale * maxZoom, desiredScale);
        return desiredScale;
    }
}
