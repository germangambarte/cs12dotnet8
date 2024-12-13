int numberOfApples = 12;
decimal pricePerAppple = 0.35M;

Console.WriteLine(
  format: "{0} apples cost {1:C}",
  arg0: numberOfApples,
  arg1: pricePerAppple * numberOfApples
  );

string formatted = string.Format(
  format: "{0} apples cost {1:C}",
  arg0: numberOfApples,
  arg1: pricePerAppple * numberOfApples
);

Console.WriteLine("{0} {1} lived in {2}",
arg0: "German", arg1: "Gambarte", arg2: "Caucete"
);

Console.WriteLine("{0} {1} lived in {2} and worked in the {3} team at {4}",
"German", "Gambarte", "Caucete", "Educational", "Optimizely"
);