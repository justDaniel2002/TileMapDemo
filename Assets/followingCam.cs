using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followingCam : MonoBehaviour
{
    public GameObject player;
    public float followSpeed = 4f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newPos = new Vector3(player.transform.position.x, player.transform.position.y, -10f);
        transform.position = Vector3.Slerp(transform.position, newPos, followSpeed * Time.deltaTime);
    }
}
