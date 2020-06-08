using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ENDTrigger : MonoBehaviour
{
    public GameManager gameManager;

    private void OnTriggerEnter(Collider other)
    {
        gameManager.CompleteLevel();
    }
}
