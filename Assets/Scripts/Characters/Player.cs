using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEditor.Rendering;
using UnityEngine;

public class Player : MonoBehaviour
{

    [SerializeField] private float speed;
    private Vector3 _movementDirection; 

    // Start is called before the first frame update
    void Start()
    {
        Inputmanager.Initialise(meFr:this); 
        Inputmanager.Gamemode();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += speed * Time.deltaTime * _movementDirection; 
    }

    public void SetMovementDirection(Vector3 newDirection)
    {
        _movementDirection = newDirection; 
    }
}
