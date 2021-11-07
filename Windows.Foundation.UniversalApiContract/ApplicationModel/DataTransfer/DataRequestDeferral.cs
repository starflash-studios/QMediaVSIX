// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.DataTransfer.DataRequestDeferral
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.DataTransfer
{
  /// <summary>Enables you to exchange content with a target app asynchronously.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class DataRequestDeferral : IDataRequestDeferral
  {
    /// <summary>Indicates that the content for an asynchronous share is ready for a target app, or that an error in the sharing operation occurred.</summary>
    [MethodImpl]
    public extern void Complete();
  }
}
