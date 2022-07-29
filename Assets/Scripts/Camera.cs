using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{

    Camera camera;
    Transform cameraTransform;
    [SerializeField] Transform playerTransform;
    // Start is called before the first frame update
    void Start()
    {
        //camera = GameObject.FindGameObjectWithTag("Player").GetComponent<Camera>();
        //GetComponent<Camera>();
        playerTransform = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        cameraTransform = GetComponent<Transform>();
        //cameraTransform = GameObject.Find("PlayerTank").GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        cameraTransform.position = new Vector3(playerTransform.position.x + 6, playerTransform.position.y + 1, cameraTransform.position.z);
    }
}
