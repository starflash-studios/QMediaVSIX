// Decompiled with JetBrains decompiler
// Type: Windows.Storage.SystemImageProperties
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Storage
{
  /// <summary>A helper object that provides indexing names for Windows image file properties.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class SystemImageProperties : ISystemImageProperties
  {
    /// <summary>Gets the name of the System.Image.HorizontalSize property (one of the Windows image file properties.</summary>
    /// <returns>The name of the System.Image.HorizontalSize file property.</returns>
    public extern string HorizontalSize { [MethodImpl] get; }

    /// <summary>Gets the name of the System.Image.VerticalSize property (one of the Windows image file properties ).</summary>
    /// <returns>The name of the System.Image.VerticalSize file property.</returns>
    public extern string VerticalSize { [MethodImpl] get; }
  }
}
