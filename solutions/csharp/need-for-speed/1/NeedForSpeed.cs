class RemoteControlCar(int speed, int batteryDrain)
{
    private int _speed = speed;
    private int _batteryDrain = batteryDrain;

    private int _batteryLevel = 100;
    private int _distanceDriven = 0;

    public bool BatteryDrained() => _batteryLevel == 0 || _batteryLevel < _batteryDrain;

    public int DistanceDriven() =>  _distanceDriven;

    public void Drive()
    {
        if (BatteryDrained()) return;
        _distanceDriven +=  _speed;
        _batteryLevel -= _batteryDrain;
    }

    public static RemoteControlCar Nitro() => new(50, 4);
}

class RaceTrack(int distance)
{
    private int _distance = distance;

    public bool TryFinishTrack(RemoteControlCar car)
    {
        while (!car.BatteryDrained())
        {
            car.Drive();
        }
        return car.DistanceDriven() >=  _distance;
    }
}
