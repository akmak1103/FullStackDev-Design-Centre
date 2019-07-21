using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wheel_click : MonoBehaviour
{
    public Animator elements;
    public GameObject clickhere,parts,wallpaper;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown() {
        elements.Play("unite",0);
    }

    public void load_session()
    {
        clickhere.SetActive(true);
        wallpaper.SetActive(true);
        parts.SetActive(false);
    }
}
