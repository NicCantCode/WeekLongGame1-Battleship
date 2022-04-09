using System.Runtime.CompilerServices;
using UnityEngine;

public class Battleship : Ship
{
    protected override void SinkShip()
    {
        switch (ShipOwner)
        {
            case ShipOwner.ENEMY:
                Debug.Log($"Enemy {GetType().Name} was sunk!");
                GetGameManagerReference().SubtractFromEnemyShipPool();
                break;
            case ShipOwner.PLAYER:
                Debug.Log($"Player {GetType().Name} was sunk!");
                GetGameManagerReference().SubtractFromPlayerShipPool();
                break;
        }
    }
}