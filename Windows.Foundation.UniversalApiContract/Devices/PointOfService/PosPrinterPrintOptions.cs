// Decompiled with JetBrains decompiler
// Type: Windows.Devices.PointOfService.PosPrinterPrintOptions
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.PointOfService
{
  /// <summary>Represents the print options of the text that you want to print to a point-of-service printer.</summary>
  [ContractVersion(typeof (UniversalApiContract), 524288)]
  [Threading(ThreadingModel.Both)]
  [DualApiPartition(version = 1)]
  [Activatable(524288, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class PosPrinterPrintOptions : IPosPrinterPrintOptions
  {
    /// <summary>Creates an instance of PosPrinterPrintOptions.</summary>
    [MethodImpl]
    public extern PosPrinterPrintOptions();

    /// <summary>Gets or sets a string value that indicates the typeface that the application wants to use for printing characters.</summary>
    /// <returns>The typeface that the application wants to use for printing characters.</returns>
    public extern string TypeFace { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a numeric value that indicates the character height that the application wants to use for printing characters.</summary>
    /// <returns>The character height that the application wants to use for printing characters. The value must be 0 or one of the supported height values of the font if the font is not scalable.</returns>
    public extern uint CharacterHeight { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that indicates if the application wants to print characters in bold style.</summary>
    /// <returns>True if the application wants to print characters in bold style; otherwise, false.</returns>
    public extern bool Bold { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that indicates if the application wants to print characters in italic style.</summary>
    /// <returns>True if the application wants to print characters in italic style; otherwise, false.</returns>
    public extern bool Italic { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that indicates if the application wants to print characters in underline style.</summary>
    /// <returns>True if the application wants to print characters in underline style; otherwise, false.</returns>
    public extern bool Underline { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that indicates if the application wants to print characters in reverse-video style.</summary>
    /// <returns>True if the application wants to print characters in reverse-video style; otherwise, false.</returns>
    public extern bool ReverseVideo { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that indicates if the application wants to print characters in strikethrough style.</summary>
    /// <returns>True if the application wants to print characters in strikethrough style; otherwise, false.</returns>
    public extern bool Strikethrough { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that indicates if the application wants to print characters in superscript style.</summary>
    /// <returns>True if the application wants to print characters in superscript style; otherwise, false.</returns>
    public extern bool Superscript { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that indicates if the application wants to print characters in subscript style.</summary>
    /// <returns>True if the application wants to print characters in subscript style; otherwise, false.</returns>
    public extern bool Subscript { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that indicates if the application wants to print characters in double-wide style.</summary>
    /// <returns>True if the application wants to print characters in double-wide style; otherwise, false.</returns>
    public extern bool DoubleWide { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that indicates if the application wants to print characters in double-high style.</summary>
    /// <returns>True if the application wants to print characters in double-high style; otherwise, false.</returns>
    public extern bool DoubleHigh { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that indicates the alignment that the application wants to use for printing text.</summary>
    /// <returns>The alignment that the application wants to use for printing text.</returns>
    public extern PosPrinterAlignment Alignment { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a numeric value that indicates the character set that the application wants to use for printing characters.</summary>
    /// <returns>The character set that the application wants to use for printing characters. The value must be 0 or one of the supported character set values of the point-of-service printer.</returns>
    public extern uint CharacterSet { [MethodImpl] get; [MethodImpl] set; }
  }
}
