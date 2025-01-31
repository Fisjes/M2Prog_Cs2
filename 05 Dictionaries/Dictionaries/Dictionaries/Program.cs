Dictionary<int,string> personeelOpNummer = new Dictionary<int,string>();

personeelOpNummer.Add(382942, "jim");
personeelOpNummer.Add(789432, "tim");

string jim = personeelOpNummer[382942];
string tim = personeelOpNummer[789432];

foreach (KeyValuePair<int, string> item in personeelOpNummer)
{

}