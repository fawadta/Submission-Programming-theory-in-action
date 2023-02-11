using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follow_Player : MonoBehaviour
{
    private Vector3 offset = new Vector3(0, 2.63f, -3.76f);
    public GameObject player;
    //public bool isFound = false;
    private void Start()
    {
        player = GameObject.FindWithTag("Player");
    }
    // Start is called before the first frame update
    void Update()
    {
        transform.position = player.transform.position + offset;
        //Debug.Log(transform.position);
    }
}
