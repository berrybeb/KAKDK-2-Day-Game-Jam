using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class RuleBook : MonoBehaviour
{
    public GameObject Pages;
    // Start is called before the first frame update
    public void OpenPages(){
        if(Pages != null){
            bool isActive = Pages.activeSelf;
            Pages.SetActive(!isActive);
        }
    }
}
