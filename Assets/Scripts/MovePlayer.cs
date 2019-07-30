using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    public int _playerSpeed;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("Fire1"))
            transform.position= transform.position+ Camera.main.transform.forward*_playerSpeed*Time.deltaTime;
        
        if (Input.GetKeyDown(KeyCode.Escape)) 
            Application.Quit(); 
    }
}
