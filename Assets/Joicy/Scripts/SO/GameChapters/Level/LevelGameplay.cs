using UnityEngine;

[System.Serializable]
public class LevelGameplay
{
    [SerializeField] private int population = 100;
    [SerializeField] private int victimsPenalty = 0;
    [SerializeField] private Wave[] _waves = null;

    public int Population { get => population; }
    public int VictimsPenalty { get => victimsPenalty; }
    public Wave[] Waves { get => _waves; }
}
