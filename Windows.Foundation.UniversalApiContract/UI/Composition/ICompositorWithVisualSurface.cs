﻿// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.ICompositorWithVisualSurface
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Composition
{
  [ContractVersion(typeof (UniversalApiContract), 524288)]
  [Guid(3483461003, 291, 17745, 136, 145, 137, 189, 204, 64, 50, 43)]
  [ExclusiveTo(typeof (Compositor))]
  [WebHostHidden]
  internal interface ICompositorWithVisualSurface
  {
    CompositionVisualSurface CreateVisualSurface();
  }
}