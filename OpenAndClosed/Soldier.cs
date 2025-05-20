using System;

public class Soldier
{
    // how to add extendable fire method?

    // option 1: parameterazation and switch
    public void fire(string weapon)
    {
        switch (weapon)
        {

            case "gun":
                Console.WriteLine("pyu pyu");
                break;
            case "cannon":
                Console.WriteLine("boom!!!!");
                break;
        }
    }
    // problems - need to edit exsiting working code to add more firing options

    // option 2 - open and closed. make the code extenable

    public void extendableFire() // using the Ifireinterface
    {
        this._weapon.fire();
    }
    // usage - we create a soldier with a weapon class that uses IFirable
    // then we class the fire method - we can add as many weapons as we want
    // without changing the soldier class

    // add weapon property
    private IFireable _weapon;
    public void addWeapon(IFireable weapon)
    {
        _weapon = weapon;
    }

    

}