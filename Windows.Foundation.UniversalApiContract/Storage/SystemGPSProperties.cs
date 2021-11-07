// Decompiled with JetBrains decompiler
// Type: Windows.Storage.SystemGPSProperties
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Storage
{
  /// <summary>A helper object that provides indexing names for GPS file properties.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class SystemGPSProperties : ISystemGPSProperties
  {
    /// <summary>Gets the name of the property (one of the GPS file properties.</summary>
    /// <returns>The name of the file property.</returns>
    public extern string LatitudeDecimal { [MethodImpl] get; }

    /// <summary>Gets the name of the property (one of the GPS file properties.</summary>
    /// <returns>The name of the file property.</returns>
    public extern string LongitudeDecimal { [MethodImpl] get; }
  }
}
