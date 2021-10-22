using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMagnet : MonoBehaviour
{

    public Transform target;
    public float moveSpeed;

    private void Start()
    {
        target = GameObject.FindWithTag("CloneCharacter").GetComponent<Transform>();
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            Destroy(gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, target.position, moveSpeed * Time.deltaTime);
    }
}
