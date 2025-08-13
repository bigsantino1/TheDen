namespace Content.Server._Impstation.Traits.Components;

[RegisterComponent]
public sealed partial class RandomUnrevivableComponent : Component
{
    /// <summary>
    /// The starting chance an entity has for becoming unrevivable. This value is lowered by 0.1 every roll.
    /// </summary>
    [DataField]
    public float Chance = 0.5f;

    [DataField]
    public bool Unrevivable = false;

    /// <summary>
    /// Decides if health analyzers display an unrevivable alert after the entity is deemed unrevivable.
    /// </summary>
    [DataField]
    public bool Analyzable = true;
}
