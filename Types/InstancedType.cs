namespace QMediaVSIX.Commands;

[InstanceProvider(nameof(Instance), "Init")]
public abstract class InstancedType {
    // ReSharper disable once ReplaceAutoPropertyWithComputedProperty
    public static InstancedType? Instance { get; } = null;

    ///// <summary>
    ///// Constructor used for <see cref="Instance"/> construction and initialisation.
    ///// </summary>
    ///// <returns>A newly constructed <see cref="InstancedType"/>.</returns>
    //public abstract InstancedType Init();
}