// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Background.IBackgroundTaskProgressEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Background
{
  [ExclusiveTo(typeof (BackgroundTaskProgressEventArgs))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(4212418732, 33586, 19722, 149, 50, 3, 234, 230, 132, 218, 49)]
  internal interface IBackgroundTaskProgressEventArgs
  {
    Guid InstanceId { get; }

    uint Progress { get; }
  }
}
