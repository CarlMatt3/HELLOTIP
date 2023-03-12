using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisableCameraMove : MonoBehaviour
{
    public GameObject MapCanvas;
    public GameObject InstructionCanvas;
    public GameObject FaqCanvas;
    private TourManager tourManager;

    // Assign the TourManager reference
    public void Start()
    {
        tourManager = FindObjectOfType<TourManager>();
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

    // Start is called before the first frame update
    public void ToggleMenu(GameObject menu)
    {
        bool menuActive = menu.activeSelf;
        menu.SetActive(!menuActive);
        Debug.Log(menuActive);

        if (menu == MapCanvas || InstructionCanvas || FaqCanvas) {
            tourManager.isCameraMove = menuActive;
        }
    }
}
