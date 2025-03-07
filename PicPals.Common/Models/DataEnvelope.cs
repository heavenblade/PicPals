namespace PicPals.Common.Model;

public class DataEnvelope<T>
{
    public List<T> Data { get; set; }
    public int Count { get; set; }
}
