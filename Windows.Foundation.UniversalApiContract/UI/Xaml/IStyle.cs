﻿// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.IStyle
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Interop;

namespace Windows.UI.Xaml
{
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (Style))]
  [Guid(3299471909, 40375, 19069, 182, 209, 247, 78, 219, 146, 147, 194)]
  internal interface IStyle
  {
    bool IsSealed { get; }

    SetterBaseCollection Setters { get; }

    TypeName TargetType { get; set; }

    Style BasedOn { get; set; }

    void Seal();
  }
}