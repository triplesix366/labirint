using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputNumber : MonoBehaviour
{
    // Start is called before the first frame update
    public PasswordManager PasswordManager;
    bool Inputed = false;
    public string TextToPassword;
    void Start()
    {
        PasswordManager = GameObject.Find("PasswordManager").GetComponent<PasswordManager>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (!Inputed)
        {
            if (TextToPassword == "Check")
            {
                PasswordManager.CheckPaswword();
                Inputed = true;
            }
            else if (TextToPassword == "Backspace")
            {
                PasswordManager.Password = PasswordManager.Password.Substring(0, PasswordManager.Password.Length - 1);
                Inputed = true;
            }
            else
            {
                if (PasswordManager.Password.Length < 5)
                {
                    PasswordManager.Password += TextToPassword;
                    Inputed = true;
                }
            }
        }
    }
    private void OnTriggerExit(Collider other)
    {
        Inputed = false;
    }
    private void Update()
    {

    }

}
