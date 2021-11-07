// Decompiled with JetBrains decompiler
// Type: Windows.Networking.BackgroundTransfer.BackgroundTransferError
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Web;

namespace Windows.Networking.BackgroundTransfer
{
  /// <summary>Used to provide errors encountered during a transfer operation.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [Static(typeof (IBackgroundTransferErrorStaticMethods), 65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.Both)]
  public static class BackgroundTransferError
  {
    /// <summary>Gets the specific error using the returned **HRESULT** value. Possible values are defined by WebErrorStatus.</summary>
    /// <param name="hresult">An **HRESULT** returned during the operation.</param>
    /// <returns>The error encountered.</returns>
    [MethodImpl]
    public static extern WebErrorStatus GetStatus(int hresult);
  }
}
