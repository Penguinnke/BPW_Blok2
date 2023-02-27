using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Keypad : MonoBehaviour
{
    [SerializeField] private Text Ans;
    // [SerializeField] private Animator Door;

    private string Answer = "1324314";

    public void Number(int number)
    {
        Ans.text += number.ToString();
    }

    public void Execute()
    {
        if(Ans.text == Answer)
        {
            Ans.text = "Good job :)!";
            // Door.SetBool("Open",true);
            // StartCoroutine("StopDoor");
        }
        else
        {
            Ans.text = "Incorrect, please try again!";
        }
    }

    // IEnumerator StopDoor()
    // {
    //     yield return new WaitForSeconds(0.5f);
    //     Door.SetBool("Open", false);
    // }
}
