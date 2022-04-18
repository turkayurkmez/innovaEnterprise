// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
/*
 * Bir sınıf, implemente ettiği interface'in tüm metodlarını kullanmıyorsa, bu prensibi ihlal ediyorsunuz demektir.
 * 
 * Bir sınıf içindeki bir fonksiyon bir interface'e bağlı olmak zorunda değildir ama implemente ettiği interface'in tüm metodlarını kullanmak zorundadır.
 * 
 * 
 */

public interface IMessage
{
    public Guid Guid { get; set; }
    public string From { get; set; }
    public string To { get; set; }
    public string Subject { get; set; }
    public string Body { get; set; }
   

}

public interface IStreamMessage: IMessage
{
    public int Duration { get; set; }
    public string Type { get; set; }
    public byte[] Stream { get; set; }
}

public class TextMessage : IMessage
{
    public Guid Guid { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public string From { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public string To { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public string Subject { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public string Body { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
}

public class SerializedMessage : IStreamMessage
{
    public int Duration { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public string Type { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public byte[] Stream { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public Guid Guid { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public string From { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public string To { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public string Subject { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public string Body { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
}