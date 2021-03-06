using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Death_On_Collison : MonoBehaviour
{
    [SerializeField] private Transform player;
    [SerializeField] private Transform respawn_point;
    [SerializeField] private Transform respawn_point2;
    [SerializeField] private Transform respawn_point3;
    [SerializeField] private Transform respawn_point4;
    [SerializeField] private Transform respawn_point5;
    [SerializeField] private Transform respawn_point6;

    private void OnTriggerEnter(Collider other)
    {
        player.transform.position = respawn_point.transform.position;
        player.transform.position = respawn_point2.transform.position;
        player.transform.position = respawn_point3.transform.position;
        player.transform.position = respawn_point4.transform.position;
        player.transform.position = respawn_point5.transform.position;
        player.transform.position = respawn_point6.transform.position;
    }
    
}
