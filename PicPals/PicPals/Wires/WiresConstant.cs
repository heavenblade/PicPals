namespace PicPals.Wires;

public static class WiresConstant
{
    public static Type[] GetBootstrapper =>
        [
            typeof(Bootstrapper),
            typeof(DAL.Wires.Bootstrapper)
        ];
}
