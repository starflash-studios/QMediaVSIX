﻿// Decompiled with JetBrains decompiler
// Type: Windows.UI.ViewManagement.IApplicationViewConsolidatedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.ViewManagement
{
  [Guid(1363429868, 32418, 19943, 166, 166, 125, 251, 170, 235, 182, 251)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (ApplicationViewConsolidatedEventArgs))]
  internal interface IApplicationViewConsolidatedEventArgs
  {
    bool IsUserInitiated { get; }
  }
}