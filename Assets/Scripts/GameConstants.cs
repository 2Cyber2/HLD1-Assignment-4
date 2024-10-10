using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class GameConstants
{
    // Gameplay constants
    public const float DefaultGameDuration = 300.0f;
    public const float DestroyActorAtY = -8.0f;

    public static readonly Vector2[] BreakableBlockBitOffsets = { new Vector2(-0.25f, 0.25f), new Vector2(-0.25f, -0.25f), new Vector2(0.25f, 0.25f), new Vector2(0.25f, -0.25f) };
    public static readonly Vector2[] BreakableBlockBitImpulses = { new Vector2(-4.6875f, 10.9375f), new Vector2(-4.6875f, 9.375f), new Vector2(4.6875f, 10.9375f), new Vector2(4.6875f, 9.375f) };
}
