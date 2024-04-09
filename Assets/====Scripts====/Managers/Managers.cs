using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Managers : MonoBehaviour
{
    private static Managers s_instanace;
    private static bool s_Init = false;

    #region CoreManagers

    private GameManager _game = new GameManager();
    public static GameManager Game { get { return Instance._game; } }

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
