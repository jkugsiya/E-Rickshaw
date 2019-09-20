using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class canvas2 : MonoBehaviour
{

    public GameObject rickshaw;
    public GameObject button;
    public GameObject UI;
    Toggle BatteryToggle;
    public GameObject toggle;
    public GameObject Canvas2;
    
    // Start is called before the first frame update
    void Start()
    {
        BatteryToggle = toggle.GetComponent<Toggle>();
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

    public void checkBattery()
    {
        toggle.SetActive(true);
        BatteryToggle.isOn = true;
        Invoke("showBatteryAnimation", 2.0f);
    }
    void showBatteryAnimation()
    {
        Canvas2.SetActive(false);
        rickshaw.SetActive(true);
    }
}
