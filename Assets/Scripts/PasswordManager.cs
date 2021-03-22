using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PasswordManager : MonoBehaviour
{
    public string Password = string.Empty;
    public TextMeshProUGUI Text;
    GameObject DoorToLab;
    // Start is called before the first frame update
    private void Start()
    {
        Text = GameObject.Find("TextOfPassword").GetComponentInChildren<TextMeshProUGUI>();
        DoorToLab = GameObject.Find("DoorToLab");
    }
    public void CheckPaswword()
    {
        if (Password == "92538")
        {
            Statistic.SuccessfulPassword = true;
            DoorToLab.GetComponent<Animator>().SetTrigger("on");
        }
        else
        {
            gameObject.GetComponent<Animator>().SetTrigger("WorngPassword");
            Password = string.Empty;
        }
    }
    private void Update()
    {
        Text.text = Password;
        if (Password.Length > 5)
        {
            Password = Password.Substring(0, Password.Length - 1);
        }

    }
}
