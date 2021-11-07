// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Activation.ICachedFileUpdaterActivatedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Provider;

namespace Windows.ApplicationModel.Activation
{
  /// <summary>Provides information about the activated event that fires when the user saves a file that requires content management from the app.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3496915399, 14341, 20171, 183, 87, 108, 241, 94, 38, 254, 243)]
  public interface ICachedFileUpdaterActivatedEventArgs : IActivatedEventArgs
  {
    /// <summary>The letterbox UI of the file picker that is displayed when a file requires content management from the app.</summary>
    /// <returns>The letterbox UI of the file picker that is displayed when a file requires content management from the app.</returns>
    CachedFileUpdaterUI CachedFileUpdaterUI { get; }
  }
}
