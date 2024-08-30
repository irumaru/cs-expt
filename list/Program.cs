
List<float> weights = new List<float>();

weights.Add(1.0f);
weights.Add(2.0f);
weights.Add(3.0f);

for (int i = 0; i < weights.Count; i ++)
{
  Console.WriteLine(weights[i]);
}

foreach (float weight in weights)
{
  Console.WriteLine(weight);
}

