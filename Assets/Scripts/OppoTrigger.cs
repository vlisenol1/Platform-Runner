using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OppoTrigger : MonoBehaviour
{



   
    [SerializeField] private Transform oppo1;
    [SerializeField] private Transform oppo2;
    [SerializeField] private Transform oppo3;
    [SerializeField] private Transform oppo4;
    [SerializeField] private Transform oppo5;
    [SerializeField] private Transform oppo6;
    [SerializeField] private Transform oppo7;
    [SerializeField] private Transform oppo8;
    [SerializeField] private Transform oppo9;
    [SerializeField] private Transform oppo10;

    [SerializeField] private Transform respawnPoint1;


    private void OnTriggerEnter(Collider other)
    {


      
        oppo1.transform.position = respawnPoint1.transform.position;
        oppo2.transform.position = respawnPoint1.transform.position;
        oppo3.transform.position = respawnPoint1.transform.position;
        oppo4.transform.position = respawnPoint1.transform.position;
        oppo5.transform.position = respawnPoint1.transform.position;
        oppo6.transform.position = respawnPoint1.transform.position;
        oppo7.transform.position = respawnPoint1.transform.position;
        oppo8.transform.position = respawnPoint1.transform.position;
        oppo9.transform.position = respawnPoint1.transform.position;
        oppo10.transform.position = respawnPoint1.transform.position;

    }


}