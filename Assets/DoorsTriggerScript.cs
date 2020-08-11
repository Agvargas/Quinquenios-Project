using UnityEngine;

public class DoorsTriggerScript : MonoBehaviour
{
    public GameObject doors;
    public bool evenDoors;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            if (evenDoors)
                doors.GetComponent<Animator>().SetInteger("Doors", 2);
            else
                doors.GetComponent<Animator>().SetInteger("Doors", 1);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            doors.GetComponent<Animator>().SetInteger("Doors", 0);
        }
    }
}
