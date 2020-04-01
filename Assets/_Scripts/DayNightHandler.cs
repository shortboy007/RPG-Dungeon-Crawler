using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class DayNightHandler : MonoBehaviour
{
    public new Light light;

    public int count = 0;

    public int hourCount;
    
    public int dayLength = 12;

    public int nightLength = 12;

    public float lightIntensity;

    public GameObject timeTextBox;
    public Text timeText;

    //public GameObject invTimeTextBox;
    //public Text invTimeText;

    public bool isDayTime = false;
    public bool isNightTime = false;

    // Start is called before the first frame update
    void Start()
    {
        timeTextBox = GameObject.FindWithTag("TimeText");
        //invTimeTextBox = GameObject.FindWithTag("InvTimeText");

        lightIntensity = light.intensity;

        isNightTime = true;
    }

    // Update is called once per frame
   void Update()
    {        
       this.gameObject.GetComponent<Light>().intensity = lightIntensity;

        count++;

        if(count >= 180 && isNightTime)
        {
            passTimeTowardsNight();
            hourCount = hourCount + 1;

            timeText = timeTextBox.GetComponent<Text>();
            timeText.text = "Time: " + hourCount + " PM";

            /*invTimeText = invTimeTextBox.GetComponent<Text>();
            invTimeText.text = "Time: " + hourCount + " PM";*/
        }

        if (count >= 360/*180*/ && isDayTime)
        {
            passTimeTowardsDay();
            hourCount = hourCount + 1;

            timeText = timeTextBox.GetComponent<Text>();
            timeText.text = "Time: " + hourCount + " AM";

            /*invTimeText = invTimeTextBox.GetComponent<Text>();
            invTimeText.text = "Time: " + hourCount + " AM";*/
        }

        if (lightIntensity >= 1.2 && isDayTime)
        {
                isNightTime = true;
                isDayTime = false;
                hourCount = 1;

            timeText = timeTextBox.GetComponent<Text>();
            timeText.text = "Time: " + hourCount + " PM";

            /*invTimeText = invTimeTextBox.GetComponent<Text>();
            invTimeText.text = "Time: " + hourCount + " PM";*/
        }

        else if (lightIntensity <= 0 && isNightTime)
        {
                isDayTime = true;
                isNightTime = false;
                hourCount = 1;

            timeText = timeTextBox.GetComponent<Text>();
            timeText.text = "Time: " + hourCount + " AM";

            /*invTimeText = invTimeTextBox.GetComponent<Text>();
            invTimeText.text = "Time: " + hourCount + " AM";*/
        }

        /*if (Input.GetKeyDown(KeyCode.Keypad6))
        {
            lightIntensity = 1.2f;
        }
        if (Input.GetKeyDown(KeyCode.Keypad3))
        {
            lightIntensity = 0f;
        }*/

    }

    public void passTimeTowardsNight()
    {
        count = 0;
        lightIntensity = lightIntensity - 0.1f;
        isDayTime = false;
    }

    public void passTimeTowardsDay()
    {
        count = 0;
        lightIntensity = lightIntensity + 0.1f;
        isNightTime = false;
    }

}
