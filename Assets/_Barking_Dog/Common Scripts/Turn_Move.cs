
using UnityEngine;

public class Turn_Move : MonoBehaviour
{
    private int TurnX;
    private int TurnY;

	private int MoveZ;

	public bool Player;

	void Update () {

        if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.DownArrow))
        {
            if (Input.GetKey(KeyCode.UpArrow)) MoveZ = 2;
            if (Input.GetKey(KeyCode.DownArrow)) MoveZ = -2;
        }
        else
        {
            MoveZ = 0;
        }

        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.RightArrow))
        {
            if (Input.GetKey(KeyCode.LeftArrow)) TurnY = -40;
            if (Input.GetKey(KeyCode.RightArrow)) TurnY = 40;
        }
        else
        {
             TurnY = 0;
        }

        if (Input.GetKey(KeyCode.Period) || Input.GetKey(KeyCode.Comma))
        {
            if (Input.GetKey(KeyCode.Period)) TurnX = -40;
            if (Input.GetKey(KeyCode.Comma)) TurnX = 40;
        }
        else
        {
            TurnX = 0;
        }

        if (Player==true) {
            transform.Rotate(0f, TurnY * Time.deltaTime, 0f, Space.Self);
            transform.Translate(0f, 0f, MoveZ * Time.deltaTime, Space.Self);
        }
        else{
            transform.Rotate(TurnX * Time.deltaTime, 0f, 0f, Space.Self);
        }
	}
}
