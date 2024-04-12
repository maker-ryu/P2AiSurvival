using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Managers : MonoBehaviour
{
    private static Managers s_instanace;
    private static bool s_Init = false;

    #region Managers

    private GameManager _game = new GameManager();
    private ObjectManager _object = new ObjectManager();
    private ResourceManager _resource = new ResourceManager();
    
    public static GameManager Game { get { return Instance._game; } }
    public static ObjectManager Object { get { return Instance._object; } }
    public static ResourceManager Resource { get { return Instance._resource; } }

    #endregion

    public static Managers Instance
    {
        get
        {
            if (s_Init == false)
            {
                s_Init = true;

                GameObject go = GameObject.Find("_Manager");
                if (go == null)
                {
                    go = new GameObject() { name = "_Manager" };
                    go.AddComponent<Managers>();
                }
                
                DontDestroyOnLoad(go);
                s_instanace = go.GetComponent<Managers>();
            }
            return s_instanace;
        }
    }
}
