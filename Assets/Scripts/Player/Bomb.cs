using UnityEngine;
using System.Collections;

public class Bomb : Player {
    private Transform myTransform;
	// Use this for initialization
	void Start () {
        myTransform = GetComponent<Transform>();
        horizontal += "P1";
        vertical += "P1";
        attack += "P1";
        defense += "P1";
	}
	
	// Update is called once per frame
	void Update () {
        Movement(myTransform);
	}
    override public void AttackSpell() {
        Debug.Log("BOOOOOOM");
    }
    override public void DefenseSpell() {
        Debug.Log("SHINGGGGGG");
    }
}
