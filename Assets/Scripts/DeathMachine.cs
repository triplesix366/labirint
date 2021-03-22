using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathMachine : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject BILLET;
    public GameObject StartPos, EndPos;
    float time = 0;
    Vector3 shootingVector;
    private void Start()
    {
        StartPos = gameObject.transform.GetChild(1).gameObject;
        EndPos = gameObject.transform.GetChild(0).gameObject;
        shootingVector = new Vector3(EndPos.transform.position.x - StartPos.transform.position.x, EndPos.transform.position.y - StartPos.transform.position.y, EndPos.transform.position.z - StartPos.transform.position.z);
    }
    void Shoot()
    {        
        var obecjt = Instantiate(BILLET, new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z), Quaternion.identity);
        obecjt.GetComponent<Rigidbody>().AddForce(shootingVector * 1000);
        Destroy(obecjt, 5);
    }

    // Update is called once per frame
    void Update()
    {
        if(time>1.5)
        {
            Shoot();
            time = 0;
        }
        time += Time.deltaTime;
    }
}
