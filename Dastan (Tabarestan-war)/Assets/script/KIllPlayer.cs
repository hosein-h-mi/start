using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KIllPlayer : MonoBehaviour
{
    public LevelManger levelmanger;
    // Start is called before the first frame update
    void Start()
    {
        levelmanger = FindObjectOfType<LevelManger>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.name == "rostam") 
        {
            levelmanger.RespawnPlayer();
        }
    }
}
