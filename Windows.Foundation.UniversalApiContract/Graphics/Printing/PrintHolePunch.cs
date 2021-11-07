// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Printing.PrintHolePunch
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Graphics.Printing
{
  /// <summary>Specifies the hole punch option.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum PrintHolePunch
  {
    /// <summary>The default hole punch option.</summary>
    Default,
    /// <summary>An unsupported hole punch option.</summary>
    NotAvailable,
    /// <summary>A custom hole punch option that is specific to the print device.</summary>
    PrinterCustom,
    /// <summary>The option to indicate that hole punching is not required.</summary>
    None,
    /// <summary>The option to indicate that hole punching required along the left edges of the sheets.</summary>
    LeftEdge,
    /// <summary>The option to indicate that hole punching required along the right edges of the sheets.</summary>
    RightEdge,
    /// <summary>The option to indicate that hole punching required along the top edges of the sheets.</summary>
    TopEdge,
    /// <summary>The option to indicate that hole punching required along the bottom edges of the sheets.</summary>
    BottomEdge,
  }
}
