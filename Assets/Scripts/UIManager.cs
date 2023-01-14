using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{ 
   public GameObject letterPanel;
   
   public void CloseLetter()
   {
      letterPanel.SetActive(false);
   }
   
   public void OpenLetter()
   {
      letterPanel.SetActive(true);
   }
}
