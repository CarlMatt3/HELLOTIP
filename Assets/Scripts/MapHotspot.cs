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
        sitePositions.Add(tourManager.objSites[0], new Vector2(-3354f,357f));
        sitePositions.Add(tourManager.objSites[1], new Vector2(-3354f,357f));
        sitePositions.Add(tourManager.objSites[2], new Vector2(-3354f,357f));
        sitePositions.Add(tourManager.objSites[3], new Vector2(-3354f,357f));
        sitePositions.Add(tourManager.objSites[4], new Vector2(-3354f,357f));
        sitePositions.Add(tourManager.objSites[5], new Vector2(-2181f,165.9499f));
        sitePositions.Add(tourManager.objSites[6], new Vector2(-1229f, 347f));
        sitePositions.Add(tourManager.objSites[7], new Vector2(-1229f, 347f));
        sitePositions.Add(tourManager.objSites[8], new Vector2(-1229f, 347f));
        sitePositions.Add(tourManager.objSites[9], new Vector2(-1229f, 595.9501f));
        sitePositions.Add(tourManager.objSites[10], new Vector2(-875f, 595.95f));
        sitePositions.Add(tourManager.objSites[11], new Vector2(-875f, 595.95f));
        sitePositions.Add(tourManager.objSites[12], new Vector2(-834f, 1223.1f));
        sitePositions.Add(tourManager.objSites[13], new Vector2(-824f, 1972.1f));
        sitePositions.Add(tourManager.objSites[14], new Vector2(-824f, 1972.1f));
        sitePositions.Add(tourManager.objSites[15], new Vector2(541f, 2007.9f));
        sitePositions.Add(tourManager.objSites[16], new Vector2(541f, 2007.9f));
        sitePositions.Add(tourManager.objSites[17], new Vector2(541f, 2007.9f));
        sitePositions.Add(tourManager.objSites[18], new Vector2(541f, 2007.9f));
        sitePositions.Add(tourManager.objSites[19], new Vector2(627f, 1634f));
        sitePositions.Add(tourManager.objSites[20], new Vector2(632f, 1244.1f));
        sitePositions.Add(tourManager.objSites[21], new Vector2(511.0002f, 501.95f));
        sitePositions.Add(tourManager.objSites[22], new Vector2(511.0002f, 501.95f));
        sitePositions.Add(tourManager.objSites[23], new Vector2(-236.0001f, 496.05f));

        sitePositions.Add(tourManager.objSites[24], new Vector2(119f, 736f));
        sitePositions.Add(tourManager.objSites[25], new Vector2(-236.0001f, 496.05f));
        sitePositions.Add(tourManager.objSites[26], new Vector2(-236.0001f, 496.05f));
        sitePositions.Add(tourManager.objSites[27], new Vector2(-236.0001f, 496.05f));
        sitePositions.Add(tourManager.objSites[28], new Vector2(-236.0001f, 496.05f));
        sitePositions.Add(tourManager.objSites[29], new Vector2(-236.0001f, 496.05f));
        sitePositions.Add(tourManager.objSites[30], new Vector2(-236.0001f, 496.05f));
        sitePositions.Add(tourManager.objSites[31], new Vector2(-236.0001f, 496.05f));
        sitePositions.Add(tourManager.objSites[32], new Vector2(-236.0001f, 496.05f));
        sitePositions.Add(tourManager.objSites[33], new Vector2(-236.0001f, 496.05f));




        
        //sitePositions.Add(tourManager.objSites[n], new Vector2(xposf, yposf));


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
