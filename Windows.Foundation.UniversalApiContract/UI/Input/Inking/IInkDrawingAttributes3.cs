﻿// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.Inking.IInkDrawingAttributes3
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Input.Inking
{
  [Guid(1912733698, 32091, 18064, 138, 244, 230, 100, 203, 226, 183, 79)]
  [ExclusiveTo(typeof (InkDrawingAttributes))]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  internal interface IInkDrawingAttributes3
  {
    InkDrawingAttributesKind Kind { get; }

    InkDrawingAttributesPencilProperties PencilProperties { get; }
  }
}