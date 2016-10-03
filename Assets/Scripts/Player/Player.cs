using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {
    protected string horizontal = "Horizontal"; 
    protected string vertical = "Vertical";
    private Transform myTransform;
    private float movementSpeed = 5f;  
    private float moveHorizontal;
    private float moveVertical;
    private Vector3 tempPosition;

    // Use this for initialization
    void Start() {
        myTransform = GetComponent<Transform>();
    }
    // Update is called once per frame
    void Update() {
        Movement(myTransform);
    }
    public void Movement(Transform transform)
    {
        moveHorizontal = Input.GetAxis(horizontal);
        moveVertical = Input.GetAxis(vertical);
        tempPosition = transform.position;
        tempPosition.x += movementSpeed * moveHorizontal * Time.deltaTime;
        tempPosition.y += movementSpeed * moveVertical * Time.deltaTime;
        transform.position = tempPosition;
    }
}
