﻿// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Store.Preview.InstallControl.IAppInstallItem2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Store.Preview.InstallControl
{
  [ExclusiveTo(typeof (AppInstallItem))]
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  [Guid(3549899512, 16576, 20439, 170, 108, 10, 161, 60, 166, 24, 140)]
  internal interface IAppInstallItem2
  {
    [Overload("CancelWithTelemetry")]
    void Cancel(string correlationVector);

    [Overload("PauseWithTelemetry")]
    void Pause(string correlationVector);

    [Overload("RestartWithTelemetry")]
    void Restart(string correlationVector);
  }
}