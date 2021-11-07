// Decompiled with JetBrains decompiler
// Type: Windows.Management.Deployment.IDeploymentResult
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Management.Deployment
{
  [Guid(627292590, 46973, 19487, 138, 123, 32, 230, 173, 81, 94, 243)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (DeploymentResult))]
  internal interface IDeploymentResult
  {
    string ErrorText { get; }

    Guid ActivityId { get; }

    HResult ExtendedErrorCode { get; }
  }
}
