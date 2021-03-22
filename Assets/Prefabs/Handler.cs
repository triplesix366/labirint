using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Handler : MonoBehaviour
{
    public GameObject DorHandler;
    Rigidbody rb;
    
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.MovePosition(DorHandler.transform.position);
    }
    public void ResetPos()
    {
        DorHandler.transform.SetParent(gameObject.transform);
        DorHandler.transform.localEulerAngles = new Vector3(0, 0, 0);
        DorHandler.transform.localPosition = new Vector3(0, 0, 0);       
    }
}
