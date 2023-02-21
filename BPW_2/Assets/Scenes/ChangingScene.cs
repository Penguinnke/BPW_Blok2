using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangingScene : MonoBehaviour
{
    public int sceneID;
    public GameObject Button1;
    public GameObject Button2;
    public GameObject Button3;
    public GameObject Button4;
    // Update is called once per frame
    void Update()
    {
         if (Button1.activeInHierarchy == true)
         {
            if (Button2.activeInHierarchy == true)
            {
                if (Button3.activeInHierarchy == true)
                {
                    if (Button4.activeInHierarchy == true)
                    {
                         SceneManager.LoadScene(sceneID);
                    }
                }
            }
         }   
    }
}
