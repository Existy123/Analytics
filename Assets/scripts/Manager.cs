using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Analytics;

public class Manager : MonoBehaviour
{

    private int enemiesKilled = 90;
    private int numberOfHeadshots = 47;
    private int bestScore = 218;
    // Start is called before the first frame update
    void Start()
    {
        Invoke("Level 3", 2f);
    }

   void Summary()
    {
        Debug.Log("Summary");
        Analytics.CustomEvent("Level 3", new Dictionary<string, object>
        {
            {"Kiled enemies",enemiesKilled },
            {"Total headshots", numberOfHeadshots },
            {"Best score", bestScore }

        }
        );
    }

}
