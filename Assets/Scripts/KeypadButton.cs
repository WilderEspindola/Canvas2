using UnityEngine;

public class KeypadButton : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public KeypadLock keypadLock;
    public string digitOrAction;
    public void pressButton() 
    {
        if (digitOrAction == "Enter")
        {
            keypadLock.CheckCode();
        }
        else if (digitOrAction == "Clear")
        {
            keypadLock.ClearCode();
        }
        else
        {
            keypadLock.AddDigit(digitOrAction); 
        }

    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
