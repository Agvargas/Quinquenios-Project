using UnityEngine;

public class ImageScript : MonoBehaviour
{
    public ContentHeightScript contentScript;
    public string personID;

    public void SendMessage()
    {
        contentScript.UpdateImage(name, personID);
    }
}
