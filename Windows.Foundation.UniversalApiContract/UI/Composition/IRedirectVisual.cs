﻿// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.IRedirectVisual
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Composition
{
  [WebHostHidden]
  [Guid(2361844544, 35701, 21538, 176, 111, 9, 255, 233, 248, 97, 126)]
  [ExclusiveTo(typeof (RedirectVisual))]
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  internal interface IRedirectVisual
  {
    Visual Source { get; set; }
  }
}