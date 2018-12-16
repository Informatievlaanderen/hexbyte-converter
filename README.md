# Be.Vlaanderen.Basisregisters.Utilities.HexByteConverter

Easily convert between byte array and hex strings.

## Usage

### Converting from byte array to hex string

```csharp
public class Test
{
    public byte[] Bytes { get; set; }

    public override string ToString()
    {
        return Bytes.ToHexString();
    }
}
```

### Converting from hex string to byte array

```csharp
public class Test
{
    public string HexString { get; set; }

    public byte[] ToByteArray()
    {
        return HexString.ToByteArray();
    }
}
```
