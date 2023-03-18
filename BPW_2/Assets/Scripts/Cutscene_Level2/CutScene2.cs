using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CutScene2 : MonoBehaviour
{

    public GameObject RedBlock;
    public GameObject GreenBlock;
    public GameObject BlueBlock;
    public GameObject PurpleBlock;
    public string sceneName;

    void Start() 
    {
        StartCoroutine("SecondsWait");
    }

    private IEnumerator SecondsWait() //makes it wait a couple of seconds before the healthbooster is seen again
    {
            BlueBlock.GetComponent<Image>().enabled = true;
            yield return new WaitForSeconds(1.5f);
            BlueBlock.GetComponent<Image>().enabled = false;

            yield return new WaitForSeconds(1.5f);

            PurpleBlock.GetComponent<Image>().enabled = true;
            yield return new WaitForSeconds(1.5f);
            PurpleBlock.GetComponent<Image>().enabled = false;

            yield return new WaitForSeconds(1.5f);

            BlueBlock.GetComponent<Image>().enabled = true;
            yield return new WaitForSeconds(1.5f);
            BlueBlock.GetComponent<Image>().enabled = false;

            yield return new WaitForSeconds(1.5f);

            GreenBlock.GetComponent<Image>().enabled = true; //green
            yield return new WaitForSeconds(1.5f);    
            GreenBlock.GetComponent<Image>().enabled = false;

            yield return new WaitForSeconds(1.5f);

            BlueBlock.GetComponent<Image>().enabled = true;
            yield return new WaitForSeconds(1.5f);
            BlueBlock.GetComponent<Image>().enabled = false;

            yield return new WaitForSeconds(1.5f);

            RedBlock.GetComponent<Image>().enabled = true; //red
            yield return new WaitForSeconds(1.5f);
            RedBlock.GetComponent<Image>().enabled = false; 

            yield return new WaitForSeconds(1.5f);
          
            BlueBlock.GetComponent<Image>().enabled = true;
            yield return new WaitForSeconds(1.5f);
            BlueBlock.GetComponent<Image>().enabled = false;
            yield return new WaitForSeconds(1.5f);

            yield return new WaitForSeconds(1.5f);

            RedBlock.GetComponent<Image>().enabled = true; //red
            yield return new WaitForSeconds(1.5f);
            RedBlock.GetComponent<Image>().enabled = false;

            yield return new WaitForSeconds(1.5f);

            GreenBlock.GetComponent<Image>().enabled = true; //green
            yield return new WaitForSeconds(1.5f);    
            GreenBlock.GetComponent<Image>().enabled = false;

            yield return new WaitForSeconds(1.5f);

            SceneManager.LoadScene(sceneName);
            StopCoroutine("SecondsWait");
            Debug.Log("Coroutine stop");
    }

    public void LoadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

}