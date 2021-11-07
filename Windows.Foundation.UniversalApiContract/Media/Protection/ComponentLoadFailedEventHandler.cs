// Decompiled with JetBrains decompiler
// Type: Windows.Media.Protection.ComponentLoadFailedEventHandler
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Protection
{
  /// <summary>Represents the method that handles the data passed by the MediaProtectionManager when a load of binary data fails.</summary>
  /// <param name="sender">Contains the MediaProtectionManager object that was loading the binary data when the load failed.</param>
  /// <param name="e">Contains event data for a MediaProtectionManager object when the load of binary data fails.</param>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2514117692, 28089, 16971, 134, 202, 9, 26, 244, 50, 8, 28)]
  public delegate void ComponentLoadFailedEventHandler(
    MediaProtectionManager sender,
    ComponentLoadFailedEventArgs e);
}
