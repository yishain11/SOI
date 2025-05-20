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