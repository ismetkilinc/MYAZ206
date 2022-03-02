public class RefType
{
    public int X { get; set; }
    public RefType(int x)
    {
        this.X = x;
    }
    public void Ref(ref int x)
    {
        x++;
    }
    public void Out(out int x)
    {
        x = 10;
        
    }
    
}







