using UnityEngine;

/// <summary>
/// Responsible for calculating the force based on the distance between the character and the hoop.
/// </summary>
public static class PowerForceCalculator
{
    public static Vector3 GetForceFromSwipeData(SwipeData data)
    {
        var xModifier = (data.StartPosition- data.EndPosition).x / (Screen.width * 1.5f);
        Debug.Log(xModifier);
        return new Vector3(xModifier, 1,1) * 3.1f;
    }
}
