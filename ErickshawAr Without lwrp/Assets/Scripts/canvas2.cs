using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class canvas2 : MonoBehaviour
{

    public GameObject rickshaw;
    public GameObject button;
    public GameObject UI;
    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void verify()
    {
        rickshaw.SetActive(false);
        button.SetActive(false);
        UI.SetActive(true);
    }
}
