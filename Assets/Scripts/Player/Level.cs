using UnityEngine;
using System.Collections;

public class Level : MonoBehaviour {
    private int level = 1;
    private int exp = 0;
    private int expNeeded = 100;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    public void AddEXP(int expAdded) {
        exp += expAdded;
        if (exp >= expNeeded)
        {
            level++;
            exp -= expNeeded;
            expNeeded += expNeeded / 4;
        }
    }
}
