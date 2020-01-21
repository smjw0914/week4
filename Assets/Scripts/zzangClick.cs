using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class zzangClick : MonoBehaviour
{
    int count;
    // Start is called before the first frame update
    void Start()
    {
        count = GameObject.Find("Canvas").GetComponent<findZZang9>().count;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnMouseUp()
    {
        count += 1;
        GameObject.Find("Canvas").GetComponent<findZZang9>().setCount(count);
        Debug.Log(count + "Click");
    }
}
