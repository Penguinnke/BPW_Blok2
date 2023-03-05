using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CutScene3 : MonoBehaviour
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
            PurpleBlock.GetComponent<Image>().enabled = true; //purple 1
            yield return new WaitForSeconds(1.5f);
            PurpleBlock.GetComponent<Image>().enabled = false;

            yield return new WaitForSeconds(1.5f);

            RedBlock.GetComponent<Image>().enabled = true; //red 4
            yield return new WaitForSeconds(1.5f);
            RedBlock.GetComponent<Image>().enabled = false;

            yield return new WaitForSeconds(1.5f);

            PurpleBlock.GetComponent<Image>().enabled = true; //purple 1
            yield return new WaitForSeconds(1.5f);
            PurpleBlock.GetComponent<Image>().enabled = false;

            yield return new WaitForSeconds(1.5f);     
                 
            BlueBlock.GetComponent<Image>().enabled = true; //blue 3
            yield return new WaitForSeconds(1.5f);
            BlueBlock.GetComponent<Image>().enabled = false;

            yield return new WaitForSeconds(1.5f);

            GreenBlock.GetComponent<Image>().enabled = true; //green 2
            yield return new WaitForSeconds(1.5f);    
            GreenBlock.GetComponent<Image>().enabled = false;

            yield return new WaitForSeconds(1.5f);

            GreenBlock.GetComponent<Image>().enabled = true; //green 2
            yield return new WaitForSeconds(1.5f);    
            GreenBlock.GetComponent<Image>().enabled = false;

            yield return new WaitForSeconds(1.5f);

            BlueBlock.GetComponent<Image>().enabled = true; //blue 3
            yield return new WaitForSeconds(1.5f);
            BlueBlock.GetComponent<Image>().enabled = false;

            yield return new WaitForSeconds(1.5f);

            PurpleBlock.GetComponent<Image>().enabled = true; //purple 1
            yield return new WaitForSeconds(1.5f);
            PurpleBlock.GetComponent<Image>().enabled = false;

            yield return new WaitForSeconds(1.5f);

            RedBlock.GetComponent<Image>().enabled = true; //red 4
            yield return new WaitForSeconds(1.5f);
            RedBlock.GetComponent<Image>().enabled = false;

            yield return new WaitForSeconds(1.5f);

            PurpleBlock.GetComponent<Image>().enabled = true; //purple 1
            yield return new WaitForSeconds(1.5f);
            PurpleBlock.GetComponent<Image>().enabled = false;

            yield return new WaitForSeconds(1.5f);
            
            BlueBlock.GetComponent<Image>().enabled = true; //blue 3
            yield return new WaitForSeconds(1.5f);
            BlueBlock.GetComponent<Image>().enabled = false;

            yield return new WaitForSeconds(1.5f);
            
            GreenBlock.GetComponent<Image>().enabled = true; //green 2
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