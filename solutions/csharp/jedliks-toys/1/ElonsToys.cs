using System;

class RemoteControlCar
{
    private int _meters;
    private int _batteryCapacity = 100;
    
    public static RemoteControlCar Buy()
    {
        RemoteControlCar car = new RemoteControlCar();
        return car;
    }

    public string DistanceDisplay()
    {
          return $"Driven {_meters} meters";
    }

    public string BatteryDisplay()
    {
        return _batteryCapacity > 0 ? $"Battery at {_batteryCapacity}%" : "Battery empty";
    }

    public void Drive()
    {
        if(_batteryCapacity > 0)
        {
            _meters += 20;
            _batteryCapacity -= 1;
        }
    }
}
