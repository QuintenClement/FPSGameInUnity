using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowBowScript : MonoBehaviour
{
    private Rigidbody myBody;
    public float speed = 30f;
    public float deactivate_Timer = 3f;
    public float damage = 15f;
    


    void Awake()
    {
        myBody = GetComponent<Rigidbody>();
    }
    // Start is called before the first frame update
    void Start()
    {
        Invoke("DeactivateGameObject", deactivate_Timer);
    }
   

    public void Launch(Camera mainCamera)
    {
        //"shoots" object in the direction the camera is facing
        myBody.velocity = mainCamera.transform.forward * speed;
        //rotate object to correct orientation
        transform.LookAt(transform.position + myBody.velocity);
    }
    void DeactivateGameObject()
    {
        if(gameObject.activeInHierarchy)
        {
            gameObject.SetActive(false);
        }
    }

    void OnTriggerEnter(Collider target)
    {
        //after hits enemy, deactivate game object

    }

























}//class
