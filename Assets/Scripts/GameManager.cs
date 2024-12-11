using Unity.VisualScripting;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }
    public InputManager InputManager { get; private set; }

    private void Awake()
    {

        if (Instance != null)
        {
            Destroy(this.GameObject());
            return;
        }
        Instance = this;
        InputManager = new InputManager();
    }

}
