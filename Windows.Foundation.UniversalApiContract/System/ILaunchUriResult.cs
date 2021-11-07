// Decompiled with JetBrains decompiler
// Type: Windows.System.ILaunchUriResult
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.System
{
  [ExclusiveTo(typeof (LaunchUriResult))]
  [Guid(3962022111, 63189, 17866, 145, 58, 112, 164, 12, 92, 130, 33)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface ILaunchUriResult
  {
    LaunchUriStatus Status { get; }

    ValueSet Result { get; }
  }
}
