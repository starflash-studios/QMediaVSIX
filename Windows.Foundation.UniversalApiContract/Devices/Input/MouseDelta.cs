﻿// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Input.MouseDelta
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Input
{
  /// <summary>Identifies the change in screen location of the mouse pointer, relative to the location of the last mouse event.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public struct MouseDelta
  {
    /// <summary>The x-coordinate of the mouse pointer, relative to the location of the last mouse event.</summary>
    public int X;
    /// <summary>The y-coordinate of the mouse pointer, relative to the location of the last mouse event.</summary>
    public int Y;
  }
}