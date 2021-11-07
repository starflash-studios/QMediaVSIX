// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Activation.IShareTargetActivatedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.ApplicationModel.DataTransfer.ShareTarget;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Activation
{
  /// <summary>Provides information for an application that is a target for share operations.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1272641992, 52658, 19147, 191, 195, 102, 72, 86, 51, 120, 236)]
  public interface IShareTargetActivatedEventArgs : IActivatedEventArgs
  {
    /// <summary>Contains information about data included in a share operation.</summary>
    /// <returns>An object that includes the data included in a send operation.</returns>
    ShareOperation ShareOperation { get; }
  }
}
