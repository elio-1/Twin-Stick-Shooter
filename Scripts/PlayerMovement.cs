using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    #region Exposed
    public float m_speed;
    
    #endregion

    #region Lifecycle

    void Awake()
    {
        
    }
    
    void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

        
    void Update()
    {
        _direction.x = Input.GetAxisRaw("Horizontal");
        _direction.y = Input.GetAxisRaw("Vertical");
        
        
        #region Key Rotation
        /*
        orientationHorizontal = Input.GetAxisRaw("RightStickY");
        orientationVertical = Input.GetAxisRaw("RightStickX");
        
        _orientationInput = new Vector3(orientationHorizontal, 0, orientationVertical);
        if (_orientationInput != Vector3.zero) // garde la derniere orientation
        {
            Quaternion lookRotation = Quaternion.LookRotation(_orientationInput, Vector3.up);
            _rigidbody.MoveRotation(lookRotation);
        }
        
        */
        /* Vector3 local_z = transform.forward;
        Vector3 local_x = transform.right;
        _direction = _direction.x * local_x + _direction.y * local_z; 
        */
       
        #endregion
        #region Mouse Pointer
        /* mouse pointer
        */
        Plane plane = new Plane(Vector3.up, 0);
        float distance;
        Ray cameraRay = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (plane.Raycast(cameraRay, out distance))
        {
            Vector3 pointToLook = cameraRay.GetPoint(distance);
            //Debug.DrawLine(cameraRay.origin, pointToLook, Color.cyan); 
           transform.LookAt(new Vector3(pointToLook.x, 0, pointToLook.z));
        }
        #endregion
    }
    private void FixedUpdate()
    {
       
        Vector3 direction3D = new Vector3(_direction.x, 0,_direction.y);
        direction3D = direction3D.normalized * Time.deltaTime * m_speed;
       //_rigidbody.AddRelativeForce(direction3D);
       _rigidbody.velocity = direction3D;

    }
    #endregion
    #region Main Methods
    #endregion
    #region Private & Protected
    private Vector2 _direction;
    private Rigidbody _rigidbody;
    private float orientationHorizontal;
    private float orientationVertical;
    private Vector3 _orientationInput;
    private Vector3 pointToLook;
   
    #endregion
}
