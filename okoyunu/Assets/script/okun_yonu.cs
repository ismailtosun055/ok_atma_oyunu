using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    float X;
    public float hassasiyet;
    float Y;
    void Start()
    {

    }

    void Update()
    {
        X=Input.GetAxis("Mouse X")*hassasiyet*Time.deltaTime;
        Y=Input.GetAxis("Mouse Y")*hassasiyet*Time.deltaTime;
        transform.Rotate(-Y,0f,0f);
        transform.Rotate(0f,X,0f,Space.World);
        
    }
}
