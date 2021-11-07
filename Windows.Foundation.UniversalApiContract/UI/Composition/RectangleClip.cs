﻿// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.RectangleClip
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Foundation.Numerics;

namespace Windows.UI.Composition
{
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 786432)]
  [WebHostHidden]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class RectangleClip : CompositionClip, IRectangleClip
  {
    public extern float Bottom { [MethodImpl] get; [MethodImpl] set; }

    public extern Vector2 BottomLeftRadius { [MethodImpl] get; [MethodImpl] set; }

    public extern Vector2 BottomRightRadius { [MethodImpl] get; [MethodImpl] set; }

    public extern float Left { [MethodImpl] get; [MethodImpl] set; }

    public extern float Right { [MethodImpl] get; [MethodImpl] set; }

    public extern float Top { [MethodImpl] get; [MethodImpl] set; }

    public extern Vector2 TopLeftRadius { [MethodImpl] get; [MethodImpl] set; }

    public extern Vector2 TopRightRadius { [MethodImpl] get; [MethodImpl] set; }
  }
}