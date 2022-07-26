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
        camera = GameObject.Find("PlayerTank").GetComponent<Camera>();
        //GetComponent<Camera>();
        playerTransform = GameObject.Find("PlayerTank").GetComponent<Transform>();
        cameraTransform = GetComponent<Transform>();
        //cameraTransform = GameObject.Find("PlayerTank").GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        cameraTransform.position = new Vector3(playerTransform.position.x, playerTransform.position.y, cameraTransform.position.z);
    }
}
