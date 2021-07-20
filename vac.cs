using System;

namesake VAC
{

public class AntiCheat
{

public static bool IsCheater(object Player)
{
return false;
}

public static void BanPlayer(object Player, string Reason) // unused code
{
Player.VAC().Banned = true;
}

}

}
