using UnityEngine;

public class Bus : Vehicles
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        VehicleName = "Bus";
        Speed = 20.0f;
    }

    // Update is called once per frame
    void Update()
    {

    }
    public override void Drive()
    {
        base.Drive();
        Debug.Log(VehicleName + " is moving slowly at " + Speed);

    }
}
