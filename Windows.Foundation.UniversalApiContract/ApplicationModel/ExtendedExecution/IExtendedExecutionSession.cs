// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.ExtendedExecution.IExtendedExecutionSession
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.ExtendedExecution
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2945485357, 4491, 18673, 147, 8, 12, 79, 196, 30, 32, 15)]
  [ExclusiveTo(typeof (ExtendedExecutionSession))]
  internal interface IExtendedExecutionSession : IClosable
  {
    ExtendedExecutionReason Reason { get; set; }

    string Description { get; set; }

    uint PercentProgress { get; set; }

    event TypedEventHandler<object, ExtendedExecutionRevokedEventArgs> Revoked;

    [RemoteAsync]
    IAsyncOperation<ExtendedExecutionResult> RequestExtensionAsync();
  }
}
