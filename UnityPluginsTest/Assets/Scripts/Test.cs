using UnityEngine;
using System.Collections;
using UnityManagedPluginsTest;

public class Test : MonoBehaviour {

	// Use this for initialization
	void Start () {
        TestClass.StaticFunc();
        TestClass tc1 = new TestClass();
        tc1.GetA();
        tc1.SetA(1);
        TestClass tc2 = new TestClass(2);
        tc2.GetA();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
