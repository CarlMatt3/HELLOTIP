using UnityEngine;
using UnityEngine.EventSystems;

public class MapZoom : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    private Vector3 initialScale;
    private bool isPinching;
    private float startingPinchDistance;
    private float previousPinchDistance;

    [SerializeField]
    private float zoomSpeed = 0.000001f;
    [SerializeField]
    private float maxZoom = 10f;

    private void Awake()
    {
        initialScale = transform.localScale;
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        if (Input.touchCount == 2)
        {
            isPinching = true;
            startingPinchDistance = Vector2.Distance(Input.GetTouch(0).position, Input.GetTouch(1).position);
            previousPinchDistance = startingPinchDistance;
        }
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        if (Input.touchCount != 2)
        {
            isPinching = false;
        }
    }

    private void Update()
    {
        if (isPinching)
        {
            var currentPinchDistance = Vector2.Distance(Input.GetTouch(0).position, Input.GetTouch(1).position);
            var delta = Vector3.one * ((currentPinchDistance - previousPinchDistance) * zoomSpeed);
            var desiredScale = transform.localScale + delta;

            desiredScale = ClampDesiredScale(desiredScale);

            transform.localScale = desiredScale;

            previousPinchDistance = currentPinchDistance;
        }
    }

    private Vector3 ClampDesiredScale(Vector3 desiredScale)
    {
        desiredScale = Vector3.Max(initialScale, desiredScale);
        desiredScale = Vector3.Min(initialScale * maxZoom, desiredScale);
        return desiredScale;
    }
}