using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SliderMenuAnim : MonoBehaviour
{
    public GameObject PanelMenu;
    public GameObject SettingsMenu;
    public GameObject TelevisionMenu;

    public TourManager tourManager; // reference to the TourManager script

    // Assign the TourManager reference
    public void Start()
    {
        tourManager = FindObjectOfType<TourManager>();
    }

    // Toggles the PanelMenu
    public void ShowHidePanelMenu()
    {
        ToggleMenu(PanelMenu);
    }

    // Toggles the SettingsMenu
    public void ShowHideSettingsMenu()
    {
        ToggleMenu(SettingsMenu);
    }

    public void ShowHideTelevisionMenu()
    {
        ToggleMenu(TelevisionMenu);
    }

    public void ToggleMenu(GameObject menu)
    {
        tourManager.isCameraMove = false;
        
        if (menu != null)
        {
            Animator animator = menu.GetComponent<Animator>();
            if (animator != null)
            {
                bool isOpen = animator.GetBool("show");
                animator.SetBool("show", !isOpen);
                bool anyMenuOpen = 
                PanelMenu.GetComponent<Animator>().GetBool("show") || 
                SettingsMenu.GetComponent<Animator>().GetBool("show") || 
                TelevisionMenu.GetComponent<Animator>().GetBool("show");
                
                if (!anyMenuOpen)
                {
                    tourManager.isCameraMove = true; // enable camera movement if no menus are open
                }
                else
                {
                    tourManager.isCameraMove = false; // disable camera movement if any menu is open
                }
            }
        }
    }
}
