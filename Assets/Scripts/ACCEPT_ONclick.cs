using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ACCEPT_ONclick : MonoBehaviour
{
    public GameObject CharacterACCEPTED;
    public GameObject cvACCEPTED;
    public GameObject diplomaACCEPED;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Click(){
    CharacterACCEPTED.GetComponent<ForwardMovingCharacter>().transform.position = new Vector3(14,3.22f,0);
    cvACCEPTED.SetActive(false);
    diplomaACCEPED.SetActive(false);
    }
}
