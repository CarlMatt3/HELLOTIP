using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextSite : MonoBehaviour
{
    [SerializeField] private int siteToLoad = 0;

    public int GetSiteToLoad(){
        return siteToLoad;
    }
}




















// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;
// using DG.Tweening;

// public class NextSite : MonoBehaviour
// {
//     [SerializeField] private int siteToLoad = 0;
//     [SerializeField] private float zoomDuration = 1.0f;
//     [SerializeField] private float zoomScale = 1.5f;

//     public void LoadNextSite()
//     {
//         // Create a new Tweener that scales the camera to the new position
//     var tweener = cameraTransform.ScaleTo(new Vector3(2f, 2f, 2f), 1f);

//     // Add a callback to the tweener that loads the next site
//     tweener.OnComplete(() => {
//         int siteToLoad = nextSite.GetSiteToLoad();
//         tourManager.LoadSite(siteToLoad);
//     });
//     }

//     private IEnumerator WaitForZoom(System.Action callback)
//     {
//         yield return new WaitForSeconds(zoomDuration);
//         if (callback != null) callback();
//     }
    
//     public int GetSiteToLoad()
//     {
//         return siteToLoad;
//     }
// }





// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;
// using DG.Tweening;

// public class NextSite : MonoBehaviour
// {
//     [SerializeField] private int siteToLoad = 0;
//     [SerializeField] private float transitionDuration = 1f;
//     [SerializeField] private GameObject imageObject;

//     public void LoadNextSite()
//     {
//         // Calculate the end rotation for the transition
//         Quaternion endRotation = Quaternion.Euler(0, 90 * siteToLoad, 0);

//         // Set up the animation using Dotween
//         imageObject.transform.DORotate(endRotation.eulerAngles, transitionDuration).SetEase(Ease.OutSine);
//     }
// }


// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;
// using DG.Tweening;

// public class NextSite : MonoBehaviour
// {
//     [SerializeField] private int siteToLoad = 0;
//     [SerializeField] private Transform cameraTransform;
//     [SerializeField] private float zoomDuration = 1.0f;
//     [SerializeField] private float zoomAmount = 2.0f;

//     public int GetSiteToLoad()
//     {
//         return siteToLoad;
//     }

//     public void LoadSiteWithZoom()
//     {
//         // Zoom in on the camera
//         cameraTransform.DOLocalMove(cameraTransform.localPosition * zoomAmount, zoomDuration);

//         // Load the next site after the zoom
//         StartCoroutine(LoadSiteAfterDelay(zoomDuration));
//     }

//     private IEnumerator LoadSiteAfterDelay(float delay)
//     {
//         yield return new WaitForSeconds(delay);
//         TourManager.Instance.LoadSite(siteToLoad);
//     }
// }




// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;
// using DG.Tweening;

// public class NextSite : MonoBehaviour
// {
//     [SerializeField] private int siteToLoad = 0;
//     [SerializeField] private GameObject[] objSites;

//     public float transitionDuration = 1.0f;

//     public void LoadNextSite()
//     {
//         int nextSiteIndex = (siteToLoad + 1) % objSites.Length;
//         GameObject nextSite = objSites[nextSiteIndex];

//         // Start the transition animation
//         Transform cameraTransform = Camera.main.transform;
//         Vector3 targetPosition = nextSite.transform.position;
//         Quaternion targetRotation = nextSite.transform.rotation;
//         cameraTransform.DOMove(targetPosition, transitionDuration);
//         cameraTransform.DORotateQuaternion(targetRotation, transitionDuration);

//         // Deactivate current site and activate the next site after the transition animation is complete
//         StartCoroutine(ActivateNextSite(nextSite, transitionDuration));
//     }

//     private IEnumerator ActivateNextSite(GameObject nextSite, float delay)
//     {
//         yield return new WaitForSeconds(delay);
//         objSites[siteToLoad].SetActive(false);
//         siteToLoad = (siteToLoad + 1) % objSites.Length;
//         nextSite.SetActive(true);
//     }

//     public int GetSiteToLoad()
//     {
//         return siteToLoad;
//     }
// }
