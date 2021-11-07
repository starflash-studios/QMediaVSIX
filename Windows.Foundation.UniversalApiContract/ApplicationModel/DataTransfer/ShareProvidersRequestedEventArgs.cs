// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.DataTransfer.ShareProvidersRequestedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.DataTransfer
{
  /// <summary>The event args of ShareProvidersRequested.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  public sealed class ShareProvidersRequestedEventArgs : IShareProvidersRequestedEventArgs
  {
    /// <summary>Gets the share providers.</summary>
    /// <returns>
    /// </returns>
    public extern IVector<ShareProvider> Providers { [MethodImpl] get; }

    /// <summary>Gets the data.</summary>
    /// <returns>The data.</returns>
    public extern DataPackageView Data { [MethodImpl] get; }

    /// <summary>Requests a deferral to complete actions on this object in an event handler.</summary>
    /// <returns>The deferral.</returns>
    [MethodImpl]
    public extern Deferral GetDeferral();
  }
}
