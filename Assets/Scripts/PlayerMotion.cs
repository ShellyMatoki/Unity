using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMotion : MonoBehaviour
{
    CharacterController cController;
    float speed = 0.4f;
    float angularSpeed = 1f;
    float rotationAboutY, rotationAboutX=0f;
    public GameObject aCamera;
    private AudioSource footstep;

    // Start is called before the first frame update
    void Start()
    {
       cController = GetComponent<CharacterController>();
        footstep = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
       // float rotationAboutY, rotationAboutX;
        float dx, dz;
        //transform.localEulerAngles.y 
        rotationAboutY = transform.localEulerAngles.y+ Input.GetAxis("Mouse X") * angularSpeed;
        rotationAboutX -= angularSpeed * Input.GetAxis("Mouse Y");

        /*  transform.Rotate(new Vector3(0, rotationAboutY, 0));
          aCamera.transform.Rotate(new Vector3(rotationAboutX, 0, 0));*/

        aCamera.transform.localEulerAngles = new Vector3(rotationAboutX, 0, 0);
        transform.localEulerAngles = new Vector3(0, rotationAboutY, 0);

        dx = Input.GetAxis("Horizontal") * speed;
        dz = Input.GetAxis("Vertical")*speed;
       

        Vector3 direction = new Vector3(dx, -0.5f, dz);

        direction = transform.TransformDirection(direction);
        cController.Move(direction);

        if (cController.velocity.magnitude>0.4f && !footstep.isPlaying)
            footstep.Play();


    }
}
