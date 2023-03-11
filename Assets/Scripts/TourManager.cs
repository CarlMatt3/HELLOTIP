using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class TourManager : MonoBehaviour
{
    public GameObject[] objSites; //site list
    public GameObject canvasMainMenu; //mainmenu
    public bool isCameraMove; //should the camera move
    public GameObject mainmenuButton;

    private Camera mainCamera;

    // Start is called before the first frame update
    void Start()
    {
        mainCamera = Camera.main;
        isCameraMove = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (isCameraMove)
        {
            

            if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
            {
                RaycastHit hit;

               

                Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);

                if (Physics.Raycast(ray, out hit, 100.0f))
                {
                    if (hit.transform.gameObject.tag == "Sound")
                    {
                        hit.transform.gameObject.GetComponent<MediaAudio>().PlayAudio();
                    }
                    else if (hit.transform.gameObject.tag == "Image")
                    {
                        hit.transform.gameObject.GetComponent<MediaImage>().ShowImage();
                    }
                    else if (hit.transform.gameObject.tag == "Video")
                    {
                        hit.transform.gameObject.GetComponent<MediaVideo>().ShowVideo();
                    }
                    else if (hit.transform.gameObject.tag == "NextSite")
                    {
                        int nextSiteNumber = hit.transform.gameObject.GetComponent<NextSite>().GetSiteToLoad();

                        if (nextSiteNumber < objSites.Length)
                        {
                            Vector3 nextSitePosition = mainCamera.transform.position + mainCamera.transform.forward * 3.0f; // Change this value to adjust the distance to zoom
                            float duration = 1.0f; // Change this value to adjust the duration of the zoom effect
                            float distance = Vector3.Distance(mainCamera.transform.position, nextSitePosition);

                            mainCamera.transform
                                .DOBlendableLocalMoveBy(Vector3.forward * distance, duration)
                                .SetEase(Ease.InOutSine)
                                .OnComplete(() =>
                                {
                                    LoadSite(nextSiteNumber);
                                    mainCamera.transform.position = new Vector3(0, 0, 0); // set camera position to (0, 0, 0)
                                });
                        }
                    }
                }
            }
        }
    }

    public void LoadSite(int siteNumber)
    {
        //hide sites
        for (int i = 0; i < objSites.Length; i++)
        {
            objSites[i].SetActive(false);
        }

        //show sites
        objSites[siteNumber].SetActive(true);

        //enable cam
        // isCameraMove = true;

        // GetComponent<CameraController>().ResetCamera();
    }

    // public void StartMainMenu()
    // {
    //     canvasMainMenu.SetActive(true);
    //     isCameraMove = false;
    // }

    

    public void ReturnToSite()
    {
        isCameraMove = true;
    }

    public void OpenMedia()
    {
        isCameraMove = false;
    }
}
