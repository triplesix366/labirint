using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shots : MonoBehaviour
{
    Transform Pos;
    private void Start()
    {
        Pos = GameObject.Find("Pos").GetComponent<Transform>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag=="Player")
        {
            other.gameObject.transform.position = Pos.position;
        }
    }
}
