using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StatCode : MonoBehaviour {

    private Image content;

    private float currentFill;

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
          
            currentValue = value;
        }
    }

    private float currentValue;

	// Use this for initialization
	void Start () {
        content = GetComponent<Image>();
        
	}
	
	// Update is called once per frame
	void Update () {
        Debug.Log(MyCurrentValue);
	}
}
