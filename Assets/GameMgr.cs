using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameMgr : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void PeopleRotate(int index)
    {
        if (index == 1)
        {
            transform.eulerAngles += new Vector3(0, 10, 0);

        }
        else if (index == 2)
        {
            transform.eulerAngles += new Vector3(0, -10, 0);
        }




    }


    public void PeopleMove(int index)
    {
        if (index == 1)
        {
            transform.position += new Vector3(0.2f, 0, 0);

        }
        else if (index == 2)
        {
            transform.position += new Vector3(-0.2f, 0, 0);
        }


    }


    public void PeopleScale(int index)
    {
        if (index == 1)
        {
            transform.localScale += new Vector3(0.1f, 0.1f, 0.1f);

        }
        else if (index == 2)
        {
            transform.localScale += new Vector3(-0.1f, -0.1f, -0.1f);
        }


    }


    public void LoadBack()
    {
        SceneManager.LoadScene("Start");
    }


    public void LoadBackReset()
    {
        transform.position = new Vector3(-19,4,115);
        transform.rotation = Quaternion.identity;
        transform.localScale = Vector3.one;
    }


    public void LoadBackReset2()
    {
        transform.localPosition = new Vector3(12.7f,24.23f, 18.06f);
        transform.rotation = Quaternion.identity;
        transform.localScale = Vector3.one;
    }


    public void LoadBackReset4()
    {
        transform.position = new Vector3(39.44f, 7.318f, 149.48f);
        transform.rotation = Quaternion.identity;
        transform.localScale = Vector3.one;
    }
}
