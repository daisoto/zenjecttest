using UnityEngine;
using Zenject;

public class GameplayState : GameStateEntity
{
    public override void Initialize()
    {
        Debug.Log("GameplayState Initialized");
    }

    public override void Start()
    {
        Debug.Log("GameplayState Started");
    }

    public override void Tick()
    {
    }

    public override void Dispose()
    {
        Debug.Log("GameplayState Disposed");
    }

    public class Factory : PlaceholderFactory<GameplayState>
    {
    }
}