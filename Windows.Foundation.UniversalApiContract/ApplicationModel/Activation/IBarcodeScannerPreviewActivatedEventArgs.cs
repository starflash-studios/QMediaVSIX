// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Activation.IBarcodeScannerPreviewActivatedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Activation
{
  /// <summary>Describes event arguments used in activating the barcode scanner preview.</summary>
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  [Guid(1735555452, 39359, 17225, 175, 34, 228, 18, 53, 96, 55, 28)]
  public interface IBarcodeScannerPreviewActivatedEventArgs : IActivatedEventArgs
  {
    /// <summary>Gets a connection ID used to match the service connection.</summary>
    /// <returns>A connection ID.</returns>
    string ConnectionId { get; }
  }
}
