using UnityEngine;

public class PinchZoom : MonoBehaviour
{
    public float zoomSpeed = 0.1f;
    public float minZoom = 1.0f;
    public float maxZoom = 5.0f;
    public float damping = 10.0f;
    
    private float targetZoom;
    private float currentZoom;
    private Vector2 prevTouch1;
    private Vector2 prevTouch2;
    private bool zooming = false;
    
    void Start()
    {
        targetZoom = Camera.main.orthographicSize;
        currentZoom = targetZoom;
    }
    
    void Update()
    {
        if (Input.touchCount == 2)
        {
            Touch touch1 = Input.GetTouch(0);
            Touch touch2 = Input.GetTouch(1);
            
            if (!zooming)
            {
                prevTouch1 = touch1.position - touch1.deltaPosition;
                prevTouch2 = touch2.position - touch2.deltaPosition;
                zooming = true;
            }
            else
            {
                float touchDeltaMag = (touch1.position - touch2.position).magnitude;
                float prevTouchDeltaMag = (prevTouch1 - prevTouch2).magnitude;
                float deltaMagnitudeDiff = prevTouchDeltaMag - touchDeltaMag;
                
                targetZoom += deltaMagnitudeDiff * zoomSpeed;
                targetZoom = Mathf.Clamp(targetZoom, minZoom, maxZoom);
                prevTouch1 = touch1.position - touch1.deltaPosition;
                prevTouch2 = touch2.position - touch2.deltaPosition;
            }
        }
        else
        {
            zooming = false;
        }
        
        currentZoom = Mathf.Lerp(currentZoom, targetZoom, Time.deltaTime * damping);
        Camera.main.orthographicSize = currentZoom;
    }
    
    void OnDisable()
    {
        targetZoom = Camera.main.orthographicSize;
        currentZoom = targetZoom;
    }
}
