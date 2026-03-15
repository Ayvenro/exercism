public static class TelemetryBuffer
{
    public static byte[] ToBuffer(long reading)
    {
        var buffer = new byte[9];

        (int size, bool signed) = reading switch
        {
            > uint.MaxValue => (8, true),
            > int.MaxValue => (4, false),
            > ushort.MaxValue => (4, true),
            >= 0 => (2, false),
            >= short.MinValue => (2,true),
            >= int.MinValue => (4,true),
            _ => (8, true)
        };
        
        buffer[0] = signed ? (byte)(256 - size) : (byte)size;

        var payload = BitConverter.GetBytes(reading);
        Array.Copy(payload, 0, buffer, 1, size);
        
        return buffer;
    }

    public static long FromBuffer(byte[] buffer) => buffer[0] switch
    {
        256 - 8 or 4 or 2 =>  BitConverter.ToInt64(buffer, 1),
        256 - 4 => BitConverter.ToInt32(buffer, 1),
        256 - 2 => BitConverter.ToInt16(buffer, 1),
        _ => 0
    };
}
