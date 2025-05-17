using UnityEngine;

public class Vehicles : MonoBehaviour
{
    private string vehicleName = "Unnamed";
    private float speed = 2.0f;
    public bool isPlayerControlled = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
   
    public string VehicleName
    {
        get {  return vehicleName; }
        set { vehicleName = value; }
    }

    public float Speed
    {
        get { return speed; }
        set
        {
            if (value < 0)
                speed = 0;
            else
                speed = value;
        }
    }
    public virtual void Drive()
    {
        if (isPlayerControlled)
        {
            float vertical = Input.GetAxis("Vertical");
            if (vertical != 0)

            {
                Debug.Log(VehicleName + " is driving at " + Speed);
                transform.Translate(Vector3.forward * vertical* Speed * Time.deltaTime);
            }
        }
    }
}
