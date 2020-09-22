using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class SignInScript : MonoBehaviour
{
    public TMP_InputField nameInput;
    public TMP_InputField idInput;
    public TMP_InputField bussinesInput;
    public TMP_InputField cityInput;
    public Toggle acceptCheck;
    public GameController data;
    public BoxCollider blockerCollider;
    public GameObject rightImage;
    public GameObject wrongImage;

    public void CheckInfo()
    {
        
        for (int i = 0; i < data.dataPlayers.Length; i++)
        {
            if (data.dataPlayers[i][0] == nameInput.text)
            {
                print("ok1");
                if (data.dataPlayers[i][1] == idInput.text)
                {
                    print("ok2");
                    if (data.dataPlayers[i][2] == bussinesInput.text)
                    {
                        print("ok3");
                        if (data.dataPlayers[i][3] == cityInput.text)
                        {
                            print("ok4");
                            if (acceptCheck.isOn)
                            {
                                print("ok5");
                                wrongImage.SetActive(false);
                                data.userID = data.dataPlayers[i][5];
                                //data.userName = data.dataPlayers[i][0];
                                blockerCollider.enabled = false;
                                rightImage.SetActive(true);
                                i = data.dataPlayers.Length;
                            }
                            else
                            {
                                print("wrong5");
                                wrongImage.SetActive(true);
                            }
                        }
                        else
                        {
                            print("wrong4");
                            wrongImage.SetActive(true);
                        }
                    }
                    else
                    {
                        print("wrong3");
                        wrongImage.SetActive(true);
                    }
                }
                else
                {
                    print("wrong2");
                    wrongImage.SetActive(true);
                }
            }
            else
            {
                print("wrong1");
                wrongImage.SetActive(true);
            }
        }
    }
}