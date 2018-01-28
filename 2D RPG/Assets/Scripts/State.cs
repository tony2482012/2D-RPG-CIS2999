using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Stat : MonoBehaviour
{

    private Image content;
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
            if (value > MyMaxValue)
            {
                currentValue = MyMaxValue;
            }
            else if (value < 0)
            {
                currentValue = 0;
            }
            else
            {
                currentValue = value;
            }
            currentFill = currentValue / MyMaxValue;
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
        if (currentFill != content.fillamount)
        {
            content.fillAmount = Mathf.Lerp(content.fillAmount, currentFill, Time.deltaTime * lerpsSpeed);
        }

    }
    public void Initialized(float currentValue, float maxValue)
    {
        MyMaxValue = maxValue;
        MyCurrentValue = currentValue;
    }
}



