using UnityEngine;

public class Player2 : Player
{
    protected override void SetParam()
    {
        angleStep = 30f;
        velocityStep = 5f;
        fireCooldown = 0.5f;

        angleUpKey = KeyCode.UpArrow;
        angleDownKey = KeyCode.DownArrow;
        velocityUpKey = KeyCode.RightArrow;
        velocityDownKey = KeyCode.LeftArrow;
        fireKey = KeyCode.Return;
    }
}
