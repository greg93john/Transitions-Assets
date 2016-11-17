using UnityEngine;
using System.Collections;

public class game : MonoBehaviour
{

    public enum gravity { descending, level, ascending, climbing, hanging, pushing };
    public enum action { idle, shift, perform, recover, connect };

    public enum state { stationary, traverse, strafe, pivot, rotate };
    public enum speed { halt, moderate, quick, rapid };

    public enum cardinal { N, E, S, W, center };
    public enum orientation { fw, bw, lt, rt };

    public static float oneSpace = 0.125f;

}


public class set
{


    public static Vector3 V3(float _a, float _b, float _c) {///shift between a float[] and a Vector3
        Vector3 _V3 = (Vector3.right * _a) + (Vector3.up * _b) + (Vector3.forward * _c);
        return _V3;
    }///        public static Vector3 V3(  float _a,  float _b,  float _c)
    public static Vector3 V3(int _a, int _b, int _c) {///shift between a float[] and a Vector3
        Vector3 _V3 = (Vector3.right * _a) + (Vector3.up * _b) + (Vector3.forward * _c);
        return _V3;
    }///        public static Vector3 V3(  float _a,  float _b,  float _c)
    public static Vector3 NormalizeV3(Vector3 _value) {///set a vector 3 to have a value of 1 for only a single axis.
        float x = _value.x; float y = _value.y; float z = _value.z;    //collect each float
        Vector3 Calculation = (Vector3.right * Mathf.RoundToInt(x)) + (Vector3.up * Mathf.RoundToInt(y)) + (Vector3.forward * Mathf.RoundToInt(z));
        return Calculation;
    }///        public static Vector3 V3toNormal( Vector3 _value)

}