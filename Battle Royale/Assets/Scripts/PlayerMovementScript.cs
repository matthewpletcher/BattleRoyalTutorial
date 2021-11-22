using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementScript : MonoBehaviour
{
    CharacterController CharacterControllerPlayer;
    public float Speed = 1f;
    public float Sensitivity =1f;
    float currentPitch;
    Vector3 move;
    public Transform cameraTransform;     
    // Start is called before the first frame update
    void Start()
    {
        CharacterControllerPlayer = this.GetComponent<CharacterController>();        
        currentPitch=0f;              
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();
        Look();
    }

    void MovePlayer(){     
        move=new Vector3(Input.GetAxis("Horizontal"),0,Input.GetAxis("Vertical"));        
        move =Vector3.ClampMagnitude(move,1f);
        move=transform.TransformDirection(move);        
        CharacterControllerPlayer.SimpleMove(move*Speed);
    }

    void Look(){
        float mouseX=Input.GetAxis("Mouse X")*Sensitivity;        
        float mouseY=Input.GetAxis("Mouse Y")*Sensitivity*-1.0f;
        currentPitch+=mouseY;
        currentPitch=Mathf.Clamp(currentPitch,-25,25);                 
        transform.Rotate(0,mouseX,0);                        
        cameraTransform.localRotation = Quaternion.Euler(currentPitch,0,0);
    }
}
