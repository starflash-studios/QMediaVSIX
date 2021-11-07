// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.DataTransfer.IShareProvidersRequestedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.DataTransfer
{
  [ExclusiveTo(typeof (ShareProvidersRequestedEventArgs))]
  [Guid(4169724758, 41976, 20430, 133, 228, 136, 38, 230, 59, 231, 153)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  internal interface IShareProvidersRequestedEventArgs
  {
    IVector<ShareProvider> Providers { get; }

    DataPackageView Data { get; }

    Deferral GetDeferral();
  }
}
