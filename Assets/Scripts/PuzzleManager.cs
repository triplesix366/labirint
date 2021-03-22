using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleManager : MonoBehaviour
{
    public PuzzleElement[] Elements = new PuzzleElement[8];
    public bool gameIsTrue = true;
    GameObject LockedDoor;
    GameObject Rofl;

    void Start()
    {
        LockedDoor = GameObject.Find("LockedDoor");
        Rofl = GameObject.Find("Rofl");
        for (int i = 0; i < Elements.Length; i++)
        {
            Elements[i] = GameObject.Find("PuzzleElement_" + i).GetComponent<PuzzleElement>();
        }
    }
    public void CheckStatus()
    {
        if (Elements[0].Status && Elements[1].Status && Elements[2].Status && Elements[3].Status && Elements[4].Status && Elements[5].Status && Elements[6].Status && Elements[7])
        {
            gameIsTrue = false;
            LockedDoor.GetComponent<Animator>().SetTrigger("on");
            Rofl.SetActive(false);
        }
    }


    void Update()
    {

    }
}
