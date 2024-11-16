using UnityEngine;

public class PlayerBehavior : MonoBehaviour
{

    private InputManager inputManager;

    void Start()
    {
        inputManager = new InputManager();
    }


    void Update()
    {
        float movimentDirection = inputManager.Moviment;
        transform.Translate(movimentDirection * Time.deltaTime, 0, 0);
    }

}
