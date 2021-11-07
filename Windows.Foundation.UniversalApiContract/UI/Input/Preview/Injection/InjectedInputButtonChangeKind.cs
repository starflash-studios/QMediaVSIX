// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.Preview.Injection.InjectedInputButtonChangeKind
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Input.Preview.Injection
{
  /// <summary>Specifies the changes in state of a button associated with a pointer.</summary>
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  public enum InjectedInputButtonChangeKind
  {
    /// <summary>No change in button state. Default.</summary>
    None,
    /// <summary>Indicates a primary action is initiated.</summary>
    FirstButtonDown,
    /// <summary>Indicates a primary action is complete.</summary>
    FirstButtonUp,
    /// <summary>Indicates a secondary action is initiated.</summary>
    SecondButtonDown,
    /// <summary>Indicates a secondary action is complete.</summary>
    SecondButtonUp,
    /// <summary>Indicates a third action is initiated.A touch pointer does not use this flag.</summary>
    ThirdButtonDown,
    /// <summary>Indicates a third action is complete.</summary>
    ThirdButtonUp,
    /// <summary>Indicates a fourth action is initiated.</summary>
    FourthButtonDown,
    /// <summary>Indicates a fourth action is complete.</summary>
    FourthButtonUp,
    /// <summary>Indicates a fifth action is initiated.</summary>
    FifthButtonDown,
    /// <summary>Indicates a fifth action is complete.</summary>
    FifthButtonUp,
  }
}
