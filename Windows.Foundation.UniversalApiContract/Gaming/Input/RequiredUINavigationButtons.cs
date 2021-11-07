// Decompiled with JetBrains decompiler
// Type: Windows.Gaming.Input.RequiredUINavigationButtons
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Gaming.Input
{
  /// <summary>Specifies the buttons that are required to be available on a controller that appears as a navigation controller.</summary>
  [Flags]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  public enum RequiredUINavigationButtons : uint
  {
    /// <summary>No required buttons.</summary>
    None = 0,
    /// <summary>Menu button is required.</summary>
    Menu = 1,
    /// <summary>View button is required.</summary>
    View = 2,
    /// <summary>Accept button is required.</summary>
    Accept = 4,
    /// <summary>Cancel button is required.</summary>
    Cancel = 8,
    /// <summary>Up button is required.</summary>
    Up = 16, // 0x00000010
    /// <summary>Down button is required.</summary>
    Down = 32, // 0x00000020
    /// <summary>Left button is required.</summary>
    Left = 64, // 0x00000040
    /// <summary>Right button is required.</summary>
    Right = 128, // 0x00000080
  }
}
