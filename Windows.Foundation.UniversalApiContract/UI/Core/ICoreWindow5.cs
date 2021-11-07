// Decompiled with JetBrains decompiler
// Type: Windows.UI.Core.ICoreWindow5
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.System;

namespace Windows.UI.Core
{
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  [ExclusiveTo(typeof (CoreWindow))]
  [Guid(1263198689, 11885, 20138, 189, 161, 28, 92, 193, 190, 225, 65)]
  [WebHostHidden]
  internal interface ICoreWindow5
  {
    DispatcherQueue DispatcherQueue { get; }

    CoreWindowActivationMode ActivationMode { get; }
  }
}
