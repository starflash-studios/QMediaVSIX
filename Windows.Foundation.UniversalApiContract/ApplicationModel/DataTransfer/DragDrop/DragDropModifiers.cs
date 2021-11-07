// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.DataTransfer.DragDrop.DragDropModifiers
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.DataTransfer.DragDrop
{
  /// <summary>Represents the key modifiers applied to a drag and drop operation. Zero or more modifiers can be included.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Flags]
  [WebHostHidden]
  public enum DragDropModifiers : uint
  {
    /// <summary>No modifiers.</summary>
    None = 0,
    /// <summary>The shift key.</summary>
    Shift = 1,
    /// <summary>The control key.</summary>
    Control = 2,
    /// <summary>The alt key.</summary>
    Alt = 4,
    /// <summary>The left mouse button.</summary>
    LeftButton = 8,
    /// <summary>The middle mouse button.</summary>
    MiddleButton = 16, // 0x00000010
    /// <summary>The right mouse button.</summary>
    RightButton = 32, // 0x00000020
  }
}
