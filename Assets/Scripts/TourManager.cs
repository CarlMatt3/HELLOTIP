using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TourManager : MonoBehaviour
{

    //site list

    public GameObject[] objSites;

    //mainmenu
    public GameObject canvasMainMenu;
    //should the camera move
    public bool isCameraMove = false;

    public GameObject mainmenuButton;
    
    // Start is called before the first frame update
    void Start()
    {
         StartMainMenu();
    }

    // Update is called once per frame
    void Update()
    {
        if(isCameraMove){
            if(Input.GetKeyDown(KeyCode.Escape) && Input.touchCount == 0){
                StartMainMenu();
            }

            if(Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began){
                RaycastHit hit;

                HideMainMenu();

                Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);



                if(Physics.Raycast(ray, out hit, 100.0f)){
                     if(hit.transform.gameObject.tag == "Sound"){
                        hit.transform.gameObject.GetComponent<MediaAudio>().PlayAudio();
                     }
                     else if(hit.transform.gameObject.tag == "Image"){
                        hit.transform.gameObject.GetComponent<MediaImage>().ShowImage();
                     }
                     else if(hit.transform.gameObject.tag == "Video"){
                        hit.transform.gameObject.GetComponent<MediaVideo>().ShowVideo();
                     }
                     else if(hit.transform.gameObject.tag == "NextSite"){
                        LoadSite(hit.transform.gameObject.GetComponent<NextSite>().GetSiteToLoad());
                     }
                }
            }
        }
    }

    public void LoadSite(int siteNumber){
        //hide sites
        for(int i = 0; i < objSites.Length; i++){
            objSites[i].SetActive(false);
        }

        //show sites
        objSites[siteNumber].SetActive(true);

        //enable cam
        isCameraMove = true;

        // GetComponent<CameraController>().ResetCamera();
    }

    // public void ReturnToMenu(){
    //     //showmenu
    //     canvasMainMenu.SetActive(true);
    //     //hide sites
    //     for(int i = 0; i < objSites.Length; i++){
    //         objSites[i].SetActive(false);
    //     }

    //     isCameraMove = false;
    // }

    public void StartMainMenu(){
        
        canvasMainMenu.SetActive(true);
        
        isCameraMove = false;
    }

    public void HideMainMenu(){
        canvasMainMenu.SetActive(false);
    }

    public void ReturnToSite(){
        isCameraMove = true;
    }

    public void OpenMedia(){
        isCameraMove = false;
    }
}
