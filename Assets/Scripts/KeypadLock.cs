using UnityEngine;

public class KeypadLock : MonoBehaviour
{
    public string code = "1234";
    public GameObject door;
    private string enterCode = "";
    private bool isDoorOpen = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void AddDigit(string digit)
    {
        if (enterCode.Length < code.Length)
        {
            enterCode += digit;
            Debug.Log("Current code" + enterCode);
        }
    }

    // Update is called once per frame
    public void CheckCode()
    {
        if (enterCode == code)
        {
            Debug.Log("Its correct passcode");
            OpenDoor();
        }
        else 
        {
            Debug.Log("code is Incorrect");
            ClearCode();
        }
    }
    public void ClearCode()
    {
        enterCode = "";
        Debug.Log("Screen is clear");
    }
    private void OpenDoor()
    {
        if (!isDoorOpen && door != null)
        {
            door.transform.position += new Vector3(0, 2f, 0);
        }
    }
}
