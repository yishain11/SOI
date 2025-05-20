using System;

public class M16 : IFireable {
    public void fire() {
        Console.WriteLine("pyu pyu");
    }
}

public class Cannon : IFireable {
    public void fire() {
        Console.WriteLine("boom!!!");
    }
}

public class Hermes460 : IFireable {
    public void fire() {
        Console.WriteLine("shhhhhh boom");
    }
}