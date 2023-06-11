/// <summary>
/// Classe responsável pelas exceções tanto nos casos de o robo tentar sair do mapa, posição ocupad, sem energia e não ter nada para coletar.
/// </summary>
public class OutOfMapException : Exception {}
public class OccupiedPositionException : Exception {}
public class RanOutOfEnergyException : Exception {}
public class NothingToCollectException : Exception {}