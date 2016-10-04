using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {
    protected string horizontal = "Horizontal"; 
    protected string vertical = "Vertical";
    protected string attack = "Attack";
    protected string defense = "Defense";
    private bool isDead = false;
    private int hp = 20;
    private int maxHP = 20;
    private int mp = 10;
    private int maxMP = 10;
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
    public void Movement(Transform transform) {
        if (!isDead) {
            moveHorizontal = Input.GetAxis(horizontal);
            moveVertical = Input.GetAxis(vertical);
            tempPosition = transform.position;
            tempPosition.x += movementSpeed * moveHorizontal * Time.deltaTime;
            tempPosition.y += movementSpeed * moveVertical * Time.deltaTime;
            transform.position = tempPosition;
            if (Input.GetButtonDown(attack)) {
                AttackSpell();
            }else if (Input.GetButtonDown(defense)) {
                DefenseSpell();
            }
        }
    }
    public void Damage(int damage) {
        hp -= damage;
        if (hp <= 0) {
            hp = 0;
            isDead = true;
        }
    }
    public void IncreaseStats(int multiplyer) {
        maxHP += maxHP / multiplyer;
        maxMP += maxMP / multiplyer;
    }
    virtual public void AttackSpell() { }
    virtual public void DefenseSpell() { }
}
