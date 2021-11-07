// Decompiled with JetBrains decompiler
// Type: Windows.Storage.SystemMediaProperties
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Storage
{
  /// <summary>A helper object that provides indexing names for Windows media file properties.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class SystemMediaProperties : ISystemMediaProperties
  {
    /// <summary>Gets the name of the System.Media.Duration property (one of the Windows media file properties.</summary>
    /// <returns>The name of the System.Media.Duration file property.</returns>
    public extern string Duration { [MethodImpl] get; }

    /// <summary>Gets the name of the System.Media.Producer property (one of the Windows media file properties.</summary>
    /// <returns>The name of the System.Media.Producer file property.</returns>
    public extern string Producer { [MethodImpl] get; }

    /// <summary>Gets the name of the System.Media.Publisher property (one of the Windows media file properties.</summary>
    /// <returns>The name of the System.Media.Publisher file property.</returns>
    public extern string Publisher { [MethodImpl] get; }

    /// <summary>Gets the name of the System.Media.SubTitle property (one of the Windows media file properties.</summary>
    /// <returns>The name of the System.Media.SubTitle file property.</returns>
    public extern string SubTitle { [MethodImpl] get; }

    /// <summary>Gets the name of the System.Media.Writer property (one of the Windows media file properties.</summary>
    /// <returns>The name of the System.Media.Writer file property.</returns>
    public extern string Writer { [MethodImpl] get; }

    /// <summary>Gets the name of the System.Media.Year property (one of the Windows media file properties.</summary>
    /// <returns>The name of the System.Media.Year file property.</returns>
    public extern string Year { [MethodImpl] get; }
  }
}
