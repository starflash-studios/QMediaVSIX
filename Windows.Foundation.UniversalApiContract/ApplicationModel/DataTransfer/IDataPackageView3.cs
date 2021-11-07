// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.DataTransfer.IDataPackageView3
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Security.EnterpriseData;

namespace Windows.ApplicationModel.DataTransfer
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (DataPackageView))]
  [Guid(3547820456, 56749, 17032, 132, 40, 209, 202, 227, 148, 18, 139)]
  internal interface IDataPackageView3
  {
    [Overload("RequestAccessAsync")]
    IAsyncOperation<ProtectionPolicyEvaluationResult> RequestAccessAsync();

    [Overload("RequestAccessWithEnterpriseIdAsync")]
    IAsyncOperation<ProtectionPolicyEvaluationResult> RequestAccessAsync(
      string enterpriseId);

    ProtectionPolicyEvaluationResult UnlockAndAssumeEnterpriseIdentity();
  }
}
