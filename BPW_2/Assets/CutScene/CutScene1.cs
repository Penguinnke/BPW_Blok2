using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CutScene1 : MonoBehaviour
{

    public GameObject RedBlock;
    public GameObject GreenBlock;
    public GameObject BlueBlock;
    public GameObject PurpleBlock;


    void Start() 
    {
        StartCoroutine("SecondsWait");
    }

    private IEnumerator SecondsWait() //makes it wait a couple of seconds before the healthbooster is seen again
    {
        
            //The little white square, which is the healthbooster, should dissapear right after the player touched it
            RedBlock.GetComponent<Image>().enabled = false;

            StartCoroutine("SecondsWait");

            yield return new WaitForSeconds(5);
            Debug.Log("Coroutine activated");

            // Healthbooster.GetComponent<BoxCollider2D>().enabled = true;
            // Healthbooster.GetComponent<Image>().enabled = true;
            // Healthbooster_TEXT.enabled = true;

            // SpawnOnANewPlace();
    }

}