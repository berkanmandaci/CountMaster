using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using Random = UnityEngine.Random;

public class ScoreController : MonoBehaviour
{
    public GameObject cloneCharacter;
    private Queue<Vector3> posQueue;
    private List<Vector3> posList;
    public float spawnDis;
    public int characterCounter;
    private int layerCount;
    public TextMeshProUGUI scoreValueTxt;
    private void Start()
    {
        posQueue = new Queue<Vector3>();
        layerCount = 1;
        posList = new List<Vector3>();
        posQueue.Enqueue(new Vector3(-0.4f,0,0));//sol
        posQueue.Enqueue(new Vector3(0.4f,0,0));//sağ
        posQueue.Enqueue(new Vector3(0,0,0.4f));//ön
        posQueue.Enqueue(new Vector3(0,0,-0.4f));//arka
        posQueue.Enqueue(new Vector3(-0.4f,0,0.4f));//sol ön
        posQueue.Enqueue(new Vector3(-0.4f,0,-0.4f));//sol arka
        posQueue.Enqueue(new Vector3(0.4f,0,0.4f));//sağ ön
        posQueue.Enqueue(new Vector3(0.4f,0,-0.4f));//sağ arkas
        
        
        posList.Add(new Vector3(-spawnDis,0,0));//sol
        posList.Add(new Vector3(spawnDis,0,0));//sağ
        posList.Add(new Vector3(0,0,spawnDis));//ön
        posList.Add(new Vector3(0,0,-spawnDis));//arka
        posList.Add(new Vector3(-spawnDis,0,spawnDis));//sol ön
        posList.Add(new Vector3(-spawnDis,0,-spawnDis));//sol arka
        posList.Add(new Vector3(spawnDis,0,spawnDis));//sağ ön
        posList.Add(new Vector3(spawnDis,0,-spawnDis));//sağ arkas
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("ScoreWall"))
        {
            var scoreValue = other.GetComponent<RandomScore>().scoreValue;
            AddQueue(scoreValue);
            for (int i = 0; i < scoreValue; i++)
            {
                //spawn sound
                var character = Instantiate(cloneCharacter, transform.position+(posList[i+characterCounter]), Quaternion.identity,transform);
            }
            layerCount++;
            characterCounter = +scoreValue;
        }
    }

    private void AddQueue(int scoreValue)
    {
        foreach (var pos in posQueue)
        {
            posList.Add(pos);
        }
        var kalan = scoreValue % 8;
        if (kalan!=0)
        {
            for (int i = 0; i < kalan; i++)
            {
                posList.Add(posList[i]);
            }
        }
    }
}


