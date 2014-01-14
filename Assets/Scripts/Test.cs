using UnityEngine;
using System.Collections;

public class Test : MonoBehaviour {

	void Update() {
	    if(Input.GetKeyDown(KeyCode.T))
            GameManager.Instance.test();
	}
}
