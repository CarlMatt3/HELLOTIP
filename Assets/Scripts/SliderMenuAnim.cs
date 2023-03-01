// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;

// public class SliderMenuAnim : MonoBehaviour
// {
//     public GameObject PanelMenu;
//     public TourManager tourManager; // reference to the TourManager script

//     public void ShowHideMenu()
//     {
//         if (PanelMenu != null)
//         {
//             Animator animator = PanelMenu.GetComponent<Animator>();
//             if (animator != null)
//             {
//                 bool isOpen = animator.GetBool("show");
//                 animator.SetBool("show", !isOpen);
//                 if (!isOpen) // if the menu is being opened
//                 {
//                     tourManager.isCameraMove = false; // set isCameraMove to false
//                 }
//                 else // if the menu is being closed
//                 {
//                     tourManager.isCameraMove = true; // set isCameraMove to true
//                 }
//             }
//         }
//     }
// }

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SliderMenuAnim : MonoBehaviour
{
    public GameObject PanelMenu;
    public TourManager tourManager; // reference to the TourManager script

    // Assign the TourManager reference
    public void Start()
    {
        tourManager = FindObjectOfType<TourManager>();
    }

    public void ShowHideMenu()
    {
        if (PanelMenu != null)
        {
            Animator animator = PanelMenu.GetComponent<Animator>();
            if (animator != null)
            {
                bool isOpen = animator.GetBool("show");
                animator.SetBool("show", !isOpen);
                if (!isOpen) // if the menu is being opened
                {
                    tourManager.isCameraMove = true; // set isCameraMove to false
                }
                else // if the menu is being closed
                {
                    tourManager.isCameraMove = false; // set isCameraMove to true
                }
            }
        }
    }
}
