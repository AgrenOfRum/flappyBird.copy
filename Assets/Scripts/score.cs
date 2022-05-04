using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class score : MonoBehaviour
{
    public static int sscore = 0;
    void Start()
    {
        sscore = 0;
    }
    void Update()
    {
        GetComponent<UnityEngine.UI.Text>().text = sscore.ToString();
    }
}
