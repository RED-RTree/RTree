namespace RTree.Literals;

public enum DuplicateHandling
{
    None,       // No permite duplicados (comportamiento por defecto)
    Allow,      // Permite duplicados como nodos separados
    Count       // Almacena un contador en cada nodo para duplicados
}