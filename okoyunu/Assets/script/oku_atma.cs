using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class oku_atma : MonoBehaviour
{
    public GameObject ok;
    Transform kamera;
    public Image atis_bari;
    float firlatma_hizi=4000.0f;
    float resethiz=4000.0f;

    void Start()
    {
        kamera=GameObject.Find("Main Camera").transform;
    }

    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            GameObject yeni_ok=Instantiate(ok,kamera.position,kamera.rotation);
            firlatma_hizi *= atis_bari.fillAmount;

            yeni_ok.GetComponent<Rigidbody>().AddForce(yeni_ok.transform.forward*firlatma_hizi);
            firlatma_hizi=resethiz;
        }
        
    }
}
