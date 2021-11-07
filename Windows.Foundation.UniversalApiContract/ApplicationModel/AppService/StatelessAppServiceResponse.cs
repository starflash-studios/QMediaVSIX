// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.AppService.StatelessAppServiceResponse
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.AppService
{
  /// <summary>The response to an SendStatelessMessageAsync call, containing the response message and connection status.</summary>
  [ContractVersion(typeof (UniversalApiContract), 524288)]
  [DualApiPartition(version = 1)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class StatelessAppServiceResponse : IStatelessAppServiceResponse
  {
    /// <summary>The response to the the SendStatelessMessageAsync operation.</summary>
    /// <returns>The response to the the SendStatelessMessageAsync operation.</returns>
    public extern ValueSet Message { [MethodImpl] get; }

    /// <summary>The response status.</summary>
    /// <returns>The response status.</returns>
    public extern StatelessAppServiceResponseStatus Status { [MethodImpl] get; }
  }
}
