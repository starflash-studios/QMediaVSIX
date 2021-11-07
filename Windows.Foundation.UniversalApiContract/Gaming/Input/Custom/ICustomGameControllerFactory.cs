// Decompiled with JetBrains decompiler
// Type: Windows.Gaming.Input.Custom.ICustomGameControllerFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Gaming.Input.Custom
{
  /// <summary>Represents a factory for creating a custom controller type.</summary>
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Guid(1772138078, 30094, 19646, 172, 230, 98, 21, 95, 233, 18, 111)]
  [WebHostHidden]
  public interface ICustomGameControllerFactory
  {
    /// <summary>Creates an instance of a game controller.</summary>
    /// <param name="provider">The controller provider for the controller.</param>
    /// <returns>The created object.</returns>
    object CreateGameController(IGameControllerProvider provider);

    /// <summary>Event raised when the controller is added.</summary>
    /// <param name="value">The added controller.</param>
    void OnGameControllerAdded(IGameController value);

    /// <summary>Event raised when the controller is removed.</summary>
    /// <param name="value">The removed controller.</param>
    void OnGameControllerRemoved(IGameController value);
  }
}
