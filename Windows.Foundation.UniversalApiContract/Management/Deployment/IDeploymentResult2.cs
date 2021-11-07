// Decompiled with JetBrains decompiler
// Type: Windows.Management.Deployment.IDeploymentResult2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Management.Deployment
{
  [ExclusiveTo(typeof (DeploymentResult))]
  [Guid(4228804956, 23041, 19415, 188, 241, 56, 28, 140, 130, 224, 74)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  internal interface IDeploymentResult2
  {
    bool IsRegistered { get; }
  }
}
