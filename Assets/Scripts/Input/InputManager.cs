public class InputManager
{

  private PlayerControls playerControls;

  public float Moviment => playerControls.Gameplay.moviment.ReadValue<float>();


  public InputManager()
  {
    playerControls = new PlayerControls();
    playerControls.Gameplay.Enable();
  }


}
