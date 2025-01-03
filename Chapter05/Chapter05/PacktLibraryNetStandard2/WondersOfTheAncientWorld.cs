﻿namespace Packt.Shared;

[Flags]
public enum WondersOfTheAncientWorld : byte
{
    GreatPyramidOfGiza = 0b_0000_0000,
    HangingGardenOfBabylon = 0b_0000_0001,
    StatueOfZeusAtOlympia = 0b_0000_0010,
    TempleOfArtemisAtEphesus = 0b_0000_0100,
    MausoleumAtHalicarnassus = 0b_0000_1000,
    ColossusOfRhodes = 0b_0001_0000,
    LighthouseOfAlezandria = 0b_0010_0000,
}