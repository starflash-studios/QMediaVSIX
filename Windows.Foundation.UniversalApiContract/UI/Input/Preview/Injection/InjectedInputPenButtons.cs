// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.Preview.Injection.InjectedInputPenButtons
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Input.Preview.Injection
{
  /// <summary>Specifies the pen options used to simulate pen input through InjectedInputPenInfo.</summary>
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Flags]
  public enum InjectedInputPenButtons : uint
  {
    /// <summary>No pen buttons are pressed. Default.</summary>
    None = 0,
    /// <summary>The barrel button is pressed.</summary>
    Barrel = 1,
    /// <summary>The pen is inverted.</summary>
    Inverted = 2,
    /// <summary>The eraser button is pressed.</summary>
    Eraser = 4,
  }
}
