using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeleeAttack : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] Transform endLocation;
    [SerializeField] float speed;
    Vector2 startPosition;
    void Start()
    {
        startPosition = this.transform.localPosition;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.R))
        {
            Vector2 position = Vector2.Lerp(this.transform.localPosition, endLocation.localPosition, speed * Time.deltaTime);
            this.transform.localPosition = position;
        }
        
        else{
            Vector2 position = Vector2.Lerp(this.transform.localPosition, startPosition, speed * Time.deltaTime);
            this.transform.localPosition = position;
        }
        
        
    }
}
