using UnityEngine ;
using EasyUI.Popup ;

public class Demo : MonoBehaviour {
   [TextArea (5, 20)]public string longText ;

   //Buttons

   public void poi1_inquirytable () {
      Popup.Show ("TIP Inquiry Table", longText) ;
   }

   public void poi2_statue1 () {
      Popup.Show ("Statue Name 1", longText) ;
   }

   public void poi3_statue2 () {
      Popup.Show ("Statue Name 2", longText) ;
   }
}
