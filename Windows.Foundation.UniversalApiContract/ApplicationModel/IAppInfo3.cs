﻿// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.IAppInfo3
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel
{
  [ExclusiveTo(typeof (AppInfo))]
  [Guid(161975878, 37796, 18142, 147, 151, 8, 67, 181, 113, 21, 234)]
  [ContractVersion(typeof (UniversalApiContract), 720896)]
  internal interface IAppInfo3
  {
    AppExecutionContext ExecutionContext { get; }
  }
}