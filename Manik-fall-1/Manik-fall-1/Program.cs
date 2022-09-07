
using Manik_fall_1;

var Senators = new NHLTeam(NHLConference.Eastern, NHLDivision.Atlantic, "Senators", "Ottawa");

Senators.GamePlayed = 82;
Senators.Wins = 33;
Senators.Losses = 42;
Senators.Overtimelosses = 7;

Console.WriteLine(Senators);
Console.WriteLine($"Points ={ Senators.Points}");
