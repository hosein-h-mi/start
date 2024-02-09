using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManger : MonoBehaviour
{
    public GameObject currentCheckPoint;
    private MoveingPlayer player;
    // Start is called before the first frame update
    void Start()
    {
        player =FindObjectOfType<MoveingPlayer>(); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void RespawnPlayer()
    {
    player.transform .position =currentCheckPoint .transform.position;
    }
}
