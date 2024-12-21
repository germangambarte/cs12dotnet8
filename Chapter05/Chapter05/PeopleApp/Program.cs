using Packt.Shared;

ConfigureConsole();

Person bob = new();

bob.Name = "Bob Smith";
bob.Born = new DateTimeOffset(
    year: 1965, month: 12, day: 22,
    hour: 16, minute: 20, second: 0,
    offset: TimeSpan.FromHours(-3)
);
WriteLine(format: "{0} nació el {1:D}.",
    arg0: bob.Name, arg1: bob.Born);

bob.FavoriteAncientWonder = WondersOfTheAncientWorld.StatueOfZeusAtOlympia;
WriteLine(
    format: "{0}'s favorite wonder is {1}. Its integer is {2}.",
    arg0: bob.Name,
    arg1: bob.FavoriteAncientWonder,
    arg2: (int)bob.FavoriteAncientWonder
);

bob.BucketList =
    WondersOfTheAncientWorld.HangingGardenOfBabylon
    | WondersOfTheAncientWorld.MausoleumAtHalicarnassus;
WriteLine($"{bob.Name}'s bucket list is {bob.BucketList}");

bob.Children.Add(new Person { Name = "Alfred" });
bob.Children.Add(new Person { Name = "Bella" });
bob.Children.Add(new Person { Name = "Zoe" });
WriteLine($"{bob.Name} has {bob.Children.Count} children:");
foreach(Person child in bob.Children)
{
    WriteLine($"> {child.Name}");
}

Person alice = new()
{
    Name = "Alice Jones",
    Born = new(1998, 3, 7, 16, 28, 0, TimeSpan.Zero)
};

WriteLine(format: "{0} nació el {1:D}.",
    arg0: alice.Name, arg1: alice.Born);