#nullable enable
using System;

public class DoOnce
{
    private readonly Action _action;
    private bool _alreadyCalled = false;
    private readonly Action? _fallback;

    public DoOnce(Action action, Action? fallback = null)
    {
        _action = action;
        _fallback = fallback;
    }

    public void Run()
    {
        if (!_alreadyCalled)
        {
            _action.Invoke();
            _alreadyCalled = true;
        }
        else
        {
            _fallback?.Invoke();
        }

    }
}