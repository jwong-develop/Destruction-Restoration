using UnityEngine;
using System.Collections;

public class Fairy : Player {
    private Transform myTransform;
	// Use this for initialization
	void Start () {
        myTransform = GetComponent<Transform>();
        horizontal += "P2";
        vertical += "P2";
        attack += "P2";
        defense += "P2";
    }
	
	// Update is called once per frame
	void Update () {
        Movement(myTransform);
	}
    override public void AttackSpell() {
        Debug.Log("HISSSSS");
    }
    override public void DefenseSpell() {
        Debug.Log("WOOOOOP");
    }
}
