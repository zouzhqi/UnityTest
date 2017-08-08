using UnityEngine;
using System.Collections;

public class test : MonoBehaviour {

	// Use this for initialization
	void Start () {

        XLua.LuaEnv luaenv = new XLua.LuaEnv();
        luaenv.DoString("CS.UnityEngine.Debug.Log('hello Unity')");
        luaenv.Dispose();
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
