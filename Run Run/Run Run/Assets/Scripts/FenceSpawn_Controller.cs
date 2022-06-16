using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FenceSpawn_Controller : MonoBehaviour
{
    public GameObject FenceSpawn;
    public float interval;
    

    private void OnEnable()
    {
        InvokeRepeating(nameof(FenceSpawn), interval, interval);
    }
    private void OnDisable()
    {
        CancelInvoke(nameof(FenceSpawn));
    }
   
}
