﻿// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Input.IInputScopeName
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Input
{
  [ExclusiveTo(typeof (InputScopeName))]
  [Guid(4248725911, 2299, 19642, 160, 33, 121, 45, 117, 137, 253, 90)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IInputScopeName
  {
    InputScopeNameValue NameValue { get; set; }
  }
}