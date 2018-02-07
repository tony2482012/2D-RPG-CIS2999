
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StatCode : MonoBehaviour
{

    private Image content;

    [SerializeField]
    private Text stateValue;

    private float currentFill;

    private float currentValue;

    [SerializeField]
    private float lerpsSpeed;

    public float MyMaxValue { get; set; }

    public float MyCurrentValue
    {
        get
        {
            return currentValue;
        }

        set
        {
            if (value > MyMaxValue) //makes sure that we don't get too health
            {
                currentValue = MyMaxValue;
            }
            else if (value < 0) // makes sure that we don't get health below 0
             {
                currentValue = 0;
            }
            else //make sure that we set the current value within the bounds of 0 to max health 100
            {
                currentValue = value;
            }

            //calculates the currentFill so that we can lerp
            currentFill = currentValue / MyMaxValue;

            stateValue.text = currentValue + "/" + MyMaxValue;  //to change the text when you get damaged

        }

    }



    // Use this for initialization
    void Start()
    {
        content = GetComponent<Image>();

    }

    // Update is called once per frame
    void Update()
    {
        /*
        if (currentFill != content.fillamount)
        {
            content.fillAmount = Mathf.Lerp(content.fillAmount, currentFill, Time.deltaTime * lerpsSpeed);
        }
        */
    }
    public void Initialized(float currentValue, float maxValue)
    {
        MyMaxValue = maxValue;
        MyCurrentValue = currentValue;
    }
}


