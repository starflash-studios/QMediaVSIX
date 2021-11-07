// Decompiled with JetBrains decompiler
// Type: Windows.System.IAppResourceGroupBackgroundTaskReport
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System
{
  [Guid(627500878, 45149, 16578, 157, 193, 26, 79, 3, 158, 161, 32)]
  [ExclusiveTo(typeof (AppResourceGroupBackgroundTaskReport))]
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  internal interface IAppResourceGroupBackgroundTaskReport
  {
    Guid TaskId { get; }

    string Name { get; }

    string Trigger { get; }

    string EntryPoint { get; }
  }
}
