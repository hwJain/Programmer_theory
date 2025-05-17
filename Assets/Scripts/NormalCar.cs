using UnityEngine;

public class NormalCar : Vehicles
{
    void Start()
    {
        VehicleName = "Normal Car";
        Speed = 35.0f;
    }

    // Update is called once per frame
    void Update()
    {

    }
    public override void Drive()
    {
        base.Drive();
        Debug.Log(VehicleName + " cruising at " + Speed);

    }
}
