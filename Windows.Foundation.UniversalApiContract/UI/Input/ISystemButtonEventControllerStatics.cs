// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.ISystemButtonEventControllerStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.System;

namespace Windows.UI.Input
{
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 655360)]
  [Guid(1664069755, 8381, 24085, 175, 74, 0, 219, 242, 6, 79, 250)]
  [ExclusiveTo(typeof (SystemButtonEventController))]
  internal interface ISystemButtonEventControllerStatics
  {
    SystemButtonEventController CreateForDispatcherQueue(
      DispatcherQueue queue);
  }
}
