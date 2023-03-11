using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettingsSlider : MonoBehaviour
{
    public GameObject SettingsPanel;

    public void ShowHideSettings()
    {
        if(SettingsPanel != null)
        {
            Animator animator = SettingsPanel.GetComponent<Animator>();
            if(animator != null)
            {
                bool isOpen = animator.GetBool("show");
                animator.SetBool("show", !isOpen);
            }
        }
    }
}