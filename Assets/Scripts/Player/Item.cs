using UnityEngine;
using System.Collections;

public class Item : MonoBehaviour {
    private int quantity=0;
    protected string flavorText;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    public void AddItem() {
        quantity++;
    }
    public string ViewText() {
        return flavorText;
    }
    public void Effect() { }
}
