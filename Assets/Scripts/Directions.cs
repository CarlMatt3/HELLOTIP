using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Directions : MonoBehaviour
{
    public GameObject[] objectsToToggle;

    private void Start()
    {
    }

    public void ToggleVisibility()
    {
        // Enable the current object and disable the others
        foreach (GameObject obj in objectsToToggle)
        {
            obj.SetActive(obj == gameObject);
        }
    }
}
