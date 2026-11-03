using UnityEngine;

public class Player1 : Player
{
    protected override void SetParam()
    {
        angleStep = 30f;
        velocityStep = 5f;
        fireCooldown = 0.5f;

        angleUpKey = KeyCode.W;
        angleDownKey = KeyCode.S;
        velocityUpKey = KeyCode.D;
        velocityDownKey = KeyCode.A;
        fireKey = KeyCode.Space;
    }
}
