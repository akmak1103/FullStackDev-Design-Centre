using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class databse : MonoBehaviour
{
    public GameObject website,code,button,wheel;
    void OnMouseDown()
    {
        website.SetActive(true);
        code.SetActive(false);
        button.SetActive(false);
        gameObject.SetActive(false);
        wheel.SetActive(false);
    }
}
