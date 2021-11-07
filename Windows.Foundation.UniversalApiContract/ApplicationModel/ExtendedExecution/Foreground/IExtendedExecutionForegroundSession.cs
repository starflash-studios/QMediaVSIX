// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.ExtendedExecution.Foreground.IExtendedExecutionForegroundSession
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.ExtendedExecution.Foreground
{
  [ExclusiveTo(typeof (ExtendedExecutionForegroundSession))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(4227088609, 40208, 16897, 176, 30, 200, 50, 117, 41, 111, 46)]
  internal interface IExtendedExecutionForegroundSession : IClosable
  {
    string Description { get; set; }

    event TypedEventHandler<object, ExtendedExecutionForegroundRevokedEventArgs> Revoked;

    [RemoteAsync]
    IAsyncOperation<ExtendedExecutionForegroundResult> RequestExtensionAsync();

    ExtendedExecutionForegroundReason Reason { get; set; }
  }
}
