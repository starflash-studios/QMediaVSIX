// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.DataTransfer.IShareProviderOperation
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.DataTransfer
{
  [Guid(432994615, 54325, 16761, 182, 175, 20, 224, 73, 43, 105, 246)]
  [ExclusiveTo(typeof (ShareProviderOperation))]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  internal interface IShareProviderOperation
  {
    DataPackageView Data { get; }

    ShareProvider Provider { get; }

    void ReportCompleted();
  }
}
