using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Collections.Generic;

public class MapHotspot : MonoBehaviour
{
    public GameObject youAreHereImage;
    public Dictionary<GameObject, Vector2> sitePositions = new Dictionary<GameObject, Vector2>();
    private TourManager tourManager;
    private RectTransform rectTransform;

    void Start()
    {
        tourManager = FindObjectOfType<TourManager>();
        rectTransform = youAreHereImage.GetComponent<RectTransform>();
        
        // Populate the dictionary with site positions
        sitePositions.Add(tourManager.objSites[0], new Vector2(-240.600006f,27.5f));
        sitePositions.Add(tourManager.objSites[1], new Vector2(-0.15f, 0.15f));
        sitePositions.Add(tourManager.objSites[2], new Vector2(0.1f, 0f));
        sitePositions.Add(tourManager.objSites[3], new Vector2(0.3f, -0.1f));
        sitePositions.Add(tourManager.objSites[4], new Vector2(0.5f, 0.2f));
        sitePositions.Add(tourManager.objSites[5], new Vector2(0.8f, 0.1f));
        // add more sites and positions as necessary
    }

    void Update()
    {
        // Find the active site
        GameObject activeSite = null;
        foreach (GameObject site in tourManager.objSites)
        {
            if (site.activeSelf)
            {
                activeSite = site;
                break;
            }
        }

        // Set the position of the "You are here" image based on the active site
        if (activeSite != null)
        {
            Vector2 position;
            if (sitePositions.TryGetValue(activeSite, out position))
            {
                rectTransform.anchoredPosition = new Vector2(position.x, position.y);
                Debug.Log("Active site: " + activeSite);
            }
        }
    }
}
