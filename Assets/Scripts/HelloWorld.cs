using UnityEngine;
using XLua;

public class HelloWorld : MonoBehaviour
{
    void Start(){
        LuaEnv luaEnv = new LuaEnv();
        luaEnv.DoString("print('this is my hello world')");
        Debug.Log("Though coding is very hard for me,I will try my best.");
    }

}
