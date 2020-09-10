using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class MinimumDemo : MonoBehaviour
{
    public Camera m_Camera;
    public MeshRenderer m_CubeMeshRenderer;
    public GameController data;
    private byte[] bytes;

    public Text ui;

    [Space]
    public SDev.FileSaveUtil.AppPath ApplicationPath = SDev.FileSaveUtil.AppPath.PersistentDataPath;
    public string SubFolderName;
    public string FileName;

    public void TakeScreenshot()
    {
        ScreenshotHelper.iCaptureScreen((texture2D) =>
        {
            // Clear the old texture if exist.
            if (m_CubeMeshRenderer.material.mainTexture != null)
            {
                Destroy(m_CubeMeshRenderer.material.mainTexture);
            }

            // Set the new (captured) screenshot texture to the cube renderer.
            m_CubeMeshRenderer.material.mainTexture = texture2D;

            SaveTexture(texture2D);
        });
    }

    public void CaptureWithCamera()
    {
        ScreenshotHelper.iCaptureWithCamera(m_Camera, (texture2D) =>
        {
            // Clear the old texture if exist.
            if (m_CubeMeshRenderer.material.mainTexture != null)
            {
                Destroy(m_CubeMeshRenderer.material.mainTexture);
            }

            // Set the new (captured) screenshot texture to the cube renderer.
            m_CubeMeshRenderer.material.mainTexture = texture2D;

            SaveTexture(texture2D);
        });
    }

    private void SaveTexture(Texture2D texture2D)
    {
        // Example: Save to Application data path
        //string savePath = SDev.FileSaveUtil.Instance.SaveTextureAsJPG(texture2D, ApplicationPath, SubFolderName, FileName);
        //Debug.Log("Result - Texture resolution: " + texture2D.width + " x " + texture2D.height + "\nSaved at: " + savePath);
        //ui.text = "Result - Texture resolution: " + texture2D.width + " x " + texture2D.height + "\nSaved at: " + savePath;
        // Example: Save to mobile device gallery(iOS/Android). <- Requires Mobile Media Plugin (Included in Screenshot Helper Plus, and SwanDev GIF Assets)
        //MobileMedia.SaveImage(texture2D, SubFolderName, FileName, MobileMedia.ImageFormat.JPG);
        bytes = texture2D.EncodeToPNG();
        StartCoroutine(Messenger("https://www.quinqueniosfgs.com/app/mensajes.php"));
    }

    IEnumerator Messenger(string a)
    {
        WWWForm form = new WWWForm();
        form.AddField("idusuario_de", data.userID);
        form.AddField("accesskey", "g67HsR1ockT5dsF");
        form.AddBinaryData("userfile", bytes, data.userID + "_Quinquenios_2020.png", "image/png");
        WWW w = new WWW(a, form);
        yield return w;

        print(w.text);
        print("id_de_: " + data.userID);
        print("nombre_imagen_: " + data.userID + "_Quinquenios_2020.png");

        if (w.error != null)
        {
            //problems 
            print(w.error);
        }
    }
}
