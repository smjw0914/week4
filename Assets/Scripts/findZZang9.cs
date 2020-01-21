using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class findZZang9 : MonoBehaviour
{
    public Text countText;
    public int count;
    // Start is called before the first frame update
    void Start()
    {
        count = 0;
    }

    // Update is called once per frame
    void Update()
    {

    }

    /*
    public void find()
    {
        count += 1;
        countText.text = count.ToString();
        Debug.Log("Image Clicked");
        if (count == 3) SceneManager.LoadScene("Ending1");
    }
    */

    public void setCount(int num)
    {
        count = num;
        countText.text = count.ToString();
        if (count == 3) SceneManager.LoadScene("Ending1");
    }
}
