using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisableCameraMove : MonoBehaviour
{
    public GameObject MapCanvas;
    public GameObject InstructionCanvas;
    public GameObject FaqCanvas;
    public GameObject InformationCanvas;
    private TourManager tourManager;

    // Assign the TourManager reference
    public void Start()
    {
        tourManager = FindObjectOfType<TourManager>();
        tourManager.isCameraMove = false;
    }

    public void ShowHideInstructionCanvas()
    {
        ToggleMenu(InstructionCanvas);
    }

    public void ShowHideMapCanvas()
    {
        ToggleMenu(MapCanvas);
    }

    public void ShowHideFaqCanvas()
    {
        ToggleMenu(FaqCanvas);
    }
        public void ShowHideInformationCanvas()
    {
        ToggleMenu(InformationCanvas);
    }

    // Start is called before the first frame update
    public void ToggleMenu(GameObject menu)
    {
        bool menuActive = menu.activeSelf;
    menu.SetActive(!menuActive);

    if ((menu == MapCanvas) || (menu == InstructionCanvas) || (menu == FaqCanvas) || (menu == InformationCanvas))
    {
        tourManager.isCameraMove = menuActive;
    }
    }
}
