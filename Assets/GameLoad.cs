using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameLoad : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void LoadGameMain(int index)
    {
        if (index==1)
        {
            SceneManager.LoadScene("GameMain");
        }
        else if (index ==2)
        {
            SceneManager.LoadScene("GameMain2");

        }
        else if (index==3)
        {
            SceneManager.LoadScene("GameMain3");
        }
        else if (index==4)
        {
            SceneManager.LoadScene("GameMain4");
        }
    }
}
