using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dog : MonoBehaviour
{

    public GameObject winImage;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnTriggerEnter(Collider col)    {
        Debug.Log("win");
        winImage.SetActive(true);
    }
}
