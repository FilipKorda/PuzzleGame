using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Death : MonoBehaviour
{
    [SerializeField] private Transform player;
    [SerializeField] private Transform respawn_point;
    [SerializeField] private Transform respawn_point2;
    [SerializeField] private Transform respawn_point3;
    [SerializeField] private Transform respawn_point4;
    [SerializeField] private Transform respawn_point5;
    

     void OnCollisionEnter(Collision other)
    {
        if(other.transform.tag == "Enemy")
        {
             Die();
        }
        if(other.transform.tag == "Enemy1")
        {
            Die1();
        }
        if(other.transform.tag == "Enemy2")
        {
            Die2();
        }
        if(other.transform.tag == "Enemy3")
        {
            Die3();
        }
        if(other.transform.tag == "Enemy4")
        {
            Die4();
        }
    }
    
    void Die()
    {
        player.transform.position = respawn_point.transform.position;
        
    }
    void Die1()
    {
        player.transform.position = respawn_point2.transform.position;
    }
    void Die2()
    {
        player.transform.position = respawn_point3.transform.position;
    }
    void Die3()
    {
        player.transform.position = respawn_point4.transform.position;
    }
    void Die4()
    {
        player.transform.position = respawn_point5.transform.position;
    }
}
