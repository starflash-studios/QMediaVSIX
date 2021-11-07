// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Activation.ILaunchActivatedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Activation
{
  /// <summary>Provides event information when an app is launched.</summary>
  [Guid(4224269862, 41290, 19279, 130, 176, 51, 190, 217, 32, 175, 82)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public interface ILaunchActivatedEventArgs : IActivatedEventArgs
  {
    /// <summary>Gets the arguments that are passed to the app during its launch activation.</summary>
    /// <returns>The list of arguments.</returns>
    string Arguments { get; }

    /// <summary>Gets the ID of the tile that was invoked to launch the app.</summary>
    /// <returns>The ID of the tile that launched the app. If the app's main tile was used, this value is "App". If a secondary tile is used, the SecondaryTile.TileId value, assigned to the secondary tile when it was created, is returned.</returns>
    string TileId { get; }
  }
}
