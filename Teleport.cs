using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    public GameObject uiObject;
    public Transform teleportTarget;
    public GameObject Player;

    void Start()
    {
        uiObject.SetActive(false);
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            uiObject.SetActive(true);
            StartCoroutine("WaitForSec");
        }
        Player.transform.position = teleportTarget.transform.position;
    }
     IEnumerator WaitForSec()
    {
        yield return new WaitForSeconds(3);
        Destroy(uiObject);
        Destroy(gameObject);
    }
}