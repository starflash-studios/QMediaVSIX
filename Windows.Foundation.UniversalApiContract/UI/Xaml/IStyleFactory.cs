﻿// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.IStyleFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Interop;

namespace Windows.UI.Xaml
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [Guid(2741511395, 15745, 19685, 170, 81, 139, 65, 15, 96, 47, 205)]
  [ExclusiveTo(typeof (Style))]
  internal interface IStyleFactory
  {
    Style CreateInstance(TypeName targetType);
  }
}