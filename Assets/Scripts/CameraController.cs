using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    //Sensitivity of the touch
    private float rotateSpeed = 3f;

    //Zoom in/out variables
    private float zoomSpeed = 1f;
    private float zoomAmount = 0.0f;

    //Lerp variables
    private float lerpSpeed = 5.0f; //Adjust this value to control the lerp speed
    private Quaternion targetRotation; //This will store the target rotation for the camera

    //Tourmanager
    private TourManager tourManager;

    // Invert Y-axis toggle
    private bool isInvertedY = false;
    // Invert X-axis toggle
    private bool isInvertedX = false;

    // Start is called before the first frame update
    void Start()
    {
        tourManager = GetComponent<TourManager>();
        targetRotation = transform.rotation; //Initialize the target rotation to the current rotation
    }

    // Update is called once per frame
    void Update()
    {
        if(tourManager.isCameraMove)
        {
           //Handle touch input for rotation
            if (Input.touchCount > 0)
            {
                Touch touch = Input.GetTouch(0);
                if (touch.phase == TouchPhase.Moved)
                {
                    //Update the target rotation based on touch input
                    float x = touch.deltaPosition.x * Time.deltaTime * rotateSpeed * (isInvertedX ? 1 : -1);
                    float y = touch.deltaPosition.y * Time.deltaTime * rotateSpeed * (isInvertedY ? -1 : 1);
                    targetRotation *= Quaternion.Euler(y, x, 0);
                }
            }

            //Handle touch input for zoom
            if (Input.touchCount == 2)
            {
                Touch touch1 = Input.GetTouch(0);
                Touch touch2 = Input.GetTouch(1);
                Vector2 touch1PrevPos = touch1.position - touch1.deltaPosition;
                Vector2 touch2PrevPos = touch2.position - touch2.deltaPosition;
                float prevTouchDeltaMag = (touch1PrevPos - touch2PrevPos).magnitude;
                float touchDeltaMag = (touch1.position - touch2.position).magnitude;
                float deltaMagDiff = prevTouchDeltaMag - touchDeltaMag;
                zoomAmount = Mathf.Clamp(zoomAmount - deltaMagDiff * Time.deltaTime * zoomSpeed, 0f, 5.0f);
                //Apply to camera
                Camera.main.transform.localPosition = new Vector3(0, 0, zoomAmount);
            }

            // Only the x and y rotation, set the z rotation to zero
            targetRotation.eulerAngles = new Vector3(targetRotation.eulerAngles.x, targetRotation.eulerAngles.y, 0);

            //Smoothly interpolate between the current rotation and the target rotation
            transform.rotation = Quaternion.Lerp(transform.rotation, targetRotation, Time.deltaTime * lerpSpeed);
        }
    }

    public void ResetCamera()
    {
        transform.localEulerAngles = new Vector3(0,0,0);
        targetRotation = transform.rotation;
        zoomAmount = 0.0f;
        Camera.main.transform.localPosition = new Vector3(0, 0, zoomAmount);
    }

    public void ToggleInvertY()
    {
        isInvertedY = !isInvertedY;
    }
    
    public void ToggleInvertX()
    {
        isInvertedX = !isInvertedX;
    }
}

