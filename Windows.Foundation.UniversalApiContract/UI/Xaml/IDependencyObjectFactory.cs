﻿// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.IDependencyObjectFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml
{
  [Guid(2583932818, 32138, 18743, 136, 79, 236, 243, 79, 224, 42, 203)]
  [WebHostHidden]
  [ExclusiveTo(typeof (DependencyObject))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IDependencyObjectFactory
  {
    DependencyObject CreateInstance(object baseInterface, out object innerInterface);
  }
}