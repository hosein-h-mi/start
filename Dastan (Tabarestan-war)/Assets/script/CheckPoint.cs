using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPoint : MonoBehaviour
{
    public LevelManger levelManger; 
    // Start is called before the first frame update
    void Start()
    {
        levelManger = FindObjectOfType<LevelManger>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.name == "rostam")
        {
            levelManger.currentCheckPoint = gameObject;
        }
    }
}
