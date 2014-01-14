using UnityEngine;
using System.Collections;

public class GameManager : UnitySingleton<GameManager> {

    private GameManager() { }

    protected override void Init() {
        Debug.Log("[GameManager] Init");
        Persist = false;
    }

	void Start() {
        Debug.Log("[GameManager] Start");
	}

    public void test() {
        Debug.Log("test");
    }
}
