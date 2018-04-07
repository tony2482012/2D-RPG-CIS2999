
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//Elias
public class StatCode : MonoBehaviour
{

    private Image content;
    
    [SerializeField]
    private Text stateValue;
    
    private float currentFill;

    //the amount we have in the mean time
    private float currentValue;
    
    [SerializeField]
    private float lerpsSpeed;
    
    public float MyMaxValue { get; set; }

    [SerializeField] public float MyCurrentValue // Selena - made serializable
    {
        get
        {
            return currentValue;
        }

        set
        {
            if (value > MyMaxValue) //makes sure that we don't get health over max 100
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
       // content.fillAmount = currentFill;
       
        if (currentFill != content.fillAmount)
        {
            content.fillAmount = Mathf.Lerp(content.fillAmount, currentFill, Time.deltaTime * lerpsSpeed);
        }
        

    }
    //to make sure our values are set when start the game
    public void Initialized(float currentValue, float maxValue)
    {
        MyMaxValue = maxValue;
        MyCurrentValue = currentValue;
    }
}


