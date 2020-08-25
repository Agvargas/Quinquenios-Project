using UnityEngine;

public class ImageScript : MonoBehaviour
{
    public ContentHeightScript contentScript;

    public void SendMessage()
    {
        contentScript.UpdateImage(name);
    }
}
