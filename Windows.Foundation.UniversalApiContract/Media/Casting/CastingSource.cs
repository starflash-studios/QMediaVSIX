// Decompiled with JetBrains decompiler
// Type: Windows.Media.Casting.CastingSource
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Casting
{
  /// <summary>Represents the media content that can be sent to another device.</summary>
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 167772160)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class CastingSource : ICastingSource
  {
    /// <summary>Gets or sets an alternative URI for the content for use with DLNA ByRef.</summary>
    /// <returns>The alternative URI for the content.</returns>
    public extern Uri PreferredSourceUri { [MethodImpl] get; [MethodImpl] set; }
  }
}
