/*
 
    say we have 2 entities:
    
    important message
        1. encrypt
        2. deleted
        3. has a creator
        4. creation date

    regular message:
        1. can be read
        2. can be shouted
        3. has a creator
        4. has a creation date

     how would you improve this code?
 
 */

// option 1: inheritance

using System;

public abstract class BaseMsg {
    protected string _creator;
    protected DateTime _creationDate;
    protected string _content;

    public BaseMsg(string creator, DateTime creationDate, string content)
    {
        _creator = creator;
        _creationDate = creationDate;
    }

    public void showCreator() {
        Console.WriteLine($"creator is: {this._creator}");
    }
}

public class ImportantMsg: BaseMsg {
    public ImportantMsg(string creator, DateTime creationDate, string content ): base(creator, creationDate, content) { }

    public void encrypt() {
        Console.WriteLine("encrypting...");
    }

    public void destroy() {
        Console.WriteLine("destroy now!");
        this._content = "";
    }

}

public class RegularMsg: BaseMsg {
    public RegularMsg(string creator, DateTime creationDate, string content) : base(creator, creationDate, content) { }

    public void read()
    {
        Console.WriteLine($"msg is: {this._content}");
    }

    public void Shout() {
        Console.WriteLine($"msg  is: {this._content.ToUpper()}");
    }
}

// problem - if we want to provide a service:
public class MessageProcessor
{
    public void HandleEncryption(BaseMsg msg)
    {
        // show creator
        Console.WriteLine(msg);
        msg.Encrypt(); // ❌ won't compile – not all messages encrypt
    }
}

// solution - using interface:
// how to solve? 
// one way - handleEcryption for everytype of class
// problem - duplication

// another solution - segregate interfaces


// Interface segregation for capabilities
public interface IEncryptable
{
    void Encrypt();
}

public interface IDestructible
{
    void Destroy();
}

public interface IReadable
{
    void Read();
}

public interface IShoutable
{
    void Shout();
}

// now the processor:
public class MessageProcessor
{
    public void HandleEncryption(IEncryptable msg)
    {
        msg.Encrypt();
    }

    public void HandleDestruction(IDestructible msg)
    {
        msg.Destroy();
    }

    public void HandleReading(IReadable msg)
    {
        msg.Read();
    }

    public void HandleShouting(IShoutable msg)
    {
        msg.Shout();
    }
}

// what is the diff from just using methods that accept diff classes?
// because if we have a new class that also has encrypt - we will need another method
// if we use interface - we can add as many new classes as we like 