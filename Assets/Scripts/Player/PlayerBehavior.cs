using UnityEngine;
using UnityEngine.Scripting.APIUpdating;

public class PlayerBehavior : MonoBehaviour
{

    [SerializeField] private float moveSpeed = 5;

    void Update()
    {
        float movimentDirection = GameManager.Instance.InputManager.Movement * Time.deltaTime * moveSpeed;
        transform.Translate(movimentDirection, 0, 0);
    }

}
