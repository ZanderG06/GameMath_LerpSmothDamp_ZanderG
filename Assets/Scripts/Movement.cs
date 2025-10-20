using UnityEngine;

public class Movement : MonoBehaviour
{
    public Vector3 a = new Vector3(0,0,0);
    public Vector3 b = new Vector3(10, 10, 10);
    public Vector3 c = new Vector3(5, 5, 0);
    public Vector3 d = new Vector3(0, 0, 0);
    static Vector3 velocity = new Vector3(0, 0, 2);

    public GameObject cube1;
    public GameObject cube2;
    static float timeSec;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timeSec = Time.time;
        cube1.transform.position = Vector3.Lerp(a, b, timeSec);
        cube2.transform.position = Vector3.SmoothDamp(c, d, ref velocity, timeSec);
    }
}
