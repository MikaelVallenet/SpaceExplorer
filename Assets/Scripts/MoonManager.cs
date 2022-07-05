using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoonManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space")) {
            Debug.Log("La touche espace a été enfoncée !");

            bool isActive = this.gameObject.activeSelf;
            if (isActive) {
                Debug.Log("on cache le gameobject 'moon'");
                this.gameObject.SetActive(false);
            }
        }
    }
}
