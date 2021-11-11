namespace QMediaVSIX.Commands;

[InstanceProvider(nameof(Instance), "InitAsync")]
public abstract class AsynchronousInstancedType {
    // ReSharper disable once ReplaceAutoPropertyWithComputedProperty
    public static AsynchronousInstancedType? Instance { get; } = null;

    ///// <summary>
    ///// Constructor used for <see cref="Instance"/> construction and initialisation.
    ///// </summary>
    ///// <returns>A newly constructed <see cref="InstancedType"/>.</returns>
    //public abstract Task<AsynchronousInstancedType> InitAsync();
}