using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reject_ONclick : MonoBehaviour
{
    public GameObject Character;
    public GameObject cv;
    public GameObject diploma;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Click(){
    Character.SetActive(false); 
    cv.SetActive(false);
    diploma.SetActive(false);
    }
}
