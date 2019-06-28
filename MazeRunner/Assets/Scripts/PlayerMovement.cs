using UnityEngine;
using UnityEngine.AI;
using UnityEngine.EventSystems;
public class PlayerMovement : MonoBehaviour
{




    public float speed = 6f;

    Vector3 movement;
    Animator anim;
    Rigidbody playerRigidBody;
    int floorMask;
    float camRayLength = 100f;
    public int key1 = 0;
    public int key2 = 0;
    public int key3 = 0;
    public float distance = 10f;
    public float angleBetween = 0.0f;
    public Transform target;

    void Awake()
    {
       floorMask = LayerMask.GetMask("Floor");anim = GetComponent<Animator>();
        playerRigidBody = GetComponent<Rigidbody>();
        Camera.main.transform.rotation = Quaternion.Euler(0, 276,0);

    }
    void FixedUpdate()
    {
        //  if (Input.GetKey(KeyCode.UpArrow))
        //  {
        //    Vector3 targetDir = target.position - transform.position;
        //    angleBetween = Vector3.Angle(transform.forward, targetDir);
        //Move the Rigidbody forwards constantly at speed you define (the blue arrow axis in Scene view)
        //      playerRigidBody.velocity = transform.forward * speed;
        //  }
        transform.position = transform.position + Camera.main.transform.forward * distance * Time.deltaTime;

      float h = Input.GetAxisRaw("Vertical");
      float v = Input.GetAxisRaw("Horizontal");
       Move(-h, v); 
     //   Vector3 targetDirection = new Vector3(h, 0f, v);
       // targetDirection = Camera.main.transform.TransformDirection(targetDirection);
        //targetDirection.y = 0.0f;

        //    transform.forward = Camera.main.transform.forward;
        //  transform.localEulerAngles = new Vector3(transform.localEulerAngles.x, Camera.main.transform.localEulerAngles.y, transform.localEulerAngles.z);

        Turning();
        //   Animating(-h, -v);


    }

    void Move(float h, float v){
        movement.Set(h, 0f, v);
        movement = movement.normalized * speed * Time.deltaTime;
        playerRigidBody.MovePosition(transform.position + movement);
        float mouseY = (Input.mousePosition.y / Screen.width);
     
        //  float mouseX = (Input.mousePosition.x / Screen.width) - 0.5f;
        //  float mouseY = (Input.mousePosition.y / Screen.height) - 0.5f;
        // transform.localRotation = Quaternion.Euler(new Vector4(-1f * (mouseY * 180f), mouseX * 360f, transform.localRotation.z));
    }


  void Turning()
    {
        Ray camRay = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit floorHit;
        if (Physics.Raycast(camRay, out floorHit, camRayLength, floorMask))
        {
            Vector3 playerToMouse = floorHit.point - transform.position;
            playerToMouse.y = 0f;

            Quaternion newRotation = Quaternion.LookRotation(playerToMouse);
            playerRigidBody.MoveRotation(newRotation);
        }
    } 
 /* void Animating(float h, float v)
    {
        // Create a boolean that is true if either of the input axes is non-zero.
        bool walking = h != 0f || v != 0f;

        // Tell the animator whether or not the player is walking.
        anim.SetBool("IsWalking", walking);
    } */

} 
   



