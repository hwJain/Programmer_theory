using UnityEngine;

public class SportsCar : Vehicles
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        VehicleName = "Sports Car";
        Speed = 50.0f;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public override void Drive()
    {
        base.Drive();
        Debug.Log(VehicleName + " is zooming in at " + Speed);

    }
}
