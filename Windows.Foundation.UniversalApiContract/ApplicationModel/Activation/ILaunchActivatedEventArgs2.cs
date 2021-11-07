// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Activation.ILaunchActivatedEventArgs2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Activation
{
  /// <summary>Provides additional information about the tile that launched your app.</summary>
  [Guid(265518780, 40393, 18101, 154, 206, 189, 149, 212, 86, 83, 69)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  public interface ILaunchActivatedEventArgs2 : ILaunchActivatedEventArgs, IActivatedEventArgs
  {
    /// <summary>Gets additional information that is provided when the user launches your app from a tile. This will be **null** if the app is not launched from its tile or if the app is launched on a platform that doesn't support this property.</summary>
    /// <returns>Information about the tile that launched the app.</returns>
    TileActivatedInfo TileActivatedInfo { get; }
  }
}
