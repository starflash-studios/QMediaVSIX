// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Core.ICoreApplicationView6
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.System;

namespace Windows.ApplicationModel.Core
{
  [ExclusiveTo(typeof (CoreApplicationView))]
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  [WebHostHidden]
  [Guid(3239695514, 1657, 18874, 128, 63, 183, 156, 92, 243, 76, 202)]
  internal interface ICoreApplicationView6
  {
    DispatcherQueue DispatcherQueue { get; }
  }
}
