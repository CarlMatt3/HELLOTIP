using UnityEngine ;
using EasyUI.Popup ;

public class Demo : MonoBehaviour {
   [TextArea (5, 20)]public string longText ;

   //Buttons

   public void Anim1 () {
      Popup.Show ("Title", longText) ;
   }



  
}
