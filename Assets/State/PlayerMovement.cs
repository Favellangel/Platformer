using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    StandartMovement standartMovement;
    Climb climb;

    private void Awake()
    {
        climb = GetComponent<Climb>();   
        standartMovement = GetComponent<StandartMovement>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Respawn")
            ClimbState();
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        
    }

    public void ClimbState()
    {
        climb.enabled = true;
        standartMovement.enabled = false;
    }

    public void MoveState()
    {
        climb.enabled = false;
        standartMovement.enabled = true;
    }
}
