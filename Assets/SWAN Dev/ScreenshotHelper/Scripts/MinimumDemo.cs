﻿using UnityEngine;
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
        //print("Star capture");
        ScreenshotHelper.iCaptureWithCamera(m_Camera, (texture2D) =>
        {
            // Clear the old texture if exist.
            if (m_CubeMeshRenderer.material.mainTexture != null)
            {
                Destroy(m_CubeMeshRenderer.material.mainTexture);
            }

            // Set the new (captured) screenshot texture to the cube renderer.
            m_CubeMeshRenderer.material.mainTexture = texture2D;
            //print("Captured... send to save...");
            SaveTexture(texture2D);

        });
    }

    private void SaveTexture(Texture2D texture2D)
    {
        //print("Start save...");
        bytes = texture2D.EncodeToJPG();
        //print("send to upload...");
        StartCoroutine(UploadImage("https://www.quinqueniosfgs.com/app/uploadimg.php"));
    }

    IEnumerator UploadImage(string a)
    {
        print("Start upload...");
        WWWForm form = new WWWForm();
        form.AddField("idusuario_de", data.userID);
        form.AddField("accesskey", "g67HsR1ockT5dsF");
        form.AddBinaryData("userfile", bytes, data.userID + "_Quinquenios_2020.jpg", "image/jpg");
        WWW w = new WWW(a, form);
        yield return w;

        //print(w.text);
        //print("id_de_: " + data.userID);
        //print("nombre_imagen_: " + data.userID + "_Quinquenios_2020.jpg");

        if (w.error != null)
        {
            //problems 
            print(w.error);
        }
        else
        {
            Application.ExternalCall("download_image", data.userID);
        }
    }
}
