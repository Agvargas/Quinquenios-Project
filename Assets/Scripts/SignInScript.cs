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

    public void CheckInfo()
    {
        for (int i = 0; i < 1444; i++)
        {
            if (data.dataPlayers[i][0] == nameInput.text)
            {
                if (data.dataPlayers[i][1] == idInput.text)
                {
                    if (data.dataPlayers[i][2] == bussinesInput.text)
                    {
                        if (data.dataPlayers[i][3] == cityInput.text)
                        {
                            if (acceptCheck.isOn)
                            {
                                data.userID = Int32.Parse(data.dataPlayers[i][5]);
                                blockerCollider.enabled = false;
                                gameObject.SetActive(false);
                            }
                        }
                    }
                }
            }
        }
    }
}