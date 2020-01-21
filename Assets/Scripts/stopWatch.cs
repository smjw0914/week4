using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class stopWatch : MonoBehaviour
{
    float time = 0f;
    public Text myTime;
    public int limit = 60;
    int sec;

    // Start is called before the first frame update
    void Start()
    {
        myTime.text = "01:00";
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        sec = (int)time % (60);
        //UnityEngine.Debug.Log("Time: " + time);

        if ((limit - sec) == 0) SceneManager.LoadScene("Ending2");

        else if ((limit - sec) < 10)
        {
            myTime.text = "00:0" + (limit - sec);
        }

        else
        {
            myTime.text = "00:" + (limit - sec);
        }
    }
}
