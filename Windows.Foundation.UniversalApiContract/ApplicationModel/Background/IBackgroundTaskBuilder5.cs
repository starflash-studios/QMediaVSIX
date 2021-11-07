// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Background.IBackgroundTaskBuilder5
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Background
{
  [ContractVersion(typeof (UniversalApiContract), 655360)]
  [Guid(124847094, 39413, 19188, 188, 173, 71, 49, 208, 51, 13, 67)]
  [ExclusiveTo(typeof (BackgroundTaskBuilder))]
  internal interface IBackgroundTaskBuilder5
  {
    void SetTaskEntryPointClsid(Guid TaskEntryPoint);
  }
}
