using System;
using Zenject;

public abstract class GameStateEntity : IInitializable, ITickable, IDisposable
{
    public virtual void Initialize()
    {
        // optionally overridden
    }

    public virtual void Start()
    {
        // optionally overridden
    }

    public virtual void Tick()
    {
        // optionally overridden
    }

    public virtual void Dispose()
    {
        // optionally overridden
    }
}