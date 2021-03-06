﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*  this script moves the gameobject toward player position to act like a bullet or rocket
	this script should be assigned to the bullet prefab
	the bullet will follow the game gameObject with tag "Player" as target,
	you can also access the player transform by using public variable by a litle change
	bullet should have rigidbody component and player should have a collider and rigidbody
	*/
public class TwoDBullet : MonoBehaviour {

    public int speed = 30;

    public bool followMode; //should bullet or rocket follow the player?!

    private Transform playerTransform;

    private Vector2 playerFirstPos;

    // Start is called before the first frame update
    void Start () {
        playerTransform = GameObject.FindGameObjectWithTag ("Player")
            .GetComponent<Transform> ();

        playerFirstPos = playerTransform.position;
    }

    // Update is called once per frame
    void Update () {
        if (followMode) {
            transform.position =
                Vector2.MoveTowards (transform.position, playerTransform.position, speed * Time.deltaTime);
        } else {
            transform.position =
                Vector2.MoveTowards (transform.position, playerFirstPos, speed * Time.deltaTime);

        }
    }
}