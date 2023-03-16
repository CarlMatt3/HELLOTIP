using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisableCameraMove : MonoBehaviour
{
    public GameObject MapCanvas;
    public GameObject InstructionCanvas;
    public GameObject FaqCanvas;
    public GameObject TechnoElev;
    private TourManager tourManager;

    // Assign the TourManager reference
    public void Start()
    {
        tourManager = FindObjectOfType<TourManager>();
        tourManager.isCameraMove = false;
    }

    public void ShowHideInstructionCanvas()
    {
        ToggleMenuDCM(InstructionCanvas);
    }

    public void ShowHideMapCanvas()
    {
        ToggleMenuDCM(MapCanvas);
    }

    public void ShowHideFaqCanvas()
    {
        ToggleMenuDCM(FaqCanvas);
    }

    // Start is called before the first frame update
    public void ToggleMenuDCM(GameObject menu)
{
    if (menu == null)
    {
        Debug.Log("Menu GameObject is null");
        return;
    }

    bool menuActive = menu.activeSelf;
    menu.SetActive(!menuActive);

    if ((menu == MapCanvas) || (menu == InstructionCanvas) || (menu == FaqCanvas))
    {
        tourManager.isCameraMove = menuActive;
    }
}
}
