using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Keypad : MonoBehaviour
{
    [SerializeField] private Text Ans;

    public string Answer = "1324314";
    public string sceneName;

    void Update() 
    {
        StartCoroutine("SecondsWait");
    }

    public void Number(int number)
    {
        Ans.text += number.ToString();
    }

    public void Execute()
    {
        if(Ans.text == Answer)
        {
            Ans.text = "Good job :)!";
        }
        else
        {
            Ans.text = "Incorrect, please try again!";
        }
    }

        private IEnumerator SecondsWait()
    {
        if (Ans.text == Answer)
        {
           yield return new WaitForSeconds(4); 
           SceneManager.LoadScene(sceneName);
           StopCoroutine("SecondsWait");
           Debug.Log("Coroutine stop");
        }
    }
}
