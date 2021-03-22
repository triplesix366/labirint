using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleElement : MonoBehaviour
{
    public bool Status = false;
    public PuzzleElement[] Elements = new PuzzleElement[8];
    public PuzzleManager PuzzleManager;
    void Start()
    {
        ChangeColor();
        PuzzleManager = GameObject.Find("PuzzleManager").GetComponent<PuzzleManager>();
        for (int i = 0; i < Elements.Length; i++)
        {
            Elements[i] = GameObject.Find("PuzzleElement_" + i).GetComponent<PuzzleElement>();
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (PuzzleManager.gameIsTrue)
        {
            if (int.Parse(gameObject.transform.name[14].ToString()) != 0 && int.Parse(gameObject.transform.name[14].ToString()) != 7)
            {
                Elements[int.Parse(gameObject.transform.name[14].ToString())].ChangeStatus();
                Elements[int.Parse(gameObject.transform.name[14].ToString()) + 1].ChangeStatus();
                Elements[int.Parse(gameObject.transform.name[14].ToString()) - 1].ChangeStatus();
            }
            if (int.Parse(gameObject.transform.name[14].ToString()) == 0)
            {
                Elements[int.Parse(gameObject.transform.name[14].ToString())].ChangeStatus();
                Elements[int.Parse(gameObject.transform.name[14].ToString()) + 1].ChangeStatus();
                Elements[7].ChangeStatus();
            }
            if (int.Parse(gameObject.transform.name[14].ToString()) == 7)
            {
                Elements[int.Parse(gameObject.transform.name[14].ToString())].ChangeStatus();
                Elements[int.Parse(gameObject.transform.name[14].ToString()) - 1].ChangeStatus();
                Elements[0].ChangeStatus();
            }
            PuzzleManager.CheckStatus();
        }

    }
    public void ChangeColor()
    {
        if (Status)
        {
            gameObject.GetComponent<Renderer>().material.color = Color.red;
        }
        else
        {
            gameObject.GetComponent<Renderer>().material.color = Color.white;
        }
    }
    public void ChangeStatus()
    {
        if (Status)
        {
            Status = false;
        }
        else
        {
            Status = true;
        }
        ChangeColor();
    }

    // Update is called once per frame
    void Update()
    {

    }
}
